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

namespace FilmMovie
{
    public partial class EditorPanel : Form
    {
        public EditorPanel()
        {
            InitializeComponent();
        }


        FilmRepository fr = new FilmRepository();
        private void btnFilmGetir_Click(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void FilmleriGetir()
        {
            dataGridView1.DataSource = fr.GetAll();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            string filmAdi = txtFilmAdi.Text;
            string filmAfişi = txtFilmAfis.Text;
            int filmSuresi = Convert.ToInt32(txtFilmSüre.Text);
            string filmKonusu = txtFilmKonu.Text;
            DateTime vizyonTarihi = dtpFilmTarih.Value;
            int yönetmenId = Convert.ToInt32(txtFilmYönetmenId.Text);
            int kategoriId = Convert.ToInt32(txtFilmKategoriId.Text);
            string oduller = txtFilmOdul.Text;
            int yasSınırı = Convert.ToInt32(txtFilmYasSınırı.Text);
            string ulke = txtFilmUlke.Text;
            int fragmanSure = Convert.ToInt32(txtFilmFragmanSure.Text);
            string fragmanVideo = txtFilmVideo.Text;
            Boolean isDeleted = checkBoxFilm.Checked;

            if (
                string.IsNullOrEmpty(filmAdi)   || 
                string.IsNullOrEmpty(filmKonusu) || string.IsNullOrEmpty(Convert.ToString(yönetmenId))
                || string.IsNullOrEmpty(Convert.ToString(kategoriId))
                
                )
            {
                MessageBox.Show("İgili alanlar boş geçilemez.Lütfen doldurunuz");
                return;
            }

            else
            {
                fr.Insert(new DAL.Filmler
                {
                    FilmAdi = filmAdi,
                    FilmResim = filmAfişi,
                    FilmSuresi = filmSuresi,
                    Konusu = filmKonusu,
                    VizyonTarihi = vizyonTarihi,
                    YonetmenId = yönetmenId,
                    KategoriId = kategoriId,
                    FilmOdul = oduller,
                    YasSiniri = yasSınırı,
                    Ulkesi = ulke,
                    FragmanSuresi = fragmanSure,
                    FragmanVideo = fragmanVideo,
                    isDeleted = isDeleted
                });
                Temizle();
                FilmleriGetir();

                MessageBox.Show("Film Başarıyla Eklendi");
            }
        }

        private void Temizle()
        {
            txtFilmAdi = txtFilmAfis = txtFilmSüre = txtFilmKonu = txtFilmYönetmenId = txtFilmKategoriId = txtFilmOdul = txtFilmYasSınırı = txtFilmUlke = txtFilmFragmanSure = txtFilmVideo = null;

        }


        DAL.Filmler secilenFilm;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            secilenFilm = fr.GetById(id);

            txtFilmAdi.Text = secilenFilm.FilmAdi;
            txtFilmAfis.Text = secilenFilm.FilmResim;
            txtFilmSüre.Text = Convert.ToString(secilenFilm.FilmSuresi);
            txtFilmKonu.Text = secilenFilm.Konusu;
            txtFilmYönetmenId.Text = Convert.ToString(secilenFilm.YonetmenId);
            txtFilmKategoriId.Text = Convert.ToString(secilenFilm.KategoriId);
            txtFilmOdul.Text = secilenFilm.FilmOdul;
            txtFilmYasSınırı.Text = Convert.ToString(secilenFilm.YasSiniri);
            txtFilmUlke.Text = secilenFilm.Ulkesi;
            txtFilmFragmanSure.Text = Convert.ToString(secilenFilm.FilmSuresi);
            txtFilmVideo.Text = secilenFilm.FragmanVideo;
            dtpFilmTarih.Value = Convert.ToDateTime(secilenFilm.VizyonTarihi);

        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            secilenFilm.FilmAdi = txtFilmAdi.Text;
            secilenFilm.FilmResim = txtFilmAfis.Text;
            secilenFilm.FilmSuresi = Convert.ToInt32(txtFilmSüre.Text);
            secilenFilm.Konusu = txtFilmKonu.Text;
            secilenFilm.YonetmenId = Convert.ToInt32(txtFilmYönetmenId.Text);
            secilenFilm.KategoriId = Convert.ToInt32(txtFilmKategoriId.Text);
            secilenFilm.FilmOdul = txtFilmOdul.Text;
            secilenFilm.YasSiniri = Convert.ToInt32(txtFilmYasSınırı.Text);
            secilenFilm.Ulkesi = txtFilmKonu.Text;
            secilenFilm.FragmanSuresi = Convert.ToInt32(txtFilmFragmanSure.Text);
            secilenFilm.FragmanVideo = txtFilmVideo.Text;
            secilenFilm.VizyonTarihi = dtpFilmTarih.Value;

            fr.Update(secilenFilm);

            MessageBox.Show("Film Başarıyla Güncellendi");
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {

            fr.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            FilmleriGetir();
            Temizle();
            checkBoxFilm.Enabled = false;

        }

        private void txtFilmAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fr.GetAll().Where(f => f.FilmAdi.StartsWith(txtFilmAra.Text)).ToList();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Form2 yonetim = new Form2();
            yonetim.Show();
            this.Hide();
        }

