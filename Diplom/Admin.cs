using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
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
    }
}
