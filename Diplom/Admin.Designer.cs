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
            this.Smena.Text = "Смена";
            this.Smena.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 283);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.Smena);
            this.Controls.Add(this.BackToAuto);
            this.Controls.Add(this.ExitApp);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToAuto;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Button Smena;
    }
}