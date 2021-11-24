using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    class enviar_email
    {
        public int enviar(string emisor, string contraseña, string receptor)
        {
            Random codigo = new Random();
            int numero = codigo.Next(100000, 1000000);
            MailMessage mensaje = new MailMessage();
            mensaje.To.Add(receptor);
            mensaje.Subject = "correo de verificación";
            mensaje.SubjectEncoding = Encoding.UTF8;
            mensaje.Body = "su codigo de verificación es " + numero + ", ingrese el código para cambiar la contraseña";
            mensaje.BodyEncoding = Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new MailAddress(emisor);
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emisor, contraseña);
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            try
            {
                client.Send(mensaje);
            }
            catch (Exception)
            {

                MessageBox.Show("");
                numero = 0;
            }

            return numero;
        }
    }
}
