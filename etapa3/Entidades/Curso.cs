using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string uniqId { get; private set; }
        public string nombre { get; set; }

        public tiposJornadas Jornada;

        public Curso()=>uniqId = Guid.NewGuid().ToString();
        
        
    }
}