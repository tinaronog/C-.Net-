﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ComputerManagerDBEntities1 : DbContext
    {
        public ComputerManagerDBEntities1()
            : base("name=ComputerManagerDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<computer> computer { get; set; }
        public DbSet<login> login { get; set; }
        public DbSet<manager> manager { get; set; }
        public DbSet<ordercompuer> ordercompuer { get; set; }
        public DbSet<sofware> sofware { get; set; }
        public DbSet<student> student { get; set; }
    }
}
