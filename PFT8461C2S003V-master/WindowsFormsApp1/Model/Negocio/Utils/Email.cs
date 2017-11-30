using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Utils
{
    class Email
    {
        public static void enviarMailOferta(string nombreCliente, string email, string nombreProducto)
        {
            // Construcción email
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("Widuk_@hotmail.com");
            mail.Subject = nombreCliente + " ¡Tenemos una nueva oferta!";
            mail.Body = "¡Tenemos una nueva oferta de " + nombreProducto + "!  <a href='http://localhost:8080/Ofertas/'> Visitanos</a> para saber más sobre esta.";
            mail.IsBodyHtml = true;
            
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
            mail.AlternateViews.Add(htmlView);
            
            // Instanciamiento y configuración de cliente SMTP 
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.live.com";
            smtp.Credentials = new NetworkCredential(
                "Widuk_@hotmail.com", "irco6no92eb3");
            smtp.EnableSsl = true;

            // Envío email
            smtp.Send(mail);
        }
    }
}
