
namespace Summer_Project
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dbSinavOgrenciDataSet = new Summer_Project.DbSinavOgrenciDataSet();
            this.dbSinavOgrenciDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlAnasayfa = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.butonListe = new System.Windows.Forms.Button();
            this.butonDers = new System.Windows.Forms.Button();
            this.butonNot = new System.Windows.Forms.Button();
            this.butonAra = new System.Windows.Forms.Button();
            this.boxAra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.btnOgrListele = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSinavOgrenciDataSet
            // 
            this.dbSinavOgrenciDataSet.DataSetName = "DbSinavOgrenciDataSet";
            this.dbSinavOgrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSinavOgrenciDataSetBindingSource
            // 
            this.dbSinavOgrenciDataSetBindingSource.DataSource = this.dbSinavOgrenciDataSet;
            this.dbSinavOgrenciDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnOrtalama);
            this.panel1.Controls.Add(this.btnOgrListele);
            this.panel1.Controls.Add(this.btnAnasayfa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nickname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.BackColor = System.Drawing.Color.White;
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickname.Location = new System.Drawing.Point(45, 97);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(98, 18);
            this.nickname.TabIndex = 2;
            this.nickname.Text = "Samet Salih";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlAnasayfa
            // 
            this.pnlAnasayfa.Controls.Add(this.listView1);
            this.pnlAnasayfa.Controls.Add(this.dataGridView1);
            this.pnlAnasayfa.Controls.Add(this.label2);
            this.pnlAnasayfa.Controls.Add(this.butonDers);
            this.pnlAnasayfa.Controls.Add(this.butonNot);
            this.pnlAnasayfa.Controls.Add(this.butonListe);
            this.pnlAnasayfa.Location = new System.Drawing.Point(224, 22);
            this.pnlAnasayfa.Name = "pnlAnasayfa";
            this.pnlAnasayfa.Size = new System.Drawing.Size(676, 432);
            this.pnlAnasayfa.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Burası Ana sayfa";
            // 
            // butonListe
            // 
            this.butonListe.Location = new System.Drawing.Point(31, 283);
            this.butonListe.Name = "butonListe";
            this.butonListe.Size = new System.Drawing.Size(75, 52);
            this.butonListe.TabIndex = 3;
            this.butonListe.Text = "Öğrenci Listesi";
            this.butonListe.UseVisualStyleBackColor = true;
            this.butonListe.Click += new System.EventHandler(this.butonListe_Click);
            // 
            // butonDers
            // 
            this.butonDers.Location = new System.Drawing.Point(112, 283);
            this.butonDers.Name = "butonDers";
            this.butonDers.Size = new System.Drawing.Size(75, 52);
            this.butonDers.TabIndex = 4;
            this.butonDers.Text = "Ders Listesi";
            this.butonDers.UseVisualStyleBackColor = true;
            this.butonDers.Click += new System.EventHandler(this.butonDers_Click);
            // 
            // butonNot
            // 
            this.butonNot.Location = new System.Drawing.Point(193, 283);
            this.butonNot.Name = "butonNot";
            this.butonNot.Size = new System.Drawing.Size(75, 52);
            this.butonNot.TabIndex = 5;
            this.butonNot.Text = "Not Listesi";
            this.butonNot.UseVisualStyleBackColor = true;
            // 
            // butonAra
            // 
            this.butonAra.Location = new System.Drawing.Point(664, 471);
            this.butonAra.Name = "butonAra";
            this.butonAra.Size = new System.Drawing.Size(75, 20);
            this.butonAra.TabIndex = 6;
            this.butonAra.Text = "Ara";
            this.butonAra.UseVisualStyleBackColor = true;
            this.butonAra.Click += new System.EventHandler(this.butonAra_Click);
            // 
            // boxAra
            // 
            this.boxAra.Location = new System.Drawing.Point(745, 471);
            this.boxAra.Name = "boxAra";
            this.boxAra.Size = new System.Drawing.Size(155, 20);
            this.boxAra.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Summer_Project.Properties.Resources.Dakirby309_Windows_8_Metro_Other_Power_Shut_Down_Metro;
            this.pictureBox2.Location = new System.Drawing.Point(904, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAyarlar.Image = global::Summer_Project.Properties.Resources.settings;
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 512);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(178, 42);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            this.btnAyarlar.Leave += new System.EventHandler(this.btnAyarlar_Leave);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrtalama.FlatAppearance.BorderSize = 0;
            this.btnOrtalama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrtalama.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrtalama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOrtalama.Image = global::Summer_Project.Properties.Resources.diagram;
            this.btnOrtalama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrtalama.Location = new System.Drawing.Point(0, 228);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(178, 42);
            this.btnOrtalama.TabIndex = 3;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            this.btnOrtalama.Leave += new System.EventHandler(this.btnOrtalama_Leave);
            // 
            // btnOgrListele
            // 
            this.btnOgrListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOgrListele.FlatAppearance.BorderSize = 0;
            this.btnOgrListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrListele.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOgrListele.Image = global::Summer_Project.Properties.Resources.Conact;
            this.btnOgrListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrListele.Location = new System.Drawing.Point(0, 186);
            this.btnOgrListele.Name = "btnOgrListele";
            this.btnOgrListele.Size = new System.Drawing.Size(178, 42);
            this.btnOgrListele.TabIndex = 2;
            this.btnOgrListele.Text = "Öğrenci Listesi";
            this.btnOgrListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgrListele.UseVisualStyleBackColor = true;
            this.btnOgrListele.Click += new System.EventHandler(this.btnOgrListele_Click);
            this.btnOgrListele.Leave += new System.EventHandler(this.btnOgrListele_Leave);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAnasayfa.Image = global::Summer_Project.Properties.Resources.home;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 144);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(178, 42);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.Leave += new System.EventHandler(this.btnAnasayfa_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Summer_Project.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 229);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(952, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.boxAra);
            this.Controls.Add(this.butonAra);
            this.Controls.Add(this.pnlAnasayfa);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAnasayfa.ResumeLayout(false);
            this.pnlAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbSinavOgrenciDataSet dbSinavOgrenciDataSet;
        private System.Windows.Forms.BindingSource dbSinavOgrenciDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Button btnOgrListele;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlAnasayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butonListe;
        private System.Windows.Forms.Button butonDers;
        private System.Windows.Forms.Button butonNot;
        private System.Windows.Forms.Button butonAra;
        private System.Windows.Forms.TextBox boxAra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
    }
}