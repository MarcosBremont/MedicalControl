using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicalControl
{
    public partial class FrmInventario : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            Refresh();
            CARGARCOMBOXPROVEEDOR();


        }

        public void CARGARCOMBOXPROVEEDOR()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_PROVEEDOR", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbproveedor.ValueMember = "idt_proveedor";
            cbproveedor.DisplayMember = "NombreProveedor";
            cbproveedor.DataSource = dt;
        }

        public void Refresh()
        {
            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from t_inventario", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO t_inventario (NombreMedicamento, CantidadMedicamento, Proveedor, Descripcion, Fecha) values (@NombreMedicamento, @CantidadMedicamento, @Proveedor, @Descripcion, @Fecha)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreMedicamento", txtnombremedicamento.Text);
            comando.Parameters.AddWithValue("@CantidadMedicamento", txtcantidadmedicamento.Text);
            comando.Parameters.AddWithValue("@Proveedor", cbproveedor.SelectedValue);
            comando.Parameters.AddWithValue("@Descripcion", txtdescripcionmedicamento.Text);
            comando.Parameters.AddWithValue("@Fecha", dtfecha.Text);

            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Medicamento Agregado");
            con.Close();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombremedicamento.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcantidadmedicamento.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbproveedor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdescripcionmedicamento.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtfecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM t_inventario Where idt_inventario = @idt_inventario";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_inventario", lblid.Text);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Eliminado");
            con.Close();
            clear();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE t_inventario SET NombreMedicamento = @NombreMedicamento, CantidadMedicamento = @CantidadMedicamento, Proveedor = @Proveedor, Descripcion = @Descripcion, Fecha = @Fecha where idt_inventario=@idt_inventario";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@idt_inventario", lblid.Text);
            comando.Parameters.AddWithValue("@NombreMedicamento", txtnombremedicamento.Text);
            comando.Parameters.AddWithValue("@CantidadMedicamento", txtcantidadmedicamento.Text);
            comando.Parameters.AddWithValue("@Proveedor", cbproveedor.SelectedValue);
            comando.Parameters.AddWithValue("@Descripcion", txtdescripcionmedicamento.Text);
            comando.Parameters.AddWithValue("@Fecha", dtfecha.Text);

            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Actualizado");
            con.Close();
            clear();
        }

        public void clear()
        {
            lblid.Text = "";
            txtnombremedicamento.Text = "";
            txtcantidadmedicamento.Text = "";
            cbproveedor.Text = "";
            txtdescripcionmedicamento.Text = "";


        }
    }
}
