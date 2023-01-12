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

using BLL.Repositories;

using DAL;

using DevExpress.DirectX.Common.DirectWrite;

using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace FilmMovie
{
    public partial class SliderPanel : UserControl
    {

        FilmsRepository fr = new FilmsRepository();
        MoviesRepository dr = new MoviesRepository();
        int xLocNow;
        int kullaniciID;
        //public Form2 ParentForm { get; set; }
        public SliderPanel()
        {
            InitializeComponent();
        }
        public void SetKullaniciId(int id)
        {
            kullaniciID = id;
        }
        public void GetCardsWithOption(string option)
        {
            if (option == "Filmler")
            {
                clearAllCards();
                foreach (Filmler _film in fr.GetAll())
                {
                    userControl11.addNewItem(_film.FilmAdi, _film.FilmResim, _film.Video);
                }
            }
            else if (option == "Diziler")
            {
                clearAllCards();
                foreach (Diziler _dizi in dr.GetAll())
                {
                    userControl11.addNewItem(_dizi.DiziAdi, _dizi.DiziResim, _dizi.DiziAdi);
                }
            }
            else if (option == "FilmListem")
            {
                clearAllCards();
                foreach (Filmler _film in fr.GetMyList(kullaniciID))
                {
                    userControl11.addNewItem(_film.FilmAdi, _film.FilmResim, _film.Video);
                }
            }
            else if (option == "DiziListem")
            {
                clearAllCards();
                foreach (Diziler _dizi in dr.GetMyList(kullaniciID))
                {
                    userControl11.addNewItem(_dizi.DiziAdi, _dizi.DiziResim, _dizi.DiziAdi);
                }
            }
            else if (option == "FilmSonİzlediklerim")
            {
                clearAllCards();
                foreach (Filmler _film in fr.GetLastWatchList(kullaniciID))
                {
                    userControl11.addNewItem(_film.FilmAdi, _film.FilmResim, _film.Video);
                }
            }
            else if (option == "DiziSonİzlediklerim")
            {
                clearAllCards();
                List<Diziler> dz = dr.GetLastWatchList(kullaniciID).ToList();
                foreach (Diziler _dizi in dr.GetLastWatchList(kullaniciID))
                {
                    userControl11.addNewItem(_dizi.DiziAdi, _dizi.DiziResim, _dizi.DiziAdi);
                }
            }
        }
        public void clearAllCards()
        {
            userControl11.removeAllPictureCards();
        }

        public void SliderPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.MaximumSize = new Size(flowLayoutPanel1.Size.Width, 1000);
                c.MinimumSize = new Size(760, 360);

                if (c.Controls.Count <= 5)
                {
                    btnNext.Visible = false;
                    btnPrevious.Visible = false;
                    panel1.Visible = false;
                    panel2.Visible = false;
                }
                else
                {
                    btnNext.Visible = true;
                    btnPrevious.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
                }
            }
        }

        #region ScroolToRight
        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            timerNextButton.Start();
        }

        private void btnNext_MouseUp(object sender, MouseEventArgs e)
        {
            timerNextButton.Stop();
        }

        private void timerNextButton_Tick(object sender, EventArgs e)
        {
            xLocNow = (userControl11.AutoScrollPosition.X) * (-1) + 5;
            userControl11.ChangeMyHScrollBarPosition(xLocNow);
        }
        #endregion
        #region ScrollToLeft
        private void btnPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            timerPreviousButton.Start();
        }

        private void btnPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            timerPreviousButton.Stop();
        }
        private void timerPreviousButton_Tick(object sender, EventArgs e)
        {
            xLocNow = (userControl11.AutoScrollPosition.X) * (-1) - 5;
            userControl11.ChangeMyHScrollBarPosition(xLocNow);
        }
        #endregion

    }
}

