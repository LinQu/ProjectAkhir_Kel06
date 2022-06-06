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

    public partial class CRUDPot : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);

        public CRUDPot()
        {
            InitializeComponent();
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
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

        public void clear()
        {
            tbID.Clear();
            tbNama.Clear();
            tbHarga.Clear();
            tbStock.Clear();
            tbID.Enabled = false;
            IdOtomatis a = new IdOtomatis();
            string sp = "sp_IdPot";
            a.setID("PT", sp);
            string id = a.getID();
            tbID.Text = id;
            
        }

        public void LoadData()
        {
            tbID.Enabled = false;
            IdOtomatis a = new IdOtomatis();
            string sp = "sp_IdPot";
            a.setID("PT", sp);
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
                    SqlCommand view = new SqlCommand("sp_LoadPot", con);
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
                dataGridView1.Columns[0].HeaderCell.Value = "ID Pot";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama";
                dataGridView1.Columns[2].HeaderCell.Value = "Harga";
                dataGridView1.Columns[3].HeaderCell.Value = "Stock";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void CRUDPot_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbID.Text;
                string nama = tbNama.Text;
                string harga = tbHarga.Text;
                string stock = tbStock.Text;

                 if (id == "" || nama == "" || harga == "" || stock == "" )
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertPot", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_pot", id);
                    insert.Parameters.AddWithValue("nama", nama);
                    insert.Parameters.AddWithValue("harga", harga);
                    insert.Parameters.AddWithValue("stock", stock);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeletePot", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("id_pot", ID);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbID.Text;
                string nama = tbNama.Text;
                float harga = Int32.Parse(tbHarga.Text);
                int stock = Int32.Parse(tbStock.Text);

                if (nama == "" || nama == "" || tbHarga.Text == "" || tbStock.Text == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdatePot", con);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_pot", id);
                    Update.Parameters.AddWithValue("nama", nama);
                    Update.Parameters.AddWithValue("harga", harga);
                    Update.Parameters.AddWithValue("stock", stock);
                    Update.ExecuteNonQuery();
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
                float tempharga = float.Parse(row.Cells[2].Value.ToString());
                tbHarga.Text = tempharga.ToString();
                tbStock.Text = row.Cells[3].Value.ToString();
            }
            }
            catch (Exception ex)
            {
                clear();
                MessageBox.Show("Error" );
                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
