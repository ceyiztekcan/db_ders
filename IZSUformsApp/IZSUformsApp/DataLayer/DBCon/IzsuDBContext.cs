namespace IZSUformsApp.DataLayer.DBCon
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IzsuDBContext : DbContext
    {
        public IzsuDBContext()
            : base("name=IzsuDB")
        {
        }

        public virtual DbSet<Abone> Abone { get; set; }
        public virtual DbSet<AboneTuru> AboneTuru { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
    }
}