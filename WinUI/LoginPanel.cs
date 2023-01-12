using BLL;
using BLL.Repositories;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FilmMovie;

namespace WinUI
{
    public partial class LoginPanel : Form
    {

        public LoginPanel()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtEmail, "...@outlook.com");
        }
        KullaniciRepository kullaniRepo = new KullaniciRepository();
        Kullanicilar secilen;
        public static int ID; //giriş yapan kişinin id sini tutacak int 
        static int attempt = 3;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text != null ? txtEmail.Text.ToString() : "";
            string sifre = string.IsNullOrEmpty(txtSifre.Text) ? "" : txtSifre.Text.ToString();


            var kullanicilar = kullaniRepo.GetAll();
            if (kullanicilar.Any(x => x.KullaniciMail == email))
            {

                var kullanici = kullaniRepo.GetAll().Where(x => x.KullaniciMail == email).FirstOrDefault();
                if (sifre == "" && string.IsNullOrEmpty(kullanici.Sifre) && txtSifre.Text != kullanici.Sifre)
                {
                    MessageBox.Show("Geçersiz email ya da şifre.", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (kullanici != null)
                    {
                        if (kullanici.Sifre == Sifreleme.MD5Sifrele(sifre))
                        {
                            attempt = 0;
                            MessageBox.Show("Giriş başarılı.");
                            ID = kullanici.KullaniciId;
                            if (kullanici.RolId==4)
                            {
                                string message = "Editör olarak girmek için Yes'e Kullanıcı olarak girmek için No'ya basınız";
                                string title = "Editör Girişi";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.Yes)
                                {
                                    FilmMovie.EditorPanel frmEdit = new FilmMovie.EditorPanel();
                                    frmEdit.Show();
                                    this.Close();
                                }
                                else
                                {
                                    FilmMovie.FilmBox frm2 = new FilmMovie.FilmBox(ID);
                                    frm2.Show();
                                    this.Close();
                                }
                            }
                            else
                            {
                                FilmMovie.FilmBox frm2 = new FilmMovie.FilmBox(ID);
                                frm2.Show();
                                this.Close();
                            }
                            

                        }
                        else if ((attempt == 3) || (attempt > 0))
                        {
                            MessageBox.Show("Yalnızca " + Convert.ToString(attempt) + "  kere giriş hakkınız kaldı.");
                            --attempt;
                        }
                        else
                        {

                            MessageBox.Show("Hesabınız kitlendi. Şifrenizi [Şifremi unuttum] linkinden sıfırlayarak hesabınıza giriş yapabilirsiniz. İlgili bilgilere ulaşmak için asdsdsassds@outlook.com mail adresiyle iletişime geçebilirsiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            secilen = kullaniRepo.GetById(kullanici.KullaniciId);
                            secilen.isDeleted = true;
                            kullaniRepo.Update(secilen);
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Bu adreste bir kullanıcı hesabı bulunmamaktadır.");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnGeriDon.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            StartingPage frm2 = new StartingPage();
            frm2.Show();
            this.Close();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            UyelikFormu uf = new UyelikFormu();
            uf.Show();
            this.Close();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreSıfırlaForm df = new SifreSıfırlaForm();
            df.ShowDialog();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Lütfen mail formatında bi değer giriniz.");
                return;
            }
        }
    }
}
