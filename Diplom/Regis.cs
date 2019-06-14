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
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KRAI-ПК\SQLEXPRESS;Initial Catalog=Diplom;User ID=sa;Password=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Name, Role, Nmbr, Login, Psswrd) VALUES ('" + FIO.Text + "','Ученик','" + Numb.Text + "','" + Login.Text + "', '" + Pass.Text + "')", con);

            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
