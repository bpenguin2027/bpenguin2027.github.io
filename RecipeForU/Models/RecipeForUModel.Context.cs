﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeForU.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecipeForUEntities : DbContext
    {
        public RecipeForUEntities()
            : base("name=RecipeForUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ELEMENT> ELEMENT { get; set; }
        public virtual DbSet<eRECIPE> eRECIPE { get; set; }
        public virtual DbSet<mELEMENT> mELEMENT { get; set; }
        public virtual DbSet<rMEMBER> rMEMBER { get; set; }
        public virtual DbSet<sRECIPE> sRECIPE { get; set; }
        public virtual DbSet<MEMBER> MEMBER { get; set; }
        public virtual DbSet<RECIPE> RECIPE { get; set; }
    }
}
