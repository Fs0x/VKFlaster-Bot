using System;
using System.IO;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class Proxy : Form
    {
        public API Api;

        public Proxy()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (check1.Checked && ProxyString.Text.Contains(":"))
            {
                int type = -1;

                if (checkHTTP.Checked)
                    type = 0;
                else if (checkSOCK4.Checked)
                    type = 1;
                else if (checkSOCK5.Checked)
                    type = 2;

                if (type >= 0)
                {
                    File.WriteAllText("Proxy.ini", ("[Proxy]\\nenable=1\\nip=" + ProxyString.Text.Split(':')[0] + "\\nport=" + ProxyString.Text.Split(':')[1] + "\\ntype=" + type.ToString().Replace("0", "http").Replace("1", "sock4").Replace("2", "sock5") + "\\n\\n").Replace("\\n", Environment.NewLine));
                    MessageBox.Show(@"Прокси успешно установлены.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    File.WriteAllText("Proxy.ini", ("[Proxy]\\nenable=0\\nip=\\nport=\\ntype=\\n\\n").Replace("\\n", Environment.NewLine));

                Api.Http.setProxy(ProxyString.Text, type);
            }
            else
                Api.Http.setProxy();

            Close();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked)
            {
                ProxyString.Enabled = true;
                Box1.Enabled = true;

                checkHTTP.Checked = true;
                checkSOCK4.Checked = false;
                checkSOCK5.Checked = false;
            }
            else
            {
                ProxyString.Text = "IP:Port";
                ProxyString.Enabled = false;
                Box1.Enabled = false;

                checkHTTP.Checked = false;
                checkSOCK4.Checked = false;
                checkSOCK5.Checked = false;

                Api.Http.setProxy();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkHTTP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHTTP.Checked)
            {
                checkSOCK4.Checked = false;
                checkSOCK5.Checked = false;
            }
            else if (!checkSOCK4.Checked && !checkSOCK5.Checked) checkHTTP.Checked = true;
        }

        private void checkSOCK4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSOCK4.Checked)
            {
                checkSOCK5.Checked = false;
                checkHTTP.Checked = false;
            }
            else if (!checkSOCK5.Checked && !checkHTTP.Checked) checkSOCK4.Checked = true;
        }

        private void checkSOCK5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSOCK5.Checked)
            {
                checkHTTP.Checked = false;
                checkSOCK4.Checked = false;
            }
            else if (!checkHTTP.Checked && !checkSOCK4.Checked) checkSOCK5.Checked = true;
        }

        private void ProxyString_Enter(object sender, EventArgs e)
        {
            if (ProxyString.Text.ToLower().Trim() == "ip:port")
                ProxyString.Text = null;
        }

        private void ProxyString_Leave(object sender, EventArgs e)
        {
            if (ProxyString.Text.Trim() == "")
                ProxyString.Text = "IP:Port";
        }

        private void Proxy_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы

                    // Шрифты
                    {
                        Label[] lbls = new Label[] { label1 };
                        foreach (Label lbl in lbls)
                        {
                            lbl.BackColor = skin.BackGround_Color;
                            lbl.ForeColor = skin.Font_Color;
                        }
                    }

                    // Кнопки
                    {
                        Button[] btns = new Button[] { btn_close, btn_save };
                        foreach (Button btn in btns)
                        {
                            btn.BackColor = skin.Button_Color;
                            btn.FlatAppearance.MouseOverBackColor = skin.Button_Color_focus;
                            btn.FlatAppearance.MouseDownBackColor = skin.Button_Color_click;
                            btn.ForeColor = skin.Button_Color_Font;
                        }
                    }

                    // Чек-боксы
                    {
                        CheckBox[] checks = new CheckBox[] { check1, checkHTTP, checkSOCK4, checkSOCK5 };
                        foreach (CheckBox check in checks)
                        {
                            check.BackColor = skin.BackGround_Color;
                            check.ForeColor = skin.Font_Color;
                        }
                    }

                    // Боксы
                    {
                        GroupBox[] Boxs = new GroupBox[] { Box1 };
                        foreach (GroupBox Box in Boxs)
                        {
                            Box.ForeColor = skin.Font_Color;
                        }
                    }

                    // Поля ввода
                    {
                        TextBox[] textboxs = new TextBox[] { ProxyString };
                        foreach (TextBox textbox in textboxs)
                        {
                            textbox.BackColor = skin.Edit_Color;
                            textbox.ForeColor = skin.Edit_Color_Font;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
