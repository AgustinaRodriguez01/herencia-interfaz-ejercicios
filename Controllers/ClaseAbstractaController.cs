using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using herencia_interfaz_ejercicios.ClaseAbstracta;

namespace herencia_interfaz_ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseAbstractaController : ControllerBase
    {
        [HttpGet]
        [Route("api/HacerSonidos")]
        public string GetSonidos()
        {
            Perro perro = new Perro("Firulais");
            Gato gato = new Gato("Garfield");
            return $"{perro.HacerSonido()} y {gato.HacerSonido()}";
        }

        [HttpGet]
        [Route("api/Comer")]
        public string GetComer()
        {
            Perro perro = new Perro("Firulais");
            Gato gato = new Gato("Garfield");
            return $"Perro: {perro.Comer()} y Gato: {gato.Comer()}";
        }
    }
}
