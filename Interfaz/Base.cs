namespace herencia_interfaz_ejercicios.Interfaz
{
    public class Base
    {
        public string GetComer(IAnimal animal)
        {
            return animal.Comer();
        }
    }
}
