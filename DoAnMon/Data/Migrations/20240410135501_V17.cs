﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnMon.Data.Migrations
{
    /// <inheritdoc />
    public partial class V17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "classroomDetail",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_classroomDetail_RoleId",
                table: "classroomDetail",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_classroomDetail_AspNetRoles_RoleId",
                table: "classroomDetail",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_classroomDetail_AspNetRoles_RoleId",
                table: "classroomDetail");


            migrationBuilder.DropIndex(
                name: "IX_classroomDetail_RoleId",
                table: "classroomDetail");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "classroomDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