        //--------DİZİLER----------
        DiziRepository dr = new DiziRepository();
        private void btnDiziGetir_Click(object sender, EventArgs e)
        {
            DiziGetir();
        }

        private void DiziGetir()
        {
            dGVDizi.DataSource = dr.GetAll();
        }
        private void btnDiziEkle_Click(object sender, EventArgs e)
        {
            if (txtDiziAdi.Text == "" || txtDiziYönetmenId.Text == "" || txtDiziKategoriId.Text == "" || txtDiziBölümSayisi.Text == "" || txtDiziUlkesi.Text == "" || txtDiziSezonSayisi.Text == "")
            {
                MessageBox.Show("Ekleme yapmanız için tüm alanları doldurmanız gerekiyor");
            }
            else
            {
                Diziler _yenidizi = new Diziler();

                _yenidizi.DiziAdi = txtDiziAdi.Text;
                _yenidizi.YonetmenId = Convert.ToInt32(txtDiziYönetmenId.Text);
                _yenidizi.KategoriId = Convert.ToInt32(txtDiziKategoriId.Text);
                _yenidizi.BolumSayisi = Convert.ToInt32(txtDiziBölümSayisi.Text);
                _yenidizi.SezonSayisi = Convert.ToInt32(txtDiziSezonSayisi.Text);
                _yenidizi.Ulkesi = txtDiziUlkesi.Text;
                //_yenidizi.DiziResim = txtDiziAfisi.Text;
                _yenidizi.isDeleted = false;
                _yenidizi.DiziOdul = txtDiziOdülleri.Text;

                dr.Insert(_yenidizi);

                DiziTemizle();
            }
        }

        private void DiziTemizle()
        {
            txtDiziAdi.Text = txtDiziSezonSayisi.Text = txtDiziBölümSayisi.Text = txtDiziYönetmenId.Text = txtDiziKategoriId.Text = txtDiziOdülleri.Text = txtDiziAra.Text = txtDiziUlkesi.Text = string.Empty;
            checkBoxDizi.Checked = true;
        }

        Diziler secilenDizi;
        private void dGVDizi_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            secilenDizi = dr.GetById(id);

            txtDiziAdi.Text = secilenDizi.DiziAdi;
            txtDiziKategoriId.Text = secilenDizi.KategoriId.ToString();
            txtDiziBölümSayisi.Text = secilenDizi.BolumSayisi.ToString();
            txtDiziSezonSayisi.Text = secilenDizi.SezonSayisi.ToString();
            txtDiziUlkesi.Text = secilenDizi.Ulkesi;
            txtDiziOdülleri.Text = secilenDizi.DiziOdul;
            txtDiziYönetmenId.Text = secilenDizi.YonetmenId.ToString();

            if (secilenDizi.isDeleted == true)
            {
                checkBoxDizi.Checked = false;
            }
            else
            {
                checkBoxDizi.Checked = true;
            }
        }

        string DiziAdi;
        string YonetmenId;
        string KategoriId;
        string BolumSayisi;
        string SezonSayisi;
        string Ulkesi;
        string DiziOdul;

