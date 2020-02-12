using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;
using Taller1_Esp.Fabricas;

namespace Taller1_Esp
{
    public class Aplicacion
    {
        List<Notificador> notificadors;
        FactoryNotificador factoryNotificador;
        public Aplicacion(Parametros parametros)
        {
            factoryNotificador = new FactoryNotificador();
            notificadors = factoryNotificador.getNotificadores(parametros);
        }

        public void hacerAlgo()
        {
            foreach (var notificador in notificadors)
            {
                notificador.enviar();
            }
            Console.ReadLine();
        }
    }
}
