﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diagram
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class my_db_for_db_2Entities : DbContext
    {
        public my_db_for_db_2Entities()
            : base("name=my_db_for_db_2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BrandSC> BrandSC { get; set; }
        public virtual DbSet<Breakage> Breakage { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoriesSC> CategoriesSC { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsShops> GoodsShops { get; set; }
        public virtual DbSet<Makers> Makers { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<Provide> Provide { get; set; }
        public virtual DbSet<ProvideOrder> ProvideOrder { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceCenter> ServiceCenter { get; set; }
        public virtual DbSet<ServiceTransportation> ServiceTransportation { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<Shops> Shops { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Transportation> Transportation { get; set; }
    }
}
