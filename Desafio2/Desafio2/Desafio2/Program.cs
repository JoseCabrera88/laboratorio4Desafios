using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        interface INotificable
        {
            void Notifica(string mensaje);
        }

        class NotificacionEmail : INotificable
        {
            public string direccionCorreo;

            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando email al correo: {direccionCorreo}: {mensaje}");
            }
        }

        class NotificacionWhatsapp : INotificable
        {
            public string numeroTelefono;
            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando mensaje a Whatsapp al número: {numeroTelefono}: {mensaje}");
            }
        }

        class NotificacionSMS : INotificable
        {
            public string numeroTelefono;
            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando SMS al número: {numeroTelefono}: {mensaje}");
            }
        }
        static void Main(string[] args)
        {
            var notificacionEmail = new NotificacionEmail { direccionCorreo = "correodeejemplo@gmail.com" };
            var notificacionWhatsapp = new NotificacionWhatsapp { numeroTelefono = "1234567890" };
            var notificacionSMS = new NotificacionSMS { numeroTelefono = "1234567890" };

            notificacionEmail.Notifica("Hola como te va? ");
            notificacionWhatsapp.Notifica("Hola como te va? ");
            notificacionSMS.Notifica("Hola como te va? ");
        }
    }
}
