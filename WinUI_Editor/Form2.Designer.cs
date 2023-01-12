
namespace FilmMovie
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnDiziSil = new System.Windows.Forms.Button();
            this.btnDiziGüncelle = new System.Windows.Forms.Button();
            this.btnDiziEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRolId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciSoyadi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTCKNAra = new System.Windows.Forms.TextBox();
            this.btnKullanicilariGetir = new System.Windows.Forms.Button();
            this.dgwyonetim = new System.Windows.Forms.DataGridView();
            this.chckBoxIsdeleted = new System.Windows.Forms.CheckBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwyonetim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiziSil
            // 
            this.btnDiziSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiziSil.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDiziSil.Location = new System.Drawing.Point(623, 172);
            this.btnDiziSil.Name = "btnDiziSil";
            this.btnDiziSil.Size = new System.Drawing.Size(75, 34);
            this.btnDiziSil.TabIndex = 113;
            this.btnDiziSil.Text = "Delete";
            this.btnDiziSil.UseVisualStyleBackColor = false;
            this.btnDiziSil.Click += new System.EventHandler(this.btnDiziSil_Click);
            // 
            // btnDiziGüncelle
            // 
            this.btnDiziGüncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiziGüncelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDiziGüncelle.Location = new System.Drawing.Point(623, 117);
            this.btnDiziGüncelle.Name = "btnDiziGüncelle";
            this.btnDiziGüncelle.Size = new System.Drawing.Size(75, 34);
            this.btnDiziGüncelle.TabIndex = 112;
            this.btnDiziGüncelle.Text = "Güncelle";
            this.btnDiziGüncelle.UseVisualStyleBackColor = false;
            this.btnDiziGüncelle.Click += new System.EventHandler(this.btnDiziGüncelle_Click);
            // 
            // btnDiziEkle
            // 
            this.btnDiziEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiziEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDiziEkle.Location = new System.Drawing.Point(623, 68);
            this.btnDiziEkle.Name = "btnDiziEkle";
            this.btnDiziEkle.Size = new System.Drawing.Size(75, 34);
            this.btnDiziEkle.TabIndex = 111;
            this.btnDiziEkle.Text = "Insert";
            this.btnDiziEkle.UseVisualStyleBackColor = false;
            this.btnDiziEkle.Click += new System.EventHandler(this.btnDiziEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(441, 147);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(372, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Şifre :";
            // 
            // txtRolId
            // 
            this.txtRolId.Location = new System.Drawing.Point(441, 118);
            this.txtRolId.Name = "txtRolId";
            this.txtRolId.Size = new System.Drawing.Size(100, 20);
            this.txtRolId.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(372, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Rol Id :";
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(207, 114);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSoyadi.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(94, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 103;
            this.label18.Text = "Kullanıcı Soyadı :";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(207, 169);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtpDogumTarihi.TabIndex = 102;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label20.ForeColor = System.Drawing.Color.DarkBlue;
            this.label20.Location = new System.Drawing.Point(94, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 101;
            this.label20.Text = "Doğum Tarihi:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(441, 89);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 100;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(371, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 99;
            this.label21.Text = "Mail Adresi :";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(207, 140);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(100, 20);
            this.txtTCKN.TabIndex = 98;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(94, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 97;
            this.label22.Text = "TCKN :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(207, 88);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 94;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label24.ForeColor = System.Drawing.Color.DarkBlue;
            this.label24.Location = new System.Drawing.Point(94, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 93;
            this.label24.Text = "Kullanıcı Adı:";
            // 
            // txtTCKNAra
            // 
            this.txtTCKNAra.Location = new System.Drawing.Point(376, 37);
            this.txtTCKNAra.Name = "txtTCKNAra";
            this.txtTCKNAra.Size = new System.Drawing.Size(100, 20);
            this.txtTCKNAra.TabIndex = 92;
            this.txtTCKNAra.Text = "TCKN Ara";
            this.txtTCKNAra.TextChanged += new System.EventHandler(this.txtTCKNAra_TextChanged);
            // 
            // btnKullanicilariGetir
            // 
            this.btnKullanicilariGetir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKullanicilariGetir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKullanicilariGetir.Location = new System.Drawing.Point(133, 22);
            this.btnKullanicilariGetir.Name = "btnKullanicilariGetir";
            this.btnKullanicilariGetir.Size = new System.Drawing.Size(155, 49);
            this.btnKullanicilariGetir.TabIndex = 91;
            this.btnKullanicilariGetir.Text = "Kullancıları Getir";
            this.btnKullanicilariGetir.UseVisualStyleBackColor = false;
            this.btnKullanicilariGetir.Click += new System.EventHandler(this.btnKullanicilariGetir_Click);
            // 
            // dgwyonetim
            // 
            this.dgwyonetim.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwyonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwyonetim.Location = new System.Drawing.Point(49, 229);
            this.dgwyonetim.Name = "dgwyonetim";
            this.dgwyonetim.Size = new System.Drawing.Size(697, 194);
            this.dgwyonetim.TabIndex = 114;
            this.dgwyonetim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwyonetim_CellDoubleClick);
            // 
            // chckBoxIsdeleted
            // 
            this.chckBoxIsdeleted.AutoSize = true;
            this.chckBoxIsdeleted.Location = new System.Drawing.Point(552, 37);
            this.chckBoxIsdeleted.Name = "chckBoxIsdeleted";
            this.chckBoxIsdeleted.Size = new System.Drawing.Size(53, 17);
            this.chckBoxIsdeleted.TabIndex = 115;
            this.chckBoxIsdeleted.Text = "Silindi";
            this.chckBoxIsdeleted.UseVisualStyleBackColor = true;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(441, 172);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyet.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(372, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Cinsiyet :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckBoxIsdeleted);
            this.Controls.Add(this.dgwyonetim);
            this.Controls.Add(this.btnDiziSil);
            this.Controls.Add(this.btnDiziGüncelle);
            this.Controls.Add(this.btnDiziEkle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRolId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKullaniciSoyadi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtTCKNAra);
            this.Controls.Add(this.btnKullanicilariGetir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwyonetim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiziSil;
        private System.Windows.Forms.Button btnDiziGüncelle;
        private System.Windows.Forms.Button btnDiziEkle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRolId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciSoyadi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTCKNAra;
        private System.Windows.Forms.Button btnKullanicilariGetir;
        private System.Windows.Forms.DataGridView dgwyonetim;
        private System.Windows.Forms.CheckBox chckBoxIsdeleted;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.Label label1;
    }
}
