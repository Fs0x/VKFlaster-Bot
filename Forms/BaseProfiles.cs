using System;
using System.IO;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class BaseProfiles : Form
    {
        public Main form;
        public API Api;

        public BaseProfiles()
        {
            InitializeComponent();
        }

        protected void AddProfiles()
        {
            string _url = url.Text.Trim().ToLower().Replace("https://", "").Replace("http://", "").Replace("vk.com/", "");
            if (_url == "") return;
            else
            {
                var response = Api.Inquiry("users.get", "user_ids=" + _url);
                if (response != null)
                {
                    string full_name = response[0]["first_name"].ToString() + " " + response[0]["last_name"].ToString();
                    if (profiles.FindItemWithText("@" + full_name) == null)
                        profiles.Items.Add("@" + full_name).SubItems.Add("@" + response[0]["id"].ToString());
                    else
                        MessageBox.Show(@"Ошибка: данная страница уже имеется в базе.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPEN = new OpenFileDialog()
            {
                Filter = "База-страниц (*.TXT)|*.TXT"
            };

            if (OPEN.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] data = null;

                    if (File.ReadAllText(OPEN.FileName).Trim() != "")
                        data = File.ReadAllLines(OPEN.FileName);

                    if (data != null && data.Length >= 1)
                    {
                        profiles.Items.Clear();
                        foreach (string _profiles in data)
                        {
                            string _url = _profiles.Trim().ToLower().Replace("https://", "").Replace("http://", "").Replace("vk.com/", "");
                            if (_url == "") continue;
                            else
                            {
                                var response = Api.Inquiry("users.get", "user_ids=" + _url);
                                if (response != null)
                                {
                                    string full_name = response[0]["first_name"].ToString() + " " + response[0]["last_name"].ToString();
                                    if (profiles.FindItemWithText("@" + full_name) == null)
                                        profiles.Items.Add("@" + full_name).SubItems.Add("@" + response[0]["id"].ToString());
                                }
                            }
                        }

                        MessageBox.Show(@"База-страниц успешно загружена.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(@"Ошибка: база-страниц не действительна.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { }
            }
        }

        public void PUBLIC_AddProfiles(string name, string id)
        {
            profiles.Items.Add(name).SubItems.Add(id);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProfiles();
        }

        private void url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddProfiles();
        }

        private void url_Enter(object sender, EventArgs e)
        {
            if (url.Text.Trim().ToLower().Replace("https://", "").Replace("http://", "") == "vk.com/id0")
                url.Text = null;
        }

        private void url_Leave(object sender, EventArgs e)
        {
            if (!url.Text.Trim().ToLower().Contains("vk.com")
                || url.Text.Trim().ToLower().Replace("https://", "").Replace("http://", "") == "vk.com/id0")
                url.Text = "vk.com/id0";
        }

        private void удалитьИзБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profiles.SelectedIndices.Count > 0)
                for (int i = 0; i < profiles.SelectedIndices.Count; i++)
                    profiles.Items.RemoveAt(profiles.SelectedIndices[i]);
        }

        private void BaseProfiles_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы
                    profiles.BackColor = skin.BackGround_Color;
                    profiles.ForeColor = skin.Font_Color;

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
                        Button[] btns = new Button[] { btn_add, btn_LoadFile };
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
                        TextBox[] textboxs = new TextBox[] { url };
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
