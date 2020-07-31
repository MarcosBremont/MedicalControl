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
            selectDoctor();

        }

        public void selectDoctor()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM T_DOCTOR WHERE IDDOCTOR=@IDDOCTOR", con);
            cmd.Parameters.AddWithValue("@IDDOCTOR", txtDoctor.Text);
            con.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                txtexpecialidad.Text = registro["Especialidad"].ToString();
            }
            con.Close();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM T_Doctor Where IDDOCTOR = @IDDOCTOR";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDDOCTOR", cmbDoctor.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("DOCTOR Eliminado");
            con.Close();
            CARGARCOMBOXDOCTOR();
        }

        private void BtnEliminarAlergia_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
            string query = "DELETE FROM T_Alergia Where IDALERGIA = @IDALERGIA";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDALERGIA", cmbAlergia.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Alergia Eliminada");
            con.Close();
            CARGARCOMBOXALERGIA();

            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique las citas y pacientes que hay registrados con esa Alergia");
            }
        }

        private void BtnEliminarSeguros_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
            string query = "DELETE FROM T_SeguroM Where IDSEGURO = @IDSEGURO";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDSEGURO", cmbAlergia.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Seguro Eliminada");
            con.Close();
            CARGARCOMBOXSEGURO();

            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique las citas y pacientes que hay registrados con ese seguro medico");
            }
        }

        private void BtnEliminarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM t_proveedor Where idt_proveedor = @idt_proveedor";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@idt_proveedor", cmbAlergia.SelectedValue);
                comando.ExecuteNonQuery();
                Refresh();
                MessageBox.Show("Proveedor Eliminado");
                con.Close();
                CARGARCOMBOXPROVEEDOR();

            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique los medicamentos que hay registrados con ese proveedor");
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDoctor.Text = cmbDoctor.Text;

        }

        private void BtnActualizarDoctor_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "UPDATE T_DOCTOR SET NOMBREDOCTOR = @NOMBREDOCTOR, ESPECIALIDAD = @ESPECIALIDAD where IDDOCTOR=@IDDOCTOR";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDDOCTOR", cmbDoctor.SelectedValue);
            comando.Parameters.AddWithValue("@NombreDoctor", txtDoctor.Text);
            comando.Parameters.AddWithValue("@Especialidad", txtexpecialidad.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Doctor Actualizado");
            con.Close();
        }
    }
}
