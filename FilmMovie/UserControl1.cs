// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FilmMovie.Properties;

namespace FilmMovie
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //To Do
        }
        public void addNewItem(string cardName, string imagePath, string videoURL)
        {
            UserControl2_Cards card = new UserControl2_Cards();
            card.Name = cardName;
            card.Dock = System.Windows.Forms.DockStyle.Left;
            this.Controls.Add(card);
            card.SetCardImageProp(imagePath, cardName);
            card.videoURL = videoURL;

        }
        public void removeAllPictureCards()
        {
            this.Controls.Clear();
        }
        public void ChangeMyHScrollBarPosition(int xLoc)
        {
            // Change only location of X on HScrollBar.

            AutoScrollPosition = new Point(xLoc, 0);
        }
    }
}
