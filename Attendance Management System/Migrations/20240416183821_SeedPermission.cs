using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class SeedPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "3c006269-c49c-4c5d-8d37-59344dbe7da2", "IS", "M", "44682408778516", 2, "AinShams" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "bd1128fb-98a1-4c20-95da-8c765f8d0bae", "Engineering", "75236063207317", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "cf096cb6-26be-419b-a11a-061e1363b230", "CS", "F", "65346008870005", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "ce9e9e2a-97e3-48fd-a64c-49f723c77e02", "11103236505635", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "17ae1577-2e80-44c5-9eed-0ebc180cac1b", "CS", "M", "21752167055415", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "84f6be59-83f0-4e35-b72e-928110aa2327", "F", "11117362157372", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "d7c95092-4108-4fd7-9d02-47f34c22b5e6", "Engineering", "M", "17005335043114", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5cb674f6-9160-48bf-8e7e-4e9169875714", "M", "37407788628700", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "062e90ac-ac2b-4799-aade-2a58f6cc0a78", "IS", "55103301352523", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "b7066016-0f2f-486d-a47d-72818ffeb049", "71801266874205", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "1506bb3c-d114-4ca0-89dd-48a8e0241e07", "IS", "M", "16368062521047", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "14150390-abc2-4a96-a08e-d9e9b8c2c79d", "72447044208630", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e2727452-d8a2-4252-b104-0a5c0fa7d5dc", "M", "25357617858325", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b7ec75a0-bf4b-47f7-be48-01c49e109257", "Engineering", "75241615451873", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "8949f133-84e4-4e43-aca9-a36ac9bd33ff", "Accounting", "74578226678066", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "3d44158c-f630-47f1-9f88-9fd6a39a65d3", "IS", "52415717168647", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "015112c3-0f37-4afc-bc4a-f4293455e538", "M", "22517302517014", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId" },
                values: new object[] { "4f817f01-6868-4e42-a7f0-66dff9391ddb", "M", "17764763214412" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "9b02440e-0ce9-4a04-862f-4265eaa7584d", "CS", "M", "74682575167681", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "bc673e0a-8e67-49cf-b408-d99c1d5c8f7f", "M", "76045331876876", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "0b9d0746-e7e6-4ea0-a45a-f9185240cfe2", "66773787440275", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "2a49fffb-d67e-45ea-98ee-d86bd171ee5d", "IS", "M", "54230001515618", 4, "AinShams" });

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
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "d28c8b0c-416a-4b2b-a5d3-944621b858e5", "76875218611348", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "9cfbc400-3fd2-4a90-b1b0-83dac7329d66", "73003063742436", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "8077a729-8a9f-4b37-8be9-086dfa8023e2", "Accounting", "72606612845352", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a4870e8c-14fb-44d5-a780-504c2a781ebb", "Accounting", "M", "45511161146182", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "624ad00b-2388-4d4b-ad02-f649905e01bc", "Engineering", "M", "78862351484361", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ebd6f876-f2d4-49d9-9940-a8cbdd89d755", "F", "47203118442218", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "3c756b7c-23ec-479d-8845-27de2a2ec36b", "82178513478356", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "a7c84a41-4b25-41fb-b0de-67ed3f2bd27c", "Accounting", "42062107657348", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "3306c356-62bc-42df-a927-d013124f2c4b", "CS", "F", "51416767263885", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "972b2c7a-d74c-43fc-bbf5-e0b223bb7a3b", "Engineering", "M", "11171386803855", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "45a41fab-0595-438d-ba2e-5786d7f7d596", "IS", "22470465635057", 4 });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "4e32a7e5-e37d-4250-8bc2-bea3ce30c844", "IS", "47810263453186", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "0d616695-f0a3-434c-b2ff-d7babb6c45c1", "Accounting", "31757576655170", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ebf1f18e-0a92-49d5-91a6-e5fd5732829d", "IS", "F", "64186176805081", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "22111e76-d250-4d66-b06b-9094a79c10d9", "M", "84217708347751", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e2e38180-2ded-4c56-8865-1a1d00a01950", "CS", "F", "27158777625886", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ad97b986-d797-4929-9b2a-1cd5f566e4d6", "IS", "M", "26565627228018", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "a28eebf3-f6de-4335-82d9-0b275fc97aae", "CS", "34410878856655" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "414bb176-33ff-4bdc-8c14-4b2da9efc498", "IS", "M", "60775671522635", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c7f0027e-15fe-4772-a88b-42b5fc061352", "IS", "47304500842850", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "1a24b4a9-84c8-483a-9ea5-5b9f3c886a92", "Accounting", "F", "21427706107866", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "21a85502-f65c-4ca5-97ee-f4f25b7046a6", "CS", "M", "77154113750538", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "0786cc63-4b31-4468-a153-3f84b5111447", "Accounting", "M", "42145022351705", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "47b76ca3-65bf-4d4d-a2ae-c798ec6f1a17", "Engineering", "M", "73310843525660", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "692ce71f-0da0-46ee-9380-f2cfb244bd54", "IS", "35738804276785", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "09972d28-9353-4c1f-a1b5-d39ddedc10b5", "CS", "13227012388107", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ed548e73-96f0-4419-8819-c7795e8b771b", "IS", "30852216168308", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "aac4dfa0-5bf0-41f6-bff6-d773d3bb70de", "F", "13373678137481", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "522697b7-150a-4024-a09d-bdb4ba8603a8", "CS", "M", "37341807113375", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c07bcb8a-dc05-4f08-819b-7c56dbf130b3", "F", "80324284620111", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9912bfd7-7bab-41f0-9c46-442aed7764ac", "CS", "41555626026243", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "eb5d3a9d-dc8b-465b-9a92-bb6a0d936a37", "F", "23580035057015", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "33f8be46-ce4b-437d-8c9b-6a4960fa9214", "CS", "M", "75834713824552", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "7cbeaf08-17bc-4d23-85ac-d736ac7732b8", "IS", "F", "11286884630543", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b27697bc-41ab-4c9e-b580-c511cc2e2496", "IS", "25034773781184", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "7f4aa314-2e0c-4eb9-8eea-4cfbcfe92ee8", "IS", "68733351371681", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "61d55137-cc57-4d41-89d8-397994e2df67", "Engineering", "32721470517485", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "752aef2c-da0d-4e02-bc75-7a776f75875c", "M", "66280238551435", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "153a150d-98c7-43f8-be48-0c022ab7ce00", "CS", "F", "38757002808780", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "853d89f3-ebb4-49ef-8404-1baeda8eb54c", "87841133613015", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "1a916205-115b-4afe-b9e5-012147fef44a", "CS", "63358854176664", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "2b4b4dcd-6020-43c2-bee9-c5964b185d6c", "Accounting", "M", "77842348806687", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "49145553-fd4c-4600-aaa1-f321eee6c81f", "F", "85816185287008", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "288df62a-267d-4c63-ae37-87cdac2d02f5", "M", "42760114380218", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "5d5338c5-70ec-4ed8-885f-4807865f5446", "Engineering", "M", "63512803606856", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "afc4f87b-58b8-4f12-9947-59ecd3147540", "CS", "F", "84135685443852", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "7f8a3fbb-3339-461a-b4af-57ce5c2ac18f", "IS", "52845516322484", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "7fab0656-867e-42a3-af5b-d88b2f60a362", "CS", "12684571660874", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "1e658a45-5e5c-4702-8817-f39b1df44862", "CS", "F", "45578035174544", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "68e950c7-d027-44f6-81ce-dc56a7dbd370", "M", "66643767863753", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "7ec116ac-3078-4b21-9445-ca3903301ba0", "F", "17201025143748", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "3920582e-396b-4af1-8b7c-eb8b7613366f", "IS", "72047304325575", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "92039c4e-8344-47fe-acf9-39b4c9e899fa", "CS", "24671572816752", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "63cb2be2-cf84-4175-a3ee-ebb596d3c078", "CS", "M", "73862453527146", 4, "Tanta" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "88922370-8d0e-4645-893b-19edb350b164", "IS", "F", "88840253621513", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "7db1af12-cc9e-429e-a5eb-1ed20c168174", "CS", "77103610348712", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "07df0228-ed33-4445-85b3-25a86115e49f", "72274516666168", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "7ffdc8da-3011-4a20-9959-5b35c4a0ed7d", "Accounting", "F", "62380117178037", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "6fba0117-2b99-4516-bb30-8645d88a8b86", "Engineering", "M", "38830772865658", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9d1b1b0b-7509-4183-9bac-a4cb21e3c68f", "CS", "33557131058506", 1, "AinShams" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d1cf9c2b-078a-4f22-b881-578a903b0f8b", "CS", "M", "54470255004753", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "8f2778b2-2d40-4862-ac5e-766bfaab17c9", "IS", "74563846207786", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "5a8273ca-c6b1-4e32-8ab4-362fd08e7180", "CS", "17701211527164", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "e5d61ba2-a303-45f9-8db3-6e4b539427a7", "IS", "62034606735865", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "fd8f9a75-8b6f-4632-b523-3ab5de1e0a3a", "Accounting", "F", "21237831466484", "Zagazig" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "91f2478b-e6fc-4558-8649-f44a7c5cc745", "IS", "F", "61583458687464", 2, "Tanta" });

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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Date", "StudentId", "BodyOfDescription", "DateCreated", "ID", "Reason", "Status" },
                values: new object[,]
                {
                    { new DateOnly(2024, 4, 16), -6, "6", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2690), 6, "6", 0 },
                    { new DateOnly(2024, 4, 16), -5, "5", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2685), 5, "5", 0 },
                    { new DateOnly(2024, 4, 16), -4, "4", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2682), 4, "4", 0 },
                    { new DateOnly(2024, 4, 16), -3, "3", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2679), 3, "3", 0 },
                    { new DateOnly(2024, 4, 16), -2, "2", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2675), 2, "2", 0 },
                    { new DateOnly(2024, 4, 16), -1, "1", new DateTime(2024, 4, 16, 20, 38, 19, 32, DateTimeKind.Local).AddTicks(2668), 1, "1", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -6 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -5 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -4 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -3 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -2 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "110a76d7-94ad-4837-b6bb-7327c4af0d5a", "Accounting", "F", "50068550263440", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d7547560-07fb-430a-b95d-884252d8c9ff", "IS", "F", "27237780042578", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "34a5c1fa-42f4-4e4d-b84f-8ad1a48f35d4", "CS", "38044140244762", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "57cbfb65-c1cc-4cbc-979d-8b1aa8437cc7", "Accounting", "M", "41051554563425", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "9051374e-1966-4791-b29a-b7bd524b478f", "73581618011036", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "276ae676-5164-44f7-aa82-03a41529dbc5", "Engineering", "F", "37267184045852", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a5292c9e-6286-4aa3-bd01-878a22fa0d84", "M", "15855610187674", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "bdc42f67-aedf-47b1-b842-46a131d4a3a4", "CS", "F", "76264338526145", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "37c341d7-d9c5-4ceb-8517-ac307e97488d", "F", "10865705810863", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "5805a6f0-8746-429f-9ce8-bbeb01631ea9", "CS", "47617434115722", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "74dbcc49-90b2-40ea-8338-1ad79e020b83", "82707007212264", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "9edc48d3-2fdf-4988-a7cd-78b92d7c5de0", "Accounting", "F", "80545378528232", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "11eea0b2-c286-453c-afac-d737d8abb8dd", "72761126747010", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d31aafc3-cf18-403d-bb02-f77e6f912ef9", "F", "81465655088388", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "e6bd372e-6365-4fb2-a009-eeafdfceecfa", "IS", "42634347542543", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ef7ac279-48f3-49d0-97e5-b0c8e917bff8", "Engineering", "73453610135632", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "75e6ca67-49c1-4b78-a306-0845365bd7c4", "CS", "85274762788282", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "6cdbdeb4-2796-40bd-b98d-435728affe97", "F", "87705361587745", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId" },
                values: new object[] { "39456615-d4fa-4ddd-a2d2-e9b770bb6def", "F", "44617665285235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "945d9d3a-0122-479c-abd8-864e1c6dbe86", "Accounting", "F", "31087706465446", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "9bb729b2-a206-4dc7-acea-0015d8beaa56", "F", "20428307024158", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "86dd6de3-0dfe-4b4b-b024-19777d6d6a01", "78554016845345", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "04f6715d-28e7-4637-bab8-742d2a43d4cd", "CS", "F", "10325027285624", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "e2ced79d-ad10-434e-b730-1a05ad15422c", "CS", "45534877723463", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "fae94e96-0938-4a5c-ab37-873be345b559", "48320311750734", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "db43fe5a-06be-4a90-9532-44db8a50a1d8", "34023730230345", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "b557a129-ea5c-464c-b129-54c0ba90737a", "CS", "55038527516385", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "89fa3af2-b218-45b0-b109-f2065945671a", "Engineering", "F", "73451630738286", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "e843b299-bbca-4246-ae63-e5cbf99f401a", "Accounting", "F", "64063758075573", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "4949830e-9eb7-4bf2-9446-bb4725a264b9", "M", "47548111676683", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "0d4d0ea2-13b9-48a0-aeed-5df00f35057e", "75301581167010", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "a85a160b-f6ad-451b-9e02-dd8a8e6f2eab", "IS", "28022427481273", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d3ef4a3b-7e1c-4277-8bf6-acb57852a943", "IS", "M", "60504185162175", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "310dacfd-cb2f-42e2-923a-7fc704821a05", "IS", "F", "16623845864830", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "128985bf-2967-4fba-967e-f1e20c56ffa5", "Accounting", "45616316460851", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9a410e5e-e7a6-4bd9-8f30-894f25aa4e82", "Accounting", "76351057685135", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "3d3757e6-e8f4-476d-8c88-359925d3da24", "Engineering", "30716660503613", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "44eb0ab0-d1ee-408e-ac33-f13f46029774", "CS", "44733585688141", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "6d317253-abf9-43cd-9a89-c26ab16a661a", "CS", "M", "82243628673562", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "934f8699-6c41-46cc-b9d6-a91100778e89", "F", "68765423451100", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "66672a4b-a6e5-41dc-9927-e487f4acadf3", "Accounting", "M", "14201516600415", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "9d884995-ae4d-45f0-b8fa-f2f02d919e18", "Accounting", "F", "46428640176805", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "9619aa92-458c-4a60-9486-3ce79b77a805", "IS", "36453740650614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "52d4d0d8-c996-4a56-8ec0-dc591657ae44", "Accounting", "F", "30454142752513", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "38c4a038-a125-4938-ba7b-b1c188266035", "Engineering", "47054253486726", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "21c9d4a1-dafc-4140-af7b-10156c015cbb", "IS", "M", "41888516237178", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "41a42ec4-414e-461f-8be8-8c3d23d30b7a", "IS", "F", "50373453665374", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "e0bc482b-0ca8-4a2a-bcba-670e85b56133", "IS", "F", "72410484042673", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "4da93b10-dc9e-4b7f-b55e-4b25ecc18cb6", "CS", "F", "42072255468885", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "0df628b6-071a-4f35-b024-b726e6906b8e", "CS", "23744045725573", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b948e93e-2f8a-470d-9638-7d9d06de4187", "Accounting", "21178508872305", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "873cdf87-f17c-49b4-a22c-31b6d74f740c", "Accounting", "83781531448875", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "89fc34a8-e72b-4937-9be9-a5164078207f", "M", "63880647112776", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "be5b647a-a0b1-4b2f-b7a5-34dcfa377ae9", "Accounting", "F", "72783707360586", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e83009f8-5ee0-4da8-b60c-51070715fb13", "M", "55880657353468", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "45218ed7-b414-4cf3-a3cf-ffbb84ec4a34", "IS", "48413402720642", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "03dc226d-10d1-4500-9620-e52f451fdb3b", "M", "76216121832152", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "520e3f2d-b858-4fe2-9604-26edd8f71513", "Accounting", "F", "86447431124571", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "83ac8b6a-eee4-4db4-b5b5-c4eb0dee7fb6", "CS", "M", "72606021400256", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "3887c4fe-c26c-4203-a703-fcd9966920e3", "Engineering", "74584733522503", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "f78fff17-3583-45e5-8012-91788dceba1a", "Engineering", "63685476406342", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "fcbc05d1-8ea9-4af6-a7dc-ed28a64b19dd", "CS", "17743222438407", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "4b14781c-9a39-4a00-9a96-a5c90994ea4e", "F", "67775125873605", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "02ed4b35-f02b-4f6f-a0f9-8fdc87d270b0", "IS", "M", "67210040144287", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "09a1a3ba-25de-44bb-89a0-f2a9ba61a95a", "17472362562632", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ce40020d-2c0e-4ff2-a270-3fc0e168f4dd", "IS", "46534215762354", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "4c51b1e6-3f7b-47b4-b7b1-bdcdd71c0d35", "CS", "F", "46005414746115", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f2b6a454-5b29-4405-be11-1ebfa38e4d98", "M", "11351058640303", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "3615fef1-0753-4613-93cc-6718d3580fc3", "F", "88540867572132", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "e006c3bc-1c0a-4325-8bf4-736ef31e6ac6", "CS", "F", "46004682057674", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "17d17868-5033-4d91-aabd-f436ee6536d6", "Engineering", "M", "17732166622482", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "a6a874c2-bbb2-4965-9b54-44a8e4800486", "CS", "80680474834688", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "37730b13-e8e0-4a78-87da-093f182e285f", "IS", "11322446317308", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "cc4dbe11-6529-4d00-89f0-2cf973f7a8b0", "Engineering", "M", "65258367772484", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5f021ff3-6183-49b8-8d01-3522c5edeea7", "F", "21504851245201", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "4bcdf4e0-b54c-453d-83b1-17ee712cdf42", "M", "85804573742362", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "e044b5c4-9c97-44db-bffb-65f9ad6ecdd4", "Accounting", "11677327755101", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "5e3bdf5c-7132-456a-aa85-a25fc6b3f809", "Engineering", "40171326572242", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ee775de4-1e84-4425-9a25-adef324e9cfc", "Accounting", "F", "57410022075708", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "4e27eac3-367e-428f-af83-e2a3582a52cd", "CS", "17047300757634", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f5f9e1d3-530f-4801-9bbc-4d083b6beba1", "CS", "M", "48546016711153", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "ba3033bb-8a6a-4aab-9950-6d8e3cd9749f", "Accounting", "66855801502138", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "6367af3b-4da6-4afa-a143-22dc925d6ec2", "15442217872600", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f193e72c-1fef-454e-93c2-44b80da43dc3", "IS", "M", "62641558874076", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "3d3d0af9-4339-46fa-8620-4efd42e4f0a6", "CS", "F", "55226441081742", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "2cf629f3-f3ef-4ea7-a2ce-cac82a54d137", "Accounting", "78303426781615", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "01b48cae-923b-444b-8dbb-8fd189f0d699", "Engineering", "F", "20457484611674", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "961e0ac5-28cb-46fc-9d0d-094292526df1", "Engineering", "F", "33536027428315", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "dd5af255-42c8-47ab-b403-9451c131dd34", "Engineering", "15480364335762", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "4b0aef9d-d57b-4131-a0f8-6aceb42715b5", "IS", "30875051756223", 1, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b1ce0515-8675-4806-931c-32d28bbe80fd", "CS", "32377826321151", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "fcf2b33a-f3b8-415c-8aa6-740d11619dd4", "IS", "M", "27167036567854", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "70b0bee9-e61e-4472-8683-7c0a9194f3c7", "12755678773788", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "2459830f-6bd8-4746-8c74-1a77dd100d7d", "CS", "M", "13140316248888", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -5,
                column: "ConcurrencyStamp",
                value: "25fcfb6d-90fe-407e-9063-8cfa244ec334");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -4,
                column: "ConcurrencyStamp",
                value: "b88cb9b6-00e3-4487-b23f-b688bcae56a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "c343c942-287b-4aed-899f-cbf0545054a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "2d12dee1-f6ac-4bd2-bb90-34ee4e69f935");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "ee96fa08-ad01-4e4a-a17f-db39ca8ac264");
        }
    }
}
