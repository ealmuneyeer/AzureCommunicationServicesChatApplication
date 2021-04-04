using Azure;
using Azure.Communication;
using Azure.Communication.Chat;
using Azure.Communication.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class frmChat : Form
    {
        private AppConfig _appConfig;

        private CommunicationIdentityClient _commIdentityClient;

        private ChatParticipant _chatParticipant;
        private ChatThreadClient _chatThreadClient;

        private ReaderWriterLockSlim _rwl = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        private System.Timers.Timer _refreshChatThreadTimer;
        private DateTimeOffset? _lastChatThreadRefreshTime = null;

        private class ChatMessageType
        {
            public const string Text = "text";
            public const string Html = "html";
            public const string TopicUpdated = "topicUpdated";
            public const string ParticipantAdded = "participantAdded";
            public const string ParticipantRemoved = "participantRemoved";
        }

        public frmChat()
        {
            InitializeComponent();

            IConfiguration configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();

            _appConfig = configuration.GetSection("appConfig").Get<AppConfig>();

            _commIdentityClient = new CommunicationIdentityClient(_appConfig.ConnectionString);

            _refreshChatThreadTimer = new System.Timers.Timer(1000);
            _refreshChatThreadTimer.AutoReset = false;
            _refreshChatThreadTimer.Elapsed += RefreshChatThreadTimer_Elapsed;
            _refreshChatThreadTimer.Start();
        }

        private async void RefreshChatThreadTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_rwl.TryEnterReadLock(5000))
            {
                if (_chatThreadClient != null)
                {
                    //DateTime beforeCalling = DateTime.Now;

                    //AsyncPageable<ChatMessage> chatMessages = _chatThreadClient.GetMessagesAsync(_lastChatThreadRefreshTime);

                    ////_lastChatThreadRefreshTime = DateTime.Now.AddSeconds(1);
                    //await foreach (ChatMessage message in chatMessages)
                    //{
                    //    WriteChatMessage(message);
                    //}

                    //DateTime afterCalling = DateTime.Now;

                    //_lastChatThreadRefreshTime = DateTime.Now; //beforeCalling == afterCalling ? afterCalling.AddSeconds(1) : afterCalling;

                    Pageable<ChatMessage> chatMessages = _chatThreadClient.GetMessages(_lastChatThreadRefreshTime);
                    DateTime tempLastCheck = DateTime.Now;
                    foreach (ChatMessage message in chatMessages)
                    {
                        WriteChatMessage(message);
                    }

                    _lastChatThreadRefreshTime = tempLastCheck; //DateTime.Now;
                }
            }

            _refreshChatThreadTimer.Start();
        }

        private void WriteChatMessage(ChatMessage message)
        {
            if (txtChatThread.InvokeRequired)
            {
                txtChatThread.Invoke(new Action(() =>
                {
                    WriteChatMessage(message);
                }));
            }
            else
            {
                string msgAction = message.EditedOn != null ? "Edit" : message.DeletedOn != null ? "Delete" : "Create";
                string msg = $"[{message.CreatedOn.LocalDateTime:dd/MM/yyyy HH:mm:ss}] [{message.Id}] [{msgAction}] {(message.SenderDisplayName == _chatParticipant.DisplayName ? "-Me-" : message.SenderDisplayName)}:{Environment.NewLine}";

                switch (message.Type.ToString())
                {
                    case ChatMessageType.Text:
                    case ChatMessageType.Html:
                        msg += message.Content.Message;
                        break;

                    case ChatMessageType.TopicUpdated:
                        msg += $"Thread topic has been updated to: '{message.Content.Topic}'";
                        break;

                    case ChatMessageType.ParticipantAdded:
                        msg += $"Participant '{message.SenderDisplayName}' add the following participants: '{string.Join(", ", message.Content.Participants.Select(p => p.DisplayName))}'";
                        break;

                    case ChatMessageType.ParticipantRemoved:
                        msg += $"Participant {message.SenderDisplayName} remove the following participants: '{string.Join(", ", message.Content.Participants.Select(p => p.DisplayName))}'";
                        break;
                }

                txtChatThread.AppendText($"{msg} {Environment.NewLine} {Environment.NewLine}");
            }
        }

        private void WriteLog(string log)
        {
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new Action(() => { WriteLog(log); }));
            }
            else
            {
                txtLogs.AppendText($"[{DateTime.Now:HH:mm:ss.fff}]: {log + Environment.NewLine}");
            }
        }

        private void UpdateChatParticipant(bool forceCreate)
        {
            if (_chatParticipant == null || forceCreate)
            {
                _chatParticipant = new ChatParticipant(new CommunicationUserIdentifier(txtUserId.Text))
                {
                    DisplayName = $"User{DateTime.Now:HHmmss}",
                };

                UpdateTitle();
            }
        }

        private void UpdateTitle()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { UpdateTitle(); }));
            }
            else
            {
                this.Text = "Chat - " + _chatParticipant.DisplayName;
            }
        }

        private ChatClient GetChatClient()
        {
            CommunicationTokenCredential communicationTokenCredential = new CommunicationTokenCredential(txtUserToken.Text);
            return new ChatClient(new Uri(_appConfig.Endpoint), communicationTokenCredential);
        }

        private async void btnGenerateToken_Click(object sender, EventArgs e)
        {
            WriteLog($"Generating token for user '{txtUserId.Text}'...");

            List<CommunicationTokenScope> scope = new List<CommunicationTokenScope>();
            if (chkScopeChat.Checked) scope.Add(CommunicationTokenScope.Chat);
            //if (chkScopePSTN.Checked) scope.Add(CommunicationTokenScope.Pstn);
            if (chkScopeVOIP.Checked) scope.Add(CommunicationTokenScope.VoIP);

            var tokenResponse = await _commIdentityClient.GetTokenAsync(new CommunicationUserIdentifier(txtUserId.Text), scope);
            txtUserToken.Text = tokenResponse.Value.Token;
            txtUserTokenExpiry.Text = tokenResponse.Value.ExpiresOn.ToString("dd/MM/yyyy HH:mm:ss");

            WriteLog($"{tokenResponse.GetRawResponse().Status}: {tokenResponse.GetRawResponse().ReasonPhrase}");
        }

        private async void btnCreateUser_Click(object sender, EventArgs e)
        {
            WriteLog("Creating user...");

            var userResponse = await _commIdentityClient.CreateUserAsync();
            txtUserId.Text = userResponse.Value.Id;

            //WriteLog($"User '{userResponse.Value.Id}' has been created");
            //WriteLog($"User '{userResponse.Value.Id}' has been created. Status: {userResponse.GetRawResponse().Status} -  {userResponse.GetRawResponse().ReasonPhrase}");

            WriteLog($"Create user status: {userResponse.GetRawResponse().Status} - {userResponse.GetRawResponse().ReasonPhrase} | User Id: '{userResponse.Value.Id}'");
        }

        private async void btnRevokeTokens_Click(object sender, EventArgs e)
        {
            WriteLog($"Revoke user '{txtUserId.Text}' tokens...");

            var revokeResponse = await _commIdentityClient.RevokeTokensAsync(new CommunicationUserIdentifier(txtUserId.Text));

            WriteLog($"Revoke tokens status: {revokeResponse.Status} - {revokeResponse.ReasonPhrase}");
        }

        private async void btnCreateChatThread_Click(object sender, EventArgs e)
        {
            WriteLog("Creating chat thread...");
            ChatClient chatClient = GetChatClient();

            UpdateChatParticipant(true);

            CreateChatThreadResult createChatThreadResult = await chatClient.CreateChatThreadAsync($"New topic {DateTime.Now:HH:mm:ss}", new List<ChatParticipant>() { _chatParticipant });

            _chatThreadClient = chatClient.GetChatThreadClient(createChatThreadResult.ChatThread.Id);

            txtChatThreadID.Text = createChatThreadResult.ChatThread.Id;

            WriteLog($"Chat thread '{createChatThreadResult.ChatThread.Id}' has been created");
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            WriteLog($"Deleting user '{txtUserId.Text}'");

            var deleteResponse = await _commIdentityClient.DeleteUserAsync(new CommunicationUserIdentifier(txtUserId.Text));

            WriteLog($"User deletion status: {deleteResponse.Status} - {deleteResponse.ReasonPhrase}");
        }

        private void btnJoinChatThread_Click(object sender, EventArgs e)
        {
            WriteLog($"Joining chat thread '{txtChatThreadID.Text}'...");

            UpdateChatParticipant(true);

            ChatClient chatClient = GetChatClient();
            _chatThreadClient = chatClient.GetChatThreadClient(txtChatThreadID.Text);
            var addResult = _chatThreadClient.AddParticipant(_chatParticipant);

            WriteLog($"Join chat thread status: {addResult.Status} - {addResult.ReasonPhrase}");
        }

        private void btnListenToChatThread_Click(object sender, EventArgs e)
        {
            WriteLog($"Listen to chat thread '{txtChatThreadID.Text}'...");

            UpdateChatParticipant(true);

            ChatClient chatClient = GetChatClient();
            _chatThreadClient = chatClient.GetChatThreadClient(txtChatThreadID.Text);

            WriteLog($"Listen to chat thread '{_chatThreadClient.Id}' succeeded");
        }

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (_chatThreadClient != null)
            {
                var sendResult = _chatThreadClient.SendMessage(txtSendMsg.Text, ChatMessageType.Text, _chatParticipant.DisplayName);
                txtSendMsg.Clear();
                txtSendMsg.Focus();

                WriteLog($"Sending chat message status: {sendResult.GetRawResponse().Status} - {sendResult.GetRawResponse().ReasonPhrase}");
            }
        }

        private async void btnAddMember_Click(object sender, EventArgs e)
        {
            if (_chatThreadClient != null)
            {
                ChatParticipant chatParticipent = new ChatParticipant(new CommunicationUserIdentifier(string.IsNullOrEmpty(txtAddMemberUserId.Text) ? txtUserId.Text : txtAddMemberUserId.Text));

                WriteLog($"Adding '{(chatParticipent.User as CommunicationUserIdentifier).Id}' participant to the chat thread...");

                var addMemberResponse = _chatThreadClient.AddParticipant(chatParticipent);

                WriteLog($"Add participant status: {addMemberResponse.Status} - {addMemberResponse.ReasonPhrase}");
            }
        }

        private async void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (_chatThreadClient != null)
            {
                string userId = string.IsNullOrEmpty(txtRemoveUserUserId.Text) ? txtUserId.Text : txtRemoveUserUserId.Text;

                WriteLog($"Removing '{userId}' user from the chat thread...");

                Response removeUserResponse = _chatThreadClient.RemoveParticipant(new CommunicationUserIdentifier(userId));

                WriteLog($"Remove user status: {removeUserResponse.Status} - {removeUserResponse.ReasonPhrase}");
            }
        }

        private async void btnDeleteChatThread_Click(object sender, EventArgs e)
        {
            if (_rwl.TryEnterReadLock(5000))
            {
                WriteLog($"Delete chat thread '{txtChatThreadID.Text}'...");

                ChatClient chatClient = GetChatClient();
                var deleteResponse = await chatClient.DeleteChatThreadAsync(txtChatThreadID.Text);

                WriteLog($"Delete chat thread status: {deleteResponse.Status} - {deleteResponse.ReasonPhrase}");

                _chatThreadClient = deleteResponse.Status >= 200 && deleteResponse.Status <= 299 ? null : _chatThreadClient;
            }
        }

        private async void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            if (_chatThreadClient != null)
            {
                WriteLog($"Deleting message '{txtEditMessageId.Text}'...");

                Response deleteResponse = await _chatThreadClient.DeleteMessageAsync(txtEditMessageId.Text);

                WriteLog($"Delete message status: {deleteResponse.Status} - {deleteResponse.ReasonPhrase}");
            }
        }

        private async void btnUpdateMessage_Click(object sender, EventArgs e)
        {
            if (_chatThreadClient != null)
            {
                WriteLog($"Update message '{txtEditMessageId.Text}'...");

                Response updateResponse = await _chatThreadClient.UpdateMessageAsync(txtEditMessageId.Text, txtEditMessageMessage.Text);

                WriteLog($"Update message status: {updateResponse.Status} - {updateResponse.ReasonPhrase}");
            }
        }
    }
}
