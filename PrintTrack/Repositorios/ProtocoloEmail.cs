using PrintTrack.Entidades;
using PrintTrack.Repositorios.Plantillas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    // Clase logica para mandar correos
    internal class ProtocoloEmail
    {
        private readonly string _correo;
        private readonly string _clave;

        public ProtocoloEmail()
        {
            _correo = ConfigurationManager.AppSettings["EmailUser"];
            _clave = ConfigurationManager.AppSettings["EmailPass"];
        }


        public void Enviar(string destinatario, string asunto, string html)
        {
            var remitente = new MailAddress(_correo, "PrintTrack");
            var mensaje = new MailMessage(remitente, new MailAddress(destinatario))
            {
                Subject = asunto,
                Body = html,
                IsBodyHtml = true
            };

            var cliente = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_correo, _clave)
            };

            cliente.Send(mensaje);

        }


        // Metodo para enviar credenciales a empleados nuevos
        public void EnviarCredenciales(string correo,string clave,string usuario)
        {
            string html;

            string asunto = "CREDENCIALES DE ACCESO AL SISTEMA";

            html = htmls.CredencialesNuevoUsuario(clave, usuario, asunto);
            

            Enviar(correo, asunto, html);

        }

        public void AnuncioGeneral(List<Usuarios> usuariosSeleccionados, string asunto, string mensaje)
        {
            string html;

            foreach(Usuarios user in usuariosSeleccionados)
            {
                html = htmls.Anuncio(asunto, mensaje, user.NombreCompleto);

                Enviar(user.Email.ToLower(), asunto, html);
            }
        }

    }
}
