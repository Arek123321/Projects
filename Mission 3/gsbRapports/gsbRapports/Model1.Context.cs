﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gsbRapports
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gsbrapports2021Entities : DbContext
    {
        public gsbrapports2021Entities()
            : base("name=gsbrapports2021Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<famille> famille { get; set; }
        public DbSet<medecin> medecin { get; set; }
        public DbSet<medicament> medicament { get; set; }
        public DbSet<offrir> offrir { get; set; }
        public DbSet<rapport> rapport { get; set; }
        public DbSet<visiteur> visiteur { get; set; }
    }
}
