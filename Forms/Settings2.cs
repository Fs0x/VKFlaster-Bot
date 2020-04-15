using System;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class Settings2 : Form
    {
        public Main form;

        public Settings2()
        {
            InitializeComponent();
        }

        private void imlike_CheckedChanged(object sender, EventArgs e)
        {
            form.imlike = imlike.Checked;
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            form.video_comment = check2.Checked;
        }

        private void group_id_Enter(object sender, EventArgs e)
        {
            if (group_id.Text.ToLower().Trim() == "group id")
                group_id.Text = null;
        }

        private void group_id_Leave(object sender, EventArgs e)
        {
            if (group_id.Text.Trim() == "")
                group_id.Text = "Group Id";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            group_id.Enabled = checkBox1.Checked;
        }

        private void Settings2_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы

                    // Чек-боксы
                    {
                        CheckBox[] checks = new CheckBox[] { imlike, check2, checkBox1 };
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
                        TextBox[] textboxs = new TextBox[] { group_id };
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
