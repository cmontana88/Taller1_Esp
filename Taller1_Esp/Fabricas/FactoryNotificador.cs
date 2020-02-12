using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1_Esp.Abstracciones;
using Taller1_Esp.Model;

namespace Taller1_Esp.Fabricas
{
    public class FactoryNotificador
    {
        List<Notificador> notificadors;
        
        public List<Notificador> getNotificadores(Parametros parametros)
        {
            notificadors = new List<Notificador>();
            foreach (var tipo in parametros.Tipos.Split(',').ToList())
            {
                if (tipo.Equals("E"))
                {
                    notificadors.Add(new NotificadorEmail(parametros));
                }
                else if (tipo.Equals("S"))
                {
                    notificadors.Add(new NotificadorSMS(parametros));
                }
                else if (tipo.Equals("F"))
                {
                    notificadors.Add(new NotificadorFB(parametros));
                }
                else if (tipo.Equals("C"))
                {
                    notificadors.Add(new NotificadorCorporativo(parametros));
                }
            }

            return notificadors;
        }
    }
}
