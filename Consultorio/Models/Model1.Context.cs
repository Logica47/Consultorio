﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hospitalEntities : DbContext
    {
        public hospitalEntities()
            : base("name=hospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cita> cita { get; set; }
        public virtual DbSet<consulta> consulta { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<paciente> paciente { get; set; }
        public virtual DbSet<receta> receta { get; set; }
        public virtual DbSet<visita> visita { get; set; }
    }
}