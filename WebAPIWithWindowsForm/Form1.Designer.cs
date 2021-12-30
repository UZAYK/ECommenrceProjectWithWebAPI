namespace WebAPIWithWindowsForm
{
    partial class kullanici
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.Label();
            this.dogumTarihi = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(48, 61);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(76, 15);
            this.kullaniciAdi.TabIndex = 0;
            this.kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 54);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 203);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(560, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(61, 110);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(28, 15);
            this.adi.TabIndex = 4;
            this.adi.Text = "Adı:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 159);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(61, 167);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(45, 15);
            this.soyad.TabIndex = 6;
            this.soyad.Text = "Soyadı:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(61, 222);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(30, 15);
            this.sifre.TabIndex = 8;
            this.sifre.Text = "Şifre";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(582, 54);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(248, 23);
            this.dtpDateOfBirth.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(582, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(511, 166);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 15);
            this.email.TabIndex = 12;
            this.email.Text = "E-mail";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(582, 217);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 23);
            this.txtAddress.TabIndex = 15;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(515, 222);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(37, 15);
            this.adres.TabIndex = 14;
            this.adres.Text = "Adres";
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.AutoSize = true;
            this.dogumTarihi.Location = new System.Drawing.Point(471, 60);
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.Size = new System.Drawing.Size(81, 15);
            this.dogumTarihi.TabIndex = 16;
            this.dogumTarihi.Text = "Dogum Tarihi:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbGender.Location = new System.Drawing.Point(582, 102);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(248, 23);
            this.cmbGender.TabIndex = 18;
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.Location = new System.Drawing.Point(500, 106);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(52, 15);
            this.cinsiyet.TabIndex = 19;
            this.cinsiyet.Text = "Cinsiyet:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(657, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 57);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(754, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 57);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 604);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dogumTarihi);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.kullaniciAdi);
            this.Name = "kullanici";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label dogumTarihi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}
