namespace VKFlaster.Forms
{
    partial class BaseComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseComments));
            this.comments = new System.Windows.Forms.ListView();
            this._comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._attachment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьИзБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.btn_addFile = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comments
            // 
            this.comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.comments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._comment,
            this._attachment});
            this.comments.ContextMenuStrip = this.Menu;
            this.comments.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comments.FullRowSelect = true;
            this.comments.GridLines = true;
            this.comments.Location = new System.Drawing.Point(12, 12);
            this.comments.MultiSelect = false;
            this.comments.Name = "comments";
            this.comments.ShowGroups = false;
            this.comments.Size = new System.Drawing.Size(411, 145);
            this.comments.TabIndex = 5;
            this.comments.UseCompatibleStateImageBehavior = false;
            this.comments.View = System.Windows.Forms.View.Details;
            // 
            // _comment
            // 
            this._comment.Text = "@comment";
            this._comment.Width = 219;
            // 
            // _attachment
            // 
            this._attachment.Text = "@attachment";
            this._attachment.Width = 188;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Текст комментария";
            // 
            // comment
            // 
            this.comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comment.Location = new System.Drawing.Point(12, 188);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(282, 25);
            this.comment.TabIndex = 11;
            this.comment.Text = "Я хочу быть первым! Хытьфу";
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comment_KeyDown);
            // 
            // btn_addFile
            // 
            this.btn_addFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.btn_addFile.FlatAppearance.BorderSize = 0;
            this.btn_addFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_addFile.Location = new System.Drawing.Point(300, 188);
            this.btn_addFile.Name = "btn_addFile";
            this.btn_addFile.Size = new System.Drawing.Size(42, 25);
            this.btn_addFile.TabIndex = 10;
            this.btn_addFile.Text = " [+]";
            this.btn_addFile.UseVisualStyleBackColor = false;
            this.btn_addFile.Click += new System.EventHandler(this.btn_addFile_Click);
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
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_LoadFile.TabIndex = 14;
            this.btn_LoadFile.Text = "Из файла";
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // BaseComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.btn_addFile);
            this.Controls.Add(this.comments);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKFlaster | Комментарии";
            this.Load += new System.EventHandler(this.BaseComments_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader _comment;
        private System.Windows.Forms.ColumnHeader _attachment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button btn_addFile;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзБазыToolStripMenuItem;
        public System.Windows.Forms.ListView comments;
        private System.Windows.Forms.Button btn_LoadFile;
    }
}