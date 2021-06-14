using Imunizacija21.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imunizacija21.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Alergija> Alergija { get; set; }
        public DbSet<Bolest> Bolest { get; set; }
        public DbSet<CovidKarton> CovidKarton { get; set; }
        public DbSet<CovidTest> CovidTest { get; set; }
        public DbSet<Doza> Doza { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Oboljenja> Oboljenja { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        //public DbSet<StatistikaKSSingleton> StatistikaKSSingletons { get; set; }
        public DbSet<StrucnaOsoba> StrucnaOsoba { get; set; }
        public DbSet<Vakcina> Vakcina { get; set; }
        public DbSet<Vakcinacija> Vakcinacija { get; set; }
        public DbSet<Zahtjev> Zahtjev { get; set; }
        public DbSet<ZahtjevFacade> ZahtjevFacade { get; set; }
        public DbSet<ZahtjevZaTestiranje> ZahtjevZaTestiranje { get; set; }
        public DbSet<ZahtjevZaVakcinaciju> ZahtjevZaVakcinaciju { get; set; }
        public DbSet<VakcinaZahtjevZaVakcinaciju> VakcinaZahtjevZaVakcinaciju { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bolest>()
                .ToTable("Bolest")
                .HasDiscriminator<string>("BolestTip")
                .HasValue<Alergija>("Alergija")
                .HasValue<Oboljenja>("Oboljenja");

            modelBuilder.Entity<Osoba>()
                .ToTable("Osoba")
                .HasDiscriminator<string>("OsobaTip")
                .HasValue<Korisnik>("Korisnik")
                .HasValue<StrucnaOsoba>("StrucnaOsoba");

            modelBuilder.Entity<Zahtjev>()
                .ToTable("Zahtjev")
                .HasDiscriminator<string>("ZahtjevTip")
                .HasValue<ZahtjevZaTestiranje>("ZahtjevZaTestiranje")
                .HasValue<ZahtjevZaVakcinaciju>("ZahtjevZaVakcinaciju");


            //modelBuilder.Entity<Alergija>().ToTable("Alergija");
            //modelBuilder.Entity<Bolest>().ToTable("Bolest");
            modelBuilder.Entity<CovidKarton>().ToTable("CovidKarton");
            modelBuilder.Entity<CovidTest>().ToTable("CovidTest");
            modelBuilder.Entity<Doza>().ToTable("Doza");
            //modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            //modelBuilder.Entity<Oboljenja>().ToTable("Oboljenja");
            //modelBuilder.Entity<Osoba>().ToTable("Osoba");
            //modelBuilder.Entity<StatistikaKSSingleton>().ToTable("StatistikaKSSingleton");
            //modelBuilder.Entity<StrucnaOsoba>().ToTable("StrucnaOsoba");
            modelBuilder.Entity<Vakcina>().ToTable("Vakcina");
            modelBuilder.Entity<Vakcinacija>().ToTable("Vakcinacija");
            //modelBuilder.Entity<Zahtjev>().ToTable("Zahtjev");
            modelBuilder.Entity<ZahtjevFacade>().ToTable("ZahtjevFacade");
            //modelBuilder.Entity<ZahtjevZaTestiranje>().ToTable("ZahtjevZaTestiranje");
            //modelBuilder.Entity<ZahtjevZaVakcinaciju>().ToTable("ZahtjevZaVakcinaciju");
            modelBuilder.Entity<VakcinaZahtjevZaVakcinaciju>().ToTable("VakcinaZahtjevZaVakcinaciju");
        }

        public DataContext getContext()
        {
            return this;
        }
    }
}
