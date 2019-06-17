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
        string b = "";
        string b1 = "";
        int c = 0;
        int j = 0;
        int pm=0, pc=0;
        int wm=0, wc=0;
        int pr = 0;
        int pv = 0;
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
            string Qurty2 = "SELECT Week.DayOfWeek, Smena.SmSta, Smena.SmEnd FROM [Week] INNER JOIN ([WeSm] INNER JOIN ([Ussmen] INNER JOIN [Smena] ON Ussmen.IdSmena=Smena.Id) ON WeSm.IdSmena=Ussmen.IdSmena AND Ussmen.IdUser='" + User.id + "')ON WeSm.IdWeek = Week.Id ORDER BY Week.DayOfWeek ASC";
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
            zgc.MasterPane.PaneList.Clear();
            GraphPane pane1 = new GraphPane();
            pane1.XAxis.Title.Text = "Дни";
            pane1.YAxis.Title.Text = "Часы";
            pane1.Title.Text = x;

            int itemscount = 7;
            Random rnd = new Random();

            double[] YValues1 = GenerateData(itemscount, rnd);
            double[] YValues2 = GenerateData(itemscount, rnd);
            double[] YValues3 = GenerateData(itemscount, rnd);

            double[] XValues = new double[itemscount];

            for (int i = 0; i < itemscount; i++)
            {
                XValues[i] = i + 1;
            }

            CreateBars(pane1, XValues, YValues1, YValues2, YValues3);

            pane1.BarSettings.Type = BarType.Overlay;

            zgc.MasterPane.Add(pane1);

            using (Graphics g = CreateGraphics())
            {

                zgc.MasterPane.SetLayout(g, PaneLayout.SingleColumn);
            }

            zgc.AxisChange();

            zgc.Invalidate();
        }
        private double[] GenerateData(int itemscount, Random rnd)
        {
            double[] values = new double[itemscount];

            for (int i = 0; i < itemscount; i++)
            {
                values[i] = rnd.NextDouble();
            }

            return values;
        }
        private static void CreateBars(GraphPane pane,
            double[] XValues,
            double[] YValues1, double[] YValues2, double[] YValues3)
        {
            pane.CurveList.Clear();

            pane.AddBar("", XValues, YValues1, Color.Green);
            pane.AddBar("", XValues, YValues2, Color.Red);
            pane.AddBar("", XValues, YValues3, Color.Gray);
        }
        void Time_TickM(object sender, EventArgs e)
        {
            s3++;
            con.Open();
            if (s3 % 10 == 0)
            {
                
                LstV.Items.Clear();
                string str1 = "SELECT Week.DayOfWeek, Smena.SmSta, Smena.SmEnd FROM [Week] INNER JOIN ([WeSm] INNER JOIN ([Ussmen] INNER JOIN [Smena] ON Ussmen.IdSmena=Smena.Id) ON WeSm.IdSmena=Ussmen.IdSmena AND Ussmen.IdUser='" + User.id + "')ON WeSm.IdWeek = Week.Id ORDER BY Week.DayOfWeek ASC";
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
                
            }
            SqlCommand cm2 = new SqlCommand("SELECT IdStatus FROM [User] WHERE Id='" + User.id + "'",con);
            Status.Text =cm2.ExecuteScalar().ToString();
            string st = Status.Text;
            if (st.Trim() == "Активен")
            {
                Status.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (st.Trim() == "Неактивен")
            {
                Status.BackColor = Color.Silver;
            }
            else if (st.Trim() == "Пауза")
            {
                Status.BackColor = Color.FromArgb(255, 128, 128);
            }
            con.Close();
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
            SqlCommand cmd = new SqlCommand("SELECT WorkTime, PauseTime FROM [Work] WHERE IdUser='" + User.id + "'", con);
            SqlDataReader vse = cmd.ExecuteReader();
            while (vse.Read())
            {

                b = vse[0].ToString();//rabota
                b1 = vse[1].ToString();//pausa
                wc += Convert.ToInt16(b[0] + "" + b[1]);
                wm += Convert.ToInt16(b[3] + "" + b[4]);
                if (wm >= 60) { wc += 1;wm -= 60; }
                pc += Convert.ToInt16(b1[0] + "" + b1[1]);
                pm += Convert.ToInt16(b1[3] + "" + b1[4]);
                if (pm >= 60) { pc += 1;pm -= 60; }
                c += Convert.ToInt16(b[0] + "" + b[1]);
                c += Convert.ToInt16(b1[0]+""+b1[1]);
                j += Convert.ToInt16(b[3] + "" + b[4]);
                if (j >= 60)
                {
                    c += 1;
                    j = j - 60;
                }
                j += Convert.ToInt16(b1[3]+ "" +b1[4]);
                if (j >= 60)
                {
                    c += 1;
                    j = j - 60;
                }

            }
            vse.Close();
            Vsego.Text = "Всего: " + c + ":" + j + "(100%)";
            pv = c * 60 + j;
            pr = (wc * 60 + wm)*100/pv;
            Rabota.Text = "В работе: "+wc+":"+wm+"("+ pr +"%)";
            Pauza.Text = "Пауза: " + pc + ":" + pm + "(" + (100-pr) +"%)";
            cmd.CommandText = "SELECT FioUs FROM [WrTime] WHERE FioUs='" + User.id + "'";


            if (cmd.ExecuteScalar() == null)
            {
                SqlCommand cm2 = new SqlCommand("INSERT INTO [WrTime] (FioUs, AllTime, PsTime, WrkTime)VALUES('" + User.id + "', '" + c + ":" + j + "', '" + pc + ":" + pm + "', '" + wc + ":" + wm + "')", con);
                cm2.ExecuteNonQuery();
            }
            else if (cmd.ExecuteScalar()!= null)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE [WrTime] SET AllTime='" + c + ":" + j + "' WHERE FioUs='" + User.id + "'",con);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("UPDATE [WrTime] SET PsTime='" + pc + ":" + pm + "' WHERE FioUs='" + User.id + "'", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("UPDATE [WrTime] SET WrkTime='" + wc + ":" + wm + "' WHERE FioUs='" + User.id + "'", con);
                cmd4.ExecuteNonQuery();
            }
            con.Close();
            pc = 0;
            pm = 0;
            wc = 0;
            wm = 0;
            c = 0;
            j = 0;
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (WTime.Text[1] == ':'|| WTime.Text[1]=='0')
            {
                WTime.Text = "0" + H + ":" + m;
                if (WTime.Text[WTime.Text.Count() - 2] == ':' || WTime.Text[WTime.Text.Count() - 2]=='0')
                {
                    WTime.Text = "0" + H + ":0" + m;
                }
            }
            else if (WTime.Text[1] != ':' || WTime.Text[1]!='0' && WTime.Text[WTime.Text.Count() - 2] == ':' || WTime.Text[WTime.Text.Count() - 2]=='0')
            {

                WTime.Text = H + ":0" + m;

            }
            else
            {
                WTime.Text = H + ":" + m;
            }

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
            if (PTime.Text[1] == ':' || PTime.Text[1] == '0')
            {
                PTime.Text = "0" + H + ":" + m;
                if (PTime.Text[PTime.Text.Count() - 2] == ':' || PTime.Text[PTime.Text.Count() - 2] == '0')
                {
                    PTime.Text = "0" + H2 + ":0" + m2;
                }
            }
            else if (PTime.Text[1] != ':' || PTime.Text[1] != '0' && PTime.Text[PTime.Text.Count() - 2] == ':' || PTime.Text[PTime.Text.Count() - 2] == '0')
            {

                PTime.Text = H2 + ":0" + m2;

            }
            else
            {
                PTime.Text = H2 + ":" + m2;
            }

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
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET IdStatus='Активен' WHERE Id='" + User.id + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET IdStatus='Пауза' WHERE Id='" + User.id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            s = 0;
            s2 = 0;
            WTime.Text = "00:00";
            PTime.Text = "00:00";
            if (En == null) { En = DateTime.Now.ToString("HH:mm"); }
            string dt = DateTime.Now.ToString("dddd");
            con.Open();
            SqlCommand cm = new SqlCommand("SELECT Id FROM [Week] WHERE DayOfWeek='" + dt + "'",con);
            string sd = cm.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Work] (WorkTime, PauseTime, StartWork, EndWork, IdUser, IdWeek)VALUES('" + rabT + "', '" + pasT + "', '" + St + "', '" + En + "', '" + User.id + "','" + sd + "')",con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("UPDATE [User] SET IdStatus='Активен' WHERE Id='" + User.id + "'", con);
            cmd2.ExecuteNonQuery();    
            
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
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET IdStatus='Неактивен' WHERE Id='" + User.id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET IdStatus='Неактивен' WHERE Id='" + User.id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
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

        private void Work_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET IdStatus='Неактивен' WHERE Id='" + User.id + "'", con);
            cmd.ExecuteNonQuery();
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
