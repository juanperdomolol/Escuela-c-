using System;
using System.Collections.Generic;
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

            Escuelita.cursos = new List<Curso>(){
            new Curso() { nombre = "101", Jornada = tiposJornadas.mañana },
            new Curso() { nombre = "201", Jornada = tiposJornadas.mañana },
            new Curso() { nombre = "301", Jornada = tiposJornadas.mañana }
            };
            Escuelita.cursos.Add(new Curso() { nombre = "102", Jornada = tiposJornadas.tarde });

            var otroscursos = new List<Curso>(){
            new Curso() { nombre = "401", Jornada = tiposJornadas.mañana },
            new Curso() { nombre = "501", Jornada = tiposJornadas.mañana },
            new Curso() { nombre = "202", Jornada = tiposJornadas.tarde }
            };
            //var cursotmp = new Curso() { nombre = "106", Jornada = tiposJornadas.noche };
            //Escuelita.cursos.Add(cursotmp);//se agrego un solo curso
            Escuelita.cursos.AddRange(otroscursos);// se agrega una lista a cursos
            ImprimirCursosEscuela(Escuelita);
            WriteLine("============================");
            //Escuelita.cursos.Remove(cursotmp); se remueve un solo curso
           // Escuelita.cursos.RemoveAll(Predicado);//este es el delegado de predicado para borrar un curso
            ImprimirCursosEscuela(Escuelita);


        }

       // private static bool Predicado(Curso objeto)// esto es el predicado
        //{
        //    return objeto.nombre == "301";
        //}

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

                    WriteLine($"Nombre: {Curso.nombre}, id: {Curso.uniqId}, jornada : ");
                    WriteLine("==============");
                }

            }
        }
    }
}

