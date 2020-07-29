using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalControl
{
    public partial class FrmCitasMedicas : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmCitasMedicas()
        {
            InitializeComponent();
        }

        private void FrmCitasMedicas_Load(object sender, EventArgs e)
        {
            Refresh();
            CARGARCOMBOXALERGIA();
            CARGARCOMBOXSEGURO();
            CARGARCOMBOXDOCTOR();

            //Nombramos una variable string con la fecha de hoy
            string fechacompar = DateTime.Today.ToString("dd/MM/yyyy");
            dataGridView1.AllowUserToAddRows = false;
           // int rowIndex = -1;
            //Hacemos un foreach para que recorra la tabla, en caso de que encuentre una fecha que sea igual
            // de la de hoy este mostrara la celda en rojo
            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.Equals(fechacompar))
                {
                    //rowIndex = row.Index;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    //break
                }
                else
                {



                }
            }
            */
        }

        public void CARGARCOMBOXSEGURO()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM t_segurom", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbnseguro.ValueMember = "IDSEGURO";
            cmbnseguro.DisplayMember = "NombreSeguro";
            cmbnseguro.DataSource = dt;
        }

        public void CARGARCOMBOXALERGIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_ALERGIA", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbnalergia.ValueMember = "IDALERGIA";
            cmbnalergia.DisplayMember = "NombreA";
            cmbnalergia.DataSource = dt;
        }


        public void CARGARCOMBOXDOCTOR()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_Doctor", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbndoctor.ValueMember = "IDDOCTOR";
            cmbndoctor.DisplayMember = "NombreDoctor";
            cmbndoctor.DataSource = dt;
        }

        

        public void Refresh()
        {
            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_citamedica", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO T_CitaMedica (HORACM, FECHACM, COMENTARIO, ID2SEGUR, ID2ALERG, ID2DOCTOR, NombreCompleto) values (@HORACM, @FECHACM, @COMENTARIO, @ID2SEGUR, @ID2ALERG, @ID2DOCTOR, @NombreCompleto)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@HORACM", dthora.Text);
            comando.Parameters.AddWithValue("@FECHACM", dtfecha.Text);
            comando.Parameters.AddWithValue("@COMENTARIO", txtcomentario.Text);
            comando.Parameters.AddWithValue("@ID2SEGUR", cmbnseguro.SelectedValue);
            comando.Parameters.AddWithValue("@ID2ALERG", cmbnalergia.SelectedValue);
            comando.Parameters.AddWithValue("@ID2DOCTOR", cmbndoctor.SelectedValue);
            comando.Parameters.AddWithValue("@NombreCompleto", txtnombrecompleto.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Agregado");
            con.Close();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM t_citamedica Where IDCITAMEDICA = @IDCITAMEDICA";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCITAMEDICA", lblid.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Eliminado");
            con.Close();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dthora.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtfecha.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcomentario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbnseguro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbnalergia.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbndoctor.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtnombrecompleto.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE T_CITAMEDICA SET HORACM = @HORACM, FECHACM = @FECHACM, COMENTARIO = @COMENTARIO, ID2SEGUR = @ID2SEGUR, ID2ALERG = @ID2ALERG, ID2DOCTOR = @ID2DOCTOR, NombreCompleto = @NombreCompleto where IDCITAMEDICA=@IDCITAMEDICA";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCITAMEDICA", lblid.Text);
            comando.Parameters.AddWithValue("@HORACM", dthora.Text);
            comando.Parameters.AddWithValue("@FECHACM", dtfecha.Text);
            comando.Parameters.AddWithValue("@COMENTARIO", txtcomentario.Text);
            comando.Parameters.AddWithValue("@ID2SEGUR", cmbnseguro.SelectedValue);
            comando.Parameters.AddWithValue("@ID2ALERG", cmbnalergia.SelectedValue);
            comando.Parameters.AddWithValue("@ID2DOCTOR", cmbndoctor.SelectedValue);
            comando.Parameters.AddWithValue("@NombreCompleto", txtnombrecompleto.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Actualizado");
            con.Close();
            clear();
        }

        public void clear()
        {
            lblid.Text = "";
            txtcomentario.Text = "";
            cmbnseguro.Text = "";
            cmbnalergia.Text = "";
            cmbndoctor.Text = "";
           

        }
    }
}
