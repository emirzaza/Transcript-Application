using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database1_0
{
    public partial class güncelle : Form
    {
        public güncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");

        public void tablogoster(string txt)
        {

            baglantı.Open();

            NpgsqlCommand komut = new NpgsqlCommand();

            komut.Connection = baglantı;

            komut.CommandType = CommandType.Text;

            komut.CommandText = txt;

            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                güncelledata.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tablogoster("select * from ders");
        }

        private void dersigüncellebtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = baglantı;

            komut_guncelle.Parameters.AddWithValue("@hangi_kod", hangiidtxt.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_kodu", derskodutxt.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_adı", dersaditxt.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_kredi", Convert.ToInt32(derskreditxt.Text));
            komut_guncelle.Parameters.AddWithValue("@ders_akts", Convert.ToInt32(dersaktstxt.Text));
            komut_guncelle.Parameters.AddWithValue("@ders_notu", dersnottxt.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_dönem", dersdönemtxt.Text);
            komut_guncelle.Parameters.AddWithValue("@dersi_veren_Öğretim_Üyesi", hocatxt.Text);

            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update ders set ders_kodu=@ders_kodu, ders_adı=@ders_adı, ders_kredi=@ders_kredi, ders_akts=@ders_akts, ders_notu=@ders_notu, ders_dönem=@ders_dönem, dersi_veren_Öğretim_Üyesi=@dersi_veren_Öğretim_Üyesi WHERE ders_kodu=@hangi_kod ";


            NpgsqlDataReader dr = komut_guncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                güncelledata.DataSource = dt;
            }
            komut_guncelle.Dispose();
            baglantı.Close();

            tablogoster("select * from ders");

            MessageBox.Show("güncelleme basarılı");

        }

        private void çıkışgüncellebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
