namespace VKFlaster.Forms
{
    partial class Proxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proxy));
            this.label1 = new System.Windows.Forms.Label();
            this.ProxyString = new System.Windows.Forms.TextBox();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.checkSOCK5 = new System.Windows.Forms.CheckBox();
            this.checkSOCK4 = new System.Windows.Forms.CheckBox();
            this.checkHTTP = new System.Windows.Forms.CheckBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Прокси";
            // 
            // ProxyString
            // 
            this.ProxyString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ProxyString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProxyString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProxyString.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProxyString.Location = new System.Drawing.Point(23, 38);
            this.ProxyString.Name = "ProxyString";
            this.ProxyString.Size = new System.Drawing.Size(250, 25);
            this.ProxyString.TabIndex = 15;
            this.ProxyString.Text = "IP:Port";
            this.ProxyString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProxyString.Enter += new System.EventHandler(this.ProxyString_Enter);
            this.ProxyString.Leave += new System.EventHandler(this.ProxyString_Leave);
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.checkSOCK5);
            this.Box1.Controls.Add(this.checkSOCK4);
            this.Box1.Controls.Add(this.checkHTTP);
            this.Box1.Enabled = false;
            this.Box1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Box1.Location = new System.Drawing.Point(23, 69);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(250, 62);
            this.Box1.TabIndex = 16;
            this.Box1.TabStop = false;
            this.Box1.Text = "Тип прокси";
            // 
            // checkSOCK5
            // 
            this.checkSOCK5.AutoSize = true;
            this.checkSOCK5.Location = new System.Drawing.Point(167, 28);
            this.checkSOCK5.Name = "checkSOCK5";
            this.checkSOCK5.Size = new System.Drawing.Size(78, 25);
            this.checkSOCK5.TabIndex = 2;
            this.checkSOCK5.Text = "SOCK5";
            this.checkSOCK5.UseVisualStyleBackColor = true;
            this.checkSOCK5.CheckedChanged += new System.EventHandler(this.checkSOCK5_CheckedChanged);
            // 
            // checkSOCK4
            // 
            this.checkSOCK4.AutoSize = true;
            this.checkSOCK4.Location = new System.Drawing.Point(83, 28);
            this.checkSOCK4.Name = "checkSOCK4";
            this.checkSOCK4.Size = new System.Drawing.Size(78, 25);
            this.checkSOCK4.TabIndex = 1;
            this.checkSOCK4.Text = "SOCK4";
            this.checkSOCK4.UseVisualStyleBackColor = true;
            this.checkSOCK4.CheckedChanged += new System.EventHandler(this.checkSOCK4_CheckedChanged);
            // 
            // checkHTTP
            // 
            this.checkHTTP.AutoSize = true;
            this.checkHTTP.Checked = true;
            this.checkHTTP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHTTP.Location = new System.Drawing.Point(12, 28);
            this.checkHTTP.Name = "checkHTTP";
            this.checkHTTP.Size = new System.Drawing.Size(65, 25);
            this.checkHTTP.TabIndex = 0;
            this.checkHTTP.Text = "HTTP";
            this.checkHTTP.UseVisualStyleBackColor = true;
            this.checkHTTP.CheckedChanged += new System.EventHandler(this.checkHTTP_CheckedChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_close.Location = new System.Drawing.Point(23, 140);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(123, 31);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_save.Location = new System.Drawing.Point(150, 140);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 31);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.check1.Location = new System.Drawing.Point(118, 17);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(164, 21);
            this.check1.TabIndex = 27;
            this.check1.Text = "Использовать прокси?";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // Proxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(300, 192);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyString);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Прокси";
            this.Load += new System.EventHandler(this.Proxy_Load);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox ProxyString;
        public System.Windows.Forms.GroupBox Box1;
        public System.Windows.Forms.CheckBox checkSOCK5;
        public System.Windows.Forms.CheckBox checkSOCK4;
        public System.Windows.Forms.CheckBox checkHTTP;
        public System.Windows.Forms.CheckBox check1;
    }
}