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

namespace MedicalControl
{
    public partial class FrmSeguro : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmSeguro()
        {
            InitializeComponent();
        }

        private void FrmSeguro_Load(object sender, EventArgs e)
        {
            RefreshSeguro();
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

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into t_segurom(NombreSeguro)values(@NombreSeguro)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NombreSeguro", txtnombreseguro.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Seguro Agregado");
            con.Close();
            txtnombreseguro.Text = "";
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmSeguro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnombrreseguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void dgvdoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsegurom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoseguro.Text = dgvsegurom.CurrentRow.Cells[0].Value.ToString();
            txtnombreseguro.Text = dgvsegurom.CurrentRow.Cells[1].Value.ToString();
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
    }
}
