// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FilmMovie.Properties;

namespace FilmMovie
{
    public partial class UserControl2_Cards : UserControl
    {
        public string videoURL { get; set; }
        public UserControl2_Cards()
        {
            InitializeComponent();

        }
        internal void SetCardImageProp(string pbImageName, string labelTxt)
        {
            this.pictureBoxCard.Image = (Image)Resources.ResourceManager.GetObject(pbImageName);
            this.labelName.Text = labelTxt;
        }
        private void pictureBoxCard_Click(object sender, EventArgs e)
        {
            runVideo(videoURL);
        }
        private void runVideo(string videoURL)
        {
            Form_VideoPlayer fvp = new Form_VideoPlayer(videoURL);
            fvp.Show();
        }
    }
}
