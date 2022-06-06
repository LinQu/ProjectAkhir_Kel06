using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel06
{
    public partial class CRUDKaryawan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDKaryawan()
        {
            InitializeComponent();
        }
        public void clear()
        {
            IdOtomatis a = new IdOtomatis();
            string sp = "sp_IdKar";
            a.setID("KR", sp);
            string id = a.getID();
            tbID.Text = id;
            tbNama.Clear();
            tbNoTelp.Clear();
            tbAlamat.Clear();
            tbUser.Clear();
            tbPass.Clear();
            cbPerempuan.Checked = false;
            cbLaki.Checked = false;
        }

        public void LoadData()
        {
            IdOtomatis a = new IdOtomatis();
            string sp = "sp_IdKar";
            a.setID("KR", sp);
            string id = a.getID();
            tbID.Text = id;
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                clear();
                con.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadKar", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].HeaderCell.Value = "ID Karyawan";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama";
                dataGridView1.Columns[2].HeaderCell.Value = "Jenis Kelamin";
                dataGridView1.Columns[3].HeaderCell.Value = "No Handphone";
                dataGridView1.Columns[4].HeaderCell.Value = "Alamat";
                dataGridView1.Columns[5].HeaderCell.Value = "Username";
                dataGridView1.Columns[6].HeaderCell.Value = "Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void cbLaki_OnChange(object sender, EventArgs e)
        {
            cbLaki.Checked = true;
            cbPerempuan.Checked = false;

        }

        private void cbPerempuan_OnChange(object sender, EventArgs e)
        {
            cbPerempuan.Checked = true;
            cbLaki.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            tbID.Enabled = false;
            cbPerempuan.Checked = false;
            cbLaki.Checked = false;
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            clear();
            LoadData();


        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbID.Text;
                string nama = tbNama.Text;
                string jenkil = "";
                if (cbLaki.Checked)
                {
                    jenkil = "Laki Laki";
                }
                else
                {
                    jenkil = "Perempuan";
                }
                string NoTelp = tbNoTelp.Text;
                string alamat = tbAlamat.Text;
                string user = tbUser.Text;
                string pass = tbPass.Text;

                if (nama == "" || NoTelp == "" || jenkil == "" || alamat == "" || user == "" || pass == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (NoTelp.Length > 13 || NoTelp.Length < 8)
                {
                    MessageBox.Show("Panjang digit no telepon anda tidak memenuhi standar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNoTelp.Text = "";
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertKaryawan", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_karyawan", id);
                    insert.Parameters.AddWithValue("nama", nama);
                    insert.Parameters.AddWithValue("jenis_kelamin", jenkil);
                    insert.Parameters.AddWithValue("noTelp", NoTelp);
                    insert.Parameters.AddWithValue("alamat", alamat);
                    insert.Parameters.AddWithValue("username", user);
                    insert.Parameters.AddWithValue("password", pass);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil disimpan dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                string id = tbID.Text;
                string nama = tbNama.Text;
                string jenkil = "";
                if (cbLaki.Checked)
                {
                    jenkil = "Laki Laki";
                }
                else
                {
                    jenkil = "Perempuan";
                }
                string NoTelp = tbNoTelp.Text;
                string alamat = tbAlamat.Text;
                string user = tbUser.Text;
                string pass = tbPass.Text;

                if (NoTelp.Length > 13 || NoTelp.Length < 8)
                {
                    MessageBox.Show("Panjang digit no telepon anda tidak memenuhi standar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNoTelp.Text = "";
                }
                else if (nama == "" || NoTelp == "" || jenkil == "" || alamat == "" || user == "" || pass == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand update = new SqlCommand("sp_UpdateKaryawan", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_karyawan", id);
                    update.Parameters.AddWithValue("nama", nama);
                    update.Parameters.AddWithValue("jenis_kelamin", jenkil);
                    update.Parameters.AddWithValue("noTelp", NoTelp);
                    update.Parameters.AddWithValue("alamat", alamat);
                    update.Parameters.AddWithValue("username", user);
                    update.Parameters.AddWithValue("password", pass);
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil diupdate dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteKaryawan", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_karyawan", ID);
                try
                {
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = txtCari.Text;
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariKaryawan", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("id_karyawan", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dataGridView1.DataSource = bindingSource1;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dataGridView1.Columns[0].HeaderCell.Value = "ID Karyawan";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama";
                dataGridView1.Columns[2].HeaderCell.Value = "Jenis Kelamin";
                dataGridView1.Columns[3].HeaderCell.Value = "No Handphone";
                dataGridView1.Columns[4].HeaderCell.Value = "Alamat";
                dataGridView1.Columns[5].HeaderCell.Value = "Username";
                dataGridView1.Columns[6].HeaderCell.Value = "Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    //transfer ke textbox
                    tbID.Text = row.Cells[0].Value.ToString();
                    tbNama.Text = row.Cells[1].Value.ToString();
                    string jenkil = row.Cells[2].Value.ToString(); ;
                    if (jenkil == "Laki Laki")
                    {
                        cbLaki.Checked = true;
                        cbPerempuan.Checked = false;
                    }
                    else
                    {
                        cbPerempuan.Checked = true;
                        cbLaki.Checked = false;
                    }
                    tbNoTelp.Text = row.Cells[3].Value.ToString();
                    tbAlamat.Text = row.Cells[4].Value.ToString();
                    tbUser.Text = row.Cells[5].Value.ToString();
                    tbPass.Text = row.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                clear();
            }
        }
    }
}
