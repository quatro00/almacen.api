﻿using Microsoft.AspNetCore.Identity;

namespace almacen.api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Guid? OrganizacionId { get; set; }
        public bool Activo {  get; set; }
    }
}
