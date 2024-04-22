using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;


namespace database1_0
{
    public partial class transkript : Form
    {
        public transkript()
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
                transkriptdata.DataSource = dt;

               
            }


            komut.Dispose();
            baglantı.Close();
        }
        double toplam = 0;
        double kreditoplam = 0;
        public void harf2sayi(string txt, string text)
        {

            string gradelet = txt;
            double gradenum = 0;
            string kredinum = text;

            if (gradelet == "AA")
            {
                gradenum = 4;
                
            }


            if (gradelet == "BA")
            {
                gradenum =3.5;
                
            }


            if (gradelet == "BB")
            {
                gradenum = 3;
                
            }

            if (gradelet == "CB")
            {
                gradenum = 2.5;
                
            }

            if (gradelet == "CC")
            {
                gradenum = 2;
                
            }

            if (gradelet == "DC")
            {
                gradenum = 1.5;
                
            }

            if (gradelet == "DD")
            {
                gradenum = 1;
                
            }

            if (gradelet == "FD")
            {
                gradenum = 0.5;
                
            }
            kreditoplam += Convert.ToDouble(kredinum);
            toplam += Convert.ToDouble(kredinum) * gradenum;
        }
        public void Ganohesapla(string txt)
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
                

                int i;


                for (i = 0; i < dt.Rows.Count; i++)
                {

                    dt.Rows[i].ItemArray[1].ToString();

                    harf2sayi(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString());

                   
                   
                }

                ganotxt.Text = (toplam / kreditoplam).ToString();

                komut.Dispose();
                baglantı.Close();


            }

        }

            private void göstertransbtn_Click(object sender, EventArgs e)
            {
                tablogoster("select * from ders where ders_notu!= '' ");

                Ganohesapla("select ders_notu,ders_kredi from ders where ders_notu!= '' ");


            }


            private void çıkıştransbtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    } 
