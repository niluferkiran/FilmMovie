// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilmMovie
{
    partial class UserControl2_Cards
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelCard.Controls.Add(this.pictureBoxCard);
            this.panelCard.Controls.Add(this.labelName);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.MaximumSize = new System.Drawing.Size(362, 434);
            this.panelCard.MinimumSize = new System.Drawing.Size(362, 434);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(362, 434);
            this.panelCard.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(26, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelName.Size = new System.Drawing.Size(159, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = " Harry Potter";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Image = global::FilmMovie.Properties.Resources.SelviBoylumAlYazmalim;
            this.pictureBoxCard.Location = new System.Drawing.Point(30, 52);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(292, 352);
            this.pictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCard.TabIndex = 1;
            this.pictureBoxCard.TabStop = false;
            this.pictureBoxCard.Click += new System.EventHandler(this.pictureBoxCard_Click);
            // 
            // UserControl2_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCard);
            this.Name = "UserControl2_Cards";
            this.Size = new System.Drawing.Size(362, 434);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.Label labelName;
    }
}
