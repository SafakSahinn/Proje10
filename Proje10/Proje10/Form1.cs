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

namespace Proje10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=Test;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HAREKETID, URUNAD AS 'ÜRÜN AD', (AD + ' ' + SOYAD) AS 'MÜŞTERİ', ADSOYAD AS 'PERSONEL', TBLHAREKET.FIYAT AS 'FİYAT' FROM TBLHAREKET INNER JOIN TBLURUNLER ON TBLHAREKET.URUN = TBLURUNLER.URUNID INNER JOIN TBLMUSTERI ON TBLHAREKET.MUSTERI = TBLMUSTERI.ID INNER JOIN TBLPERSONEL ON TBLHAREKET.PERSONEL = TBLPERSONEL.ID",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
