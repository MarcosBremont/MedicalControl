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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

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
            dgvcitasmedicas.AllowUserToAddRows = false;
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
            dgvcitasmedicas.DataSource = tabla;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO T_CitaMedica (NombreCompleto, HORACM, FECHACM, COMENTARIO, ID2SEGUR, ID2ALERG, ID2DOCTOR) values (@NombreCompleto, @HORACM, @FECHACM, @COMENTARIO, @ID2SEGUR, @ID2ALERG, @ID2DOCTOR)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreCompleto", txtnombrecompleto.Text);
            comando.Parameters.AddWithValue("@HORACM", dthora.Text);
            comando.Parameters.AddWithValue("@FECHACM", dtfecha.Text);
            comando.Parameters.AddWithValue("@COMENTARIO", txtcomentario.Text);
            comando.Parameters.AddWithValue("@ID2SEGUR", cmbnseguro.SelectedValue);
            comando.Parameters.AddWithValue("@ID2ALERG", cmbnalergia.SelectedValue);
            comando.Parameters.AddWithValue("@ID2DOCTOR", cmbndoctor.SelectedValue);
            
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Cita Medica Agregada");
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
            MessageBox.Show("Cita Medica Eliminada");
            con.Close();
            clear();
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
            MessageBox.Show("Cita Medica Actualizada");
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
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvcitasmedicas);

        }

        private void txtnombrecompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void dgvcitasmedicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvcitasmedicas.CurrentRow.Cells[0].Value.ToString();
            dthora.Text = dgvcitasmedicas.CurrentRow.Cells[1].Value.ToString();
            dtfecha.Text = dgvcitasmedicas.CurrentRow.Cells[2].Value.ToString();
            txtcomentario.Text = dgvcitasmedicas.CurrentRow.Cells[3].Value.ToString();
            cmbnseguro.SelectedValue = dgvcitasmedicas.CurrentRow.Cells[4].Value.ToString();
            cmbnalergia.SelectedValue = dgvcitasmedicas.CurrentRow.Cells[5].Value.ToString();
            cmbndoctor.SelectedValue = dgvcitasmedicas.CurrentRow.Cells[6].Value.ToString();
            txtnombrecompleto.Text = dgvcitasmedicas.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM t_citamedica where NombreCompleto like ('" + txtbuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvcitasmedicas.DataSource = dt;

            con.Close();
        }

        private void gbprincipal_Enter(object sender, EventArgs e)
        {

        }
    }
}
