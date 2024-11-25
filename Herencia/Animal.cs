namespace herencia_interfaz_ejercicios.Herencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public virtual string HacerSonido()
        {
            return "Hace sonido";
        }
    }
}
