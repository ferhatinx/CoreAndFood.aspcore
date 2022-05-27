using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySonKisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var sorgu = db.Tbl_Ogrenci.OrderBy(x => x.SEHIR).GroupBy(y => y.SEHIR).Select(z =>
            //new
            //{
            //    Sehir = z.Key,
            //    Toplam = z.Count()

            //});
            //dataGridView1.DataSource = sorgu.ToList();

            label1.Text = db.Tbl_Notlar.Max(p => p.ORTALAMA).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var SONUC = db.Tbl_Notlar.Where(x => x.DURUM == false).OrderByDescending(y => y.ORTALAMA).Take(1).Select(z => new
            {
                Ogrenci = z.OGR,
                Ortalama = z.ORTALAMA,
                Durum = z.DURUM
            });
            dataGridView1.DataSource = SONUC.ToList();
        }
    }
}
