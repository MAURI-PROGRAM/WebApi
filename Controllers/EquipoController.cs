using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace proyect_neet_core_3._1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipoController : ControllerBase
    {


        private readonly ILogger<EquipoController> _logger;

        public EquipoController(ILogger<EquipoController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public Equipo GetName()
        {
            var equipo = new Equipo();
            var integrantes = new List<Integrante>();
            integrantes.Add(new Integrante { Nombre = "Juan", Edad = 27, Sexo = "Masculino" });
            integrantes.Add(new Integrante { Nombre = "Jerry", Edad = 25, Sexo = "Masculino" });
            integrantes.Add(new Integrante { Nombre = "Michael", Edad = 27, Sexo = "Masculino" });
            equipo.Integrantes = integrantes;
            return equipo;
        }
    }
}
