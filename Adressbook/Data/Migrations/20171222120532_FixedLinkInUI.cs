using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Adressbook.Data.Migrations
{
    public partial class FixedLinkInUI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdressID",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "AdressName",
                table: "Adresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressID",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "AdressName",
                table: "Adresses",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
