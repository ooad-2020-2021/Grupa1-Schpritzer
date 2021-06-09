using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Imunizacija21.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolest",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doktor = table.Column<string>(nullable: false),
                    DatumDijagnoze = table.Column<DateTime>(nullable: false),
                    BolestTip = table.Column<string>(nullable: false),
                    Tip = table.Column<int>(nullable: true),
                    Oboljenja_Tip = table.Column<int>(nullable: true),
                    Ustanova = table.Column<string>(nullable: true),
                    OpisDijagnoze = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CovidTest",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TipCovidTesta = table.Column<int>(nullable: false),
                    DatumTestiranja = table.Column<DateTime>(nullable: false),
                    Rezultat = table.Column<bool>(nullable: false),
                    OpisTesta = table.Column<string>(nullable: false),
                    Lokacija = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidTest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Doza",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Primljena = table.Column<bool>(nullable: false),
                    Lokacija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doza", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vakcina",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Efikanost = table.Column<double>(nullable: false),
                    BrojDostupnih = table.Column<int>(nullable: false),
                    BrojIskoristenih = table.Column<int>(nullable: false),
                    KratkiOpis = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    VrijemeMedjuDozama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakcina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vakcinacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VakcinaID = table.Column<int>(nullable: true),
                    PrvaDozaID = table.Column<int>(nullable: true),
                    DrugaDozaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakcinacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vakcinacija_Doza_DrugaDozaID",
                        column: x => x.DrugaDozaID,
                        principalTable: "Doza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vakcinacija_Doza_PrvaDozaID",
                        column: x => x.PrvaDozaID,
                        principalTable: "Doza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vakcinacija_Vakcina_VakcinaID",
                        column: x => x.VakcinaID,
                        principalTable: "Vakcina",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CovidKarton",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VakcinacijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidKarton", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CovidKarton_Vakcinacija_VakcinacijaID",
                        column: x => x.VakcinacijaID,
                        principalTable: "Vakcinacija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Spol = table.Column<string>(nullable: false),
                    JMBG = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    OsobaTip = table.Column<string>(nullable: false),
                    ZdravstvenaKartica = table.Column<string>(nullable: true),
                    CovidKartonID = table.Column<int>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Zanimanje = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Osoba_CovidKarton_CovidKartonID",
                        column: x => x.CovidKartonID,
                        principalTable: "CovidKarton",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DatumZahtjeva = table.Column<DateTime>(nullable: false),
                    OdobrenZahtjev = table.Column<bool>(nullable: true),
                    StrucnaOsobaID = table.Column<int>(nullable: false),
                    ZahtjevTip = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    TipCovidTesta = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Osoba_StrucnaOsobaID",
                        column: x => x.StrucnaOsobaID,
                        principalTable: "Osoba",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VakcinaZahtjevZaVakcinaciju",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VakcinaID = table.Column<int>(nullable: false),
                    ZahtjevZaVakcinacijuID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VakcinaZahtjevZaVakcinaciju", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VakcinaZahtjevZaVakcinaciju_Vakcina_VakcinaID",
                        column: x => x.VakcinaID,
                        principalTable: "Vakcina",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VakcinaZahtjevZaVakcinaciju_Zahtjev_ZahtjevZaVakcinacijuID",
                        column: x => x.ZahtjevZaVakcinacijuID,
                        principalTable: "Zahtjev",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZahtjevFacade",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ZahtjevZaTestiranjeID = table.Column<int>(nullable: true),
                    ZahtjevZaVakcinacijuID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtjevFacade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ZahtjevFacade_Zahtjev_ZahtjevZaTestiranjeID",
                        column: x => x.ZahtjevZaTestiranjeID,
                        principalTable: "Zahtjev",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZahtjevFacade_Zahtjev_ZahtjevZaVakcinacijuID",
                        column: x => x.ZahtjevZaVakcinacijuID,
                        principalTable: "Zahtjev",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CovidKarton_VakcinacijaID",
                table: "CovidKarton",
                column: "VakcinacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_CovidKartonID",
                table: "Osoba",
                column: "CovidKartonID");

            migrationBuilder.CreateIndex(
                name: "IX_Vakcinacija_DrugaDozaID",
                table: "Vakcinacija",
                column: "DrugaDozaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vakcinacija_PrvaDozaID",
                table: "Vakcinacija",
                column: "PrvaDozaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vakcinacija_VakcinaID",
                table: "Vakcinacija",
                column: "VakcinaID");

            migrationBuilder.CreateIndex(
                name: "IX_VakcinaZahtjevZaVakcinaciju_VakcinaID",
                table: "VakcinaZahtjevZaVakcinaciju",
                column: "VakcinaID");

            migrationBuilder.CreateIndex(
                name: "IX_VakcinaZahtjevZaVakcinaciju_ZahtjevZaVakcinacijuID",
                table: "VakcinaZahtjevZaVakcinaciju",
                column: "ZahtjevZaVakcinacijuID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_StrucnaOsobaID",
                table: "Zahtjev",
                column: "StrucnaOsobaID");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjevFacade_ZahtjevZaTestiranjeID",
                table: "ZahtjevFacade",
                column: "ZahtjevZaTestiranjeID");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjevFacade_ZahtjevZaVakcinacijuID",
                table: "ZahtjevFacade",
                column: "ZahtjevZaVakcinacijuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bolest");

            migrationBuilder.DropTable(
                name: "CovidTest");

            migrationBuilder.DropTable(
                name: "VakcinaZahtjevZaVakcinaciju");

            migrationBuilder.DropTable(
                name: "ZahtjevFacade");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "CovidKarton");

            migrationBuilder.DropTable(
                name: "Vakcinacija");

            migrationBuilder.DropTable(
                name: "Doza");

            migrationBuilder.DropTable(
                name: "Vakcina");
        }
    }
}
