using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_NET_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {

            using (Models.crudContext db = new Models.crudContext())
            {
                var lst = (from d in db.Persona
                           select d).ToList();
                return Ok(lst);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.ViewModels.PersonaViewModel model)
        {
            using (Models.crudContext db = new Models.crudContext())
            {
                Models.Persona persona = new Models.Persona();
                persona.Nombre = model.nombre;
                persona.Edad = model.edad.ToString();
                persona.Descripcion = model.descripcion;
                db.Add(persona);
                db.SaveChanges();

            }
            return Ok();
        }
    }
}