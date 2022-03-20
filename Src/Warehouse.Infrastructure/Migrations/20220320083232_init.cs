using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wharehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unitPrice = table.Column<double>(type: "float", nullable: false),
                    product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wharehouses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wharehouses");
        }
    }
}
