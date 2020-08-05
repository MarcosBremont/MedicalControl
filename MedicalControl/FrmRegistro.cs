using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace MedicalControl
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        //Para poder arastrar el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");


            string query = "INSERT into Usuario (LoginName, Password, FirstName, LastName, Email) VALUES (@LoginName,@Password, @FirstName , @LastName , @Email)";
            con.Open();

            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@LoginName", txtnombreusuario.Text);
            comando.Parameters.AddWithValue("@Password", txtcontrasena.Text);
            comando.Parameters.AddWithValue("@FirstName", txtnombre.Text);
            comando.Parameters.AddWithValue("@LastName", txtapellido.Text);
            comando.Parameters.AddWithValue("@Email", txtemail.Text);
            comando.ExecuteNonQuery();


            MessageBox.Show("El usuario se guardo correctamente");
            txtnombreusuario.Text = "";
            txtcontrasena.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtemail.Text = "";
            con.Close();
        }


        private void FrmRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelregistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxregistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "NOMBRE")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "NOMBRE";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "CONTRASENA")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.Black;
                txtcontrasena.UseSystemPasswordChar = true;

            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "CONTRASENA";
                txtcontrasena.ForeColor = Color.Black;
                txtcontrasena.UseSystemPasswordChar = false;

            }
        }

        private void txtcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "APELLIDO")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "APELLIDO";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "E-MAIL")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "E-MAIL";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtnombreusuario_Enter(object sender, EventArgs e)
        {
            //Si el txtnombreusuario es igual a USUARIO entonces se colocara vacio cuando demos click
            if (txtnombreusuario.Text == "USUARIO")
            {
                txtnombreusuario.Text = "";
                txtnombreusuario.ForeColor = Color.Black;
            }
        }

        private void txtnombreusuario_Leave(object sender, EventArgs e)
        {
            //Si el txtnombreusuario esta vacio entonces se colocara USUARIO cuando demos click afuera

            if (txtnombreusuario.Text == "")
            {
                txtnombreusuario.Text = "USUARIO";
                txtnombreusuario.ForeColor = Color.Black;
            }
        }
    }
}
