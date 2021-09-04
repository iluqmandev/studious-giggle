using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMCalculatorBedFittedPc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FittedSheet s = new FittedSheet();
            s.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pillow_Cushion p = new Pillow_Cushion();
            p.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
           // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState;
        }
    }
}
