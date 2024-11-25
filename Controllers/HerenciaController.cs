using herencia_interfaz_ejercicios.Herencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace herencia_interfaz_ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet("Perro")]
        public string getPerro()
        {
            Perro perro = new Perro();
            return perro.HacerSonido();
        }

        [HttpGet("Gato")]
        public string getGato()
        {
            Gato gato = new Gato();
            return gato.HacerSonido();
        }
    }
}
