using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class Settings : Form
    {
        public API Api;
        public Main form;
        public Settings2 form2;

        public BaseComments Comments;
        public BaseGroups Groups;
        public BaseProfiles Profiles;

        public Settings()
        {
            InitializeComponent();
        }

        private void btn_settings2_Click(object sender, EventArgs e)
        {
            form2.form = form;
            form2.ShowDialog();
        }

        private void btn_comments_Click(object sender, EventArgs e)
        {
            Comments.form = form;
            Comments.ShowDialog();
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            Groups.form = form;
            Groups.Api = Api;
            Groups.ShowDialog();
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            Profiles.form = form;
            Profiles.Api = Api;
            Profiles.ShowDialog();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked) form.type = 0; else form.type = 1;

            btn_groups.Enabled = check1.Checked;
            btn_profiles.Enabled = !check1.Checked;
            check2.Checked = !check1.Checked;
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked) form.type = 1; else form.type = 0;

            btn_profiles.Enabled = check2.Checked;
            btn_groups.Enabled = !check2.Checked;
            check1.Checked = !check2.Checked;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            RegistryKey reg = null;
            try
            {
                reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\VKFlasterBot", true);
            }
            catch { try { reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true).CreateSubKey("VKFlasterBot", RegistryKeyPermissionCheck.ReadWriteSubTree); } catch { } }

            if (reg != null)
            {
                try
                {
                    // Основные настройки...
                    int var_check1 = check1.Checked ? 1 : 0;
                    int var_check2 = check2.Checked ? 1 : 0;


                    // Доп. настройки...
                    int var_imlike = form2.imlike.Checked ? 1 : 0;
                    int var_video = form2.check2.Checked ? 1 : 0;
                    int var_commentGroup = form2.checkBox1.Checked ? 1 : 0;


                    // Комментарии...
                    string comments = "";
                    if (Comments.comments.Items.Count > 0)
                        for (int i = 0; i < Comments.comments.Items.Count; i++)
                            comments += Comments.comments.Items[i].Text + "<attachment/>" + Comments.comments.Items[i].SubItems[2].Text + "<nextline/>";
                    else comments = "<null/>";

                    // Группы...
                    string groups = "";
                    if (Groups.groups.Items.Count > 0)
                        for (int i = 0; i < Groups.groups.Items.Count; i++)
                            groups += Groups.groups.Items[i].Text + "<group_id/>" + Groups.groups.Items[i].SubItems[1].Text + "<nextline/>";
                    else groups = "<null/>";

                    // Страницы...
                    string profiles = "";
                    if (Profiles.profiles.Items.Count > 0)
                        for (int i = 0; i < Profiles.profiles.Items.Count; i++)
                            profiles += Profiles.profiles.Items[i].Text + "<user_id/>" + Profiles.profiles.Items[i].SubItems[1].Text + "<nextline/>";
                    else profiles = "<null/>";


                    string[] settings = new string[] { var_check1.ToString(), var_check2.ToString(), var_imlike.ToString(), var_video.ToString(), var_commentGroup.ToString(),
                    comments.Trim(), groups.Trim(), profiles.Trim(), form2.group_id.Text.ToLower().Trim() };

                    reg.SetValue("Settings", ProtectedData.Protect(Encoding.UTF8.GetBytes(string.Join("<#TAG>", settings)), null, DataProtectionScope.CurrentUser), RegistryValueKind.Binary);
                    reg.Close();
                }
                catch { }
            }

            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы
                    Ico.BackColor = BackColor;

                    // Кнопки
                    {
                        Button[] btns = new Button[] { btn_comments, btn_groups, btn_profiles, btn_save, btn_settings2 };
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
                        CheckBox[] checks = new CheckBox[] { check1, check2 };
                        foreach (CheckBox check in checks)
                        {
                            check.BackColor = skin.BackGround_Color;
                            check.ForeColor = skin.Font_Color;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
