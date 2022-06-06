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
    public partial class CRUDDekor : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);

        public CRUDDekor()
        {
            InitializeComponent();
        }

        private void CRUDDekor_Load(object sender, EventArgs e)
        {

        }
    }
}
