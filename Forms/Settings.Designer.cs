namespace VKFlaster.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_profiles = new System.Windows.Forms.Button();
            this.btn_groups = new System.Windows.Forms.Button();
            this.btn_comments = new System.Windows.Forms.Button();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.Ico = new System.Windows.Forms.PictureBox();
            this.btn_settings2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_profiles
            // 
            this.btn_profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_profiles.Enabled = false;
            this.btn_profiles.FlatAppearance.BorderSize = 0;
            this.btn_profiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_profiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_profiles.Location = new System.Drawing.Point(12, 114);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(254, 31);
            this.btn_profiles.TabIndex = 25;
            this.btn_profiles.Text = "База страниц";
            this.btn_profiles.UseVisualStyleBackColor = false;
            this.btn_profiles.Click += new System.EventHandler(this.btn_profiles_Click);
            // 
            // btn_groups
            // 
            this.btn_groups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_groups.FlatAppearance.BorderSize = 0;
            this.btn_groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_groups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_groups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_groups.Location = new System.Drawing.Point(12, 80);
            this.btn_groups.Name = "btn_groups";
            this.btn_groups.Size = new System.Drawing.Size(254, 31);
            this.btn_groups.TabIndex = 24;
            this.btn_groups.Text = "База групп";
            this.btn_groups.UseVisualStyleBackColor = false;
            this.btn_groups.Click += new System.EventHandler(this.btn_groups_Click);
            // 
            // btn_comments
            // 
            this.btn_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_comments.FlatAppearance.BorderSize = 0;
            this.btn_comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_comments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_comments.Location = new System.Drawing.Point(12, 46);
            this.btn_comments.Name = "btn_comments";
            this.btn_comments.Size = new System.Drawing.Size(254, 31);
            this.btn_comments.TabIndex = 23;
            this.btn_comments.Text = "База комментариев";
            this.btn_comments.UseVisualStyleBackColor = false;
            this.btn_comments.Click += new System.EventHandler(this.btn_comments_Click);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Checked = true;
            this.check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check1.Location = new System.Drawing.Point(12, 159);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(132, 21);
            this.check1.TabIndex = 26;
            this.check1.Text = "Только для групп";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check2.Location = new System.Drawing.Point(12, 181);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(146, 21);
            this.check2.TabIndex = 27;
            this.check2.Text = "Только для страниц";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // Ico
            // 
            this.Ico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.Ico.Image = ((System.Drawing.Image)(resources.GetObject("Ico.Image")));
            this.Ico.Location = new System.Drawing.Point(223, 159);
            this.Ico.Name = "Ico";
            this.Ico.Size = new System.Drawing.Size(43, 43);
            this.Ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ico.TabIndex = 28;
            this.Ico.TabStop = false;
            // 
            // btn_settings2
            // 
            this.btn_settings2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_settings2.FlatAppearance.BorderSize = 0;
            this.btn_settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_settings2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_settings2.Location = new System.Drawing.Point(12, 12);
            this.btn_settings2.Name = "btn_settings2";
            this.btn_settings2.Size = new System.Drawing.Size(254, 31);
            this.btn_settings2.TabIndex = 30;
            this.btn_settings2.Text = "Доп. настройки";
            this.btn_settings2.UseVisualStyleBackColor = false;
            this.btn_settings2.Click += new System.EventHandler(this.btn_settings2_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_save.Location = new System.Drawing.Point(12, 208);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(254, 31);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "Сохранить настройки";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(278, 248);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_settings2);
            this.Controls.Add(this.Ico);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.btn_profiles);
            this.Controls.Add(this.btn_groups);
            this.Controls.Add(this.btn_comments);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profiles;
        private System.Windows.Forms.Button btn_groups;
        private System.Windows.Forms.Button btn_comments;
        private System.Windows.Forms.PictureBox Ico;
        private System.Windows.Forms.Button btn_settings2;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.CheckBox check1;
        public System.Windows.Forms.CheckBox check2;
    }
}