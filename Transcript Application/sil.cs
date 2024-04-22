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
    public partial class sil : Form
    {
        public sil()
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
                sildata.DataSource = dt;
            }
            komut.Dispose();
            baglantı.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sil_Load(object sender, EventArgs e)
        {

        }

        private void silgöster_Click(object sender, EventArgs e)
        {
            tablogoster("select * from ders");
        }

        private void dersisilbtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = baglantı;
            komut_sil.Parameters.AddWithValue("@hangi_kod", silinecekid.Text);

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from ders where ders_kodu = @hangi_kod";

            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                sildata.DataSource = dt;
            }
            komut_sil.Dispose();
            baglantı.Close();

            tablogoster("select * from ders");

            MessageBox.Show("Silme İşlemi basarılı");
        }

        private void çıkışsilbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


