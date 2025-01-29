﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddImgToCast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Casts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Casts");
        }
    }
}
