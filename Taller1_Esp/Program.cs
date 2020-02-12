using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace Taller1_Esp
{

    class Program
    {
        static void Main(string[] args)
        {
            Parametros parametros = new Parametros();
            parametros.Tipos = "C,E,F";  //E,S,F,C    E = Email, S = SMS, F = Facebook, C = Corporativo
            parametros.Mensaje = "Hola compañeros";
            parametros.ListaCorporativos = new List<string>() { "corporativo1@miempresa.com", "corporativo3@miempresa.com", "corporativo2@miempresa.com" };
            parametros.ListaEmail = new List<string>() { "miemail1@gmail.com", "miemail3@gmail.com", "miemail2@gmail.com" };
            parametros.ListaFB = new List<string>() { "Facebook1", "Facebook2", "Facebook3", "Facebook4" };
            parametros.ListaTelefonos = new List<string>() { "3006584752", "3015245698", "3104142587", "3006584752", "3201457896" };

            Aplicacion aplicacion = new Aplicacion(parametros);
            aplicacion.hacerAlgo();
        }
    }
}
