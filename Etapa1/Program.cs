using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escuelita = new Escuela("liceo", 1997);
            Escuelita.ciudadDeLaEscuela = "Neiva";
            Escuelita.Tipoescuela = TiposEscuela.secundaria;
            Console.WriteLine(Escuelita);
            
            var Escuelita2 = new Escuela("tecnico",2005,TiposEscuela.prescolar,ciudad: "mordor",pais:"colombia");
            Console.WriteLine(Escuelita2);
        }
    }
}
