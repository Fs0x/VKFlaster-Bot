namespace VKFlaster.Forms
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ico = new System.Windows.Forms.PictureBox();
            this.rinneCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ico);
            this.groupBox1.Controls.Add(this.rinneCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.activCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.errCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CommentsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // Ico
            // 
            this.Ico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.Ico.Image = ((System.Drawing.Image)(resources.GetObject("Ico.Image")));
            this.Ico.Location = new System.Drawing.Point(218, 95);
            this.Ico.Name = "Ico";
            this.Ico.Size = new System.Drawing.Size(34, 33);
            this.Ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ico.TabIndex = 20;
            this.Ico.TabStop = false;
            // 
            // rinneCount
            // 
            this.rinneCount.AutoSize = true;
            this.rinneCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rinneCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rinneCount.Location = new System.Drawing.Point(130, 83);
            this.rinneCount.Name = "rinneCount";
            this.rinneCount.Size = new System.Drawing.Size(15, 17);
            this.rinneCount.TabIndex = 20;
            this.rinneCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Получено глазиков:";
            // 
            // activCount
            // 
            this.activCount.AutoSize = true;
            this.activCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activCount.Location = new System.Drawing.Point(116, 106);
            this.activCount.Name = "activCount";
            this.activCount.Size = new System.Drawing.Size(15, 17);
            this.activCount.TabIndex = 18;
            this.activCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Получено актива:";
            // 
            // errCount
            // 
            this.errCount.AutoSize = true;
            this.errCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errCount.Location = new System.Drawing.Point(133, 46);
            this.errCount.Name = "errCount";
            this.errCount.Size = new System.Drawing.Size(15, 17);
            this.errCount.TabIndex = 16;
            this.errCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Неудачных попыток:";
            // 
            // CommentsCount
            // 
            this.CommentsCount.AutoSize = true;
            this.CommentsCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentsCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CommentsCount.Location = new System.Drawing.Point(178, 25);
            this.CommentsCount.Name = "CommentsCount";
            this.CommentsCount.Size = new System.Drawing.Size(15, 17);
            this.CommentsCount.TabIndex = 14;
            this.CommentsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Отправлено комментариев:";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stats";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Статистика";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label CommentsCount;
        public System.Windows.Forms.Label errCount;
        public System.Windows.Forms.Label activCount;
        public System.Windows.Forms.Label rinneCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Ico;
    }
}