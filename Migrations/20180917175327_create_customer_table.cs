using Microsoft.EntityFrameworkCore.Migrations;

namespace safkaizalaapi.Migrations
{
    public partial class create_customer_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Customers", 
            columns: table => new 
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("MySql:ValueGeneratedOnAdd", true),
                FirstName = table.Column<string>(nullable: false, maxLength: 20),
                MiddleName = table.Column<string>(nullable: true, maxLength: 20),
                Surname = table.Column<string>(nullable: false, maxLength: 20),
                IdentificationNumber = table.Column<string>(nullable: false, maxLength: 20),
                PhoneNumber = table.Column<string>(nullable: false, maxLength: 20)
            }, constraints: table => 
            {
                table.PrimaryKey("PK_Customers", pk => pk.Id);
            });
            migrationBuilder.Sql("ALTER TABLE `Customers` ENGINE = InnoDB;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
