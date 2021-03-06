﻿using System;
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
using System.IO;

namespace MedicalControl
{
    public partial class FrmHistorialClinicocs : Form
    {
        char[] delimitador_cc = { ',' };
        char[] delimitador_adjunto = { '|' };

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /*CONFIGURACIÓN SMTP:
        ---------------------------------------------------------
        * OUTLOOK -->
          servidor SMTP: smtp-mail.outlook.com
          puerto: 587   
        ---------------------------------------------------------
        * GMAIL -->         
          servidor SMTP: smtp.gmail.com
        * puerto: 465 (SSL); 587 (TLS)
        ---------------------------------------------------------
        * YAHOO! -->
          servidor SMTP: smtp.mail.yahoo.com
          puerto: 25 ó 265
       */

        /* CARÁCTERES ESPECIALES QUE NO ADMITEN LOS NOMBRES DE ARCHIVOS:
         * / , \ , : , ? , * , ", < , > , |
         */

        MySqlConnection con = new MySqlConnection("Server=localhost; database=medicalcontrol; user=root; password=1234");

        public FrmHistorialClinicocs()
        {
            InitializeComponent();
        }

        private void FrmHistorialClinicocs_Load(object sender, EventArgs e)
        {
            txtremitente.Text = "lofisoftware00@gmail.com";
            txtpassword.Text = "Marcosjb1";

            rtbmensaje.Text = "";

            string total;
            total = rtbmensaje.Text;

            rtbmensaje.Text = total;

            CARGARCOMBOXALERGIA();
            CARGARCOMBOXSEGURO();
            CARGARCOMBOXDOCTOR();
            Refresh();
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
            cmbalergias.Visible = false;
            lblAntecedentesTransfucionales.Visible = false;


        }

        public void Refresh()
        {
            //  MySqlCommand comando = new MySqlCommand("Select * from T_Paciente", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select IDhistorialClinico as Codigo, NombreP as Nombre, ApellidoP as Apellido, Telefono as Telefono  from t_historialclinico", con);
            // adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvhistorialclinico.DataSource = tabla;
        }

        public void enviar_correo(string host, int puerto, string remitente, string contraseña, string nombre, string destinatarios, string cc, string asunto, string adjuntos, string cuerpo)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;
                correo.Subject = asunto;
                if (destinatarios == "") { }
                else
                {
                    string[] cadena = destinatarios.Split(delimitador_cc);
                    foreach (string word in cadena) correo.To.Add(word.Trim());
                }
                if (cc == "") { }
                else
                {
                    string[] cadena1 = cc.Split(delimitador_cc);
                    foreach (string word in cadena1) correo.CC.Add(word.Trim());
                }
                if (adjuntos == "") { }
                else
                {
                    string[] cadena2 = adjuntos.Split(delimitador_adjunto);
                    foreach (string word in cadena2) correo.Attachments.Add(new Attachment(word));
                }
                cliente.Credentials = new NetworkCredential(remitente, contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);

                MessageBox.Show("El correo se envio correctamente", "Correo Enviado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Arrow;
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

       

        
        private void SaveFile(SaveFileDialog sfd)
        {
            string path = sfd.FileName;
            File.WriteAllText(path, string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22} {23} {24} {25} {26} {27} {28} {29} {30} {31} {32} {33} {34} {35} {36} {37} {38} {39} {40} {41} {42} {43} {44} {45} {46} {47} {48} {49}"
            , "ID", txthistorialclinico.Text
            , "Nombre", txtnombrep.Text
            , "Apellido", txtApellido.Text
            , "Fecha", dtPFecha.Text
            , "Sexo", cmbSexo.Text
            , "Telefono", MtbTelefono.Text
            , "Procedencia", txtProcedencia.Text
            , "Residencia", txtResidencia.Text
            , "Edad", txtEdad.Text
            , "Cedula", mtbCedula.Text
            , "Telefono 2", mtbTelefono2.Text
            , "Seguro", cmbsegurom.Text
            , "Doctor/a", cmbDoctor.Text
            , "Ocupacion", txtOcupacion.Text
            , "Religion", txtReligion.Text
            , "Estado Civil", txtEstadoCivil.Text
            , "Raza", txtRaza.Text
            , "Alergias", cmbalergias.Text
            , "Antecedentes Quirurgicos", txtAntecedentesQuirurgicos.Text
            , "Antecedentes Hospitalarios", txtAntecedentesHospitalarios.Text
            , "Antecedentes Medicamentosos", txtAntecedentesMedicamentosos.Text
            , "Antecedentes Traumaticos", txtAntecedentesTarumaticos.Text
            , "Antecedentes sobre la niñez", txtNiñez.Text
            , "Antecedentes sobre la adolescencia", txtAdolescencia.Text
            , "Antecedentes sobre la adultez", txtAdultez.Text));


        }

      

       

