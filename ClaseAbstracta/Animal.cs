namespace herencia_interfaz_ejercicios.ClaseAbstracta
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public abstract string HacerSonido();

        public string Comer()
        {
            return "Estoy comiendo";
        }
    }
}
