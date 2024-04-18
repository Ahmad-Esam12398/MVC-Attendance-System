using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class fixiden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "62d5febe-d7d8-4009-9bb4-a5b378fabd61", "CS", "74805450653474", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "bfd3c975-4884-4085-b771-1b58f7ccf6df", "IS", "68226683670016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "02922881-b3fb-4601-8b87-ad5d4419d836", "F", "76130441715863", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "6611bcfe-01c7-4732-b088-d0a192f0c695", "CS", "77151052581211", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "73e01fb0-337b-4153-ba44-b913b97bfea9", "IS", "32336308343215", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "0be2ef3f-4cd1-40f2-bcb5-a966dd033106", "IS", "M", "16142388662618", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "ebdf97a9-d773-4e37-9df4-b239a530272d", "47828743736362", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "0d340114-d9ed-4d12-a85f-369c8005144d", "M", "48577562147376", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "0b74c975-32c0-4f89-a0fe-517451d00cf4", "45773808260733", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "54cb2a41-0c60-4d58-8584-664e9d4b334c", "IS", "F", "72827363747251", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "e01e59be-9918-4a1c-959f-bb9742997d4d", "CS", "48567704115475", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a8067d04-bc1f-4624-b294-c26b673e2505", "Accounting", "F", "43444375242517", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "fe77e7cf-ea5c-4265-95c6-e0eb1017c098", "CS", "68302126607288", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ca327113-9fe5-4b62-a114-90bef887e807", "Accounting", "18311363384274", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "0655b488-afb2-456e-b322-38c193c6120d", "F", "31656722283444", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9cdcc25f-07f2-4883-bd28-2ba64029af66", "CS", "65254266040005", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "491c0524-e34e-4fcc-83ed-5d372a398d4e", "Accounting", "53333358008157", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "b5127860-0adf-4c0b-84e8-6433557a8009", "M", "54037008555048", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "a4d50874-18c9-4fd2-b4bb-097d0c308cce", "CS", "52245632762720", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "f5b42c41-4410-4042-ac9f-9a6e91198fd5", "Accounting", "85611203533141", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f7849006-e78c-4924-ab41-38fd66d03a3c", "Engineering", "F", "16626554041807", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "f28b08c2-ea3e-4ae3-a569-a89501202efe", "Engineering", "12145481444354", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f99af1df-2f21-48ec-8748-5f4d940399d8", "Accounting", "F", "76703183716476", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "905e0668-c3db-41e1-af5c-bacdad3ac62d", "Accounting", "F", "68347157215001", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "948b13de-ee32-4f85-b1ad-318316c09eda", "CS", "F", "25876016212335", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "e0479cd1-2dd8-4400-9815-5e37f42b42dc", "Accounting", "F", "32434552873124", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "b42bc015-6ec8-44e4-b080-0c62634db889", "CS", "F", "72620757771547", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5a1d9d7d-bcd5-40e6-be15-c5331f56cd3d", "Engineering", "F", "26462603630162", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "afe4dcc8-d7c4-4fee-89f7-5f7894e5bffd", "75014386686705", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "897a31cf-665a-4d9d-a39f-efa01383c6ef", "Engineering", "67172178262158", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "18eec3df-5a9f-4082-a3fa-29a3789b4de0", "87706848537650", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "8def840f-c412-4c38-aaa5-c9302d454114", "CS", "F", "72242405436472", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "b1028bc6-03ae-4539-ae10-45ee7d7b5da0", "CS", "F", "62821284547654", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e9019874-075b-44e6-818a-2e8728daee2a", "Accounting", "F", "48118145133273", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c468c111-519f-4246-a53d-ca253804912a", "CS", "M", "16308443440687", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "b33d86f7-b5b0-41b9-b3d7-f737bec4fc2d", "42717462338546", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "d5a59ae2-bfd3-4043-b33e-0193fb743f1c", "Accounting", "F", "77103237383226", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "92501245-557b-4441-9261-6719e779d6e9", "Engineering", "14550316288623", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "17bf5c70-df17-4448-909e-a7a2826853d2", "CS", "M", "75812210774342", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId" },
                values: new object[] { "16c973ad-8096-4030-986d-bbf5dc7d5c60", "Accounting", "M", "40768736687276" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "1e5678d1-9648-4f99-9e6f-266085697154", "IS", "M", "72634100512255", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "9d013b79-a6e7-4495-b16e-296dd832c32a", "IS", "61081425052325", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ffe9a376-e25e-4957-a283-942349eaeb21", "Engineering", "22612547511477", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "07a62390-9a40-4151-917e-072caff2e64c", "Accounting", "F", "74743565861671", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "2dc00451-79d9-4ba1-975b-ef938a36a4cf", "IS", "F", "66872153355535", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "d1d3c9cc-fa7b-4eff-826f-10802a6c731f", "46733630818730", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "NationalId" },
                values: new object[] { "7dbdc817-fd57-4a5b-91bc-d13e95a863c1", "75820712227788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "0c5d460a-d2e7-4d1b-9549-4651497e285f", "CS", "15086742002114", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "b0cd69c5-70bd-4620-8a28-77d2864c105a", "48266143405318", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "a5bcff3e-aa54-4e03-bfbd-da85d13e5369", "Accounting", "M", "55714125432020", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "02c28be0-5949-4c5f-a41a-5f70f4a5fc4c", "46522112423866", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "0728d5a0-eb20-47f1-9ddf-3fc8afda53e4", "F", "18766257611381", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "00598e31-bae7-4b90-a2a1-c96685ca13a0", "CS", "M", "24473725176207", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "2a2e4c3d-97b4-49ff-85f6-7ff09de327a0", "IS", "46611285603107", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "ff60e466-50c2-4cc5-ae56-cbf9cef68cda", "Accounting", "M", "82364434584201", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "fe87b1d9-1d2d-424d-9329-27ceb102766f", "CS", "56804616301341", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "167ee2c7-f22c-4dea-99ef-fb92d3a3cd6c", "CS", "57123023668650", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "79081849-e241-43f6-89f6-46fb11be3d7e", "Engineering", "32816364663303", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "e2199a0e-ce77-4e38-b249-6aaee8fa63dd", "Accounting", "80264350744478", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "88a893e7-e925-4d21-9183-1003292a11bf", "IS", "M", "60114522405662", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "30286bd3-20fb-485e-8567-8a72246912ab", "Engineering", "45074166564750", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e5a1c59c-5829-44e5-847b-1617594340e2", "CS", "M", "45068242530728", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "8fabb0cf-816d-4b2d-9534-b72a34c0e57c", "66061553751733", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "76c68df3-6035-4270-ba98-dca426a9e857", "IS", "M", "13542751044683", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "7a928f4f-44c7-41ff-ac69-7720adfb83cd", "Engineering", "M", "22236876637047", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c09ee692-1120-496c-92c5-37eacd3f04f9", "IS", "33260170413622", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "59f2c6d0-0bce-4aea-a4d5-4007dface1fd", "Accounting", "F", "16781115815287", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "8a9b183b-34ee-4668-87e0-e057c32ca215", "CS", "F", "15021886577351", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "4db166c2-c15e-49c5-897f-07e0c4c1b34f", "IS", "F", "28042456083015", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "993ea179-bfc2-4762-b235-face3cc6e17c", "CS", "15484456501885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "3c518b9a-3ac2-48df-8482-a817f45ef720", "Engineering", "M", "48681662044826", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "59076c52-aa83-4b75-8573-9cd4c82c8813", "Accounting", "F", "78603010106403", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "e19a7747-f6d3-4f63-9063-d274481db030", "48204422588266", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "6a7811fe-de27-49e0-b44c-d68352966178", "CS", "74336246011075", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "e4117ba9-5270-48f9-a8bf-91c095bd7e2f", "Accounting", "13732672222111", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ad228fda-31c2-4532-b275-b5f06827f943", "Engineering", "M", "71222865530342", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "d2fc77d9-449d-4e9f-9172-64166f3270ec", "Engineering", "F", "75845342652853", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "8fd9b21f-4f42-4d27-b616-2c0679240fe3", "IS", "M", "75210530627731", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "9ff59396-0eeb-49ae-8084-03a5f551a83b", "IS", "F", "66321420373130", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "ConcurrencyStamp", "NationalId" },
                values: new object[] { "6d00a597-d945-4a14-b56e-72cda430c93b", "28822180162001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ef2164e0-1e4b-4d0d-979b-583bc7d7550a", "F", "77142180821718", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "59a47dcc-784e-45ea-adec-fe57fe93bc6c", "CS", "76241104761103", 3, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "fb2661ec-274e-4f0a-999b-6827cb649ab5", "IS", "M", "38723725745263", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "6a274b1d-385f-4b5c-9049-d348813315e1", "IS", "44348123302505", 1, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "e412ca58-dabf-428b-88ab-c967c77c2dc2", "Engineering", "M", "35357354232110", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "036dc620-152b-4185-a582-ada28301bfb2", "Accounting", "F", "15421134733505", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "3a862f29-0189-4e84-9cca-4b799072c351", "M", "11666771203758", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "901a411b-e108-4692-a6a6-2644356f4523", "F", "54444460461385", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "cb3ab128-3eb1-4e14-ac5a-2cf38d00ee9a", "Engineering", "F", "55111244522006", 2, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "bc0636f1-915b-4057-b708-44343fa13b80", "IS", "57018054077171", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "d7bc1b01-3506-40b6-b570-4d331a658749", "F", "83527781751501", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "831ee0e2-1a4d-45fc-ba8b-44f1cdea59c3", "Engineering", "36707585343525", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "f319bf3f-ef10-4315-aa35-e885ac5429b2", "Engineering", "F", "78255773676174", 3, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ee6b9332-e8f6-4e10-8e0c-bb2dc177b27c", "CS", "M", "81545727053317", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -5,
                column: "ConcurrencyStamp",
                value: "37fd8b2d-4efb-454d-81e5-9064ba42576a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -4,
                column: "ConcurrencyStamp",
                value: "ab800b44-f002-4aad-8dd1-76d00f266d91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "3b691052-e4b7-4349-834a-c00eb256f1e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "9db50e57-5588-42c0-8405-2e1a22db131c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "352fa022-19c7-48a6-945e-484a3cf4e871");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 53, 16, 532, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 53, 16, 532, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 53, 16, 532, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 53, 16, 532, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 16), -1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 16, 21, 53, 16, 532, DateTimeKind.Local).AddTicks(7574));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "23902be4-8b8d-423b-b1a3-27268fa19e3d", "IS", "40088522356205", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "28cf85b0-7e28-4460-a39a-3c2248fd566f", "Engineering", "56451010582432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "c0a561a5-7f84-43df-aed3-d31400122c83", "M", "78327704314815", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "51a8417c-9caf-4139-953a-d4022fcbe915", "Engineering", "60245870427875", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "5440fb17-8875-421c-8ebc-9398493088be", "Accounting", "12661188484440", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "eda3a99c-3bfa-4030-ba1e-927bc2749960", "Engineering", "F", "58525012561736", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "269cf115-e85b-43b0-9125-d4890adf9d82", "23625425022307", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "University" },
                values: new object[] { "22744be6-02ba-4d35-a7a5-152d7b6d3024", "F", "15243650223682", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "4969cc5e-9084-4eaf-8b3c-3e4e4edfeaf8", "42402831371455", 4, "Zagazig" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "d0e62320-b040-46f9-a49b-c9e2fa731f93", "Engineering", "48587387826702", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "0dfb605d-b95a-4719-aadc-fd31505b6306", "Engineering", "M", "10588434780428", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "f8929bcd-c19e-4587-b942-c8cbe9d7fe2d", "Accounting", "31553656015220", "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "92fae72a-747c-45c8-941e-e9671a541ecc", "Engineering", "82101425425325", 4, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "57c326f9-b07c-4f8d-bd65-23e6337c1174", "M", "56140628423026", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "a7978347-7fc3-44af-9dbb-bee19b4d52d8", "IS", "32366150272752", 5, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "04c1d9d5-5ed2-4e20-aeb8-6b97b99eb754", "IS", "53074251838106", 3, "Zagazig" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "153b5bb6-c046-465c-9067-57276e0fc8b2", "Accounting", "23802816860401", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c62a61ac-b1bf-4d2a-874b-4c5aae9b8015", "CS", "38224727555173", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ac9c9dd0-225d-4b2c-8d15-a79e1eff3db1", "IS", "M", "43174504267382", 2, "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c00db365-15a0-41ed-956d-495c7e6c3811", "Accounting", "57363361088620", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "28c920fb-f148-49b7-a8d4-477c8cebb90d", "CS", "M", "67304363701808", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "59e44c49-a96d-48f9-b11d-a3adf6c4f408", "CS", "M", "54637343204026", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "2abf6d71-bf1c-4216-8c4d-add748a36967", "Accounting", "M", "67181168364410", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "acaf6599-3a76-40f7-8133-78300d2e5783", "CS", "M", "25006781251531", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "faec51c6-2931-4eab-9489-88ad68cef8e1", "Accounting", "M", "35387512138368", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "6d87ef80-e783-4e45-9bbd-cc2b4ee153aa", "Accounting", "M", "65072723341053", 4, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "349543da-ab20-4758-8227-96045ccf7a9a", "66057822481205", 4, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "ce7a8a3c-3f3b-4a29-991a-c242839633a3", "IS", "76555248267388", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "a372df14-a55a-48cf-981a-a51ca8ac18e2", "30714356060600", "Tanta" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "b29aa77c-5d7d-4d7d-8335-fdbc81958c66", "CS", "M", "75746163161874", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "8388d5e0-fa99-4c08-959c-281f0640fc3f", "IS", "F", "68574764474744", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "896cc6f3-0ecd-4408-9391-b5a35f8c0f0d", "44303278048374", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "b98dcf56-9cca-40fe-af04-2289a48570ca", "IS", "M", "16351787637472", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "82ab3a52-40f3-42a6-92aa-bb0d11a1d692", "Accounting", "67486356857073", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "fbbd2ed4-7809-481b-a99f-a76fdc77d585", "IS", "F", "68676560086584", 2, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId" },
                values: new object[] { "63e57090-01ba-4f26-b0a8-07f55d4255bf", "CS", "F", "38837600864803" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "8ebc1ac9-15a0-4b60-a35b-5b51efc52f38", "CS", "F", "14570381861148", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "343c3b75-1c82-428a-8ad9-435d99ba1a84", "CS", "13774883180001", 3, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "ffb426ec-7385-48c6-8679-3adfbf3a93ef", "IS", "35367753683008", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "45879a16-80c7-4c8e-b5d5-a8a50975221f", "IS", "M", "53778614436240", 4, "AinShams" });

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
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "2a13e755-64ac-436b-a753-ae7949dc108d", "44847573813701", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "ConcurrencyStamp", "NationalId" },
                values: new object[] { "5613fd1e-8fff-4d2d-976f-cc10eae339e3", "15410662757360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "852509c7-c269-4d38-8d0a-8e7550d2bf06", "IS", "74784738018848", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "eb6f954f-219a-4c8a-b993-de21d4439730", "12057180265651", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "cb219c1e-e127-466e-bc74-23e3c0796f1e", "CS", "F", "14232230056147", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "ConcurrencyStamp", "NationalId", "University" },
                values: new object[] { "04b69db0-6729-4900-859c-8b30d31cc4b6", "40628654346205", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "96e3832a-ddfd-436c-b4e3-9db3af251f38", "M", "43285025568042", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "e8c4331c-253d-4b0a-aef8-dacf7abbe8ee", "Accounting", "F", "68341010143406", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "8bef47d4-919a-4201-9d37-8e2e4878aee2", "CS", "14537385375366", 5, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "03f249e1-280c-482a-b198-e134283efabc", "Engineering", "F", "56666167214404", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "8c822066-06ac-46ef-ae9d-1429f39bedc4", "Engineering", "34280122805413", "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "b3a0cfe8-9597-4942-aad6-e816c9f9aeb8", "Accounting", "52171550262464", 5, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "a9f02600-da40-4aba-8e55-7339901f4dd5", "CS", "34113388827700", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID" },
                values: new object[] { "cd37c532-754c-4db8-8c0c-0f4d565ef465", "Engineering", "38018343863577", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "a087f2fd-7f84-46fa-bcf2-d47c40b1801b", "Engineering", "F", "26683124803461", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "University" },
                values: new object[] { "353dbf49-fcee-43c8-9316-c72c5ece0dc6", "CS", "72166724565232", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "b1a1a670-cf15-4348-bad0-35f20ebd8c9d", "Engineering", "F", "27416320725281", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID", "University" },
                values: new object[] { "47164d7d-13a0-4b64-a505-4d5a1040397f", "22515788401823", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "ee0d7d5d-f61c-4909-8025-564aaa9fa609", "Engineering", "F", "28600373757522", 1, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "9649fb06-7788-4973-90fb-1ea5e5cd21e3", "IS", "F", "71146427805413", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c58d7830-cc6e-481a-a805-b6d72394fec8", "CS", "86746154267287", 5, "Mansoura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "a1e47915-b98a-40e8-ac94-982e61caff47", "Engineering", "M", "50868847718674", 2, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "dbd4b7b1-12e5-4b18-82ea-4f46015f3fde", "Accounting", "M", "65126535472203", 5, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "46885247-405c-498b-823d-6d48f9574962", "Engineering", "M", "24750222555757", 4, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId" },
                values: new object[] { "7ebc418b-e690-4d64-9b24-fe4206d602ce", "Engineering", "23687255106662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "d7993b8a-f299-4777-af39-f2f022dbfa5f", "CS", "F", "10368271648681", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "506cac1e-24ab-4bd8-a253-3aadb084957d", "IS", "M", "51035665823805", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "ConcurrencyStamp", "NationalId", "TrackID" },
                values: new object[] { "2871c5b5-01b4-4797-a5fd-12ff9a25fea8", "76582541011681", 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "c334e91a-0f36-4772-be9a-778e9bec6e48", "Accounting", "53520474120543", 4, "Mansoura" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "9361e8c0-cd9e-4f57-8e50-c3815d7e7217", "CS", "F", "25725621575016", 1, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "6a28f4d6-3db1-4c4f-a675-550f0907e667", "Accounting", "M", "27457812352461", "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "db4cee9e-15b6-4841-929a-4ba52c827295", "Accounting", "F", "34812083474026", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "b14b155f-7113-462f-8dd7-e0339f7a04ba", "Engineering", "M", "22818160420384", "Tanta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "ConcurrencyStamp", "NationalId" },
                values: new object[] { "dba8db6d-166a-4e13-aceb-c0ea90b20dd6", "17610432557484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "53e763fe-9b79-4348-b999-63a672f57ef4", "M", "68455468135500", 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "0c88d642-e737-4190-9fad-8fe90e1ffa54", "Engineering", "66251542107742", 4, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "University" },
                values: new object[] { "9f53c4dd-2346-49bc-964f-db15ada7aa9c", "Engineering", "F", "64327844068731", "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "2b550b8f-e983-436d-bd72-4c87655f69a9", "CS", "21333102367171", 3, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "1b48001e-0943-4b51-8214-b47957a3e007", "CS", "F", "51371661221468", 1, "Cairo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "5d32a966-3f8b-4119-b205-82832928af8c", "IS", "M", "84585750432113", 3, "AinShams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID" },
                values: new object[] { "ec3f32de-1cb1-4c64-b963-1289a67007d8", "F", "16564105734444", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "ConcurrencyStamp", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "0b458c93-b8b7-4210-adb1-0389314a0b0a", "M", "35431645860472", 1, "Mansoura" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "NationalId", "TrackID", "University" },
                values: new object[] { "60c1435d-dee6-4944-9feb-a02798f6b88d", "CS", "76577301515624", 1, "Zagazig" });

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
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID", "University" },
                values: new object[] { "df7256c9-7db9-4ca9-9ee3-43ca6535f18c", "Accounting", "M", "51753858282443", 2, "Zagazig" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ConcurrencyStamp", "Faculty", "Gender", "NationalId", "TrackID" },
                values: new object[] { "a2fdf1e5-ad5c-4f82-a5eb-b77a2dd3d28d", "Accounting", "F", "67832456683274", 2 });

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
    }
}
