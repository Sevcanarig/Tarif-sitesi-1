using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarifApp.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    KullanıcıId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullanıcıAd = table.Column<string>(type: "TEXT", nullable: true),
                    KullanıcıSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    Eposta = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.KullanıcıId);
                });

            migrationBuilder.CreateTable(
                name: "yemekler",
                columns: table => new
                {
                    YemekId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yemekler", x => x.YemekId);
                });

            migrationBuilder.CreateTable(
                name: "YemekKayitlari",
                columns: table => new
                {
                    KayitId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullanıcıId = table.Column<int>(type: "INTEGER", nullable: false),
                    YemekId = table.Column<int>(type: "INTEGER", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKayitlari", x => x.KayitId);
                    table.ForeignKey(
                        name: "FK_YemekKayitlari_Kullanıcılar_KullanıcıId",
                        column: x => x.KullanıcıId,
                        principalTable: "Kullanıcılar",
                        principalColumn: "KullanıcıId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekKayitlari_yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "yemekler",
                        principalColumn: "YemekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YemekKayitlari_KullanıcıId",
                table: "YemekKayitlari",
                column: "KullanıcıId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekKayitlari_YemekId",
                table: "YemekKayitlari",
                column: "YemekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YemekKayitlari");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "yemekler");
        }
    }
}
