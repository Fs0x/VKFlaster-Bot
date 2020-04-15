using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Text;

namespace VKFlaster.Forms
{
    public partial class Main : Form
    {
        protected Settings form = new Settings();
        protected Settings2 form2 = new Settings2();

        protected static BaseComments Comments = new BaseComments();
        protected static BaseGroups Groups = new BaseGroups();
        protected static BaseProfiles Profiles = new BaseProfiles();

        protected static Stats Statsform = new Stats();

        public API Api;
        public ListView comments_list = Comments.comments;
        public ListView groups_list = Groups.groups;
        public ListView profiles_list = Profiles.profiles;

        public string hash;

        // Настройки
        public int type = 0;
        public bool imlike = false;
        public bool video_comment = false;

        protected Thread thread = null;

        public Main()
        {
            InitializeComponent();
        }

        protected void __threadBot()
        {
            Action action = null;
            int unix = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            int CommentsCount = 0;
            int errCount = 0;
            int activCount = 0;
            int view = 0;

            try
            {
                {
                    var response = Api.Inquiry("wall.get",  $"owner_id={Api.user_id}&count=1&filter=owner");

                    if (response != null && response["items"].Value<JArray>().Count > 0 && response["items"][0].ToObject<JObject>().ContainsKey("views"))
                        view = int.Parse(response["items"][0]["views"]["count"].ToString());
                    else
                        view = 0;
                }

                string check = "";

                ListView ListView;
                ListViewItem Collection;

                string Id;
                string ObjectId;
                string ObjectType;
                string message;
                string attachment;
                string logs = null;

                List<string> list = new List<string>();

                int Count;
                if (type == 0)
                {
                    Count = groups_list.Items.Count;
                    ListView = groups_list;
                }
                else
                {
                    Count = profiles_list.Items.Count;
                    ListView = profiles_list;
                }

                for (int i = 0; i < Count; i++)
                    list.Add(ListView.Items[i].SubItems[1].Text.Substring(1));

                while (true)
                {
                    var response = Api.Inquiry("newsfeed.get", string.Format("count={1}&start_time={0}", unix, 5));
                    check = "";

                    if (response != null && response["items"].Value<JArray>().Count > 0
                        && int.Parse(response["items"][0]["date"].ToString()) >= unix)
                    {
                        try
                        {
                            for (int k = 0; k < response["items"].Value<JArray>().Count; k++)
                            {
                                ObjectType = response["items"][k]["type"].ToString();
                                Id = response["items"][k]["source_id"].ToString().Replace("-", "");

                                if (ObjectType == "post")
                                    ObjectId = response["items"][k]["post_id"].ToString();
                                else if (ObjectType == "video")
                                    ObjectId = response["items"][k]["video"]["items"][0]["id"].ToString();
                                else
                                    continue;

                                if (!check.Contains(Id + ObjectId))
                                {
                                    check += (Id + ObjectId);

                                    if (Count > 0) if (!list.Contains(Id)) continue;

                                    if (comments_list.Items.Count > 1)
                                        Collection = comments_list.Items[(new Random()).Next(0, comments_list.Items.Count - 1)];
                                    else
                                        Collection = comments_list.Items[0];

                                    message = Collection.Text.Replace("\\n", "\n").Trim();
                                    attachment = Collection.SubItems[2].Text;

                                    {
                                        if (type == 0 && response["groups"].Value<JArray>().Count > 0)
                                        {
                                            logs = string.Format((ObjectType == "post"
                                                ? "Комментарий успешно оставлен. ({0} / vk.com/public{1}?w=wall-{1}_{2})"
                                                : "Комментарий успешно оставлен. ({0} / vk.com/video-{1}_{2}"),
                                                    response["groups"][0]["name"].ToString(), Id, ObjectId) + Environment.NewLine + (video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост...");

                                            Id = "-" + Id;
                                        }
                                        else if (type == 1 && response["profiles"].Value<JArray>().Count > 0)
                                            logs = string.Format((ObjectType == "post"
                                                ? "Комментарий успешно оставлен. ({0} / vk.com/id{1}?w=wall{1}_{2})"
                                                : "Комментарий успешно оставлен. ({0} / vk.com/id{1}?z=video{1}_{2})"),
                                                        (response["profiles"][0]["first_name"].ToString() + " " + response["profiles"][0]["last_name"].ToString()), Id, ObjectId) + Environment.NewLine + (video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост...");
                                        else
                                            continue;
                                    }


                                    // Отправка комментария...

                                    if (ObjectType == "post")
                                        response = Api.Inquiry("wall.createComment", string.Format("owner_id={1}&post_id={2}&message={0}&attachments={3}{4}{5}", message, Id, ObjectId, attachment, (form2.checkBox1.Checked ? ("&from_group=" + form2.group_id.Text.Trim().Replace("-", "")) : ""), (attachment.Contains("sticker") ? attachment.Replace("sticker", "&sticker_id=") : "")));
                                    else if (ObjectType == "video")
                                        response = Api.Inquiry("video.createComment", string.Format("owner_id={1}&video_id={2}&message={0}&attachments={3}{4}", message, Id, ObjectId, attachment, (attachment.Contains("sticker") ? attachment.Replace("sticker", "&sticker_id=") : "")));

                                    if (response != null)
                                    {
                                        if (imlike) Api.Inquiry("likes.add", string.Format("type={0}&item_id={1}&owner_id={2}",
                                            (ObjectType == "post" ? "comment" : "video_comment"),
                                            (ObjectType == "post" ? response["comment_id"] : response), Id));

                                        response = Api.Inquiry("wall.getComments", string.Format("owner_id={0}&post_id={1}&count=100&extended=false&need_likes=false&sort=asc", Id, ObjectId));
                                        if (response != null && response["count"].ToObject<int>() > 0)
                                        {
                                            for (int i = 0; i < response["count"].ToObject<int>(); i++)
                                            {
                                                if (response["items"].Value<JArray>()[i]["from_id"].ToString().Contains(Api.user_id))
                                                {
                                                    logs = string.Format("[TOP-{0}] ", (i + 1)) + logs;
                                                    break;
                                                }
                                            }
                                        }

                                        action = () => data.Text = data.Text.Replace((video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост..."), "").Trim() + Environment.NewLine + string.Format("[{0}]" + (logs.Contains("[TOP-") ? logs : (" " + logs)), DateTime.Now.ToLongTimeString());
                                        CommentsCount++;
                                    }
                                    else
                                        errCount++;

                                    // Отправка сообщения в лог...

                                    if (action != null)
                                    {
                                        try { if (InvokeRequired) Invoke(action); else action(); } catch { }
                                        action = null;
                                    }

                                    Thread.Sleep(2 * 1000);
                                }
                            }
                        }
                        catch { }

                        Thread.Sleep(1 * 1000);
                        unix = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
                    }
                }
            }
            catch (ThreadAbortException)
            {
                {
                    var response = Api.Inquiry("wall.get", "owner_id=" + Api.user_id + "&count=1&filter=owner");
                    if (response != null && int.Parse(response["count"].ToString()) > 0)
                        view = (int.Parse(response["items"][0]["views"]["count"].ToString()) - view);
                }

                {
                    var response = Api.Inquiry("notifications.get", "count=100&filters=likes,comments,mentions&start_time=" + unix);
                    if (response != null)
                        activCount = (int.Parse(response["count"].ToString()) + view);
                }

                action = () =>
                {
                    Statsform.CommentsCount.Text = CommentsCount.ToString();
                    Statsform.errCount.Text = errCount.ToString();
                    Statsform.activCount.Text = activCount.ToString();
                    Statsform.rinneCount.Text = view.ToString();
                };
                try { if (InvokeRequired) Invoke(action); else action(); } catch { }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Skins skin = new Skins();
            if (skin.skinLoader)
            {
                try
                {
                    BackColor = skin.BackGround_Color;   // Фон программы

                    Menu.BackColor = skin.MenuStrip_Color;

                    foreach (ToolStripMenuItem Item in Menu.Items)
                    {
                        Item.BackColor = skin.MenuStrip_Color;
                        Item.ForeColor = skin.MenuStrip_Color_Font;
                    }

                    // Фон панели
                    {
                        BoxGray.BackColor = skin.Panel_Color;
                        BoxGray.ForeColor = skin.Panel_Color;
                        BoxGray.FlatAppearance.BorderColor = skin.Panel_Color;
                        BoxGray.FlatAppearance.MouseDownBackColor = skin.Panel_Color;
                        BoxGray.FlatAppearance.MouseOverBackColor = skin.Panel_Color;
                    }
                    Ico.BackColor = BoxGray.BackColor;

                    // Кнопки
                    {
                        Button[] btns = new Button[] { btn_start, btn_stop, btn_settings, btn_vk, btn_stats };
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
                        TextBox[] textboxs = new TextBox[] { data };
                        foreach (TextBox textbox in textboxs)
                        {
                            textbox.BackColor = skin.Edit_Color;
                            textbox.ForeColor = skin.Edit_Color_Font;
                        }
                    }


                }
                catch { }
            }

            data.Text = "======================== ЛОГ ========================" + Environment.NewLine;

            RegistryKey reg;
            try
            {
                reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\VKFlasterBot");
                object data = reg.GetValue("Settings");
                string[] settings;

                if (data != null)
                {
                    settings = (Encoding.UTF8.GetString(ProtectedData.Unprotect((byte[])data, null, DataProtectionScope.CurrentUser))).Split(new string[] { "<#TAG>" }, StringSplitOptions.None);

                    form.form = this;
                    form2.form = this;

                    {
                        if (settings[0] == "0")
                            form.check1.Checked = false;

                        if (settings[2] == "1")
                            form2.imlike.Checked = true;

                        if (settings[3] == "1")
                            form2.check2.Checked = true;

                        if (settings[4] == "1")
                            form2.checkBox1.Checked = true;
                    }

                    {
                        if (settings[5] != "<null/>")
                        {
                            string[] lines = settings[5].Split(new string[] { "<nextline/>" }, StringSplitOptions.None);
                            for(int i = 0; i < lines.Length-1; i++)
                            {
                                string[] _Params = lines[i].Split(new string[] { "<attachment/>" }, StringSplitOptions.None);
                                Comments.PUBLIC_AddComments(_Params[0], _Params[1]);
                            }
                        }
                    }

                    {
                        if (settings[6] != "<null/>")
                        {
                            string[] lines = settings[6].Split(new string[] { "<nextline/>" }, StringSplitOptions.None);
                            for(int i = 0; i < lines.Length-1; i++)
                            {
                                string[] _Params = lines[i].Split(new string[] { "<group_id/>" }, StringSplitOptions.None);
                                Groups.PUBLIC_AddGroup(_Params[0], _Params[1]);
                            }
                        }
                    }

                    {
                        if (settings[7] != "<null/>")
                        {
                            string[] lines = settings[7].Split(new string[] { "<nextline/>" }, StringSplitOptions.None);
                            for(int i = 0; i < lines.Length-1; i++)
                            {
                                string[] _Params = lines[i].Split(new string[] { "<user_id/>" }, StringSplitOptions.None);
                                Profiles.PUBLIC_AddProfiles(_Params[0], _Params[1]);
                            }
                        }
                    }

                    form2.group_id.Text = settings[8].ToLower().Trim();
                }
            }
            catch { }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (comments_list.Items.Count > 0)
            {
                Statsform.CommentsCount.Text = "0";
                Statsform.errCount.Text = "0";
                Statsform.activCount.Text = "0";

                btn_start.Enabled = false;
                btn_settings.Enabled = false;
                btn_stats.Enabled = false;
                btn_stop.Enabled = true;

                data.Text = "======================== ЛОГ ========================" + Environment.NewLine + (video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост...");

                thread = new Thread(__threadBot)
                {
                    IsBackground = true
                };
                thread.Start();
            }
            else
                MessageBox.Show(@"Ошибка: пожалуйста, добавьте хоть 1 комментарий в базу. (Настройки -> База комментариев)", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_settings.Enabled = true;
            btn_stats.Enabled = true;
            btn_stop.Enabled = false;

            try
            {
                if (thread != null)
                {
                    thread.Abort();
                    thread = null;
                }
            }
            catch { }

            data.Text = data.Text.Replace((video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост..."), "").Trim();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            form.Api = Api;

            form.form = this;
            form.form2 = form2;

            form.Comments = Comments;
            form.Groups = Groups;
            form.Profiles = Profiles;

            form.ShowDialog();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            Statsform.ShowDialog();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Text = "======================== ЛОГ ========================" + Environment.NewLine
                + (thread != null ? (video_comment ? "Ожидаем новый пост/видео..." : "Ожидаем новый пост...") : null);
        }

        private void btn_vk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id143682623");
        }

        private void BoxGray_Click(object sender, EventArgs e)
        {

        }

        protected static Thread thread0 = null;
        private void Main_Deactivate(object sender, EventArgs e)
        {
            thread0 = new Thread(delegate ()
            {
                Action action;

                while (true)
                {
                    Thread.Sleep(50);
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
            thread0.Start();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            Opacity = 1;
            if (thread0 != null) thread0.Abort();
        }
    }
}
