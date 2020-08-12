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
            RefreshProveedor();
        }


        public void RefreshProveedor()
        {

            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_Proveedor", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproveedor.DataSource = tabla;

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
            cmd.Parameters.AddWithValue("@UbicacionProveedor", txtubicacionproveedor.Text);
            cmd.Parameters.AddWithValue("@TelefonoProveedor", mtxtTelefono.Text);
            cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Proveedor Agregado");
            con.Close();
            txtnombreproveedor.Text = "";
            txtubicacionproveedor.Text = "";
            txtcorreo.Text = "";
            mtxtTelefono.Text = "";
            RefreshProveedor();
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

        private void BtnEliminarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM t_proveedor Where idt_proveedor = @idt_proveedor";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@idt_proveedor", txtcodigoproveedor.Text);
                comando.ExecuteNonQuery();
                RefreshProveedor();
                MessageBox.Show("Proveedor Eliminado");
                con.Close();

                RefreshProveedor();
            }
            catch (MySql.Data.MySqlClient.MySqlException ER)
            {
                MessageBox.Show("Error, primero elimine o modifique los medicamentos que hay registrados con ese proveedor");
            }
        }

        private void dgvproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoproveedor.Text = dgvproveedor.CurrentRow.Cells[0].Value.ToString();
            txtnombreproveedor.Text = dgvproveedor.CurrentRow.Cells[1].Value.ToString();
            txtubicacionproveedor.Text = dgvproveedor.CurrentRow.Cells[2].Value.ToString();
            mtxtTelefono.Text = dgvproveedor.CurrentRow.Cells[3].Value.ToString();
            txtcorreo.Text = dgvproveedor.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_proveedor SET NombreProveedor = @NombreProveedor, UbicacionProveedor = @UbicacionProveedor, TelefonoProveedor = @TelefonoProveedor, Correo=@Correo where idt_proveedor=@idt_proveedor";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_proveedor", txtcodigoproveedor.Text);
            comando.Parameters.AddWithValue("@NombreProveedor", txtnombreproveedor.Text);
            comando.Parameters.AddWithValue("@UbicacionProveedor", txtubicacionproveedor.Text);
            comando.Parameters.AddWithValue("@TelefonoProveedor", mtxtTelefono.Text);
            comando.Parameters.AddWithValue("@Correo", txtcorreo.Text);


            comando.ExecuteNonQuery();
            RefreshProveedor();
            MessageBox.Show("Seguro Actualizado");
            con.Close();
        }

        private void FrmProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
