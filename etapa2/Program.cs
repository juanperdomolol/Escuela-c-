using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace etapa2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escuelita = new Escuela("liceo", 1997);
            Escuelita.ciudadDeLaEscuela = "Neiva";
            Escuelita.Tipoescuela = TiposEscuela.secundaria;
            Console.WriteLine(Escuelita);

            var Escuelita2 = new Escuela("tecnico", 2005, TiposEscuela.prescolar, ciudad: "mordor", pais: "colombia");
            Console.WriteLine(Escuelita2);

            Escuelita.cursos = new Curso[] {
            new Curso() {nombre = "101"},
            new Curso(){nombre = "201"},
            new Curso(){nombre = "301"}
            };
            ImprimirCursosEscuela(Escuelita);
        }

        private static void ImprimirCursosEscuela(Escuela Escuelita)
        {
            WriteLine("==============");
            WriteLine("Cursos de la Escuela {Escuelita.nombre}");
            WriteLine("==============");

            if (Escuelita == null && Escuelita.cursos == null)
            {
                return;
            }
            else
            {
                foreach (var Curso in Escuelita.cursos)
                {
                    WriteLine("==============");
                    WriteLine($"Nombre: {Curso.nombre}, id: {Curso.uniqId}");
                }

            }
        }
    }
}

