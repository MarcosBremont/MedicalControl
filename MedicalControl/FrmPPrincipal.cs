using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalControl
{
    public partial class FrmPPrincipal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K7CFK6M\\SQLEXPRESS01; database=MedicalControl; Integrated Security = True");
        public FrmPPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicalControlDataSet.Paciente' Puede moverla o quitarla según sea necesario.
            Refresh();

        }

        public void Refresh ()
        {
            SqlCommand comando = new SqlCommand("Select * from Paciente", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Paciente (NombreP, ApellidoP, EdadP, CedulaP, DireccionP, TelefonoP, TelefonoEP, Alergias) values (@NombreP, @ApellidoP, @EdadP, @CedulaP, @DireccionP, @TelefonoP, @TelefonoEP, @Alergias)";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
            comando.Parameters.AddWithValue("@ApellidoP", txtapellidop.Text);
            comando.Parameters.AddWithValue("@EdadP", txtedadp.Text);
            comando.Parameters.AddWithValue("@CedulaP", txtcedulap.Text);
            comando.Parameters.AddWithValue("@DireccionP", txtdireccionp.Text);
            comando.Parameters.AddWithValue("@TelefonoP", txttelefonop.Text);
            comando.Parameters.AddWithValue("@TelefonoEP", txttelefonoep.Text);
            comando.Parameters.AddWithValue("@Alergias", txtalergias.Text);
            comando.ExecuteNonQuery();
            Refresh();
            //this.pacienteTableAdapter.Fill(this.medicalControlDataSet.Paciente);
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
            txtcedulap.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtdireccionp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txttelefonop.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txttelefonoep.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtalergias.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Paciente Where IDPaciente = @IDPaciente";
            SqlCommand comando = new SqlCommand(query, con);
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
            txtcedulap.Text = "";
            txtdireccionp.Text = "";
            txttelefonop.Text = "";
            txttelefonoep.Text = "";
            txtalergias.Text = "";
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Paciente SET NombreP = @NombreP, ApellidoP = @ApellidoP, EdadP = @EdadP, CedulaP = @CedulaP, DireccionP = @DireccionP, TelefonoP = @TelefonoP, TelefonoEP = @TelefonoEP, Alergias = @Alergias where IDPaciente=@IDPaciente";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDPaciente", lblid.Text);
            comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
            comando.Parameters.AddWithValue("@ApellidoP", txtapellidop.Text);
            comando.Parameters.AddWithValue("@EdadP", txtedadp.Text);
            comando.Parameters.AddWithValue("@CedulaP", txtcedulap.Text);
            comando.Parameters.AddWithValue("@DireccionP", txtdireccionp.Text);
            comando.Parameters.AddWithValue("@TelefonoP", txttelefonop.Text);
            comando.Parameters.AddWithValue("@TelefonoEP", txttelefonoep.Text);
            comando.Parameters.AddWithValue("@Alergias", txtalergias.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Actualizado");
            con.Close();
            clear();
            
        }

        private void txtnombrep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
