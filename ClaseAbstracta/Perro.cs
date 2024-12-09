namespace herencia_interfaz_ejercicios.ClaseAbstracta
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }
        
        public override string HacerSonido()
        {
            return "Guau guau";
        }
    }
}
