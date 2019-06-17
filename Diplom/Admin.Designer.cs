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
            this.components = new System.ComponentModel.Container();
            this.BackToAuto = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Button();
            this.Smena = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.InfoUs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet1 = new Diplom.DiplomDataSet1();
            this.userTableAdapter = new Diplom.DiplomDataSet1TableAdapters.UserTableAdapter();
            this.RabUs = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbrText = new System.Windows.Forms.TextBox();
            this.FIOText = new System.Windows.Forms.TextBox();
            this.Updt = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet1)).BeginInit();
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
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // Smena
            // 
            this.Smena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smena.Location = new System.Drawing.Point(2, 1);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(91, 26);
            this.Smena.TabIndex = 12;
            this.Smena.Text = "Сотрудники";
            this.Smena.UseVisualStyleBackColor = true;
            this.Smena.Click += new System.EventHandler(this.Smena_Click);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(221, 231);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(192, 49);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            this.InfoUs.Location = new System.Drawing.Point(98, 3);
            this.InfoUs.Name = "InfoUs";
            this.InfoUs.Size = new System.Drawing.Size(469, 222);
            this.InfoUs.TabIndex = 0;
            this.InfoUs.UseCompatibleStateImageBehavior = false;
            this.InfoUs.View = System.Windows.Forms.View.Details;
            this.InfoUs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.InfoUs_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Форма занятости";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер телефона";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус";
            this.columnHeader4.Width = 115;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Location = new System.Drawing.Point(2, 51);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(91, 26);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Updt);
            this.panel3.Controls.Add(this.FIOText);
            this.panel3.Controls.Add(this.nmbrText);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Roles);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(96, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 279);
            this.panel3.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.diplomDataSet1;
            // 
            // diplomDataSet1
            // 
            this.diplomDataSet1.DataSetName = "DiplomDataSet1";
            this.diplomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // RabUs
            // 
            this.RabUs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.RabUs.FullRowSelect = true;
            this.RabUs.GridLines = true;
            this.RabUs.Location = new System.Drawing.Point(99, 3);
            this.RabUs.Name = "RabUs";
            this.RabUs.Size = new System.Drawing.Size(469, 270);
            this.RabUs.TabIndex = 0;
            this.RabUs.UseCompatibleStateImageBehavior = false;
            this.RabUs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО";
            this.columnHeader5.Width = 114;
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать сотрудника";
            // 
            // Roles
            // 
            this.Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "Ученик",
            "Стажер",
            "Постоянный",
            "Гибкий"});
            this.Roles.Location = new System.Drawing.Point(220, 45);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(204, 28);
            this.Roles.TabIndex = 2;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Форма занятости";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Изменить номер";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Изменить ФИО";
            // 
            // nmbrText
            // 
            this.nmbrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmbrText.Location = new System.Drawing.Point(220, 89);
            this.nmbrText.Multiline = true;
            this.nmbrText.Name = "nmbrText";
            this.nmbrText.Size = new System.Drawing.Size(204, 33);
            this.nmbrText.TabIndex = 6;
            // 
            // FIOText
            // 
            this.FIOText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOText.Location = new System.Drawing.Point(220, 132);
            this.FIOText.Multiline = true;
            this.FIOText.Name = "FIOText";
            this.FIOText.Size = new System.Drawing.Size(204, 33);
            this.FIOText.TabIndex = 7;
            // 
            // Updt
            // 
            this.Updt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Updt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Updt.Location = new System.Drawing.Point(107, 186);
            this.Updt.Name = "Updt";
            this.Updt.Size = new System.Drawing.Size(210, 49);
            this.Updt.TabIndex = 19;
            this.Updt.Text = "Обновить информацию";
            this.Updt.UseVisualStyleBackColor = true;
            this.Updt.Click += new System.EventHandler(this.Updt_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 282);
            this.Controls.Add(this.RabUs);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.InfoUs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.BackToAuto);
            this.Controls.Add(this.ExitApp);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToAuto;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Button Smena;
        private System.Windows.Forms.ListView InfoUs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DiplomDataSet1 diplomDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DiplomDataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ListView RabUs;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Updt;
        private System.Windows.Forms.TextBox FIOText;
        private System.Windows.Forms.TextBox nmbrText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}