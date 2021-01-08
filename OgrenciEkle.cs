using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Summer_Project
{
    public partial class OgrenciEkle : Form
    {
        int mov;
        int movX;
        int movY;

        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRONIC;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();


        public OgrenciEkle()
        {
            InitializeComponent();
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void pnlMove2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlMove2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlMove2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI kaydet = new TBLOGRENCI();
            kaydet.AD = txtAdı.Text;
            kaydet.SOYAD = txtSoyad.Text;
            kaydet.SEHIR = txtCity.Text;
            kaydet.FOTOGRAF = txtFoto.Text;
            db.TBLOGRENCI.Add(kaydet);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı");

        }
    }
}
