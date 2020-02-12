using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;

namespace Taller1_Esp.Model
{
    public class NotificadorEmail : Notificador
    {
        public NotificadorEmail(Parametros parametros)
        : base(parametros)
        {

        }

        public override void enviar()
        {
            Console.WriteLine("******************** INICIO ENVIO EMAIL ****************");
            foreach (var destinatario in parametros.ListaEmail)
            {
                Console.WriteLine(@"Enviado a email: {0}, mensaje: {1}", destinatario, parametros.Mensaje);
            }
            Console.WriteLine("******************** FINAL ENVIO EMAIL *****************\n");
        }
    }
}
