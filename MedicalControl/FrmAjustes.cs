using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicalControl
{
    public partial class FrmAjustes : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmAjustes()
        {
            InitializeComponent();
        }

        private void FrmAjustes_Load(object sender, EventArgs e)
        {
            CARGARCOMBOXPROVEEDOR();
            CARGARCOMBOXALERGIA();
            CARGARCOMBOXDOCTOR();
            CARGARCOMBOXSEGURO();
            
        }

        public void CARGARCOMBOXPROVEEDOR()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_PROVEEDOR", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbproveedor.ValueMember = "idt_proveedor";
            cbproveedor.DisplayMember = "NombreProveedor";
            cbproveedor.DataSource = dt;
        }

        public void CARGARCOMBOXALERGIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_ALERGIA", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAlergia.ValueMember = "IDALERGIA";
            cmbAlergia.DisplayMember = "NombreA";
            cmbAlergia.DataSource = dt;
        }

        public void CARGARCOMBOXSEGURO()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM t_segurom", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSeguro.ValueMember = "IDSEGURO";
            cmbSeguro.DisplayMember = "NombreSeguro";
            cmbSeguro.DataSource = dt;
        }


        public void CARGARCOMBOXDOCTOR()
        {

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_Doctor", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDoctor.ValueMember = "IDDOCTOR";
            cmbDoctor.DisplayMember = "NombreDoctor";
            cmbDoctor.DataSource = dt;
            
        }

        
    }
}
