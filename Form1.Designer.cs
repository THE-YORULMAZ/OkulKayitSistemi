
namespace OkulKayıtSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnogrnc = new System.Windows.Forms.Button();
            this.btnogretmen = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(390, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 499);
            this.panel1.TabIndex = 1;
            // 
            // btnogrnc
            // 
            this.btnogrnc.BackColor = System.Drawing.Color.White;
            this.btnogrnc.FlatAppearance.BorderSize = 0;
            this.btnogrnc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnogrnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogrnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrnc.Location = new System.Drawing.Point(109, 276);
            this.btnogrnc.Name = "btnogrnc";
            this.btnogrnc.Size = new System.Drawing.Size(152, 77);
            this.btnogrnc.TabIndex = 2;
            this.btnogrnc.Text = "ÖĞRENCİ GİRİŞİ";
            this.btnogrnc.UseVisualStyleBackColor = false;
            this.btnogrnc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnogretmen
            // 
            this.btnogretmen.BackColor = System.Drawing.Color.White;
            this.btnogretmen.FlatAppearance.BorderSize = 0;
            this.btnogretmen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnogretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogretmen.Location = new System.Drawing.Point(524, 275);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(152, 78);
            this.btnogretmen.TabIndex = 3;
            this.btnogretmen.Text = "ÖĞRETMEN GİRİŞİ";
            this.btnogretmen.UseVisualStyleBackColor = false;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.White;
            this.btncreate.FlatAppearance.BorderSize = 0;
            this.btncreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncreate.Location = new System.Drawing.Point(524, 378);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(152, 78);
            this.btncreate.TabIndex = 7;
            this.btncreate.Text = "ÜYE OL";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(109, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "ÜYE OL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OkulKayıtSistemi.Properties.Resources._35093_graduated_400x400;
            this.pictureBox2.Location = new System.Drawing.Point(109, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OkulKayıtSistemi.Properties.Resources.faculty;
            this.pictureBox1.Location = new System.Drawing.Point(524, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.btnogrnc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OKUL KAYIT SİSTEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnogrnc;
        private System.Windows.Forms.Button btnogretmen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button button1;
    }
}

