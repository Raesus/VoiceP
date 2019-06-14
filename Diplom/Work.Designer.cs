namespace Diplom
{
    partial class Work
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
            this.Profile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.WTime = new System.Windows.Forms.Label();
            this.PTime = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Smena = new System.Windows.Forms.Button();
            this.Zapis = new System.Windows.Forms.Button();
            this.LstV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.diplomDataSet = new Diplom.DiplomDataSet();
            this.smenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smenaTableAdapter = new Diplom.DiplomDataSetTableAdapters.SmenaTableAdapter();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c4 = new System.Windows.Forms.CheckBox();
            this.c5 = new System.Windows.Forms.CheckBox();
            this.c6 = new System.Windows.Forms.CheckBox();
            this.c7 = new System.Windows.Forms.CheckBox();
            this.Edit = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.BackToAuto = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smenaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Profile.Location = new System.Drawing.Point(1, 1);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(91, 26);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Профиль";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            // 
            // WTime
            // 
            this.WTime.AutoSize = true;
            this.WTime.BackColor = System.Drawing.Color.White;
            this.WTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WTime.Location = new System.Drawing.Point(146, 44);
            this.WTime.Name = "WTime";
            this.WTime.Size = new System.Drawing.Size(178, 108);
            this.WTime.TabIndex = 1;
            this.WTime.Text = "0:0";
            // 
            // PTime
            // 
            this.PTime.AutoSize = true;
            this.PTime.BackColor = System.Drawing.Color.White;
            this.PTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTime.Location = new System.Drawing.Point(363, 44);
            this.PTime.Name = "PTime";
            this.PTime.Size = new System.Drawing.Size(178, 108);
            this.PTime.TabIndex = 2;
            this.PTime.Text = "0:0";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(152, 213);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(117, 42);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause.Location = new System.Drawing.Point(275, 213);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(117, 42);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(398, 213);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(117, 42);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Закончить";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.c7);
            this.panel1.Controls.Add(this.LstV);
            this.panel1.Controls.Add(this.c6);
            this.panel1.Controls.Add(this.c2);
            this.panel1.Controls.Add(this.c5);
            this.panel1.Controls.Add(this.Zapis);
            this.panel1.Controls.Add(this.c4);
            this.panel1.Controls.Add(this.c1);
            this.panel1.Controls.Add(this.c3);
            this.panel1.Location = new System.Drawing.Point(95, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 358);
            this.panel1.TabIndex = 6;
            // 
            // Smena
            // 
            this.Smena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Smena.Location = new System.Drawing.Point(1, 26);
            this.Smena.Name = "Smena";
            this.Smena.Size = new System.Drawing.Size(91, 26);
            this.Smena.TabIndex = 7;
            this.Smena.Text = "Смена";
            this.Smena.UseVisualStyleBackColor = true;
            this.Smena.Click += new System.EventHandler(this.Smena_Click);
            // 
            // Zapis
            // 
            this.Zapis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zapis.Location = new System.Drawing.Point(170, 376);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(91, 26);
            this.Zapis.TabIndex = 8;
            this.Zapis.Text = "Запись";
            this.Zapis.UseVisualStyleBackColor = true;
            // 
            // LstV
            // 
            this.LstV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LstV.FullRowSelect = true;
            this.LstV.GridLines = true;
            this.LstV.Location = new System.Drawing.Point(3, 3);
            this.LstV.Name = "LstV";
            this.LstV.Size = new System.Drawing.Size(511, 266);
            this.LstV.TabIndex = 0;
            this.LstV.UseCompatibleStateImageBehavior = false;
            this.LstV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "День";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Смена";
            this.columnHeader2.Width = 276;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.smenaBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smenaBindingSource
            // 
            this.smenaBindingSource.DataMember = "Smena";
            this.smenaBindingSource.DataSource = this.diplomDataSet;
            // 
            // smenaTableAdapter
            // 
            this.smenaTableAdapter.ClearBeforeFill = true;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(52, 275);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(94, 17);
            this.c1.TabIndex = 10;
            this.c1.Text = "Понедельник";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(161, 275);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(68, 17);
            this.c2.TabIndex = 11;
            this.c2.Text = "Вторник";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(254, 275);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(57, 17);
            this.c3.TabIndex = 12;
            this.c3.Text = "Среда";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(341, 275);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(68, 17);
            this.c4.TabIndex = 13;
            this.c4.Text = "Четверг";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Location = new System.Drawing.Point(90, 298);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(69, 17);
            this.c5.TabIndex = 14;
            this.c5.Text = "Пятница";
            this.c5.UseVisualStyleBackColor = true;
            // 
            // c6
            // 
            this.c6.AutoSize = true;
            this.c6.Location = new System.Drawing.Point(194, 298);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(67, 17);
            this.c6.TabIndex = 15;
            this.c6.Text = "Суббота";
            this.c6.UseVisualStyleBackColor = true;
            // 
            // c7
            // 
            this.c7.AutoSize = true;
            this.c7.Location = new System.Drawing.Point(280, 298);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(93, 17);
            this.c7.TabIndex = 16;
            this.c7.Text = "Воскресенье";
            this.c7.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Location = new System.Drawing.Point(235, 321);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(91, 26);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Запись";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitApp.Location = new System.Drawing.Point(2, 332);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(91, 26);
            this.ExitApp.TabIndex = 8;
            this.ExitApp.Text = "Выход";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // BackToAuto
            // 
            this.BackToAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToAuto.Location = new System.Drawing.Point(2, 287);
            this.BackToAuto.Name = "BackToAuto";
            this.BackToAuto.Size = new System.Drawing.Size(91, 46);
            this.BackToAuto.TabIndex = 9;
            this.BackToAuto.Text = "Сменить пользователя";
            this.BackToAuto.UseVisualStyleBackColor = true;
            this.BackToAuto.Click += new System.EventHandler(this.BackToAuto_Click);
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.BackToAuto);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PTime);
            this.Controls.Add(this.WTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Profile);
            this.Name = "Work";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.Work_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smenaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label WTime;
        private System.Windows.Forms.Label PTime;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Smena;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.ListView LstV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource smenaBindingSource;
        private DiplomDataSetTableAdapters.SmenaTableAdapter smenaTableAdapter;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.CheckBox c7;
        private System.Windows.Forms.CheckBox c6;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c5;
        private System.Windows.Forms.CheckBox c4;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button BackToAuto;
        private System.Windows.Forms.Timer timer4;
    }
}