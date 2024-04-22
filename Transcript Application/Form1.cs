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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
       
        
        

        private void eklebtn_Click(object sender, EventArgs e)
        {
            ekle frm1 = new ekle();
            frm1.Show();
        }

        private void güncellebtn_Click(object sender, EventArgs e)
        {
            güncelle frm2 = new güncelle();
            frm2.Show();
            MessageBox.Show("Güncelleme işlemi yapabilmek için tüm kutuları doldurmanız gerekmektedir. Eğer değişim olmayacaksa bile eski değeri yazmanız gerekmektedir.");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            sil frm3 = new sil();
            frm3.Show();
        }

        private void transbtn_Click(object sender, EventArgs e)
        {
            transkript frm4 = new transkript();
            frm4.Show();
        }
    }
}
