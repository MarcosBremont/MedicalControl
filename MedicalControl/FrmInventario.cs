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
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using DataTable = System.Data.DataTable;

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
            this.TxtCantidad.Text = this.dataGridView1.Rows.Count.ToString("N0");

        }

        DataView ImportarDatos(string nombrearchivo)
        {
            //UTILIZAMOS 12.0 DEPENDIENDO DE LA VERSION DEL EXCEL, EN CASO DE QUE LA VERSIÓN QUE TIENES ES INFERIOR AL DEL 2013, CAMBIAR POR A EXCEL 8.0 Y EN VEZ DE
            //ACE.OLEDB.12.0 UTILIZAR LO SIGUIENTE (Jet.Oledb.4.0)
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nombrearchivo);

            OleDbConnection conector = new OleDbConnection(conexion);

            conector.Open();

            //DEPENDIENDO DEL NOMBRE QUE TIENE LA PESTAÑA EN TU ARCHIVO EXCEL COLOCAR DENTRO DE LOS []
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            conector.Close();

            return ds.Tables[0].DefaultView;
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
            comando.Parameters.AddWithValue("@Fecha", txtdescripcionmedicamento.Text);

            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Medicamento Agregado");
            con.Close();
            clear();
            this.TxtCantidad.Text = this.dataGridView1.Rows.Count.ToString("N0");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnombremedicamento.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcantidadmedicamento.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbproveedor.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            string query = "UPDATE t_inventario SET NombreMedicamento = @NombreMedicamento, CantidadMedicamento = @CantidadMedicamento, Proveedor = @Proveedor, Descripcion = @Descripcion, Fecha=@Fecha where idt_inventario=@idt_inventario";
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

        private void btnOtro_Click(object sender, EventArgs e)
        {
            FrmProveedor form = new FrmProveedor();
            form.ShowDialog();
            CARGARCOMBOXPROVEEDOR();
        }
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //DE ESTA MANERA FILTRAMOS TODOS LOS ARCHIVOS EXCEL EN EL NAVEGADOR DE ARCHIVOS
                Filter = "Excel | *.xls;*.xlsx;",

                //AQUÍ INDICAMOS QUE NOMBRE TENDRÁ EL NAVEGADOR DE ARCHIVOS COMO TITULO
                Title = "Seleccionar Archivo"
            };

            //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = ImportarDatos(openFileDialog.FileName);
            }
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM t_inventario where NombreMedicamento like ('" + txtbuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void txtcantidadmedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM t_paciente where NombreP like ('" + txtbuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
