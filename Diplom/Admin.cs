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
using ZedGraph;

namespace Diplom
{
    public partial class Admin : Form
    {
        string ra = "";
        int s3 = 1;
        string sa = "";
        SqlConnection con = new SqlConnection(@"Data Source=KRAI-ПК\SQLEXPRESS;Initial Catalog=Diplom;User ID=sa;Password=1234");
        private void UdT()
        {
            con.Open();
            comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT [Name] FROM [User] WHERE Role='Гибкий' OR Role='Постоянный' OR Role='Стажер' OR Role='Ученик'", con);
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                comboBox1.Items.Add(dt[0].ToString());
            }
            dt.Close();
            con.Close();
        }
        void Time_TickM(object sender, EventArgs e)
        {
            s3++;
            
            if (s3 % 10 == 0)
            {
                con.Open();
                InfoUs.Items.Clear();
                string str1 = "SELECT Name, Role, Nmbr, IdStatus FROM [User] WHERE Role='Ученик' OR Role='Стажер' OR Role='Постоянный' OR Role='Гибкий'";
                SqlCommand command2 = new SqlCommand(str1, con);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        item.SubItems.Add(reader[i].ToString());
                    }
                    InfoUs.Items.Add(item);
                }
                reader.Close();

                RabUs.Items.Clear();
                SqlCommand comm = new SqlCommand("SELECT [User].[Name], [WrTime].[AllTime], [WrTime].[PsTime], [WrTime].[WrkTime] FROM [User] " +
                    "INNER JOIN [WrTime] ON [User].[Id] = [WrTime].[FioUs] ORDER BY [User].[Name] ASC", con);
                SqlDataReader reader2 = comm.ExecuteReader();
                while (reader2.Read())
                {
                    ListViewItem item = new ListViewItem(reader2[0].ToString());
                    for (int i = 1; i < reader2.FieldCount; i++)
                    {
                        item.SubItems.Add(reader2[i].ToString());
                    }
                    RabUs.Items.Add(item);
                }
                reader2.Close();
                con.Close();
                UdT();

            }
        }
            
        public Admin()
        {
            InitializeComponent();
            timer1.Tick += Time_TickM;
            timer1.Start();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }

        private void BackToAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT Name, Role, Nmbr, IdStatus FROM [User] WHERE Role='Ученик' OR Role='Стажер' OR Role='Постоянный' OR Role='Гибкий'", con);
             SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    item.SubItems.Add(reader[i].ToString());
                }
                InfoUs.Items.Add(item);
            }
            reader.Close();
            con.Close();

            con.Open();
            SqlCommand comm = new SqlCommand("SELECT [User].[Name], [WrTime].[AllTime], [WrTime].[PsTime], [WrTime].[WrkTime] FROM [User] " +
                "INNER JOIN [WrTime] ON [User].[Id] = [WrTime].[FioUs] ORDER BY [User].[Name] ASC", con);
            SqlDataReader reader2 = comm.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem item = new ListViewItem(reader2[0].ToString());
                for (int i = 1; i < reader2.FieldCount; i++)
                {
                    item.SubItems.Add(reader2[i].ToString());
                }
                RabUs.Items.Add(item);
            }
            reader2.Close();
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Name] FROM [User] WHERE Role='Гибкий' OR Role='Постоянный' OR Role='Стажер' OR Role='Ученик'",con);
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                comboBox1.Items.Add(dt[0].ToString());
            }
            dt.Close();
            con.Close();
            RabUs.Visible = false;
            panel3.Visible = false;
        }

        private void Smena_Click(object sender, EventArgs e)
        {
            InfoUs.Visible = true;
            RabUs.Visible = false;
            Delete.Visible = true;
            panel3.Visible = false;
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            RabUs.Visible = true;
            Delete.Visible = false;
            InfoUs.Visible = false;
            panel3.Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE [Name]='" + InfoUs.SelectedItems[0].Text + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            InfoUs.Visible = false;
            Delete.Visible = false;
            RabUs.Visible = false;
            panel3.Visible = true;
        }

        private void InfoUs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sa = comboBox1.SelectedItem.ToString();
        }

        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ra = Roles.SelectedItem.ToString();
        }

        private void Updt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Id FROM [User] WHERE Name='" + sa + "'",con);
            string se = cmd2.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("SELECT Role FROM [User] WHERE Id='" + se + "'", con);
            if (ra != cmd.ExecuteScalar().ToString() && ra!="")
            {
                SqlCommand c = new SqlCommand("UPDATE [User] SET Role='" + ra + "' WHERE Id='" + se + "'",con);
                c.ExecuteNonQuery();
            }
            if (FIOText.Text != sa && FIOText.Text!="")
            {
                SqlCommand cm = new SqlCommand("UPDATE [User] SET Name='" + FIOText.Text + "' WHERE Id='" + se + "'", con);
                cm.ExecuteNonQuery();
            }
            SqlCommand cs = new SqlCommand("SELECT Nmbr FROM [User] WHERE Id='" + se + "'",con);
            if (nmbrText.Text != cs.ExecuteScalar().ToString() && nmbrText.Text != "")
            {
                SqlCommand sw = new SqlCommand("UPDATE [User] SET Nmbr='" + nmbrText.Text + "' WHERE Id='" + se + "'",con);
                sw.ExecuteNonQuery();
            }
            nmbrText.Text = "";
            FIOText.Text = "";
            con.Close();

        }
    }
}
