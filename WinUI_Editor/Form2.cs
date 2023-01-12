using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmMovie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        YonetimRepository yr = new YonetimRepository();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void btnKullanicilariGetir_Click(object sender, EventArgs e)
        {
            KullanıcılarıGetir();
        }

        private void KullanıcılarıGetir()
        {
            dgwyonetim.DataSource = yr.GetAll();
        }       
       

        private void btnDiziEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string kullaniciSoyadi = txtKullaniciSoyadi.Text;
            string TCKN = txtTCKN.Text;
            DateTime dogumTarihi = dtpDogumTarihi.Value;
            int rolId = Convert.ToInt32(txtRolId.Text);
            string mail = txtMail.Text;
            string sifre = txtSifre.Text;
            string cinsiyet = txtCinsiyet.Text;
            bool isDeleted = chckBoxIsdeleted.Checked;


            yr.Insert(new DAL.Kullanicilar
            {
                KullaniciAdi = kullaniciAdi,
                KullaniciSoyadi = kullaniciSoyadi,
                TCKN = TCKN,
                DogumTarihi = dogumTarihi,
                RolId = rolId,
                KullaniciMail = mail,
                Sifre = sifre,
                Cinsiyet = cinsiyet,
                isDeleted = isDeleted
            });
            Temizle();
            KullanıcılarıGetir();
        }

        private void Temizle()
        {
            txtKullaniciAdi = txtKullaniciSoyadi = txtTCKN = txtSifre = txtRolId = txtCinsiyet = txtMail = null;
           
        }

        DAL.Kullanicilar secilenKullanici;
        private void dgwyonetim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgwyonetim.CurrentRow.Cells[0].Value);
            secilenKullanici = yr.GetById(id);

            txtKullaniciAdi.Text = secilenKullanici.KullaniciAdi;
            txtKullaniciSoyadi.Text = secilenKullanici.KullaniciSoyadi;
            txtTCKN.Text = secilenKullanici.TCKN;
            dtpDogumTarihi.Value = Convert.ToDateTime(secilenKullanici.DogumTarihi);
            txtRolId.Text = Convert.ToString(secilenKullanici.RolId);
            txtCinsiyet.Text = secilenKullanici.Cinsiyet;
            txtMail.Text = secilenKullanici.KullaniciMail;
            txtSifre.Text = secilenKullanici.Sifre;
            chckBoxIsdeleted.Checked = Convert.ToBoolean(secilenKullanici.isDeleted);
        }

        private void btnDiziGüncelle_Click(object sender, EventArgs e)
        {
            secilenKullanici.KullaniciAdi = txtKullaniciAdi.Text;
            secilenKullanici.KullaniciSoyadi = txtKullaniciSoyadi.Text;
            secilenKullanici.TCKN = txtTCKN.Text;
            secilenKullanici.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
            secilenKullanici.RolId =Convert.ToInt32(txtRolId.Text);
            secilenKullanici.Cinsiyet = txtCinsiyet.Text;
            secilenKullanici.KullaniciMail = txtMail.Text;
            secilenKullanici.Sifre = txtSifre.Text;
            secilenKullanici.isDeleted = Convert.ToBoolean(chckBoxIsdeleted.Checked);

            yr.Update(secilenKullanici);
        }

        private void btnDiziSil_Click(object sender, EventArgs e)
        {
            yr.Delete(Convert.ToInt32(dgwyonetim.CurrentRow.Cells[0].Value));
            KullanıcılarıGetir();            
            chckBoxIsdeleted.Enabled = false;
            Temizle();
        }

        private void txtTCKNAra_TextChanged(object sender, EventArgs e)
        {
            dgwyonetim.DataSource = yr.GetAll().Where(f => f.TCKN.StartsWith(txtTCKNAra.Text)).ToList();

        }
    }
}
