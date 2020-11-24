using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDApp.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
