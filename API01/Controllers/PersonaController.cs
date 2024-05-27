using API01.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace API01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    //controlador en especifico
    public class PersonaController : ControllerBase
    {
        //Metodo/ verbo de http
        [HttpGet]
        public IActionResult ListarPersona()
        {
            //instanciar
            List<Persona> lstPersonas = new List<Persona>();

            for (int i = 0; i < 10; i++) { 
                
                Persona tmp = new Persona();
                tmp.Id = i;
                tmp.Nombre = $"Nombre ${i*3}";
                tmp.ApellidoPaterno = $"Apellido paterno ${i*3}";
                tmp.ApellidoMaterno = $"Apellido materno ${i * 3}";
                tmp.FechaNacimiento = DateTime.Now.AddYears(-i*2);
                tmp.Direccion = $"Dirección ${i * 7}"; 
                lstPersonas.Add(tmp);
            }
            return Ok(lstPersonas);
        }

    }
}

        ////Metodo/ verbo de http
        //[HttpGet("Lista-total-persona")]
        //public IActionResult ListarPersonas()
        //{
        //    //instanciar
        //    List<Persona> lstPersonas = new List<Persona>();

        //    for (int i = 0; i < 20; i++)
        //    {

        //        Persona tmp = new Persona();
        //        tmp.Id = i;
        //        tmp.Nombre = $"Nombre ${i * 3}";
        //        tmp.ApellidoPaterno = $"Apellido paterno ${i * 3}";
        //        tmp.ApellidoMaterno = $"Apellido materno ${i * 3}";
        //        tmp.FechaNacimiento = DateTime.Now.AddYears(-i * 2);
        //        tmp.Direccion = $"Dirección ${i * 7}";
        //        lstPersonas.Add(tmp);
        //    }
        //    return Ok(lstPersonas);
        //}