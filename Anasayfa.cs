using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Summer_Project
{

    public partial class Anasayfa : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public Anasayfa()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAnasayfa.Height;
            pnlNav.Top = btnAnasayfa.Top;
            pnlNav.Left = btnAnasayfa.Left;
            btnAnasayfa.BackColor = Color.FromArgb(46, 51, 73);

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRONIC;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public string dataTabloIsim = "ogr";


        private void Anasayfa_Load(object sender, EventArgs e)
        {
            btnOgrListele.Enabled = false;
            btnOrtalama.Enabled = false;
            boxAra.Hide();
            pictureBox2.Hide();

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnAnasayfa.Height;
            pnlNav.Top = btnAnasayfa.Top;
            pnlNav.Left = btnAnasayfa.Left;
            btnAnasayfa.BackColor = Color.FromArgb(46, 51, 73);
            pnlAnasayfa.Show(); // Anasayfa paneli yüklenir
        }

        private void btnOgrListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataTabloIsim = "ogr";
            pnlNav.Height = btnOgrListele.Height;
            pnlNav.Top = btnOgrListele.Top;
            btnOgrListele.BackColor = Color.FromArgb(46, 51, 73);
            //pnlAnasayfa.Hide();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOrtalama.Height;
            pnlNav.Top = btnOrtalama.Top;
            btnOrtalama.BackColor = Color.FromArgb(46,51,73);
            //pnlAnasayfa.Hide();

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAyarlar.Height;
            pnlNav.Top = btnAyarlar.Top;
            btnAyarlar.BackColor = Color.FromArgb(46, 51, 73);
            //pnlAnasayfa.Hide();
        }

        private void btnAnasayfa_Leave(object sender, EventArgs e)
        {
            btnAnasayfa.BackColor = Color.FromArgb(24, 30, 54);

           
        }

        private void btnOgrListele_Leave(object sender, EventArgs e)
        {
            btnOgrListele.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOrtalama_Leave(object sender, EventArgs e)
        {
            btnOrtalama.BackColor = Color.FromArgb(24,30,54);
        }

        private void btnAyarlar_Leave(object sender, EventArgs e)
        {
            btnAyarlar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void butonAra_Click(object sender, EventArgs e)
        {
            boxAra.Show();
            pictureBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            boxAra.Hide();
            pictureBox2.Hide();
        }

        private void butonListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataTabloIsim = "ogr";
        }

        private void butonDers_Click(object sender, EventArgs e)
        {

        }
    }
}
