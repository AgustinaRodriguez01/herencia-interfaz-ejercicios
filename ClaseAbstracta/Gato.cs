namespace herencia_interfaz_ejercicios.ClaseAbstracta
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override string HacerSonido()
        {
            return "Miau miau";
        }
    }
}
