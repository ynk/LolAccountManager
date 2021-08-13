
namespace LolAccountManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_SaveAccounts = new System.Windows.Forms.Button();
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.ManageAccountTab = new System.Windows.Forms.TabPage();
            this.Button_ManageAccount_Login = new System.Windows.Forms.Button();
            this.Button_ModifyAccount_DeleteAccount = new System.Windows.Forms.Button();
            this.Button_ManageAccount_CopyLoginNameClipboard = new System.Windows.Forms.Button();
            this.Button_ManageAccount_CopyPasswordClipboard = new System.Windows.Forms.Button();
            this.TextBox_ModifyAccount_SummonerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_ModifyAccount_Server = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_ManageAccount_CopySummonerNameClipboard = new System.Windows.Forms.Button();
            this.Button_ModifyAccount_SaveChanges = new System.Windows.Forms.Button();
            this.TextBox_ModifyAccount_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ModifyAccount_LoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountPage = new System.Windows.Forms.TabPage();
            this.CheckBox_Add_HideUsername = new System.Windows.Forms.CheckBox();
            this.CheckBox_RememberPassword = new System.Windows.Forms.CheckBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_AddAccount = new System.Windows.Forms.Button();
            this.PasswordLoginLabel = new System.Windows.Forms.Label();
            this.LoginNameLabel = new System.Windows.Forms.Label();
            this.TextBox_AddAccount_LoginName = new System.Windows.Forms.TextBox();
            this.CheckBox_Add_HidePassword = new System.Windows.Forms.CheckBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Checkbox_ManageAccount_HideSummonerName = new System.Windows.Forms.CheckBox();
            this.Checkbox_ManageAccount_Password = new System.Windows.Forms.CheckBox();
            this.Checkbox_ManageAccount_HideLoginName = new System.Windows.Forms.CheckBox();
            this.Button_Settings_Default = new System.Windows.Forms.Button();
            this.Button_SaveSettings = new System.Windows.Forms.Button();
            this.CheckBox_StartMinimized = new System.Windows.Forms.CheckBox();
            this.CheckBox_LaunchStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox_HideLoginName = new System.Windows.Forms.CheckBox();
            this.Checkbox_HideSummonerName = new System.Windows.Forms.CheckBox();
            this.Checkbox_DebugMode = new System.Windows.Forms.CheckBox();
            this.DebugPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Button_SaveDebugLog = new System.Windows.Forms.Button();
            this.DebugLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackgroundWorker_RankChecker = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorker_ClientChecker = new System.ComponentModel.BackgroundWorker();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.Solo_Duo_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flex_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_ModifyAccount_SoloQueue = new System.Windows.Forms.TextBox();
            this.TextBox_ModifyAccount_FlexQueue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_ModifyAccount_GetRankedData = new System.Windows.Forms.Button();
            this.loginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riotAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.ManageAccountTab.SuspendLayout();
            this.AccountPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DebugPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riotAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.HomePage);
            this.Tabs.Controls.Add(this.ManageAccountTab);
            this.Tabs.Controls.Add(this.AccountPage);
            this.Tabs.Controls.Add(this.SettingsPage);
            this.Tabs.Controls.Add(this.DebugPage);
            this.Tabs.Location = new System.Drawing.Point(-1, 4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(831, 440);
            this.Tabs.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.label5);
            this.HomePage.Controls.Add(this.button4);
            this.HomePage.Controls.Add(this.button2);
            this.HomePage.Controls.Add(this.Button_SaveAccounts);
            this.HomePage.Controls.Add(this.accountGridView);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(823, 414);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Accounts";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Manage selected account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ManageAccountButton4Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Load Accounts From File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Button_SaveAccounts
            // 
            this.Button_SaveAccounts.Location = new System.Drawing.Point(9, 35);
            this.Button_SaveAccounts.Name = "Button_SaveAccounts";
            this.Button_SaveAccounts.Size = new System.Drawing.Size(140, 23);
            this.Button_SaveAccounts.TabIndex = 2;
            this.Button_SaveAccounts.Text = "Save Accounts To File";
            this.Button_SaveAccounts.UseVisualStyleBackColor = true;
            this.Button_SaveAccounts.Click += new System.EventHandler(this.Button_SaveAccounts_Click);
            // 
            // accountGridView
            // 
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.AutoGenerateColumns = false;
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.serverDataGridViewTextBoxColumn,
            this.Solo_Duo_Rank,
            this.Flex_Rank,
            this.summonerNameDataGridViewTextBoxColumn});
            this.accountGridView.DataSource = this.riotAccountBindingSource;
            this.accountGridView.Location = new System.Drawing.Point(9, 64);
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountGridView.Size = new System.Drawing.Size(805, 315);
            this.accountGridView.TabIndex = 1;
            this.accountGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.accountGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ManageAccountTab
            // 
            this.ManageAccountTab.Controls.Add(this.Button_ModifyAccount_GetRankedData);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_FlexQueue);
            this.ManageAccountTab.Controls.Add(this.label7);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_SoloQueue);
            this.ManageAccountTab.Controls.Add(this.label6);
            this.ManageAccountTab.Controls.Add(this.Button_ManageAccount_Login);
            this.ManageAccountTab.Controls.Add(this.Button_ModifyAccount_DeleteAccount);
            this.ManageAccountTab.Controls.Add(this.Button_ManageAccount_CopyLoginNameClipboard);
            this.ManageAccountTab.Controls.Add(this.Button_ManageAccount_CopyPasswordClipboard);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_SummonerName);
            this.ManageAccountTab.Controls.Add(this.label4);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_Server);
            this.ManageAccountTab.Controls.Add(this.label3);
            this.ManageAccountTab.Controls.Add(this.Button_ManageAccount_CopySummonerNameClipboard);
            this.ManageAccountTab.Controls.Add(this.Button_ModifyAccount_SaveChanges);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_Password);
            this.ManageAccountTab.Controls.Add(this.label2);
            this.ManageAccountTab.Controls.Add(this.TextBox_ModifyAccount_LoginName);
            this.ManageAccountTab.Controls.Add(this.label1);
            this.ManageAccountTab.Location = new System.Drawing.Point(4, 22);
            this.ManageAccountTab.Name = "ManageAccountTab";
            this.ManageAccountTab.Size = new System.Drawing.Size(654, 396);
            this.ManageAccountTab.TabIndex = 4;
            this.ManageAccountTab.Text = "Manage Account";
            this.ManageAccountTab.UseVisualStyleBackColor = true;
            this.ManageAccountTab.Click += new System.EventHandler(this.ManageAccountTab_Click);
            // 
            // Button_ManageAccount_Login
            // 
            this.Button_ManageAccount_Login.Location = new System.Drawing.Point(12, 293);
            this.Button_ManageAccount_Login.Name = "Button_ManageAccount_Login";
            this.Button_ManageAccount_Login.Size = new System.Drawing.Size(110, 34);
            this.Button_ManageAccount_Login.TabIndex = 15;
            this.Button_ManageAccount_Login.Text = "Login";
            this.Button_ManageAccount_Login.UseVisualStyleBackColor = true;
            this.Button_ManageAccount_Login.Click += new System.EventHandler(this.Button_ManageAccount_Login_Click);
            // 
            // Button_ModifyAccount_DeleteAccount
            // 
            this.Button_ModifyAccount_DeleteAccount.Location = new System.Drawing.Point(140, 293);
            this.Button_ModifyAccount_DeleteAccount.Name = "Button_ModifyAccount_DeleteAccount";
            this.Button_ModifyAccount_DeleteAccount.Size = new System.Drawing.Size(110, 34);
            this.Button_ModifyAccount_DeleteAccount.TabIndex = 14;
            this.Button_ModifyAccount_DeleteAccount.Text = "Delete Account";
            this.Button_ModifyAccount_DeleteAccount.UseVisualStyleBackColor = true;
            this.Button_ModifyAccount_DeleteAccount.Click += new System.EventHandler(this.Button_ModifyAccount_DeleteAccount_Click);
            // 
            // Button_ManageAccount_CopyLoginNameClipboard
            // 
            this.Button_ManageAccount_CopyLoginNameClipboard.Location = new System.Drawing.Point(341, 28);
            this.Button_ManageAccount_CopyLoginNameClipboard.Name = "Button_ManageAccount_CopyLoginNameClipboard";
            this.Button_ManageAccount_CopyLoginNameClipboard.Size = new System.Drawing.Size(164, 20);
            this.Button_ManageAccount_CopyLoginNameClipboard.TabIndex = 13;
            this.Button_ManageAccount_CopyLoginNameClipboard.Text = "Copy To Clipboard";
            this.Button_ManageAccount_CopyLoginNameClipboard.UseVisualStyleBackColor = true;
            this.Button_ManageAccount_CopyLoginNameClipboard.Click += new System.EventHandler(this.Button_ManageAccount_CopyLoginNameClipboard_Click);
            // 
            // Button_ManageAccount_CopyPasswordClipboard
            // 
            this.Button_ManageAccount_CopyPasswordClipboard.Location = new System.Drawing.Point(341, 60);
            this.Button_ManageAccount_CopyPasswordClipboard.Name = "Button_ManageAccount_CopyPasswordClipboard";
            this.Button_ManageAccount_CopyPasswordClipboard.Size = new System.Drawing.Size(164, 20);
            this.Button_ManageAccount_CopyPasswordClipboard.TabIndex = 12;
            this.Button_ManageAccount_CopyPasswordClipboard.Text = "Copy To Clipboard";
            this.Button_ManageAccount_CopyPasswordClipboard.UseVisualStyleBackColor = true;
            this.Button_ManageAccount_CopyPasswordClipboard.Click += new System.EventHandler(this.Button_ManageAccount_CopyPasswordClipboard_Click);
            // 
            // TextBox_ModifyAccount_SummonerName
            // 
            this.TextBox_ModifyAccount_SummonerName.Enabled = false;
            this.TextBox_ModifyAccount_SummonerName.Location = new System.Drawing.Point(103, 125);
            this.TextBox_ModifyAccount_SummonerName.Name = "TextBox_ModifyAccount_SummonerName";
            this.TextBox_ModifyAccount_SummonerName.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_SummonerName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Summoner Name";
            // 
            // TextBox_ModifyAccount_Server
            // 
            this.TextBox_ModifyAccount_Server.Enabled = false;
            this.TextBox_ModifyAccount_Server.Location = new System.Drawing.Point(103, 91);
            this.TextBox_ModifyAccount_Server.Name = "TextBox_ModifyAccount_Server";
            this.TextBox_ModifyAccount_Server.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_Server.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server";
            // 
            // Button_ManageAccount_CopySummonerNameClipboard
            // 
            this.Button_ManageAccount_CopySummonerNameClipboard.Location = new System.Drawing.Point(341, 125);
            this.Button_ManageAccount_CopySummonerNameClipboard.Name = "Button_ManageAccount_CopySummonerNameClipboard";
            this.Button_ManageAccount_CopySummonerNameClipboard.Size = new System.Drawing.Size(164, 20);
            this.Button_ManageAccount_CopySummonerNameClipboard.TabIndex = 5;
            this.Button_ManageAccount_CopySummonerNameClipboard.Text = "Copy To Clipboard";
            this.Button_ManageAccount_CopySummonerNameClipboard.UseVisualStyleBackColor = true;
            this.Button_ManageAccount_CopySummonerNameClipboard.Click += new System.EventHandler(this.Button_ManageAccount_CopySummonerNameClipboard_Click);
            // 
            // Button_ModifyAccount_SaveChanges
            // 
            this.Button_ModifyAccount_SaveChanges.Location = new System.Drawing.Point(269, 293);
            this.Button_ModifyAccount_SaveChanges.Name = "Button_ModifyAccount_SaveChanges";
            this.Button_ModifyAccount_SaveChanges.Size = new System.Drawing.Size(110, 34);
            this.Button_ModifyAccount_SaveChanges.TabIndex = 4;
            this.Button_ModifyAccount_SaveChanges.Text = "Save Changes";
            this.Button_ModifyAccount_SaveChanges.UseVisualStyleBackColor = true;
            this.Button_ModifyAccount_SaveChanges.Click += new System.EventHandler(this.Button_ModifyAccount_SaveChanges_Click);
            // 
            // TextBox_ModifyAccount_Password
            // 
            this.TextBox_ModifyAccount_Password.Location = new System.Drawing.Point(103, 60);
            this.TextBox_ModifyAccount_Password.Name = "TextBox_ModifyAccount_Password";
            this.TextBox_ModifyAccount_Password.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_Password.TabIndex = 3;
            this.TextBox_ModifyAccount_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TextBox_ModifyAccount_LoginName
            // 
            this.TextBox_ModifyAccount_LoginName.Location = new System.Drawing.Point(103, 29);
            this.TextBox_ModifyAccount_LoginName.Name = "TextBox_ModifyAccount_LoginName";
            this.TextBox_ModifyAccount_LoginName.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_LoginName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Name:";
            // 
            // AccountPage
            // 
            this.AccountPage.Controls.Add(this.CheckBox_Add_HideUsername);
            this.AccountPage.Controls.Add(this.CheckBox_RememberPassword);
            this.AccountPage.Controls.Add(this.TextBox_Password);
            this.AccountPage.Controls.Add(this.Button_AddAccount);
            this.AccountPage.Controls.Add(this.PasswordLoginLabel);
            this.AccountPage.Controls.Add(this.LoginNameLabel);
            this.AccountPage.Controls.Add(this.TextBox_AddAccount_LoginName);
            this.AccountPage.Controls.Add(this.CheckBox_Add_HidePassword);
            this.AccountPage.Location = new System.Drawing.Point(4, 22);
            this.AccountPage.Name = "AccountPage";
            this.AccountPage.Size = new System.Drawing.Size(654, 396);
            this.AccountPage.TabIndex = 3;
            this.AccountPage.Text = "Add Account";
            this.AccountPage.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Add_HideUsername
            // 
            this.CheckBox_Add_HideUsername.AutoSize = true;
            this.CheckBox_Add_HideUsername.Location = new System.Drawing.Point(82, 109);
            this.CheckBox_Add_HideUsername.Name = "CheckBox_Add_HideUsername";
            this.CheckBox_Add_HideUsername.Size = new System.Drawing.Size(99, 17);
            this.CheckBox_Add_HideUsername.TabIndex = 9;
            this.CheckBox_Add_HideUsername.Text = "Hide Username";
            this.CheckBox_Add_HideUsername.UseVisualStyleBackColor = true;
            this.CheckBox_Add_HideUsername.CheckedChanged += new System.EventHandler(this.CheckBox_Add_HideUsername_CheckedChanged);
            // 
            // CheckBox_RememberPassword
            // 
            this.CheckBox_RememberPassword.AutoSize = true;
            this.CheckBox_RememberPassword.Location = new System.Drawing.Point(290, 109);
            this.CheckBox_RememberPassword.Name = "CheckBox_RememberPassword";
            this.CheckBox_RememberPassword.Size = new System.Drawing.Size(125, 17);
            this.CheckBox_RememberPassword.TabIndex = 7;
            this.CheckBox_RememberPassword.Text = "Remember password";
            this.CheckBox_RememberPassword.UseVisualStyleBackColor = true;
            this.CheckBox_RememberPassword.CheckedChanged += new System.EventHandler(this.CheckBox_RememberPassword_CheckedChanged);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(82, 83);
            this.TextBox_Password.MaxLength = 32;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(310, 20);
            this.TextBox_Password.TabIndex = 2;
            // 
            // Button_AddAccount
            // 
            this.Button_AddAccount.Location = new System.Drawing.Point(100, 132);
            this.Button_AddAccount.Name = "Button_AddAccount";
            this.Button_AddAccount.Size = new System.Drawing.Size(263, 61);
            this.Button_AddAccount.TabIndex = 3;
            this.Button_AddAccount.Text = "Add Account";
            this.Button_AddAccount.UseVisualStyleBackColor = true;
            this.Button_AddAccount.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // PasswordLoginLabel
            // 
            this.PasswordLoginLabel.AutoSize = true;
            this.PasswordLoginLabel.Location = new System.Drawing.Point(20, 83);
            this.PasswordLoginLabel.Name = "PasswordLoginLabel";
            this.PasswordLoginLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLoginLabel.TabIndex = 3;
            this.PasswordLoginLabel.Text = "Password:";
            // 
            // LoginNameLabel
            // 
            this.LoginNameLabel.AutoSize = true;
            this.LoginNameLabel.Location = new System.Drawing.Point(9, 41);
            this.LoginNameLabel.Name = "LoginNameLabel";
            this.LoginNameLabel.Size = new System.Drawing.Size(67, 13);
            this.LoginNameLabel.TabIndex = 1;
            this.LoginNameLabel.Text = "Login Name:";
            // 
            // TextBox_AddAccount_LoginName
            // 
            this.TextBox_AddAccount_LoginName.Location = new System.Drawing.Point(82, 38);
            this.TextBox_AddAccount_LoginName.MaxLength = 32;
            this.TextBox_AddAccount_LoginName.Name = "TextBox_AddAccount_LoginName";
            this.TextBox_AddAccount_LoginName.Size = new System.Drawing.Size(310, 20);
            this.TextBox_AddAccount_LoginName.TabIndex = 0;
            // 
            // CheckBox_Add_HidePassword
            // 
            this.CheckBox_Add_HidePassword.AutoSize = true;
            this.CheckBox_Add_HidePassword.Location = new System.Drawing.Point(187, 109);
            this.CheckBox_Add_HidePassword.Name = "CheckBox_Add_HidePassword";
            this.CheckBox_Add_HidePassword.Size = new System.Drawing.Size(97, 17);
            this.CheckBox_Add_HidePassword.TabIndex = 8;
            this.CheckBox_Add_HidePassword.Text = "Hide Password";
            this.CheckBox_Add_HidePassword.UseVisualStyleBackColor = true;
            this.CheckBox_Add_HidePassword.CheckedChanged += new System.EventHandler(this.CheckBox_Add_HidePassword_CheckedChanged);
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.groupBox2);
            this.SettingsPage.Controls.Add(this.Button_Settings_Default);
            this.SettingsPage.Controls.Add(this.Button_SaveSettings);
            this.SettingsPage.Controls.Add(this.CheckBox_StartMinimized);
            this.SettingsPage.Controls.Add(this.CheckBox_LaunchStartup);
            this.SettingsPage.Controls.Add(this.groupBox1);
            this.SettingsPage.Controls.Add(this.Checkbox_DebugMode);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(654, 396);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Checkbox_ManageAccount_HideSummonerName);
            this.groupBox2.Controls.Add(this.Checkbox_ManageAccount_Password);
            this.groupBox2.Controls.Add(this.Checkbox_ManageAccount_HideLoginName);
            this.groupBox2.Location = new System.Drawing.Point(9, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Account ";
            // 
            // Checkbox_ManageAccount_HideSummonerName
            // 
            this.Checkbox_ManageAccount_HideSummonerName.AutoSize = true;
            this.Checkbox_ManageAccount_HideSummonerName.Location = new System.Drawing.Point(7, 68);
            this.Checkbox_ManageAccount_HideSummonerName.Name = "Checkbox_ManageAccount_HideSummonerName";
            this.Checkbox_ManageAccount_HideSummonerName.Size = new System.Drawing.Size(132, 17);
            this.Checkbox_ManageAccount_HideSummonerName.TabIndex = 2;
            this.Checkbox_ManageAccount_HideSummonerName.Text = "Hide Summoner Name";
            this.Checkbox_ManageAccount_HideSummonerName.UseVisualStyleBackColor = true;
            this.Checkbox_ManageAccount_HideSummonerName.CheckedChanged += new System.EventHandler(this.Checkbox_ManageAccount_HideSummonerName_CheckedChanged);
            // 
            // Checkbox_ManageAccount_Password
            // 
            this.Checkbox_ManageAccount_Password.AutoSize = true;
            this.Checkbox_ManageAccount_Password.Location = new System.Drawing.Point(7, 44);
            this.Checkbox_ManageAccount_Password.Name = "Checkbox_ManageAccount_Password";
            this.Checkbox_ManageAccount_Password.Size = new System.Drawing.Size(97, 17);
            this.Checkbox_ManageAccount_Password.TabIndex = 1;
            this.Checkbox_ManageAccount_Password.Text = "Hide Password";
            this.Checkbox_ManageAccount_Password.UseVisualStyleBackColor = true;
            this.Checkbox_ManageAccount_Password.CheckedChanged += new System.EventHandler(this.Checkbox_ManageAccount_Password_CheckedChanged);
            // 
            // Checkbox_ManageAccount_HideLoginName
            // 
            this.Checkbox_ManageAccount_HideLoginName.AutoSize = true;
            this.Checkbox_ManageAccount_HideLoginName.Location = new System.Drawing.Point(7, 20);
            this.Checkbox_ManageAccount_HideLoginName.Name = "Checkbox_ManageAccount_HideLoginName";
            this.Checkbox_ManageAccount_HideLoginName.Size = new System.Drawing.Size(108, 17);
            this.Checkbox_ManageAccount_HideLoginName.TabIndex = 0;
            this.Checkbox_ManageAccount_HideLoginName.Text = "Hide Login Name";
            this.Checkbox_ManageAccount_HideLoginName.UseVisualStyleBackColor = true;
            this.Checkbox_ManageAccount_HideLoginName.CheckedChanged += new System.EventHandler(this.Checkbox_ManageAccount_HideLoginName_CheckedChanged);
            // 
            // Button_Settings_Default
            // 
            this.Button_Settings_Default.Location = new System.Drawing.Point(426, 355);
            this.Button_Settings_Default.Name = "Button_Settings_Default";
            this.Button_Settings_Default.Size = new System.Drawing.Size(90, 23);
            this.Button_Settings_Default.TabIndex = 14;
            this.Button_Settings_Default.Text = "Default Settings";
            this.Button_Settings_Default.UseVisualStyleBackColor = true;
            this.Button_Settings_Default.Click += new System.EventHandler(this.ButtonResetSettingsClick);
            // 
            // Button_SaveSettings
            // 
            this.Button_SaveSettings.Location = new System.Drawing.Point(522, 355);
            this.Button_SaveSettings.Name = "Button_SaveSettings";
            this.Button_SaveSettings.Size = new System.Drawing.Size(109, 23);
            this.Button_SaveSettings.TabIndex = 13;
            this.Button_SaveSettings.Text = "Save Settings";
            this.Button_SaveSettings.UseVisualStyleBackColor = true;
            this.Button_SaveSettings.Click += new System.EventHandler(this.Button_SaveSettings_Click);
            // 
            // CheckBox_StartMinimized
            // 
            this.CheckBox_StartMinimized.AutoSize = true;
            this.CheckBox_StartMinimized.Location = new System.Drawing.Point(202, 361);
            this.CheckBox_StartMinimized.Name = "CheckBox_StartMinimized";
            this.CheckBox_StartMinimized.Size = new System.Drawing.Size(100, 17);
            this.CheckBox_StartMinimized.TabIndex = 12;
            this.CheckBox_StartMinimized.Text = "Start Minimized ";
            this.CheckBox_StartMinimized.UseVisualStyleBackColor = true;
            // 
            // CheckBox_LaunchStartup
            // 
            this.CheckBox_LaunchStartup.AutoSize = true;
            this.CheckBox_LaunchStartup.Location = new System.Drawing.Point(80, 361);
            this.CheckBox_LaunchStartup.Name = "CheckBox_LaunchStartup";
            this.CheckBox_LaunchStartup.Size = new System.Drawing.Size(116, 17);
            this.CheckBox_LaunchStartup.TabIndex = 11;
            this.CheckBox_LaunchStartup.Text = "Launch On Startup";
            this.CheckBox_LaunchStartup.UseVisualStyleBackColor = true;
            this.CheckBox_LaunchStartup.CheckedChanged += new System.EventHandler(this.CheckBox_LaunchStartup_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBox_HideLoginName);
            this.groupBox1.Controls.Add(this.Checkbox_HideSummonerName);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Overview";
            // 
            // CheckBox_HideLoginName
            // 
            this.CheckBox_HideLoginName.AutoSize = true;
            this.CheckBox_HideLoginName.Location = new System.Drawing.Point(6, 19);
            this.CheckBox_HideLoginName.Name = "CheckBox_HideLoginName";
            this.CheckBox_HideLoginName.Size = new System.Drawing.Size(108, 17);
            this.CheckBox_HideLoginName.TabIndex = 7;
            this.CheckBox_HideLoginName.Text = "Hide Login Name";
            this.CheckBox_HideLoginName.UseVisualStyleBackColor = true;
            // 
            // Checkbox_HideSummonerName
            // 
            this.Checkbox_HideSummonerName.AutoSize = true;
            this.Checkbox_HideSummonerName.Location = new System.Drawing.Point(6, 42);
            this.Checkbox_HideSummonerName.Name = "Checkbox_HideSummonerName";
            this.Checkbox_HideSummonerName.Size = new System.Drawing.Size(132, 17);
            this.Checkbox_HideSummonerName.TabIndex = 8;
            this.Checkbox_HideSummonerName.Text = "Hide Summoner Name";
            this.Checkbox_HideSummonerName.UseVisualStyleBackColor = true;
            // 
            // Checkbox_DebugMode
            // 
            this.Checkbox_DebugMode.AutoSize = true;
            this.Checkbox_DebugMode.Location = new System.Drawing.Point(16, 361);
            this.Checkbox_DebugMode.Name = "Checkbox_DebugMode";
            this.Checkbox_DebugMode.Size = new System.Drawing.Size(58, 17);
            this.Checkbox_DebugMode.TabIndex = 1;
            this.Checkbox_DebugMode.Text = "Debug";
            this.Checkbox_DebugMode.UseVisualStyleBackColor = true;
            // 
            // DebugPage
            // 
            this.DebugPage.Controls.Add(this.button3);
            this.DebugPage.Controls.Add(this.Button_SaveDebugLog);
            this.DebugPage.Controls.Add(this.DebugLog);
            this.DebugPage.Location = new System.Drawing.Point(4, 22);
            this.DebugPage.Name = "DebugPage";
            this.DebugPage.Padding = new System.Windows.Forms.Padding(3);
            this.DebugPage.Size = new System.Drawing.Size(654, 396);
            this.DebugPage.TabIndex = 1;
            this.DebugPage.Text = "Debug";
            this.DebugPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Button_SaveDebugLog
            // 
            this.Button_SaveDebugLog.Location = new System.Drawing.Point(544, 343);
            this.Button_SaveDebugLog.Name = "Button_SaveDebugLog";
            this.Button_SaveDebugLog.Size = new System.Drawing.Size(104, 23);
            this.Button_SaveDebugLog.TabIndex = 1;
            this.Button_SaveDebugLog.Text = "Save Debug Log";
            this.Button_SaveDebugLog.UseVisualStyleBackColor = true;
            this.Button_SaveDebugLog.Click += new System.EventHandler(this.WriteDebugLogButton);
            // 
            // DebugLog
            // 
            this.DebugLog.Location = new System.Drawing.Point(10, 7);
            this.DebugLog.Multiline = true;
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.Size = new System.Drawing.Size(638, 330);
            this.DebugLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // Notify
            // 
            this.Notify.Text = "LolAccountManager";
            this.Notify.Visible = true;
            // 
            // Solo_Duo_Rank
            // 
            this.Solo_Duo_Rank.DataPropertyName = "Solo_Duo_Rank";
            this.Solo_Duo_Rank.HeaderText = "Solo Queue";
            this.Solo_Duo_Rank.Name = "Solo_Duo_Rank";
            this.Solo_Duo_Rank.ReadOnly = true;
            // 
            // Flex_Rank
            // 
            this.Flex_Rank.DataPropertyName = "Flex_Rank";
            this.Flex_Rank.HeaderText = "Flex Queue";
            this.Flex_Rank.Name = "Flex_Rank";
            this.Flex_Rank.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Double Click on a account to sign in!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Solo Queue";
            // 
            // TextBox_ModifyAccount_SoloQueue
            // 
            this.TextBox_ModifyAccount_SoloQueue.Enabled = false;
            this.TextBox_ModifyAccount_SoloQueue.Location = new System.Drawing.Point(103, 161);
            this.TextBox_ModifyAccount_SoloQueue.Name = "TextBox_ModifyAccount_SoloQueue";
            this.TextBox_ModifyAccount_SoloQueue.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_SoloQueue.TabIndex = 17;
            // 
            // TextBox_ModifyAccount_FlexQueue
            // 
            this.TextBox_ModifyAccount_FlexQueue.Enabled = false;
            this.TextBox_ModifyAccount_FlexQueue.Location = new System.Drawing.Point(103, 191);
            this.TextBox_ModifyAccount_FlexQueue.Name = "TextBox_ModifyAccount_FlexQueue";
            this.TextBox_ModifyAccount_FlexQueue.Size = new System.Drawing.Size(232, 20);
            this.TextBox_ModifyAccount_FlexQueue.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Flex Queue";
            // 
            // Button_ModifyAccount_GetRankedData
            // 
            this.Button_ModifyAccount_GetRankedData.Location = new System.Drawing.Point(386, 293);
            this.Button_ModifyAccount_GetRankedData.Name = "Button_ModifyAccount_GetRankedData";
            this.Button_ModifyAccount_GetRankedData.Size = new System.Drawing.Size(119, 34);
            this.Button_ModifyAccount_GetRankedData.TabIndex = 20;
            this.Button_ModifyAccount_GetRankedData.Text = "Get Ranked Data";
            this.Button_ModifyAccount_GetRankedData.UseVisualStyleBackColor = true;
            this.Button_ModifyAccount_GetRankedData.Click += new System.EventHandler(this.Button_ModifyAccount_GetRankedData_Click);
            // 
            // loginNameDataGridViewTextBoxColumn
            // 
            this.loginNameDataGridViewTextBoxColumn.DataPropertyName = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.HeaderText = "Login Name";
            this.loginNameDataGridViewTextBoxColumn.Name = "loginNameDataGridViewTextBoxColumn";
            this.loginNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.FillWeight = 50F;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 60;
            // 
            // serverDataGridViewTextBoxColumn
            // 
            this.serverDataGridViewTextBoxColumn.DataPropertyName = "Server";
            this.serverDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverDataGridViewTextBoxColumn.Name = "serverDataGridViewTextBoxColumn";
            this.serverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summonerNameDataGridViewTextBoxColumn
            // 
            this.summonerNameDataGridViewTextBoxColumn.DataPropertyName = "SummonerName";
            this.summonerNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.summonerNameDataGridViewTextBoxColumn.HeaderText = "Summoner Name";
            this.summonerNameDataGridViewTextBoxColumn.Name = "summonerNameDataGridViewTextBoxColumn";
            this.summonerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.summonerNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // riotAccountBindingSource
            // 
            this.riotAccountBindingSource.DataSource = typeof(LCULib.LCU.RiotAccount);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 460);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "LolAccountManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Tabs.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.ManageAccountTab.ResumeLayout(false);
            this.ManageAccountTab.PerformLayout();
            this.AccountPage.ResumeLayout(false);
            this.AccountPage.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DebugPage.ResumeLayout(false);
            this.DebugPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riotAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage DebugPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabPage AccountPage;
        private System.Windows.Forms.Button Button_AddAccount;
        private System.Windows.Forms.Label PasswordLoginLabel;
        private System.Windows.Forms.Label LoginNameLabel;
        private System.Windows.Forms.TextBox TextBox_AddAccount_LoginName;
        private System.Windows.Forms.TextBox DebugLog;
        private System.Windows.Forms.CheckBox Checkbox_DebugMode;
        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.Button Button_SaveDebugLog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_SaveAccounts;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage ManageAccountTab;
        private System.Windows.Forms.BindingSource riotAccountBindingSource;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_RankChecker;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_ClientChecker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_HideLoginName;
        private System.Windows.Forms.CheckBox Checkbox_HideSummonerName;
        private System.Windows.Forms.CheckBox CheckBox_LaunchStartup;
        private System.Windows.Forms.CheckBox CheckBox_StartMinimized;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.Button Button_SaveSettings;
        private System.Windows.Forms.CheckBox CheckBox_Add_HideUsername;
        private System.Windows.Forms.CheckBox CheckBox_RememberPassword;
        private System.Windows.Forms.Button Button_Settings_Default;
        private System.Windows.Forms.Button Button_ModifyAccount_SaveChanges;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_LoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_ManageAccount_CopySummonerNameClipboard;
        private System.Windows.Forms.Button Button_ManageAccount_CopyLoginNameClipboard;
        private System.Windows.Forms.Button Button_ManageAccount_CopyPasswordClipboard;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_SummonerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_Server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_ModifyAccount_DeleteAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Checkbox_ManageAccount_HideSummonerName;
        private System.Windows.Forms.CheckBox Checkbox_ManageAccount_Password;
        private System.Windows.Forms.CheckBox Checkbox_ManageAccount_HideLoginName;
        private System.Windows.Forms.Button Button_ManageAccount_Login;
        private System.Windows.Forms.CheckBox CheckBox_Add_HidePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solo_Duo_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flex_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn summonerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_ModifyAccount_GetRankedData;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_FlexQueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_ModifyAccount_SoloQueue;
        private System.Windows.Forms.Label label6;
    }
}

