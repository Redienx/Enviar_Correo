using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioCorreo
{
    public partial class fmrEnvioCorreo : Form
    {
        private string _myEmail = ""; // Tu dirección de correo electrónico
        private string _Contraseña = ""; // Tu contraseña (¡asegúrate de mantenerla segura!)
        private string Alias = ""; // Tu alias o nombre
        private string[] _ArchivosAdjuntos; // Arreglo para almacenar los archivos adjuntos
        private MailMessage _mCorreo; // Mensaje de correo electrónico

        public fmrEnvioCorreo()
        {
            InitializeComponent();
        }

        private void CrearCuerpoCorreo()
        {
            _mCorreo = new MailMessage();
            _mCorreo.From = new MailAddress(_myEmail, Alias, System.Text.Encoding.UTF8); // Establece la dirección y el alias del remitente
            _mCorreo.To.Add(txtEmailPara.Text.Trim()); // Agrega el destinatario desde el cuadro de texto
            _mCorreo.Subject = txtAsunto.Text.Trim(); // Asigna el asunto desde el cuadro de texto
            _mCorreo.Body = txtMensaje.Text.Trim(); // Asigna el cuerpo del mensaje desde el cuadro de texto
            _mCorreo.IsBodyHtml = true; // Indica que el cuerpo es HTML
            _mCorreo.Priority = MailPriority.High; // Establece la prioridad del correo como alta

            // Adjunta los archivos seleccionados
            for (int i = 0; i < _ArchivosAdjuntos.Length; i++)
            {
                _mCorreo.Attachments.Add(new Attachment(_ArchivosAdjuntos[i]));
            }
        }

        private void Enviar()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25; // Puerto SMTP
                smtp.Host = "smtp.gmail.com"; // Servidor SMTP de Gmail
                smtp.Credentials = new System.Net.NetworkCredential(_myEmail, _Contraseña); // Credenciales de inicio de sesión
                // La línea a continuación evita la validación del certificado SSL (¡no recomendado en producción!)
                // ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true; // Habilita SSL para conexiones seguras
                smtp.Send(_mCorreo); // Envía el correo
                MessageBox.Show("Enviado"); // Muestra un mensaje de confirmación
                lblArchivos.Text = ""; // Limpia la etiqueta de archivos adjuntos
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Muestra un mensaje de error si ocurre una excepción
            }
        }

        private void AdjuntarArchivos()
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // Permite seleccionar múltiples archivos
            ofd.Title = "Adjuntar archivos al correo"; // Título del cuadro de diálogo

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _ArchivosAdjuntos = ofd.FileNames; // Almacena los nombres de los archivos seleccionados
            }

            for (int i = 0; i < _ArchivosAdjuntos.Length; i++)
            {
                names += _ArchivosAdjuntos[i] + "\n"; // Muestra los nombres de los archivos seleccionados
            }

            lblArchivos.Text = names; // Muestra los nombres de los archivos en una etiqueta
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            Enviar();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }
    }
}
