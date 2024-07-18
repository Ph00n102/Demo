using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobRequest",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReqTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPoint1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPoint2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPoint3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPoint4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPoint1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPoint2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPoint3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPoint4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrgentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoterFname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QN = table.Column<int>(type: "int", nullable: false),
                    QNName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QNAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QNSex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRequest", x => x.JobId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobRequest");
        }
    }
}
