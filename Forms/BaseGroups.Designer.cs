namespace VKFlaster.Forms
{
    partial class BaseGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseGroups));
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.groups = new System.Windows.Forms.ListView();
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btn_LoadFile.TabIndex = 20;
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
            this.btn_add.TabIndex = 19;
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
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ссылка на группу";
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
            this.url.TabIndex = 17;
            this.url.Text = "vk.com/public000";
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url.Enter += new System.EventHandler(this.url_Enter);
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_KeyDown);
            this.url.Leave += new System.EventHandler(this.url_Leave);
            // 
            // groups
            // 
            this.groups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.groups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._name,
            this._group});
            this.groups.ContextMenuStrip = this.Menu;
            this.groups.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groups.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groups.FullRowSelect = true;
            this.groups.GridLines = true;
            this.groups.Location = new System.Drawing.Point(12, 12);
            this.groups.MultiSelect = false;
            this.groups.Name = "groups";
            this.groups.ShowGroups = false;
            this.groups.Size = new System.Drawing.Size(411, 145);
            this.groups.TabIndex = 15;
            this.groups.UseCompatibleStateImageBehavior = false;
            this.groups.View = System.Windows.Forms.View.Details;
            // 
            // _name
            // 
            this._name.Text = "@name";
            this._name.Width = 192;
            // 
            // _group
            // 
            this._group.Text = "@group";
            this._group.Width = 215;
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
            // BaseGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.groups);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Группы";
            this.Load += new System.EventHandler(this.BaseGroups_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        public System.Windows.Forms.ListView groups;
        private System.Windows.Forms.ColumnHeader _name;
        private System.Windows.Forms.ColumnHeader _group;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзБазыToolStripMenuItem;
    }
}