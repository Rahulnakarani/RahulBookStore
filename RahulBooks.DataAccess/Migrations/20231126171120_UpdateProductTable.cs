﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RahulBooks.DataAccess.Migrations
{
    public partial class UpdateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverType_CategoryId",
                table: "Products");


            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products",
                column: "CoverTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverType_CoverTypeId",
                table: "Products",
                column: "CoverTypeId",
                principalTable: "CoverType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverType_CoverTypeId",
                table: "Products");


            migrationBuilder.DropColumn(
                name: "Price50",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverType_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CoverType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
