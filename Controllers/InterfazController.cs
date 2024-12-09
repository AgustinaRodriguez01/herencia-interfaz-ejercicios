using herencia_interfaz_ejercicios.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace herencia_interfaz_ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazController : ControllerBase
    {
        [HttpGet("Herencia")]
        public string Get()
        {
            Interfaz.Perro perro = new Interfaz.Perro();
            Interfaz.Gato gato = new Interfaz.Gato();
            return $"{perro.Comer()} y {gato.Comer()}";
        }

        [HttpGet("Base")]
        public string GetBase()
        {
            Interfaz.Base _base = new Interfaz.Base();
            Perro perro = new Perro();
            return _base.GetComer(perro);
        }

        [HttpGet]
        [Route("api/EjemploInterfazConImplementacion")]
        public string EjemploInterfazConImplementacion()
        {
            IAnimal perro = new Perro();
            return perro.HacerSonido();

        }
    }
}
