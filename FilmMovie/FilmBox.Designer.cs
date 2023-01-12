// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilmMovie
{
    partial class FilmBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel_BtnAnasayfa = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel_BtnFilmler = new System.Windows.Forms.Panel();
            this.btnFilmler = new System.Windows.Forms.Button();
            this.panel_BtnDiziler = new System.Windows.Forms.Panel();
            this.btnDiziler = new System.Windows.Forms.Button();
            this.panel_BtnListem = new System.Windows.Forms.Panel();
            this.btnListem = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderPanel1 = new FilmMovie.SliderPanel();
            this.sliderPanel2 = new FilmMovie.SliderPanel();
            this.sideBar.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_BtnAnasayfa.SuspendLayout();
            this.panel_BtnFilmler.SuspendLayout();
            this.panel_BtnDiziler.SuspendLayout();
            this.panel_BtnListem.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideBar.Controls.Add(this.panel_Menu);
            this.sideBar.Controls.Add(this.panel_BtnAnasayfa);
            this.sideBar.Controls.Add(this.panel_BtnFilmler);
            this.sideBar.Controls.Add(this.panel_BtnDiziler);
            this.sideBar.Controls.Add(this.panel_BtnListem);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(361, 1500);
            this.sideBar.MinimumSize = new System.Drawing.Size(100, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(361, 1055);
            this.sideBar.TabIndex = 0;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.btnMenu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(3, 3);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(358, 79);
            this.panel_Menu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Image = global::FilmMovie.Properties.Resources.icons8_list_50;
            this.btnMenu.Location = new System.Drawing.Point(9, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(91, 49);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel_BtnAnasayfa
            // 
            this.panel_BtnAnasayfa.Controls.Add(this.btnAnasayfa);
            this.panel_BtnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BtnAnasayfa.Location = new System.Drawing.Point(3, 88);
            this.panel_BtnAnasayfa.Name = "panel_BtnAnasayfa";
            this.panel_BtnAnasayfa.Size = new System.Drawing.Size(358, 79);
            this.panel_BtnAnasayfa.TabIndex = 2;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnasayfa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnasayfa.Image = global::FilmMovie.Properties.Resources.icons8_home_page_50__1_;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAnasayfa.Size = new System.Drawing.Size(358, 79);
            this.btnAnasayfa.TabIndex = 0;
            this.btnAnasayfa.Text = "Ana Sayfa";
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // panel_BtnFilmler
            // 
            this.panel_BtnFilmler.Controls.Add(this.btnFilmler);
            this.panel_BtnFilmler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BtnFilmler.Location = new System.Drawing.Point(3, 173);
            this.panel_BtnFilmler.Name = "panel_BtnFilmler";
            this.panel_BtnFilmler.Size = new System.Drawing.Size(358, 79);
            this.panel_BtnFilmler.TabIndex = 3;
            // 
            // btnFilmler
            // 
            this.btnFilmler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilmler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmler.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilmler.Image = global::FilmMovie.Properties.Resources.icons8_movie_50;
            this.btnFilmler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmler.Location = new System.Drawing.Point(0, 0);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFilmler.Size = new System.Drawing.Size(358, 79);
            this.btnFilmler.TabIndex = 1;
            this.btnFilmler.Text = "Filmler";
            this.btnFilmler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilmler.UseVisualStyleBackColor = true;
            this.btnFilmler.Click += new System.EventHandler(this.btnFilmler_Click);
            // 
            // panel_BtnDiziler
            // 
            this.panel_BtnDiziler.Controls.Add(this.btnDiziler);
            this.panel_BtnDiziler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BtnDiziler.Location = new System.Drawing.Point(3, 258);
            this.panel_BtnDiziler.Name = "panel_BtnDiziler";
            this.panel_BtnDiziler.Size = new System.Drawing.Size(358, 79);
            this.panel_BtnDiziler.TabIndex = 4;
            // 
            // btnDiziler
            // 
            this.btnDiziler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiziler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiziler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiziler.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiziler.Image = global::FilmMovie.Properties.Resources.icons8_movie_theater_50;
            this.btnDiziler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiziler.Location = new System.Drawing.Point(0, 0);
            this.btnDiziler.Name = "btnDiziler";
            this.btnDiziler.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDiziler.Size = new System.Drawing.Size(358, 79);
            this.btnDiziler.TabIndex = 1;
            this.btnDiziler.Text = "Diziler";
            this.btnDiziler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiziler.UseVisualStyleBackColor = true;
            this.btnDiziler.Click += new System.EventHandler(this.btnDiziler_Click);
            // 
            // panel_BtnListem
            // 
            this.panel_BtnListem.Controls.Add(this.btnListem);
            this.panel_BtnListem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BtnListem.Location = new System.Drawing.Point(3, 343);
            this.panel_BtnListem.Name = "panel_BtnListem";
            this.panel_BtnListem.Size = new System.Drawing.Size(358, 79);
            this.panel_BtnListem.TabIndex = 5;
            // 
            // btnListem
            // 
            this.btnListem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListem.Image = global::FilmMovie.Properties.Resources.icons8_film_reel_50;
            this.btnListem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListem.Location = new System.Drawing.Point(0, 0);
            this.btnListem.Name = "btnListem";
            this.btnListem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnListem.Size = new System.Drawing.Size(358, 79);
            this.btnListem.TabIndex = 1;
            this.btnListem.Text = "Listem";
            this.btnListem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListem.UseVisualStyleBackColor = true;
            this.btnListem.Click += new System.EventHandler(this.btnListem_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(361, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 60);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1252, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.sliderPanel1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.sliderPanel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(361, 60);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(2500, 1500);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1252, 995);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.Resize += new System.EventHandler(this.flowLayoutPanel2_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filmler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diziler";
            // 
            // sliderPanel1
            // 
            this.sliderPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sliderPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sliderPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderPanel1.Location = new System.Drawing.Point(20, 40);
            this.sliderPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.sliderPanel1.Name = "sliderPanel1";
            this.sliderPanel1.Size = new System.Drawing.Size(1532, 423);
            this.sliderPanel1.TabIndex = 4;
            // 
            // sliderPanel2
            // 
            this.sliderPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sliderPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sliderPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderPanel2.Location = new System.Drawing.Point(20, 503);
            this.sliderPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.sliderPanel2.Name = "sliderPanel2";
            this.sliderPanel2.Size = new System.Drawing.Size(1532, 423);
            this.sliderPanel2.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1613, 1055);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmBox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sideBar.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_BtnAnasayfa.ResumeLayout(false);
            this.panel_BtnFilmler.ResumeLayout(false);
            this.panel_BtnDiziler.ResumeLayout(false);
            this.panel_BtnListem.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel_BtnAnasayfa;
        private System.Windows.Forms.Panel panel_BtnFilmler;
        private System.Windows.Forms.Panel panel_BtnDiziler;
        private System.Windows.Forms.Panel panel_BtnListem;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Button btnFilmler;
        private System.Windows.Forms.Button btnDiziler;
        private System.Windows.Forms.Button btnListem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private SliderPanel sliderPanel1;
        private System.Windows.Forms.Label label2;
        private SliderPanel sliderPanel2;
    }
}
