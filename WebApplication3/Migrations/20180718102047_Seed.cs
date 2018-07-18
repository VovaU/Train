﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT Into Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT Into Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT Into Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make1-ModelA',1)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make1-ModelB',1)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make1-ModelC',1)");

            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make2-ModelA',2)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make2-ModelB',2)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make2-ModelC',2)");

            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make3-ModelA',3)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make3-ModelB',3)");
            migrationBuilder.Sql("INSERT Into Models (Name, MakeId) VALUES ('Make3-ModelC',3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Make WHERE Name IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
