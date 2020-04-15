using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using VKFlaster.Forms;

namespace VKFlaster
{
    public partial class Auth : Form
    {
        protected API Api = new API();
        protected Main form = new Main();
        protected Proxy form2 = new Proxy();
        protected byte[] Password = /*Encoding.UTF8.GetBytes(Environment.UserName)*/new byte[] { 0, 23, 64, 22, 21, 0, 0, 0, 1, 1, 0, 112, 74, 31, 46, 19, 6, 0, 0 , 1, 24 };
        protected int numberAccount = Process.GetProcessesByName(Path.GetFileName(Assembly.GetExecutingAssembly().Location).Split('.')[0]).Length;
        protected string Token = null;

        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы
                    Ico.BackColor = BackColor;

                    // Шрифты
                    {
                        Label[] lbls = new Label[] { label1, label2, label3, version, about };
                        foreach (Label lbl in lbls)
                        {
                            lbl.BackColor = skin.BackGround_Color;
                            lbl.ForeColor = skin.Font_Color;
                        }
                    }

                    // Кнопки
                    {
                        Button[] btns = new Button[] { btn_close, btn_auth, saveAccount };
                        foreach(Button btn in btns)
                        {
                            btn.BackColor = skin.Button_Color;
                            btn.FlatAppearance.MouseOverBackColor = skin.Button_Color_focus;
                            btn.FlatAppearance.MouseDownBackColor = skin.Button_Color_click;
                            btn.ForeColor = skin.Button_Color_Font;
                        }
                    }

                    // Чек-боксы
                    {
                        CheckBox[] checks = new CheckBox[] { check1 };
                        foreach (CheckBox check in checks)
                        {
                            check.BackColor = skin.BackGround_Color;
                            check.ForeColor = skin.Font_Color;
                        }
                    }

                    // Поля ввода
                    {
                        TextBox[] textboxs = new TextBox[] { login, password };
                        foreach (TextBox textbox in textboxs)
                        {
                            textbox.BackColor = skin.Edit_Color;
                            textbox.ForeColor = skin.Edit_Color_Font;
                        }
                    }
                }
                catch { }
            }

            try
            {
                if (numberAccount == 0) numberAccount = 1;
                version.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

                if (File.Exists("Proxy.ini"))
                {
                    IniFiles ini = new IniFiles("Proxy.ini");

                    string ip = ini.ReadINI("Proxy", "ip");
                    int enable = int.Parse(ini.ReadINI("Proxy", "enable"));
                    int port = int.Parse(ini.ReadINI("Proxy", "port"));
                    int type = int.Parse(ini.ReadINI("Proxy", "type").ToLower().Replace("http", "0").Replace("sock4", "1").Replace("sock5", "2"));

                    if (enable == 1)
                    {
                        form2.check1.Checked = true;

                        if (ip.Trim() != "" && port != 0 && port.ToString().Trim() != "" && port.ToString().Length >= 2)
                        {
                            form2.ProxyString.Text = ip + ":" + port;

                            if (type == 0)
                                form2.checkHTTP.Checked = true;
                            else if (type == 1)
                                form2.checkSOCK4.Checked = true;
                            else if (type == 2)
                                form2.checkSOCK5.Checked = true;

                            if (type == 0 || type == 1 || type == 2)
                                Api.Http.setProxy(ip + ":" + port, type);
                        }
                    }
                }
            }
            catch { }

            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\VKFlasterBot");
                object read = reg.GetValue("account" + numberAccount);
                reg.Close();

                if (read == null) return;
                else
                {
                    byte[] data = ProtectedData.Unprotect((byte[])read, Password, DataProtectionScope.CurrentUser);
                    string Token = Encoding.UTF8.GetString(data);

                    if (Api.CheckToken(Token))
                    {
                        this.Token = Token;

                        Api.setToken(Token);
                        Api.Isauth = true;

                        var account = Api.Inquiry("users.get", "name_case=acc")[0];
                        Api.user_id = account["id"].ToString();
                        saveAccount.Text += $" {account["first_name"]} {account["last_name"]}";
                        saveAccount.Visible = true;
                    }
                }
            }
            catch { }
        }

        protected void LoadForm()
        {
            try
            {
                Hide();
                var account = Api.Inquiry("users.get")[0];

                form.Text = string.Format("VKFlaster Bot {2}         | ---> Аккаунт: {0} {1}", account["first_name"], account["last_name"], version.Text);
                form.Api = Api;
                form.hash = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(login.Text + password.Text)));
                form.ShowDialog();
            }
            catch (Exception E) { MessageBox.Show(E.Message + "\n\n\n" + E.StackTrace); MessageBox.Show(@"Произошла неизвестная ошибка. (Закрытие программы)", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            Environment.Exit(0);
        }

        protected void __Auth()
        {
            if (login.Text.Trim() != "" && password.Text.Trim() != "")
            {
                if (!Api.auth(login.Text, password.Text))
                    MessageBox.Show(@"Ошибка: Неверный логин\пароль.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (check1.Checked)
                    {
                        RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true).CreateSubKey("VKFlasterBot", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        reg.SetValue("account" + numberAccount, ProtectedData.Protect(Encoding.UTF8.GetBytes(Api.getToken()), Password, DataProtectionScope.CurrentUser));
                        reg.Close();
                    }
                    else
                        Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true).DeleteSubKey("VKFlasterBot", false);

                    try
                    {
                        LoadForm();
                    }
                    catch { MessageBox.Show(@"Произошла неизвестная ошибка. (Закрытие программы)", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    Environment.Exit(0);
                }
            }
            else
                MessageBox.Show(@"Ошибка: Укажите логин\пароль. (Если Вы используете прокси, то скорее всего они нерабочие.)", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            __Auth();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            form2.Api = Api;
            form2.ShowDialog();
        }

        private void saveAccount_Click(object sender, EventArgs e)
        {
            if (Token != null && Api.CheckToken(Token))
            {
                Api.setToken(Token);
                Api.Isauth = true;

                LoadForm();
            }
            else
                MessageBox.Show(@"Ошибка: похоже токен устарел. (Войдите в аккаунт через логин и пароль)", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text.Trim().ToLower() == "ваш пароль")
            {
                password.Text = "";
                password.PasswordChar = '•';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text.Trim() == "")
            {
                password.Text = "Ваш пароль";
                password.PasswordChar = (char)0;
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                __Auth();
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text.Trim().ToLower() == "ваш логин") login.Text = "";
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text.Trim() == "") login.Text = "Ваш логин";
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                __Auth();
        }

        protected static System.Threading.Thread thread = null;
        private void Auth_Deactivate(object sender, EventArgs e)
        {
            thread = new System.Threading.Thread(delegate ()
            {
                Action action;

                while (true)
                {
                    System.Threading.Thread.Sleep(50);
                    if (Opacity > 0.90)
                    {
                        action = () => Opacity -= 0.01;
                        if (InvokeRequired) Invoke(action); else action();
                    }
                    else
                        break;
                }
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void Auth_Activated(object sender, EventArgs e)
        {
            Opacity = 1;
            if (thread != null) thread.Abort();
        }
    }
}
