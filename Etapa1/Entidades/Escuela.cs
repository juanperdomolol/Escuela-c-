namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombreEscuela;
        public string NombreEscuela
        {
            get { return "COPIA: "+ nombreEscuela; }
            set { nombreEscuela = value.ToUpper(); }
        }
        public int añoDeLaEscuela { get; set; }

        public string ciudadDeLaEscuela { get; set; }

        public string  paisEscuela { get; set; }

        //public Escuela(string nombre, int añoDeLaEscuela){
        //   nombreEscuela = nombre;
        //    this.añoDeLaEscuela = añoDeLaEscuela;
        //}

        public TiposEscuela Tipoescuela { get; set; }


        public Escuela(string nombre, int año) => (NombreEscuela, añoDeLaEscuela) = (nombre, año);

        public Escuela(string nombre, int añoDeLaEscuela, TiposEscuela tipos, 
        string ciudad = " ", string pais = " ")
        {
            NombreEscuela = nombre;
            this.añoDeLaEscuela = añoDeLaEscuela;
            ciudadDeLaEscuela = ciudad;
            paisEscuela = pais;

        }
              
        public override string ToString()
        {
            return $"Nombre de la escuela: {NombreEscuela}, Tipo de escuela: {Tipoescuela} {System.Environment.NewLine}Año de la escuela: {añoDeLaEscuela}, ciudad de la escuela: {ciudadDeLaEscuela}, pais de la escuela: {paisEscuela}";
        }

    }
}
