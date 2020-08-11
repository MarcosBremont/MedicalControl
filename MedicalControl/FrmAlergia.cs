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
    public partial class FrmAlergia : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmAlergia()
        {
            InitializeComponent();
        }

        private void FrmAlergia_Load(object sender, EventArgs e)
        {
            RefreshAlergia();
        }

        public void RefreshAlergia()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_alergia", con);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvalergia.DataSource = tabla;
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

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into t_alergia(NombreA)values(@NombreA)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NombreA", txtnombrealergia.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Alergia Agregado");
            con.Close();
            RefreshAlergia();
            txtnombrealergia.Text = "";
            Refresh();
           
        }

        private void FrmAlergia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnombrealergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void dgvalergia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoalergia.Text = dgvalergia.CurrentRow.Cells[0].Value.ToString();
            txtnombrealergia.Text = dgvalergia.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
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
    }
}
