using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //sınav1 50 den küçük olanlar
                var sayi = db.Tbl_Notlar.Where(p => p.SINAV1 <= 50);
                dataGridView1.DataSource = sayi.ToList();

            }
            if (radioButton2.Checked == true)
            {
                //adı ali olanlar
                var sorgu = db.Tbl_Ogrenci.Where(p => p.AD == "ali");
                dataGridView1.DataSource = sorgu.ToList();

            }
            if (radioButton3.Checked == true)
            {
                //adı ve soyadı textden al
                var sorgu = db.Tbl_Ogrenci.Where(p => p.AD == textBox1.Text || p.SOYAD==textBox1.Text);
                dataGridView1.DataSource = sorgu.ToList();

            }
            if (radioButton4.Checked == true)
            {
                //soyadlarını listeleme
                var sorgu = db.Tbl_Ogrenci.Select(p => 
                    new
                    {
                        Soyad =p.SOYAD
                    });
                dataGridView1.DataSource = sorgu.ToList();

            }
            if (radioButton5.Checked == true)
            {
                //ad büyük soy ad küçük
                var sorgu = db.Tbl_Ogrenci.Select(p => 
                    new
                    {
                        Ad = p.AD.ToUpper(),
                        Soyad=p.SOYAD.ToLower()
                    });
                dataGridView1.DataSource = sorgu.ToList();

            }
            if (radioButton6.Checked == true)
            {
                //şartlı seçim
                var deger = db.Tbl_Ogrenci.Select(p =>
                    new
                    {
                        Ad = p.AD.ToUpper(),
                        Soyad = p.SOYAD.ToLower()
                    }).Where(p => p.Ad =="Ali");

            }
            if (radioButton7.Checked == true)
            {
                //geçti kaldı
                var deger = db.Tbl_Notlar.Select(p =>
                    new
                    {
                       OgrenciAd=p.OGR,
                       Ortalama=p.ORTALAMA,
                       Durum=p.DURUM==true ? "Geçti":"Kaldı"
                    });

            }
            if (radioButton8.Checked == true)
            {
                //birleştir
                var deger = db.Tbl_Notlar.SelectMany(p => db.Tbl_Ogrenci.Where(y => y.ID == p.OGR),(p,y) => 
                new                         
                {
                    y.AD,
                    p.ORTALAMA,
                    Durum=p.DURUM==true ? "Geçti":"Kaldı"
                });
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton9.Checked == true)
            {
                //Order by ilk 3 değer
                var deger = db.Tbl_Ogrenci.OrderBy(p => p.ID).Take(3);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton10.Checked == true)
            {
                //Order by descending son 3 değer
                var deger = db.Tbl_Ogrenci.OrderByDescending(p => p.ID).Take(3);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton11.Checked == true)
            {
                //Order by descending son 3 değer
                var deger = db.Tbl_Ogrenci.OrderBy(p => p.AD);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton12.Checked == true)
            {
                //skip ilk 5 değeri atla
                var deger = db.Tbl_Ogrenci.OrderBy(p => p.ID).Skip(5);
                dataGridView1.DataSource = deger.ToList();
            }
        }
    }
}