        private void btnDiziGüncelle_Click(object sender, EventArgs e)
        {
            if (secilenDizi == null)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız");
            }
            else if (txtDiziAdi.Text == "" || txtDiziYönetmenId.Text == "" || txtDiziKategoriId.Text == "" || txtDiziBölümSayisi.Text == "" || txtDiziUlkesi.Text == "" || txtDiziSezonSayisi.Text == "")
            {
                MessageBox.Show("Güncellemeniz için önce boş alanları doldurmanız gerekiyor");
            }
            else
            {
                DiziAdi = txtDiziAdi.Text;
                YonetmenId = txtDiziYönetmenId.Text;
                KategoriId = txtDiziKategoriId.Text;
                BolumSayisi = txtDiziBölümSayisi.Text;
                Ulkesi = txtDiziUlkesi.Text;
                SezonSayisi = txtDiziSezonSayisi.Text;
                DiziOdul = txtDiziOdülleri.Text;

                secilenDizi.DiziAdi = DiziAdi;
                secilenDizi.YonetmenId = int.Parse(YonetmenId);
                secilenDizi.KategoriId = int.Parse(KategoriId);
                secilenDizi.BolumSayisi = int.Parse(BolumSayisi);
                secilenDizi.SezonSayisi = Convert.ToInt32(SezonSayisi);
                secilenDizi.Ulkesi = Ulkesi;
                secilenDizi.DiziOdul = DiziOdul;

                dr.Update(secilenDizi);
                DiziGetir();
            }

        }

        private void btnDiziSil_Click(object sender, EventArgs e)
        {
            if (dGVDizi.SelectedRows.Count > 0)
            {
                dr.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                Temizle();
                checkBoxDizi.Enabled = false;
                DiziGetir();
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız");
            }
        }

        string arananDeger;
        private void txtDiziAra_TextChanged(object sender, EventArgs e)
        {
            if (txtDiziAra.Text.Length > 0)



            dataGridView1.DataSource = dr.GetAll().Where(d => d.DiziAdi.StartsWith(txtDiziAra.Text)).ToList();

            arananDeger = txtDiziAra.Text.ToLower();
            dataGridView1.DataSource = dr.GetAll().Where
           (aranan => aranan.DiziAdi.ToLower().Contains(arananDeger)).ToList();
        }



        //-------Dizi DETAY-----
        DiziDetayRepository ddr = new DiziDetayRepository();




        //---------OYUNCULAR---------
        OyuncularRepository or = new OyuncularRepository();

        private void button8_Click(object sender, EventArgs e)
        {
            OyuncuGetir();
        }

        private void OyuncuGetir()
        {
            dataGridView3.DataSource = or.GetAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string OyuncuAdi = oyuncuadi.Text;
            string OyuncuSoyadi = oyuncusoyadi.Text;
            //DateTime DogumTarihi = oyncudgmtarihi.Value;
            string Cinsiyet = oyuncucinsiyeti.Text;
            string Ulkesi = oyuncuulkesi.Text;
            string OyuncuOdulleri = oyuncuodul.Text;


            if (string.IsNullOrEmpty(OyuncuAdi) || string.IsNullOrEmpty(OyuncuSoyadi) || string.IsNullOrEmpty(Cinsiyet) || string.IsNullOrEmpty(Ulkesi) || string.IsNullOrEmpty(OyuncuOdulleri))
            {
                MessageBox.Show("İlgili alanlar boş geçilemez");
                return;
            }

            //or.Insert(new Oyuncular
            //{
            //    oyncuadi = OyuncuAdi,
            //    oyncusoyadi = OyuncuSoyadi

            //});

            or.Insert(new Oyuncular
            {
                OyuncuAdi = oyuncuadi.Text,
                OyuncuSoyadi = oyuncusoyadi.Text,
                DogumTarihi = oyuncudgmtarihi.Value,
                Cinsiyet = oyuncucinsiyeti.Text,
                Ulkesi = oyuncuulkesi.Text,
                OyuncuOdulleri = oyuncuodul.Text
            });

            MessageBox.Show("Yeni oyuncu eklendi.");
            dataGridView3.DataSource = or.GetAll();
            Temizle_Oyuncular();
        }

        private void Temizle_Oyuncular()
        {
            oyuncuadi.Text = oyuncusoyadi.Text = oyuncucinsiyeti.Text = oyuncuulkesi.Text = oyuncuodul.Text = string.Empty;
        }


        Oyuncular secilenOyuncular;
        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            secilenOyuncular = or.GetById(Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
            oyuncuadi.Text = secilenOyuncular.OyuncuAdi;
            oyuncusoyadi.Text = secilenOyuncular.OyuncuSoyadi;
            oyuncudgmtarihi.Value = Convert.ToDateTime(secilenOyuncular.DogumTarihi);
            oyuncucinsiyeti.Text = secilenOyuncular.Cinsiyet;
            oyuncuulkesi.Text = secilenOyuncular.Ulkesi;
            oyuncuodul.Text = secilenOyuncular.OyuncuOdulleri;
        } 
        
        private void btnOyuncuGuncelle_Click(object sender, EventArgs e)
        {
            secilenOyuncular.OyuncuAdi = oyuncuadi.Text;
            secilenOyuncular.OyuncuSoyadi = oyuncusoyadi.Text;
            secilenOyuncular.DogumTarihi = oyuncudgmtarihi.Value;
            secilenOyuncular.Cinsiyet = oyuncucinsiyeti.Text;
            secilenOyuncular.Ulkesi = oyuncuulkesi.Text;
            secilenOyuncular.OyuncuOdulleri = oyuncuodul.Text;
            or.Update(secilenOyuncular);
            MessageBox.Show("Değişiklikler kaydedildi.");
            dataGridView3.DataSource = or.GetAll();

            Temizle_Oyuncular();
        }

        private void btnOSil_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                or.Delete(Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
                dataGridView3.DataSource = or.GetAll();
                Temizle_Oyuncular();

            }
        }


        //---------YONETMENLER---------
        YonetmenRepository yr = new YonetmenRepository();
        private void btnYntmnGetir_Click(object sender, EventArgs e)
        {
            YonetmenGetir();
        }

        private void YonetmenGetir()
        {
            dataGridView4.DataSource = yr.GetAll();

        } 
        private void btnYEkle_Click(object sender, EventArgs e)
        {
            if (txtYAdi.Text.Length == 0 || txtYSoyadi.Text.Length == 0)
            {
                MessageBox.Show("Ad ve Soyad alanları boş geçilemez.!");
            }
            else
            {
                Yonetmenler yeniYonetmen = new Yonetmenler();
                yeniYonetmen.YonetmenAdi = txtYAdi.Text;
                yeniYonetmen.YonetmenSoyadi = txtYSoyadi.Text;
                yeniYonetmen.Cinsiyet = txtYCinsiyet.Text;
                yeniYonetmen.DogumTarihi = dtpYonetmen.Value;
                yr.Insert(yeniYonetmen);
                YonetmenTemizle();
            }
        }

        private void YonetmenTemizle()
        {
            textBox1.Text = textBox2.Text = textBox4.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        Yonetmenler secilenYonetmen;
        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            secilenYonetmen = yr.GetById(id);

            txtYAdi.Text = secilenYonetmen.YonetmenAdi;
            txtYSoyadi.Text = secilenYonetmen.YonetmenSoyadi;
            txtYCinsiyet.Text = secilenYonetmen.Cinsiyet;
            dtpYonetmen.Value = (DateTime)secilenYonetmen.DogumTarihi;
        }
        private void btnYGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenYonetmen == null)
            {
                MessageBox.Show("Listeden ütfen bir veri seçiniz.");
            }
            else if (txtYAdi.Text == null || txtYSoyadi.Text == null || txtYCinsiyet.Text == null || dtpYonetmen.Value == null)
            {
                MessageBox.Show("Güncelleme yapmak için ilgili alanlar boş geçilemez.");

            }
            else
            {
                secilenYonetmen.YonetmenAdi = txtYAdi.Text;
                secilenYonetmen.YonetmenSoyadi = txtYSoyadi.Text;
                secilenYonetmen.Cinsiyet = txtYCinsiyet.Text;
                secilenYonetmen.DogumTarihi = dtpYonetmen.Value;
                yr.Update(secilenYonetmen);
            }

        }
        private void btnYSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete", "Silmek istediğine emin misin?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (secilenYonetmen == null)
                {
                    MessageBox.Show("Silmek için birini seçiniz");
                }
                else
                {
                    yr.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    YonetmenGetir();
                    Temizle();
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //-------------KATEGORİLER-------------

        KategoriRepository kr = new KategoriRepository();

        private void btnKategoriGetir_Click(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            dgvKategori.DataSource = kr.GetAll();
            dgvKategori.Columns["Diziler"].Visible = false;
            dgvKategori.Columns["Filmler"].Visible = false;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdı = txtKategoriAdi.Text;

            if (string.IsNullOrEmpty(kategoriAdı))
            {
                MessageBox.Show("Lütfen Boş Bırakılan Alanı Doldurunuz");
            }

            else
            {
                kr.Insert(new DAL.Kategoriler
                {
                    KategoriAdi = kategoriAdı
                });
                KategoriTemizle();
                KategoriGetir();

                MessageBox.Show("Kategori Başarıyla Eklendi");
            }
        }
        
        private void KategoriTemizle()
        {
            txtKategoriAdi.Text = null;
        }

        DAL.Kategoriler secilenKategori;
        private void dgvKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvKategori.CurrentRow.Cells[0].Value);
            secilenKategori = kr.GetById(id);

            txtKategoriAdi.Text = secilenKategori.KategoriAdi;
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            secilenKategori.KategoriAdi = txtKategoriAdi.Text;

            kr.Update(secilenKategori);

            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void txtKategoriAra_TextChanged(object sender, EventArgs e)
        {
            dgvKategori.DataSource = kr.GetAll().Where(k => k.KategoriAdi.StartsWith(txtKategoriAra.Text)).ToList();
        }



    }
}
