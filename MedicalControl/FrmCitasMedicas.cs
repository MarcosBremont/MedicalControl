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
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=MarcosBremont");

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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.Equals(fechacompar))
                {
                    //rowIndex = row.Index;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    //break;
                }
                else
                {



                }
            }

        }

        public void CARGARCOMBOXSEGURO()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM T_SEGUROM", con);
            con.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                cmbnseguro.Items.Add(registro["IDSEGURO"].ToString());
                cmbnseguro.Items.Add(registro["NombreSeguro"].ToString());
            }
            con.Close();
        }

        public void CARGARCOMBOXALERGIA()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM T_ALERGIA", con);
            con.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                cmbnalergia.Items.Add(registro["IDALERGIA"].ToString());
                cmbnalergia.Items.Add(registro["NombreA"].ToString());
            }
            con.Close();
        }


        public void CARGARCOMBOXDOCTOR()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM T_Doctor", con);
            con.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                cmbndoctor.Items.Add(registro["IDDOCTOR"].ToString());
                cmbndoctor.Items.Add(registro["NombreDoctor"].ToString());
            }
            con.Close();
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
            string query = "INSERT INTO T_CitaMedica (HORACM, FECHACM, COMENTARIO, ID2SEGUR, ID2ALERG, ID2DOCTOR) values (@HORACM, @FECHACM, @COMENTARIO, @ID2SEGUR, @ID2ALERG, @ID2DOCTOR)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@HORACM", dthora.Text);
            comando.Parameters.AddWithValue("@FECHACM", dtfecha.Text);
            comando.Parameters.AddWithValue("@COMENTARIO", txtcomentario.Text);
            comando.Parameters.AddWithValue("@ID2SEGUR", cmbnseguro.Text);
            comando.Parameters.AddWithValue("@ID2ALERG", cmbnalergia.Text);
            comando.Parameters.AddWithValue("@ID2DOCTOR", cmbndoctor.Text);
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
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE T_CITAMEDICA SET HORACM = @HORACM, FECHACM = @FECHACM, COMENTARIO = @COMENTARIO, ID2SEGUR = @ID2SEGUR, ID2ALERG = @ID2ALERG, ID2DOCTOR = @ID2DOCTOR where IDCITAMEDICA=@IDCITAMEDICA";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCITAMEDICA", lblid.Text);
            comando.Parameters.AddWithValue("@HORACM", dthora.Text);
            comando.Parameters.AddWithValue("@FECHACM", dtfecha.Text);
            comando.Parameters.AddWithValue("@COMENTARIO", txtcomentario.Text);
            comando.Parameters.AddWithValue("@ID2SEGUR", cmbnseguro.Text);
            comando.Parameters.AddWithValue("@ID2ALERG", cmbnalergia.Text);
            comando.Parameters.AddWithValue("@ID2DOCTOR", cmbndoctor.Text);
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
