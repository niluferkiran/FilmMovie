// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilmMovie
{
    partial class CardSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl12 = new FilmMovie.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.AutoScroll = true;
            this.userControl12.AutoScrollMargin = new System.Drawing.Size(25, 25);
            this.userControl12.AutoSize = true;
            this.userControl12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl12.Location = new System.Drawing.Point(-186, -4);
            this.userControl12.MaximumSize = new System.Drawing.Size(1448, 445);
            this.userControl12.MinimumSize = new System.Drawing.Size(760, 445);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(1448, 445);
            this.userControl12.TabIndex = 6;
            // 
            // CardSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.userControl12);
            this.MaximumSize = new System.Drawing.Size(1080, 440);
            this.MinimumSize = new System.Drawing.Size(904, 440);
            this.Name = "CardSlider";
            this.Size = new System.Drawing.Size(1076, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControl1 userControl12;
    }
}
