namespace VKFlaster.Forms
{
    partial class Settings2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings2));
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.group_id = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.imlike = new System.Windows.Forms.CheckBox();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.group_id);
            this.Box1.Controls.Add(this.checkBox1);
            this.Box1.Controls.Add(this.check2);
            this.Box1.Controls.Add(this.imlike);
            this.Box1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Box1.Location = new System.Drawing.Point(12, 12);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(260, 132);
            this.Box1.TabIndex = 1;
            this.Box1.TabStop = false;
            this.Box1.Text = "Доп. настройки";
            // 
            // group_id
            // 
            this.group_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group_id.Enabled = false;
            this.group_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_id.Location = new System.Drawing.Point(10, 97);
            this.group_id.Name = "group_id";
            this.group_id.Size = new System.Drawing.Size(240, 25);
            this.group_id.TabIndex = 33;
            this.group_id.Text = "Group Id";
            this.group_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.group_id.Enter += new System.EventHandler(this.group_id_Enter);
            this.group_id.Leave += new System.EventHandler(this.group_id_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(10, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Писать от имени сообщества";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Enabled = false;
            this.check2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check2.Location = new System.Drawing.Point(10, 50);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(174, 21);
            this.check2.TabIndex = 31;
            this.check2.Text = "Писать под видеозаписи";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // imlike
            // 
            this.imlike.AutoSize = true;
            this.imlike.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imlike.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.imlike.Location = new System.Drawing.Point(10, 28);
            this.imlike.Name = "imlike";
            this.imlike.Size = new System.Drawing.Size(134, 21);
            this.imlike.TabIndex = 30;
            this.imlike.Text = "Ставить самолайк";
            this.imlike.UseVisualStyleBackColor = true;
            this.imlike.CheckedChanged += new System.EventHandler(this.imlike_CheckedChanged);
            // 
            // Settings2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.Box1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Доп. настройки";
            this.Load += new System.EventHandler(this.Settings2_Load);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box1;
        public System.Windows.Forms.CheckBox imlike;
        public System.Windows.Forms.CheckBox check2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox group_id;
    }
}