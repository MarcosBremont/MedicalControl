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
    public partial class FrmMantenimiento : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmAjustes_Load(object sender, EventArgs e)
        {

        
            RefreshAlergia();
            RefreshProveedor();
            RefreshSeguro();

        }



       

        private void BtnEliminarAlergia_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM T_Alergia Where IDALERGIA = @IDALERGIA";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@IDALERGIA", txtcodigoalergia.Text);
                comando.ExecuteNonQuery();
                RefreshAlergia();
                MessageBox.Show("Alergia Eliminada");
                con.Close();


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
                comando.Parameters.AddWithValue("@IDSEGURO", txtcodigoseguro.Text);
                comando.ExecuteNonQuery();
                RefreshSeguro();
                MessageBox.Show("Seguro Eliminada");
                con.Close();


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
                comando.Parameters.AddWithValue("@idt_proveedor", txtcodigoproveedor.Text);
                comando.ExecuteNonQuery();
                RefreshProveedor();
                MessageBox.Show("Proveedor Eliminado");
                con.Close();


            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique los medicamentos que hay registrados con ese proveedor");
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        
        public void RefreshAlergia()
        {

            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_alergia", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvalergia.DataSource = tabla;

        }
        public void RefreshSeguro()
        {

            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_segurom", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvsegurom.DataSource = tabla;

        }
        public void RefreshProveedor()
        {

            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_Proveedor", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedor.DataSource = tabla;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoalergia.Text = dgvalergia.CurrentRow.Cells[0].Value.ToString();
            txtnombrealergia.Text = dgvalergia.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvsegurom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoseguro.Text = dgvsegurom.CurrentRow.Cells[0].Value.ToString();
            txtnombreseguro.Text = dgvsegurom.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoproveedor.Text = dgvproveedor.CurrentRow.Cells[0].Value.ToString();
            txtnombreproveedor.Text = dgvproveedor.CurrentRow.Cells[1].Value.ToString();
            txtubicacionproveedor.Text = dgvproveedor.CurrentRow.Cells[2].Value.ToString();
            mtxtTelefono.Text = dgvproveedor.CurrentRow.Cells[3].Value.ToString();
            txtcorreo.Text = dgvproveedor.CurrentRow.Cells[4].Value.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE T_Alergia SET NOMBREA = @NOMBREA where IDALERGIA=@IDALERGIA";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDALERGIA", txtcodigoalergia.Text);
            comando.Parameters.AddWithValue("@NOMBREA", txtnombrealergia.Text);
            comando.ExecuteNonQuery();
            RefreshAlergia();
            MessageBox.Show("Alergia Actualizada");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_segurom SET NOMBRESEGURO = @NOMBRESEGURO where IDSEGURO=@IDSEGURO";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDSEGURO", txtcodigoseguro.Text);
            comando.Parameters.AddWithValue("@NOMBRESEGURO", txtnombreseguro.Text);
            comando.ExecuteNonQuery();
            RefreshSeguro();
            MessageBox.Show("Seguro Actualizado");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_proveedor SET NombreProveedor = @NombreProveedor, UbicacionProveedor = @UbicacionProveedor, TelefonoProveedor = @TelefonoProveedor, Correo=@Correo where idt_proveedor=@idt_proveedor";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_proveedor", txtcodigoproveedor.Text);
            comando.Parameters.AddWithValue("@NombreProveedor", txtnombreproveedor.Text);
            comando.Parameters.AddWithValue("@UbicacionProveedor", txtubicacionproveedor.Text);
            comando.Parameters.AddWithValue("@TelefonoProveedor", mtxtTelefono.Text);
            comando.Parameters.AddWithValue("@Correo", txtcorreo.Text);


            comando.ExecuteNonQuery();
            RefreshProveedor();
            MessageBox.Show("Seguro Actualizado");
            con.Close();
        }

        private void txtnombredoctor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtexpecialidaddoctor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtnombrealergia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtnombreseguro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtnombreproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }
    }
}
