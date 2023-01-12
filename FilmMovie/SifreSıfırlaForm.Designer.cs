
namespace FilmMovie
{
    partial class SifreSıfırlaForm
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
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMailAdres = new System.Windows.Forms.TextBox();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Red;
            this.lblMail.Location = new System.Drawing.Point(84, 143);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(125, 26);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail Adresi :";
            // 
            // txtMailAdres
            // 
            this.txtMailAdres.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailAdres.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMailAdres.Location = new System.Drawing.Point(87, 175);
            this.txtMailAdres.Name = "txtMailAdres";
            this.txtMailAdres.Size = new System.Drawing.Size(319, 30);
            this.txtMailAdres.TabIndex = 1;
            this.txtMailAdres.Text = "ornek@hotmail.com";
            this.txtMailAdres.Leave += new System.EventHandler(this.txtMailAdres_Leave);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Maroon;
            this.btnSifirla.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.Black;
            this.btnSifirla.Location = new System.Drawing.Point(87, 262);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(319, 46);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SifreSıfırlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(506, 468);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.txtMailAdres);
            this.Controls.Add(this.lblMail);
            this.Name = "SifreSıfırlaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Sıfırla";
            this.Load += new System.EventHandler(this.SifreSıfırlaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMailAdres;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
