﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Urun_Satis_Uygulama
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EF_UrunEntities : DbContext
    {
        public EF_UrunEntities()
            : base("name=EF_UrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Kategoriler> Tbl_Kategoriler { get; set; }
        public virtual DbSet<Tbl_Musteriler> Tbl_Musteriler { get; set; }
        public virtual DbSet<Tbl_Satislar> Tbl_Satislar { get; set; }
        public virtual DbSet<Tbl_Urunler> Tbl_Urunler { get; set; }
        public virtual DbSet<Tbl_Adminler> Tbl_Adminler { get; set; }
    
        public virtual ObjectResult<string> Markagetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Markagetir");
        }
    }
}
