using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; // SQL Connection
using System.Data.SqlClient; // SQL Connection
using Tulpep.NotificationWindow;

namespace Summer_Project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public SqlConnection con; 
        public SqlCommand cmd;
        public SqlDataReader dr;

        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRONIC;Initial Catalog=DbSinavOgrenci;Integrated Security=True");


        public void Admin_Load(object sender, EventArgs e)
        {
            Username.Text = Properties.Settings.Default["Username"].ToString();
            Password.Text = Properties.Settings.Default["Password"].ToString();

            if (Username.Text.Count() > 1)
            {
                checkHatirla.Checked = true;
            }
            else
            {
                checkHatirla.Checked = false;
            }
        }

        private void girisYap()
        {
            string user = Username.Text;
            string pass = Password.Text;
            con = new SqlConnection(@"Data Source=EXTRONIC;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM AdminLogins where Username='" + Username.Text + "' AND Password='" + Password.Text + "'";
            dr = cmd.ExecuteReader();

            if (checkHatirla.Checked)
            {
                Properties.Settings.Default["Username"] = Username.Text;
                Properties.Settings.Default["Password"] = Password.Text;
            }
            else
            {
                Properties.Settings.Default["Username"] = "";
                Properties.Settings.Default["Password"] = "";
            }
            Properties.Settings.Default.Save();



            if (dr.Read())
            {
                MessageBox.Show("Giriş işlemi başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Giriş yapılıyor...";
                System.Threading.Thread.Sleep(2000);
                popup.ContentText = "Giriş yapıldı";
                popup.Popup(); //SHOW
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            girisYap();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
