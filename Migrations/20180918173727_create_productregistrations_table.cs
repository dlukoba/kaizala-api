using Microsoft.EntityFrameworkCore.Migrations;

namespace safkaizalaapi.Migrations
{
    public partial class create_productregistrations_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("productregistrations", 
            columns: table => new 
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("MySql:ValueGeneratedOnAdd", true),
                ProductName = table.Column<string>(nullable: false, maxLength: 200),
                ProductActivationReady = table.Column<string>(nullable: false, maxLength: 10),
                Latitude = table.Column<double>(nullable: true),
                Longitude = table.Column<double>(nullable: true),
                LocationDescription = table.Column<string>(nullable: true, maxLength: 100),
                SenderId = table.Column<System.Guid>(nullable: false),
                SenderName = table.Column<string>(nullable: false, maxLength: 200),
                SenderPhoneNumber = table.Column<string>(nullable: false, maxLength: 20),
                CorrelationId = table.Column<string>(nullable: false, maxLength: 50),
                CustomerId = table.Column<int>(nullable: false)
            }, constraints: table => 
            {
                table.PrimaryKey("PK_Productregistrations", pk => pk.Id);
                table.ForeignKey("FK_ProductRegistration_CustomerId_Customer_Id", l => l.CustomerId, "customers", "Id", null, ReferentialAction.NoAction);
            });
            migrationBuilder.Sql("ALTER TABLE `productregistrations` ENGINE = InnoDB;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
