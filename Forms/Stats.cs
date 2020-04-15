using System.Windows.Forms;

namespace VKFlaster.Forms
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, System.EventArgs e)
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
                        Label[] lbls = new Label[] { label1, label2, label3, label4, CommentsCount, errCount, rinneCount, activCount };
                        foreach (Label lbl in lbls)
                        {
                            lbl.BackColor = skin.BackGround_Color;
                            lbl.ForeColor = skin.Font_Color;
                        }
                    }

                    // Боксы
                    {
                        GroupBox[] Boxs = new GroupBox[] { groupBox1 };
                        foreach (GroupBox Box in Boxs)
                        {
                            Box.ForeColor = skin.Font_Color;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
