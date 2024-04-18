using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class fixingIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -6 });

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "23902be4-8b8d-423b-b1a3-27268fa19e3d", "40088522356205", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "28cf85b0-7e28-4460-a39a-3c2248fd566f", "Engineering", "F", "56451010582432", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c0a561a5-7f84-43df-aed3-d31400122c83", "IS", "M", "78327704314815", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "51a8417c-9caf-4139-953a-d4022fcbe915", "Engineering", "60245870427875", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5440fb17-8875-421c-8ebc-9398493088be", "M", "12661188484440", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "eda3a99c-3bfa-4030-ba1e-927bc2749960", "Engineering", "F", "58525012561736", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "269cf115-e85b-43b0-9125-d4890adf9d82", "IS", "23625425022307", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "22744be6-02ba-4d35-a7a5-152d7b6d3024", "F", "15243650223682", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "4969cc5e-9084-4eaf-8b3c-3e4e4edfeaf8", "42402831371455", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "dd387c14-f3a6-46ff-afad-8f27ebf34f8d", "CS", "M", "42670637280448", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "d0e62320-b040-46f9-a49b-c9e2fa731f93", "Engineering", "M", "48587387826702", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "0dfb605d-b95a-4719-aadc-fd31505b6306", "Engineering", "10588434780428", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "f8929bcd-c19e-4587-b942-c8cbe9d7fe2d", "Accounting", "31553656015220", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "92fae72a-747c-45c8-941e-e9671a541ecc", "Engineering", "82101425425325", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "57c326f9-b07c-4f8d-bd65-23e6337c1174", "IS", "M", "56140628423026", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "a7978347-7fc3-44af-9dbb-bee19b4d52d8", "IS", "F", "32366150272752", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "04c1d9d5-5ed2-4e20-aeb8-6b97b99eb754", "F", "53074251838106", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "4e7b6f57-70f3-4e52-8745-74bd03307d55", "F", "24503055085633", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "153b5bb6-c046-465c-9067-57276e0fc8b2", "F", "23802816860401", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "c62a61ac-b1bf-4d2a-874b-4c5aae9b8015", "38224727555173", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ac9c9dd0-225d-4b2c-8d15-a79e1eff3db1", "IS", "43174504267382", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c00db365-15a0-41ed-956d-495c7e6c3811", "F", "57363361088620", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "28c920fb-f148-49b7-a8d4-477c8cebb90d", "CS", "67304363701808", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "59e44c49-a96d-48f9-b11d-a3adf6c4f408", "CS", "54637343204026", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "2abf6d71-bf1c-4216-8c4d-add748a36967", "67181168364410", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "acaf6599-3a76-40f7-8133-78300d2e5783", "CS", "25006781251531", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "faec51c6-2931-4eab-9489-88ad68cef8e1", "35387512138368", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "6d87ef80-e783-4e45-9bbd-cc2b4ee153aa", "65072723341053", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "349543da-ab20-4758-8227-96045ccf7a9a", "F", "66057822481205", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ce7a8a3c-3f3b-4a29-991a-c242839633a3", "IS", "76555248267388", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a372df14-a55a-48cf-981a-a51ca8ac18e2", "IS", "M", "30714356060600", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ae82f00e-ba43-4939-8bab-1b6eb0ade1a9", "Engineering", "M", "61262513175103", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ab123633-dd0b-4da5-b177-2a4e0a594403", "Engineering", "M", "60866623284723", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b29aa77c-5d7d-4d7d-8335-fdbc81958c66", "CS", "75746163161874", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "8388d5e0-fa99-4c08-959c-281f0640fc3f", "68574764474744", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "896cc6f3-0ecd-4408-9391-b5a35f8c0f0d", "Accounting", "44303278048374", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "b98dcf56-9cca-40fe-af04-2289a48570ca", "16351787637472", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "82ab3a52-40f3-42a6-92aa-bb0d11a1d692", "67486356857073", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "fbbd2ed4-7809-481b-a99f-a76fdc77d585", "68676560086584", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "63e57090-01ba-4f26-b0a8-07f55d4255bf", "CS", "F", "38837600864803", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "8ebc1ac9-15a0-4b60-a35b-5b51efc52f38", "14570381861148", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "343c3b75-1c82-428a-8ad9-435d99ba1a84", "CS", "F", "13774883180001", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "ffb426ec-7385-48c6-8679-3adfbf3a93ef", "IS", "35367753683008", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "45879a16-80c7-4c8e-b5d5-a8a50975221f", "53778614436240", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "386f9174-8529-4cb5-9f44-4ad1b73ddb35", "Engineering", "M", "30267173280147", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "2a13e755-64ac-436b-a753-ae7949dc108d", "44847573813701", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "5613fd1e-8fff-4d2d-976f-cc10eae339e3", "Engineering", "15410662757360", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "852509c7-c269-4d38-8d0a-8e7550d2bf06", "IS", "74784738018848", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "eb6f954f-219a-4c8a-b993-de21d4439730", "CS", "12057180265651", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "cb219c1e-e127-466e-bc74-23e3c0796f1e", "CS", "F", "14232230056147", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "04b69db0-6729-4900-859c-8b30d31cc4b6", "IS", "M", "40628654346205", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "96e3832a-ddfd-436c-b4e3-9db3af251f38", "CS", "M", "43285025568042", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "e8c4331c-253d-4b0a-aef8-dacf7abbe8ee", "68341010143406", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "8bef47d4-919a-4201-9d37-8e2e4878aee2", "14537385375366", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "03f249e1-280c-482a-b198-e134283efabc", "Engineering", "56666167214404", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "8c822066-06ac-46ef-ae9d-1429f39bedc4", "Engineering", "M", "34280122805413", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "b3a0cfe8-9597-4942-aad6-e816c9f9aeb8", "Accounting", "52171550262464", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "a9f02600-da40-4aba-8e55-7339901f4dd5", "34113388827700", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "cd37c532-754c-4db8-8c0c-0f4d565ef465", "Engineering", "38018343863577", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "a087f2fd-7f84-46fa-bcf2-d47c40b1801b", "Engineering", "F", "26683124803461", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "353dbf49-fcee-43c8-9316-c72c5ece0dc6", "CS", "72166724565232", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "b1a1a670-cf15-4348-bad0-35f20ebd8c9d", "27416320725281", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "47164d7d-13a0-4b64-a505-4d5a1040397f", "CS", "22515788401823", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ee0d7d5d-f61c-4909-8025-564aaa9fa609", "Engineering", "28600373757522", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9649fb06-7788-4973-90fb-1ea5e5cd21e3", "IS", "71146427805413", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "c58d7830-cc6e-481a-a805-b6d72394fec8", "86746154267287", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "a1e47915-b98a-40e8-ac94-982e61caff47", "Engineering", "50868847718674", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "dbd4b7b1-12e5-4b18-82ea-4f46015f3fde", "Accounting", "M", "65126535472203", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "46885247-405c-498b-823d-6d48f9574962", "Engineering", "24750222555757", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "7ebc418b-e690-4d64-9b24-fe4206d602ce", "F", "23687255106662", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "d7993b8a-f299-4777-af39-f2f022dbfa5f", "10368271648681", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "506cac1e-24ab-4bd8-a253-3aadb084957d", "51035665823805", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "2871c5b5-01b4-4797-a5fd-12ff9a25fea8", "F", "76582541011681", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c334e91a-0f36-4772-be9a-778e9bec6e48", "Accounting", "M", "53520474120543", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "d40a1d1b-2f18-4baa-beed-06f978f7f509", "Engineering", "58870473028316", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9361e8c0-cd9e-4f57-8e50-c3815d7e7217", "CS", "25725621575016", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "6a28f4d6-3db1-4c4f-a675-550f0907e667", "Accounting", "M", "27457812352461", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "db4cee9e-15b6-4841-929a-4ba52c827295", "Accounting", "F", "34812083474026", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "b14b155f-7113-462f-8dd7-e0339f7a04ba", "Engineering", "22818160420384", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "dba8db6d-166a-4e13-aceb-c0ea90b20dd6", "CS", "17610432557484", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId" },
                values: new object[] { "53e763fe-9b79-4348-b999-63a672f57ef4", "CS", "M", "68455468135500" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "0c88d642-e737-4190-9fad-8fe90e1ffa54", "Engineering", "F", "66251542107742", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9f53c4dd-2346-49bc-964f-db15ada7aa9c", "Engineering", "64327844068731", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "2b550b8f-e983-436d-bd72-4c87655f69a9", "CS", "M", "21333102367171", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "1b48001e-0943-4b51-8214-b47957a3e007", "CS", "F", "51371661221468", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "5d32a966-3f8b-4119-b205-82832928af8c", "IS", "M", "84585750432113", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ec3f32de-1cb1-4c64-b963-1289a67007d8", "Engineering", "F", "16564105734444", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "0b458c93-b8b7-4210-adb1-0389314a0b0a", "IS", "35431645860472", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ee2fdc40-1520-4a95-9921-39e02e037b30", "Accounting", "M", "22013834442272", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "60c1435d-dee6-4944-9feb-a02798f6b88d", "76577301515624", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "14427c35-55b4-409c-9927-d24148471b63", "M", "24076002362548", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "391660a6-3894-46da-aca4-07e8e5c3f797", "CS", "18488278057085", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "df7256c9-7db9-4ca9-9ee3-43ca6535f18c", "51753858282443", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "a2fdf1e5-ad5c-4f82-a5eb-b77a2dd3d28d", "Accounting", "67832456683274", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -5,
                column: "ConcurrencyStamp",
                value: "46504455-b471-41a7-9e3f-6e5ec1da538b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -4,
                column: "ConcurrencyStamp",
                value: "0f1c7fa3-c945-44bc-8489-f8546ceac64a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "c6b0a5ba-a9cc-4530-8e7d-a261ba471c4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "8b154864-76f1-4c11-b86d-1a28d6fe6ca6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "a79ffa32-01cd-4a46-8609-bd79664f9740");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 47, 40, 992, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 47, 40, 992, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 47, 40, 992, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 47, 40, 992, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 47, 40, 992, DateTimeKind.Local).AddTicks(5902));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "3c006269-c49c-4c5d-8d37-59344dbe7da2", "44682408778516", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ce29901f-0548-4d91-b529-16525c975878", "CS", "M", "31285138830665", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "bd1128fb-98a1-4c20-95da-8c765f8d0bae", "Engineering", "F", "75236063207317", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "cf096cb6-26be-419b-a11a-061e1363b230", "CS", "65346008870005", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ce9e9e2a-97e3-48fd-a64c-49f723c77e02", "F", "11103236505635", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "17ae1577-2e80-44c5-9eed-0ebc180cac1b", "CS", "M", "21752167055415", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "84f6be59-83f0-4e35-b72e-928110aa2327", "CS", "11117362157372", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d7c95092-4108-4fd7-9d02-47f34c22b5e6", "M", "17005335043114", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "5cb674f6-9160-48bf-8e7e-4e9169875714", "37407788628700", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "062e90ac-ac2b-4799-aade-2a58f6cc0a78", "IS", "F", "55103301352523", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "b7066016-0f2f-486d-a47d-72818ffeb049", "IS", "F", "71801266874205", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "1506bb3c-d114-4ca0-89dd-48a8e0241e07", "IS", "16368062521047", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "14150390-abc2-4a96-a08e-d9e9b8c2c79d", "Engineering", "72447044208630", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "e2727452-d8a2-4252-b104-0a5c0fa7d5dc", "CS", "25357617858325", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "b7ec75a0-bf4b-47f7-be48-01c49e109257", "Engineering", "F", "75241615451873", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "8949f133-84e4-4e43-aca9-a36ac9bd33ff", "Accounting", "M", "74578226678066", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "3d44158c-f630-47f1-9f88-9fd6a39a65d3", "M", "52415717168647", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "015112c3-0f37-4afc-bc4a-f4293455e538", "M", "22517302517014", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "4f817f01-6868-4e42-a7f0-66dff9391ddb", "M", "17764763214412", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "9b02440e-0ce9-4a04-862f-4265eaa7584d", "74682575167681", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "bc673e0a-8e67-49cf-b408-d99c1d5c8f7f", "CS", "76045331876876", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "0b9d0746-e7e6-4ea0-a45a-f9185240cfe2", "M", "66773787440275", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "2a49fffb-d67e-45ea-98ee-d86bd171ee5d", "IS", "54230001515618", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "959ba974-9be8-4b72-9cda-d2bfc1ba6538", "Accounting", "17230576144541", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "d28c8b0c-416a-4b2b-a5d3-944621b858e5", "76875218611348", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9cfbc400-3fd2-4a90-b1b0-83dac7329d66", "IS", "73003063742436", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "8077a729-8a9f-4b37-8be9-086dfa8023e2", "72606612845352", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "a4870e8c-14fb-44d5-a780-504c2a781ebb", "45511161146182", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "624ad00b-2388-4d4b-ad02-f649905e01bc", "M", "78862351484361", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ebd6f876-f2d4-49d9-9940-a8cbdd89d755", "CS", "47203118442218", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "3c756b7c-23ec-479d-8845-27de2a2ec36b", "Accounting", "F", "82178513478356", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a7c84a41-4b25-41fb-b0de-67ed3f2bd27c", "Accounting", "F", "42062107657348", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "3306c356-62bc-42df-a927-d013124f2c4b", "CS", "F", "51416767263885", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "972b2c7a-d74c-43fc-bbf5-e0b223bb7a3b", "Engineering", "11171386803855", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "45a41fab-0595-438d-ba2e-5786d7f7d596", "22470465635057", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "88c8ec4a-a194-49e7-a2bd-a6a16be0a5b9", "Engineering", "43161020535551", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "4e32a7e5-e37d-4250-8bc2-bea3ce30c844", "47810263453186", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "0d616695-f0a3-434c-b2ff-d7babb6c45c1", "31757576655170", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "ebf1f18e-0a92-49d5-91a6-e5fd5732829d", "64186176805081", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "22111e76-d250-4d66-b06b-9094a79c10d9", "IS", "M", "84217708347751", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "e2e38180-2ded-4c56-8865-1a1d00a01950", "27158777625886", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ad97b986-d797-4929-9b2a-1cd5f566e4d6", "IS", "M", "26565627228018", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "a28eebf3-f6de-4335-82d9-0b275fc97aae", "CS", "34410878856655", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "414bb176-33ff-4bdc-8c14-4b2da9efc498", "60775671522635", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c7f0027e-15fe-4772-a88b-42b5fc061352", "IS", "F", "47304500842850", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "1a24b4a9-84c8-483a-9ea5-5b9f3c886a92", "21427706107866", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "21a85502-f65c-4ca5-97ee-f4f25b7046a6", "CS", "77154113750538", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "0786cc63-4b31-4468-a153-3f84b5111447", "Accounting", "42145022351705", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "47b76ca3-65bf-4d4d-a2ae-c798ec6f1a17", "Engineering", "73310843525660", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "692ce71f-0da0-46ee-9380-f2cfb244bd54", "IS", "M", "35738804276785", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "09972d28-9353-4c1f-a1b5-d39ddedc10b5", "CS", "F", "13227012388107", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ed548e73-96f0-4419-8819-c7795e8b771b", "IS", "F", "30852216168308", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "aac4dfa0-5bf0-41f6-bff6-d773d3bb70de", "13373678137481", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "522697b7-150a-4024-a09d-bdb4ba8603a8", "37341807113375", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c07bcb8a-dc05-4f08-819b-7c56dbf130b3", "CS", "80324284620111", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "9912bfd7-7bab-41f0-9c46-442aed7764ac", "CS", "F", "41555626026243", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "eb5d3a9d-dc8b-465b-9a92-bb6a0d936a37", "CS", "23580035057015", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "33f8be46-ce4b-437d-8c9b-6a4960fa9214", "75834713824552", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "7cbeaf08-17bc-4d23-85ac-d736ac7732b8", "IS", "11286884630543", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "b27697bc-41ab-4c9e-b580-c511cc2e2496", "IS", "M", "25034773781184", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "7f4aa314-2e0c-4eb9-8eea-4cfbcfe92ee8", "IS", "68733351371681", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "61d55137-cc57-4d41-89d8-397994e2df67", "32721470517485", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "752aef2c-da0d-4e02-bc75-7a776f75875c", "Accounting", "66280238551435", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "153a150d-98c7-43f8-be48-0c022ab7ce00", "CS", "38757002808780", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "853d89f3-ebb4-49ef-8404-1baeda8eb54c", "Accounting", "87841133613015", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "1a916205-115b-4afe-b9e5-012147fef44a", "63358854176664", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "2b4b4dcd-6020-43c2-bee9-c5964b185d6c", "Accounting", "77842348806687", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "49145553-fd4c-4600-aaa1-f321eee6c81f", "Engineering", "F", "85816185287008", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "288df62a-267d-4c63-ae37-87cdac2d02f5", "IS", "42760114380218", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5d5338c5-70ec-4ed8-885f-4807865f5446", "M", "63512803606856", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "afc4f87b-58b8-4f12-9947-59ecd3147540", "84135685443852", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "7f8a3fbb-3339-461a-b4af-57ce5c2ac18f", "52845516322484", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "7fab0656-867e-42a3-af5b-d88b2f60a362", "M", "12684571660874", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "1e658a45-5e5c-4702-8817-f39b1df44862", "CS", "F", "45578035174544", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "68e950c7-d027-44f6-81ce-dc56a7dbd370", "IS", "66643767863753", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "7ec116ac-3078-4b21-9445-ca3903301ba0", "IS", "17201025143748", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "3920582e-396b-4af1-8b7c-eb8b7613366f", "IS", "F", "72047304325575", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "92039c4e-8344-47fe-acf9-39b4c9e899fa", "CS", "M", "24671572816752", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "63cb2be2-cf84-4175-a3ee-ebb596d3c078", "CS", "73862453527146", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "92a93f4e-531b-4342-b102-ddde49569651", "IS", "60532511147174", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId" },
                values: new object[] { "88922370-8d0e-4645-893b-19edb350b164", "IS", "F", "88840253621513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "7db1af12-cc9e-429e-a5eb-1ed20c168174", "CS", "M", "77103610348712", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "07df0228-ed33-4445-85b3-25a86115e49f", "IS", "72274516666168", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "7ffdc8da-3011-4a20-9959-5b35c4a0ed7d", "Accounting", "F", "62380117178037", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "6fba0117-2b99-4516-bb30-8645d88a8b86", "Engineering", "M", "38830772865658", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "9d1b1b0b-7509-4183-9bac-a4cb21e3c68f", "CS", "F", "33557131058506", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "73ca9e41-fd36-46e9-8c86-43bd60b8f371", "CS", "M", "88601144346632", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "d1cf9c2b-078a-4f22-b881-578a903b0f8b", "CS", "54470255004753", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "8f2778b2-2d40-4862-ac5e-766bfaab17c9", "IS", "F", "74563846207786", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "5a8273ca-c6b1-4e32-8ab4-362fd08e7180", "17701211527164", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e5d61ba2-a303-45f9-8db3-6e4b539427a7", "F", "62034606735865", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "fd8f9a75-8b6f-4632-b523-3ab5de1e0a3a", "Accounting", "21237831466484", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "fc7d2f74-ccda-4893-adbc-7be927512d15", "88760018023147", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "91f2478b-e6fc-4558-8649-f44a7c5cc745", "IS", "61583458687464", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -5,
                column: "ConcurrencyStamp",
                value: "f14aed1f-7a29-4ff9-95e6-1275726eefd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -4,
                column: "ConcurrencyStamp",
                value: "2a063154-3a70-4e9c-abbc-c60545803083");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "d08d2608-3e37-418f-8aaf-382f09ea1e08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "0409f2e3-5040-44e2-b01f-6f1e4183e373");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "eba91544-ab4d-40af-b042-5e3aa1c7a073");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Date", "StudentId", "BodyOfDescription", "DateCreated", "ID", "Reason", "Status" },
                values: new object[] { new DateOnly(2024, 4, 16), -6, "6", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2690), 6, "6", 0 });
        }
    }
}
