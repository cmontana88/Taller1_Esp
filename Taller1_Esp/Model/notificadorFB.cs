using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;

namespace Taller1_Esp.Model
{
    public class NotificadorFB : Notificador
    {
        public NotificadorFB(Parametros parametros)
        : base(parametros)
        {

        }

        public override void enviar()
        {
            Console.WriteLine("******************** INICIO ENVIO FACEBOOK ****************");
            foreach (var destinatario in parametros.ListaFB)
            {
                Console.WriteLine(@"Enviado a Facebook: {0}, mensaje: {1}", destinatario, parametros.Mensaje);
            }
            Console.WriteLine("******************** FINAL ENVIO FACEBOOK *****************\n");
        }
    }
}
