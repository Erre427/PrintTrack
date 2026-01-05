using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrintTrack.Repositorios
{
    public static class Verificador
    {
        public static bool Email(string email)
        {

            var emailCortado = email.Trim();

            if (emailCortado.EndsWith("."))
                return false;

            var verificador = new System.Net.Mail.MailAddress(email);

            if (verificador.Address == emailCortado)
                return true;

            else
                return false;
        }
    }
}
