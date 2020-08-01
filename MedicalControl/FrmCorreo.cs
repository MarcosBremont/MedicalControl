using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MedicalControl
{
    public partial class FrmCorreo : Form
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


        public FrmCorreo()
        {
            InitializeComponent();
        }

        private void FrmCorreo_Load(object sender, EventArgs e)
        {
            txtremitente.Text = "lofisoftware00@gmail.com";
            txtpassword.Text = "Marcosjb1";

            rtbmensaje.Text = "";

            string total;
            total = txtnombreclinica.Text + rtbmensaje.Text;

            rtbmensaje.Text = total;
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

                MessageBox.Show("El correo se ha enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Arrow;
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            enviar_correo("smtp.gmail.com", 587, txtremitente.Text, txtpassword.Text, txtasunto.Text, txtpara.Text, txtcc.Text, rtbmensaje.Text, txtadjunto.Text, rtbmensaje.Text);
            Cursor = Cursors.WaitCursor;
        }
    }
}
