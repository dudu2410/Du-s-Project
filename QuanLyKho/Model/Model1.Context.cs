﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLKEntities : DbContext
    {
        public QLKEntities()
            : base("name=QLKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hanghoa> hanghoas { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<kho> khoes { get; set; }
        public virtual DbSet<phieunhap> phieunhaps { get; set; }
        public virtual DbSet<phieuxuat> phieuxuats { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}