// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmMovie
{
    public partial class FilmBox : Form
    {
        bool sideBarExpand;
        public static int kullaniciID;

        public FilmBox(int userID)
        {
            kullaniciID = userID;
            InitializeComponent();
            InitialiazeAnasayfa();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                c.Width = flowLayoutPanel2.Size.Width - 20;
                c.Height = 340;
            }
            this.sliderPanel2.SetKullaniciId(kullaniciID);

    }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }

            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }

            }
        }
        

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                c.Width = flowLayoutPanel2.Size.Width - 20;
                c.Height = 340;
            }
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            InitialiazeAnasayfa();
        }

        private void InitialiazeAnasayfa()
        {
            this.label1.Text = "Filmler";
            this.sliderPanel1.GetCardsWithOption("Filmler");

            this.label2.Text = "Diziler";
           this.sliderPanel2.GetCardsWithOption("Diziler");
        }

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Filmler";
            this.sliderPanel1.GetCardsWithOption("Filmler");

            this.label2.Text = "En son İzlediklerin";
            this.sliderPanel2.GetCardsWithOption("FilmSonİzlediklerim");
        }

        private void btnDiziler_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Diziler";
            this.sliderPanel1.GetCardsWithOption("Diziler");

            this.label2.Text = "En son İzlediklerin";
            this.sliderPanel2.GetCardsWithOption("DiziSonİzlediklerim");
        }

        private void btnListem_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Listene Eklediğin Filmler";
            this.sliderPanel2.GetCardsWithOption("FilmListem");

            this.label2.Text = "Listene Eklediğin Diziler";
            this.sliderPanel2.GetCardsWithOption("DiziListem");

        }

    }
}
