using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Title" },
                values: new object[,]
                {
                    { new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"), 3, "Chemistry" },
                    { new Guid("938a181c-d465-47fc-bbf5-bacb467619af"), 4, "Calculus" },
                    { new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"), 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "StartedOn" },
                values: new object[,]
                {
                    { new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae"), "Jane", "Doe", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f"), "John", "Doe", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("093700e2-0de6-402c-bc77-f896273bcdea"), new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"), 8, new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae") },
                    { new Guid("1dcf0e5b-bdb9-4a48-b250-eb42ea60a6d6"), new Guid("938a181c-d465-47fc-bbf5-bacb467619af"), 8, new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f") },
                    { new Guid("32063aa2-e689-4a1a-913c-9655b3521029"), new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"), 8, new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f") },
                    { new Guid("7a2dbbdd-30e5-4469-814f-3083e3f2fabd"), new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"), 15, new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f") },
                    { new Guid("d2f7a963-77cb-4125-a703-1e202a11e97e"), new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"), 11, new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae") },
                    { new Guid("ed87c9d4-9cd2-4b02-bd73-bf6409a55018"), new Guid("938a181c-d465-47fc-bbf5-bacb467619af"), 8, new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("093700e2-0de6-402c-bc77-f896273bcdea"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("1dcf0e5b-bdb9-4a48-b250-eb42ea60a6d6"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("32063aa2-e689-4a1a-913c-9655b3521029"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("7a2dbbdd-30e5-4469-814f-3083e3f2fabd"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("d2f7a963-77cb-4125-a703-1e202a11e97e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ed87c9d4-9cd2-4b02-bd73-bf6409a55018"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("938a181c-d465-47fc-bbf5-bacb467619af"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f"));
        }
    }
}
