﻿// <auto-generated />
using System;
using Imunizacija21.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imunizacija21.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Imunizacija21.Models.Bolest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BolestTip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CovidKartonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumDijagnoze")
                        .HasColumnType("datetime");

                    b.Property<string>("Doktor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Bolest");

                    b.HasDiscriminator<string>("BolestTip").HasValue("Bolest");
                });

            modelBuilder.Entity("Imunizacija21.Models.CovidKarton", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("VakcinacijaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CovidKarton");
                });

            modelBuilder.Entity("Imunizacija21.Models.CovidTest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CovidKartonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumTestiranja")
                        .HasColumnType("datetime");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OpisTesta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("Rezultat")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TipCovidTesta")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CovidTest");
                });

            modelBuilder.Entity("Imunizacija21.Models.Doza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<string>("Lokacija")
                        .HasColumnType("text");

                    b.Property<bool>("Primljena")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Doza");
                });

            modelBuilder.Entity("Imunizacija21.Models.Osoba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("text");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ime")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JMBG")
                        .HasColumnType("varchar(13)")
                        .HasMaxLength(13);

                    b.Property<int>("LokalnaZdravstvenaUstanova")
                        .HasColumnType("int");

                    b.Property<string>("OsobaTip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prezime")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Spol")
                        .HasColumnType("text");

                    b.Property<bool>("Ulogovan")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Osoba");

                    b.HasDiscriminator<string>("OsobaTip").HasValue("Osoba");
                });

            modelBuilder.Entity("Imunizacija21.Models.Vakcina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrojDostupnih")
                        .HasColumnType("int");

                    b.Property<int>("BrojIskoristenih")
                        .HasColumnType("int");

                    b.Property<double>("Efikanost")
                        .HasColumnType("double");

                    b.Property<string>("KratkiOpis")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasColumnType("text");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<int>("VrijemeMedjuDozama")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vakcina");
                });

            modelBuilder.Entity("Imunizacija21.Models.VakcinaZahtjevZaVakcinaciju", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("VakcinaID")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevZaVakcinacijuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("VakcinaZahtjevZaVakcinaciju");
                });

            modelBuilder.Entity("Imunizacija21.Models.Vakcinacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DrugaDozaID")
                        .HasColumnType("int");

                    b.Property<int>("PrvaDozaID")
                        .HasColumnType("int");

                    b.Property<int>("StrucnaOsobaID")
                        .HasColumnType("int");

                    b.Property<int>("TipVakcine")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vakcinacija");
                });

            modelBuilder.Entity("Imunizacija21.Models.Zahtjev", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CovidKartonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumZahtjeva")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<bool?>("OdobrenZahtjev")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("StrucnaOsobaID")
                        .HasColumnType("int");

                    b.Property<string>("ZahtjevTip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Zahtjev");

                    b.HasDiscriminator<string>("ZahtjevTip").HasValue("Zahtjev");
                });

            modelBuilder.Entity("Imunizacija21.Models.ZahtjevFacade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ZahtjevZaTestiranjeID")
                        .HasColumnType("int");

                    b.Property<int?>("ZahtjevZaVakcinacijuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ZahtjevZaTestiranjeID");

                    b.HasIndex("ZahtjevZaVakcinacijuID");

                    b.ToTable("ZahtjevFacade");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Imunizacija21.Models.Alergija", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Bolest");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Alergija");
                });

            modelBuilder.Entity("Imunizacija21.Models.Oboljenja", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Bolest");

                    b.Property<string>("OpisDijagnoze")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Tip")
                        .HasColumnName("Oboljenja_Tip")
                        .HasColumnType("int");

                    b.Property<string>("Ustanova")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Oboljenja");
                });

            modelBuilder.Entity("Imunizacija21.Models.Korisnik", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Osoba");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CovidKartonID")
                        .HasColumnType("int");

                    b.Property<int>("Zanimanje")
                        .HasColumnType("int");

                    b.Property<string>("ZdravstvenaKartica")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.HasDiscriminator().HasValue("Korisnik");
                });

            modelBuilder.Entity("Imunizacija21.Models.StrucnaOsoba", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Osoba");

                    b.HasDiscriminator().HasValue("StrucnaOsoba");
                });

            modelBuilder.Entity("Imunizacija21.Models.ZahtjevZaTestiranje", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Zahtjev");

                    b.Property<string>("Opis")
                        .HasColumnType("text");

                    b.Property<int>("TipCovidTesta")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("ZahtjevZaTestiranje");
                });

            modelBuilder.Entity("Imunizacija21.Models.ZahtjevZaVakcinaciju", b =>
                {
                    b.HasBaseType("Imunizacija21.Models.Zahtjev");

                    b.HasDiscriminator().HasValue("ZahtjevZaVakcinaciju");
                });

            modelBuilder.Entity("Imunizacija21.Models.ZahtjevFacade", b =>
                {
                    b.HasOne("Imunizacija21.Models.ZahtjevZaTestiranje", "ZahtjevZaTestiranje")
                        .WithMany()
                        .HasForeignKey("ZahtjevZaTestiranjeID");

                    b.HasOne("Imunizacija21.Models.ZahtjevZaVakcinaciju", "ZahtjevZaVakcinaciju")
                        .WithMany()
                        .HasForeignKey("ZahtjevZaVakcinacijuID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
