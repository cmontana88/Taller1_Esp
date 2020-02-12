using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;

namespace Taller1_Esp.Model
{
    public class NotificadorSMS : Notificador
    {
        public NotificadorSMS(Parametros parametros)
        : base(parametros)
        {

        }

        public override void enviar()
        {
            Console.WriteLine("******************** INICIO ENVIO SMS ****************");
            foreach (var destinatario in parametros.ListaTelefonos)
            {
                Console.WriteLine(@"Enviado SMS a: {0}, mensaje: {1}", destinatario, parametros.Mensaje);
            }
            Console.WriteLine("******************** FINAL ENVIO SMS *****************\n");
        }
    }
}
