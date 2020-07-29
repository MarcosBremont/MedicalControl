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
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=MarcosBremont");

        private void FrmDoctorcs_Load(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("@NombreDoctor", txtnombredr.Text);
            cmd.Parameters.AddWithValue("@Especialidad", txtespecialidaddr.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Agregado");
            con.Close();
            txtnombredr.Text = "";
            txtespecialidaddr.Text = "";
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
