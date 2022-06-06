
namespace ProjectAkhir_Kel06
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnSupplier = new FontAwesome.Sharp.IconButton();
            this.btnJenisTanaman = new FontAwesome.Sharp.IconButton();
            this.btnTanaman = new FontAwesome.Sharp.IconButton();
            this.btnPot = new FontAwesome.Sharp.IconButton();
            this.btnAlat = new FontAwesome.Sharp.IconButton();
            this.btnTanah = new FontAwesome.Sharp.IconButton();
            this.btnPupuk = new FontAwesome.Sharp.IconButton();
            this.btnDekor = new FontAwesome.Sharp.IconButton();
            this.btnKaryawan = new FontAwesome.Sharp.IconButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 116);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.btnKaryawan);
            this.panel2.Controls.Add(this.btnDekor);
            this.panel2.Controls.Add(this.btnPupuk);
            this.panel2.Controls.Add(this.btnTanah);
            this.panel2.Controls.Add(this.btnAlat);
            this.panel2.Controls.Add(this.btnPot);
            this.panel2.Controls.Add(this.btnTanaman);
            this.panel2.Controls.Add(this.btnJenisTanaman);
            this.panel2.Controls.Add(this.btnSupplier);
            this.panel2.Location = new System.Drawing.Point(-1, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 620);
            this.panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 89;
            this.iconPictureBox1.Location = new System.Drawing.Point(4, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(97, 89);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(133, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 15);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "ADMIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(795, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(209, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 43);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.btnLogout.IconColor = System.Drawing.Color.Transparent;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(262, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(33, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnSupplier.IconColor = System.Drawing.Color.White;
            this.btnSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupplier.IconSize = 43;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 24);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(198, 54);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "SUPPLIER";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnJenisTanaman
            // 
            this.btnJenisTanaman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnJenisTanaman.FlatAppearance.BorderSize = 0;
            this.btnJenisTanaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenisTanaman.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisTanaman.ForeColor = System.Drawing.Color.White;
            this.btnJenisTanaman.IconChar = FontAwesome.Sharp.IconChar.Leaf;
            this.btnJenisTanaman.IconColor = System.Drawing.Color.White;
            this.btnJenisTanaman.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJenisTanaman.IconSize = 43;
            this.btnJenisTanaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisTanaman.Location = new System.Drawing.Point(0, 84);
            this.btnJenisTanaman.Name = "btnJenisTanaman";
            this.btnJenisTanaman.Size = new System.Drawing.Size(197, 54);
            this.btnJenisTanaman.TabIndex = 1;
            this.btnJenisTanaman.Text = "           JENIS TANAMAN";
            this.btnJenisTanaman.UseVisualStyleBackColor = true;
            this.btnJenisTanaman.Click += new System.EventHandler(this.btnJenisTanaman_Click);
            // 
            // btnTanaman
            // 
            this.btnTanaman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTanaman.FlatAppearance.BorderSize = 0;
            this.btnTanaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanaman.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanaman.ForeColor = System.Drawing.Color.White;
            this.btnTanaman.IconChar = FontAwesome.Sharp.IconChar.Tree;
            this.btnTanaman.IconColor = System.Drawing.Color.White;
            this.btnTanaman.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTanaman.IconSize = 43;
            this.btnTanaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanaman.Location = new System.Drawing.Point(0, 144);
            this.btnTanaman.Name = "btnTanaman";
            this.btnTanaman.Size = new System.Drawing.Size(198, 54);
            this.btnTanaman.TabIndex = 2;
            this.btnTanaman.Text = "TANAMAN";
            this.btnTanaman.UseVisualStyleBackColor = true;
            this.btnTanaman.Click += new System.EventHandler(this.btnTanaman_Click);
            // 
            // btnPot
            // 
            this.btnPot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPot.FlatAppearance.BorderSize = 0;
            this.btnPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPot.ForeColor = System.Drawing.Color.White;
            this.btnPot.IconChar = FontAwesome.Sharp.IconChar.Pallet;
            this.btnPot.IconColor = System.Drawing.Color.White;
            this.btnPot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPot.IconSize = 43;
            this.btnPot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPot.Location = new System.Drawing.Point(2, 204);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(196, 54);
            this.btnPot.TabIndex = 3;
            this.btnPot.Text = "POT          ";
            this.btnPot.UseVisualStyleBackColor = true;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // btnAlat
            // 
            this.btnAlat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAlat.FlatAppearance.BorderSize = 0;
            this.btnAlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlat.ForeColor = System.Drawing.Color.White;
            this.btnAlat.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnAlat.IconColor = System.Drawing.Color.White;
            this.btnAlat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlat.IconSize = 43;
            this.btnAlat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlat.Location = new System.Drawing.Point(3, 264);
            this.btnAlat.Name = "btnAlat";
            this.btnAlat.Size = new System.Drawing.Size(195, 54);
            this.btnAlat.TabIndex = 2;
            this.btnAlat.Text = "    PERALATAN";
            this.btnAlat.UseVisualStyleBackColor = true;
            this.btnAlat.Click += new System.EventHandler(this.btnAlat_Click);
            // 
            // btnTanah
            // 
            this.btnTanah.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTanah.FlatAppearance.BorderSize = 0;
            this.btnTanah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanah.ForeColor = System.Drawing.Color.White;
            this.btnTanah.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnTanah.IconColor = System.Drawing.Color.White;
            this.btnTanah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTanah.IconSize = 43;
            this.btnTanah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanah.Location = new System.Drawing.Point(4, 324);
            this.btnTanah.Name = "btnTanah";
            this.btnTanah.Size = new System.Drawing.Size(194, 54);
            this.btnTanah.TabIndex = 4;
            this.btnTanah.Text = "              TANAH";
            this.btnTanah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanah.UseVisualStyleBackColor = true;
            this.btnTanah.Click += new System.EventHandler(this.btnTanah_Click);
            // 
            // btnPupuk
            // 
            this.btnPupuk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPupuk.FlatAppearance.BorderSize = 0;
            this.btnPupuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPupuk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPupuk.ForeColor = System.Drawing.Color.White;
            this.btnPupuk.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnPupuk.IconColor = System.Drawing.Color.White;
            this.btnPupuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPupuk.IconSize = 43;
            this.btnPupuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPupuk.Location = new System.Drawing.Point(3, 384);
            this.btnPupuk.Name = "btnPupuk";
            this.btnPupuk.Size = new System.Drawing.Size(194, 54);
            this.btnPupuk.TabIndex = 2;
            this.btnPupuk.Text = "               PUPUK";
            this.btnPupuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPupuk.UseVisualStyleBackColor = true;
            this.btnPupuk.Click += new System.EventHandler(this.btnPupuk_Click);
            // 
            // btnDekor
            // 
            this.btnDekor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDekor.FlatAppearance.BorderSize = 0;
            this.btnDekor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDekor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekor.ForeColor = System.Drawing.Color.White;
            this.btnDekor.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnDekor.IconColor = System.Drawing.Color.White;
            this.btnDekor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDekor.IconSize = 43;
            this.btnDekor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDekor.Location = new System.Drawing.Point(2, 444);
            this.btnDekor.Name = "btnDekor";
            this.btnDekor.Size = new System.Drawing.Size(196, 54);
            this.btnDekor.TabIndex = 2;
            this.btnDekor.Text = "               DEKOR";
            this.btnDekor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDekor.UseVisualStyleBackColor = true;
            this.btnDekor.Click += new System.EventHandler(this.btnDekor_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKaryawan.FlatAppearance.BorderSize = 0;
            this.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaryawan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnKaryawan.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnKaryawan.IconColor = System.Drawing.Color.White;
            this.btnKaryawan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaryawan.IconSize = 43;
            this.btnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaryawan.Location = new System.Drawing.Point(4, 504);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(194, 54);
            this.btnKaryawan.TabIndex = 2;
            this.btnKaryawan.Text = "    KARYAWAN";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // panelView
            // 
            this.panelView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelView.BackColor = System.Drawing.Color.ForestGreen;
            this.panelView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelView.BackgroundImage")));
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelView.Location = new System.Drawing.Point(197, 121);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(785, 449);
            this.panelView.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 35;
            this.btnMinimize.Location = new System.Drawing.Point(957, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 28);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 35;
            this.btnClose.Location = new System.Drawing.Point(995, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panel2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private FontAwesome.Sharp.IconButton btnKaryawan;
        private FontAwesome.Sharp.IconButton btnDekor;
        private FontAwesome.Sharp.IconButton btnPupuk;
        private FontAwesome.Sharp.IconButton btnTanah;
        private FontAwesome.Sharp.IconButton btnAlat;
        private FontAwesome.Sharp.IconButton btnPot;
        private FontAwesome.Sharp.IconButton btnTanaman;
        private FontAwesome.Sharp.IconButton btnJenisTanaman;
        private FontAwesome.Sharp.IconButton btnSupplier;
        private System.Windows.Forms.Panel panelView;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}