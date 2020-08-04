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
            cmd.Parameters.AddWithValue("@NombreSeguro", txtnombrreseguro.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Seguro Agregado");
            con.Close();
            txtnombrreseguro.Text = "";
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
    }
}
