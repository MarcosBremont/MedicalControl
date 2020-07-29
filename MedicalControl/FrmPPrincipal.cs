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
    public partial class FrmPPrincipal : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmPPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPPrincipal_Load(object sender, EventArgs e)
        {
            Refresh();
            CARGARCOMBOXALERGIA();
            CARGARCOMBOXSEGURO();
            CARGARCOMBOXDOCTOR();


            this.TxtCantidad.Text = this.dataGridView1.Rows.Count.ToString("N0");



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

        public void Refresh()
        {
            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from T_Paciente", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO T_Paciente (NombreP, ApellidoP, EdadP, CedulaP, DireccionP, TelefonoP, Telefonop2, SexoP, IDTALER, IDTSEGURO, IDTDOCTOR  ) values (@NombreP, @ApellidoP, @EdadP, @CedulaP, @DireccionP, @TelefonoP, @Telefonop2, @SexoP, @IDTALER, @IDTSEGURO, @IDTDOCTOR)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
            comando.Parameters.AddWithValue("@ApellidoP", txtapellidop.Text);
            comando.Parameters.AddWithValue("@EdadP", txtedadp.Text);
            comando.Parameters.AddWithValue("@CedulaP", mtxtCedula.Text);
            comando.Parameters.AddWithValue("@DireccionP", txtdireccionp.Text);
            comando.Parameters.AddWithValue("@TelefonoP", mtxtTelefono.Text);
            comando.Parameters.AddWithValue("@Telefonop2", mtxtTelefono2.Text);
            comando.Parameters.AddWithValue("@SEXOP", cmbSexo.Text);
            comando.Parameters.AddWithValue("@IDTALER", cmbAlergia.SelectedValue);
            comando.Parameters.AddWithValue("@IDTSEGURO", cmbSeguro.SelectedValue);
            comando.Parameters.AddWithValue("@IDTDOCTOR", cmbDoctor.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Agregado");
            con.Close();
            clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombrep.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapellidop.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtedadp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtxtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtdireccionp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtxtTelefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mtxtTelefono2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbSexo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbAlergia.SelectedValue = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbSeguro.SelectedValue = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cmbDoctor.SelectedValue = dataGridView1.CurrentRow.Cells[11].Value.ToString();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM T_Paciente Where IDPaciente = @IDPaciente";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDPaciente", lblid.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Eliminado");
            con.Close();
            clear();



        }

        public void clear()
        {
            lblid.Text = "";
            txtnombrep.Text = "";
            txtapellidop.Text = "";
            txtedadp.Text = "";
            mtxtCedula.Text = "";
            txtdireccionp.Text = "";
            mtxtTelefono.Text = "";
            mtxtTelefono2.Text = "";
            cmbAlergia.Text = "";
            cmbDoctor.Text = "";
            cmbSeguro.Text = "";
            cmbSexo.Text = "";

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE T_Paciente SET NombreP = @NombreP, ApellidoP = @ApellidoP, EdadP = @EdadP, CedulaP = @CedulaP, DireccionP = @DireccionP, TelefonoP = @TelefonoP, TelefonoP2 = @TelefonoP2, SexoP=@SexoP, IDTALER = @IDTALER, IDTSEGURO = @IDTSEGURO, IDTDOCTOR = @IDTDOCTOR where IDPaciente=@IDPaciente";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDPaciente", lblid.Text);
            comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
            comando.Parameters.AddWithValue("@ApellidoP", txtapellidop.Text);
            comando.Parameters.AddWithValue("@EdadP", txtedadp.Text);
            comando.Parameters.AddWithValue("@CedulaP", mtxtCedula.Text);
            comando.Parameters.AddWithValue("@DireccionP", txtdireccionp.Text);
            comando.Parameters.AddWithValue("@TelefonoP", mtxtTelefono.Text);
            comando.Parameters.AddWithValue("@TelefonoP2", mtxtTelefono2.Text);
            comando.Parameters.AddWithValue("@SexoP", cmbSexo.Text);
            comando.Parameters.AddWithValue("@IDTALER", cmbAlergia.SelectedValue);
            comando.Parameters.AddWithValue("@IDTSEGURO", cmbSeguro.SelectedValue);
            comando.Parameters.AddWithValue("@IDTDOCTOR", cmbDoctor.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Actualizado");
            con.Close();
            clear();

        }

        private void txtnombrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            FrmDoctorcs form = new FrmDoctorcs();
            form.ShowDialog();
            CARGARCOMBOXDOCTOR();
        }

        private void Cargar()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM T_PACIENTE";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            Cargar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAlergia form = new FrmAlergia();
            form.ShowDialog();
            CARGARCOMBOXALERGIA();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSeguro form = new FrmSeguro();
            form.ShowDialog();
            CARGARCOMBOXSEGURO();

        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM t_paciente where NombreP like ('" + txtbuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