        private void btnenviar_Click(object sender, EventArgs e)
        {
            enviar_correo("smtp.gmail.com", 587, txtremitente.Text, txtpassword.Text, txtasunto.Text, txtpara.Text, txtcc.Text, rtbmensaje.Text, txtadjunto.Text, rtbmensaje.Text);

        }

        private void btnadjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtadjunto.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
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
            cmbalergias.Visible = true;
            lblAntecedentesTransfucionales.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    string query = "INSERT INTO t_HistorialClinico (NombreP, ApellidoP, Fecha, Sexo, Telefono, Procedencia, Residencia, Edad, Cedula, Telefono2, Seguro, Doctor, Ocupacion, Religion, EstadoCivil, Raza, AntAlrg, AntQrg, AntHops, AntMed, AntTra, Ninez, Adolescencia, Adultez) values(@NombreP, @ApellidoP, @Fecha, @Sexo, @Telefono, @Procedencia, @Residencia, @Edad, @Cedula, @Telefono2, @Seguro, @Doctor, @Ocupacion, @Religion, @EstadoCivil, @Raza, @AntAlrg, @AntQrg, @AntHops, @AntMed, @AntTra, @Ninez, @Adolescencia, @Adultez)";
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

                    comando.ExecuteNonQuery();
                    Refresh();
                    MessageBox.Show("Historial Clinico Agregado");

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Text Files|*.txt|Documents|*.doc";
                        sfd.CreatePrompt = true;
                        sfd.OverwritePrompt = false;
                        sfd.Title = "Save Text Document";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            SaveFile(sfd);
                        }
                    }
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
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

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    string query = "UPDATE t_HistorialClinico SET NombreP = @NombreP, ApellidoP=@ApellidoP, Fecha=@Fecha, Sexo=@Sexo, Telefono=@Telefono, Procedencia=@Procedencia, Residencia=@Residencia, Edad=@Edad, Cedula=@Cedula, Telefono2=@Telefono2, Seguro=@Seguro, Doctor=@Doctor, Ocupacion=@Ocupacion, Religion=@Religion, EstadoCivil=@EstadoCivil, Raza=@Raza, AntAlrg=@AntAlrg, AntQrg=@AntQrg, AntHops=@AntHops, AntMed=@AntMed, AntTra=@AntTra, Ninez=@Ninez, Adolescencia=@Adolescencia, Adultez=@Adultez where IDhistorialClinico=@IDhistorialClinico";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.Parameters.AddWithValue("@IDhistorialClinico", txthistorialclinico.Text);
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
                    comando.Parameters.AddWithValue("@AntHops", txtAntecedentesHospitalarios.Text);
                    comando.Parameters.AddWithValue("@AntMed", txtAntecedentesMedicamentosos.Text);
                    comando.Parameters.AddWithValue("@AntTra", txtAntecedentesTarumaticos.Text);
                    comando.Parameters.AddWithValue("@Ninez", txtNiñez.Text);
                    comando.Parameters.AddWithValue("@Adolescencia", txtAdolescencia.Text);
                    comando.Parameters.AddWithValue("@Adultez", txtAdultez.Text);

                    comando.ExecuteNonQuery();
                    Refresh();
                    MessageBox.Show("Historial Clinico Actualizado");
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
    }
}
