// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using DevExpress.Drawing.Internal.Fonts.Interop;

using DevExpress.XtraExport.Implementation;

using Microsoft.Win32;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmMovie
{
    public partial class Form_VideoPlayer : Form
    {
        string _yUrl;
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_yUrl);
                return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
            }
        }
        public Form_VideoPlayer(string _yUrl)
        {
            InitializeComponent();
            Go_Video(_yUrl);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Go_Video($"https://www.youtube.com/watch?v=mNgwNXKBEW0&ab_channel=KinoCheck.com");
        }
        private void Go_Video(string videoURL)
        {
            _yUrl = videoURL;
            webBrowser1.DocumentText = String.Format("<meta http-equiv='X-UA-Compatible' content='IE=Edge'/><iframe width='1272' height='721'" +
                " src='https://www.youtube.com/embed/{0}?autoplay=1' frameborder='0' allow='accelerometer; autoplay;" +
                " encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>", VideoID);
        }
    }
}
