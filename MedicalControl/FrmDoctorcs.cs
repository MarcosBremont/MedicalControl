using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MedicalControl
{
    public partial class FrmDoctorcs : Form
    {
        public FrmDoctorcs()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        private void FrmDoctorcs_Load(object sender, EventArgs e)
        {
            RefreshDoctor();
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

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmDoctorcs_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into t_doctor(NombreDoctor, Especialidad)values(@NombreDoctor, @Especialidad)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NombreDoctor", txtnombredoctor.Text);
            cmd.Parameters.AddWithValue("@Especialidad", txtexpecialidaddoctor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Agregado");
            con.Close();
            txtnombredoctor.Text = "";
            txtexpecialidaddoctor.Text = "";
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnombredr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtespecialidaddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void BtnEliminarDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM T_Doctor Where IDDOCTOR = @IDDOCTOR";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@IDDOCTOR", txtcodigodoctor.Text);
                comando.ExecuteNonQuery();
                RefreshDoctor();
                MessageBox.Show("Doctor Eliminado");
                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique las citas y pacientes que hay registrados con este doctor/@");
            }
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
            RefreshDoctor();
            MessageBox.Show("Doctor Actualizado");
            con.Close();
        }

        private void dgvdoctores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigodoctor.Text = dgvdoctores.CurrentRow.Cells[0].Value.ToString();
            txtnombredoctor.Text = dgvdoctores.CurrentRow.Cells[1].Value.ToString();
            txtexpecialidaddoctor.Text = dgvdoctores.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
