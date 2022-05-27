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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnderslistesi_Click(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbSınavOgrenci;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Tbl_Dersler", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db.Tbl_Ogrenci.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnnotlistesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.Tbl_Notlar
                        select new
                        {
                            item.NOTID,
                            item.Tbl_Ogrenci.AD,
                            item.Tbl_Ogrenci.SOYAD,
                            item.Tbl_Dersler.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();  
            //dataGridView1.DataSource = db.Tbl_Notlar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tbl_Ogrenci t = new Tbl_Ogrenci();
            t.AD = txtograd.Text;
            t.SOYAD = txtogrsoyad.Text;
            db.Tbl_Ogrenci.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrid.Text);
            var x = db.Tbl_Ogrenci.Find(id);
            db.Tbl_Ogrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrid.Text);
            var x = db.Tbl_Ogrenci.Find(id);

            x.AD = txtograd.Text;
            x.SOYAD = txtogrsoyad.Text;
            x.FOTOGRAF = txtogrfoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void prosedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLİSTESİ();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Ogrenci.Where(degisken => degisken.AD == txtograd.Text & degisken.SOYAD==txtogrsoyad.Text).ToList();  
        }

        private void txtograd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtograd.Text;
            var sorgu = from item in db.Tbl_Ogrenci
                        where item.AD.Contains(aranan)//içerdiklerini getiriyor
                        select item;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<Tbl_Ogrenci> liste1 = db.Tbl_Ogrenci.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;


            }
            if (radioButton2.Checked == true)
            {
                List<Tbl_Ogrenci> liste2 = db.Tbl_Ogrenci.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
                dataGridView1.DataSource = liste2;
                dataGridView1.DataSource = liste2;


            }
            if (radioButton3.Checked == true)
            {
                List<Tbl_Ogrenci> liste3 = db.Tbl_Ogrenci.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;


            }
            if (radioButton4.Checked == true)
            {
                List<Tbl_Ogrenci> liste4 = db.Tbl_Ogrenci.Where(p => p.ID==5).ToList();
                dataGridView1.DataSource = liste4;


            }
            if (radioButton5.Checked == true)
            {
                //başı a ile başlayan
                List<Tbl_Ogrenci> liste5 = db.Tbl_Ogrenci.Where(p => p.AD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;


            }
            if (radioButton6.Checked == true)
            {
                //sonu a ile biten
                List<Tbl_Ogrenci> liste5 = db.Tbl_Ogrenci.Where(p => p.AD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste5;


            }
            if (radioButton7.Checked == true)
            {
                //değer var mı
                bool deger = db.Tbl_Ogrenci.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);



            }
            if (radioButton8.Checked == true)
            {
                //Öğrenci sayısı
                int toplam = db.Tbl_Ogrenci.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı");


            }
            if (radioButton9.Checked == true)
            {
                //sınav1 toplam deger
                var toplam = db.Tbl_Notlar.Sum(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "Sınav 1 not toplamaı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (radioButton10.Checked == true)
            {
                //sınav1 ortalama bulma
                var toplam = db.Tbl_Notlar.Average(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "Sınav 1 ortalama", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (radioButton11.Checked == true)
            {
                //sınav1 en yüksek sayı
                var toplam = db.Tbl_Notlar.Max(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "En yüksek sayı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (radioButton11.Checked == true)
            {
                //sınav1 en düşük sayı
                var toplam = db.Tbl_Notlar.Min(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "En yüksek sayı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnnotguncelle_Click(object sender, EventArgs e)
        {
            //join ve birleştirme
            var sorgu = from d1 in db.Tbl_Notlar
                        join d2 in db.Tbl_Ogrenci
                        on d1.OGR equals d2.ID

                        join d3 in db.Tbl_Dersler
                        on d1.DERS equals d3.DERSID
                        select new
                        {
                            Öğrenci=d2.AD + " "+ d2.SOYAD,
                            Ders=d3.DERSAD,
                            Sınav1 =d1.SINAV1,
                            Sınav2=d1.SINAV2,
                            Sınav3=d1.SINAV3,
                            Ortalama=d1.ORTALAMA,
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
