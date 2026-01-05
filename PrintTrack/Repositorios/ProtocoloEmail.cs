using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    // Clase logica para mandar correos
    internal class ProtocoloEmail
    {
        // Credenciales y datos principales
        MailAddress remitente = new MailAddress("printtracknoreply@gmail.com", "PrintTrack");
        SmtpClient cliente = new SmtpClient("smtp.gmail.com");


        // Metodo para enviar credenciales a empleados nuevos
        public void EnviarCredenciales(string correo,string clave,string usuario)
        {
            string asunto = "CREDENCIALES DE ACCESO AL SISTEMA";
            string cuerpo = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
</head>
<body style='font-family: Arial, Helvetica, sans-serif; color:#333; line-height:1.6'>

    <p><strong>Hola!</strong></p>

    <p>
        Nos da mucho gusto tenerte como nuevo miembro en el equipo,<br>
        por lo tanto te adjuntamos en este correo las credenciales para<br>
        entrar a nuestro sistema por primera vez.
    </p>

    <h3 style='margin-top:25px;'>CREDENCIALES</h3>

    <table style='border-collapse: collapse;'>
        <tr>
            <td style='padding:6px 10px; font-weight:bold;'>Usuario:</td>
            <td style='padding:6px 10px;'>{usuario}</td>
        </tr>
        <tr>
            <td style='padding:6px 10px; font-weight:bold;'>Contraseña temporal:</td>
            <td style='padding:6px 10px;'>{clave}</td>
        </tr>
    </table>

    <p style='margin-top:20px;'>
        Por seguridad el sistema te pedirá crear una contraseña nueva solo<br>
        para que tú puedas entrar con tu perfil.
    </p>

    <p style='margin-top:20px;'>Un saludo.</p>

</body>
</html>";

            MailAddress destinatario = new MailAddress(correo);
            MailMessage mensaje = new MailMessage(remitente, destinatario);
            mensaje.Subject = asunto;
            mensaje.IsBodyHtml = true;
            mensaje.Body = cuerpo;

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential("printtracknoreply@gmail.com", "gbunyythijfaettn");

            cliente.Send(mensaje);

        }
    }
}
