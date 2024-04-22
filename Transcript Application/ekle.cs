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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        int Ders= 15;

        NpgsqlConnection baglantı = new NpgsqlConnection("Server=localhost; Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");

        private void ekle_Load(object sender, EventArgs e)
        {

        }

        private void derseklebtn_Click(object sender, EventArgs e)
        {
            

            baglantı.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglantı;

            komut_ekle.Parameters.AddWithValue("@ders_kodu",derskodutxt.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adı",dersaditxt.Text);
            komut_ekle.Parameters.AddWithValue("@ders_kredi", Convert.ToInt32(derskreditxt.Text));
            komut_ekle.Parameters.AddWithValue("@ders_akts", Convert.ToInt32(dersaktstxt.Text));
            komut_ekle.Parameters.AddWithValue("@ders_notu", dersnottxt.Text);
            komut_ekle.Parameters.AddWithValue("@ders_dönem", dersdönemtxt.Text);
            komut_ekle.Parameters.AddWithValue("@dersi_veren_Öğretim_Üyesi", hocatxt.Text);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders (ders_kodu, ders_adı, ders_kredi, ders_akts, ders_notu, ders_dönem, dersi_veren_Öğretim_Üyesi) values (@ders_kodu, @ders_adı, @ders_kredi, @ders_akts, @ders_notu, @ders_dönem, @dersi_veren_Öğretim_Üyesi)";
            _ = komut_ekle.ExecuteReader();

            komut_ekle.Dispose();
            baglantı.Close();

            MessageBox.Show("ekleme basarılı");

            Ders++;
        }

        private void cikiseklebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
