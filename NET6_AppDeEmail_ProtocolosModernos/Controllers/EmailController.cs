using MailKit.Net.Smtp;
using MailKit.Security;

using Microsoft.AspNetCore.Mvc;

using MimeKit;
using MimeKit.Text;

namespace NET6_AppDeEmail_ProtocolosModernos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult EnviarEmail(string corpo)
        {
            var email = new MimeMessage();
            //usamos conta de email de Ethereal
            // https://ethereal.email/ 
            //Ethereal e un servicio fake de email SMTP
            //co cal podes testear tua app de email
            //crean un email de mentira para ti
            //tras clickar en Create Ethereal account
            //we use an email account from Ethereal
            //https://ethereal.email/ 
            //Ethereal is a fake SMTP email service
            //with which you can test your email app
            //they create a fake email account for you
            //after clicking on Create Ethereal account
            email.From.Add(MailboxAddress.Parse("gage.hettinger4@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("gage.hettinger4@ethereal.email"));
            email.Subject = "Hola boas"; //hardcodeado
            email.Body = new TextPart(TextFormat.Html) { Text = corpo }; //personalizable. Customizable 

            //Por favor! non uses System.Net.Mail para SmtpClient
            //Microsoft non o recomenda. Usa namespace Mimekit.Text
            //Please dont use System.Net.Mail for SmtpClient
            //Microsoft doesnt recommend it, Use Mimekit.Text namespace instead
            using var smtp = new SmtpClient();

            //servidor e porto. Server and port
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);//conectase a server fake de Ethereal. It connects to fake server from Ethereal
            //para outros servicios, como gmail, sería "smtp.gmail.com" por ex.
            //i.e, for other services, like gmail, you'd type "smtp.gmail.com" 
            //para Hotmail seria/for Hotmail it'd be ("smtp.live.com")
            //para Office365 seria/for Office365 it'd be ("smtp.office365.com")

            //Autenticacion. Authenticacion. Datos tomados da conta fake de Ethereal. Data takem from Ethereal fake account
            smtp.Authenticate("gage.hettinger4@ethereal.email", "mBJdth4xpmnQsvQeuA");
            smtp.Send(email);
            smtp.Disconnect(true);

            return Ok();
        }
    }
}
