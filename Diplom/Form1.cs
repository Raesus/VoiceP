using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {


                SqlConnection con = new SqlConnection(@"Data Source=KRAI-ПК\SQLEXPRESS;Initial Catalog=Diplom;User ID=sa;Password=1234");
                SqlCommand cmd = new SqlCommand("SELECT Role FROM [User] WHERE Login='" + LogIn.Text + "' AND Psswrd='" + Pass.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand("SELECT Id FROM [User] WHERE Login='" + LogIn.Text + "' AND Psswrd='" + Pass.Text + "'", con);
                con.Open();
                string x = cmd.ExecuteScalar().ToString();
                string d = cmd2.ExecuteScalar().ToString();
                User.Login = LogIn.Text;
                User.pass = Pass.Text;
                User.id = d;
                if (x.Trim() == "Администратор")
                {

                    Admin f = new Admin();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else if (x.Trim() == "Ученик" || x.Trim() == "Стажер" || x.Trim() == "Постоянный" || x.Trim() == "Гибкий")
                {
                    this.Hide();
                    Work f = new Work();
                    f.ShowDialog();
                    this.Close();
                }
                con.Close();
   
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regis f = new Regis();
            f.ShowDialog();
            this.Close();
        }
    }
}
