using System;
using System.IO;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class BaseGroups : Form
    {
        public Main form;
        public API Api;

        public BaseGroups()
        {
            InitializeComponent();
        }

        protected void AddGroup()
        {
            string _url = url.Text.Trim().Replace("https://", "").Replace("http://", "").Replace("vk.com/", "").Replace("public", "").Replace("club", "");
            if (_url == "") return;
            else
            {
                var response = Api.Inquiry("groups.getById", "group_id=" + _url);
                if (response != null)
                {
                    if (groups.FindItemWithText("@" + response[0]["id"].ToString()) == null)
                        groups.Items.Add("@" + response[0]["name"].ToString()).SubItems.Add("@" + response[0]["id"].ToString());
                    else
                        MessageBox.Show(@"Ошибка: данная группа уже имеется в базе.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPEN = new OpenFileDialog()
            {
                Filter = "База-групп (*.TXT)|*.TXT"
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
                        groups.Items.Clear();
                        foreach (string _group in data)
                        {
                            string _url = _group.Replace("https://", "").Replace("http://", "").Replace("vk.com/", "").Replace("public", "").Replace("club", "").Trim();
                            if (_url == "") continue;
                            else
                            {
                                var response = Api.Inquiry("groups.getById", "group_id=" + _url);
                                if (response != null)
                                    if (groups.FindItemWithText("@" + response[0]["id"].ToString()) == null)
                                        groups.Items.Add("@" + response[0]["name"].ToString()).SubItems.Add("@" + response[0]["id"].ToString());
                            }
                        }

                        MessageBox.Show(@"База-групп успешно загружена.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(@"Ошибка: база-групп не действительна.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { }
            }
        }

        public void PUBLIC_AddGroup(string name, string id)
        {
            groups.Items.Add(name).SubItems.Add(id);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddGroup();
        }

        private void url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddGroup();
        }

        private void url_Enter(object sender, EventArgs e)
        {
            if (url.Text.Trim().ToLower().Replace("https://", "").Replace("http://", "") == "vk.com/public000")
                url.Text = null;
        }

        private void url_Leave(object sender, EventArgs e)
        {
            if (!url.Text.Trim().ToLower().Contains("vk.com")
                || url.Text.Trim().ToLower().Replace("https://", "").Replace("http://", "") == "vk.com/public000")
                url.Text = "vk.com/public000";
        }

        private void удалитьИзБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groups.SelectedIndices.Count > 0)
                for (int i = 0; i < groups.SelectedIndices.Count; i++)
                    groups.Items.RemoveAt(groups.SelectedIndices[i]);
        }

        private void BaseGroups_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы
                    groups.BackColor = skin.BackGround_Color;
                    groups.ForeColor = skin.Font_Color;

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
