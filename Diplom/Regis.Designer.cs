namespace Diplom
{
    partial class Regis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Numb = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Registr = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(87, 9);
            this.FIO.Multiline = true;
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(135, 24);
            this.FIO.TabIndex = 4;
            // 
            // Numb
            // 
            this.Numb.Location = new System.Drawing.Point(87, 43);
            this.Numb.Multiline = true;
            this.Numb.Name = "Numb";
            this.Numb.Size = new System.Drawing.Size(135, 24);
            this.Numb.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(87, 77);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(135, 24);
            this.Login.TabIndex = 6;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(87, 113);
            this.Pass.Multiline = true;
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(135, 24);
            this.Pass.TabIndex = 7;
            // 
            // Registr
            // 
            this.Registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr.Location = new System.Drawing.Point(9, 143);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(213, 51);
            this.Registr.TabIndex = 8;
            this.Registr.Text = "Зарегестрироваться";
            this.Registr.UseVisualStyleBackColor = true;
            this.Registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(9, 200);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(213, 51);
            this.back.TabIndex = 9;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Regis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 268);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Numb);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Regis";
            this.Text = "Regis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox Numb;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button Registr;
        private System.Windows.Forms.Button back;
    }
}