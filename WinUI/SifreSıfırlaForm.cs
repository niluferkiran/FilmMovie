using BLL;
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

namespace FilmMovie
{
    public partial class SifreSıfırlaForm : Form
    {
        public SifreSıfırlaForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void SifreSıfırlaForm_Load(object sender, EventArgs e)
        {

        }
        MailGonderici mg = new MailGonderici();
        private void btnSifirla_Click(object sender, EventArgs e)
        {

            //mg.Microsoft(txtMailAdres.Text,txtMailSifre.Text,txtMailAdres.Text);
            //MessageBox.Show("Girilen bilgiler eşleşir ise şifreniz yenilecek ve mail olarak size gönderilecektir.","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //this.Close();
           

            //Bu method ile de sadece mail adresini yazarak sifre sıfırlama maili attırabiliriz. Gmail ya da outlook olmasının bir önemi olmadan gönderiyor.
            //Microsoft ekranı mantıksız geldiyse bu haliyle de çalıştırabiliriz.
            mg.Email(txtMailAdres.Text);
            MessageBox.Show("Girilen bilgiler eşleşir ise şifreniz yenilecek ve mail olarak size gönderilecektir.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void txtMailAdres_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(txtMailAdres.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtMailAdres, "Lütfen mail formatında bi değer giriniz.");
                return;
            }
        }
    }
}
