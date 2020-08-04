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
    public partial class FrmProveedor : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert Into t_proveedor(NombreProveedor, UbicacionProveedor, TelefonoProveedor, Correo)values(@NombreProveedor, @UbicacionProveedor, @TelefonoProveedor, @Correo)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NombreProveedor", txtnombreproveedor.Text);
            cmd.Parameters.AddWithValue("@UbicacionProveedor", txtubicacion.Text);
            cmd.Parameters.AddWithValue("@TelefonoProveedor", mtbtelefonoproveedor.Text);
            cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Proveedor Agregado");
            con.Close();
            txtnombreproveedor.Text = "";
            txtubicacion.Text = "";
            txtcorreo.Text = "";
            mtbtelefonoproveedor.Text = "";
            Refresh();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void txtnombreproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }
    }
}
