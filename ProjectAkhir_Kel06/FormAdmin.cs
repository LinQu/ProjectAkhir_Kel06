using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel06
{
    public partial class FormAdmin : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currchildform;
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public FormAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 49);
            panelView.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(34, 139, 34);//Border color
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void coloReset()
        {
            this.btnKaryawan.BackColor = Color.FromArgb(76, 187, 23);
            this.btnSupplier.BackColor = Color.FromArgb(76, 187, 23);
            this.btnJenisTanaman.BackColor = Color.FromArgb(76, 187, 23);
            this.btnTanaman.BackColor = Color.FromArgb(76, 187, 23);
            this.btnPot.BackColor = Color.FromArgb(76, 187, 23);
            this.btnAlat.BackColor = Color.FromArgb(76, 187, 23);
            this.btnTanah.BackColor = Color.FromArgb(76, 187, 23);
            this.btnPupuk.BackColor = Color.FromArgb(76, 187, 23);
            this.btnDekor.BackColor = Color.FromArgb(76, 187, 23);
        }

        private void openChildForm(Form childform)
        {
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelView.Controls.Add(childform);
            panelView.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            coloReset();
            btnKaryawan.BackColor = Color.FromArgb(34, 139, 34);
            openChildForm(new CRUDKaryawan());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            coloReset();
            currchildform.Close();
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            coloReset();
            btnPot.BackColor = Color.FromArgb(34, 139, 34);
            openChildForm(new CRUDPot());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            coloReset();
            btnSupplier.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnJenisTanaman_Click(object sender, EventArgs e)
        {
            coloReset();
            btnJenisTanaman.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnTanaman_Click(object sender, EventArgs e)
        {
            coloReset();
            btnTanaman.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnAlat_Click(object sender, EventArgs e)
        {
            coloReset();
            btnAlat.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnTanah_Click(object sender, EventArgs e)
        {
            coloReset();
            btnTanah.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnPupuk_Click(object sender, EventArgs e)
        {
            coloReset();
            btnPupuk.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnDekor_Click(object sender, EventArgs e)
        {
            coloReset();
            btnDekor.BackColor = Color.FromArgb(34, 139, 34);
        }
    }
}
