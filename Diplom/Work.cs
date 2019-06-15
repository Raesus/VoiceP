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
    public partial class Work : Form
    {
        int s = 1;
        int m = 0;
        int H = 0;
        int s2 = 1;
        int m2 = 0;
        int H2 = 0;
        string rabT;
        string pasT;
        int s3 = 1;
        int s4 = 1;
        string St;
        string En;
        string ra;
        int v;
        TimeSpan vs;
        int[] mas = new int[7];
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        SqlConnection con = new SqlConnection(@"Data Source=KRAI-ПК\SQLEXPRESS;Initial Catalog=Diplom;User ID=sa;Password=1234");
        public Work()
        {
            InitializeComponent();
            timer2.Tick += Timer_Tick2;
            timer1.Tick += Timer_Tick;
            timer3.Tick += Time_TickM;
            timer4.Tick += Timer_Tick4;
            timer4.Start();
            LstV.Visible = false;
            WTime.Visible = true;
            PTime.Visible = true;
            Pause.Visible = true;
            Start.Visible = true;
            Stop.Visible = true;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            comboBox1.Visible = false;
            Edit.Visible = false;
            zgc.Visible = false;
            Rabota.Visible = false;
            Pauza.Visible = false;
            Vsego.Visible = false;
            timer3.Start();
            con.Open();           
            LstV.Items.Clear();
            string Qurty2 = "SELECT Week.DayOfWeek, WeSm.IdSmena FROM [Week] INNER JOIN ([WeSm] INNER JOIN [Ussmen] ON WeSm.IdSmena=Ussmen.IdSmena AND Ussmen.IdUser='" + User.id + "')ON WeSm.IdWeek = Week.Id";
            SqlCommand command2 = new SqlCommand(Qurty2, con);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    item.SubItems.Add(reader[i].ToString());
                }
                LstV.Items.Add(item);
            }
            reader.Close();
            con.Close();
            Pause.Enabled = false;
            Stop.Enabled = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            DrawGraph();

        }
        private void DrawGraph()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM [User] WHERE Id='" + User.id + "'",con);
            string x = cmd.ExecuteScalar().ToString();
            con.Close();
            GraphPane pane = zgc.GraphPane;
            pane.XAxis.Title.Text = "Дни";
            pane.YAxis.Title.Text = "Часы";
            pane.Title.Text = x;
        }
        void Time_TickM(object sender, EventArgs e)
        {
            s3++;
            if (s3 % 10 == 0)
            {
                con.Open();
                LstV.Items.Clear();
                string str1 = "SELECT Week.DayOfWeek, WeSm.IdSmena FROM [Week] INNER JOIN ([WeSm] INNER JOIN [Ussmen] ON WeSm.IdSmena=Ussmen.IdSmena AND Ussmen.IdUser='" + User.id + "')ON WeSm.IdWeek = Week.Id";
                SqlCommand command2 = new SqlCommand(str1, con);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        item.SubItems.Add(reader[i].ToString());
                    }
                    LstV.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
        }
        void Timer_Tick4(object sender, EventArgs e)
        {
            s4++;
            if (s4 % 60 == 0)
            {
                Graphics GH = Graphics.FromImage(BM as Image);
                GH.CopyFromScreen(0, 0, 0, 0, BM.Size);
                BM.Save("images/skreen" + v + ".jpg");
                v++;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT WorkTime FROM [Work] WHERE IdUser='" + User.id + "'",con);
            SqlCommand cmd2 = new SqlCommand("SELECT PauseTime FROM [Work] WHERE IdUser='" + User.id + "'",con)
            
            Vsego.Text = "Всего: " + "(" + "%)";
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            WTime.Text = H + ":" + m;

            if (m < 60)
            {
                if (s < 59)
                {
                    s++;
                }
                else if (s >= 59)
                {
                    m++;
                    s = 0;
                }

            }
            else if (m == 60 && s >= 59)
            {
                m = 0;
                s = 0;
                H++;
            }
            rabT = WTime.Text;
        }
        void Timer_Tick2(object sender, EventArgs e)
        {
            PTime.Text = H2 + ":" + m2;

            if (m2 < 59)
            {
                if (s2 <= 59)
                {
                    s2++;
                }
                else if (s2 > 59)
                {
                    m2++;
                    s2 = 0;
                }

            }
            else if (m2 == 59 && s2 >= 59)
            {
                m2 = 0;
                s2 = 0;
                H2++;
            }
            pasT = PTime.Text;
           
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
            timer3.Start();
            if (St == null) { St = DateTime.Now.ToString("HH:mm"); }
            Pause.Enabled = true;
            Stop.Enabled = true;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            s = 0;
            s2 = 0;
            WTime.Text = "0:0";
            PTime.Text = "0:0";
            if (En == null) { En = DateTime.Now.ToString("HH:mm"); }
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Work] (WorkTime, PauseTime, StartWork, EndWork, IdUser)VALUES('" + rabT + "', '" + pasT + "', '" + St + "', '" + En + "', '" + User.id + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Rabota.Visible = false;
            Pauza.Visible = false;
            Vsego.Visible = false;
            WTime.Visible = true;
            PTime.Visible = true;
            Pause.Visible = true;
            Start.Visible = true;
            Stop.Visible = true;
            LstV.Visible = false;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            comboBox1.Visible = false;
            Edit.Visible = false;
            zgc.Visible = false;
        }

        private void Smena_Click(object sender, EventArgs e)
        {
            Rabota.Visible = false;
            Pauza.Visible = false;
            Vsego.Visible = false;
            WTime.Visible = false;
            PTime.Visible = false;
            Pause.Visible = false;
            Start.Visible = false;
            Stop.Visible = false;
            LstV.Visible = true;
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
            c5.Visible = true;
            c6.Visible = true;
            c7.Visible = true;
            comboBox1.Visible = true;
            Edit.Visible = true;
            zgc.Visible = false;

        }


        private void Work_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Smena". При необходимости она может быть перемещена или удалена.
            this.smenaTableAdapter.Fill(this.diplomDataSet.Smena);

        }

        private void BackToAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true)
            { mas[0] = 1; }
            if (c2.Checked == true)
            { mas[1] = 2; }
            if (c3.Checked == true)
            { mas[2] = 3; }
            if (c4.Checked == true)
            { mas[3] = 4; }
            if (c5.Checked == true)
            { mas[4] = 5; }
            if (c6.Checked == true)
            { mas[5] = 6; }
            if (c7.Checked == true)
            { mas[6] = 7; }
            
            con.Open();
            for (int i = 0; i <= 6; i++)
            {
                if (mas[i] != 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [WeSm] (IdWeek,IdSmena)VALUES('" + mas[i] + "','" + ra[0] + "')", con);
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ra = comboBox1.SelectedItem.ToString();
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            WTime.Visible = false;
            PTime.Visible = false;
            Pause.Visible = false;
            Start.Visible = false;
            Stop.Visible = false;
            LstV.Visible = false;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            comboBox1.Visible = false;
            Edit.Visible = false;
            zgc.Visible = true;
            Rabota.Visible = true;
            Pauza.Visible = true;
            Vsego.Visible = true;
        }
    }
}
