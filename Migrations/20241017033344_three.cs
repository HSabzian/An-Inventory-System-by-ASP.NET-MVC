using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssetMaster",
                columns: new[] { "AMid", "AssetDescription", "AssetModel", "AssetName", "SerialNumber" },
                values: new object[] { 1, "Dell XPS 13", "Dell XPS", "Laptop", 601 });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Depid", "DepartmentDescription", "DepartmentName", "SerialNumber", "Status" },
                values: new object[] { 1, "Human Resources", "HR", 301, "Active" });

            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "Did", "DesignaionDescription", "DesignationName", "SerialNumber", "Status" },
                values: new object[] { 1, "Manages teams", "Manager", 201, "Active" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Lid", "LocationDescription", "LocationName", "SerialNumber", "Status" },
                values: new object[] { 1, "Headquarters", "HQ", 401, "Active" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Status", "when" },
                values: new object[] { "Active", new DateTime(2024, 10, 16, 23, 33, 44, 72, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.InsertData(
                table: "VendorMaster",
                columns: new[] { "VMid", "SerialNumber", "VendorDescription", "VendorName" },
                values: new object[] { 1, 101, "Provides hardware", "TechVendor" });

            migrationBuilder.InsertData(
                table: "AssetProcurement",
                columns: new[] { "APid", "AssetMasterId", "DeliveryDate", "PurchaseDate", "PurchaseOrder", "Quantity", "QuotationNumber", "Remark", "SerialNumber", "Status", "VendorMasterId" },
                values: new object[] { 1, 1, new DateTime(2024, 10, 23, 23, 33, 44, 72, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 10, 16, 23, 33, 44, 72, DateTimeKind.Local).AddTicks(3214), 1001, 10, 10001, "On Time", 701, "Delivered", 1 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Eid", "DateOfBirth", "DateOfJoining", "DepartmentId", "DesignationId", "Email", "EmpId", "FirstName", "LastName", "LocationId", "Phone", "Sr.No.", "Status" },
                values: new object[] { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "john.doe@example.com", 1, "John", "Doe", 1, "1234567890", 501, "Active" });

            migrationBuilder.InsertData(
                table: "AssetAquisation",
                columns: new[] { "AAid", "AssetMasterId", "EmployeeId", "ReceivedDate", "Remark", "SerialNumber", "Status", "VendorMasterId" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 10, 16, 23, 33, 44, 72, DateTimeKind.Local).AddTicks(3274), "Received Successfully", 901, "Received", 1 });

            migrationBuilder.InsertData(
                table: "AssetDeployement",
                columns: new[] { "ADid", "AssetMasterId", "DepartmentId", "EmployeeId", "IssueDate", "Remark", "SerialNumber", "Status", "VendorMasterId" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2024, 10, 16, 23, 33, 44, 72, DateTimeKind.Local).AddTicks(3245), "Deployed Successfully", 801, "Deployed", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetAquisation",
                keyColumn: "AAid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetDeployement",
                keyColumn: "ADid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetProcurement",
                keyColumn: "APid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetMaster",
                keyColumn: "AMid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Eid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VendorMaster",
                keyColumn: "VMid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Depid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designation",
                keyColumn: "Did",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Lid",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Status", "when" },
                values: new object[] { "OK", new DateTime(2024, 10, 16, 23, 1, 29, 277, DateTimeKind.Local).AddTicks(1538) });
        }
    }
}
