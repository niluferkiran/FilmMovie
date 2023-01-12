
namespace FilmMovie
{
    partial class StartingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOturumAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(132, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "En iyi film ve dizi izleme platformu";
            // 
            // button1
            // 
            this.button1.Image = global::WinUI.Properties.Resources.icons8_close_window_50;
            this.button1.Location = new System.Drawing.Point(1309, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOturumAc
            // 
            this.btnOturumAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOturumAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOturumAc.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturumAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOturumAc.Location = new System.Drawing.Point(560, 436);
            this.btnOturumAc.Name = "btnOturumAc";
            this.btnOturumAc.Size = new System.Drawing.Size(216, 63);
            this.btnOturumAc.TabIndex = 2;
            this.btnOturumAc.Text = "Oturum Aç";
            this.btnOturumAc.UseVisualStyleBackColor = false;
            this.btnOturumAc.Click += new System.EventHandler(this.btnOturumAc_Click);
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinUI.Properties.Resources.jack_reacher_star_wars_interstellar_movie_john_wick_wallpaper_preview__1_1;
            this.ClientSize = new System.Drawing.Size(1343, 682);
            this.Controls.Add(this.btnOturumAc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StartingPage";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmBox";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOturumAc;
    }
}
