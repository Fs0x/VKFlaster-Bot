namespace VKFlaster.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BoxGray = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ico = new System.Windows.Forms.PictureBox();
            this.btn_vk = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxGray
            // 
            this.BoxGray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BoxGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.BoxGray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.BoxGray.FlatAppearance.BorderSize = 0;
            this.BoxGray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.BoxGray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.BoxGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxGray.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxGray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.BoxGray.Location = new System.Drawing.Point(0, -1);
            this.BoxGray.Name = "BoxGray";
            this.BoxGray.Size = new System.Drawing.Size(162, 305);
            this.BoxGray.TabIndex = 11;
            this.BoxGray.UseVisualStyleBackColor = false;
            this.BoxGray.Click += new System.EventHandler(this.BoxGray_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_stop.Enabled = false;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_stop.Location = new System.Drawing.Point(12, 46);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(140, 31);
            this.btn_stop.TabIndex = 13;
            this.btn_stop.Text = "Стоп";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(140, 31);
            this.btn_start.TabIndex = 12;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data.ContextMenuStrip = this.Menu;
            this.data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.data.Location = new System.Drawing.Point(162, -1);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.data.Size = new System.Drawing.Size(497, 305);
            this.data.TabIndex = 15;
            this.data.Text = "======================== ЛОГ ========================";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(127, 26);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // Ico
            // 
            this.Ico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.Ico.Image = ((System.Drawing.Image)(resources.GetObject("Ico.Image")));
            this.Ico.Location = new System.Drawing.Point(54, 174);
            this.Ico.Name = "Ico";
            this.Ico.Size = new System.Drawing.Size(56, 56);
            this.Ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ico.TabIndex = 19;
            this.Ico.TabStop = false;
            // 
            // btn_vk
            // 
            this.btn_vk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_vk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_vk.FlatAppearance.BorderSize = 0;
            this.btn_vk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_vk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_vk.Location = new System.Drawing.Point(12, 236);
            this.btn_vk.Name = "btn_vk";
            this.btn_vk.Size = new System.Drawing.Size(140, 24);
            this.btn_vk.TabIndex = 20;
            this.btn_vk.Text = "Я ВКонтакте";
            this.btn_vk.UseVisualStyleBackColor = false;
            this.btn_vk.Click += new System.EventHandler(this.btn_vk_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_settings.Location = new System.Drawing.Point(12, 80);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(140, 31);
            this.btn_settings.TabIndex = 21;
            this.btn_settings.Text = "Настройки";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_stats.FlatAppearance.BorderSize = 0;
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_stats.Location = new System.Drawing.Point(12, 263);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(140, 31);
            this.btn_stats.TabIndex = 23;
            this.btn_stats.Text = "Статистика";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(659, 304);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_vk);
            this.Controls.Add(this.Ico);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.BoxGray);
            this.Controls.Add(this.data);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 343);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Аккаунт: Unknown";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BoxGray;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.PictureBox Ico;
        private System.Windows.Forms.Button btn_vk;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Button btn_stats;
    }
}