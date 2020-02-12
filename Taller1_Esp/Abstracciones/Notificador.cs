using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_Esp.Abstracciones
{
    public abstract class Notificador
    {
        public Parametros parametros { get; set; }

        public Notificador(Parametros parametros)
        {
            this.parametros = parametros;
        }

        public abstract void enviar();
    }
}
