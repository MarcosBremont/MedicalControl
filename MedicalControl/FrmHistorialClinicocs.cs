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
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Runtime.InteropServices;

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

            CARGARCOMBOXALERGIA();
            CARGARCOMBOXSEGURO();
            CARGARCOMBOXDOCTOR();


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


        public void CARGARCOMBOXALERGIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_ALERGIA", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbalergias.ValueMember = "IDALERGIA";
            cmbalergias.DisplayMember = "NombreA";
            cmbalergias.DataSource = dt;
        }

        public void CARGARCOMBOXSEGURO()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM t_segurom", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbsegurom.ValueMember = "IDSEGURO";
            cmbsegurom.DisplayMember = "NombreSeguro";
            cmbsegurom.DataSource = dt;
        }


        public void CARGARCOMBOXDOCTOR()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM T_Doctor", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDoctor.ValueMember = "IDDOCTOR";
            cmbDoctor.DisplayMember = "NombreDoctor";
            cmbDoctor.DataSource = dt;

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
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    string query = "INSERT INTO t_HistorialClinico (NombreP, ApellidoP, Fecha, Sexo, Telefono, Procedencia, Residencia, Edad, Cedula, Telefono2, Seguro, Doctor, Ocupacion, Religion, EstadoCivil, Raza, AntAlrg, AntQrg, AntHops, AntMed, AntTra, Ninez, Adolescencia, Adultez, Sonografia, TomografiaComp, Radriografia, ResonanciaM) values(@NombreP, @ApellidoP, @Fecha, @Sexo, @Telefono, @Procedencia, @Residencia, @Edad, @Cedula, @Telefono2, @Seguro, @Doctor, @Ocupacion, @Religion, @EstadoCivil, @Raza, @AntAlrg, @AntQrg, @AntHops, @AntMed, @AntTra, @Ninez, @Adolescencia, @Adultez, @Sonografia, @TomografiaComp, @Radriografia, @ResonanciaM)";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.Parameters.AddWithValue("@NombreP", txtnombrep.Text);
                    comando.Parameters.AddWithValue("@ApellidoP", txtApellido.Text);
                    comando.Parameters.AddWithValue("@Fecha", dtPFecha.Text);
                    comando.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                    comando.Parameters.AddWithValue("@Telefono", MtbTelefono.Text);
                    comando.Parameters.AddWithValue("@Procedencia", txtProcedencia.Text);
                    comando.Parameters.AddWithValue("@Residencia", txtResidencia.Text);
                    comando.Parameters.AddWithValue("@Edad", txtEdad.Text);
                    comando.Parameters.AddWithValue("@Cedula", mtbCedula.Text);
                    comando.Parameters.AddWithValue("@Telefono2", mtbTelefono2.Text);
                    comando.Parameters.AddWithValue("@Seguro", cmbsegurom.SelectedValue);
                    comando.Parameters.AddWithValue("@Doctor", cmbDoctor.SelectedValue);
                    comando.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                    comando.Parameters.AddWithValue("@Religion", txtReligion.Text);
                    comando.Parameters.AddWithValue("@EstadoCivil", txtEstadoCivil.Text);
                    comando.Parameters.AddWithValue("@Raza", txtRaza.Text);
                    comando.Parameters.AddWithValue("@AntAlrg", cmbalergias.SelectedValue);
                    comando.Parameters.AddWithValue("@AntQrg", txtAntecedentesQuirurgicos.Text);
                    comando.Parameters.AddWithValue("@AntHops", txtAntecedentesHospitalarios.Text); ;
                    comando.Parameters.AddWithValue("@AntMed", txtAntecedentesMedicamentosos.Text);
                    comando.Parameters.AddWithValue("@AntTra", txtAntecedentesTarumaticos.Text);
                    comando.Parameters.AddWithValue("@Ninez", txtNiñez.Text);
                    comando.Parameters.AddWithValue("@Adolescencia", txtAdolescencia.Text);
                    comando.Parameters.AddWithValue("@Adultez", txtAdultez.Text);
                    comando.Parameters.AddWithValue("@Sonografia", txtSonografia.Text);
                    comando.Parameters.AddWithValue("@TomografiaComp", txtTomografiaComputarizada);
                    comando.Parameters.AddWithValue("@Radriografia", txtRadiografia);
                    comando.Parameters.AddWithValue("@ResonanciaM", txtResonanciaMagnetica.Text);
                    comando.ExecuteNonQuery();
                    Refresh();
                    MessageBox.Show("Historial Clinico Agregado");
                }
                else
                {
                    con.Close();
                }

            }
            catch (Exception)
            {

            }



        }

        private void BtnSonografia_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtSonografia.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void BtnTomografia_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtTomografiaComputarizada.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void BtnRadriografia_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtRadiografia.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void BtnResonancia_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtResonanciaMagnetica.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from t_HistorialClinico where IDhistorialClinico=@IDhistorialClinico", con);
                    cmd.Parameters.AddWithValue("@IDhistorialClinico", txthistorialclinico.Text);
                   
                    MySqlDataReader reg = cmd.ExecuteReader();
                    if (reg.Read())
                    {
                        txtnombrep.Text = reg["NombreP"].ToString();
                        txtApellido.Text = reg["ApellidoP"].ToString();
                        dtPFecha.Text = reg["Fecha"].ToString();
                        cmbSexo.Text = reg["Sexo"].ToString();
                        MtbTelefono.Text = reg["Telefono"].ToString();
                        txtProcedencia.Text = reg["Procedencia"].ToString();
                        txtResidencia.Text = reg["Residencia"].ToString();
                        txtEdad.Text = reg["Edad"].ToString();
                        mtbCedula.Text = reg["Cedula"].ToString();
                        mtbTelefono2.Text = reg["Telefono2"].ToString();
                        cmbsegurom.SelectedValue = reg["Seguro"].ToString();
                        cmbDoctor.SelectedValue = reg["Doctor"].ToString();
                        txtOcupacion.Text = reg["Ocupacion"].ToString();
                        txtReligion.Text = reg["Religion"].ToString();
                        txtEstadoCivil.Text = reg["EstadoCivil"].ToString();
                        txtRaza.Text = reg["Raza"].ToString();
                        cmbalergias.SelectedValue = reg["AntAlrg"].ToString();
                        txtAntecedentesQuirurgicos.Text = reg["AntQrg"].ToString();
                        txtAntecedentesHospitalarios.Text = reg["AntHops"].ToString();
                        txtAntecedentesMedicamentosos.Text = reg["AntMed"].ToString();
                        txtAntecedentesTarumaticos.Text = reg["AntTra"].ToString();
                        txtNiñez.Text = reg["Ninez"].ToString();
                        txtAdolescencia.Text = reg["Adolescencia"].ToString();
                        txtAdultez.Text = reg["Adultez"].ToString();
                        txtSonografia.Text = reg["Sonografia"].ToString();
                        txtTomografiaComputarizada.Text = reg["TomografiaComp"].ToString();
                        txtRadiografia.Text = reg["Radriografia"].ToString();
                        txtResonanciaMagnetica.Text = reg["ResonanciaM"].ToString();
                        MessageBox.Show("Historial Clinico Encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Historial Clinico No Encontrado");
                    con.Close();
                }

            }
            catch (Exception)
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



    }
}
