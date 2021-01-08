
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.dbSinavOgrenciDataSet = new Summer_Project.DbSinavOgrenciDataSet();
            this.dbSinavOgrenciDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.btnOgrListele = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlAnasayfa = new System.Windows.Forms.Panel();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.butonDers = new System.Windows.Forms.Button();
            this.butonNot = new System.Windows.Forms.Button();
            this.butonListe = new System.Windows.Forms.Button();
            this.butonAra = new System.Windows.Forms.Button();
            this.boxAra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.evetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnAyarlar
            // 
            resources.ApplyResources(this.btnAyarlar, "btnAyarlar");
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAyarlar.Image = global::Summer_Project.Properties.Resources.settings;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            this.btnAyarlar.Leave += new System.EventHandler(this.btnAyarlar_Leave);
            // 
            // btnOrtalama
            // 
            resources.ApplyResources(this.btnOrtalama, "btnOrtalama");
            this.btnOrtalama.FlatAppearance.BorderSize = 0;
            this.btnOrtalama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOrtalama.Image = global::Summer_Project.Properties.Resources.diagram;
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            this.btnOrtalama.Leave += new System.EventHandler(this.btnOrtalama_Leave);
            // 
            // btnOgrListele
            // 
            resources.ApplyResources(this.btnOgrListele, "btnOgrListele");
            this.btnOgrListele.FlatAppearance.BorderSize = 0;
            this.btnOgrListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOgrListele.Image = global::Summer_Project.Properties.Resources.Conact;
            this.btnOgrListele.Name = "btnOgrListele";
            this.btnOgrListele.UseVisualStyleBackColor = true;
            this.btnOgrListele.Click += new System.EventHandler(this.btnOgrListele_Click);
            this.btnOgrListele.Leave += new System.EventHandler(this.btnOgrListele_Leave);
            // 
            // btnAnasayfa
            // 
            resources.ApplyResources(this.btnAnasayfa, "btnAnasayfa");
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAnasayfa.Image = global::Summer_Project.Properties.Resources.home;
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.Leave += new System.EventHandler(this.btnAnasayfa_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nickname);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // nickname
            // 
            resources.ApplyResources(this.nickname, "nickname");
            this.nickname.BackColor = System.Drawing.Color.White;
            this.nickname.Name = "nickname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Summer_Project.Properties.Resources.Untitled_11;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.pnlNav, "pnlNav");
            this.pnlNav.Name = "pnlNav";
            // 
            // pnlAnasayfa
            // 
            this.pnlAnasayfa.Controls.Add(this.btnOgrenciEkle);
            this.pnlAnasayfa.Controls.Add(this.dataGridView1);
            this.pnlAnasayfa.Controls.Add(this.label2);
            this.pnlAnasayfa.Controls.Add(this.butonDers);
            this.pnlAnasayfa.Controls.Add(this.butonNot);
            this.pnlAnasayfa.Controls.Add(this.butonListe);
            resources.ApplyResources(this.pnlAnasayfa, "pnlAnasayfa");
            this.pnlAnasayfa.Name = "pnlAnasayfa";
            // 
            // btnOgrenciSil
            // 
            resources.ApplyResources(this.btnOgrenciSil, "btnOgrenciSil");
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciEkle
            // 
            resources.ApplyResources(this.btnOgrenciEkle, "btnOgrenciEkle");
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // butonDers
            // 
            resources.ApplyResources(this.butonDers, "butonDers");
            this.butonDers.Name = "butonDers";
            this.butonDers.UseVisualStyleBackColor = true;
            this.butonDers.Click += new System.EventHandler(this.butonDers_Click);
            // 
            // butonNot
            // 
            resources.ApplyResources(this.butonNot, "butonNot");
            this.butonNot.Name = "butonNot";
            this.butonNot.UseVisualStyleBackColor = true;
            this.butonNot.Click += new System.EventHandler(this.butonNot_Click);
            // 
            // butonListe
            // 
            resources.ApplyResources(this.butonListe, "butonListe");
            this.butonListe.Name = "butonListe";
            this.butonListe.UseVisualStyleBackColor = true;
            this.butonListe.Click += new System.EventHandler(this.butonListe_Click);
            // 
            // butonAra
            // 
            resources.ApplyResources(this.butonAra, "butonAra");
            this.butonAra.Name = "butonAra";
            this.butonAra.UseVisualStyleBackColor = true;
            this.butonAra.Click += new System.EventHandler(this.butonAra_Click);
            // 
            // boxAra
            // 
            resources.ApplyResources(this.boxAra, "boxAra");
            this.boxAra.Name = "boxAra";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Summer_Project.Properties.Resources.Dakirby309_Windows_8_Metro_Other_Power_Shut_Down_Metro;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlMove, "pnlMove");
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // evetToolStripMenuItem
            // 
            this.evetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hayırToolStripMenuItem});
            this.evetToolStripMenuItem.Name = "evetToolStripMenuItem";
            resources.ApplyResources(this.evetToolStripMenuItem, "evetToolStripMenuItem");
            // 
            // hayırToolStripMenuItem
            // 
            this.hayırToolStripMenuItem.Name = "hayırToolStripMenuItem";
            resources.ApplyResources(this.hayırToolStripMenuItem, "hayırToolStripMenuItem");
            // 
            // txtDelete
            // 
            resources.ApplyResources(this.txtDelete, "txtDelete");
            this.txtDelete.Name = "txtDelete";
            // 
            // Anasayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.pnlMove);
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
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinavOgrenciDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAnasayfa.ResumeLayout(false);
            this.pnlAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.ToolStripMenuItem evetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayırToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDelete;
    }
}