namespace Diplom
{
    partial class Admin
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
            this.BackToAuto = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Button();
            this.Smena = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.InfoUs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToAuto
            // 
            this.BackToAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToAuto.Location = new System.Drawing.Point(2, 209);
            this.BackToAuto.Name = "BackToAuto";
            this.BackToAuto.Size = new System.Drawing.Size(91, 46);
            this.BackToAuto.TabIndex = 11;
            this.BackToAuto.Text = "Сменить пользователя";
            this.BackToAuto.UseVisualStyleBackColor = true;
            this.BackToAuto.Click += new System.EventHandler(this.BackToAuto_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitApp.Location = new System.Drawing.Point(2, 254);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(91, 26);
            this.ExitApp.TabIndex = 10;
            this.ExitApp.Text = "Выход";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // Stat
            // 
            this.Stat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stat.Location = new System.Drawing.Point(2, 26);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(91, 26);
            this.Stat.TabIndex = 13;
            this.Stat.Text = "Статистика";
            this.Stat.UseVisualStyleBackColor = true;
            // 
            // Smena
            // 
            this.Smena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smena.Location = new System.Drawing.Point(2, 1);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(91, 26);
            this.Smena.TabIndex = 12;
            this.Smena.Text = "Смены";
            this.Smena.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.InfoUs);
            this.panel1.Location = new System.Drawing.Point(98, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 279);
            this.panel1.TabIndex = 14;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Location = new System.Drawing.Point(256, 234);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 42);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Location = new System.Drawing.Point(72, 234);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(147, 42);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // InfoUs
            // 
            this.InfoUs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.InfoUs.FullRowSelect = true;
            this.InfoUs.GridLines = true;
            this.InfoUs.Location = new System.Drawing.Point(3, 6);
            this.InfoUs.Name = "InfoUs";
            this.InfoUs.Size = new System.Drawing.Size(469, 222);
            this.InfoUs.TabIndex = 0;
            this.InfoUs.UseCompatibleStateImageBehavior = false;
            this.InfoUs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Форма занятости";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер телефона";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(98, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 279);
            this.panel2.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(469, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Общее рабочее время";
            this.columnHeader6.Width = 133;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Время в паузе";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Время в работе";
            this.columnHeader8.Width = 109;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.BackToAuto);
            this.Controls.Add(this.ExitApp);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToAuto;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Button Smena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView InfoUs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}