using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDApp.Migrations
{
    public partial class ADDResto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
                table: "Personnes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Restos",
                columns: table => new
                {
                    RestoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restos", x => x.RestoId);
                });

            migrationBuilder.CreateTable(
                name: "Sondages",
                columns: table => new
                {
                    SondageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sondages", x => x.SondageId);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestoId = table.Column<int>(nullable: true),
                    PersonneId = table.Column<int>(nullable: true),
                    SondageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteId);
                    table.ForeignKey(
                        name: "FK_Votes_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Restos_RestoId",
                        column: x => x.RestoId,
                        principalTable: "Restos",
                        principalColumn: "RestoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Sondages_SondageId",
                        column: x => x.SondageId,
                        principalTable: "Sondages",
                        principalColumn: "SondageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "PersonneId", "Adresse", "CodePostal", "Mail", "Nom", "Prenom", "Telephone", "Ville" },
                values: new object[,]
                {
                    { 1, "Allée Reaumure", 26000, "dialloabdou26@gmail.com", "DIALLO", "Abdou", "06 16 43 28 73", "Valence" },
                    { 2, "5C Eugene Varlin", 93000, "barryami26@gmail.com", "Barry", "Aminata", "06 13 43 75 83", "Montreuil" },
                    { 3, "3 martin Guemou", 13000, "alybah26@gmail.com", "Bah", "Aly", "06 13 66 75 23", "Marseil" },
                    { 4, "13 allée clotures", 33000, "MSow26@gmail.com", "Sow", "Moussa", "06 43 53 15 73", "Grenoble" },
                    { 5, "13 allée des Martirs", 73000, "Mcamara26@gmail.com", "Camara", "Amara", "06 43 15 15 73", "Paris" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PersonneId",
                table: "Votes",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_RestoId",
                table: "Votes",
                column: "RestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_SondageId",
                table: "Votes",
                column: "SondageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Restos");

            migrationBuilder.DropTable(
                name: "Sondages");

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "PersonneId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "PersonneId", "Adresse", "CodePostal", "Mail", "Nom", "Prenom", "Telephone", "Ville" },
                values: new object[,]
                {
                    { 1, "Allée Reaumure", 26000, "dialloabdou26@gmail.com", "DIALLO", "Abdou", "06 16 43 28 73", "Valence" },
                    { 2, "5C Eugene Varlin", 93000, "barryami26@gmail.com", "Barry", "Aminata", "06 13 43 75 83", "Montreuil" },
                    { 3, "3 martin Guemou", 13000, "alybah26@gmail.com", "Bah", "Aly", "06 13 66 75 23", "Marseil" },
                    { 4, "13 allée clotures", 33000, "MSow26@gmail.com", "Sow", "Moussa", "06 43 53 15 73", "Grenoble" },
                    { 5, "13 allée des Martirs", 73000, "Mcamara26@gmail.com", "Camara", "Amara", "06 43 15 15 73", "Paris" }
                });
        }
    }
}
