//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigracionApp.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOGIN
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public Nullable<System.DateTime> ultimo_acceso { get; set; }
    
        public virtual USUARIOS USUARIOS { get; set; }
    }
}