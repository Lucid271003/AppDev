﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsmAppDev.Migrations
{
    /// <inheritdoc />
    public partial class JobApp1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_AspNetUsers_ApplicationUserId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_ApplicationUserId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "JobApplications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "JobApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_ApplicationUserId",
                table: "JobApplications",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_AspNetUsers_ApplicationUserId",
                table: "JobApplications",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
