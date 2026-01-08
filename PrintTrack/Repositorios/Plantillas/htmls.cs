using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrintTrack.Repositorios.Plantillas
{
    internal class htmls
    {

        public static string Anuncio(string titulo, string mensaje, string nombre)
        {
            string html = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
</head>
<body style='font-family: Arial, Helvetica, sans-serif; color:#333; line-height:1.6'>

    <h3 style='margin-top:25px;'>{titulo}</h3>

    <p>
        {mensaje}
    </p>


    <p style='margin-top:20px; font-weight:bold;'>Un saludo {nombre}.</p>

</body>
</html>";

            return html;
        }

        public static string CredencialesNuevoUsuario(string clave, string usuario,string titulo)
        {
            string html = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
</head>
<body style='font-family: Arial, Helvetica, sans-serif; color:#333; line-height:1.6'>


    <h3 style='margin-top:25px;'>{titulo}</h3>

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

            return html;
        }

    }
}
