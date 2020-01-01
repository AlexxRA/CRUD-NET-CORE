using System;
using System.Collections.Generic;

namespace CRUD_NET_CORE.Models
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Descripcion { get; set; }
    }
}
