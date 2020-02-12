using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;

namespace Taller1_Esp.Model
{
    public class NotificadorCorporativo : Notificador
    {
        public NotificadorCorporativo(Parametros parametros)
        : base(parametros)
        {

        }

        public override void enviar()
        {
            Console.WriteLine("******************** INICIO ENVIO CORPORATIVO ****************");
            foreach (var destinatario in parametros.ListaCorporativos)
            {
                Console.WriteLine(@"Enviado a coorporativo: {0}, mensaje: {1}", destinatario, parametros.Mensaje);
            }
            Console.WriteLine("******************** FINAL ENVIO CORPORATIVO *****************\n");
        }
    }
}
