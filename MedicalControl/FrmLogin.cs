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
    public partial class FrmLogin : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public FrmLogin()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        }
        //Para poder arastrar el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //VARIABLES
        string usuarios;

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre = txtnombreusuario.Text;
            string Password = txtcontrasena.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Usuario where LoginName='" + txtnombreusuario.Text + "' AND Password='" + txtcontrasena.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmBase form = new FrmBase();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
            con.Close();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtnombreusuario_Enter(object sender, EventArgs e)
        {
            if (txtnombreusuario.Text == "USUARIO")
            {
                txtnombreusuario.Text = "";
                txtnombreusuario.ForeColor = Color.Black;
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Nombre = txtnombreusuario.Text;
                string Contrasena = txtcontrasena.Text;
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Usuario where LoginName='" + txtnombreusuario.Text + "' AND Password='" + txtcontrasena.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    FrmBase form = new FrmBase();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
                con.Close();

            }
        }

        private void txtnombreusuario_Leave(object sender, EventArgs e)
        {
            if (txtnombreusuario.Text == "")
            {
                txtnombreusuario.Text = "USUARIO";
                txtnombreusuario.ForeColor = Color.Black;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro form = new FrmRegistro();
            this.Hide();
            form.Show();
        }
    }
}
