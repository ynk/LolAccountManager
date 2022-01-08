using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LCULib;
using LCULib.LCU;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LolAccountManager
{
    public partial class MainForm : Form
    {
        private RiotClient _riotClient = null;
        private BindingSource _source = null;
        private BindingList<RiotAccount> _accounts;
        private ContextMenu _contextMenu = new System.Windows.Forms.ContextMenu();
        private MenuItem _menuItem1 = new System.Windows.Forms.MenuItem();

        public MainForm()
        {
            InitializeComponent();


            /*todo:
             BackgroundWorker_RankChecker.WorkerReportsProgress = true;
            BackgroundWorker_RankChecker.RunWorkerAsync();
            BackgroundWorker_ClientChecker.RunWorkerAsync();
            BackgroundWorker_ClientChecker.WorkerReportsProgress = true;
            
            */
        }

        private bool CheckIfHaveToRunminimized()
        {
            return CheckBox_StartMinimized.Checked;
        }


   

        public bool CheckIfRunOnStartupIsEnabled()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk.GetValueNames().Contains("LeagueAccountManager"))
            {
                CheckBox_LaunchStartup.Checked = true;
                return true;
            }

            return false;
        }

        public void GatherClientDetails()
        {
            try
            {
                _riotClient = new RiotClient();
                // MessageBox.Show("Client Details Obtained!");
                WriteToDebug($"Client password: {_riotClient.Password} ");
                statusLabel.Text = "Client Details Gathered!";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        public void WriteToDebug(string Msg)
        {
            if (Checkbox_DebugMode.Checked)
            {
                DebugLog.AppendText($"[{DateTime.Now:MM\\/dd\\/yyyy h\\:mm tt}] {Msg} {Environment.NewLine}");
            }
        }


        private void WriteDebugLogButton(object sender, EventArgs e)
        {
            if (File.Exists("debug_log.txt"))
            {
                File.Delete("debug_log.txt");
            }

            WriteToDebug("Writing Debug Log!");

            File.WriteAllText("debug_log.txt", DebugLog.Text);
            MessageBox.Show("debug_log.txt saved!");
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                var username = TextBox_AddAccount_LoginName.Text;


                var password = TextBox_Password.Text;

                RiotAccount account = new RiotAccount(username, password);

                if (_source == null)
                {
                    _accounts = new BindingList<RiotAccount>();
                    _source = new BindingSource(_accounts, null);
                    accountGridView.DataSource = _source;
                }

                foreach (RiotAccount acc in _source)
                {
                    if (string.Equals(acc.LoginName, account.LoginName))
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }
                }

                TextBox_AddAccount_LoginName.Text = "";
                if (!CheckBox_RememberPassword.Checked)
                {
                    TextBox_Password.Text = "";
                    //Empty Password
                }


                



                //Check if username is already in source


                _accounts.Add(account);
                accountGridView.Refresh();
                ApplyFilters();// Apply filters if a new account is created so it gets added to the ? filter.
                MessageBox.Show("Added new account");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ParseAccountFile()
        {
            if (!File.Exists("accounts.json"))
            {
                WriteToDebug("accounts.json does not exist.");
                Tabs.SelectedIndex = 2;
            }
            else
            {
                try
                {
                    _accounts =
                        JsonConvert.DeserializeObject<BindingList<RiotAccount>>(File.ReadAllText("accounts.json"));
                    WriteToDebug($"account.json loaded");
                    _source = new BindingSource(_accounts, null);
                    accountGridView.DataSource = _source;
                    ApplyFilters();
                }
                catch (Exception e)
                {
                    WriteToDebug($"ParseAccountFile: {e.Message}");
                    MessageBox.Show(e.Message);
                }
            }
        }


        private void Button_SaveAccounts_Click(object sender, EventArgs e)
        {
            var x = JsonConvert.SerializeObject(_accounts);
            File.WriteAllText("accounts.json", x);

            MessageBox.Show("Saved all accounts to file");
            WriteToDebug("Writing Accounts to json file!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("accounts.json"))
            {
                WriteToDebug("accounts.json does not exist.");
                MessageBox.Show("accounts.json does not exist. unable to load any accounts.");
                Tabs.SelectedIndex = 2;
                //
              
               
            }
            else
            {

                ParseAccountFile();
                filterComboBox.SelectedIndex = 0;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (CheckBox_HideLoginName.Checked)
            {
                if (e.ColumnIndex == 0 && e.Value != null)
                {
                    var password = new String('*', e.Value.ToString().Length);
                    //var first_letter = e.Value.ToString().ToCharArray();
                    e.Value = $"{password}";
                }
            }

            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('*', 12);
            }

            if (Checkbox_HideSummonerName.Checked)
            {
                if (e.ColumnIndex == 7 && e.Value != null)
                {
                    var SummonerName = new String('*', e.Value.ToString().Length);

                    e.Value = $"{SummonerName}";
                }
            }
        }


        private void ManageAccountButton4Click(object sender, EventArgs e)
        {
            try
            {
                RiotAccount currentObject = (RiotAccount) accountGridView.CurrentRow.DataBoundItem;

                ((Control) ManageAccountTab).Enabled = true;
                Tabs.SelectedIndex = 1;
                TextBox_ModifyAccount_LoginName.Text = currentObject.LoginName;
                TextBox_ModifyAccount_Password.Text = currentObject.Password;
                TextBox_ModifyAccount_Server.Text = currentObject.Server;
                TextBox_ModifyAccount_SummonerName.Text = currentObject.SummonerName;
                TextBox_ModifyAccount_SoloQueue.Text = currentObject.Solo_Duo_Rank;
                TextBox_ModifyAccount_FlexQueue.Text = currentObject.Flex_Rank;
            }
            catch (NullReferenceException exception)
            {
                WriteToDebug($"{exception.Message}");
                MessageBox.Show($"No account has been selected.");
            }
            catch (Exception exception)
            {
                WriteToDebug($"ManageAccountButton4Click {exception.Message}");
                MessageBox.Show($"{exception.Message}");
            }
        }

        private void CheckBox_LaunchStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (CheckBox_LaunchStartup.Checked)
                {
                    WriteToDebug("Run on startup enabled!");
                    Properties.Settings.Default.RunOnStartup = true;
                    rk.SetValue("LeagueAccountManager", Application.ExecutablePath);
                }

                else
                {
                    WriteToDebug("Run on startup disabled!");
                    rk.DeleteValue("LeagueAccountManager", false);
                }
            }
            catch (Exception exception)
            {
                WriteToDebug($"LaunchStartup: {exception.Message}");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            RiotAccount currentObject = (RiotAccount) accountGridView.CurrentRow.DataBoundItem;


            RiotAccount account = new RiotAccount(currentObject.LoginName, currentObject.Password);
            statusLabel.Text = "Trying to sign into Account!";
            WriteToDebug("Trying to sign into Account");


            WriteToDebug("Trying to login!");


            try
            {
                _riotClient = new RiotClient();
                _riotClient.Login(account);

                WriteToDebug("Logged in!");

                currentObject.SetSummonerName(_riotClient.RiotResponseAccount.SummonerName);
                currentObject.SetServer(_riotClient.RiotResponseAccount.Server);
                WriteToDebug("Obtained Summoner name!");

                accountGridView.Refresh();


                statusLabel.Text = $"Logged into: {currentObject.SummonerName}({currentObject.Server})";
            }

            catch (Exception exception)
            {
                statusLabel.Text = $"Error trying to login: {exception.Message}";
                WriteToDebug($"Login: {exception.Message}");
                MessageBox.Show(exception.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Disable Modify Account Tab On Form Load
            ((Control) ManageAccountTab).Enabled = false;
            filterComboBox.SelectedIndex = 0;
            LoadSettings();

            ParseAccountFile();
            CheckIfRunOnStartupIsEnabled();

 

            accountGridView.AutoGenerateColumns = false;
        }

        private void LoadSettings()
        {
            WriteToDebug($"Loading Settings!");
            if (Properties.Settings.Default.RunMinimized)
            {
                CheckBox_StartMinimized.Checked = true;
                Notify.Icon = SystemIcons.Information;
                Notify.Visible = true;
                Notify.ShowBalloonTip(5000, "LolAccountManager", "Running in the background!", ToolTipIcon.Info);
                WindowState = FormWindowState.Minimized;


                this._contextMenu.MenuItems.AddRange(
                    new MenuItem[] {this._menuItem1});

                this._menuItem1.Index = 0;
                this._menuItem1.Text = "Show Menu";
                this._menuItem1.Click += this._menuItem1_Click;


                Notify.ContextMenu = _contextMenu;
            }

            if (CheckIfRunOnStartupIsEnabled())
            {
                CheckBox_LaunchStartup.Checked = true;
            }

            if (Properties.Settings.Default.DebugMode)
            {
                Checkbox_DebugMode.Checked = true;
            }

            if (Properties.Settings.Default.GridAccountHideLoginName)
            {
                CheckBox_HideLoginName.Checked = true;
            }

            if (Properties.Settings.Default.GridAccountHideSummonerNameName)
            {
                Checkbox_HideSummonerName.Checked = true;
            }

            if (Properties.Settings.Default.AddAccountRememberPassword)
            {
                CheckBox_RememberPassword.Checked = true;
                TextBox_Password.Text = Properties.Settings.Default.AddAccountSavedPassword;
            }

            if (Properties.Settings.Default.AddAccountShowLoginName)
            {
                CheckBox_HideLoginName.Checked = true;
            }

            if (Properties.Settings.Default.AddAccountShowPassword)
            {
                CheckBox_Add_HidePassword.Checked = true;
            }


            if (Properties.Settings.Default.ManageAccountHideLoginName)
            {
                Checkbox_ManageAccount_HideLoginName.Checked = true;
            }

            if (Properties.Settings.Default.ManageAccountHidePassword)
            {
                Checkbox_ManageAccount_Password.Checked = true;
            }

            if (Properties.Settings.Default.ManageAccountHideSummonerName)
            {
                Checkbox_ManageAccount_HideSummonerName.Checked = true;
            }
        }

        private void _menuItem1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }


        private void SaveSettings()
        {
            Properties.Settings.Default.GridAccountHideLoginName = CheckBox_HideLoginName.Checked;
            Properties.Settings.Default.GridAccountHideSummonerNameName = Checkbox_HideSummonerName.Checked;
            Properties.Settings.Default.RunMinimized = CheckBox_StartMinimized.Checked;
            Properties.Settings.Default.DebugMode = Checkbox_DebugMode.Checked;
            Properties.Settings.Default.AddAccountRememberPassword = CheckBox_RememberPassword.Checked;

            if (CheckBox_RememberPassword.Checked)
            {
                //Save the password
                Properties.Settings.Default.AddAccountSavedPassword = TextBox_Password.Text;
            }


            Properties.Settings.Default.AddAccountShowLoginName = CheckBox_Add_HideUsername.Checked;
            Properties.Settings.Default.AddAccountShowPassword = CheckBox_Add_HidePassword.Checked;
            Properties.Settings.Default.ManageAccountHideLoginName = Checkbox_ManageAccount_HideLoginName.Checked;
            Properties.Settings.Default.ManageAccountHidePassword = Checkbox_ManageAccount_Password.Checked;
            Properties.Settings.Default.ManageAccountHideSummonerName = Checkbox_ManageAccount_HideSummonerName.Checked;

            Properties.Settings.Default.Save();
        }

        private void Button_SaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MessageBox.Show("Settings have been saved");
        }

        private void ButtonResetSettingsClick(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to reset your settings to the default settings?",
                    "LolAccountManager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // First save the settings before we reset them.
                SaveSettings();

                Properties.Settings.Default.Reset();
                WriteToDebug($"Resetting Settings!");

                MessageBox.Show("Default settings loaded!");
                LoadSettings();
            }
        }

        private void CheckBox_Add_HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Add_HidePassword.Checked)
            {
                TextBox_Password.UseSystemPasswordChar = true;
                return;
            }
            TextBox_Password.UseSystemPasswordChar = false;
        }

        private void CheckBox_Add_HideUsername_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_AddAccount_LoginName.UseSystemPasswordChar = CheckBox_Add_HideUsername.Checked;
        }

        private void ManageAccountTab_Click(object sender, EventArgs e)
        {
        }

        private void Button_ModifyAccount_SaveChanges_Click(object sender, EventArgs e)
        {
            RiotAccount currentObject = (RiotAccount) accountGridView.CurrentRow.DataBoundItem;
            currentObject.SetLoginName(TextBox_ModifyAccount_LoginName.Text);
            currentObject.SetPassword(TextBox_ModifyAccount_Password.Text);
            TextBox_ModifyAccount_LoginName.Text = "";
            TextBox_ModifyAccount_Password.Text = "";
            TextBox_ModifyAccount_Server.Text = "";
            TextBox_ModifyAccount_SummonerName.Text = "";
            TextBox_ModifyAccount_SoloQueue.Text = "";
            TextBox_ModifyAccount_FlexQueue.Text = "";


            ((Control) ManageAccountTab).Enabled = false;
            Tabs.SelectedIndex = 0;
            MessageBox.Show("Account modified!");
        }

        private void Button_ModifyAccount_DeleteAccount_Click(object sender, EventArgs e)
        {
            RiotAccount currentObject = (RiotAccount) accountGridView.CurrentRow.DataBoundItem;
            //Reset All Texboxes
            TextBox_ModifyAccount_LoginName.Text = "";
            TextBox_ModifyAccount_SummonerName.Text = "";
            TextBox_ModifyAccount_Server.Text = "";
            TextBox_ModifyAccount_Password.Text = "";
            TextBox_ModifyAccount_SoloQueue.Text = "";
            TextBox_ModifyAccount_FlexQueue.Text = "";
            TextBox_ModifyAccount_BE.Text = "";
            TextBox_ModifyAccount_RP.Text = "";

            _source.Remove(currentObject);
            ((Control) ManageAccountTab).Enabled = false;
            Tabs.SelectedIndex = 0;


            MessageBox.Show("Account Deleted!");
        }

        private void Button_ManageAccount_CopySummonerNameClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_ModifyAccount_SummonerName.Text);
        }

        private void Button_ManageAccount_CopyPasswordClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_ModifyAccount_Password.Text);
        }

        private void Button_ManageAccount_CopyLoginNameClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_ModifyAccount_LoginName.Text);
        }

        private void Button_ManageAccount_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (accountGridView.CurrentRow != null)
                {
                    RiotAccount currentObject = (RiotAccount) accountGridView.CurrentRow.DataBoundItem;
                    currentObject.SetLoginName(TextBox_ModifyAccount_LoginName.Text);
                    currentObject.SetPassword(TextBox_ModifyAccount_Password.Text);

                    _riotClient = new RiotClient();


                    _riotClient.Login(currentObject);

                    currentObject.SetSummonerName(_riotClient.RiotResponseAccount.SummonerName);
                    currentObject.SetServer(_riotClient.RiotResponseAccount.Server);


                    accountGridView.Refresh();

                    WriteToDebug("Logged in!");


                    statusLabel.Text = $"Logged into {currentObject.SummonerName}({currentObject.Server})";


                    TextBox_ModifyAccount_SummonerName.Text = currentObject.SummonerName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //We will use the textbox as input here, incase the user changed the login name for testing. 
        }

        private void CheckBox_RememberPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_RememberPassword.Checked)
            {
            }
        }


        private void Checkbox_ManageAccount_HideLoginName_CheckedChanged(object sender, EventArgs e)
        {
            // Manage Account 
            if (Checkbox_ManageAccount_HideLoginName.Checked)
            {
                TextBox_ModifyAccount_LoginName.UseSystemPasswordChar = true;
            }
        }

        private void Checkbox_ManageAccount_Password_CheckedChanged(object sender, EventArgs e)
        {
            // Manage Account 
            if (Checkbox_ManageAccount_Password.Checked)
            {
                TextBox_ModifyAccount_Password.UseSystemPasswordChar = true;
            }
        }

        private void Checkbox_ManageAccount_HideSummonerName_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_ManageAccount_HideSummonerName.Checked)
            {
                TextBox_ModifyAccount_SummonerName.UseSystemPasswordChar = true;
            }
            // Manage Account 
        }


        private void Button_ModifyAccount_GetRankedData_Click(object sender, EventArgs e)
        {
            try
            {
                LeagueClient leagueClient = new LeagueClient();


                RiotAccount currentObject = (RiotAccount)accountGridView.CurrentRow.DataBoundItem;

                leagueClient.GetStoreCredit();
                leagueClient.GetCurrentRankedStats();


                currentObject.be = leagueClient.LeagueClientStoreCredit.ip; //'ip' is the old name that got replaced with be
                currentObject.rp = leagueClient.LeagueClientStoreCredit.rp;



                TextBox_ModifyAccount_BE.Text = currentObject.be.ToString();
                TextBox_ModifyAccount_RP.Text = currentObject.rp.ToString();

                currentObject.Flex_Rank = leagueClient.LeagueClientRanked.Flex_Queue;
                TextBox_ModifyAccount_FlexQueue.Text = currentObject.Flex_Rank;


                currentObject.Solo_Duo_Rank = leagueClient.LeagueClientRanked.Solo_Queue;
                TextBox_ModifyAccount_SoloQueue.Text = currentObject.Solo_Duo_Rank;


                WriteToDebug("Ranked details gathered");
                
                

            }
            catch (Exception exception)
            {

                WriteToDebug($"Button_ModifyAccount_GetRankedData_Click: {exception.Message}");
                MessageBox.Show(exception.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ApplyFilters();
           

        }

        private void ApplyFilters()
        {
            
            string filter = filterComboBox.SelectedItem.ToString();
            WriteToDebug($"Applying filter: {filter}");

            if (_accounts == null)
            {
                WriteToDebug("No account binding list.");
                return;
            }

            if (filter == "ALL")
            {
                accountGridView.DataSource = _accounts;
                accountGridView.Update();

            }
            else

            {
                BindingList<RiotAccount> filtered =
                    new BindingList<RiotAccount>(_accounts.Where(obj => obj.Server.Contains(filter)).ToList());

                accountGridView.DataSource = filtered;
                accountGridView.Update();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }




        /* Todo: Finish writing background workers */
    }
}