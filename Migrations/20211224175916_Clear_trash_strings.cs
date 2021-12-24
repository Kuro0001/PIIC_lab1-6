using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiDemo.Migrations
{
    public partial class Clear_trash_strings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Directions_DirectionId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Categorys_CategoryId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Hotels_HotelId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Kinds_KindId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TourOperators_TourOperatorId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_Clients_ClientId",
                table: "Vouchers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_Employees_EmployeeId",
                table: "Vouchers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_Tours_TourId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_ClientId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_EmployeeId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_TourId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_HotelId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_KindId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TourOperatorId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_DirectionId",
                table: "Hotels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_ClientId",
                table: "Vouchers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_EmployeeId",
                table: "Vouchers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_TourId",
                table: "Vouchers",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_HotelId",
                table: "Tours",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_KindId",
                table: "Tours",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourOperatorId",
                table: "Tours",
                column: "TourOperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_DirectionId",
                table: "Hotels",
                column: "DirectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Directions_DirectionId",
                table: "Hotels",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Categorys_CategoryId",
                table: "Tours",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Hotels_HotelId",
                table: "Tours",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Kinds_KindId",
                table: "Tours",
                column: "KindId",
                principalTable: "Kinds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TourOperators_TourOperatorId",
                table: "Tours",
                column: "TourOperatorId",
                principalTable: "TourOperators",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_Clients_ClientId",
                table: "Vouchers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_Employees_EmployeeId",
                table: "Vouchers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_Tours_TourId",
                table: "Vouchers",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
