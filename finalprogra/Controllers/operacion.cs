using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalprogra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class operacion : ControllerBase
    {
        [HttpGet]
        public string funcion(int numero)
        {
            string texto = "";
            if (numero < 0)
            {
                texto = "ERROR";
            }
            if (numero == 0)
            {
                texto = "Realizado por Fernanda Ferreira";
            }
            if (numero > 0)
            {
                texto = "imagen: https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg"; 
            }
            return texto; 
        }
    }
}
