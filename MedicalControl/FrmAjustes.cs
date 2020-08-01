﻿using System;
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

            RefreshDoctor();
            RefreshAlergia();
            RefreshProveedor();
            RefreshSeguro();

        }

     
        
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM T_Doctor Where IDDOCTOR = @IDDOCTOR";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDDOCTOR", txtcodigodoctor.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("DOCTOR Eliminado");
            con.Close();
           
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
            Refresh();
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
            Refresh();
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
                Refresh();
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

        private void BtnActualizarDoctor_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "UPDATE T_DOCTOR SET NOMBREDOCTOR = @NOMBREDOCTOR, ESPECIALIDAD = @ESPECIALIDAD where IDDOCTOR=@IDDOCTOR";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDDOCTOR", txtcodigodoctor.Text);
            comando.Parameters.AddWithValue("@NombreDoctor", txtnombredoctor.Text);
            comando.Parameters.AddWithValue("@Especialidad", txtexpecialidaddoctor.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Doctor Actualizado");
            con.Close();
        }

        public void RefreshDoctor()
        {
            
                //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_doctor", con);
                // adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvdoctores.DataSource = tabla;
          
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
            txttelefonoproveedor.Text = dgvproveedor.CurrentRow.Cells[3].Value.ToString();
            txtcorreo.Text = dgvproveedor.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvdoctores_Click(object sender, EventArgs e)
        {
            txtcodigodoctor.Text = dgvdoctores.CurrentRow.Cells[0].Value.ToString();
            txtnombredoctor.Text = dgvdoctores.CurrentRow.Cells[1].Value.ToString();
            txtexpecialidaddoctor.Text = dgvdoctores.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
