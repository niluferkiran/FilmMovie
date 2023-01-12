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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinUI;

namespace FilmMovie
{
    public partial class UyelikFormu : Form
    {
        public UyelikFormu()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtMail, "Lütfen outlook hesabı giriniz.");
        }

        private void UyelikFormu_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 60, 60, 60);
        }
        string cinsiyet;
        int yaS;
        int rolId;
        KullaniciRepository kulRepo = new KullaniciRepository();


        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (radioButtonKadin.Checked == true)
            {
                cinsiyet = radioButtonKadin.Text;
            }
            else
            {
                cinsiyet = radioButtonErkek.Text;
            }
            if (yaS < 18)
            {
                rolId = 2;
            }
            else
            {
                rolId = 1;
            }

            string kullaniciAdi = txtAdi.Text;
            string kullanciSoyadi = txtSoyadi.Text;
            string eMail = txtMail.Text;
            string sifre = txtSifreKontrol1.Text != txtSifreKontrol2.Text ? "" : txtSifreKontrol1.Text;


            DateTime dogumTarihi = dtpDogumTarihi.Value;
            string tckno = txtTCKNO.Text;
            int RolID = rolId;


            var kullanicilar = kulRepo.GetAll();
            //Yazılan textbox ların dolu olup olmadığının kontrolü

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(kullanciSoyadi) || string.IsNullOrEmpty(tckno) || string.IsNullOrEmpty(eMail) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("İlgili alanlar boş geçilemez.");

            }//Aynı mail adresiyle üyelik yapıp yapmadığının kontrolü
            else if (kullanicilar.Any(x => x.KullaniciMail == eMail))
            {
                MessageBox.Show("Bu kullanıcı maili ile ilgili bir hesap zaten var. Başka bir mail adresi giriniz.");
            }
            else
            {
                kulRepo.Insert(new Kullanicilar
                {
                    KullaniciAdi = kullaniciAdi,
                    KullaniciSoyadi = kullanciSoyadi,
                    KullaniciMail = eMail,
                    Sifre = Sifreleme.MD5Sifrele(sifre),
                    DogumTarihi = dogumTarihi,
                    TCKN = tckno,
                    Cinsiyet = cinsiyet,
                    RolId = RolID
                });
                MessageBox.Show("İşlem başarılı.");
                Temizle();
            }
        }

        private void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            yaS = yas / 365;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(txtMail.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtMail, "Lütfen mail formatında bi değer giriniz.");
                return;
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            LoginPanel lgnPanel = new LoginPanel();
            lgnPanel.Show();
            this.Close();
        }
    }
}
