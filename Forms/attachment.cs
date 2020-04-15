using System;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class attachment : Form
    {
        public BaseComments form;

        public attachment()
        {
            InitializeComponent();
        }

        protected void AddAttach()
        {
            if (attach.Text.Trim() != "" && (attach.Text.Contains("photo") || attach.Text.Contains("video") || attach.Text.Contains("audio") || attach.Text.Contains("docs") || attach.Text.Contains("sticker")))
            {
                form.var_attachment = attach.Text.Trim();
                Close();
            }
            else
                MessageBox.Show(@"Ошибка: Вы не указали влажение.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddAttach();
        }

        private void attach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddAttach();
        }

        private void attachment_Load(object sender, EventArgs e)
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
                        Button[] btns = new Button[] { btn_add };
                        foreach (Button btn in btns)
                        {
                            btn.BackColor = skin.Button_Color;
                            btn.FlatAppearance.MouseOverBackColor = skin.Button_Color_focus;
                            btn.FlatAppearance.MouseDownBackColor = skin.Button_Color_click;
                            btn.ForeColor = skin.Button_Color_Font;
                        }
                    }

                    // Поля ввода
                    {
                        TextBox[] textboxs = new TextBox[] { attach };
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
