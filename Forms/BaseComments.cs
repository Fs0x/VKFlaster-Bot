using System;
using System.IO;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class BaseComments : Form
    {
        public API Api;
        public Main form;
        public string var_attachment = null;

        public BaseComments()
        {
            InitializeComponent();
        }

        protected void AddComments()
        {
            if (comment.Text.Trim() != "")
            {
                string attachment = null;

                if (var_attachment == null)
                    attachment = "Ничего не прикреплено";
                else
                {
                    if (var_attachment.Contains("photo"))
                        attachment = "Прикреплена фотография";
                    else if (var_attachment.Contains("audio"))
                        attachment = "Прикреплена музыка";
                    else if (var_attachment.Contains("doc"))
                        attachment = "Прикреплен документ";
                    else if (var_attachment.Contains("sticker"))
                        attachment = "Прикреплен стикер";
                }

                if (comments.FindItemWithText(comment.Text.Trim()) == null)
                {
                    if (var_attachment == null) var_attachment = "null";
                    comments.Items.Add(comment.Text.Trim()).SubItems.AddRange(new string[] { attachment, var_attachment });
                    var_attachment = null;
                }
                else
                    MessageBox.Show(@"Ошибка: данный комментарий уже имеется в базе.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(@"Ошибка: Вы не указали текст комментария.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PUBLIC_AddComments(string text, string __attachment)
        {
            string attachment;

            if (__attachment.Contains("photo"))
                attachment = "Прикреплена фотография";
            else if (__attachment.Contains("video"))
                attachment = "Прикреплена видеозапись";
            else if (__attachment.Contains("audio"))
                attachment = "Прикреплена музыка";
            else if (__attachment.Contains("doc"))
                attachment = "Прикреплен документ";
            else if (__attachment.Contains("sticker"))
                attachment = "Прикреплен стикер";
            else
                attachment = "Ничего не прикреплено";

            comments.Items.Add(text).SubItems.AddRange(new string[] { attachment, __attachment });
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPEN = new OpenFileDialog()
            {
                Filter = "База-комментариев (*.TXT)|*.TXT"
            };

            if (OPEN.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string attachment = null;
                    string attachment2 = null;
                    string[] data = null;

                    if (File.ReadAllText(OPEN.FileName).Trim() != "")
                        data = File.ReadAllLines(OPEN.FileName);

                    if (data != null && data.Length >= 1)
                    {
                        comments.Items.Clear();
                        foreach (string _comment in data)
                        {
                            string[] Params = _comment.Split('@');

                            if (Params[0].Trim() != "")
                            {
                                if (Params.Length > 1)
                                {
                                    if (Params[1].Contains("photo"))
                                        attachment = "Прикреплена фотография";
                                    else if (Params[1].Contains("video"))
                                        attachment = "Прикреплена видеозапись";
                                    else if (Params[1].Contains("audio"))
                                        attachment = "Прикреплена музыка";
                                    else if (Params[1].Contains("doc"))
                                        attachment = "Прикреплен документ";
                                    else if (Params[1].Contains("sticker"))
                                        attachment = "Прикреплен стикер";
                                    else attachment = "Ничего не прикреплено";

                                    attachment2 = Params[1];
                                }
                                else
                                {
                                    attachment = "Ничего не прикреплено";
                                    attachment2 = "null";
                                }

                                if (comments.FindItemWithText(Params[0].Trim()) == null)
                                    comments.Items.Add(Params[0].Trim()).SubItems.AddRange(new string[] { attachment, attachment2.Trim() });
                            }
                        }

                        MessageBox.Show(@"База-комментариев успешно загружена.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(@"Ошибка: база-комментариев не действительна.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddComments();
        }

        private void btn_addFile_Click(object sender, EventArgs e)
        {
            attachment attach = new attachment();
            attach.form = this;
            attach.ShowDialog();
        }

        private void удалитьИзБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comments.SelectedIndices.Count > 0)
                for (int i = 0; i < comments.SelectedIndices.Count; i++)
                    comments.Items.RemoveAt(comments.SelectedIndices[i]);
        }

        private void comment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddComments();
        }

        private void BaseComments_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы
                    comments.BackColor = skin.BackGround_Color;
                    comments.ForeColor = skin.Font_Color;

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
                        Button[] btns = new Button[] { btn_add, btn_addFile, btn_LoadFile };
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
                        TextBox[] textboxs = new TextBox[] { comment };
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
