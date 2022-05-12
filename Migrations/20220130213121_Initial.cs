using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loc",
                columns: table => new
                {
                    LocID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loc", x => x.LocID);
                });

            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    DeptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dname = table.Column<string>(nullable: false),
                    LocID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.DeptID);
                    table.ForeignKey(
                        name: "FK_Dept_Loc_LocID",
                        column: x => x.LocID,
                        principalTable: "Loc",
                        principalColumn: "LocID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(nullable: false),
                    Job = table.Column<string>(nullable: true),
                    Sal = table.Column<int>(nullable: false),
                    DeptID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_Emp_Dept_DeptID",
                        column: x => x.DeptID,
                        principalTable: "Dept",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Loc",
                columns: new[] { "LocID", "City", "Street" },
                values: new object[] { 1, "Nablus", "a1" });

            migrationBuilder.InsertData(
                table: "Loc",
                columns: new[] { "LocID", "City", "Street" },
                values: new object[] { 2, "jenin", "b3" });

            migrationBuilder.InsertData(
                table: "Dept",
                columns: new[] { "DeptID", "Dname", "LocID" },
                values: new object[] { 2, "IT", 1 });

            migrationBuilder.InsertData(
                table: "Dept",
                columns: new[] { "DeptID", "Dname", "LocID" },
                values: new object[] { 1, "CSE", 2 });

            migrationBuilder.InsertData(
                table: "Emp",
                columns: new[] { "EmpID", "DeptID", "Ename", "Job", "Sal" },
                values: new object[] { 2, 2, "Ali", "Eng", 4000 });

            migrationBuilder.InsertData(
                table: "Emp",
                columns: new[] { "EmpID", "DeptID", "Ename", "Job", "Sal" },
                values: new object[] { 1, 1, "jihad", "Eng", 2000 });

            migrationBuilder.CreateIndex(
                name: "IX_Dept_LocID",
                table: "Dept",
                column: "LocID");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_DeptID",
                table: "Emp",
                column: "DeptID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Loc");
        }
    }
}
