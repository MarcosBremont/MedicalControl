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
    public partial class FrmHistorialClinicocs : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmHistorialClinicocs()
        {
            InitializeComponent();
        }

        private void FrmHistorialClinicocs_Load(object sender, EventArgs e)
        {
            lblAntecedentesAlergicos.Visible = false;
            lblAntecedentesHospitalarios.Visible = false;
            lblAntecedentesMedicamentosos.Visible = false;
            lblAntecedentesQuirurgicos.Visible = false;
            lblAntecedentesTraumaticos.Visible = false;
            txtAntecedentesHospitalarios.Visible = false;
            txtAntecedentesMedicamentosos.Visible = false;
            txtAntecedentesQuirurgicos.Visible = false;
            txtAntecedentesTarumaticos.Visible = false;
            txtAntecedentesTransfucionales.Visible = false;
            txtNiñez.Visible = false;
            txtAdolescencia.Visible = false;
            txtAdultez.Visible = false;
            lblNiñez.Visible = false;
            lblAdolescencia.Visible = false;
            lblAdultez.Visible = false;
            lblRadiografia.Visible = false;
            lblSonografia.Visible = false;
            lblResonanciaMagnetica.Visible = false;
            lblTomografiaComputarizada.Visible = false;
            cmbalergias.Visible = false;
            lblAntecedentesTransfucionales.Visible = false;
            txtRadiografia.Visible = false;
            txtSonografia.Visible = false;
            txtResonanciaMagnetica.Visible = false;
            txtTomografiaComputarizada.Visible = false;
            BtnRadriografia.Visible = false;
            BtnResonancia.Visible = false;
            BtnSonografia.Visible = false;
            BtnTomografia.Visible = false;

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblasunto_Click(object sender, EventArgs e)
        {

        }

        private void lblpara_Click(object sender, EventArgs e)
        {

        }

        private void lblaadjunto_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblAntecedentesAlergicos.Visible = true;
            lblAntecedentesHospitalarios.Visible = true;
            lblAntecedentesMedicamentosos.Visible = true;
            lblAntecedentesQuirurgicos.Visible = true;
            lblAntecedentesTraumaticos.Visible = true;
            txtAntecedentesHospitalarios.Visible = true;
            txtAntecedentesMedicamentosos.Visible = true;
            txtAntecedentesQuirurgicos.Visible = true;
            txtAntecedentesTarumaticos.Visible = true;
            txtAntecedentesTransfucionales.Visible = true;
            txtNiñez.Visible = true;
            txtAdolescencia.Visible = true;
            txtAdultez.Visible = true;
            txtNiñez.Visible = true;
            txtAdolescencia.Visible = true;
            txtAdultez.Visible = true;
            lblNiñez.Visible = true;
            lblAdolescencia.Visible = true;
            lblAdultez.Visible = true;
            lblRadiografia.Visible = true;
            lblSonografia.Visible = true;
            lblResonanciaMagnetica.Visible = true;
            lblTomografiaComputarizada.Visible = true;
            cmbalergias.Visible = true;
            lblAntecedentesTransfucionales.Visible = true;
            txtRadiografia.Visible = true;
            txtSonografia.Visible = true;
            txtResonanciaMagnetica.Visible = true;
            txtTomografiaComputarizada.Visible = true;
            BtnRadriografia.Visible = true;
            BtnResonancia.Visible = true;
            BtnSonografia.Visible = true;
            BtnTomografia.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO t_HistorialClinico (NombreP, ApellidoP, EdadP, CedulaP, DireccionP, TelefonoP, Telefonop2, SexoP, IDTALER, IDTSEGURO, IDTDOCTOR  ) values (@NombreP, @ApellidoP, @EdadP, @CedulaP, @DireccionP, @TelefonoP, @Telefonop2, @SexoP, @IDTALER, @IDTSEGURO, @IDTDOCTOR)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
            comando.Parameters.AddWithValue("@ApellidoP", txtApellido.Text);
            comando.Parameters.AddWithValue("@EdadP", dtPFecha.Text);
            comando.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
            comando.Parameters.AddWithValue("@Telefono", MtbTelefono.Text);
            comando.Parameters.AddWithValue("@Procedencia", txtProcedencia.Text);
            comando.Parameters.AddWithValue("@Residencia", txtResidencia.Text);
            comando.Parameters.AddWithValue("@Edad", txtEdad.Text);
            comando.Parameters.AddWithValue("@Cedula", mtbCedula.Text);
            comando.Parameters.AddWithValue("@Telefono2", mtbTelefono2.Text);
            comando.Parameters.AddWithValue("@Seguro", cmbAlergia.SelectedValue);
            comando.Parameters.AddWithValue("@IDTSEGURO", cmbSeguro.SelectedValue);
            comando.Parameters.AddWithValue("@IDTDOCTOR", cmbDoctor.SelectedValue);
            comando.ExecuteNonQuery();
            Refresh();
            MessageBox.Show("Paciente Agregado");
            con.Close();
            
        }
    }
}
