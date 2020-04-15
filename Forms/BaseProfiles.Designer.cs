namespace VKFlaster.Forms
{
    partial class BaseProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseProfiles));
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.profiles = new System.Windows.Forms.ListView();
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._profiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьИзБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_LoadFile.FlatAppearance.BorderSize = 0;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_LoadFile.Location = new System.Drawing.Point(348, 160);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(75, 25);
            this.btn_LoadFile.TabIndex = 25;
            this.btn_LoadFile.Text = "Из файла";
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_add.Location = new System.Drawing.Point(348, 188);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ссылка на профиль";
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.url.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.url.Location = new System.Drawing.Point(12, 188);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(330, 25);
            this.url.TabIndex = 22;
            this.url.Text = "vk.com/id0";
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url.Enter += new System.EventHandler(this.url_Enter);
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_KeyDown);
            this.url.Leave += new System.EventHandler(this.url_Leave);
            // 
            // profiles
            // 
            this.profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.profiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._name,
            this._profiles});
            this.profiles.ContextMenuStrip = this.Menu;
            this.profiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.profiles.FullRowSelect = true;
            this.profiles.GridLines = true;
            this.profiles.Location = new System.Drawing.Point(12, 12);
            this.profiles.MultiSelect = false;
            this.profiles.Name = "profiles";
            this.profiles.ShowGroups = false;
            this.profiles.Size = new System.Drawing.Size(411, 145);
            this.profiles.TabIndex = 21;
            this.profiles.UseCompatibleStateImageBehavior = false;
            this.profiles.View = System.Windows.Forms.View.Details;
            // 
            // _name
            // 
            this._name.Text = "@name";
            this._name.Width = 192;
            // 
            // _profiles
            // 
            this._profiles.Text = "@id";
            this._profiles.Width = 215;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьИзБазыToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(164, 26);
            // 
            // удалитьИзБазыToolStripMenuItem
            // 
            this.удалитьИзБазыToolStripMenuItem.Name = "удалитьИзБазыToolStripMenuItem";
            this.удалитьИзБазыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.удалитьИзБазыToolStripMenuItem.Text = "Удалить из базы";
            this.удалитьИзБазыToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзБазыToolStripMenuItem_Click);
            // 
            // BaseProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.profiles);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Страницы";
            this.Load += new System.EventHandler(this.BaseProfiles_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        public System.Windows.Forms.ListView profiles;
        private System.Windows.Forms.ColumnHeader _name;
        private System.Windows.Forms.ColumnHeader _profiles;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзБазыToolStripMenuItem;
    }
}