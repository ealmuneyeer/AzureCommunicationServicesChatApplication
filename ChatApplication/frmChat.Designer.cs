namespace ChatApplication
{
    partial class frmChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnGenerateToken = new System.Windows.Forms.Button();
            this.chkScopeChat = new System.Windows.Forms.CheckBox();
            this.chkScopePSTN = new System.Windows.Forms.CheckBox();
            this.chkScopeVOIP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.chkHighPriority = new System.Windows.Forms.CheckBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.grpChatThread = new System.Windows.Forms.GroupBox();
            this.txtChatThread = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChatThreadID = new System.Windows.Forms.TextBox();
            this.btnJoinChatThread = new System.Windows.Forms.Button();
            this.btnCreateChatThread = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.grpUserToken = new System.Windows.Forms.GroupBox();
            this.txtUserTokenExpiry = new System.Windows.Forms.TextBox();
            this.txtUserToken = new System.Windows.Forms.TextBox();
            this.btnRevokeTokens = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtAddMemberUserToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddMemberUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListenToChatThread = new System.Windows.Forms.Button();
            this.grpRemoveUser = new System.Windows.Forms.GroupBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.txtRemoveUserUserId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnDeleteChatThread = new System.Windows.Forms.Button();
            this.grpSendMessage = new System.Windows.Forms.GroupBox();
            this.grpEditMessage = new System.Windows.Forms.GroupBox();
            this.btnUpdateMessage = new System.Windows.Forms.Button();
            this.txtEditMessageMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.txtEditMessageId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpChatThread.SuspendLayout();
            this.grpUserToken.SuspendLayout();
            this.grpAddMember.SuspendLayout();
            this.grpRemoveUser.SuspendLayout();
            this.grpLogs.SuspendLayout();
            this.grpSendMessage.SuspendLayout();
            this.grpEditMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Identity:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(114, 10);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(451, 27);
            this.txtUserId.TabIndex = 1;
            // 
            // btnGenerateToken
            // 
            this.btnGenerateToken.Location = new System.Drawing.Point(214, 23);
            this.btnGenerateToken.Name = "btnGenerateToken";
            this.btnGenerateToken.Size = new System.Drawing.Size(119, 29);
            this.btnGenerateToken.TabIndex = 2;
            this.btnGenerateToken.Text = "Generate";
            this.btnGenerateToken.UseVisualStyleBackColor = true;
            this.btnGenerateToken.Click += new System.EventHandler(this.btnGenerateToken_Click);
            // 
            // chkScopeChat
            // 
            this.chkScopeChat.AutoSize = true;
            this.chkScopeChat.Location = new System.Drawing.Point(6, 26);
            this.chkScopeChat.Name = "chkScopeChat";
            this.chkScopeChat.Size = new System.Drawing.Size(61, 24);
            this.chkScopeChat.TabIndex = 0;
            this.chkScopeChat.Text = "Chat";
            this.chkScopeChat.UseVisualStyleBackColor = true;
            // 
            // chkScopePSTN
            // 
            this.chkScopePSTN.AutoSize = true;
            this.chkScopePSTN.Location = new System.Drawing.Point(142, 26);
            this.chkScopePSTN.Name = "chkScopePSTN";
            this.chkScopePSTN.Size = new System.Drawing.Size(66, 24);
            this.chkScopePSTN.TabIndex = 1;
            this.chkScopePSTN.Text = "PSTN";
            this.chkScopePSTN.UseVisualStyleBackColor = true;
            this.chkScopePSTN.Visible = false;
            // 
            // chkScopeVOIP
            // 
            this.chkScopeVOIP.AutoSize = true;
            this.chkScopeVOIP.Location = new System.Drawing.Point(73, 26);
            this.chkScopeVOIP.Name = "chkScopeVOIP";
            this.chkScopeVOIP.Size = new System.Drawing.Size(63, 24);
            this.chkScopeVOIP.TabIndex = 2;
            this.chkScopeVOIP.Text = "VOIP";
            this.chkScopeVOIP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(82, 26);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(357, 95);
            this.txtSendMsg.TabIndex = 5;
            // 
            // chkHighPriority
            // 
            this.chkHighPriority.AutoSize = true;
            this.chkHighPriority.Location = new System.Drawing.Point(82, 130);
            this.chkHighPriority.Name = "chkHighPriority";
            this.chkHighPriority.Size = new System.Drawing.Size(114, 24);
            this.chkHighPriority.TabIndex = 6;
            this.chkHighPriority.Text = "High Priority";
            this.chkHighPriority.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(324, 127);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(115, 29);
            this.btnSendMsg.TabIndex = 7;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // grpChatThread
            // 
            this.grpChatThread.Controls.Add(this.txtChatThread);
            this.grpChatThread.Location = new System.Drawing.Point(14, 489);
            this.grpChatThread.Name = "grpChatThread";
            this.grpChatThread.Size = new System.Drawing.Size(880, 244);
            this.grpChatThread.TabIndex = 11;
            this.grpChatThread.TabStop = false;
            this.grpChatThread.Text = "Chat Thread";
            // 
            // txtChatThread
            // 
            this.txtChatThread.Location = new System.Drawing.Point(6, 26);
            this.txtChatThread.Multiline = true;
            this.txtChatThread.Name = "txtChatThread";
            this.txtChatThread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatThread.Size = new System.Drawing.Size(868, 206);
            this.txtChatThread.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chat Thread Id:";
            // 
            // txtChatThreadID
            // 
            this.txtChatThreadID.Location = new System.Drawing.Point(127, 151);
            this.txtChatThreadID.Name = "txtChatThreadID";
            this.txtChatThreadID.Size = new System.Drawing.Size(367, 27);
            this.txtChatThreadID.TabIndex = 13;
            // 
            // btnJoinChatThread
            // 
            this.btnJoinChatThread.Location = new System.Drawing.Point(600, 150);
            this.btnJoinChatThread.Name = "btnJoinChatThread";
            this.btnJoinChatThread.Size = new System.Drawing.Size(94, 29);
            this.btnJoinChatThread.TabIndex = 14;
            this.btnJoinChatThread.Text = "Join";
            this.btnJoinChatThread.UseVisualStyleBackColor = true;
            this.btnJoinChatThread.Click += new System.EventHandler(this.btnJoinChatThread_Click);
            // 
            // btnCreateChatThread
            // 
            this.btnCreateChatThread.Location = new System.Drawing.Point(500, 150);
            this.btnCreateChatThread.Name = "btnCreateChatThread";
            this.btnCreateChatThread.Size = new System.Drawing.Size(94, 29);
            this.btnCreateChatThread.TabIndex = 15;
            this.btnCreateChatThread.Text = "Create";
            this.btnCreateChatThread.UseVisualStyleBackColor = true;
            this.btnCreateChatThread.Click += new System.EventHandler(this.btnCreateChatThread_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(571, 9);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(94, 29);
            this.btnCreateUser.TabIndex = 15;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // grpUserToken
            // 
            this.grpUserToken.Controls.Add(this.txtUserTokenExpiry);
            this.grpUserToken.Controls.Add(this.txtUserToken);
            this.grpUserToken.Controls.Add(this.btnGenerateToken);
            this.grpUserToken.Controls.Add(this.chkScopeChat);
            this.grpUserToken.Controls.Add(this.chkScopeVOIP);
            this.grpUserToken.Controls.Add(this.chkScopePSTN);
            this.grpUserToken.Location = new System.Drawing.Point(13, 43);
            this.grpUserToken.Name = "grpUserToken";
            this.grpUserToken.Size = new System.Drawing.Size(881, 98);
            this.grpUserToken.TabIndex = 16;
            this.grpUserToken.TabStop = false;
            this.grpUserToken.Text = "User Token";
            // 
            // txtUserTokenExpiry
            // 
            this.txtUserTokenExpiry.Location = new System.Drawing.Point(687, 57);
            this.txtUserTokenExpiry.Name = "txtUserTokenExpiry";
            this.txtUserTokenExpiry.ReadOnly = true;
            this.txtUserTokenExpiry.Size = new System.Drawing.Size(188, 27);
            this.txtUserTokenExpiry.TabIndex = 4;
            // 
            // txtUserToken
            // 
            this.txtUserToken.Location = new System.Drawing.Point(6, 57);
            this.txtUserToken.Name = "txtUserToken";
            this.txtUserToken.Size = new System.Drawing.Size(675, 27);
            this.txtUserToken.TabIndex = 3;
            // 
            // btnRevokeTokens
            // 
            this.btnRevokeTokens.Location = new System.Drawing.Point(771, 9);
            this.btnRevokeTokens.Name = "btnRevokeTokens";
            this.btnRevokeTokens.Size = new System.Drawing.Size(123, 29);
            this.btnRevokeTokens.TabIndex = 15;
            this.btnRevokeTokens.Text = "Revoke Tokens";
            this.btnRevokeTokens.UseVisualStyleBackColor = true;
            this.btnRevokeTokens.Click += new System.EventHandler(this.btnRevokeTokens_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(671, 9);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteUser.TabIndex = 15;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(this.btnAddMember);
            this.grpAddMember.Controls.Add(this.txtAddMemberUserToken);
            this.grpAddMember.Controls.Add(this.label5);
            this.grpAddMember.Controls.Add(this.txtAddMemberUserId);
            this.grpAddMember.Controls.Add(this.label3);
            this.grpAddMember.Location = new System.Drawing.Point(13, 188);
            this.grpAddMember.Name = "grpAddMember";
            this.grpAddMember.Size = new System.Drawing.Size(445, 125);
            this.grpAddMember.TabIndex = 17;
            this.grpAddMember.TabStop = false;
            this.grpAddMember.Text = "Add Member to Chat Thread";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(107, 90);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(133, 29);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtAddMemberUserToken
            // 
            this.txtAddMemberUserToken.Location = new System.Drawing.Point(107, 57);
            this.txtAddMemberUserToken.Name = "txtAddMemberUserToken";
            this.txtAddMemberUserToken.Size = new System.Drawing.Size(332, 27);
            this.txtAddMemberUserToken.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Token:";
            // 
            // txtAddMemberUserId
            // 
            this.txtAddMemberUserId.Location = new System.Drawing.Point(107, 24);
            this.txtAddMemberUserId.Name = "txtAddMemberUserId";
            this.txtAddMemberUserId.PlaceholderText = "Leave empty to us your User Identity";
            this.txtAddMemberUserId.Size = new System.Drawing.Size(332, 27);
            this.txtAddMemberUserId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Identity:";
            // 
            // btnListenToChatThread
            // 
            this.btnListenToChatThread.Location = new System.Drawing.Point(700, 150);
            this.btnListenToChatThread.Name = "btnListenToChatThread";
            this.btnListenToChatThread.Size = new System.Drawing.Size(94, 29);
            this.btnListenToChatThread.TabIndex = 18;
            this.btnListenToChatThread.Text = "Listen";
            this.btnListenToChatThread.UseVisualStyleBackColor = true;
            this.btnListenToChatThread.Click += new System.EventHandler(this.btnListenToChatThread_Click);
            // 
            // grpRemoveUser
            // 
            this.grpRemoveUser.Controls.Add(this.btnRemoveUser);
            this.grpRemoveUser.Controls.Add(this.txtRemoveUserUserId);
            this.grpRemoveUser.Controls.Add(this.label6);
            this.grpRemoveUser.Location = new System.Drawing.Point(464, 188);
            this.grpRemoveUser.Name = "grpRemoveUser";
            this.grpRemoveUser.Size = new System.Drawing.Size(430, 125);
            this.grpRemoveUser.TabIndex = 19;
            this.grpRemoveUser.TabStop = false;
            this.grpRemoveUser.Text = "Remove User from Chat Thread";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(107, 54);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(136, 29);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // txtRemoveUserUserId
            // 
            this.txtRemoveUserUserId.Location = new System.Drawing.Point(107, 21);
            this.txtRemoveUserUserId.Name = "txtRemoveUserUserId";
            this.txtRemoveUserUserId.PlaceholderText = "Leave empty to use your User Identity";
            this.txtRemoveUserUserId.Size = new System.Drawing.Size(317, 27);
            this.txtRemoveUserUserId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Identity:";
            // 
            // grpLogs
            // 
            this.grpLogs.Controls.Add(this.txtLogs);
            this.grpLogs.Location = new System.Drawing.Point(13, 739);
            this.grpLogs.Name = "grpLogs";
            this.grpLogs.Size = new System.Drawing.Size(882, 208);
            this.grpLogs.TabIndex = 20;
            this.grpLogs.TabStop = false;
            this.grpLogs.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(6, 26);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(869, 176);
            this.txtLogs.TabIndex = 0;
            // 
            // btnDeleteChatThread
            // 
            this.btnDeleteChatThread.Location = new System.Drawing.Point(800, 150);
            this.btnDeleteChatThread.Name = "btnDeleteChatThread";
            this.btnDeleteChatThread.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteChatThread.TabIndex = 21;
            this.btnDeleteChatThread.Text = "Delete";
            this.btnDeleteChatThread.UseVisualStyleBackColor = true;
            this.btnDeleteChatThread.Click += new System.EventHandler(this.btnDeleteChatThread_Click);
            // 
            // grpSendMessage
            // 
            this.grpSendMessage.Controls.Add(this.txtSendMsg);
            this.grpSendMessage.Controls.Add(this.label2);
            this.grpSendMessage.Controls.Add(this.chkHighPriority);
            this.grpSendMessage.Controls.Add(this.btnSendMsg);
            this.grpSendMessage.Location = new System.Drawing.Point(12, 319);
            this.grpSendMessage.Name = "grpSendMessage";
            this.grpSendMessage.Size = new System.Drawing.Size(445, 164);
            this.grpSendMessage.TabIndex = 22;
            this.grpSendMessage.TabStop = false;
            this.grpSendMessage.Text = "Send Message";
            // 
            // grpEditMessage
            // 
            this.grpEditMessage.Controls.Add(this.btnUpdateMessage);
            this.grpEditMessage.Controls.Add(this.txtEditMessageMessage);
            this.grpEditMessage.Controls.Add(this.label8);
            this.grpEditMessage.Controls.Add(this.btnDeleteMessage);
            this.grpEditMessage.Controls.Add(this.txtEditMessageId);
            this.grpEditMessage.Controls.Add(this.label7);
            this.grpEditMessage.Location = new System.Drawing.Point(464, 319);
            this.grpEditMessage.Name = "grpEditMessage";
            this.grpEditMessage.Size = new System.Drawing.Size(430, 164);
            this.grpEditMessage.TabIndex = 23;
            this.grpEditMessage.TabStop = false;
            this.grpEditMessage.Text = "Edit Message";
            // 
            // btnUpdateMessage
            // 
            this.btnUpdateMessage.Location = new System.Drawing.Point(230, 127);
            this.btnUpdateMessage.Name = "btnUpdateMessage";
            this.btnUpdateMessage.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateMessage.TabIndex = 2;
            this.btnUpdateMessage.Text = "Update";
            this.btnUpdateMessage.UseVisualStyleBackColor = true;
            this.btnUpdateMessage.Click += new System.EventHandler(this.btnUpdateMessage_Click);
            // 
            // txtEditMessageMessage
            // 
            this.txtEditMessageMessage.Location = new System.Drawing.Point(99, 57);
            this.txtEditMessageMessage.Multiline = true;
            this.txtEditMessageMessage.Name = "txtEditMessageMessage";
            this.txtEditMessageMessage.Size = new System.Drawing.Size(324, 64);
            this.txtEditMessageMessage.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Message:";
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Location = new System.Drawing.Point(330, 127);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteMessage.TabIndex = 2;
            this.btnDeleteMessage.Text = "Delete";
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // txtEditMessageId
            // 
            this.txtEditMessageId.Location = new System.Drawing.Point(99, 20);
            this.txtEditMessageId.Name = "txtEditMessageId";
            this.txtEditMessageId.Size = new System.Drawing.Size(324, 27);
            this.txtEditMessageId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Message Id:";
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 955);
            this.Controls.Add(this.grpEditMessage);
            this.Controls.Add(this.grpSendMessage);
            this.Controls.Add(this.btnDeleteChatThread);
            this.Controls.Add(this.grpLogs);
            this.Controls.Add(this.grpRemoveUser);
            this.Controls.Add(this.btnListenToChatThread);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnRevokeTokens);
            this.Controls.Add(this.grpUserToken);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnJoinChatThread);
            this.Controls.Add(this.btnCreateChatThread);
            this.Controls.Add(this.txtChatThreadID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpChatThread);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.grpChatThread.ResumeLayout(false);
            this.grpChatThread.PerformLayout();
            this.grpUserToken.ResumeLayout(false);
            this.grpUserToken.PerformLayout();
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            this.grpRemoveUser.ResumeLayout(false);
            this.grpRemoveUser.PerformLayout();
            this.grpLogs.ResumeLayout(false);
            this.grpLogs.PerformLayout();
            this.grpSendMessage.ResumeLayout(false);
            this.grpSendMessage.PerformLayout();
            this.grpEditMessage.ResumeLayout(false);
            this.grpEditMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnGenerateToken;
        private System.Windows.Forms.CheckBox chkScopeChat;
        private System.Windows.Forms.CheckBox chkScopePSTN;
        private System.Windows.Forms.CheckBox chkScopeVOIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.CheckBox chkHighPriority;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.GroupBox grpChatThread;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChatThreadID;
        private System.Windows.Forms.Button btnJoinChatThread;
        private System.Windows.Forms.TextBox txtChatThread;
        private System.Windows.Forms.Button btnCreateChatThread;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.GroupBox grpUserToken;
        private System.Windows.Forms.TextBox txtUserTokenExpiry;
        private System.Windows.Forms.TextBox txtUserToken;
        private System.Windows.Forms.Button btnRevokeTokens;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtAddMemberUserToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddMemberUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListenToChatThread;
        private System.Windows.Forms.GroupBox grpRemoveUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.TextBox txtRemoveUserUserId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpLogs;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Button btnDeleteChatThread;
        private System.Windows.Forms.GroupBox grpSendMessage;
        private System.Windows.Forms.GroupBox grpEditMessage;
        private System.Windows.Forms.Button btnUpdateMessage;
        private System.Windows.Forms.TextBox txtEditMessageMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.TextBox txtEditMessageId;
        private System.Windows.Forms.Label label7;
    }
}

