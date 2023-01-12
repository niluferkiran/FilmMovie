using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinUI;

namespace FilmMovie
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 240, 240, 240);
            label1.BorderStyle = BorderStyle.Fixed3D;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //frm2.Close();
            //Application.Exit();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {

            LoginPanel frm3 = new LoginPanel();
            frm3.Show();
            this.Hide();
        }

    }
}
