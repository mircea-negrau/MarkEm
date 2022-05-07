using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Org.Webelopers.Api.Migrations
{
    public partial class ChangeNumberToStringAndAddStudyYearFKToGroupsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("0170e463-e46e-42c0-87af-6c782bc27514"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("4bac3c89-6139-4fbe-9375-9c3089607a4c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("57b4f3ff-0a61-4fa5-9139-d53611786dc0"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("58e48dc7-8a44-4735-b08c-2c560ed2792b"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("725d347f-f406-4a23-b414-4f277ad1e86d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("89f81462-999e-4830-83a6-3b8516753656"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("8bce7ea9-4038-4120-8603-c657e670678a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("b5e8e40a-8bff-4e8c-96b7-e4999b9721a4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("e5751c44-22b5-4e43-ab2a-e1bfa4e29876"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("e9d7ae38-013d-406c-b736-3e35f7d9efe6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("058f7b77-9016-4fbc-9923-e2472df222e6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0e79c4ab-9073-4844-9412-2ca05e174ccd"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0fd9bf3c-814c-448f-8fc9-4c20f7a536f0"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0fe5f0e3-7a56-473a-878a-440b1259b413"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("12c8fe84-65b5-4514-a535-d8d2ef478628"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1309887b-c1d0-4a34-8f8a-0e1da18143d9"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("24158d2f-dcd1-46b6-a499-a36f56fcd6de"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2a6ce067-cff5-4e0b-ac5e-96429a656939"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2f6481f2-2c36-4b31-ae4c-f69a199b8ed5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2fc0a867-8e8d-4c03-874e-376781a71a70"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("306123c2-78da-4181-af82-29bf6af4ac29"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("311ad7ba-207c-45a9-9ca1-80020d669643"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("36bed085-d8e0-40a1-96d6-dc457b5d1001"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3847944c-33e9-422b-bab1-46936bfdab2f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3a78c15c-098c-42f7-b503-3825c55ec9fa"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3cd3d43d-8afa-4d3d-95d3-05f3fccfe791"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("41dd6b6f-bb98-4c1a-996a-e52ab487f1c1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("424b0e31-f399-4daa-8b78-67e73f344c20"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("43eabc2f-83d0-4b4b-a247-9474782b6204"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("459b1d87-ed54-49a3-85e6-73ddcd2d2c8d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("47d94e98-8b3b-43f7-9a3e-b4f627586965"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4acae1fb-b2e6-448b-bf2e-754b8359b11f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4d296d04-1d3f-40d5-9e86-c437f8bd3626"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5734a0f7-dbd7-4d56-8a86-df532b9fc7e5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("57ff0870-a2dd-4fed-a2d4-9bf294fbaf6d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5c5e8638-ad78-4ea0-bd8f-224c7aa9a585"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("60440151-520e-4b06-ad34-051a1e1c1361"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("64508853-851a-4e82-b716-f0619776e8eb"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("69987b31-f1eb-40d5-84af-2f84dca00902"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6e4a7fd0-8930-4439-a51e-86bf441fa1d1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6fddec98-67b2-4776-8f4d-07365765fda6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("71eb7a0a-af66-4b30-8f05-c365f5aca593"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("72c168ec-4c85-4e8f-b0bc-606896311f8c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("762bc1e6-167e-41c4-baf1-aa3073f53ba1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("76681c28-da58-4882-b36a-b44bb3cdddb8"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7acfeb68-06a0-4037-bd7e-641f997e90b9"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("81c1218f-1831-4bc9-aec8-d3024869af24"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("82955a35-120f-4cb5-953c-cd7f5a1781b5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("879b8f2b-3aea-4030-9016-973107c37436"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("937287e7-3f4c-4b14-85f5-b194ba1b874c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("94e52d54-7818-4b48-b022-dc7bf26510c1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("98aff0cc-37d1-4f3d-8082-92fd1151d4ae"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9eb8b8f8-ce19-4116-a31b-371d0331b795"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a19c3900-d489-4ab0-ac11-16a1cea9b1c1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a45e1775-c2ea-430c-9747-71c74d397148"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a83ae8df-9272-4045-bf39-11cd740600d6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("aa851e05-52b0-4eb9-a2b4-d5b95e21e99b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("aa9109b5-fdd9-4646-bbfa-4db8e81eff66"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ab380a64-9c74-47a0-b5b3-3c22d65880cf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ad516f4a-42d4-4945-b2a9-d3ad223ca5bc"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ad948c25-d5bb-4134-97aa-62a6b1b7df26"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b069a1b6-9140-43c3-88a1-58c35dd5656d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b22c935b-41cc-4340-af72-6d46d0d34097"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("bc85d273-b676-4b58-b5ef-295db7d61139"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("bf5f9c60-6dbc-4b94-8b85-c35b22e56d4d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c78631fe-6b2c-41aa-a7bc-54b1ebbf04ba"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("cca76e73-0cd5-46ca-8eb1-af3af988b81f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d32d85df-ec83-4516-99c3-1633e0ee5d9f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d87b2128-1d53-4a04-81ad-10ee1fe0e3de"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d9fc7dd9-fa4e-4b4c-86f7-7d34cd27a1d3"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("dbfaca60-184c-40a2-8dc3-7b8c9da7c4a6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("dc062aaf-6c2e-43ea-a8ab-1d89141d2d7c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("df92f7ea-85a0-4859-98db-147e3514efbd"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e26bc60a-c128-41d8-b129-e6947c12f9de"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e29ff599-a1f2-4270-b46c-d8194cf2614e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e4982fe7-a40f-48ab-b494-e23ad1898a09"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e7825f20-a3c6-46df-b361-3c6c22d4057a"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ec247867-d7c8-49e8-b3ea-4a5914efc421"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f0c0fb75-5789-490e-8be1-46087dd5f258"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f2571fe8-976a-42b3-9cfe-bddbecc64f50"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("fcdc9766-0850-49e8-a071-57dae539189b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("fcff2ae5-a6bc-4ab7-adae-5d8aeaa75a17"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("003cbd81-eb57-43a8-a272-95bd8cda634b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("00a89520-0eae-4a19-a5fa-3ad9503dfb0e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("00da3686-7dbb-44c3-8891-89266dd87280"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("00f427f3-b319-4f99-9b59-94886f890a1c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("04c3ac48-025b-42db-9cee-12a0fcf8c00a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("05061ffc-17c7-4454-abe2-5affa6620e63"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("06cd2053-6b61-4574-9b3f-02e84d2be001"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("06d62245-1ffd-4355-991e-2a460df8de72"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0734ee8a-f38b-442a-9c4b-55a2af47baa9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0bdf9168-59da-4a54-b5e3-0327189a3361"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0c6aa87e-5986-4d32-adcf-6a5106c5ae54"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0d157fb0-a465-4cd2-9282-4b57ef03d74a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0ea15c1b-0b76-4bde-a305-c343333cfbd0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("108715c1-1ac1-4af8-8cb9-ad0406b3d183"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("10e9ba43-6bfd-4aa6-a18f-58ba2c76510f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("115b34f9-d008-4ae5-a15e-de46de593da7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11be2c71-487c-408c-805f-cc993368d481"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("13c2e56f-955a-43ea-a12a-098e475ce467"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("14a2fc7e-1e04-4f87-bf00-3ed591f8e91c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("15db5459-dcc6-4286-b48e-1c37a80f04e4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("16a1e99f-921d-4a51-b214-18e12ab16dd6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("17ab6360-ed7d-4f08-9470-a714909d9b8d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("18628480-9303-4645-b29e-d0afe273392a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("195da3d5-3b15-480c-9ab4-2ab80fc8982a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1b2acee4-6cfb-42b3-b8bf-ad41fcacbc07"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1b631419-fe61-4399-ac84-83c2e24537ef"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1c2b4397-2dc9-40f9-9fa5-d5ee4bd07ac1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1c860cc5-feb9-4420-b759-04467018e371"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1ccc402f-4fa5-4ea7-9cea-f436fd7e38b0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1d2a61d3-ed6d-4a6f-97bd-36d297d2fb7c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2199e07d-b072-4adb-aacd-f2ac846ae6be"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("231a15e4-56f8-4a58-bd40-b50d439f8031"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("23250ce8-54fc-42e6-972a-28e621b4acb5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("238ffbed-191d-43f1-a260-3ed2200c6bf7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2645a9dd-4807-4ae2-bac0-e5b5bae0fdb0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("26531397-c9d5-45cf-85a9-e87c59242590"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2845c36c-cf7d-474a-9658-2582222cf334"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("297fb969-58bd-481d-909b-cbcaae73d48f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2afc8fbd-2a43-4c0e-8785-2c01369914a0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2c806e60-6864-41dd-8d8b-c1362ed962ba"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("309dd1d1-e5da-4434-980a-a3eb866343b4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30efe5e9-6c13-4a69-ada3-5307a5c16975"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("31657031-dee9-46e1-b7a0-3ec3112e2cb6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("322a6185-1737-4aaf-ad21-e3f47f128255"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("32a14724-f7d2-4444-a23a-615371e4ccab"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("32daeb1e-a3cf-415b-828f-edbc17605f1a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("35a04558-b7ab-4153-8433-07e2c662f59f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("36acc87e-4081-4a50-bb67-a130aa042719"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("372deb35-8da6-4414-9525-da8a77a2c152"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("38b254b6-f105-4f20-b1eb-4ef81794d70a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("39ab7a2d-c013-4028-af95-db57c85bcdbc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3ae10080-a684-4c4d-a4db-324e7bebf2e2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3b3d3b6a-5a44-4e4f-8a0a-b00e992eff51"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3cade404-1f59-418b-b72f-18053b73fd84"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3cd3139c-f7c2-41ab-8268-cfcfa1658968"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3ff268d2-4fdd-4b51-bd87-987e5a7359f2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4049d820-85b0-4a52-8073-9e97ad597fd4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4084f658-c34f-4e6f-b78e-37190f0736d3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("409c1596-fed1-476f-9e7e-4fbb2e183345"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("40fdf53f-1e6f-4bf0-be73-83ed4094b8cb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("419c4517-e63f-4eaf-8765-746758f3c3d0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("41ec28a7-c84f-438e-95bf-8dac21e3fc56"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4218a945-83d8-402f-bc82-f41cc19193d6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("42973089-a0e9-4238-870c-2ab323893641"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4a7717dc-023c-4e63-9a1d-3a997a5f743e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4ae104bb-e5d0-4160-92a7-87124ed4c41b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4cb2fcf7-e095-46e9-8cc3-107bdb45558d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4ce0e911-9be3-465c-8ba6-7505a5d6e9f0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4e690a30-72d7-4387-87d8-0ed7cf443bed"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4eaffed0-4a9a-4ee8-bda4-dc88d4cf1c2a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4f0b1585-6ae3-4564-8170-7428e7878c13"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4fd8d72c-5ad9-4e45-a2df-c20b8af57914"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("50172451-8c71-432f-a03b-ff8b4dbe6de0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("502e248a-854d-4f70-8175-0054898b9822"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("50b86949-9281-4dce-812a-2c956c11571b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("50db75df-074d-4c6f-9cf6-4e7fade628e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5314969a-8c1f-4f74-81f4-d0925a3d3d7f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("56d2815e-1d8a-49c4-b21e-b6974cc3d9ab"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("56d5a9bf-61f1-4df8-bb81-b38bd46372a2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5744e6b5-b901-4e15-870a-b796b3b5237b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("579ee61f-ecb8-4613-8d98-f00f79c1747c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("58e115b1-e08d-45a7-a86d-e49a95b66178"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("597f12c6-13d0-46cf-a99c-5c82780bc829"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5a093f4e-b49b-43b7-bee2-c88ff07398a0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5a6fe4e1-3ad7-4187-8eaa-dd9b697bfdcf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5b3db105-30ea-4660-9636-0ea4a2320afa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5bec8e82-d5c7-418e-8f42-d37996fdf88f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5ecaf884-4f4a-4e8b-b099-1082dfcdb7ad"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5fc3dcfc-a1dd-4fa7-a725-e361c354db42"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("60571ccf-f23d-4cea-bbe7-d021b361c433"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6254e9f3-65e0-4456-bf94-02fdd1e856a3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("62f78b68-bd77-4ca2-8d7e-6269ff84f0ab"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("63696fff-8204-42c5-8fb6-dc752c3ed8b5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("63e342c4-18d2-43da-b16d-31e65369eb17"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("64dd9b8d-1118-4099-8d44-b4e0c5c22f6a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("65975ecb-6a2b-4158-99a9-6b184228f6c2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("669e6f79-10dd-444d-996e-1c72dc0c2b4a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("676b130b-4c1d-4e4c-95e0-38ad629edbea"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("678d6cd1-78d8-418e-9284-642514aa39c6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6ad11b7a-4789-4f3d-a4fb-a3862722b572"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6b664f78-4d98-4a8f-80fb-6ab2530c0f3a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6c135def-f576-43b9-acd1-4a6d82e18477"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6c582b7e-ce6d-42b5-915c-afa1612c1a35"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6cb7cd42-ce68-40a9-98a7-3895aad3ccff"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6e31023f-db11-4558-a2da-7b118be441a8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6f15bcbd-ce80-42ec-9b17-d68f6f1d15d0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("711f3fc5-5032-4cb1-a7e3-d86e37360f17"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("71ee15a8-160d-434a-9d1f-0d391ba80e10"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7480d127-c2a6-4360-afd1-fc3fa9373dae"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7756f456-4e8a-4bf6-9eaa-25425bdfba68"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("783dfc32-b826-44f3-8a88-fef7f1ddc3d5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("790740a3-c587-4ced-b1e0-afc519aac0a4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7a6a7c08-82aa-4e49-a052-8abac366e870"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7bfddbbe-a857-4905-9ffe-b8ea4f528cde"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7c293d52-6633-4aab-a5d8-c92774c16e40"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7c9e1b62-6060-44bc-9697-18770fb3980a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7cbcf72c-fefa-488f-a84c-64d77dade7e6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("816e6d30-6aaa-464b-b563-ea0b62ee2ce8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("81d7a2df-7236-4379-8e28-07fe120d5e06"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("82e80581-424b-4090-bc7c-a00a5e436626"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("85fd1f80-8fad-4aad-8271-3a713635acda"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("868aed83-6ccd-4b95-8b3c-8ce325d96251"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("88bc7ec9-d1cb-46e4-93e5-e597341c2797"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8902eaad-7692-482f-9d69-0d9f42522867"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8b8a0b12-9a92-410b-8de1-6e74c1430c8c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9098c9e1-b013-4fef-a6db-59ae446f9bc0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("917fb519-e58c-44f3-aad7-02de33796f33"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("91e34759-e455-4499-885f-250d4fd637ed"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("922df74f-5bdc-434e-8756-deb48fe66fff"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("932d303e-b8ef-4aeb-a0f0-92925288b231"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("94490873-8102-4582-9131-32242ec3c0d4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("97f3cfd2-b244-4f1b-a670-7a40cbc5d5fc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("98203cba-e8ac-4bb8-9e81-477762e52983"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("99323478-a136-417a-84c7-94f59c27d5f1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9af25062-cec8-4200-93ca-e32544af9443"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9b5f5711-ddc4-4d2e-ac93-456846e2cc3e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9d10e05c-59da-4b44-bef5-6ab022259628"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9d524a19-8d74-408a-9818-9b7e52b4155f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9d6aefec-348f-4c0f-b874-0a7788bc7981"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a05baa15-84c3-4549-9fa7-04ac4fdb0507"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a113e381-7bae-48a2-9335-d2ef45baad15"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a20fea42-4b30-4a41-a8e6-0ad0c716d0eb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a294b92d-9eb1-459e-ae2a-7fc4d2358290"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a2d5c7aa-6caf-46f3-906c-761517358022"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a38ce738-4778-4040-bfe3-ac895bc62f39"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a3e991ef-78e2-44eb-a98d-33df64232cb3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a45fa7c4-8cdc-4031-afe6-48865d29d774"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a4f4099c-964d-425a-8d82-25aef5b4d15e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a57eebcb-eac2-430f-8e84-3d5f8a3ed8f2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a6fbca19-c748-4bf9-a135-b7b69b4a2dc4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a998c7ba-279a-429f-bfbb-212161e31b9f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a9df57dd-4df3-4271-91f8-73532094dc4a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aa77d0fd-0fe8-4ded-8f7e-26c1a7853dca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ab166d6b-1c70-4b1e-9165-f4d145069c24"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("adf66d35-31a4-4c9b-b591-9eb839ad248d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ae71268a-a8ec-44cd-b90b-20451abdebd9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("afd32e3a-3be3-47cf-b0f6-8d50e1ba8532"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b09c1eee-3c9c-43af-a5a3-e0abe00a7380"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b0ec916a-851a-446a-874e-3f464398ce8b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b172c7c7-c9e9-48a4-a74f-cb376290878f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b2573ca7-2ae4-40b9-88bf-2ece9edbb71b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b2fe6b67-85db-44e2-ac30-8d55208e4599"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b317f7a9-908f-4602-a661-1dc5de93ebe7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b389609d-f996-4f3d-91da-a0b371bbd1e8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b3cdd346-7520-4fe6-97bd-0ddedc6cfb75"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b5b734c2-6a20-4523-bccf-88d6a1ee978d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b736b57b-050e-412b-948d-23a01505de9c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b741eb8e-d97c-41a1-a55f-fd8995a04a98"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b9435182-dcc9-4dc3-9bdb-8361b644e4a3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bb839bdf-c83b-47e6-aabf-ee14f8b68a1a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bc08f3b4-0610-4709-b7ab-c79c34b121c1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bde3c9c6-040e-4e3b-a193-6930e4b33687"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("be160f1d-3e14-4881-aef0-cb96861068fa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("be366a91-fd04-4a27-b5df-62ac1b4001cd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c10c9999-ae6d-4e8a-99d3-cf9d6d6b0c14"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c1668a6f-3947-425b-afcb-1b890bd71570"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c3474b39-1eb8-44b9-b44f-574ab8acca8e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c36e435c-2c90-4c12-a17a-b3b9df735361"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c6c22296-e6c1-4747-9734-ddbb51e33db9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c6ff74bc-1c0a-424e-9222-89fece5582f8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cae24c24-945c-40b6-a865-b03b7187a47a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cbfb19cd-0be1-4cf0-a1d6-69be4072b468"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cda2ad7f-327c-41c0-9e47-340fef9808ed"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cf54d312-ef91-4c5e-810f-9fe0514b9709"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d00e7538-9a39-473f-bdba-8b1922f79d1b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d1640f6a-e7e0-4b73-aea7-1bc3a69aaf0e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d1e633e3-c14b-4e04-b6ab-e691746b9cf0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d2703c36-2aa4-4fe8-89aa-becea6d4ad72"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d30f75a7-b77a-4d50-b602-09d39db60d0a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d53620a2-77e8-43b6-8ff2-294f4a69c2da"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d7c35116-05e0-409c-8144-5f0a73d1a6ec"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d943cb59-2ebd-4aed-83ad-49bc0bb7db85"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ddbc819b-16e5-4388-aab0-be754fc87520"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("de38d731-2fe3-448a-83b2-a50438bda3ba"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("def4a2c6-7314-4eb1-8dbe-5132ebc99dc6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("df9e6c12-193c-4fe0-b3a0-9fcb080e6bae"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dfba21a5-0fab-42dd-b62f-5432831c10b5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dfd57181-9352-4735-83a9-6dede198f65e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e0090a2f-734c-419f-9c26-df7f4e13f969"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e1f88efb-351d-4a89-8f24-92c72499212a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e3aa8c9d-6dd4-4510-ab34-18ac3f52e10d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e4a49f74-5e84-40d2-bdf2-4ac32b90e82c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e5e5501f-1d04-4519-8e34-c0aa9478d828"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("eb17901c-de0c-44d5-9564-67120ffdd24a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ed1c6a6b-0986-49b2-8d50-8e01f0698eca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ed6f97cc-5e8a-4ba8-8763-8d499aa7310f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ef08a75c-b669-4baf-81a8-e807ccd27b8d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f00e07f1-2a58-4d12-8048-1d84db730374"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f07ed86d-2d91-4422-bb89-ce2a6c36681d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f243096a-2100-431c-8542-d7f36f515582"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f4065884-5011-451a-8b20-1038f495dd4d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f6a8cd89-9946-408c-a807-cae07ea974f7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fb6c8d5c-3574-47c4-ae3e-911c052f4603"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fc0a99f3-651e-4428-b253-89d65e7b3424"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fccb59d5-bf08-4406-b0d6-44174f48d4f5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fd26c183-d5b4-4fa4-88a8-ddfbb8ad6bc6"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("00a8a18e-6784-4bf0-ad3a-4780dbe1c2c5"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("0672f7b1-b9da-4c61-baed-030f40559e0d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("113968fc-1b3d-4256-ab69-435884f466d1"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("127fb692-12ff-4548-89eb-b21c1673f7e5"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("140d3738-4ab9-4b28-b8c0-6db4ae79c082"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("1623cdb7-0d67-463b-a372-ffd80f80c33c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("24230622-b78a-4901-aec2-e96de24c6da8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2984a264-40d4-40e4-94fa-f3443b13a2e9"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2d2b80d3-f245-4878-a64f-39cec211539a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("325b7789-79f5-48f5-8914-df7ee291c18c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("34568b31-8579-4eb1-8286-3fcef5537d0d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("36ef1441-03a6-43af-a6b7-fdc27576bf3a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("3a099a8c-7d4b-4194-b509-61180d316bc8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("3cd76aa2-bf29-4531-99bb-4b60ebb03551"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("3e97b9ca-8874-416b-b15c-7d88ee620ecf"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("423fcbf7-9f9c-4d6f-8fa3-8c1b88414313"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("42585dde-4570-4acb-8d18-b7589eee76de"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4b9216fd-1f1a-42f4-b264-65e5d6728cfc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4d4fcd7f-9be8-4d26-ad81-c185cb80fc3e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4d60428a-3d63-43ba-b793-d268b0edab20"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4dcae60e-e16e-43cc-a460-0ebc670812cc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4e50c87c-17c5-460a-9885-b176937e05aa"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4fa69539-334b-4132-856a-dd14a1c228ab"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("51975f8f-d60b-45f8-aa69-f7a7f01112db"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("51f1221b-72e5-47d3-9176-38572f8e5f71"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("55d90fec-9ddb-455a-9aef-f84b60f495f7"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("565c3b5a-cb45-46f7-a560-74bff9106bfa"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5cd60307-4c3f-4018-94bf-031ae15aa971"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5e7848e5-ed63-4c60-9c9d-50f859487eba"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("606627ff-bffb-45cc-a5f5-8c1480f8d9ef"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("64c7a590-8643-481d-b5aa-88818420dc81"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("6c7aab23-ebc4-4d49-8c10-d1026999335c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("715043b3-7b14-4007-b1db-95e187f7a2b4"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("74a1fde6-923b-488d-b924-5e2358695d04"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("76c9acc1-752d-4bc9-9aa0-49d1dfab5b15"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("783b7e04-c50b-4056-b6a4-6aa8535cbb10"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("7ecc162b-4ba1-4320-a1d2-2771031c672a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("80bcf75a-5dbe-4e7e-9a47-7d68d0704d19"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("854033aa-92dc-440e-8355-e358a5c0afec"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("8ba521a2-63b4-446e-9734-6e0794359a82"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("92ed978b-b5d6-487d-a7ec-c6e63af5eddb"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("9d94b677-3e2d-4388-89d5-3aaa7259ab19"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a08c6128-d7fc-462d-8659-3ede91974c04"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a34a7c96-0f1a-4c64-9772-76d6caf51553"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a62dcc26-c492-4728-af34-edc57b70a66c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ac6c698a-8362-4623-ace9-6427b23d39a6"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("af676845-0fb7-4cab-837a-04737f8d6ade"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b43d90d4-2488-4138-995d-555cb28d048c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b4f574a0-0eea-4413-876f-64e554c0e929"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b55c1b00-ccb4-4f28-817c-52b795a61c72"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b617c130-731d-4b3b-8779-7e7f418cc155"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b7d93dd9-ace6-4acb-8a34-f85dbd349c2c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b8713e6a-2e5a-4f40-9ea2-f6ea9ec0364b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("bb44fbf7-38a3-4250-bcd2-523c76cd00a5"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c2829d3d-1119-4b66-8704-6496cbaf96ff"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c2a35a28-52f9-48db-a351-c34358f19aea"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c6418a1e-3bd8-4bed-8491-b9b93012d45e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c8c05a9a-2a65-4909-9cb7-2acdd2ea532e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ccb1c3d8-3ef0-4d04-ad40-d8eab450fe70"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ce3ed5e3-032a-438e-b7be-4d5771639070"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ced29c79-48b5-4153-8c52-ae945ca62731"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d0a4980a-5ec2-4689-9c08-62c11678b455"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d7675fc9-5e22-4bc5-888b-9fff21cf45f3"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("dacf4734-4f21-4a3f-baf9-2bdf3732f23f"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("db038ed8-bb29-4f07-864a-dcebd72b1399"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e1909bde-1661-4ff2-a0a1-1c939d8a6b56"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e935827a-d958-4c82-80a9-837141ef505b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("eaad80ae-3360-4b20-b687-49888015d558"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ee72f575-66ec-4414-937a-3873059bb42e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("efdbc667-3318-4da4-8088-970ac69ef635"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f51fb8af-3cf7-41eb-a02e-1c32571ce140"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f8ac9470-7dd3-4329-b9b4-c32a616a59f0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0170e463-e46e-42c0-87af-6c782bc27514"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4bac3c89-6139-4fbe-9375-9c3089607a4c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("57b4f3ff-0a61-4fa5-9139-d53611786dc0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("58e48dc7-8a44-4735-b08c-2c560ed2792b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("725d347f-f406-4a23-b414-4f277ad1e86d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("89f81462-999e-4830-83a6-3b8516753656"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8bce7ea9-4038-4120-8603-c657e670678a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b5e8e40a-8bff-4e8c-96b7-e4999b9721a4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e5751c44-22b5-4e43-ab2a-e1bfa4e29876"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e9d7ae38-013d-406c-b736-3e35f7d9efe6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("00e61e59-a3ec-4194-9084-612a0160fab3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("03c1fc56-8c4c-4895-9cd7-638dd51c1f3e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("071d25f8-bc97-4dbe-8393-a7d141a8c5d2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("07a97332-9348-4d3d-9d9b-09f9701393c9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("11857b4b-b0d4-42af-b758-89a803b30f5a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1306d78e-5b99-4165-bb5b-668cd69aa9ff"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("246cb8fc-8457-4bce-a5bb-535a71e566b3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("31f1b132-c3d6-4a47-9400-27d1782fc14e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("365518ec-babb-4ef8-ae51-807dbd4e23d5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3bdd5d34-6aae-44ae-a212-323359221dbf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3df85a78-4052-4926-b7bf-5dc6e4bff475"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4ba394de-5f78-4bfc-b42d-dd4cd3037db4"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4ccb50c1-1ee3-4fac-9a30-f6f88d7ea4f6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4dd55ace-37f5-4e3d-8f13-e44307725447"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4e47949b-ebed-4de0-9aab-e1e15b4a2fc8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("517928c6-6bf3-4b58-8da8-39f84945790b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("56e6e584-63c7-45c0-988a-b7869b0d30e7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5b05cf34-933f-444f-932c-116da17e0931"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5d603485-ac47-4093-a73a-83a7593022a7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("60c35c56-5ce9-40f7-a6a4-c97be7686345"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("66c061f7-ec5b-431a-b4b2-fcdd26640233"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6ce585ac-5513-4089-b668-692f58bdc331"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6d364226-b034-445c-a182-34aee0e2fdcd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("75819c49-6ffd-469a-b7ed-2c11d72e673c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("82a89abb-487f-426a-80a7-d746fc712c46"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("85f52f4b-149a-492c-ab15-b317a51c9fab"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8a6a68cb-60b1-40bf-851c-5a9e4c1bf831"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8e23c49c-6374-4981-8905-fd55ee39d6df"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("90ed50e4-ac0d-428b-898f-17d83d8adea7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9b590f67-1d06-4221-83f6-8e48d5d88e74"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9f37e642-d986-49d1-b4b0-0df9eeeccb18"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a5d19899-24a3-439e-aef6-0d52f99360ab"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b0451579-06e1-4124-bf68-d48bb1d20237"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b6731905-4a7d-4523-9ab8-ef1400249ebe"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b7224856-e3c7-4071-a9fa-41410ed466b0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b79a7445-1d91-4472-a333-793fd3289b3d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bcf40ec1-3934-4264-86d2-669db0fa03bf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c11b837c-ddae-41f4-bf49-ace5e4ad517b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c494ceb6-a661-48ca-bc79-dc8932627804"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c543ef1b-5823-4801-b131-cbe570618c52"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c59a0945-ec6f-4860-b1da-4be977ed624f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("cb2ecaa3-ef3b-470a-b5b0-88c2ebf2bba7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("cbafa8d0-f66e-467f-990b-cd0ad21ae6aa"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ccfc4833-55c4-408a-803a-9db4fc5558c0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d228099e-5e7a-4d83-9361-dc6624e003e1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d6b4fa4a-2c33-48b7-95d6-b8662804dad1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("da1944e4-839d-41a3-b64d-d78f24bd89c1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e004cf77-e527-4eac-89bd-d0cfc249918a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e4c37165-7c32-43e2-a0cb-daf869a920e4"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ef59c951-cfc9-4d36-b9e8-e6b50b6fed9f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("effedd84-931a-466a-9ad1-3afcc7161bd8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f19c9c3a-00c0-4503-a906-4258efc04b17"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f6f92f2b-7c47-47be-8a22-c0c1341d17c9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f7532d6b-bf41-4d53-b450-4b4fdb10efb0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("005fcf54-4ac3-4794-80e9-d9e7831c05ec"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("033a4dfb-dea0-442b-8f07-efffda3dc66c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("03a3c074-ae04-4f5c-a6d0-4e4b61820152"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("03bb9ca9-ae28-48a0-af2d-2177898b3706"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("07dfc2c5-ff08-4ca2-9d75-ac2400f718e7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("10521b95-7b13-4cd8-b47a-19fac79fa145"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("11a6bc52-2db0-477f-a17a-94c878e33f6c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("13f231f6-e8ec-43d9-a052-844ee9041034"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2265a5ee-c06d-4ce7-a6e3-61971bb97b7e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("276dd141-eee9-44a2-8f97-41decc40381e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("362b789c-e8e6-40b4-b590-7f9743cb9856"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3e262014-0d7f-4a65-bce6-d93074a8c4dc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("41de7aa6-3e5f-47bf-88ba-37030de4231b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("43936095-8cef-40d0-b61d-069a130596f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("479e5195-5d9f-45f9-953c-5417315cdd48"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("510b4925-7fc0-4de0-8921-a1756faab7c1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5209cacf-4f7c-4a88-9f1d-95ca8af3b052"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("53cbe638-d1e3-410c-a204-1f11f2c7633b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5e1879dd-aeb7-4de5-aa0f-4d725fe917fa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("625d1d34-7e86-41fe-8eb2-985fe439a6ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("6e8ad44e-d46b-4f50-beee-0562f82288a9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("748922e6-fc92-43ec-88b2-3da72ed82b58"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("78f93bcc-d1ab-4f22-8055-d6096634b45c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("7942c487-3bbf-439b-ab22-dc3f0bce4cc2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("7a286bfb-2317-41be-a927-3543eb6b675c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("93a27655-a27a-4fc1-83ce-4bfe7870584e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9ac3aac0-5341-4389-8153-c98bbb803cc8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a086d6f7-a8ca-4dd9-8cd4-28e1c67e96dd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a3702ac3-d8e6-479e-ad3d-90371c448e32"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("abebab04-e1f0-444a-a09d-b1c1c70b9ce2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ad5c6c97-3c62-4752-b2c9-b4b8141e3dab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ae16bb0e-76b1-45ed-bf72-61ae86ad4b77"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b02c2a20-c85f-42e3-8edd-68cb3fe4e84e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b08456ce-23d2-474d-bf65-0688076d83dd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c148479c-48ff-4120-94f2-baa33b6e8a09"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c157cb2c-9b1f-4ee2-8bb5-0919d1802622"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c71686c6-741c-4929-84c0-66cbb9f5a73a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("cb8878dd-25c6-4edc-bf11-28f061797d43"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d9db07d2-23b5-4d75-8e14-21733126d60e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("dc33adb6-52b6-4a9e-9401-66a305c9ab69"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("dd90d328-9e3b-42cb-ba19-e1d71ba99b78"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e08c079e-2af4-4aba-824a-e8645fe0f06f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e283577f-d734-401b-89b3-cf0e6a026e0f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e7b5f652-f44f-467e-935d-78bd2de865c4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ebe81c59-bf12-4df5-9baa-5af90bf5fef0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f27b51b6-95fa-4f4c-8b46-752b8542c51f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("fdb4e33f-9d37-438c-af39-ff0516c2d8db"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("160f0cae-1618-488d-ab49-965e96a5f955"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("325ff50f-cae1-40a2-8831-80291be583f9"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("499fc893-ec16-418d-aaf8-145c90826e82"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("877138af-5424-4b1b-9c2a-bb9273116280"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("c5697871-d83a-4001-acd9-cff38366f366"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("cf42925a-34eb-4464-897d-48396f722e88"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("005fcf54-4ac3-4794-80e9-d9e7831c05ec"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("033a4dfb-dea0-442b-8f07-efffda3dc66c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("03a3c074-ae04-4f5c-a6d0-4e4b61820152"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("03bb9ca9-ae28-48a0-af2d-2177898b3706"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("07dfc2c5-ff08-4ca2-9d75-ac2400f718e7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("10521b95-7b13-4cd8-b47a-19fac79fa145"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("11a6bc52-2db0-477f-a17a-94c878e33f6c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("13f231f6-e8ec-43d9-a052-844ee9041034"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2265a5ee-c06d-4ce7-a6e3-61971bb97b7e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("276dd141-eee9-44a2-8f97-41decc40381e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("362b789c-e8e6-40b4-b590-7f9743cb9856"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3e262014-0d7f-4a65-bce6-d93074a8c4dc"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("41de7aa6-3e5f-47bf-88ba-37030de4231b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("43936095-8cef-40d0-b61d-069a130596f0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("479e5195-5d9f-45f9-953c-5417315cdd48"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("510b4925-7fc0-4de0-8921-a1756faab7c1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5209cacf-4f7c-4a88-9f1d-95ca8af3b052"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("53cbe638-d1e3-410c-a204-1f11f2c7633b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5e1879dd-aeb7-4de5-aa0f-4d725fe917fa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("625d1d34-7e86-41fe-8eb2-985fe439a6ed"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6e8ad44e-d46b-4f50-beee-0562f82288a9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("748922e6-fc92-43ec-88b2-3da72ed82b58"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("78f93bcc-d1ab-4f22-8055-d6096634b45c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7942c487-3bbf-439b-ab22-dc3f0bce4cc2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7a286bfb-2317-41be-a927-3543eb6b675c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("93a27655-a27a-4fc1-83ce-4bfe7870584e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9ac3aac0-5341-4389-8153-c98bbb803cc8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a086d6f7-a8ca-4dd9-8cd4-28e1c67e96dd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a3702ac3-d8e6-479e-ad3d-90371c448e32"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("abebab04-e1f0-444a-a09d-b1c1c70b9ce2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ad5c6c97-3c62-4752-b2c9-b4b8141e3dab"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ae16bb0e-76b1-45ed-bf72-61ae86ad4b77"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b02c2a20-c85f-42e3-8edd-68cb3fe4e84e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b08456ce-23d2-474d-bf65-0688076d83dd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c148479c-48ff-4120-94f2-baa33b6e8a09"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c157cb2c-9b1f-4ee2-8bb5-0919d1802622"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c71686c6-741c-4929-84c0-66cbb9f5a73a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cb8878dd-25c6-4edc-bf11-28f061797d43"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d9db07d2-23b5-4d75-8e14-21733126d60e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dc33adb6-52b6-4a9e-9401-66a305c9ab69"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dd90d328-9e3b-42cb-ba19-e1d71ba99b78"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e08c079e-2af4-4aba-824a-e8645fe0f06f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e283577f-d734-401b-89b3-cf0e6a026e0f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e7b5f652-f44f-467e-935d-78bd2de865c4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ebe81c59-bf12-4df5-9baa-5af90bf5fef0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f27b51b6-95fa-4f4c-8b46-752b8542c51f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fdb4e33f-9d37-438c-af39-ff0516c2d8db"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("5b752751-101e-4a82-9d4e-d31ced092458"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("80417947-ecb8-4ab6-a4b0-768839065692"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("96ddf3f8-85b9-4355-8945-6c4110723088"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("df814f1d-5034-4c14-a03d-1829821df987"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("e9215073-62b6-4e45-92cb-7ea3c7e52331"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("38f00b21-23bd-4d5b-9bff-70839859e665"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("440f5863-b80a-444b-9e38-7628b16206a1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("5189c11f-749c-4cff-b130-1a7093c9a639"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("57489b88-50a6-412f-8d32-d544805f5eaa"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("64f2c511-583d-4dc4-a811-dada76aba579"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("f04a31a2-88f6-4ff3-8925-926403e18987"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("38f00b21-23bd-4d5b-9bff-70839859e665"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("440f5863-b80a-444b-9e38-7628b16206a1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5189c11f-749c-4cff-b130-1a7093c9a639"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("57489b88-50a6-412f-8d32-d544805f5eaa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("64f2c511-583d-4dc4-a811-dada76aba579"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f04a31a2-88f6-4ff3-8925-926403e18987"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("28819f09-20b1-4459-823a-700357ac2fb0"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("7ee04521-770f-400c-88a1-8bc31db1600a"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("82a1756a-fdf6-4404-a940-94b8eff980d0"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("9ae3e7e7-f045-4d8f-9f27-bcbbb5cb97a9"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("c48d1d0b-eeed-483e-8191-de9b254a5ba2"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("c49c97c9-60ae-40d0-b49a-f46570b2eadb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("52d2e621-2150-4328-a00c-f1f307038311"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5a424122-f16b-4bc8-891a-48fe333b6341"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("ee9319ee-65bc-4974-b7ba-2a804ef90d83"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("52d2e621-2150-4328-a00c-f1f307038311"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5a424122-f16b-4bc8-891a-48fe333b6341"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("387884bb-47c7-4c9a-8149-450fcb1bf4a5"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a97da969-4de8-4122-96c9-30460d5242d1"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("d486de20-ffea-4d3f-bb71-a7406deb5ed7"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("1de1e5c4-fe7b-4722-821b-c0a49eeefd44"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("90341a59-9256-4577-be1f-40f1d5773dad"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("b2793483-354a-4e4f-a12e-1879999ecc80"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("d804c6b1-1315-41ab-bda8-7ffdb55e4987"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("6eaf6240-ff67-4807-838f-df36916e11a9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6eaf6240-ff67-4807-838f-df36916e11a9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("53f4cdd5-a197-453e-885e-11f84e377b20"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("6c91262f-793c-4277-8076-2c276d53f655"));

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<Guid>(
                name: "StudyYearId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3"), "", "dummyEmail@email.com", "firstName0", "firstName0", "dummyPasswordHash", null, "Teacher", "TestAccount0" },
                    { new Guid("62cef015-f0eb-4a6d-a0ce-43263a9de3e5"), "", "dummyEmail@email.com", "firstName73", "firstName73", "dummyPasswordHash", null, "Student", "TestAccount73" },
                    { new Guid("99d71edc-63a4-4a24-b278-b49d0bb19f49"), "", "dummyEmail@email.com", "firstName71", "firstName71", "dummyPasswordHash", null, "Student", "TestAccount71" },
                    { new Guid("c868fdb3-b9c3-4a4e-9727-bf3cf5f2b20f"), "", "dummyEmail@email.com", "firstName70", "firstName70", "dummyPasswordHash", null, "Student", "TestAccount70" },
                    { new Guid("27c21c60-30bb-4cb7-a3e3-4857aab19659"), "", "dummyEmail@email.com", "firstName69", "firstName69", "dummyPasswordHash", null, "Student", "TestAccount69" },
                    { new Guid("b886c14b-274f-4bd7-be28-3e8f37ea9503"), "", "dummyEmail@email.com", "firstName68", "firstName68", "dummyPasswordHash", null, "Student", "TestAccount68" },
                    { new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"), "", "dummyEmail@email.com", "firstName67", "firstName67", "dummyPasswordHash", null, "Student", "TestAccount67" },
                    { new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"), "", "dummyEmail@email.com", "firstName66", "firstName66", "dummyPasswordHash", null, "Student", "TestAccount66" },
                    { new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"), "", "dummyEmail@email.com", "firstName65", "firstName65", "dummyPasswordHash", null, "Student", "TestAccount65" },
                    { new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"), "", "dummyEmail@email.com", "firstName64", "firstName64", "dummyPasswordHash", null, "Student", "TestAccount64" },
                    { new Guid("b7410b97-9dd3-403f-bad8-9ddae8158612"), "", "dummyEmail@email.com", "firstName63", "firstName63", "dummyPasswordHash", null, "Student", "TestAccount63" },
                    { new Guid("27f1e861-b79c-4143-9b88-69313b52ccc0"), "", "dummyEmail@email.com", "firstName62", "firstName62", "dummyPasswordHash", null, "Student", "TestAccount62" },
                    { new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6"), "", "dummyEmail@email.com", "firstName61", "firstName61", "dummyPasswordHash", null, "Student", "TestAccount61" },
                    { new Guid("671a6804-d308-419d-b56e-84b4c8858681"), "", "dummyEmail@email.com", "firstName60", "firstName60", "dummyPasswordHash", null, "Student", "TestAccount60" },
                    { new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"), "", "dummyEmail@email.com", "firstName59", "firstName59", "dummyPasswordHash", null, "Student", "TestAccount59" },
                    { new Guid("fe763220-9d76-451a-add3-d88a4e35722a"), "", "dummyEmail@email.com", "firstName58", "firstName58", "dummyPasswordHash", null, "Student", "TestAccount58" },
                    { new Guid("ea4c9cd4-14d3-456e-aa97-e835f7f8dbff"), "", "dummyEmail@email.com", "firstName57", "firstName57", "dummyPasswordHash", null, "Student", "TestAccount57" },
                    { new Guid("9b342db1-edd9-4031-8d39-95f30c0141a7"), "", "dummyEmail@email.com", "firstName56", "firstName56", "dummyPasswordHash", null, "Student", "TestAccount56" },
                    { new Guid("3d66a605-b2f6-414e-b4fa-7a679521bbdf"), "", "dummyEmail@email.com", "firstName55", "firstName55", "dummyPasswordHash", null, "Student", "TestAccount55" },
                    { new Guid("697a9e49-5424-4293-803b-71cde4bd3c23"), "", "dummyEmail@email.com", "firstName54", "firstName54", "dummyPasswordHash", null, "Student", "TestAccount54" },
                    { new Guid("045fd78f-d876-4b31-8e8e-93c7f28fba90"), "", "dummyEmail@email.com", "firstName53", "firstName53", "dummyPasswordHash", null, "Student", "TestAccount53" },
                    { new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"), "", "dummyEmail@email.com", "firstName52", "firstName52", "dummyPasswordHash", null, "Student", "TestAccount52" },
                    { new Guid("0cbd6601-75d8-4c01-aab1-45d423fa9319"), "", "dummyEmail@email.com", "firstName74", "firstName74", "dummyPasswordHash", null, "Student", "TestAccount74" },
                    { new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"), "", "dummyEmail@email.com", "firstName75", "firstName75", "dummyPasswordHash", null, "Student", "TestAccount75" },
                    { new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"), "", "dummyEmail@email.com", "firstName76", "firstName76", "dummyPasswordHash", null, "Student", "TestAccount76" },
                    { new Guid("8f30ff42-f259-4b6a-90b2-3745f361afff"), "", "dummyEmail@email.com", "firstName77", "firstName77", "dummyPasswordHash", null, "Student", "TestAccount77" },
                    { new Guid("d50391ff-a32e-4abf-b45f-5e4cf058b204"), "", "dummyEmail@email.com", "firstName99", "firstName99", "dummyPasswordHash", null, "Student", "TestAccount99" },
                    { new Guid("f19daf6f-9705-4a6f-a953-9d9d69604436"), "", "dummyEmail@email.com", "firstName98", "firstName98", "dummyPasswordHash", null, "Student", "TestAccount98" },
                    { new Guid("b73b2bfd-896d-42d9-8768-2bda7f1fc5aa"), "", "dummyEmail@email.com", "firstName97", "firstName97", "dummyPasswordHash", null, "Student", "TestAccount97" },
                    { new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"), "", "dummyEmail@email.com", "firstName96", "firstName96", "dummyPasswordHash", null, "Student", "TestAccount96" },
                    { new Guid("a2263c6b-31e9-4242-8663-697fcc365987"), "", "dummyEmail@email.com", "firstName95", "firstName95", "dummyPasswordHash", null, "Student", "TestAccount95" },
                    { new Guid("9d71a4b5-d03c-4341-bf59-2920f6ae260e"), "", "dummyEmail@email.com", "firstName94", "firstName94", "dummyPasswordHash", null, "Student", "TestAccount94" },
                    { new Guid("e86bcb2a-cd9b-4175-a190-d4872e96e236"), "", "dummyEmail@email.com", "firstName93", "firstName93", "dummyPasswordHash", null, "Student", "TestAccount93" },
                    { new Guid("4c941439-f62a-48fc-8aa6-d047333edb44"), "", "dummyEmail@email.com", "firstName92", "firstName92", "dummyPasswordHash", null, "Student", "TestAccount92" },
                    { new Guid("936e7f20-6944-43f3-8e3d-99bccbeb26c8"), "", "dummyEmail@email.com", "firstName91", "firstName91", "dummyPasswordHash", null, "Student", "TestAccount91" },
                    { new Guid("b96d78b3-d8cb-4634-8534-636517564e76"), "", "dummyEmail@email.com", "firstName90", "firstName90", "dummyPasswordHash", null, "Student", "TestAccount90" },
                    { new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"), "", "dummyEmail@email.com", "firstName51", "firstName51", "dummyPasswordHash", null, "Student", "TestAccount51" },
                    { new Guid("42c6514f-3632-4599-af6a-982cf4845ef4"), "", "dummyEmail@email.com", "firstName89", "firstName89", "dummyPasswordHash", null, "Student", "TestAccount89" },
                    { new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"), "", "dummyEmail@email.com", "firstName87", "firstName87", "dummyPasswordHash", null, "Student", "TestAccount87" },
                    { new Guid("b3050769-754a-4389-8690-8ec99304fb18"), "", "dummyEmail@email.com", "firstName86", "firstName86", "dummyPasswordHash", null, "Student", "TestAccount86" },
                    { new Guid("c62ff166-4f6a-4126-916a-ea30a7804072"), "", "dummyEmail@email.com", "firstName85", "firstName85", "dummyPasswordHash", null, "Student", "TestAccount85" },
                    { new Guid("ce097aa9-4fb3-4a6e-ad49-ac8a555743d6"), "", "dummyEmail@email.com", "firstName84", "firstName84", "dummyPasswordHash", null, "Student", "TestAccount84" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab"), "", "dummyEmail@email.com", "firstName83", "firstName83", "dummyPasswordHash", null, "Student", "TestAccount83" },
                    { new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"), "", "dummyEmail@email.com", "firstName82", "firstName82", "dummyPasswordHash", null, "Student", "TestAccount82" },
                    { new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"), "", "dummyEmail@email.com", "firstName81", "firstName81", "dummyPasswordHash", null, "Student", "TestAccount81" },
                    { new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"), "", "dummyEmail@email.com", "firstName80", "firstName80", "dummyPasswordHash", null, "Student", "TestAccount80" },
                    { new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"), "", "dummyEmail@email.com", "firstName79", "firstName79", "dummyPasswordHash", null, "Student", "TestAccount79" },
                    { new Guid("2e6514ee-f003-4a1c-b604-ee104cb18e9c"), "", "dummyEmail@email.com", "firstName78", "firstName78", "dummyPasswordHash", null, "Student", "TestAccount78" },
                    { new Guid("9e7ed602-ce49-4120-8013-d672ff620db5"), "", "dummyEmail@email.com", "firstName88", "firstName88", "dummyPasswordHash", null, "Student", "TestAccount88" },
                    { new Guid("cc555932-1240-4511-8879-82d6a043a116"), "", "dummyEmail@email.com", "firstName50", "firstName50", "dummyPasswordHash", null, "Student", "TestAccount50" },
                    { new Guid("4c2b1381-e9ec-41e5-858f-0b4e03a0b1dd"), "", "dummyEmail@email.com", "firstName72", "firstName72", "dummyPasswordHash", null, "Student", "TestAccount72" },
                    { new Guid("14acfd39-649e-44bb-b4c9-81bb485c1565"), "", "dummyEmail@email.com", "firstName48", "firstName48", "dummyPasswordHash", null, "Student", "TestAccount48" },
                    { new Guid("c33cdba2-ee2c-479d-b007-73e9e2ec2004"), "", "dummyEmail@email.com", "firstName22", "firstName22", "dummyPasswordHash", null, "Admin", "TestAccount22" },
                    { new Guid("5eaa5f96-418a-4ce7-afce-57ea44256311"), "", "dummyEmail@email.com", "firstName21", "firstName21", "dummyPasswordHash", null, "Admin", "TestAccount21" },
                    { new Guid("8b9c3e4c-f1d2-42ec-9e5d-61a32fcdf25c"), "", "dummyEmail@email.com", "firstName20", "firstName20", "dummyPasswordHash", null, "Admin", "TestAccount20" },
                    { new Guid("2daf477e-5667-485b-8efb-3858c7cababb"), "", "dummyEmail@email.com", "firstName19", "firstName19", "dummyPasswordHash", null, "Teacher", "TestAccount19" },
                    { new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8"), "", "dummyEmail@email.com", "firstName18", "firstName18", "dummyPasswordHash", null, "Teacher", "TestAccount18" },
                    { new Guid("15e101e5-6231-465a-b661-6b9e8830332c"), "", "dummyEmail@email.com", "firstName17", "firstName17", "dummyPasswordHash", null, "Teacher", "TestAccount17" },
                    { new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99"), "", "dummyEmail@email.com", "firstName16", "firstName16", "dummyPasswordHash", null, "Teacher", "TestAccount16" },
                    { new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9"), "", "dummyEmail@email.com", "firstName15", "firstName15", "dummyPasswordHash", null, "Teacher", "TestAccount15" },
                    { new Guid("6785ef90-5968-4673-918f-87969772d761"), "", "dummyEmail@email.com", "firstName14", "firstName14", "dummyPasswordHash", null, "Teacher", "TestAccount14" },
                    { new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2"), "", "dummyEmail@email.com", "firstName13", "firstName13", "dummyPasswordHash", null, "Teacher", "TestAccount13" },
                    { new Guid("700fb14c-1fda-4aa5-8d27-b0742d2ed3b8"), "", "dummyEmail@email.com", "firstName23", "firstName23", "dummyPasswordHash", null, "Admin", "TestAccount23" },
                    { new Guid("071f8601-80b8-42c5-8d93-6440c4633c35"), "", "dummyEmail@email.com", "firstName12", "firstName12", "dummyPasswordHash", null, "Teacher", "TestAccount12" },
                    { new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60"), "", "dummyEmail@email.com", "firstName10", "firstName10", "dummyPasswordHash", null, "Teacher", "TestAccount10" },
                    { new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353"), "", "dummyEmail@email.com", "firstName9", "firstName9", "dummyPasswordHash", null, "Teacher", "TestAccount9" },
                    { new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d"), "", "dummyEmail@email.com", "firstName8", "firstName8", "dummyPasswordHash", null, "Teacher", "TestAccount8" },
                    { new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a"), "", "dummyEmail@email.com", "firstName7", "firstName7", "dummyPasswordHash", null, "Teacher", "TestAccount7" },
                    { new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936"), "", "dummyEmail@email.com", "firstName6", "firstName6", "dummyPasswordHash", null, "Teacher", "TestAccount6" },
                    { new Guid("467747c2-5e64-433e-afc5-e8f521652bbf"), "", "dummyEmail@email.com", "firstName5", "firstName5", "dummyPasswordHash", null, "Teacher", "TestAccount5" },
                    { new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f"), "", "dummyEmail@email.com", "firstName4", "firstName4", "dummyPasswordHash", null, "Teacher", "TestAccount4" },
                    { new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c"), "", "dummyEmail@email.com", "firstName3", "firstName3", "dummyPasswordHash", null, "Teacher", "TestAccount3" },
                    { new Guid("566cf487-3ed6-40c5-ae72-d3741beff430"), "", "dummyEmail@email.com", "firstName49", "firstName49", "dummyPasswordHash", null, "Student", "TestAccount49" },
                    { new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b"), "", "dummyEmail@email.com", "firstName1", "firstName1", "dummyPasswordHash", null, "Teacher", "TestAccount1" },
                    { new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c"), "", "dummyEmail@email.com", "firstName11", "firstName11", "dummyPasswordHash", null, "Teacher", "TestAccount11" },
                    { new Guid("74dcef9a-13e3-4fbc-ab36-ad379732c46f"), "", "dummyEmail@email.com", "firstName24", "firstName24", "dummyPasswordHash", null, "Admin", "TestAccount24" },
                    { new Guid("08753260-7db2-4911-97b2-cf49552414ff"), "", "dummyEmail@email.com", "firstName2", "firstName2", "dummyPasswordHash", null, "Teacher", "TestAccount2" },
                    { new Guid("87b10a13-db0c-4026-b754-1a22e13c01cf"), "", "dummyEmail@email.com", "firstName26", "firstName26", "dummyPasswordHash", null, "Admin", "TestAccount26" },
                    { new Guid("be949e9a-24fe-4d7c-95a0-ec7a0150f500"), "", "dummyEmail@email.com", "firstName25", "firstName25", "dummyPasswordHash", null, "Admin", "TestAccount25" },
                    { new Guid("2273247a-5ea9-4956-bbe3-e4e1fbedc68a"), "", "dummyEmail@email.com", "firstName47", "firstName47", "dummyPasswordHash", null, "Student", "TestAccount47" },
                    { new Guid("7c117e49-26a5-44a1-ad74-028fc5ccc9cd"), "", "dummyEmail@email.com", "firstName46", "firstName46", "dummyPasswordHash", null, "Student", "TestAccount46" },
                    { new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea"), "", "dummyEmail@email.com", "firstName44", "firstName44", "dummyPasswordHash", null, "Student", "TestAccount44" },
                    { new Guid("e67b668b-c463-423b-8022-1832825cb1be"), "", "dummyEmail@email.com", "firstName43", "firstName43", "dummyPasswordHash", null, "Student", "TestAccount43" },
                    { new Guid("338fe279-f58e-4c5e-9081-9648454a2753"), "", "dummyEmail@email.com", "firstName42", "firstName42", "dummyPasswordHash", null, "Student", "TestAccount42" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd"), "", "dummyEmail@email.com", "firstName41", "firstName41", "dummyPasswordHash", null, "Student", "TestAccount41" },
                    { new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"), "", "dummyEmail@email.com", "firstName40", "firstName40", "dummyPasswordHash", null, "Student", "TestAccount40" },
                    { new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"), "", "dummyEmail@email.com", "firstName39", "firstName39", "dummyPasswordHash", null, "Student", "TestAccount39" },
                    { new Guid("249c3565-3c41-47d1-88e6-621398c458be"), "", "dummyEmail@email.com", "firstName38", "firstName38", "dummyPasswordHash", null, "Student", "TestAccount38" },
                    { new Guid("f43b2256-f1d4-4685-be74-d6d3ae8c76f0"), "", "dummyEmail@email.com", "firstName37", "firstName37", "dummyPasswordHash", null, "Student", "TestAccount37" },
                    { new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"), "", "dummyEmail@email.com", "firstName45", "firstName45", "dummyPasswordHash", null, "Student", "TestAccount45" },
                    { new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"), "", "dummyEmail@email.com", "firstName35", "firstName35", "dummyPasswordHash", null, "Student", "TestAccount35" },
                    { new Guid("8ea1e7b2-5649-4204-aed8-c92eba7ef250"), "", "dummyEmail@email.com", "firstName36", "firstName36", "dummyPasswordHash", null, "Student", "TestAccount36" },
                    { new Guid("c6bd4f82-482d-4c08-8d64-3ab849f89edf"), "", "dummyEmail@email.com", "firstName27", "firstName27", "dummyPasswordHash", null, "Admin", "TestAccount27" },
                    { new Guid("9976ecd7-ec23-44bf-9517-f4d0b862bd8e"), "", "dummyEmail@email.com", "firstName29", "firstName29", "dummyPasswordHash", null, "Admin", "TestAccount29" },
                    { new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"), "", "dummyEmail@email.com", "firstName30", "firstName30", "dummyPasswordHash", null, "Student", "TestAccount30" },
                    { new Guid("585fecc7-0249-42a1-b7cb-33a6783501db"), "", "dummyEmail@email.com", "firstName28", "firstName28", "dummyPasswordHash", null, "Admin", "TestAccount28" },
                    { new Guid("44ff300d-60b2-405f-aeae-46d9f3a15240"), "", "dummyEmail@email.com", "firstName32", "firstName32", "dummyPasswordHash", null, "Student", "TestAccount32" },
                    { new Guid("f518e1c2-2090-486c-8c45-02484ff2577d"), "", "dummyEmail@email.com", "firstName33", "firstName33", "dummyPasswordHash", null, "Student", "TestAccount33" },
                    { new Guid("584cde08-c075-407e-a09f-d5a533fbc45f"), "", "dummyEmail@email.com", "firstName34", "firstName34", "dummyPasswordHash", null, "Student", "TestAccount34" },
                    { new Guid("9803212f-9417-4247-b409-1faaf7e69066"), "", "dummyEmail@email.com", "firstName31", "firstName31", "dummyPasswordHash", null, "Student", "TestAccount31" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("3e827b50-38bb-4049-b554-ad4db7c6f079"), null, null, null, null },
                    { new Guid("0eb78f8e-6486-498e-abaf-e7a8ff52a03c"), null, null, null, null },
                    { new Guid("0d804411-bbbc-4de0-af5d-21ffdd14972a"), null, null, null, null },
                    { new Guid("5c1d34d9-2bfa-4cf5-aea7-e15eeddaae0b"), null, null, null, null },
                    { new Guid("3d329348-1e54-45bb-b1dc-f8359d8eca3a"), null, null, null, null },
                    { new Guid("d24e31dc-caab-40e0-8195-6f702aa19e56"), null, null, null, null },
                    { new Guid("3b4511bc-9d42-4045-959a-c600cd7ddb6a"), null, null, null, null },
                    { new Guid("46401e74-4daa-4cbf-977b-de06701233b5"), null, null, null, null },
                    { new Guid("1d687ef2-33f0-4d7a-89cc-01aec8e2d2ea"), null, null, null, null },
                    { new Guid("1f11cb47-a2e7-451c-a889-a80257623e34"), null, null, null, null },
                    { new Guid("51868205-f576-4dc7-a5bc-a01e8b9128a2"), null, null, null, null },
                    { new Guid("ac3c82f7-db08-4e04-98e9-943dc2294c9d"), null, null, null, null },
                    { new Guid("7c221e27-d7c4-4cd9-9696-ed276a0db0f8"), null, null, null, null },
                    { new Guid("de4c4358-6826-4479-83b2-4d2e56574803"), null, null, null, null },
                    { new Guid("3796f44f-4e6d-4a0d-931a-67de6eca130b"), null, null, null, null },
                    { new Guid("cdf85e3d-470c-467c-a72b-c1c4ab9effc9"), null, null, null, null },
                    { new Guid("12e1e64f-b7ba-407c-8e0c-de37d9c6a986"), null, null, null, null },
                    { new Guid("52a1bf69-48b8-4333-930e-8b8603fd5dba"), null, null, null, null },
                    { new Guid("3620dd07-5455-460c-a309-1adbf056f069"), null, null, null, null },
                    { new Guid("9d061641-b81f-41f2-aeaa-48a436317e31"), null, null, null, null },
                    { new Guid("353dfdfe-d039-4855-8d1b-9fef20b86a07"), null, null, null, null },
                    { new Guid("1e64fce0-c64e-4952-9ca4-ded612da49d6"), null, null, null, null },
                    { new Guid("87f909d9-267a-4710-bb98-687652181b48"), null, null, null, null },
                    { new Guid("d315edc1-b4a1-4a4a-a2ee-ef2c5ed5c1a2"), null, null, null, null },
                    { new Guid("c01a8e4f-ddaf-49ba-b3fc-7e8dc962addf"), null, null, null, null },
                    { new Guid("64213c26-f20c-496a-91f9-a1872cc9249a"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("5556d781-9a8c-4bc8-8b2d-7569b09b497b"), null, null, null, null },
                    { new Guid("eeb27e3b-7129-4274-ad3d-38ccaff788d7"), null, null, null, null },
                    { new Guid("7f399728-b435-443b-8fb7-7bf58eb8fd09"), null, null, null, null },
                    { new Guid("4a895a13-7960-4ff6-92b3-61afaad832a8"), null, null, null, null },
                    { new Guid("0dad3774-03bf-4c41-8cbc-640fdae1ec2f"), null, null, null, null },
                    { new Guid("260ffeb4-a7d2-407d-adea-421016739dba"), null, null, null, null },
                    { new Guid("999028dd-0e3f-40e6-8b7b-7eebe90fe176"), null, null, null, null },
                    { new Guid("fb9f1d4e-b0fc-4f5d-bd9d-ca86e5e5443e"), null, null, null, null },
                    { new Guid("62e33f6d-1316-421c-9b5d-97f86a9654d0"), null, null, null, null },
                    { new Guid("0d95f6da-d6ff-43c7-b438-b2e7a29e6035"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"), "Bachelor" },
                    { new Guid("9a851801-27e2-4559-89cf-84283b799d7d"), "Master" }
                });

            migrationBuilder.InsertData(
                table: "StudyLines",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("fc0c41a7-ac00-4471-8abc-162d286d1b32"), "English", "EN" },
                    { new Guid("9490afde-363a-4d62-aa71-848e4287787f"), "Romanian", "RO" },
                    { new Guid("c7c4488a-db08-4a93-87ed-93a5d3287542"), "German", "DE" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name", "Rank" },
                values: new object[,]
                {
                    { new Guid("aff34571-8aed-44e1-9a97-351bf716b5fb"), "TeacherDegree0", 0 },
                    { new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8"), "TeacherDegree1", 0 },
                    { new Guid("6cce64f9-b62d-4e80-82f0-b176416a2f92"), "TeacherDegree2", 0 },
                    { new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c"), "TeacherDegree3", 0 },
                    { new Guid("3723ac71-a7a1-47b4-bcca-3744fff1bebd"), "TeacherDegree4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("8b9c3e4c-f1d2-42ec-9e5d-61a32fcdf25c"),
                    new Guid("9976ecd7-ec23-44bf-9517-f4d0b862bd8e"),
                    new Guid("c6bd4f82-482d-4c08-8d64-3ab849f89edf"),
                    new Guid("87b10a13-db0c-4026-b754-1a22e13c01cf"),
                    new Guid("be949e9a-24fe-4d7c-95a0-ec7a0150f500"),
                    new Guid("585fecc7-0249-42a1-b7cb-33a6783501db"),
                    new Guid("700fb14c-1fda-4aa5-8d27-b0742d2ed3b8"),
                    new Guid("c33cdba2-ee2c-479d-b007-73e9e2ec2004"),
                    new Guid("5eaa5f96-418a-4ce7-afce-57ea44256311"),
                    new Guid("74dcef9a-13e3-4fbc-ab36-ad379732c46f")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"),
                    new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"),
                    new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"),
                    new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"),
                    new Guid("2e6514ee-f003-4a1c-b604-ee104cb18e9c"),
                    new Guid("8f30ff42-f259-4b6a-90b2-3745f361afff"),
                    new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"),
                    new Guid("c868fdb3-b9c3-4a4e-9727-bf3cf5f2b20f"),
                    new Guid("62cef015-f0eb-4a6d-a0ce-43263a9de3e5"),
                    new Guid("4c2b1381-e9ec-41e5-858f-0b4e03a0b1dd"),
                    new Guid("99d71edc-63a4-4a24-b278-b49d0bb19f49"),
                    new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"),
                    new Guid("b886c14b-274f-4bd7-be28-3e8f37ea9503"),
                    new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"),
                    new Guid("0cbd6601-75d8-4c01-aab1-45d423fa9319"),
                    new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab"),
                    new Guid("9e7ed602-ce49-4120-8013-d672ff620db5"),
                    new Guid("c62ff166-4f6a-4126-916a-ea30a7804072"),
                    new Guid("d50391ff-a32e-4abf-b45f-5e4cf058b204"),
                    new Guid("f19daf6f-9705-4a6f-a953-9d9d69604436"),
                    new Guid("b73b2bfd-896d-42d9-8768-2bda7f1fc5aa"),
                    new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"),
                    new Guid("a2263c6b-31e9-4242-8663-697fcc365987"),
                    new Guid("9d71a4b5-d03c-4341-bf59-2920f6ae260e"),
                    new Guid("ce097aa9-4fb3-4a6e-ad49-ac8a555743d6"),
                    new Guid("e86bcb2a-cd9b-4175-a190-d4872e96e236"),
                    new Guid("936e7f20-6944-43f3-8e3d-99bccbeb26c8"),
                    new Guid("b96d78b3-d8cb-4634-8534-636517564e76"),
                    new Guid("42c6514f-3632-4599-af6a-982cf4845ef4"),
                    new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"),
                    new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"),
                    new Guid("b3050769-754a-4389-8690-8ec99304fb18")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("4c941439-f62a-48fc-8aa6-d047333edb44"),
                    new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"),
                    new Guid("27c21c60-30bb-4cb7-a3e3-4857aab19659"),
                    new Guid("b7410b97-9dd3-403f-bad8-9ddae8158612"),
                    new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea"),
                    new Guid("e67b668b-c463-423b-8022-1832825cb1be"),
                    new Guid("338fe279-f58e-4c5e-9081-9648454a2753"),
                    new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd"),
                    new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"),
                    new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"),
                    new Guid("249c3565-3c41-47d1-88e6-621398c458be"),
                    new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"),
                    new Guid("8ea1e7b2-5649-4204-aed8-c92eba7ef250"),
                    new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"),
                    new Guid("584cde08-c075-407e-a09f-d5a533fbc45f"),
                    new Guid("f518e1c2-2090-486c-8c45-02484ff2577d"),
                    new Guid("44ff300d-60b2-405f-aeae-46d9f3a15240"),
                    new Guid("9803212f-9417-4247-b409-1faaf7e69066"),
                    new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"),
                    new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"),
                    new Guid("7c117e49-26a5-44a1-ad74-028fc5ccc9cd"),
                    new Guid("f43b2256-f1d4-4685-be74-d6d3ae8c76f0"),
                    new Guid("14acfd39-649e-44bb-b4c9-81bb485c1565"),
                    new Guid("27f1e861-b79c-4143-9b88-69313b52ccc0"),
                    new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6"),
                    new Guid("671a6804-d308-419d-b56e-84b4c8858681"),
                    new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"),
                    new Guid("fe763220-9d76-451a-add3-d88a4e35722a"),
                    new Guid("2273247a-5ea9-4956-bbe3-e4e1fbedc68a"),
                    new Guid("9b342db1-edd9-4031-8d39-95f30c0141a7"),
                    new Guid("ea4c9cd4-14d3-456e-aa97-e835f7f8dbff"),
                    new Guid("697a9e49-5424-4293-803b-71cde4bd3c23"),
                    new Guid("045fd78f-d876-4b31-8e8e-93c7f28fba90"),
                    new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"),
                    new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"),
                    new Guid("cc555932-1240-4511-8879-82d6a043a116"),
                    new Guid("566cf487-3ed6-40c5-ae72-d3741beff430"),
                    new Guid("3d66a605-b2f6-414e-b4fa-7a679521bbdf")
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a"), new Guid("3723ac71-a7a1-47b4-bcca-3744fff1bebd") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("2daf477e-5667-485b-8efb-3858c7cababb"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9"), new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c") },
                    { new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8"), new Guid("6cce64f9-b62d-4e80-82f0-b176416a2f92") },
                    { new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353"), new Guid("aff34571-8aed-44e1-9a97-351bf716b5fb") },
                    { new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936"), new Guid("6cce64f9-b62d-4e80-82f0-b176416a2f92") },
                    { new Guid("6785ef90-5968-4673-918f-87969772d761"), new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8") },
                    { new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60"), new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8") },
                    { new Guid("467747c2-5e64-433e-afc5-e8f521652bbf"), new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8") },
                    { new Guid("08753260-7db2-4911-97b2-cf49552414ff"), new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8") },
                    { new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b"), new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8") },
                    { new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f"), new Guid("aff34571-8aed-44e1-9a97-351bf716b5fb") },
                    { new Guid("071f8601-80b8-42c5-8d93-6440c4633c35"), new Guid("3723ac71-a7a1-47b4-bcca-3744fff1bebd") },
                    { new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2"), new Guid("6cce64f9-b62d-4e80-82f0-b176416a2f92") },
                    { new Guid("15e101e5-6231-465a-b661-6b9e8830332c"), new Guid("3723ac71-a7a1-47b4-bcca-3744fff1bebd") }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("87acd182-4559-4bf1-8052-6f88b2eab736"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3"), "Faculty-0" },
                    { new Guid("9e97fae8-6c04-47f0-be77-054b12a6cbdb"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b"), "Faculty-1" },
                    { new Guid("7c70a3ed-fe42-4ab2-b25b-606310a83114"), new Guid("08753260-7db2-4911-97b2-cf49552414ff"), "Faculty-2" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("bb8cf7e3-f07e-4d72-baaa-3fc8a0193fce"), new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"), null, null, new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("1939b7f4-ebea-43b0-b458-c9ea10b7441d"), new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"), null, null, new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("6d945629-fc20-4a2d-840e-9efc331dfae0"), new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"), null, null, new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("fc76e366-89cd-4503-87eb-c8aff678efb3"), new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"), null, null, new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("18a341f9-d05d-4dad-a4ec-725e6fc25adb"), new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"), null, null, new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("43415428-9485-44f6-9ed7-6f696e0c17ed"), new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"), null, null, new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("bd7b713d-c747-40f1-a165-3d8e1ec41b5d"), new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"), null, null, new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("94c2c181-3280-443a-9cf6-f8fb44a711d0"), new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"), null, null, new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("67a22ec5-8bf1-46c6-b087-bb33ba0db7c8"), new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"), null, null, new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("0b2c4f43-a881-4b96-b697-2baec5d6ae9e"), new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"), null, null, new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("8fab1726-e000-4f6c-9e7a-49d3f0b75a43"), new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"), null, null, new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("aadab007-b362-46ed-a688-860990c1ce67"), new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"), null, null, new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("7434bf02-5d81-4cce-a463-8b8620d20efb"), new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"), null, null, new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("5601e26f-0be7-420e-82aa-5c82d5f10a9b"), new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"), null, null, new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("d0e6bd46-38cf-4efd-adb2-6cdd458afd2a"), new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"), null, null, new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("bcdefb44-008a-449e-bc13-762db3f6614c"), new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"), null, null, new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("424a4d8b-8887-48a8-bf0d-107c4d589182"), new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"), null, null, new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("45060f12-ece6-4b97-b565-daa07f1ee078"), new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"), null, null, new Guid("15e101e5-6231-465a-b661-6b9e8830332c") }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "FacultyId", "Name", "Semesters", "StudyDegreeId", "StudyLineId" },
                values: new object[,]
                {
                    { new Guid("2d3125e6-96ee-46cf-b463-10d6f49aa402"), new Guid("9e97fae8-6c04-47f0-be77-054b12a6cbdb"), "Specialisation-0", (short)2, new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"), new Guid("fc0c41a7-ac00-4471-8abc-162d286d1b32") },
                    { new Guid("20764258-d0a1-439a-aa0b-7fb740e33dc9"), new Guid("9e97fae8-6c04-47f0-be77-054b12a6cbdb"), "Specialisation-3", (short)2, new Guid("9a851801-27e2-4559-89cf-84283b799d7d"), new Guid("c7c4488a-db08-4a93-87ed-93a5d3287542") },
                    { new Guid("17d9eef8-a266-41cb-8d39-3b53a12d6580"), new Guid("9e97fae8-6c04-47f0-be77-054b12a6cbdb"), "Specialisation-4", (short)2, new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"), new Guid("c7c4488a-db08-4a93-87ed-93a5d3287542") },
                    { new Guid("80632e42-b5f6-4eaa-9683-49f052fca4f0"), new Guid("7c70a3ed-fe42-4ab2-b25b-606310a83114"), "Specialisation-1", (short)2, new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"), new Guid("fc0c41a7-ac00-4471-8abc-162d286d1b32") },
                    { new Guid("5ecba4df-60e5-46bb-91e7-f96312e14e7f"), new Guid("7c70a3ed-fe42-4ab2-b25b-606310a83114"), "Specialisation-5", (short)2, new Guid("9a851801-27e2-4559-89cf-84283b799d7d"), new Guid("9490afde-363a-4d62-aa71-848e4287787f") },
                    { new Guid("e078d27d-3057-428a-9578-326a5b969ea5"), new Guid("87acd182-4559-4bf1-8052-6f88b2eab736"), "Specialisation-2", (short)2, new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"), new Guid("c7c4488a-db08-4a93-87ed-93a5d3287542") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "EndDate", "SpecializationId", "StartDate", "StudentLeaderId" },
                values: new object[,]
                {
                    { new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b"), 1651926713L, new Guid("2d3125e6-96ee-46cf-b463-10d6f49aa402"), 1620390713L, new Guid("249c3565-3c41-47d1-88e6-621398c458be") },
                    { new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe"), 1651926713L, new Guid("e078d27d-3057-428a-9578-326a5b969ea5"), 1620390713L, new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd") },
                    { new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9"), 1588854713L, new Guid("5ecba4df-60e5-46bb-91e7-f96312e14e7f"), 1557232313L, null },
                    { new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3"), 1620390713L, new Guid("5ecba4df-60e5-46bb-91e7-f96312e14e7f"), 1588854713L, null },
                    { new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e"), 1651926713L, new Guid("5ecba4df-60e5-46bb-91e7-f96312e14e7f"), 1620390713L, new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab") },
                    { new Guid("b189dc61-46cc-4cab-a913-633ff0dee857"), 1588854713L, new Guid("80632e42-b5f6-4eaa-9683-49f052fca4f0"), 1557232313L, null },
                    { new Guid("52af14c0-7757-40ae-884e-88e3013b730b"), 1620390713L, new Guid("80632e42-b5f6-4eaa-9683-49f052fca4f0"), 1588854713L, null },
                    { new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670"), 1651926713L, new Guid("80632e42-b5f6-4eaa-9683-49f052fca4f0"), 1620390713L, new Guid("fe763220-9d76-451a-add3-d88a4e35722a") },
                    { new Guid("88791463-d7e2-4c57-b665-e12a14104b05"), 1588854713L, new Guid("17d9eef8-a266-41cb-8d39-3b53a12d6580"), 1557232313L, null },
                    { new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634"), 1620390713L, new Guid("17d9eef8-a266-41cb-8d39-3b53a12d6580"), 1588854713L, null },
                    { new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb"), 1651926713L, new Guid("17d9eef8-a266-41cb-8d39-3b53a12d6580"), 1620390713L, new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6") },
                    { new Guid("529a8b66-6849-4683-abcd-872d416fd5fd"), 1588854713L, new Guid("20764258-d0a1-439a-aa0b-7fb740e33dc9"), 1557232313L, null },
                    { new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa"), 1620390713L, new Guid("20764258-d0a1-439a-aa0b-7fb740e33dc9"), 1588854713L, null },
                    { new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4"), 1651926713L, new Guid("20764258-d0a1-439a-aa0b-7fb740e33dc9"), 1620390713L, new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea") },
                    { new Guid("830de201-cff7-4415-b7e1-c6957b4dce49"), 1588854713L, new Guid("2d3125e6-96ee-46cf-b463-10d6f49aa402"), 1557232313L, null },
                    { new Guid("33bb17dd-3a83-4044-8ca0-3ee2f3911cbf"), 1620390713L, new Guid("2d3125e6-96ee-46cf-b463-10d6f49aa402"), 1588854713L, null },
                    { new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5"), 1620390713L, new Guid("e078d27d-3057-428a-9578-326a5b969ea5"), 1588854713L, null },
                    { new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d"), 1588854713L, new Guid("e078d27d-3057-428a-9578-326a5b969ea5"), 1557232313L, null }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("cbee3a72-69e1-4933-bb6b-a55c38ca4a0e"), new Guid("87f909d9-267a-4710-bb98-687652181b48"), 1647781930L, new Guid("9b342db1-edd9-4031-8d39-95f30c0141a7"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("70feadbf-3837-479f-a6fc-c839052c7ebb"), new Guid("5556d781-9a8c-4bc8-8b2d-7569b09b497b"), 1647781930L, new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"), new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("c85f17f3-c606-4de7-ae59-5d50f5752e0f"), new Guid("0b2c4f43-a881-4b96-b697-2baec5d6ae9e"), 1647781930L, new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"), new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("b6d19c2c-bf68-4da2-adc4-a6579ec7a873"), new Guid("67a22ec5-8bf1-46c6-b087-bb33ba0db7c8"), 1647781930L, new Guid("b96d78b3-d8cb-4634-8534-636517564e76"), new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("72af3d3e-e025-4030-b0e9-66c0b12966db"), new Guid("eeb27e3b-7129-4274-ad3d-38ccaff788d7"), 1647781930L, new Guid("9e7ed602-ce49-4120-8013-d672ff620db5"), new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("455ec276-c978-4a9f-ba44-92d1c8c35c34"), new Guid("bb8cf7e3-f07e-4d72-baaa-3fc8a0193fce"), 1647781930L, new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"), new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("42d1792b-a833-43ce-8c1b-04cd9e9b5f4a"), new Guid("62e33f6d-1316-421c-9b5d-97f86a9654d0"), 1647781930L, new Guid("045fd78f-d876-4b31-8e8e-93c7f28fba90"), new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("92da88d4-06d4-47b3-b192-fd9815a0d914"), new Guid("7434bf02-5d81-4cce-a463-8b8620d20efb"), 1647781930L, new Guid("2e6514ee-f003-4a1c-b604-ee104cb18e9c"), new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670") },
                    { new Guid("5d128c2b-ecfe-49a0-aa58-4364c2a48b47"), new Guid("bcdefb44-008a-449e-bc13-762db3f6614c"), 1647781930L, new Guid("27c21c60-30bb-4cb7-a3e3-4857aab19659"), new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670") },
                    { new Guid("410bbcb8-473c-4efb-98eb-b6f25b2f59c1"), new Guid("0eb78f8e-6486-498e-abaf-e7a8ff52a03c"), 1647781930L, new Guid("b886c14b-274f-4bd7-be28-3e8f37ea9503"), new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670") },
                    { new Guid("057ed007-9d5c-4d8b-b13a-c740482d6d90"), new Guid("424a4d8b-8887-48a8-bf0d-107c4d589182"), 1647781930L, new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"), new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("08a5392c-7208-4cd6-beb5-05f47b13aebf"), new Guid("18a341f9-d05d-4dad-a4ec-725e6fc25adb"), 1647781930L, new Guid("671a6804-d308-419d-b56e-84b4c8858681"), new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("1fc4bec6-c9bc-46f4-b99a-d59d796979ec"), new Guid("cdf85e3d-470c-467c-a72b-c1c4ab9effc9"), 1647781930L, new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"), new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("1c2963a8-6ff8-4eb2-8fe6-3158e8451e33"), new Guid("d0e6bd46-38cf-4efd-adb2-6cdd458afd2a"), 1647781930L, new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"), new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("32def790-e8e0-4fb2-8ba2-3b79829ce408"), new Guid("0d95f6da-d6ff-43c7-b438-b2e7a29e6035"), 1647781930L, new Guid("a2263c6b-31e9-4242-8663-697fcc365987"), new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634") },
                    { new Guid("d2aae668-75ee-4b94-9828-8b960cccf0ef"), new Guid("0d95f6da-d6ff-43c7-b438-b2e7a29e6035"), 1647781930L, new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd"), new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634") },
                    { new Guid("b950f2d6-1840-4f68-8983-1fd267e848cb"), new Guid("353dfdfe-d039-4855-8d1b-9fef20b86a07"), 1647781930L, new Guid("c62ff166-4f6a-4126-916a-ea30a7804072"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("49d409f3-9bc7-45aa-b498-11058b36d74a"), new Guid("7c221e27-d7c4-4cd9-9696-ed276a0db0f8"), 1647781930L, new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("5d3186a6-c001-49c5-b85a-915ce362a022"), new Guid("3b4511bc-9d42-4045-959a-c600cd7ddb6a"), 1647781930L, new Guid("c868fdb3-b9c3-4a4e-9727-bf3cf5f2b20f"), new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("50f7ae2e-70f8-4b30-8162-8cda07106544"), new Guid("12e1e64f-b7ba-407c-8e0c-de37d9c6a986"), 1647781930L, new Guid("99d71edc-63a4-4a24-b278-b49d0bb19f49"), new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("49fad271-d029-498e-bd3e-ea8f4ad208ad"), new Guid("c01a8e4f-ddaf-49ba-b3fc-7e8dc962addf"), 1647781930L, new Guid("936e7f20-6944-43f3-8e3d-99bccbeb26c8"), new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("20da02ec-2fe1-48f4-91e7-09d47718c53c"), new Guid("5556d781-9a8c-4bc8-8b2d-7569b09b497b"), 1647781930L, new Guid("9d71a4b5-d03c-4341-bf59-2920f6ae260e"), new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("5a7ed22a-738d-48f8-bda5-7e5fd7128e2f"), new Guid("7f399728-b435-443b-8fb7-7bf58eb8fd09"), 1647781930L, new Guid("b73b2bfd-896d-42d9-8768-2bda7f1fc5aa"), new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d") },
                    { new Guid("9fd6e87a-3dc5-43b2-b7f9-ac34221d5b03"), new Guid("1f11cb47-a2e7-451c-a889-a80257623e34"), 1647781930L, new Guid("0cbd6601-75d8-4c01-aab1-45d423fa9319"), new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d") },
                    { new Guid("f5d8e93c-1b35-4949-a0e2-cbe78a11e8c6"), new Guid("8fab1726-e000-4f6c-9e7a-49d3f0b75a43"), 1647781930L, new Guid("b7410b97-9dd3-403f-bad8-9ddae8158612"), new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("153d9b08-e8d6-43e9-bf9d-335652e47b03"), new Guid("9d061641-b81f-41f2-aeaa-48a436317e31"), 1647781930L, new Guid("3d66a605-b2f6-414e-b4fa-7a679521bbdf"), new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("bdb4b6f4-d978-4671-8af4-1bb183ec2436"), new Guid("67a22ec5-8bf1-46c6-b087-bb33ba0db7c8"), 1647781930L, new Guid("8ea1e7b2-5649-4204-aed8-c92eba7ef250"), new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("877d04ba-05a0-4ff8-9676-f1ad27d2cc8b"), new Guid("353dfdfe-d039-4855-8d1b-9fef20b86a07"), 1647781930L, new Guid("9803212f-9417-4247-b409-1faaf7e69066"), new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("7c0021e0-cae9-4595-9c62-8d93165b6a8e"), new Guid("aadab007-b362-46ed-a688-860990c1ce67"), 1647781930L, new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"), new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("3f2fb528-b9dd-4613-987a-5fd16ec4bac0"), new Guid("d24e31dc-caab-40e0-8195-6f702aa19e56"), 1647781930L, new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"), new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe") },
                    { new Guid("4a5ea580-b8a2-4d90-955b-36cd0753c6b1"), new Guid("3d329348-1e54-45bb-b1dc-f8359d8eca3a"), 1647781930L, new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("071177d7-0c37-4eec-82bc-68eec427b1a3"), new Guid("52a1bf69-48b8-4333-930e-8b8603fd5dba"), 1647781930L, new Guid("fe763220-9d76-451a-add3-d88a4e35722a"), new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe") },
                    { new Guid("6eb8176d-3569-41d2-8822-c9623c70c08f"), new Guid("4a895a13-7960-4ff6-92b3-61afaad832a8"), 1647781930L, new Guid("f19daf6f-9705-4a6f-a953-9d9d69604436"), new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9") },
                    { new Guid("ba0b82c5-25f8-4ca9-9bbd-9de9f94ddf10"), new Guid("46401e74-4daa-4cbf-977b-de06701233b5"), 1647781930L, new Guid("8f30ff42-f259-4b6a-90b2-3745f361afff"), new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9") },
                    { new Guid("f7077bb1-307b-451f-b59f-04b1e4ac9df9"), new Guid("6d945629-fc20-4a2d-840e-9efc331dfae0"), 1647781930L, new Guid("e86bcb2a-cd9b-4175-a190-d4872e96e236"), new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("08ec12a1-ebaa-4051-bec4-0e4e6c3ec355"), new Guid("3796f44f-4e6d-4a0d-931a-67de6eca130b"), 1647781930L, new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab"), new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("cda18b9a-2870-43fe-8bf1-e591d08b88b5"), new Guid("1d687ef2-33f0-4d7a-89cc-01aec8e2d2ea"), 1647781930L, new Guid("62cef015-f0eb-4a6d-a0ce-43263a9de3e5"), new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("0fdf8da3-57f9-4e5e-b0ba-0b5f57489937"), new Guid("5c1d34d9-2bfa-4cf5-aea7-e15eeddaae0b"), 1647781930L, new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"), new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("1b945c34-75b3-443b-a548-bb1146124464"), new Guid("64213c26-f20c-496a-91f9-a1872cc9249a"), 1647781930L, new Guid("4c941439-f62a-48fc-8aa6-d047333edb44"), new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e") },
                    { new Guid("c0d97e34-c60f-46db-9d66-9a25fbb4ce51"), new Guid("1e64fce0-c64e-4952-9ca4-ded612da49d6"), 1647781930L, new Guid("b3050769-754a-4389-8690-8ec99304fb18"), new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e") },
                    { new Guid("58e3ec4f-428e-4f7e-904f-67a94533875d"), new Guid("7f399728-b435-443b-8fb7-7bf58eb8fd09"), 1647781930L, new Guid("e67b668b-c463-423b-8022-1832825cb1be"), new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe") },
                    { new Guid("ff6edd23-ccb2-4d40-bf76-d430d60dc0c2"), new Guid("fb9f1d4e-b0fc-4f5d-bd9d-ca86e5e5443e"), 1647781930L, new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("f9a8c198-dfd3-464f-bda6-7d87de92a5bd"), new Guid("0dad3774-03bf-4c41-8cbc-640fdae1ec2f"), 1647781930L, new Guid("7c117e49-26a5-44a1-ad74-028fc5ccc9cd"), new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("c698b886-87d6-42d3-ad3a-6e066cbcd250"), new Guid("3620dd07-5455-460c-a309-1adbf056f069"), 1647781930L, new Guid("2273247a-5ea9-4956-bbe3-e4e1fbedc68a"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("3b4076e9-06d5-4907-8d23-431bcb6f8120"), new Guid("45060f12-ece6-4b97-b565-daa07f1ee078"), 1647781930L, new Guid("14acfd39-649e-44bb-b4c9-81bb485c1565"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("13cbb5dd-1880-4aa3-b875-060e7511e5e7"), new Guid("d315edc1-b4a1-4a4a-a2ee-ef2c5ed5c1a2"), 1647781930L, new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("7ea46b3b-7a1d-4fb5-ae7d-fccd5445f021"), new Guid("aadab007-b362-46ed-a688-860990c1ce67"), 1647781930L, new Guid("ce097aa9-4fb3-4a6e-ad49-ac8a555743d6"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("493831c9-eafa-46f4-988f-a34625ee0aff"), new Guid("1e64fce0-c64e-4952-9ca4-ded612da49d6"), 1647781930L, new Guid("44ff300d-60b2-405f-aeae-46d9f3a15240"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("84c05a90-29ab-40ef-92b6-ada5bcb4f043"), new Guid("260ffeb4-a7d2-407d-adea-421016739dba"), 1647781930L, new Guid("566cf487-3ed6-40c5-ae72-d3741beff430"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("d82d6b1c-3fb5-40d3-b1af-899d85a60d21"), new Guid("999028dd-0e3f-40e6-8b7b-7eebe90fe176"), 1647781930L, new Guid("cc555932-1240-4511-8879-82d6a043a116"), new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4") },
                    { new Guid("6b911cfb-326a-4393-b134-cacc021a1892"), new Guid("d0e6bd46-38cf-4efd-adb2-6cdd458afd2a"), 1647781930L, new Guid("d50391ff-a32e-4abf-b45f-5e4cf058b204"), new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4") },
                    { new Guid("e37fefde-dea3-4bf0-8dac-c34379778afc"), new Guid("5601e26f-0be7-420e-82aa-5c82d5f10a9b"), 1647781930L, new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"), new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa") },
                    { new Guid("6b7b3c36-3fa7-43e6-96a8-4d31f2ad7a96"), new Guid("1939b7f4-ebea-43b0-b458-c9ea10b7441d"), 1647781930L, new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"), new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa") },
                    { new Guid("3cc25cc3-f9cd-4830-b200-20a573b3cd20"), new Guid("d315edc1-b4a1-4a4a-a2ee-ef2c5ed5c1a2"), 1647781930L, new Guid("42c6514f-3632-4599-af6a-982cf4845ef4"), new Guid("33bb17dd-3a83-4044-8ca0-3ee2f3911cbf") },
                    { new Guid("fbd48093-5de9-4dee-b28b-b3901503511f"), new Guid("eeb27e3b-7129-4274-ad3d-38ccaff788d7"), 1647781930L, new Guid("584cde08-c075-407e-a09f-d5a533fbc45f"), new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("e551073a-89e0-4d67-8085-4da0afec167b"), new Guid("51868205-f576-4dc7-a5bc-a01e8b9128a2"), 1647781930L, new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("7d7191d2-9395-431f-99f2-050f1ff43aac"), new Guid("64213c26-f20c-496a-91f9-a1872cc9249a"), 1647781930L, new Guid("249c3565-3c41-47d1-88e6-621398c458be"), new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("a8493ec3-486b-46d1-8364-00149b5a4a25"), new Guid("0b2c4f43-a881-4b96-b697-2baec5d6ae9e"), 1647781930L, new Guid("338fe279-f58e-4c5e-9081-9648454a2753"), new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("34127cdc-9c08-4d4a-9af0-3422bb9b3d2c"), new Guid("fc76e366-89cd-4503-87eb-c8aff678efb3"), 1647781930L, new Guid("697a9e49-5424-4293-803b-71cde4bd3c23"), new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("45cc6989-5db9-4ab7-bd06-2ac14ac3cf2d"), new Guid("bd7b713d-c747-40f1-a165-3d8e1ec41b5d"), 1647781930L, new Guid("ea4c9cd4-14d3-456e-aa97-e835f7f8dbff"), new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("c5aa5f58-d3b6-4e7b-90e6-e4d69f762ecf"), new Guid("94c2c181-3280-443a-9cf6-f8fb44a711d0"), 1647781930L, new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("b343d71e-3ea3-4d43-a2b9-11f9c0b8983d"), new Guid("bcdefb44-008a-449e-bc13-762db3f6614c"), 1647781930L, new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"), new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("ea5e953a-d232-4771-9e5c-2c62caa389be"), new Guid("4a895a13-7960-4ff6-92b3-61afaad832a8"), 1647781930L, new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("6552e531-7645-4ebf-aa0b-e91919d6fd95"), new Guid("de4c4358-6826-4479-83b2-4d2e56574803"), 1647781930L, new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("a550e131-3354-4d15-bb0f-e1db5eff1dec"), new Guid("ac3c82f7-db08-4e04-98e9-943dc2294c9d"), 1647781930L, new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("1997a2b9-4c57-4e6f-a019-51615b59f619"), new Guid("6d945629-fc20-4a2d-840e-9efc331dfae0"), 1647781930L, new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("63d8e751-27aa-4eb8-8110-1ba58876a302"), new Guid("43415428-9485-44f6-9ed7-6f696e0c17ed"), 1647781930L, new Guid("4c2b1381-e9ec-41e5-858f-0b4e03a0b1dd"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("fbd5dcd9-ea40-4aa2-97a7-02841dd7a46f"), new Guid("1f11cb47-a2e7-451c-a889-a80257623e34"), 1647781930L, new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("42dac590-df57-45b6-818b-652408de3243"), new Guid("3e827b50-38bb-4049-b554-ad4db7c6f079"), 1647781930L, new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("e67a8670-d3a2-4fdd-acfd-085a5af0ad25"), new Guid("0d804411-bbbc-4de0-af5d-21ffdd14972a"), 1647781930L, new Guid("27f1e861-b79c-4143-9b88-69313b52ccc0"), new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("e185d4e0-43b6-44d1-a348-8902dc34230f"), new Guid("c01a8e4f-ddaf-49ba-b3fc-7e8dc962addf"), 1647781930L, new Guid("f43b2256-f1d4-4685-be74-d6d3ae8c76f0"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("f24a5d16-291d-4a20-bfbd-d2c1a8a98d40"), new Guid("94c2c181-3280-443a-9cf6-f8fb44a711d0"), 1647781930L, new Guid("f518e1c2-2090-486c-8c45-02484ff2577d"), new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), (short)1, new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), (short)2, new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3") },
                    { new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), (short)1, new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9") },
                    { new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), (short)2, new Guid("33bb17dd-3a83-4044-8ca0-3ee2f3911cbf") },
                    { new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), (short)1, new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), (short)2, new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9") },
                    { new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), (short)1, new Guid("33bb17dd-3a83-4044-8ca0-3ee2f3911cbf") },
                    { new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), (short)1, new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), (short)2, new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b") },
                    { new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), (short)2, new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe") },
                    { new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), (short)2, new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5") },
                    { new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), (short)1, new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), (short)2, new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), (short)1, new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e") },
                    { new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), (short)1, new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), (short)2, new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb") },
                    { new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), (short)1, new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634") },
                    { new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), (short)2, new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634") },
                    { new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), (short)1, new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d") },
                    { new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), (short)2, new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("5ce360b4-a52b-469c-864e-581079032040"), (short)1, new Guid("529a8b66-6849-4683-abcd-872d416fd5fd") },
                    { new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), (short)1, new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), (short)2, new Guid("88791463-d7e2-4c57-b665-e12a14104b05") },
                    { new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), (short)2, new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e") },
                    { new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), (short)1, new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670") },
                    { new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), (short)2, new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa") },
                    { new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), (short)1, new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa") },
                    { new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), (short)1, new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), (short)2, new Guid("52af14c0-7757-40ae-884e-88e3013b730b") },
                    { new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), (short)2, new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4") },
                    { new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), (short)1, new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4") },
                    { new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), (short)1, new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), (short)2, new Guid("b189dc61-46cc-4cab-a913-633ff0dee857") },
                    { new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), (short)1, new Guid("830de201-cff7-4415-b7e1-c6957b4dce49") },
                    { new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), (short)2, new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670") },
                    { new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), (short)2, new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("64405800-89e6-4f77-90f7-c13578d6d239"), (short)1, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("fd779d9b-b543-43d4-bae9-9de11e308dc5"), (short)5, "Course26", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("2ebe39e6-b72a-4977-a44f-f27a6870982a"), (short)1, "Course0", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("371c1501-8580-4fd0-8a30-eb182bc70451"), (short)2, "Course6", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("6b62f55c-0e28-4b4c-bae3-171f8acb6a5f"), (short)2, "Course12", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("0a06b723-cb36-4b76-bdfc-6c6d717211ad"), (short)1, "Course18", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("bbe6d1e6-e3fb-4f19-8caf-1f8814c87add"), (short)3, "Course24", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("72476355-7399-4ffc-a499-6e97b263d9c6"), (short)3, "Course30", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("62fbfb80-e33c-4714-ab5d-0ddfbf3ee43d"), (short)5, "Course13", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("b2d1c2b8-9e9f-4635-8fd0-846f02fb9d8d"), (short)4, "Course0", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("e8eb8888-96c9-40f7-93f0-e98cdeb60090"), (short)5, "Course0", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("4c535ed4-250c-49f2-986f-fbd562d33982"), (short)1, "Course7", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("04a6056b-34c7-4b6c-82c7-fe47bb025037"), (short)3, "Course14", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("ea6235b6-fa6b-4fb3-94e4-37598aaac66e"), (short)5, "Course21", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("3867216e-18d0-459f-b372-953fc4bc6c30"), (short)5, "Course28", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("227517ea-5d47-4d30-94c4-1b3af3a2fe51"), (short)2, "Course35", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("38c91055-e677-45d9-b5f9-64c6646420ef"), (short)0, "Course0", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("a0ed1c53-c258-4a06-9d3c-b0e15c379576"), (short)2, "Course8", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("6301dc06-9567-4a3c-88bf-56892b58362b"), (short)2, "Course16", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("dd1e5883-f075-4e12-95a1-5672b733eae4"), (short)5, "Course24", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("31522d38-e786-439e-9d70-9d65f1bc9d95"), (short)2, "Course32", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("05203082-9fd5-4963-a9f1-d6ca700c026d"), (short)2, "Course40", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("d43ea49d-731a-494f-8d56-f33cb3e13904"), (short)4, "Course60", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("0faee491-5220-46be-b77c-b74210ae7d3b"), (short)5, "Course48", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("4ff1b4d5-6c3b-4c19-ad18-76fd6f083f42"), (short)0, "Course39", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("63176cad-bd54-46b8-a630-f52eb85b1a91"), (short)5, "Course145", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("0a6cb981-6a01-446e-8677-65f0bbeebb20"), (short)1, "Course116", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("3343cb96-87da-4ccd-a098-aac7de9fe818"), (short)4, "Course87", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("776cddf0-e5f6-40c7-bdd5-17097a31f30d"), (short)2, "Course26", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("c15113d0-860a-40b6-860d-28208f07a0f1"), (short)3, "Course136", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("2b58e310-d41a-423c-8eec-252ceccf452d"), (short)0, "Course78", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("e0b5ca73-b8fb-4dcd-bdca-4971b3056fbd"), (short)4, "Course104", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("42eba954-a921-4c25-912f-49aae554205c"), (short)5, "Course130", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("6eacb058-9ff9-4c1d-9b4e-7d1f3d23fa43"), (short)1, "Course14", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("0ac7df8c-ff1e-4126-a7df-8dab9d4a0766"), (short)0, "Course0", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("7b42cf3e-7b49-4603-885c-18cf3eee895f"), (short)5, "Course0", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("376db3ef-08e7-480c-bafb-7e5085de538d"), (short)3, "Course27", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("adc44710-0250-4dd3-87d1-daa2116cf255"), (short)5, "Course54", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("2936e7d4-e81e-43b0-abe6-a1d582af0022"), (short)1, "Course81", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("45863316-e7f7-46d3-996b-510b20e82c23"), (short)3, "Course0", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("3e1dfe68-7ae7-4835-a55d-359ef88c9d81"), (short)0, "Course108", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("cbbd2137-1c04-4326-9c83-237de8802694"), (short)0, "Course0", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("fcd2b3fa-3efd-4ec2-bca8-8f07aa1cea51"), (short)3, "Course28", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("267c5f8a-2e1f-4d0a-b327-a5b3ad874ba3"), (short)1, "Course56", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("86e28ccc-5ca9-41ed-abee-63e9d8cf246f"), (short)1, "Course84", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("bd6b42fb-fd23-4888-80ff-ce8e1f5beb70"), (short)5, "Course112", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("9f670bd8-431b-49df-90ef-313359b8a44a"), (short)3, "Course140", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("5a6497ea-34b8-4b60-9674-bed88dcbe6d7"), (short)3, "Course65", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("e5e1f6dd-2e81-4cca-a65e-632b5a5d66ff"), (short)5, "Course52", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("28021a3d-0c23-4e82-aef7-03601a2f2142"), (short)5, "Course0", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("bbd6f5ec-7517-4957-bea9-e91708d2fedc"), (short)0, "Course29", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("8baeaced-ca8f-414e-b2c6-c3c08aa30aa0"), (short)2, "Course58", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("787b5ced-8b8e-448c-8e5a-d21f739ffa37"), (short)5, "Course135", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("c446b936-dda0-435f-a14d-3b0894df7f20"), (short)0, "Course9", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("6163bbf8-c56f-43b4-b658-4cc3a5986bdf"), (short)0, "Course18", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("40d35dd0-fdaf-4429-b288-d81726554d08"), (short)2, "Course27", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("f9a9411a-b16a-4fdd-bec8-a3fba5313173"), (short)4, "Course62", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("3a1928f6-16a6-48be-9580-67e9d372ef8a"), (short)2, "Course93", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("4365fc8a-a908-43da-9893-7b9b0c1a7f7d"), (short)0, "Course124", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("44261740-82bf-445c-9c1f-8f8081062911"), (short)2, "Course155", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("92e27d69-e0d4-4f84-b6c6-7e91a5c9ebe9"), (short)0, "Course105", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("e483ef78-07c4-437b-82e6-96981b22ad8b"), (short)0, "Course70", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("5545e463-77a0-4584-83d9-1d1c0b6024a9"), (short)1, "Course0", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("557726a1-492b-4886-89d6-34396e431ae9"), (short)1, "Course32", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("47db7a00-723a-4c47-bebb-de227291e0ab"), (short)2, "Course64", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("25a149f9-0416-4f46-9756-812e80bf5b24"), (short)4, "Course96", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("050455b2-b1bd-429a-b9de-c1345c999ef2"), (short)2, "Course128", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("a8b1cf73-080a-4c6c-b18c-2cbbeabce6ee"), (short)0, "Course31", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("d625e6c8-ed11-4830-9c17-5e2a78916d80"), (short)0, "Course160", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("e13fc883-e93b-4d4e-82a2-bc85361a85b0"), (short)5, "Course0", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("60dd9128-33b7-4f07-937e-107b5126c438"), (short)3, "Course0", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("26b4bf13-5838-4891-8040-445939883012"), (short)5, "Course33", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("0c6ec012-3be9-4722-a670-9d2d00c5b287"), (short)1, "Course66", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("e7cd7e8a-c0b8-42a6-ac76-318c01da6e9e"), (short)5, "Course99", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("4d257ae9-3301-44e8-80f6-bda172bfcce3"), (short)4, "Course132", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("2e63b547-ee72-4a6c-b6da-752485bfd0e8"), (short)0, "Course165", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("35187d6b-20be-46a4-a5bf-4fe513773c17"), (short)2, "Course0", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("4c421f21-b43c-47b0-ba55-339103ff1eca"), (short)2, "Course34", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("85aa930c-7e62-4012-a0af-6d3e350bef9b"), (short)3, "Course68", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("d80eb285-cf02-4bcf-9079-d424705c9c85"), (short)3, "Course102", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("28e6b7b4-f6d8-4644-8fad-9bd931b98d16"), (short)2, "Course35", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("21c7ea0b-2a10-4030-811e-44ef64b9a249"), (short)5, "Course0", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("afbad7ee-4f8f-4417-9840-de331744d5a5"), (short)2, "Course0", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("5cbfb4e3-7065-4402-bb3c-5d2ac7448402"), (short)3, "Course175", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("6005e774-270b-43db-b404-eddddc81ac63"), (short)1, "Course36", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("aa7003f0-2804-4234-a6da-fdc8c2de0968"), (short)1, "Course45", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("5f3718a0-2fa5-486c-9335-c276c06318f8"), (short)0, "Course36", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("87d5fb27-bb48-4dc5-93dc-85a879b04565"), (short)4, "Course24", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("d8f364fa-513c-4708-9d55-1075529872cd"), (short)4, "Course0", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("9e504600-d7bc-419c-bfdc-9d8523708aaf"), (short)0, "Course10", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("523f98d1-5ab8-45ad-93bd-3891afe1b495"), (short)1, "Course20", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("509cd428-e955-4a30-a7f4-38ebec1a7d21"), (short)4, "Course30", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("6769c33d-864d-4572-b799-161f987e6a93"), (short)4, "Course40", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("96091698-03b2-4f8b-9787-4509ddabf6dd"), (short)4, "Course50", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("57ef3c03-a50b-46f5-a243-6813e5e5bb74"), (short)3, "Course12", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("ee5b895d-3fb2-4cf4-8850-a22ed291a98b"), (short)4, "Course140", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("9c0332a6-2336-4918-8799-126e8476f68e"), (short)1, "Course0", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("130653e5-95aa-46f7-8d8d-f5636594c904"), (short)4, "Course11", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("ae3454f7-d9ba-4eb0-9e44-f821ac2c7316"), (short)0, "Course22", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("25cde140-e6b3-4580-bb40-7a1c757cb5a3"), (short)1, "Course33", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("3d7bcaae-efbe-4603-9d0d-9883b40396e1"), (short)1, "Course44", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("69e6aa9a-3e1b-4fd0-815b-37f152427d62"), (short)4, "Course55", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("9ff285d5-907b-482f-b7ff-949509d0386b"), (short)4, "Course0", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("5d613275-cf54-4e48-964a-e95dfa05621b"), (short)2, "Course30", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("cb53740e-6303-4329-93dc-e4fe2e934152"), (short)0, "Course60", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("2392d13a-ac5a-41e1-bdd7-0d3337c312f8"), (short)4, "Course90", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("ca49084b-31dd-4bd9-8267-d438dd22d7f7"), (short)3, "Course120", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("4352e691-70bd-41ed-9826-b8ec291e3ed2"), (short)1, "Course150", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("f99343c0-9148-4d35-a9f8-a569ac963297"), (short)4, "Course0", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("5265b2c5-4b7d-4fb5-aa42-a954407a2250"), (short)1, "Course28", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("f7d5411c-edf2-41b9-a49d-819c38c9137e"), (short)4, "Course52", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("b2ce8681-6b6d-41fb-8ecb-324e1cd9fb06"), (short)1, "Course125", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("64c56ab0-41b4-43ea-b407-a7aae3ece8ce"), (short)3, "Course0", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("48fe1fc7-d9c5-491f-90d5-e6739f7e96cc"), (short)1, "Course4", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("cdc726cb-f2ab-4366-84b1-8372e6c530f1"), (short)1, "Course8", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("5c6ce77c-bc34-4dcf-898e-cf190455e843"), (short)5, "Course12", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("0db21aa8-beb5-4f63-bf0d-f4e7b3c29ee9"), (short)3, "Course16", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("f9f2b46c-4339-4537-adba-1d29a6f297f5"), (short)3, "Course20", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("58f07413-d67e-4ec0-831b-2b7bcac5cf7c"), (short)0, "Course80", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("d6af09ee-95af-41f5-97fa-82cbb606b9b2"), (short)0, "Course64", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("e7de445b-9a97-4ae9-a4da-0cd59fe6b6c2"), (short)3, "Course0", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("82f9ed19-ceb1-4af6-a4f9-6176d4f8346e"), (short)2, "Course5", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("58cce350-a004-466d-b5de-2954e4b317e8"), (short)1, "Course10", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("637c147f-4773-4dae-8763-d978b516f6c8"), (short)2, "Course15", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("2da40d30-b625-438b-baa8-3f0f91a91326"), (short)3, "Course15", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("5f3614be-37ca-4287-a81c-3874993007eb"), (short)0, "Course25", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("a0204106-278e-40c3-a396-d52c42fa9318"), (short)4, "Course48", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("56ac2e5c-ae54-4706-b5ed-b56e577dab4e"), (short)4, "Course32", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("09a3d5f2-978c-44e8-ad9e-feea73b88ace"), (short)3, "Course0", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("7739cf11-f916-43fc-a50e-46689ec82628"), (short)3, "Course18", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("c062e50d-f71c-41e0-9d00-797ea584e432"), (short)3, "Course36", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("acaaa03d-44e3-4b4e-b85d-75947c11b625"), (short)0, "Course54", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("256c22d4-f992-4989-a5ee-6be548104afc"), (short)3, "Course72", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("e7f1a7f1-9e41-47b2-b67a-74bf1189d7c0"), (short)4, "Course90", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("64020ad4-31cc-44c0-97ec-f082090dea97"), (short)3, "Course42", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("9ab00069-18e5-4f71-ba53-efefa37d3a38"), (short)3, "Course0", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("2d1f03c0-4b69-4b0e-af79-f25eb0222d70"), (short)5, "Course20", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("210a5494-436b-44aa-958e-0c2f2cce37be"), (short)2, "Course12", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("32509806-4fb3-4f42-a787-68c00042177a"), (short)5, "Course9", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("7ae0ea13-3a70-474b-8111-4e1090e918de"), (short)0, "Course6", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("8510ab3b-c727-406a-8a45-81e2e74bb2bd"), (short)3, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("f22b1a5a-e442-42ea-a95b-92811b9e425f"), (short)4, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("032d315b-8fb2-477f-8f70-a376b8655785"), (short)0, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("3cf8ce3c-00ff-49e2-b866-f90cca36896f"), (short)1, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("2e12affc-a28c-4d10-ba57-cd2e66ea7671"), (short)4, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("6d1a9e21-f9cc-45f4-8898-a2102b6bea6d"), (short)2, "Course85", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("f1ade7bb-ce65-4a64-bc33-065ee2aab4f4"), (short)2, "Course68", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("f7f5d255-8037-4e69-a269-9b21a035d571"), (short)5, "Course0", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("a0172c76-fa04-4444-98a0-8f5b33890353"), (short)3, "Course1", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("44ae3f4e-6f6d-40f2-a6e2-02127260578f"), (short)3, "Course2", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("947cae5c-9659-4bb7-8c0d-082f513b5f81"), (short)0, "Course3", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("98ec5dcc-ce79-47cc-9fd6-93f1fc87da00"), (short)2, "Course4", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("bdb04d09-ba94-42ae-bd5a-984f14d37685"), (short)5, "Course5", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("14979426-0ac2-49fe-91c2-a40ed5906a3f"), (short)4, "Course51", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("d1179fa8-a82c-443e-91ae-3181aa3362c5"), (short)0, "Course34", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("49314f46-670b-469d-ad6c-8b3d0ae05510"), (short)2, "Course0", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("8f8700e0-75cd-451b-b08c-54796803351a"), (short)4, "Course2", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("8e0b0593-32f9-4beb-9b97-7d2384e256eb"), (short)3, "Course4", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("613c296a-1278-46d6-b46c-8f4f087bdcf8"), (short)2, "Course6", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("0e4f375e-e72b-431d-9532-c3562ad9b883"), (short)0, "Course8", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("0da3c5d3-eace-4894-8fdd-c9073c906417"), (short)0, "Course10", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("3d0766d7-2734-4708-845c-543c62f4bf54"), (short)4, "Course17", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("c47dfc13-0149-4a2f-8d8a-7f3da4fd0753"), (short)0, "Course0", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("6df55ed3-1908-41bc-8393-4a364ae2b427"), (short)4, "Course0", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("e99bed10-9918-40b3-bd0a-f6b6be678ea5"), (short)3, "Course3", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("4f36fc4c-e323-4c85-a3f2-2af7d5c9aad9"), (short)0, "Course0", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("aef90c4e-0a7d-4f41-a0c4-e456e96ae77a"), (short)2, "Course19", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("a0cd820c-9f6a-4e4c-b6f5-6405d4d8e541"), (short)2, "Course16", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("d9342a97-e4aa-4adf-9d20-2611c3a60145"), (short)3, "Course57", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("5c5b6ad7-1a3a-4e91-b3ed-5d2eb9806afa"), (short)5, "Course88", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("45ef827c-6be2-456e-8188-180d4e091fc7"), (short)2, "Course110", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("f826f0ff-d005-4f53-9790-882c810a0357"), (short)5, "Course15", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("a9b96aae-f867-4518-be80-e0454870c02c"), (short)1, "Course0", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("18513cfb-64f8-4b72-a45e-0c39bb988cd4"), (short)2, "Course0", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("7333ac7c-d8ba-4926-aa2d-db0d7387f51b"), (short)1, "Course23", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("f895f12f-e31e-4d56-b27e-fa54085512c8"), (short)0, "Course46", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("9a514701-4841-4ddb-8919-7a75c284f979"), (short)5, "Course69", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("593f007e-e61d-457b-a5d5-07914de0bc8c"), (short)0, "Course92", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("14b27a0a-3fe6-4512-8843-ea9b9e6e1a63"), (short)2, "Course115", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("bf03a577-1c94-455a-9cad-b85df1a86410"), (short)0, "Course0", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("e294e887-d24b-456e-8fe7-4e91756b8c9c"), (short)0, "Course24", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("c2be17b7-4797-4eb2-a631-9c5bc01cd470"), (short)4, "Course48", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("937592a7-6fe7-45fb-8944-e25bc47edc05"), (short)1, "Course72", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("174439d1-3a4c-4475-8038-ab1ebb9fef14"), (short)4, "Course96", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("74e7446a-4e0b-4cec-8742-d4b4e8aec180"), (short)1, "Course120", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("f309c0d4-4200-4c38-bc51-734ba163729b"), (short)0, "Course70", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("3872c942-d892-4c0a-86eb-7a5d44be918c"), (short)2, "Course56", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("e84bf635-e05c-48b8-bfc9-74fcca09a5a6"), (short)1, "Course0", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("ffa7bb50-9c15-43db-a53a-16e87538a26e"), (short)3, "Course25", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("ac5a0d55-d5cb-4b6b-a6d7-00a19841123a"), (short)0, "Course50", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("91f8b8a5-756e-41f3-a338-87add69b3a9f"), (short)5, "Course75", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("f1baa342-6f8c-45cc-a847-bf0baca5a8d7"), (short)5, "Course100", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("b44b1f52-e46d-4f55-a782-05a5c5cbd7cf"), (short)2, "Course38", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("bf95e9c5-6d0b-466d-a80f-3b4019fa7f7e"), (short)0, "Course44", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("c5fb0791-a031-458a-875c-da8111945286"), (short)1, "Course66", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("7b0d138b-8116-4e39-9fcf-59ebfcb3b0cd"), (short)3, "Course170", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("8282a8f4-f6bf-4deb-b3a2-571bb2a404be"), (short)2, "Course40", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("9215dc4a-f1ca-46d3-8976-f23fdcf84239"), (short)2, "Course60", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("6e66e473-88ae-48ac-9387-3104ef34b0d0"), (short)4, "Course80", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("8999bfe3-90ec-4982-a98f-7695c871a4aa"), (short)0, "Course100", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("d580d97a-1ed5-4d06-b0a1-c155de54eef6"), (short)5, "Course75", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("7a10e3d8-8aca-4793-88ca-62b772f94af6"), (short)2, "Course22", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("c4bef1c7-dac8-44a3-9322-07eccf6f9f62"), (short)5, "Course60", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("3cfabe05-7d45-43eb-bbaa-47f99453ff36"), (short)5, "Course20", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c") },
                    { new Guid("6d70231c-8da5-4b78-aa61-3ecb34a739f2"), (short)4, "Course21", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("ee9912ca-bf07-44be-b8c3-c13deac5fb25"), (short)1, "Course0", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("115699c4-686c-40e0-ae46-7ff9ef888a56"), (short)1, "Course63", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("cd26a405-e633-4a4b-9643-50c693e45072"), (short)5, "Course84", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("d590fcc6-c6c7-4700-be89-c7b8aa1e999e"), (short)1, "Course105", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("1473702f-8ca0-41c5-af85-f68c51d9e187"), (short)2, "Course45", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("aff12f58-3357-4ae4-8346-e92ba68aeeff"), (short)3, "Course95", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("d131ab61-c941-44c7-8801-7f8caf05917d"), (short)4, "Course30", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("f189614c-eeab-4fcf-8b43-e44671b5ebea"), (short)4, "Course0", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("f24d3db2-3393-4576-b22d-528d574cfec9"), (short)2, "Course76", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("d476deb6-ab70-4e75-826b-f3e06b08b482"), (short)4, "Course42", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("d07aac90-bc09-437a-923c-95ace287c0e9"), (short)1, "Course0", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("7f99321e-42e7-41ce-8e5a-a9fc685108ba"), (short)4, 20, "Course0", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("772727f6-0df9-4d59-be84-5b6c809c17fa"), (short)2, 20, "Course0", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("5700ca1d-c03c-416e-a24f-6c18c16a4207"), (short)2, 20, "Course34", new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("0fc0abb6-5756-4571-903a-4772c3aa26e0"), (short)5, 20, "Course15", new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("8cdd9286-ef35-4632-9ce4-0fee9d4c364b"), (short)5, 20, "Course0", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("106e30f0-71f2-42f0-bb44-ef429cdd5092"), (short)3, 20, "Course12", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("2a814e07-9e7e-4fa7-b87e-a39044ceb334"), (short)1, 20, "Course13", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("9d86a001-ad88-423e-904c-2c3e386431a4"), (short)4, 20, "Course0", new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("c4983706-6cf5-46ab-ac16-c67ab850bf76"), (short)5, 20, "Course14", new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("e129d72b-0566-4b37-9d3f-d50e2ef5033d"), (short)0, 20, "Course35", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") },
                    { new Guid("081d9ff7-b487-4626-ac7c-f5ab4e246eba"), (short)0, 20, "Course0", new Guid("67f71d18-25e2-445f-b519-7312728a4c08"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("cbbe77eb-a4b7-4353-973e-83243f6ecfb0"), (short)4, 20, "Course16", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("084de768-8e07-49b9-8b87-5805f5928a9c"), (short)1, 20, "Course0", new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("ba409408-d57d-46fc-9e62-0a708e625e54"), (short)3, 20, "Course0", new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("9947b5c4-1aa2-40d7-b84c-8a60b2e4cadc"), (short)1, 20, "Course29", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("712d2a0f-121c-4b3e-b191-016c6d19f1b8"), (short)4, 20, "Course0", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("f1ac8843-cb24-4586-a641-cbfe217e57ae"), (short)3, 20, "Course0", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("693a9016-3378-42fe-911a-d929bd6c5e3b"), (short)1, 20, "Course23", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("e0000746-b023-4093-8be4-ac6c97283333"), (short)1, 20, "Course0", new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("534b6e27-398a-4513-b7ec-58ce41ac4975"), (short)2, 20, "Course22", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("28b5c538-87ed-4f87-ab84-a05eb71257fc"), (short)4, 20, "Course0", new Guid("5ce360b4-a52b-469c-864e-581079032040"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("a2a50e4b-77c4-45d5-9553-cfa622ddc737"), (short)3, 20, "Course21", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("19b0da6e-8af7-421a-acaa-4747bcad3a74"), (short)1, 20, "Course0", new Guid("541c710c-c999-4f63-900c-750d9e6ad206"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("fd8172d7-1526-4218-84ec-1967a5eb1b07"), (short)2, 20, "Course20", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b") },
                    { new Guid("31cca974-f130-432d-b3f5-cd6529fe9a23"), (short)5, 20, "Course0", new Guid("f0aa8371-a126-4659-9004-075b03a98a32"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("613e6ca8-a0ee-4ce1-88bd-d7168caa4587"), (short)5, 20, "Course19", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("1290cc54-3357-4d81-87f2-e1ca6fbc7712"), (short)4, 20, "Course0", new Guid("b2c1b643-2a06-4410-8531-572bdf522174"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("a8a69473-01e4-4108-967d-21f5ab9f4dd4"), (short)4, 20, "Course18", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("796f149b-bf6c-46db-8913-fe21cf8ef727"), (short)4, 20, "Course0", new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"), new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d") },
                    { new Guid("a089d5d9-fad6-41bf-8928-6196fe09ff27"), (short)5, 20, "Course5", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("36052e77-028d-4092-8653-fa83176f0f10"), (short)0, 20, "Course0", new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("c6ce7e71-cfa0-4468-9f75-2b8c66ddba80"), (short)1, 20, "Course4", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("bd2b1033-ff78-4cad-ab9c-8ee398332b4c"), (short)0, 20, "Course0", new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("37b7445a-ee78-44c5-a0cb-16732df14b94"), (short)2, 20, "Course3", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("920212bc-fbd3-4a57-8b27-b7f7a3a0cebe"), (short)0, 20, "Course0", new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"), new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353") },
                    { new Guid("99cc5b3d-227e-4e45-a461-8f5d31e224d5"), (short)2, 20, "Course2", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("5b563d45-66ad-4643-aab7-5f08e3d8f254"), (short)3, 20, "Course0", new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("44fbb7da-7d5b-4f85-b345-2242d354bf71"), (short)4, 20, "Course1", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f") },
                    { new Guid("c0aeeae7-69ab-4bcd-bc91-f2aadfe9a4fb"), (short)0, 20, "Course0", new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("e6adadf2-a0fc-4703-8cca-6d9dcc684eb2"), (short)5, 20, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("fc0e4c35-dd67-4f6d-bbb7-ee935bccfc19"), (short)1, 20, "Course0", new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("dd7889c3-3c37-47fd-876c-b03cc585a8c8"), (short)2, 20, "Course24", new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("e293fe24-4ac5-4c43-99a2-b7fd54b5e110"), (short)2, 20, "Course33", new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("6e7a49aa-5012-4c09-8f46-318b708ebef6"), (short)4, 20, "Course0", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("d017fb0b-e864-4fed-9af4-b38a02e6de4e"), (short)0, 20, "Course0", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("68287c37-437a-438c-8e1a-f1c2f03b8f87"), (short)1, 20, "Course32", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("21fa712b-8b5d-454d-ae0d-2e9bb7142630"), (short)0, 20, "Course0", new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("17a231af-cd97-4c2c-8ea5-c6d723a5f160"), (short)2, 20, "Course31", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("2568f11b-fd28-4565-83e8-dac477d0878c"), (short)5, 20, "Course0", new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("7c2f9b96-a370-45a2-97e8-532ba40901e9"), (short)0, 20, "Course30", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("071f8601-80b8-42c5-8d93-6440c4633c35") },
                    { new Guid("2bbf530e-db1a-42ba-8e51-650428f7c658"), (short)4, 20, "Course0", new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("626eb648-e3a2-4a01-a3e3-c837cd8dea92"), (short)5, 20, "Course11", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") },
                    { new Guid("118265fc-b99b-4104-a9e7-690386759bdc"), (short)1, 20, "Course0", new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("a610ce5c-f232-4e1a-9b6c-0cbf4fdc853b"), (short)3, 20, "Course10", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("39874ce4-b45e-4d96-9dc1-2dde6d4b2b0d"), (short)2, 20, "Course0", new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("ce792043-de57-473c-a112-c223c987575e"), (short)2, 20, "Course9", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9") },
                    { new Guid("938126c0-717f-46cd-b12c-780370d210c8"), (short)2, 20, "Course0", new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("5b214518-e697-4761-8b0f-baab99f9f58e"), (short)1, 20, "Course8", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8") },
                    { new Guid("05e38cd6-e5c8-4462-ba64-bc75c4a0969e"), (short)2, 20, "Course0", new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"), new Guid("08753260-7db2-4911-97b2-cf49552414ff") },
                    { new Guid("9fb2149d-73c4-4c75-9e67-f498b178cb6a"), (short)2, 20, "Course7", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("92e8b4d3-52d5-4ea7-9fcc-36e1aa3c83bb"), (short)5, 20, "Course0", new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("aeed10d6-a36a-465e-898a-d966e9901b25"), (short)1, 20, "Course6", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936") },
                    { new Guid("2a76e322-840d-439c-8bf6-c5cd06ed8e71"), (short)5, 20, "Course0", new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"), new Guid("2daf477e-5667-485b-8efb-3858c7cababb") },
                    { new Guid("17b9fb4b-fc6b-4c2c-9c80-0105fba21425"), (short)3, 20, "Course0", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("b4aeffea-5c45-4cd2-8365-826b76014ac7"), (short)1, 20, "Course0", new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"), new Guid("6785ef90-5968-4673-918f-87969772d761") },
                    { new Guid("dec493c0-10a8-4d9f-8bd9-f517d5f3295e"), (short)3, 20, "Course28", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("467747c2-5e64-433e-afc5-e8f521652bbf") },
                    { new Guid("e48f5fcf-4c3c-41d8-a2d2-87804281f49e"), (short)2, 20, "Course0", new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"), new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99") },
                    { new Guid("9964ed38-26bd-472e-92cb-3a186433932d"), (short)5, 20, "Course27", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3") },
                    { new Guid("b6c75b8e-8dc7-4866-a926-58977164c9c6"), (short)5, 20, "Course0", new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"), new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a") },
                    { new Guid("0c2c72f6-b7bc-411d-ab3a-dc505464c74e"), (short)0, 20, "Course26", new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"), new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c") },
                    { new Guid("921680e8-2d7a-465c-8c01-864b7b4d2389"), (short)3, 20, "Course25", new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"), new Guid("15e101e5-6231-465a-b661-6b9e8830332c") },
                    { new Guid("aee93fb5-53de-4c5d-8c50-46f1d6cee655"), (short)0, 20, "Course17", new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"), new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StudyYearId",
                table: "Groups",
                column: "StudyYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_StudyYears_StudyYearId",
                table: "Groups",
                column: "StudyYearId",
                principalTable: "StudyYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_StudyYears_StudyYearId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_StudyYearId",
                table: "Groups");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("585fecc7-0249-42a1-b7cb-33a6783501db"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("5eaa5f96-418a-4ce7-afce-57ea44256311"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("700fb14c-1fda-4aa5-8d27-b0742d2ed3b8"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("74dcef9a-13e3-4fbc-ab36-ad379732c46f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("87b10a13-db0c-4026-b754-1a22e13c01cf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("8b9c3e4c-f1d2-42ec-9e5d-61a32fcdf25c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("9976ecd7-ec23-44bf-9517-f4d0b862bd8e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("be949e9a-24fe-4d7c-95a0-ec7a0150f500"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("c33cdba2-ee2c-479d-b007-73e9e2ec2004"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("c6bd4f82-482d-4c08-8d64-3ab849f89edf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("057ed007-9d5c-4d8b-b13a-c740482d6d90"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("071177d7-0c37-4eec-82bc-68eec427b1a3"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("08a5392c-7208-4cd6-beb5-05f47b13aebf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("08ec12a1-ebaa-4051-bec4-0e4e6c3ec355"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0fdf8da3-57f9-4e5e-b0ba-0b5f57489937"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("13cbb5dd-1880-4aa3-b875-060e7511e5e7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("153d9b08-e8d6-43e9-bf9d-335652e47b03"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1997a2b9-4c57-4e6f-a019-51615b59f619"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1b945c34-75b3-443b-a548-bb1146124464"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1c2963a8-6ff8-4eb2-8fe6-3158e8451e33"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1fc4bec6-c9bc-46f4-b99a-d59d796979ec"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("20da02ec-2fe1-48f4-91e7-09d47718c53c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("32def790-e8e0-4fb2-8ba2-3b79829ce408"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("34127cdc-9c08-4d4a-9af0-3422bb9b3d2c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3b4076e9-06d5-4907-8d23-431bcb6f8120"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3cc25cc3-f9cd-4830-b200-20a573b3cd20"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3f2fb528-b9dd-4613-987a-5fd16ec4bac0"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("410bbcb8-473c-4efb-98eb-b6f25b2f59c1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("42d1792b-a833-43ce-8c1b-04cd9e9b5f4a"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("42dac590-df57-45b6-818b-652408de3243"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("455ec276-c978-4a9f-ba44-92d1c8c35c34"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("45cc6989-5db9-4ab7-bd06-2ac14ac3cf2d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("493831c9-eafa-46f4-988f-a34625ee0aff"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("49d409f3-9bc7-45aa-b498-11058b36d74a"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("49fad271-d029-498e-bd3e-ea8f4ad208ad"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4a5ea580-b8a2-4d90-955b-36cd0753c6b1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("50f7ae2e-70f8-4b30-8162-8cda07106544"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("58e3ec4f-428e-4f7e-904f-67a94533875d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5a7ed22a-738d-48f8-bda5-7e5fd7128e2f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5d128c2b-ecfe-49a0-aa58-4364c2a48b47"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5d3186a6-c001-49c5-b85a-915ce362a022"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("63d8e751-27aa-4eb8-8110-1ba58876a302"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6552e531-7645-4ebf-aa0b-e91919d6fd95"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6b7b3c36-3fa7-43e6-96a8-4d31f2ad7a96"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6b911cfb-326a-4393-b134-cacc021a1892"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6eb8176d-3569-41d2-8822-c9623c70c08f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("70feadbf-3837-479f-a6fc-c839052c7ebb"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("72af3d3e-e025-4030-b0e9-66c0b12966db"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7c0021e0-cae9-4595-9c62-8d93165b6a8e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7d7191d2-9395-431f-99f2-050f1ff43aac"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7ea46b3b-7a1d-4fb5-ae7d-fccd5445f021"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("84c05a90-29ab-40ef-92b6-ada5bcb4f043"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("877d04ba-05a0-4ff8-9676-f1ad27d2cc8b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("92da88d4-06d4-47b3-b192-fd9815a0d914"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9fd6e87a-3dc5-43b2-b7f9-ac34221d5b03"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a550e131-3354-4d15-bb0f-e1db5eff1dec"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a8493ec3-486b-46d1-8364-00149b5a4a25"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b343d71e-3ea3-4d43-a2b9-11f9c0b8983d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b6d19c2c-bf68-4da2-adc4-a6579ec7a873"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b950f2d6-1840-4f68-8983-1fd267e848cb"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ba0b82c5-25f8-4ca9-9bbd-9de9f94ddf10"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("bdb4b6f4-d978-4671-8af4-1bb183ec2436"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c0d97e34-c60f-46db-9d66-9a25fbb4ce51"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c5aa5f58-d3b6-4e7b-90e6-e4d69f762ecf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c698b886-87d6-42d3-ad3a-6e066cbcd250"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c85f17f3-c606-4de7-ae59-5d50f5752e0f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("cbee3a72-69e1-4933-bb6b-a55c38ca4a0e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("cda18b9a-2870-43fe-8bf1-e591d08b88b5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d2aae668-75ee-4b94-9828-8b960cccf0ef"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d82d6b1c-3fb5-40d3-b1af-899d85a60d21"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e185d4e0-43b6-44d1-a348-8902dc34230f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e37fefde-dea3-4bf0-8dac-c34379778afc"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e551073a-89e0-4d67-8085-4da0afec167b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e67a8670-d3a2-4fdd-acfd-085a5af0ad25"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ea5e953a-d232-4771-9e5c-2c62caa389be"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f24a5d16-291d-4a20-bfbd-d2c1a8a98d40"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f5d8e93c-1b35-4949-a0e2-cbe78a11e8c6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f7077bb1-307b-451f-b59f-04b1e4ac9df9"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f9a8c198-dfd3-464f-bda6-7d87de92a5bd"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("fbd48093-5de9-4dee-b28b-b3901503511f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("fbd5dcd9-ea40-4aa2-97a7-02841dd7a46f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ff6edd23-ccb2-4d40-bf76-d430d60dc0c2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("032d315b-8fb2-477f-8f70-a376b8655785"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("04a6056b-34c7-4b6c-82c7-fe47bb025037"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("050455b2-b1bd-429a-b9de-c1345c999ef2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("05203082-9fd5-4963-a9f1-d6ca700c026d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("09a3d5f2-978c-44e8-ad9e-feea73b88ace"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0a06b723-cb36-4b76-bdfc-6c6d717211ad"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0a6cb981-6a01-446e-8677-65f0bbeebb20"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0ac7df8c-ff1e-4126-a7df-8dab9d4a0766"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0c6ec012-3be9-4722-a670-9d2d00c5b287"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0da3c5d3-eace-4894-8fdd-c9073c906417"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0db21aa8-beb5-4f63-bf0d-f4e7b3c29ee9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0e4f375e-e72b-431d-9532-c3562ad9b883"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0faee491-5220-46be-b77c-b74210ae7d3b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("115699c4-686c-40e0-ae46-7ff9ef888a56"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("130653e5-95aa-46f7-8d8d-f5636594c904"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1473702f-8ca0-41c5-af85-f68c51d9e187"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("14979426-0ac2-49fe-91c2-a40ed5906a3f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("14b27a0a-3fe6-4512-8843-ea9b9e6e1a63"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("174439d1-3a4c-4475-8038-ab1ebb9fef14"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("18513cfb-64f8-4b72-a45e-0c39bb988cd4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("210a5494-436b-44aa-958e-0c2f2cce37be"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("21c7ea0b-2a10-4030-811e-44ef64b9a249"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("227517ea-5d47-4d30-94c4-1b3af3a2fe51"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2392d13a-ac5a-41e1-bdd7-0d3337c312f8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("256c22d4-f992-4989-a5ee-6be548104afc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("25a149f9-0416-4f46-9756-812e80bf5b24"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("25cde140-e6b3-4580-bb40-7a1c757cb5a3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("267c5f8a-2e1f-4d0a-b327-a5b3ad874ba3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("26b4bf13-5838-4891-8040-445939883012"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("28021a3d-0c23-4e82-aef7-03601a2f2142"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("28e6b7b4-f6d8-4644-8fad-9bd931b98d16"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2936e7d4-e81e-43b0-abe6-a1d582af0022"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2b58e310-d41a-423c-8eec-252ceccf452d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2d1f03c0-4b69-4b0e-af79-f25eb0222d70"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2da40d30-b625-438b-baa8-3f0f91a91326"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2e12affc-a28c-4d10-ba57-cd2e66ea7671"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2e63b547-ee72-4a6c-b6da-752485bfd0e8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2ebe39e6-b72a-4977-a44f-f27a6870982a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("31522d38-e786-439e-9d70-9d65f1bc9d95"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("32509806-4fb3-4f42-a787-68c00042177a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3343cb96-87da-4ccd-a098-aac7de9fe818"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("35187d6b-20be-46a4-a5bf-4fe513773c17"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("371c1501-8580-4fd0-8a30-eb182bc70451"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("376db3ef-08e7-480c-bafb-7e5085de538d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3867216e-18d0-459f-b372-953fc4bc6c30"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3872c942-d892-4c0a-86eb-7a5d44be918c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("38c91055-e677-45d9-b5f9-64c6646420ef"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3a1928f6-16a6-48be-9580-67e9d372ef8a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3cf8ce3c-00ff-49e2-b866-f90cca36896f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3cfabe05-7d45-43eb-bbaa-47f99453ff36"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3d0766d7-2734-4708-845c-543c62f4bf54"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3d7bcaae-efbe-4603-9d0d-9883b40396e1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3e1dfe68-7ae7-4835-a55d-359ef88c9d81"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("40d35dd0-fdaf-4429-b288-d81726554d08"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("42eba954-a921-4c25-912f-49aae554205c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4352e691-70bd-41ed-9826-b8ec291e3ed2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4365fc8a-a908-43da-9893-7b9b0c1a7f7d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("44261740-82bf-445c-9c1f-8f8081062911"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("44ae3f4e-6f6d-40f2-a6e2-02127260578f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("45863316-e7f7-46d3-996b-510b20e82c23"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("45ef827c-6be2-456e-8188-180d4e091fc7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("47db7a00-723a-4c47-bebb-de227291e0ab"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("48fe1fc7-d9c5-491f-90d5-e6739f7e96cc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("49314f46-670b-469d-ad6c-8b3d0ae05510"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4c421f21-b43c-47b0-ba55-339103ff1eca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4c535ed4-250c-49f2-986f-fbd562d33982"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4d257ae9-3301-44e8-80f6-bda172bfcce3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4f36fc4c-e323-4c85-a3f2-2af7d5c9aad9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4ff1b4d5-6c3b-4c19-ad18-76fd6f083f42"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("509cd428-e955-4a30-a7f4-38ebec1a7d21"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("523f98d1-5ab8-45ad-93bd-3891afe1b495"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5265b2c5-4b7d-4fb5-aa42-a954407a2250"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5545e463-77a0-4584-83d9-1d1c0b6024a9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("557726a1-492b-4886-89d6-34396e431ae9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("56ac2e5c-ae54-4706-b5ed-b56e577dab4e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("57ef3c03-a50b-46f5-a243-6813e5e5bb74"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("58cce350-a004-466d-b5de-2954e4b317e8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("58f07413-d67e-4ec0-831b-2b7bcac5cf7c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("593f007e-e61d-457b-a5d5-07914de0bc8c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5a6497ea-34b8-4b60-9674-bed88dcbe6d7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5c5b6ad7-1a3a-4e91-b3ed-5d2eb9806afa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5c6ce77c-bc34-4dcf-898e-cf190455e843"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5cbfb4e3-7065-4402-bb3c-5d2ac7448402"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5d613275-cf54-4e48-964a-e95dfa05621b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5f3614be-37ca-4287-a81c-3874993007eb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5f3718a0-2fa5-486c-9335-c276c06318f8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6005e774-270b-43db-b404-eddddc81ac63"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("60dd9128-33b7-4f07-937e-107b5126c438"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("613c296a-1278-46d6-b46c-8f4f087bdcf8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6163bbf8-c56f-43b4-b658-4cc3a5986bdf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("62fbfb80-e33c-4714-ab5d-0ddfbf3ee43d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6301dc06-9567-4a3c-88bf-56892b58362b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("63176cad-bd54-46b8-a630-f52eb85b1a91"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("637c147f-4773-4dae-8763-d978b516f6c8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("64020ad4-31cc-44c0-97ec-f082090dea97"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("64405800-89e6-4f77-90f7-c13578d6d239"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("64c56ab0-41b4-43ea-b407-a7aae3ece8ce"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6769c33d-864d-4572-b799-161f987e6a93"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("69e6aa9a-3e1b-4fd0-815b-37f152427d62"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6b62f55c-0e28-4b4c-bae3-171f8acb6a5f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6d1a9e21-f9cc-45f4-8898-a2102b6bea6d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6d70231c-8da5-4b78-aa61-3ecb34a739f2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6df55ed3-1908-41bc-8393-4a364ae2b427"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6e66e473-88ae-48ac-9387-3104ef34b0d0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6eacb058-9ff9-4c1d-9b4e-7d1f3d23fa43"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("72476355-7399-4ffc-a499-6e97b263d9c6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7333ac7c-d8ba-4926-aa2d-db0d7387f51b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("74e7446a-4e0b-4cec-8742-d4b4e8aec180"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7739cf11-f916-43fc-a50e-46689ec82628"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("776cddf0-e5f6-40c7-bdd5-17097a31f30d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("787b5ced-8b8e-448c-8e5a-d21f739ffa37"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7a10e3d8-8aca-4793-88ca-62b772f94af6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7ae0ea13-3a70-474b-8111-4e1090e918de"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7b0d138b-8116-4e39-9fcf-59ebfcb3b0cd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7b42cf3e-7b49-4603-885c-18cf3eee895f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8282a8f4-f6bf-4deb-b3a2-571bb2a404be"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("82f9ed19-ceb1-4af6-a4f9-6176d4f8346e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8510ab3b-c727-406a-8a45-81e2e74bb2bd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("85aa930c-7e62-4012-a0af-6d3e350bef9b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("86e28ccc-5ca9-41ed-abee-63e9d8cf246f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("87d5fb27-bb48-4dc5-93dc-85a879b04565"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8999bfe3-90ec-4982-a98f-7695c871a4aa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8baeaced-ca8f-414e-b2c6-c3c08aa30aa0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8e0b0593-32f9-4beb-9b97-7d2384e256eb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8f8700e0-75cd-451b-b08c-54796803351a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("91f8b8a5-756e-41f3-a338-87add69b3a9f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9215dc4a-f1ca-46d3-8976-f23fdcf84239"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("92e27d69-e0d4-4f84-b6c6-7e91a5c9ebe9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("937592a7-6fe7-45fb-8944-e25bc47edc05"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("947cae5c-9659-4bb7-8c0d-082f513b5f81"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("96091698-03b2-4f8b-9787-4509ddabf6dd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("98ec5dcc-ce79-47cc-9fd6-93f1fc87da00"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9a514701-4841-4ddb-8919-7a75c284f979"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9ab00069-18e5-4f71-ba53-efefa37d3a38"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9c0332a6-2336-4918-8799-126e8476f68e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9e504600-d7bc-419c-bfdc-9d8523708aaf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9f670bd8-431b-49df-90ef-313359b8a44a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9ff285d5-907b-482f-b7ff-949509d0386b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a0172c76-fa04-4444-98a0-8f5b33890353"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a0204106-278e-40c3-a396-d52c42fa9318"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a0cd820c-9f6a-4e4c-b6f5-6405d4d8e541"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a0ed1c53-c258-4a06-9d3c-b0e15c379576"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a8b1cf73-080a-4c6c-b18c-2cbbeabce6ee"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a9b96aae-f867-4518-be80-e0454870c02c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aa7003f0-2804-4234-a6da-fdc8c2de0968"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ac5a0d55-d5cb-4b6b-a6d7-00a19841123a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("acaaa03d-44e3-4b4e-b85d-75947c11b625"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("adc44710-0250-4dd3-87d1-daa2116cf255"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ae3454f7-d9ba-4eb0-9e44-f821ac2c7316"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aef90c4e-0a7d-4f41-a0c4-e456e96ae77a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("afbad7ee-4f8f-4417-9840-de331744d5a5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aff12f58-3357-4ae4-8346-e92ba68aeeff"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b2ce8681-6b6d-41fb-8ecb-324e1cd9fb06"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b2d1c2b8-9e9f-4635-8fd0-846f02fb9d8d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b44b1f52-e46d-4f55-a782-05a5c5cbd7cf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bbd6f5ec-7517-4957-bea9-e91708d2fedc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bbe6d1e6-e3fb-4f19-8caf-1f8814c87add"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bd6b42fb-fd23-4888-80ff-ce8e1f5beb70"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bdb04d09-ba94-42ae-bd5a-984f14d37685"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bf03a577-1c94-455a-9cad-b85df1a86410"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bf95e9c5-6d0b-466d-a80f-3b4019fa7f7e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c062e50d-f71c-41e0-9d00-797ea584e432"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c15113d0-860a-40b6-860d-28208f07a0f1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c2be17b7-4797-4eb2-a631-9c5bc01cd470"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c446b936-dda0-435f-a14d-3b0894df7f20"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c47dfc13-0149-4a2f-8d8a-7f3da4fd0753"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c4bef1c7-dac8-44a3-9322-07eccf6f9f62"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c5fb0791-a031-458a-875c-da8111945286"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ca49084b-31dd-4bd9-8267-d438dd22d7f7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cb53740e-6303-4329-93dc-e4fe2e934152"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cbbd2137-1c04-4326-9c83-237de8802694"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cd26a405-e633-4a4b-9643-50c693e45072"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cdc726cb-f2ab-4366-84b1-8372e6c530f1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d07aac90-bc09-437a-923c-95ace287c0e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d1179fa8-a82c-443e-91ae-3181aa3362c5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d131ab61-c941-44c7-8801-7f8caf05917d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d43ea49d-731a-494f-8d56-f33cb3e13904"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d476deb6-ab70-4e75-826b-f3e06b08b482"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d580d97a-1ed5-4d06-b0a1-c155de54eef6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d590fcc6-c6c7-4700-be89-c7b8aa1e999e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d625e6c8-ed11-4830-9c17-5e2a78916d80"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d6af09ee-95af-41f5-97fa-82cbb606b9b2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d80eb285-cf02-4bcf-9079-d424705c9c85"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d8f364fa-513c-4708-9d55-1075529872cd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d9342a97-e4aa-4adf-9d20-2611c3a60145"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dd1e5883-f075-4e12-95a1-5672b733eae4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e0b5ca73-b8fb-4dcd-bdca-4971b3056fbd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e13fc883-e93b-4d4e-82a2-bc85361a85b0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e294e887-d24b-456e-8fe7-4e91756b8c9c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e483ef78-07c4-437b-82e6-96981b22ad8b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e5e1f6dd-2e81-4cca-a65e-632b5a5d66ff"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e7cd7e8a-c0b8-42a6-ac76-318c01da6e9e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e7de445b-9a97-4ae9-a4da-0cd59fe6b6c2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e7f1a7f1-9e41-47b2-b67a-74bf1189d7c0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e84bf635-e05c-48b8-bfc9-74fcca09a5a6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e8eb8888-96c9-40f7-93f0-e98cdeb60090"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e99bed10-9918-40b3-bd0a-f6b6be678ea5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ea6235b6-fa6b-4fb3-94e4-37598aaac66e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ee5b895d-3fb2-4cf4-8850-a22ed291a98b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ee9912ca-bf07-44be-b8c3-c13deac5fb25"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f189614c-eeab-4fcf-8b43-e44671b5ebea"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f1ade7bb-ce65-4a64-bc33-065ee2aab4f4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f1baa342-6f8c-45cc-a847-bf0baca5a8d7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f22b1a5a-e442-42ea-a95b-92811b9e425f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f24d3db2-3393-4576-b22d-528d574cfec9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f309c0d4-4200-4c38-bc51-734ba163729b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f7d5411c-edf2-41b9-a49d-819c38c9137e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f7f5d255-8037-4e69-a269-9b21a035d571"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f826f0ff-d005-4f53-9790-882c810a0357"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f895f12f-e31e-4d56-b27e-fa54085512c8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f99343c0-9148-4d35-a9f8-a569ac963297"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f9a9411a-b16a-4fdd-bec8-a3fba5313173"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f9f2b46c-4339-4537-adba-1d29a6f297f5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fcd2b3fa-3efd-4ec2-bca8-8f07aa1cea51"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fd779d9b-b543-43d4-bae9-9de11e308dc5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ffa7bb50-9c15-43db-a53a-16e87538a26e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("05e38cd6-e5c8-4462-ba64-bc75c4a0969e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("081d9ff7-b487-4626-ac7c-f5ab4e246eba"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("084de768-8e07-49b9-8b87-5805f5928a9c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("0c2c72f6-b7bc-411d-ab3a-dc505464c74e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("0fc0abb6-5756-4571-903a-4772c3aa26e0"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("106e30f0-71f2-42f0-bb44-ef429cdd5092"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("118265fc-b99b-4104-a9e7-690386759bdc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("1290cc54-3357-4d81-87f2-e1ca6fbc7712"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("17a231af-cd97-4c2c-8ea5-c6d723a5f160"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("17b9fb4b-fc6b-4c2c-9c80-0105fba21425"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("19b0da6e-8af7-421a-acaa-4747bcad3a74"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("21fa712b-8b5d-454d-ae0d-2e9bb7142630"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2568f11b-fd28-4565-83e8-dac477d0878c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("28b5c538-87ed-4f87-ab84-a05eb71257fc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2a76e322-840d-439c-8bf6-c5cd06ed8e71"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2a814e07-9e7e-4fa7-b87e-a39044ceb334"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2bbf530e-db1a-42ba-8e51-650428f7c658"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("31cca974-f130-432d-b3f5-cd6529fe9a23"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("36052e77-028d-4092-8653-fa83176f0f10"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("37b7445a-ee78-44c5-a0cb-16732df14b94"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("39874ce4-b45e-4d96-9dc1-2dde6d4b2b0d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("44fbb7da-7d5b-4f85-b345-2242d354bf71"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("534b6e27-398a-4513-b7ec-58ce41ac4975"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5700ca1d-c03c-416e-a24f-6c18c16a4207"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5b214518-e697-4761-8b0f-baab99f9f58e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5b563d45-66ad-4643-aab7-5f08e3d8f254"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("613e6ca8-a0ee-4ce1-88bd-d7168caa4587"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("626eb648-e3a2-4a01-a3e3-c837cd8dea92"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("68287c37-437a-438c-8e1a-f1c2f03b8f87"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("693a9016-3378-42fe-911a-d929bd6c5e3b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("6e7a49aa-5012-4c09-8f46-318b708ebef6"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("712d2a0f-121c-4b3e-b191-016c6d19f1b8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("772727f6-0df9-4d59-be84-5b6c809c17fa"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("796f149b-bf6c-46db-8913-fe21cf8ef727"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("7c2f9b96-a370-45a2-97e8-532ba40901e9"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("7f99321e-42e7-41ce-8e5a-a9fc685108ba"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("8cdd9286-ef35-4632-9ce4-0fee9d4c364b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("920212bc-fbd3-4a57-8b27-b7f7a3a0cebe"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("921680e8-2d7a-465c-8c01-864b7b4d2389"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("92e8b4d3-52d5-4ea7-9fcc-36e1aa3c83bb"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("938126c0-717f-46cd-b12c-780370d210c8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("9947b5c4-1aa2-40d7-b84c-8a60b2e4cadc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("9964ed38-26bd-472e-92cb-3a186433932d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("99cc5b3d-227e-4e45-a461-8f5d31e224d5"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("9d86a001-ad88-423e-904c-2c3e386431a4"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("9fb2149d-73c4-4c75-9e67-f498b178cb6a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a089d5d9-fad6-41bf-8928-6196fe09ff27"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a2a50e4b-77c4-45d5-9553-cfa622ddc737"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a610ce5c-f232-4e1a-9b6c-0cbf4fdc853b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a8a69473-01e4-4108-967d-21f5ab9f4dd4"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("aee93fb5-53de-4c5d-8c50-46f1d6cee655"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("aeed10d6-a36a-465e-898a-d966e9901b25"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b4aeffea-5c45-4cd2-8365-826b76014ac7"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b6c75b8e-8dc7-4866-a926-58977164c9c6"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ba409408-d57d-46fc-9e62-0a708e625e54"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("bd2b1033-ff78-4cad-ab9c-8ee398332b4c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c0aeeae7-69ab-4bcd-bc91-f2aadfe9a4fb"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c4983706-6cf5-46ab-ac16-c67ab850bf76"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c6ce7e71-cfa0-4468-9f75-2b8c66ddba80"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("cbbe77eb-a4b7-4353-973e-83243f6ecfb0"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ce792043-de57-473c-a112-c223c987575e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d017fb0b-e864-4fed-9af4-b38a02e6de4e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("dd7889c3-3c37-47fd-876c-b03cc585a8c8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("dec493c0-10a8-4d9f-8bd9-f517d5f3295e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e0000746-b023-4093-8be4-ac6c97283333"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e129d72b-0566-4b37-9d3f-d50e2ef5033d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e293fe24-4ac5-4c43-99a2-b7fd54b5e110"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e48f5fcf-4c3c-41d8-a2d2-87804281f49e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e6adadf2-a0fc-4703-8cca-6d9dcc684eb2"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f1ac8843-cb24-4586-a641-cbfe217e57ae"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("fc0e4c35-dd67-4f6d-bbb7-ee935bccfc19"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("fd8172d7-1526-4218-84ec-1967a5eb1b07"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("585fecc7-0249-42a1-b7cb-33a6783501db"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5eaa5f96-418a-4ce7-afce-57ea44256311"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("700fb14c-1fda-4aa5-8d27-b0742d2ed3b8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("74dcef9a-13e3-4fbc-ab36-ad379732c46f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("87b10a13-db0c-4026-b754-1a22e13c01cf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8b9c3e4c-f1d2-42ec-9e5d-61a32fcdf25c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9976ecd7-ec23-44bf-9517-f4d0b862bd8e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("be949e9a-24fe-4d7c-95a0-ec7a0150f500"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c33cdba2-ee2c-479d-b007-73e9e2ec2004"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c6bd4f82-482d-4c08-8d64-3ab849f89edf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0b2c4f43-a881-4b96-b697-2baec5d6ae9e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0d804411-bbbc-4de0-af5d-21ffdd14972a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0d95f6da-d6ff-43c7-b438-b2e7a29e6035"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0dad3774-03bf-4c41-8cbc-640fdae1ec2f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0eb78f8e-6486-498e-abaf-e7a8ff52a03c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("12e1e64f-b7ba-407c-8e0c-de37d9c6a986"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("18a341f9-d05d-4dad-a4ec-725e6fc25adb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1939b7f4-ebea-43b0-b458-c9ea10b7441d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1d687ef2-33f0-4d7a-89cc-01aec8e2d2ea"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1e64fce0-c64e-4952-9ca4-ded612da49d6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1f11cb47-a2e7-451c-a889-a80257623e34"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("260ffeb4-a7d2-407d-adea-421016739dba"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("353dfdfe-d039-4855-8d1b-9fef20b86a07"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3620dd07-5455-460c-a309-1adbf056f069"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3796f44f-4e6d-4a0d-931a-67de6eca130b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3b4511bc-9d42-4045-959a-c600cd7ddb6a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3d329348-1e54-45bb-b1dc-f8359d8eca3a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3e827b50-38bb-4049-b554-ad4db7c6f079"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("424a4d8b-8887-48a8-bf0d-107c4d589182"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("43415428-9485-44f6-9ed7-6f696e0c17ed"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("45060f12-ece6-4b97-b565-daa07f1ee078"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("46401e74-4daa-4cbf-977b-de06701233b5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4a895a13-7960-4ff6-92b3-61afaad832a8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("51868205-f576-4dc7-a5bc-a01e8b9128a2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("52a1bf69-48b8-4333-930e-8b8603fd5dba"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5556d781-9a8c-4bc8-8b2d-7569b09b497b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5601e26f-0be7-420e-82aa-5c82d5f10a9b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5c1d34d9-2bfa-4cf5-aea7-e15eeddaae0b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("62e33f6d-1316-421c-9b5d-97f86a9654d0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("64213c26-f20c-496a-91f9-a1872cc9249a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("67a22ec5-8bf1-46c6-b087-bb33ba0db7c8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6d945629-fc20-4a2d-840e-9efc331dfae0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7434bf02-5d81-4cce-a463-8b8620d20efb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7c221e27-d7c4-4cd9-9696-ed276a0db0f8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7f399728-b435-443b-8fb7-7bf58eb8fd09"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("87f909d9-267a-4710-bb98-687652181b48"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8fab1726-e000-4f6c-9e7a-49d3f0b75a43"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("94c2c181-3280-443a-9cf6-f8fb44a711d0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("999028dd-0e3f-40e6-8b7b-7eebe90fe176"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9d061641-b81f-41f2-aeaa-48a436317e31"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("aadab007-b362-46ed-a688-860990c1ce67"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ac3c82f7-db08-4e04-98e9-943dc2294c9d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bb8cf7e3-f07e-4d72-baaa-3fc8a0193fce"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bcdefb44-008a-449e-bc13-762db3f6614c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bd7b713d-c747-40f1-a165-3d8e1ec41b5d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c01a8e4f-ddaf-49ba-b3fc-7e8dc962addf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("cdf85e3d-470c-467c-a72b-c1c4ab9effc9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d0e6bd46-38cf-4efd-adb2-6cdd458afd2a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d24e31dc-caab-40e0-8195-6f702aa19e56"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d315edc1-b4a1-4a4a-a2ee-ef2c5ed5c1a2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("de4c4358-6826-4479-83b2-4d2e56574803"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeb27e3b-7129-4274-ad3d-38ccaff788d7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fb9f1d4e-b0fc-4f5d-bd9d-ca86e5e5443e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fc76e366-89cd-4503-87eb-c8aff678efb3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("045fd78f-d876-4b31-8e8e-93c7f28fba90"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0cbd6601-75d8-4c01-aab1-45d423fa9319"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("14acfd39-649e-44bb-b4c9-81bb485c1565"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2273247a-5ea9-4956-bbe3-e4e1fbedc68a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("27c21c60-30bb-4cb7-a3e3-4857aab19659"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("27f1e861-b79c-4143-9b88-69313b52ccc0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2e6514ee-f003-4a1c-b604-ee104cb18e9c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("338fe279-f58e-4c5e-9081-9648454a2753"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3d66a605-b2f6-414e-b4fa-7a679521bbdf"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("42c6514f-3632-4599-af6a-982cf4845ef4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("44ff300d-60b2-405f-aeae-46d9f3a15240"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("4c2b1381-e9ec-41e5-858f-0b4e03a0b1dd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("4c941439-f62a-48fc-8aa6-d047333edb44"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("566cf487-3ed6-40c5-ae72-d3741beff430"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("584cde08-c075-407e-a09f-d5a533fbc45f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("62cef015-f0eb-4a6d-a0ce-43263a9de3e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("671a6804-d308-419d-b56e-84b4c8858681"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("697a9e49-5424-4293-803b-71cde4bd3c23"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("7c117e49-26a5-44a1-ad74-028fc5ccc9cd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("8ea1e7b2-5649-4204-aed8-c92eba7ef250"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("8f30ff42-f259-4b6a-90b2-3745f361afff"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("936e7f20-6944-43f3-8e3d-99bccbeb26c8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9803212f-9417-4247-b409-1faaf7e69066"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("99d71edc-63a4-4a24-b278-b49d0bb19f49"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9b342db1-edd9-4031-8d39-95f30c0141a7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9d71a4b5-d03c-4341-bf59-2920f6ae260e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9e7ed602-ce49-4120-8013-d672ff620db5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a2263c6b-31e9-4242-8663-697fcc365987"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b3050769-754a-4389-8690-8ec99304fb18"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b73b2bfd-896d-42d9-8768-2bda7f1fc5aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b7410b97-9dd3-403f-bad8-9ddae8158612"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b886c14b-274f-4bd7-be28-3e8f37ea9503"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b96d78b3-d8cb-4634-8534-636517564e76"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c62ff166-4f6a-4126-916a-ea30a7804072"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c868fdb3-b9c3-4a4e-9727-bf3cf5f2b20f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("cc555932-1240-4511-8879-82d6a043a116"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ce097aa9-4fb3-4a6e-ad49-ac8a555743d6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d50391ff-a32e-4abf-b45f-5e4cf058b204"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e67b668b-c463-423b-8022-1832825cb1be"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e86bcb2a-cd9b-4175-a190-d4872e96e236"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ea4c9cd4-14d3-456e-aa97-e835f7f8dbff"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f19daf6f-9705-4a6f-a953-9d9d69604436"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f43b2256-f1d4-4685-be74-d6d3ae8c76f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f518e1c2-2090-486c-8c45-02484ff2577d"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("002e1b2b-1f7e-4807-95fe-99c534ddd031"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("417e15d9-41c5-4402-8c8f-4ca072d3261c"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("484c71d0-2616-41cf-9b21-2d75291f99d7"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("4891bf12-6797-4065-b520-8b6cbb383bcb"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("4d6d43da-410f-40e7-b229-f49b9afec668"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("541c710c-c999-4f63-900c-750d9e6ad206"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("55d562fc-56ca-45f3-91d5-e1c60f657e52"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("59527c4d-2e7d-4019-acf2-c4ba972b45ff"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("5ce360b4-a52b-469c-864e-581079032040"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("612965c3-5d8c-4aa3-845c-47c3452e7082"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("6152d7a9-4063-44f7-a3c5-1bc5ebd7ef67"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("67bd12e6-ca01-42d9-8a9e-bf7aef6e26ec"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("67f71d18-25e2-445f-b519-7312728a4c08"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("699b687b-a383-4f48-a64a-90aabd0f3e06"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("75f5b1f0-4163-426f-b13a-aca8f059f50c"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("8312238b-3bb8-4560-b8ce-0461890051c6"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("84f3b4fd-5a73-4cab-ad62-6e1d91e63d65"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("8d800f94-9c89-428f-a7e8-4b6ee27dabd7"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("8dfb4dc4-9619-43da-88b6-d0d9d6a22ac2"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("a0811e53-73ee-4125-a4eb-8a902ad9de54"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("a39cd731-1a83-4afc-be9c-90e48cf6c4b4"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("aa73ff57-3207-480c-944e-d0b0705ea0a1"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("accc3802-ddef-46d8-b922-3319e8fa5cf3"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("b2c1b643-2a06-4410-8531-572bdf522174"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("b80633ca-5609-496b-b629-5ea0f96e56da"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("ba5bab68-c10e-47fa-ab9a-6c289d98874a"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("bd56759f-5a35-4f70-b3e5-9a8b26f76e07"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("c05251a4-6f20-4784-ad81-09a2daf61201"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("dbc47895-ecc2-4d51-a0d1-3320e18f12c0"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f0319e10-f3cd-47ed-8631-ae6d3a08dd3b"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f06e7936-7e03-42ff-b5ac-e64b68b91731"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f0aa8371-a126-4659-9004-075b03a98a32"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f1772b63-ee43-46e7-b8c2-a7f67fd2cede"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f5ba74f4-062e-46e8-bb8a-106ce02ebba0"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f6ae1f62-82cd-40ef-84e8-dcfd349326f1"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f89890f2-0e4b-4c32-ab62-1a4af5c86ad8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("6785ef90-5968-4673-918f-87969772d761"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("045fd78f-d876-4b31-8e8e-93c7f28fba90"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0cbd6601-75d8-4c01-aab1-45d423fa9319"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("14acfd39-649e-44bb-b4c9-81bb485c1565"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2273247a-5ea9-4956-bbe3-e4e1fbedc68a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("27c21c60-30bb-4cb7-a3e3-4857aab19659"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("27f1e861-b79c-4143-9b88-69313b52ccc0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("291c9fec-de54-438a-a80b-cb050e1432f2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2d3c506b-0f9e-4676-8eb1-87714c5eefb9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2e6514ee-f003-4a1c-b604-ee104cb18e9c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("338fe279-f58e-4c5e-9081-9648454a2753"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3d66a605-b2f6-414e-b4fa-7a679521bbdf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("42c6514f-3632-4599-af6a-982cf4845ef4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("44ff300d-60b2-405f-aeae-46d9f3a15240"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4c2b1381-e9ec-41e5-858f-0b4e03a0b1dd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4c941439-f62a-48fc-8aa6-d047333edb44"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("566cf487-3ed6-40c5-ae72-d3741beff430"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("584cde08-c075-407e-a09f-d5a533fbc45f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("62cef015-f0eb-4a6d-a0ce-43263a9de3e5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("671a6804-d308-419d-b56e-84b4c8858681"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6785ef90-5968-4673-918f-87969772d761"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("697a9e49-5424-4293-803b-71cde4bd3c23"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7c117e49-26a5-44a1-ad74-028fc5ccc9cd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8ea1e7b2-5649-4204-aed8-c92eba7ef250"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8f30ff42-f259-4b6a-90b2-3745f361afff"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("936e7f20-6944-43f3-8e3d-99bccbeb26c8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9803212f-9417-4247-b409-1faaf7e69066"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("99d71edc-63a4-4a24-b278-b49d0bb19f49"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9b342db1-edd9-4031-8d39-95f30c0141a7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9d71a4b5-d03c-4341-bf59-2920f6ae260e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9e7ed602-ce49-4120-8013-d672ff620db5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a2263c6b-31e9-4242-8663-697fcc365987"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b3050769-754a-4389-8690-8ec99304fb18"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b73b2bfd-896d-42d9-8768-2bda7f1fc5aa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b7410b97-9dd3-403f-bad8-9ddae8158612"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b886c14b-274f-4bd7-be28-3e8f37ea9503"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b96d78b3-d8cb-4634-8534-636517564e76"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c62ff166-4f6a-4126-916a-ea30a7804072"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c868fdb3-b9c3-4a4e-9727-bf3cf5f2b20f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cc555932-1240-4511-8879-82d6a043a116"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ce097aa9-4fb3-4a6e-ad49-ac8a555743d6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d50391ff-a32e-4abf-b45f-5e4cf058b204"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e67b668b-c463-423b-8022-1832825cb1be"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e86bcb2a-cd9b-4175-a190-d4872e96e236"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ea4c9cd4-14d3-456e-aa97-e835f7f8dbff"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f19daf6f-9705-4a6f-a953-9d9d69604436"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f43b2256-f1d4-4685-be74-d6d3ae8c76f0"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f518e1c2-2090-486c-8c45-02484ff2577d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f956ef9c-56a1-4e16-b10b-d8ac343cffc8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("0c7f5ef1-381a-4bd8-8a8c-1b7206f4302d"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("1909e4a8-1ecc-4582-a32f-3dcb763945c9"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("1efefa0b-ace0-4ba2-8185-e71a670ceb0e"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("24e675c8-531b-4edf-b803-41bf7e71a2cb"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("33bb17dd-3a83-4044-8ca0-3ee2f3911cbf"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("4e7fe592-340b-4f26-89b7-c2feb5faa7d3"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("529a8b66-6849-4683-abcd-872d416fd5fd"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("52af14c0-7757-40ae-884e-88e3013b730b"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("5768dc74-c81f-4aba-b0f4-57e6d210f670"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("5c990f17-9d29-4c6d-9606-8b959675b3d5"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("830de201-cff7-4415-b7e1-c6957b4dce49"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("88791463-d7e2-4c57-b665-e12a14104b05"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("8bc397dd-d7f9-4623-81c0-85c8049d1a2b"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("9fb0e6fa-0ce0-4221-96cb-49d7542661fe"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("b189dc61-46cc-4cab-a913-633ff0dee857"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("c25fdb06-39c8-4863-b5c4-7d5cc8dd64a4"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("e9bd3d5c-3db6-4a01-97a3-a97cd3908cfa"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("ebbca6e3-5c58-4661-8116-21553ebc6634"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("071f8601-80b8-42c5-8d93-6440c4633c35"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("15e101e5-6231-465a-b661-6b9e8830332c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("2daf477e-5667-485b-8efb-3858c7cababb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("467747c2-5e64-433e-afc5-e8f521652bbf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("071f8601-80b8-42c5-8d93-6440c4633c35"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0a153192-1f8f-4a92-bb16-ab82de4379e3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0e322cc8-03b5-43b6-9cda-bca157b07e33"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("15e101e5-6231-465a-b661-6b9e8830332c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a05ca7c-b73d-4b77-8a01-17f7e881c936"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2cfc839b-ba6b-46c6-8955-3b2d2ee8694c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2daf477e-5667-485b-8efb-3858c7cababb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3158898d-bbb8-4a85-8c7e-de9e501cf88f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("36f86193-5211-46e2-b0f1-efb607cb0976"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3c605bc1-2cf3-4078-91ef-1acea4474300"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("467747c2-5e64-433e-afc5-e8f521652bbf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("474db11c-c458-481b-bfc5-bfa3cef134d1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("47f98e38-f0b2-4fe8-a0ad-8e0abee2ee0d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5a53e5de-c9ba-483b-b346-46e9fde8dd26"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7de58915-84e7-4bde-a808-7542b0eb1c60"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8a94aee2-829e-4b4b-9ba9-285e264cc3fa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8ebe6c8b-2453-43e5-9b03-8e5d47e37b9a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8f63fb9b-1483-47ba-9e40-0a140281837c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("94f64a73-7b1e-404e-8660-068df7ae798f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9bffef4c-c3ff-46b6-97f6-b40d4fe7c6d3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ab14935a-1968-4ad4-9eb9-4288cc10b1e8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b194fcc6-c8ba-43d2-80f1-e68c5338ea99"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b25f6943-cea8-459d-8c6e-df8d39e2e488"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b2bf36e3-9d2c-465b-b0f4-3686b50b4aa2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b57c5901-c882-4a88-9cb7-d11e58f9c678"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b9fdcfa2-129e-47f6-81ff-efcc333d32b7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bb767ae3-7dc9-4bb9-b8c1-a3da35939353"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cbc18fd5-6116-4dd0-827e-a0e82fa8a1e2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cd60f589-6db5-4124-a1e7-b26b1515a49f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ddb72c19-7cc0-4197-a1be-17b08df39f48"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e42fe777-8736-4749-a8a1-af57ac97ce7e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e6b6b58b-fa82-4507-b48d-caa40e0222f9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f84adcc5-fffe-4f79-950a-b46e8922f02c"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("17d9eef8-a266-41cb-8d39-3b53a12d6580"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("20764258-d0a1-439a-aa0b-7fb740e33dc9"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("2d3125e6-96ee-46cf-b463-10d6f49aa402"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("5ecba4df-60e5-46bb-91e7-f96312e14e7f"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("80632e42-b5f6-4eaa-9683-49f052fca4f0"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("e078d27d-3057-428a-9578-326a5b969ea5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("249c3565-3c41-47d1-88e6-621398c458be"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("fe763220-9d76-451a-add3-d88a4e35722a"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("3723ac71-a7a1-47b4-bcca-3744fff1bebd"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("6cce64f9-b62d-4e80-82f0-b176416a2f92"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("aff34571-8aed-44e1-9a97-351bf716b5fb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0dd819b3-f715-4609-84e7-53c5de8c2cea"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("249c3565-3c41-47d1-88e6-621398c458be"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3745bdd4-6b4f-4a97-a4fd-1d284b5604ab"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("baef3a80-e7af-46f7-8d66-1cbccbb3e3bd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4fc87ec-d782-4a1e-8190-f93e95d89bd6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fe763220-9d76-451a-add3-d88a4e35722a"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("7c70a3ed-fe42-4ab2-b25b-606310a83114"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("87acd182-4559-4bf1-8052-6f88b2eab736"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("9e97fae8-6c04-47f0-be77-054b12a6cbdb"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("9a851801-27e2-4559-89cf-84283b799d7d"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("c0535cbe-7031-40e0-8aaa-4a91d8321e79"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("9490afde-363a-4d62-aa71-848e4287787f"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("c7c4488a-db08-4a93-87ed-93a5d3287542"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("fc0c41a7-ac00-4471-8abc-162d286d1b32"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("08753260-7db2-4911-97b2-cf49552414ff"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("08753260-7db2-4911-97b2-cf49552414ff"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a47218c1-407a-4dd9-902e-be32b9cdada3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("aa41f24d-08d5-4e2b-a769-f5da4e64e02b"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("da11d8d8-4e6d-4971-ae42-31ff5637e6c8"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("fe77741b-c5c7-4ca5-8449-64b5b692892c"));

            migrationBuilder.DropColumn(
                name: "StudyYearId",
                table: "Groups");

            migrationBuilder.AlterColumn<long>(
                name: "Number",
                table: "Groups",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321"), "", "dummyEmail@email.com", "firstName0", "firstName0", "dummyPasswordHash", null, "Teacher", "TestAccount0" },
                    { new Guid("5209cacf-4f7c-4a88-9f1d-95ca8af3b052"), "", "dummyEmail@email.com", "firstName73", "firstName73", "dummyPasswordHash", null, "Student", "TestAccount73" },
                    { new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"), "", "dummyEmail@email.com", "firstName71", "firstName71", "dummyPasswordHash", null, "Student", "TestAccount71" },
                    { new Guid("005fcf54-4ac3-4794-80e9-d9e7831c05ec"), "", "dummyEmail@email.com", "firstName70", "firstName70", "dummyPasswordHash", null, "Student", "TestAccount70" },
                    { new Guid("ad5c6c97-3c62-4752-b2c9-b4b8141e3dab"), "", "dummyEmail@email.com", "firstName69", "firstName69", "dummyPasswordHash", null, "Student", "TestAccount69" },
                    { new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"), "", "dummyEmail@email.com", "firstName68", "firstName68", "dummyPasswordHash", null, "Student", "TestAccount68" },
                    { new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"), "", "dummyEmail@email.com", "firstName67", "firstName67", "dummyPasswordHash", null, "Student", "TestAccount67" },
                    { new Guid("11a6bc52-2db0-477f-a17a-94c878e33f6c"), "", "dummyEmail@email.com", "firstName66", "firstName66", "dummyPasswordHash", null, "Student", "TestAccount66" },
                    { new Guid("a3702ac3-d8e6-479e-ad3d-90371c448e32"), "", "dummyEmail@email.com", "firstName65", "firstName65", "dummyPasswordHash", null, "Student", "TestAccount65" },
                    { new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"), "", "dummyEmail@email.com", "firstName64", "firstName64", "dummyPasswordHash", null, "Student", "TestAccount64" },
                    { new Guid("c157cb2c-9b1f-4ee2-8bb5-0919d1802622"), "", "dummyEmail@email.com", "firstName63", "firstName63", "dummyPasswordHash", null, "Student", "TestAccount63" },
                    { new Guid("abebab04-e1f0-444a-a09d-b1c1c70b9ce2"), "", "dummyEmail@email.com", "firstName62", "firstName62", "dummyPasswordHash", null, "Student", "TestAccount62" },
                    { new Guid("52d2e621-2150-4328-a00c-f1f307038311"), "", "dummyEmail@email.com", "firstName61", "firstName61", "dummyPasswordHash", null, "Student", "TestAccount61" },
                    { new Guid("b08456ce-23d2-474d-bf65-0688076d83dd"), "", "dummyEmail@email.com", "firstName60", "firstName60", "dummyPasswordHash", null, "Student", "TestAccount60" },
                    { new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"), "", "dummyEmail@email.com", "firstName59", "firstName59", "dummyPasswordHash", null, "Student", "TestAccount59" },
                    { new Guid("625d1d34-7e86-41fe-8eb2-985fe439a6ed"), "", "dummyEmail@email.com", "firstName58", "firstName58", "dummyPasswordHash", null, "Student", "TestAccount58" },
                    { new Guid("03a3c074-ae04-4f5c-a6d0-4e4b61820152"), "", "dummyEmail@email.com", "firstName57", "firstName57", "dummyPasswordHash", null, "Student", "TestAccount57" },
                    { new Guid("c148479c-48ff-4120-94f2-baa33b6e8a09"), "", "dummyEmail@email.com", "firstName56", "firstName56", "dummyPasswordHash", null, "Student", "TestAccount56" },
                    { new Guid("e283577f-d734-401b-89b3-cf0e6a026e0f"), "", "dummyEmail@email.com", "firstName55", "firstName55", "dummyPasswordHash", null, "Student", "TestAccount55" },
                    { new Guid("e7b5f652-f44f-467e-935d-78bd2de865c4"), "", "dummyEmail@email.com", "firstName54", "firstName54", "dummyPasswordHash", null, "Student", "TestAccount54" },
                    { new Guid("fdb4e33f-9d37-438c-af39-ff0516c2d8db"), "", "dummyEmail@email.com", "firstName53", "firstName53", "dummyPasswordHash", null, "Student", "TestAccount53" },
                    { new Guid("362b789c-e8e6-40b4-b590-7f9743cb9856"), "", "dummyEmail@email.com", "firstName52", "firstName52", "dummyPasswordHash", null, "Student", "TestAccount52" },
                    { new Guid("13f231f6-e8ec-43d9-a052-844ee9041034"), "", "dummyEmail@email.com", "firstName74", "firstName74", "dummyPasswordHash", null, "Student", "TestAccount74" },
                    { new Guid("510b4925-7fc0-4de0-8921-a1756faab7c1"), "", "dummyEmail@email.com", "firstName75", "firstName75", "dummyPasswordHash", null, "Student", "TestAccount75" },
                    { new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"), "", "dummyEmail@email.com", "firstName76", "firstName76", "dummyPasswordHash", null, "Student", "TestAccount76" },
                    { new Guid("033a4dfb-dea0-442b-8f07-efffda3dc66c"), "", "dummyEmail@email.com", "firstName77", "firstName77", "dummyPasswordHash", null, "Student", "TestAccount77" },
                    { new Guid("b02c2a20-c85f-42e3-8edd-68cb3fe4e84e"), "", "dummyEmail@email.com", "firstName99", "firstName99", "dummyPasswordHash", null, "Student", "TestAccount99" },
                    { new Guid("dc33adb6-52b6-4a9e-9401-66a305c9ab69"), "", "dummyEmail@email.com", "firstName98", "firstName98", "dummyPasswordHash", null, "Student", "TestAccount98" },
                    { new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"), "", "dummyEmail@email.com", "firstName97", "firstName97", "dummyPasswordHash", null, "Student", "TestAccount97" },
                    { new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"), "", "dummyEmail@email.com", "firstName96", "firstName96", "dummyPasswordHash", null, "Student", "TestAccount96" },
                    { new Guid("5e1879dd-aeb7-4de5-aa0f-4d725fe917fa"), "", "dummyEmail@email.com", "firstName95", "firstName95", "dummyPasswordHash", null, "Student", "TestAccount95" },
                    { new Guid("7942c487-3bbf-439b-ab22-dc3f0bce4cc2"), "", "dummyEmail@email.com", "firstName94", "firstName94", "dummyPasswordHash", null, "Student", "TestAccount94" },
                    { new Guid("53cbe638-d1e3-410c-a204-1f11f2c7633b"), "", "dummyEmail@email.com", "firstName93", "firstName93", "dummyPasswordHash", null, "Student", "TestAccount93" },
                    { new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"), "", "dummyEmail@email.com", "firstName92", "firstName92", "dummyPasswordHash", null, "Student", "TestAccount92" },
                    { new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"), "", "dummyEmail@email.com", "firstName91", "firstName91", "dummyPasswordHash", null, "Student", "TestAccount91" },
                    { new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"), "", "dummyEmail@email.com", "firstName90", "firstName90", "dummyPasswordHash", null, "Student", "TestAccount90" },
                    { new Guid("6e8ad44e-d46b-4f50-beee-0562f82288a9"), "", "dummyEmail@email.com", "firstName51", "firstName51", "dummyPasswordHash", null, "Student", "TestAccount51" },
                    { new Guid("5a424122-f16b-4bc8-891a-48fe333b6341"), "", "dummyEmail@email.com", "firstName89", "firstName89", "dummyPasswordHash", null, "Student", "TestAccount89" },
                    { new Guid("c71686c6-741c-4929-84c0-66cbb9f5a73a"), "", "dummyEmail@email.com", "firstName87", "firstName87", "dummyPasswordHash", null, "Student", "TestAccount87" },
                    { new Guid("479e5195-5d9f-45f9-953c-5417315cdd48"), "", "dummyEmail@email.com", "firstName86", "firstName86", "dummyPasswordHash", null, "Student", "TestAccount86" },
                    { new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"), "", "dummyEmail@email.com", "firstName85", "firstName85", "dummyPasswordHash", null, "Student", "TestAccount85" },
                    { new Guid("f27b51b6-95fa-4f4c-8b46-752b8542c51f"), "", "dummyEmail@email.com", "firstName84", "firstName84", "dummyPasswordHash", null, "Student", "TestAccount84" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"), "", "dummyEmail@email.com", "firstName83", "firstName83", "dummyPasswordHash", null, "Student", "TestAccount83" },
                    { new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"), "", "dummyEmail@email.com", "firstName82", "firstName82", "dummyPasswordHash", null, "Student", "TestAccount82" },
                    { new Guid("41de7aa6-3e5f-47bf-88ba-37030de4231b"), "", "dummyEmail@email.com", "firstName81", "firstName81", "dummyPasswordHash", null, "Student", "TestAccount81" },
                    { new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"), "", "dummyEmail@email.com", "firstName80", "firstName80", "dummyPasswordHash", null, "Student", "TestAccount80" },
                    { new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d"), "", "dummyEmail@email.com", "firstName79", "firstName79", "dummyPasswordHash", null, "Student", "TestAccount79" },
                    { new Guid("d9db07d2-23b5-4d75-8e14-21733126d60e"), "", "dummyEmail@email.com", "firstName78", "firstName78", "dummyPasswordHash", null, "Student", "TestAccount78" },
                    { new Guid("43936095-8cef-40d0-b61d-069a130596f0"), "", "dummyEmail@email.com", "firstName88", "firstName88", "dummyPasswordHash", null, "Student", "TestAccount88" },
                    { new Guid("9ac3aac0-5341-4389-8153-c98bbb803cc8"), "", "dummyEmail@email.com", "firstName50", "firstName50", "dummyPasswordHash", null, "Student", "TestAccount50" },
                    { new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"), "", "dummyEmail@email.com", "firstName72", "firstName72", "dummyPasswordHash", null, "Student", "TestAccount72" },
                    { new Guid("10521b95-7b13-4cd8-b47a-19fac79fa145"), "", "dummyEmail@email.com", "firstName48", "firstName48", "dummyPasswordHash", null, "Student", "TestAccount48" },
                    { new Guid("58e48dc7-8a44-4735-b08c-2c560ed2792b"), "", "dummyEmail@email.com", "firstName22", "firstName22", "dummyPasswordHash", null, "Admin", "TestAccount22" },
                    { new Guid("e9d7ae38-013d-406c-b736-3e35f7d9efe6"), "", "dummyEmail@email.com", "firstName21", "firstName21", "dummyPasswordHash", null, "Admin", "TestAccount21" },
                    { new Guid("725d347f-f406-4a23-b414-4f277ad1e86d"), "", "dummyEmail@email.com", "firstName20", "firstName20", "dummyPasswordHash", null, "Admin", "TestAccount20" },
                    { new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da"), "", "dummyEmail@email.com", "firstName19", "firstName19", "dummyPasswordHash", null, "Teacher", "TestAccount19" },
                    { new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5"), "", "dummyEmail@email.com", "firstName18", "firstName18", "dummyPasswordHash", null, "Teacher", "TestAccount18" },
                    { new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9"), "", "dummyEmail@email.com", "firstName17", "firstName17", "dummyPasswordHash", null, "Teacher", "TestAccount17" },
                    { new Guid("f04a31a2-88f6-4ff3-8925-926403e18987"), "", "dummyEmail@email.com", "firstName16", "firstName16", "dummyPasswordHash", null, "Teacher", "TestAccount16" },
                    { new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d"), "", "dummyEmail@email.com", "firstName15", "firstName15", "dummyPasswordHash", null, "Teacher", "TestAccount15" },
                    { new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b"), "", "dummyEmail@email.com", "firstName14", "firstName14", "dummyPasswordHash", null, "Teacher", "TestAccount14" },
                    { new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216"), "", "dummyEmail@email.com", "firstName13", "firstName13", "dummyPasswordHash", null, "Teacher", "TestAccount13" },
                    { new Guid("b5e8e40a-8bff-4e8c-96b7-e4999b9721a4"), "", "dummyEmail@email.com", "firstName23", "firstName23", "dummyPasswordHash", null, "Admin", "TestAccount23" },
                    { new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f"), "", "dummyEmail@email.com", "firstName12", "firstName12", "dummyPasswordHash", null, "Teacher", "TestAccount12" },
                    { new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e"), "", "dummyEmail@email.com", "firstName10", "firstName10", "dummyPasswordHash", null, "Teacher", "TestAccount10" },
                    { new Guid("64f2c511-583d-4dc4-a811-dada76aba579"), "", "dummyEmail@email.com", "firstName9", "firstName9", "dummyPasswordHash", null, "Teacher", "TestAccount9" },
                    { new Guid("57489b88-50a6-412f-8d32-d544805f5eaa"), "", "dummyEmail@email.com", "firstName8", "firstName8", "dummyPasswordHash", null, "Teacher", "TestAccount8" },
                    { new Guid("38f00b21-23bd-4d5b-9bff-70839859e665"), "", "dummyEmail@email.com", "firstName7", "firstName7", "dummyPasswordHash", null, "Teacher", "TestAccount7" },
                    { new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea"), "", "dummyEmail@email.com", "firstName6", "firstName6", "dummyPasswordHash", null, "Teacher", "TestAccount6" },
                    { new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac"), "", "dummyEmail@email.com", "firstName5", "firstName5", "dummyPasswordHash", null, "Teacher", "TestAccount5" },
                    { new Guid("5189c11f-749c-4cff-b130-1a7093c9a639"), "", "dummyEmail@email.com", "firstName4", "firstName4", "dummyPasswordHash", null, "Teacher", "TestAccount4" },
                    { new Guid("440f5863-b80a-444b-9e38-7628b16206a1"), "", "dummyEmail@email.com", "firstName3", "firstName3", "dummyPasswordHash", null, "Teacher", "TestAccount3" },
                    { new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"), "", "dummyEmail@email.com", "firstName49", "firstName49", "dummyPasswordHash", null, "Student", "TestAccount49" },
                    { new Guid("6eaf6240-ff67-4807-838f-df36916e11a9"), "", "dummyEmail@email.com", "firstName1", "firstName1", "dummyPasswordHash", null, "Teacher", "TestAccount1" },
                    { new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda"), "", "dummyEmail@email.com", "firstName11", "firstName11", "dummyPasswordHash", null, "Teacher", "TestAccount11" },
                    { new Guid("e5751c44-22b5-4e43-ab2a-e1bfa4e29876"), "", "dummyEmail@email.com", "firstName24", "firstName24", "dummyPasswordHash", null, "Admin", "TestAccount24" },
                    { new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e"), "", "dummyEmail@email.com", "firstName2", "firstName2", "dummyPasswordHash", null, "Teacher", "TestAccount2" },
                    { new Guid("0170e463-e46e-42c0-87af-6c782bc27514"), "", "dummyEmail@email.com", "firstName26", "firstName26", "dummyPasswordHash", null, "Admin", "TestAccount26" },
                    { new Guid("57b4f3ff-0a61-4fa5-9139-d53611786dc0"), "", "dummyEmail@email.com", "firstName25", "firstName25", "dummyPasswordHash", null, "Admin", "TestAccount25" },
                    { new Guid("3e262014-0d7f-4a65-bce6-d93074a8c4dc"), "", "dummyEmail@email.com", "firstName47", "firstName47", "dummyPasswordHash", null, "Student", "TestAccount47" },
                    { new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"), "", "dummyEmail@email.com", "firstName46", "firstName46", "dummyPasswordHash", null, "Student", "TestAccount46" },
                    { new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"), "", "dummyEmail@email.com", "firstName44", "firstName44", "dummyPasswordHash", null, "Student", "TestAccount44" },
                    { new Guid("03bb9ca9-ae28-48a0-af2d-2177898b3706"), "", "dummyEmail@email.com", "firstName43", "firstName43", "dummyPasswordHash", null, "Student", "TestAccount43" },
                    { new Guid("276dd141-eee9-44a2-8f97-41decc40381e"), "", "dummyEmail@email.com", "firstName42", "firstName42", "dummyPasswordHash", null, "Student", "TestAccount42" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("2265a5ee-c06d-4ce7-a6e3-61971bb97b7e"), "", "dummyEmail@email.com", "firstName41", "firstName41", "dummyPasswordHash", null, "Student", "TestAccount41" },
                    { new Guid("78f93bcc-d1ab-4f22-8055-d6096634b45c"), "", "dummyEmail@email.com", "firstName40", "firstName40", "dummyPasswordHash", null, "Student", "TestAccount40" },
                    { new Guid("748922e6-fc92-43ec-88b2-3da72ed82b58"), "", "dummyEmail@email.com", "firstName39", "firstName39", "dummyPasswordHash", null, "Student", "TestAccount39" },
                    { new Guid("e08c079e-2af4-4aba-824a-e8645fe0f06f"), "", "dummyEmail@email.com", "firstName38", "firstName38", "dummyPasswordHash", null, "Student", "TestAccount38" },
                    { new Guid("93a27655-a27a-4fc1-83ce-4bfe7870584e"), "", "dummyEmail@email.com", "firstName37", "firstName37", "dummyPasswordHash", null, "Student", "TestAccount37" },
                    { new Guid("07dfc2c5-ff08-4ca2-9d75-ac2400f718e7"), "", "dummyEmail@email.com", "firstName45", "firstName45", "dummyPasswordHash", null, "Student", "TestAccount45" },
                    { new Guid("cb8878dd-25c6-4edc-bf11-28f061797d43"), "", "dummyEmail@email.com", "firstName35", "firstName35", "dummyPasswordHash", null, "Student", "TestAccount35" },
                    { new Guid("a086d6f7-a8ca-4dd9-8cd4-28e1c67e96dd"), "", "dummyEmail@email.com", "firstName36", "firstName36", "dummyPasswordHash", null, "Student", "TestAccount36" },
                    { new Guid("8bce7ea9-4038-4120-8603-c657e670678a"), "", "dummyEmail@email.com", "firstName27", "firstName27", "dummyPasswordHash", null, "Admin", "TestAccount27" },
                    { new Guid("89f81462-999e-4830-83a6-3b8516753656"), "", "dummyEmail@email.com", "firstName29", "firstName29", "dummyPasswordHash", null, "Admin", "TestAccount29" },
                    { new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"), "", "dummyEmail@email.com", "firstName30", "firstName30", "dummyPasswordHash", null, "Student", "TestAccount30" },
                    { new Guid("4bac3c89-6139-4fbe-9375-9c3089607a4c"), "", "dummyEmail@email.com", "firstName28", "firstName28", "dummyPasswordHash", null, "Admin", "TestAccount28" },
                    { new Guid("ebe81c59-bf12-4df5-9baa-5af90bf5fef0"), "", "dummyEmail@email.com", "firstName32", "firstName32", "dummyPasswordHash", null, "Student", "TestAccount32" },
                    { new Guid("ae16bb0e-76b1-45ed-bf72-61ae86ad4b77"), "", "dummyEmail@email.com", "firstName33", "firstName33", "dummyPasswordHash", null, "Student", "TestAccount33" },
                    { new Guid("dd90d328-9e3b-42cb-ba19-e1d71ba99b78"), "", "dummyEmail@email.com", "firstName34", "firstName34", "dummyPasswordHash", null, "Student", "TestAccount34" },
                    { new Guid("7a286bfb-2317-41be-a927-3543eb6b675c"), "", "dummyEmail@email.com", "firstName31", "firstName31", "dummyPasswordHash", null, "Student", "TestAccount31" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("b7224856-e3c7-4071-a9fa-41410ed466b0"), null, 0L, null },
                    { new Guid("85f52f4b-149a-492c-ab15-b317a51c9fab"), null, 0L, null },
                    { new Guid("07a97332-9348-4d3d-9d9b-09f9701393c9"), null, 0L, null },
                    { new Guid("c11b837c-ddae-41f4-bf49-ace5e4ad517b"), null, 0L, null },
                    { new Guid("b0451579-06e1-4124-bf68-d48bb1d20237"), null, 0L, null },
                    { new Guid("b6731905-4a7d-4523-9ab8-ef1400249ebe"), null, 0L, null },
                    { new Guid("f7532d6b-bf41-4d53-b450-4b4fdb10efb0"), null, 0L, null },
                    { new Guid("03c1fc56-8c4c-4895-9cd7-638dd51c1f3e"), null, 0L, null },
                    { new Guid("c59a0945-ec6f-4860-b1da-4be977ed624f"), null, 0L, null },
                    { new Guid("365518ec-babb-4ef8-ae51-807dbd4e23d5"), null, 0L, null },
                    { new Guid("b79a7445-1d91-4472-a333-793fd3289b3d"), null, 0L, null },
                    { new Guid("56e6e584-63c7-45c0-988a-b7869b0d30e7"), null, 0L, null },
                    { new Guid("bcf40ec1-3934-4264-86d2-669db0fa03bf"), null, 0L, null },
                    { new Guid("82a89abb-487f-426a-80a7-d746fc712c46"), null, 0L, null },
                    { new Guid("75819c49-6ffd-469a-b7ed-2c11d72e673c"), null, 0L, null },
                    { new Guid("5d603485-ac47-4093-a73a-83a7593022a7"), null, 0L, null },
                    { new Guid("9b590f67-1d06-4221-83f6-8e48d5d88e74"), null, 0L, null },
                    { new Guid("cbafa8d0-f66e-467f-990b-cd0ad21ae6aa"), null, 0L, null },
                    { new Guid("6ce585ac-5513-4089-b668-692f58bdc331"), null, 0L, null },
                    { new Guid("4dd55ace-37f5-4e3d-8f13-e44307725447"), null, 0L, null },
                    { new Guid("f19c9c3a-00c0-4503-a906-4258efc04b17"), null, 0L, null },
                    { new Guid("3bdd5d34-6aae-44ae-a212-323359221dbf"), null, 0L, null },
                    { new Guid("66c061f7-ec5b-431a-b4b2-fcdd26640233"), null, 0L, null },
                    { new Guid("1306d78e-5b99-4165-bb5b-668cd69aa9ff"), null, 0L, null },
                    { new Guid("e004cf77-e527-4eac-89bd-d0cfc249918a"), null, 0L, null },
                    { new Guid("da1944e4-839d-41a3-b64d-d78f24bd89c1"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("5b05cf34-933f-444f-932c-116da17e0931"), null, 0L, null },
                    { new Guid("e4c37165-7c32-43e2-a0cb-daf869a920e4"), null, 0L, null },
                    { new Guid("4ba394de-5f78-4bfc-b42d-dd4cd3037db4"), null, 0L, null },
                    { new Guid("3df85a78-4052-4926-b7bf-5dc6e4bff475"), null, 0L, null },
                    { new Guid("c494ceb6-a661-48ca-bc79-dc8932627804"), null, 0L, null },
                    { new Guid("4ccb50c1-1ee3-4fac-9a30-f6f88d7ea4f6"), null, 0L, null },
                    { new Guid("d6b4fa4a-2c33-48b7-95d6-b8662804dad1"), null, 0L, null },
                    { new Guid("6d364226-b034-445c-a182-34aee0e2fdcd"), null, 0L, null },
                    { new Guid("a5d19899-24a3-439e-aef6-0d52f99360ab"), null, 0L, null },
                    { new Guid("8e23c49c-6374-4981-8905-fd55ee39d6df"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), "Bachelor" },
                    { new Guid("1de1e5c4-fe7b-4722-821b-c0a49eeefd44"), "Master" }
                });

            migrationBuilder.InsertData(
                table: "StudyLines",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("b2793483-354a-4e4f-a12e-1879999ecc80"), "English", "EN" },
                    { new Guid("90341a59-9256-4577-be1f-40f1d5773dad"), "Romanian", "RO" },
                    { new Guid("d804c6b1-1315-41ab-bda8-7ffdb55e4987"), "German", "DE" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name", "Rank" },
                values: new object[,]
                {
                    { new Guid("53f4cdd5-a197-453e-885e-11f84e377b20"), "TeacherDegree0", 0 },
                    { new Guid("ee9319ee-65bc-4974-b7ba-2a804ef90d83"), "TeacherDegree1", 0 },
                    { new Guid("6c91262f-793c-4277-8076-2c276d53f655"), "TeacherDegree2", 0 },
                    { new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b"), "TeacherDegree3", 0 },
                    { new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4"), "TeacherDegree4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("725d347f-f406-4a23-b414-4f277ad1e86d"),
                    new Guid("89f81462-999e-4830-83a6-3b8516753656"),
                    new Guid("8bce7ea9-4038-4120-8603-c657e670678a"),
                    new Guid("0170e463-e46e-42c0-87af-6c782bc27514"),
                    new Guid("57b4f3ff-0a61-4fa5-9139-d53611786dc0"),
                    new Guid("4bac3c89-6139-4fbe-9375-9c3089607a4c"),
                    new Guid("b5e8e40a-8bff-4e8c-96b7-e4999b9721a4"),
                    new Guid("58e48dc7-8a44-4735-b08c-2c560ed2792b"),
                    new Guid("e9d7ae38-013d-406c-b736-3e35f7d9efe6"),
                    new Guid("e5751c44-22b5-4e43-ab2a-e1bfa4e29876")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"),
                    new Guid("41de7aa6-3e5f-47bf-88ba-37030de4231b"),
                    new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"),
                    new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d"),
                    new Guid("d9db07d2-23b5-4d75-8e14-21733126d60e"),
                    new Guid("033a4dfb-dea0-442b-8f07-efffda3dc66c"),
                    new Guid("510b4925-7fc0-4de0-8921-a1756faab7c1"),
                    new Guid("005fcf54-4ac3-4794-80e9-d9e7831c05ec"),
                    new Guid("5209cacf-4f7c-4a88-9f1d-95ca8af3b052"),
                    new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"),
                    new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"),
                    new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"),
                    new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"),
                    new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"),
                    new Guid("13f231f6-e8ec-43d9-a052-844ee9041034"),
                    new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"),
                    new Guid("43936095-8cef-40d0-b61d-069a130596f0"),
                    new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"),
                    new Guid("b02c2a20-c85f-42e3-8edd-68cb3fe4e84e"),
                    new Guid("dc33adb6-52b6-4a9e-9401-66a305c9ab69"),
                    new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"),
                    new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"),
                    new Guid("5e1879dd-aeb7-4de5-aa0f-4d725fe917fa"),
                    new Guid("7942c487-3bbf-439b-ab22-dc3f0bce4cc2"),
                    new Guid("f27b51b6-95fa-4f4c-8b46-752b8542c51f"),
                    new Guid("53cbe638-d1e3-410c-a204-1f11f2c7633b"),
                    new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"),
                    new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"),
                    new Guid("5a424122-f16b-4bc8-891a-48fe333b6341"),
                    new Guid("11a6bc52-2db0-477f-a17a-94c878e33f6c"),
                    new Guid("c71686c6-741c-4929-84c0-66cbb9f5a73a"),
                    new Guid("479e5195-5d9f-45f9-953c-5417315cdd48")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"),
                    new Guid("a3702ac3-d8e6-479e-ad3d-90371c448e32"),
                    new Guid("ad5c6c97-3c62-4752-b2c9-b4b8141e3dab"),
                    new Guid("c157cb2c-9b1f-4ee2-8bb5-0919d1802622"),
                    new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"),
                    new Guid("03bb9ca9-ae28-48a0-af2d-2177898b3706"),
                    new Guid("276dd141-eee9-44a2-8f97-41decc40381e"),
                    new Guid("2265a5ee-c06d-4ce7-a6e3-61971bb97b7e"),
                    new Guid("78f93bcc-d1ab-4f22-8055-d6096634b45c"),
                    new Guid("748922e6-fc92-43ec-88b2-3da72ed82b58"),
                    new Guid("e08c079e-2af4-4aba-824a-e8645fe0f06f"),
                    new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"),
                    new Guid("a086d6f7-a8ca-4dd9-8cd4-28e1c67e96dd"),
                    new Guid("cb8878dd-25c6-4edc-bf11-28f061797d43"),
                    new Guid("dd90d328-9e3b-42cb-ba19-e1d71ba99b78"),
                    new Guid("ae16bb0e-76b1-45ed-bf72-61ae86ad4b77"),
                    new Guid("ebe81c59-bf12-4df5-9baa-5af90bf5fef0"),
                    new Guid("7a286bfb-2317-41be-a927-3543eb6b675c"),
                    new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"),
                    new Guid("07dfc2c5-ff08-4ca2-9d75-ac2400f718e7"),
                    new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"),
                    new Guid("93a27655-a27a-4fc1-83ce-4bfe7870584e"),
                    new Guid("10521b95-7b13-4cd8-b47a-19fac79fa145"),
                    new Guid("abebab04-e1f0-444a-a09d-b1c1c70b9ce2"),
                    new Guid("52d2e621-2150-4328-a00c-f1f307038311"),
                    new Guid("b08456ce-23d2-474d-bf65-0688076d83dd"),
                    new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"),
                    new Guid("625d1d34-7e86-41fe-8eb2-985fe439a6ed"),
                    new Guid("3e262014-0d7f-4a65-bce6-d93074a8c4dc"),
                    new Guid("c148479c-48ff-4120-94f2-baa33b6e8a09"),
                    new Guid("03a3c074-ae04-4f5c-a6d0-4e4b61820152"),
                    new Guid("e7b5f652-f44f-467e-935d-78bd2de865c4"),
                    new Guid("fdb4e33f-9d37-438c-af39-ff0516c2d8db"),
                    new Guid("362b789c-e8e6-40b4-b590-7f9743cb9856"),
                    new Guid("6e8ad44e-d46b-4f50-beee-0562f82288a9"),
                    new Guid("9ac3aac0-5341-4389-8153-c98bbb803cc8"),
                    new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"),
                    new Guid("e283577f-d734-401b-89b3-cf0e6a026e0f")
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e"), new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b") },
                    { new Guid("f04a31a2-88f6-4ff3-8925-926403e18987"), new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b") },
                    { new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5"), new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b") },
                    { new Guid("64f2c511-583d-4dc4-a811-dada76aba579"), new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac"), new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4") },
                    { new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea"), new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4") },
                    { new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d"), new Guid("6c91262f-793c-4277-8076-2c276d53f655") },
                    { new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da"), new Guid("65b21104-7698-4271-8a4a-f8cb4763d01b") },
                    { new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda"), new Guid("6c91262f-793c-4277-8076-2c276d53f655") },
                    { new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e"), new Guid("53f4cdd5-a197-453e-885e-11f84e377b20") },
                    { new Guid("440f5863-b80a-444b-9e38-7628b16206a1"), new Guid("6c91262f-793c-4277-8076-2c276d53f655") },
                    { new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321"), new Guid("6c91262f-793c-4277-8076-2c276d53f655") },
                    { new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9"), new Guid("ee9319ee-65bc-4974-b7ba-2a804ef90d83") },
                    { new Guid("57489b88-50a6-412f-8d32-d544805f5eaa"), new Guid("ee9319ee-65bc-4974-b7ba-2a804ef90d83") },
                    { new Guid("38f00b21-23bd-4d5b-9bff-70839859e665"), new Guid("ee9319ee-65bc-4974-b7ba-2a804ef90d83") },
                    { new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f"), new Guid("53f4cdd5-a197-453e-885e-11f84e377b20") },
                    { new Guid("6eaf6240-ff67-4807-838f-df36916e11a9"), new Guid("53f4cdd5-a197-453e-885e-11f84e377b20") },
                    { new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216"), new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4") },
                    { new Guid("5189c11f-749c-4cff-b130-1a7093c9a639"), new Guid("6c91262f-793c-4277-8076-2c276d53f655") },
                    { new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b"), new Guid("394e64d1-de85-47e2-a665-dfb7a1434fd4") }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("387884bb-47c7-4c9a-8149-450fcb1bf4a5"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9"), "Faculty-1" },
                    { new Guid("d486de20-ffea-4d3f-bb71-a7406deb5ed7"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e"), "Faculty-2" },
                    { new Guid("a97da969-4de8-4122-96c9-30460d5242d1"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321"), "Faculty-0" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("ccfc4833-55c4-408a-803a-9db4fc5558c0"), new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"), 0L, new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("ef59c951-cfc9-4d36-b9e8-e6b50b6fed9f"), new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"), 0L, new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("c543ef1b-5823-4801-b131-cbe570618c52"), new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"), 0L, new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("d228099e-5e7a-4d83-9361-dc6624e003e1"), new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"), 0L, new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("8a6a68cb-60b1-40bf-851c-5a9e4c1bf831"), new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"), 0L, new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("9f37e642-d986-49d1-b4b0-0df9eeeccb18"), new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"), 0L, new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("90ed50e4-ac0d-428b-898f-17d83d8adea7"), new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"), 0L, new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("517928c6-6bf3-4b58-8da8-39f84945790b"), new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"), 0L, new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("60c35c56-5ce9-40f7-a6a4-c97be7686345"), new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"), 0L, new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("11857b4b-b0d4-42af-b758-89a803b30f5a"), new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"), 0L, new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("071d25f8-bc97-4dbe-8393-a7d141a8c5d2"), new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"), 0L, new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("246cb8fc-8457-4bce-a5bb-535a71e566b3"), new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"), 0L, new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("00e61e59-a3ec-4194-9084-612a0160fab3"), new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"), 0L, new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("4e47949b-ebed-4de0-9aab-e1e15b4a2fc8"), new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"), 0L, new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("f6f92f2b-7c47-47be-8a22-c0c1341d17c9"), new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"), 0L, new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("31f1b132-c3d6-4a47-9400-27d1782fc14e"), new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"), 0L, new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("effedd84-931a-466a-9ad1-3afcc7161bd8"), new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"), 0L, new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("cb2ecaa3-ef3b-470a-b5b0-88c2ebf2bba7"), new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"), 0L, new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "FacultyId", "Name", "Semesters", "StudyDegreeId", "StudyLineId" },
                values: new object[,]
                {
                    { new Guid("28819f09-20b1-4459-823a-700357ac2fb0"), new Guid("387884bb-47c7-4c9a-8149-450fcb1bf4a5"), "Specialisation-0", (short)2, new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), new Guid("b2793483-354a-4e4f-a12e-1879999ecc80") },
                    { new Guid("9ae3e7e7-f045-4d8f-9f27-bcbbb5cb97a9"), new Guid("387884bb-47c7-4c9a-8149-450fcb1bf4a5"), "Specialisation-1", (short)2, new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), new Guid("b2793483-354a-4e4f-a12e-1879999ecc80") },
                    { new Guid("7ee04521-770f-400c-88a1-8bc31db1600a"), new Guid("387884bb-47c7-4c9a-8149-450fcb1bf4a5"), "Specialisation-3", (short)2, new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), new Guid("b2793483-354a-4e4f-a12e-1879999ecc80") },
                    { new Guid("c49c97c9-60ae-40d0-b49a-f46570b2eadb"), new Guid("d486de20-ffea-4d3f-bb71-a7406deb5ed7"), "Specialisation-4", (short)2, new Guid("1de1e5c4-fe7b-4722-821b-c0a49eeefd44"), new Guid("d804c6b1-1315-41ab-bda8-7ffdb55e4987") },
                    { new Guid("c48d1d0b-eeed-483e-8191-de9b254a5ba2"), new Guid("a97da969-4de8-4122-96c9-30460d5242d1"), "Specialisation-2", (short)2, new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), new Guid("b2793483-354a-4e4f-a12e-1879999ecc80") },
                    { new Guid("82a1756a-fdf6-4404-a940-94b8eff980d0"), new Guid("a97da969-4de8-4122-96c9-30460d5242d1"), "Specialisation-5", (short)2, new Guid("4036b6f0-9282-4cde-b0db-c5248216530f"), new Guid("90341a59-9256-4577-be1f-40f1d5773dad") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "EndDate", "SpecializationId", "StartDate", "StudentLeaderId" },
                values: new object[,]
                {
                    { new Guid("96ddf3f8-85b9-4355-8945-6c4110723088"), 1651230707L, new Guid("28819f09-20b1-4459-823a-700357ac2fb0"), 1619694707L, new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd") },
                    { new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49"), 1651230707L, new Guid("82a1756a-fdf6-4404-a940-94b8eff980d0"), 1619694707L, new Guid("52d2e621-2150-4328-a00c-f1f307038311") },
                    { new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f"), 1588158707L, new Guid("c48d1d0b-eeed-483e-8191-de9b254a5ba2"), 1556536307L, null },
                    { new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6"), 1619694707L, new Guid("c48d1d0b-eeed-483e-8191-de9b254a5ba2"), 1588158707L, null },
                    { new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb"), 1651230707L, new Guid("c48d1d0b-eeed-483e-8191-de9b254a5ba2"), 1619694707L, new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d") },
                    { new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c"), 1588158707L, new Guid("c49c97c9-60ae-40d0-b49a-f46570b2eadb"), 1556536307L, null },
                    { new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325"), 1619694707L, new Guid("c49c97c9-60ae-40d0-b49a-f46570b2eadb"), 1588158707L, null },
                    { new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98"), 1651230707L, new Guid("c49c97c9-60ae-40d0-b49a-f46570b2eadb"), 1619694707L, new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df") },
                    { new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b"), 1588158707L, new Guid("7ee04521-770f-400c-88a1-8bc31db1600a"), 1556536307L, null },
                    { new Guid("80417947-ecb8-4ab6-a4b0-768839065692"), 1619694707L, new Guid("7ee04521-770f-400c-88a1-8bc31db1600a"), 1588158707L, null },
                    { new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37"), 1651230707L, new Guid("7ee04521-770f-400c-88a1-8bc31db1600a"), 1619694707L, new Guid("5a424122-f16b-4bc8-891a-48fe333b6341") },
                    { new Guid("e9215073-62b6-4e45-92cb-7ea3c7e52331"), 1588158707L, new Guid("9ae3e7e7-f045-4d8f-9f27-bcbbb5cb97a9"), 1556536307L, null },
                    { new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c"), 1619694707L, new Guid("9ae3e7e7-f045-4d8f-9f27-bcbbb5cb97a9"), 1588158707L, null },
                    { new Guid("5b752751-101e-4a82-9d4e-d31ced092458"), 1651230707L, new Guid("9ae3e7e7-f045-4d8f-9f27-bcbbb5cb97a9"), 1619694707L, new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1") },
                    { new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198"), 1588158707L, new Guid("28819f09-20b1-4459-823a-700357ac2fb0"), 1556536307L, null },
                    { new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea"), 1619694707L, new Guid("28819f09-20b1-4459-823a-700357ac2fb0"), 1588158707L, null },
                    { new Guid("df814f1d-5034-4c14-a03d-1829821df987"), 1619694707L, new Guid("82a1756a-fdf6-4404-a940-94b8eff980d0"), 1588158707L, null },
                    { new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408"), 1588158707L, new Guid("82a1756a-fdf6-4404-a940-94b8eff980d0"), 1556536307L, null }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("424b0e31-f399-4daa-8b78-67e73f344c20"), new Guid("4ccb50c1-1ee3-4fac-9a30-f6f88d7ea4f6"), 1647781930L, new Guid("41ca9194-441b-485c-9e6e-31a642ca8c12"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("6fddec98-67b2-4776-8f4d-07365765fda6"), new Guid("071d25f8-bc97-4dbe-8393-a7d141a8c5d2"), 1647781930L, new Guid("03a3c074-ae04-4f5c-a6d0-4e4b61820152"), new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("a45e1775-c2ea-430c-9747-71c74d397148"), new Guid("3df85a78-4052-4926-b7bf-5dc6e4bff475"), 1647781930L, new Guid("80ebb18a-e447-4ad4-aa6c-be7e8383a2f6"), new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("cca76e73-0cd5-46ca-8eb1-af3af988b81f"), new Guid("3bdd5d34-6aae-44ae-a212-323359221dbf"), 1647781930L, new Guid("ebe81c59-bf12-4df5-9baa-5af90bf5fef0"), new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("24158d2f-dcd1-46b6-a499-a36f56fcd6de"), new Guid("11857b4b-b0d4-42af-b758-89a803b30f5a"), 1647781930L, new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"), new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("f0c0fb75-5789-490e-8be1-46087dd5f258"), new Guid("00e61e59-a3ec-4194-9084-612a0160fab3"), 1647781930L, new Guid("f27b51b6-95fa-4f4c-8b46-752b8542c51f"), new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c") },
                    { new Guid("a19c3900-d489-4ab0-ac11-16a1cea9b1c1"), new Guid("cbafa8d0-f66e-467f-990b-cd0ad21ae6aa"), 1647781930L, new Guid("625d1d34-7e86-41fe-8eb2-985fe439a6ed"), new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c") },
                    { new Guid("12c8fe84-65b5-4514-a535-d8d2ef478628"), new Guid("e4c37165-7c32-43e2-a0cb-daf869a920e4"), 1647781930L, new Guid("dd90d328-9e3b-42cb-ba19-e1d71ba99b78"), new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c") },
                    { new Guid("0e79c4ab-9073-4844-9412-2ca05e174ccd"), new Guid("ccfc4833-55c4-408a-803a-9db4fc5558c0"), 1647781930L, new Guid("53cbe638-d1e3-410c-a204-1f11f2c7633b"), new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("2f6481f2-2c36-4b31-ae4c-f69a199b8ed5"), new Guid("9f37e642-d986-49d1-b4b0-0df9eeeccb18"), 1647781930L, new Guid("11a6bc52-2db0-477f-a17a-94c878e33f6c"), new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("c78631fe-6b2c-41aa-a7bc-54b1ebbf04ba"), new Guid("e004cf77-e527-4eac-89bd-d0cfc249918a"), 1647781930L, new Guid("98a52ca8-5af2-4dbd-a6fe-be22207349b1"), new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("4acae1fb-b2e6-448b-bf2e-754b8359b11f"), new Guid("c494ceb6-a661-48ca-bc79-dc8932627804"), 1647781930L, new Guid("a66eb85e-b430-4586-8228-5e0f0da8311b"), new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("98aff0cc-37d1-4f3d-8082-92fd1151d4ae"), new Guid("4ba394de-5f78-4bfc-b42d-dd4cd3037db4"), 1647781930L, new Guid("2e8097d2-7564-440c-b954-dd55c04eadcd"), new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("459b1d87-ed54-49a3-85e6-73ddcd2d2c8d"), new Guid("e4c37165-7c32-43e2-a0cb-daf869a920e4"), 1647781930L, new Guid("43936095-8cef-40d0-b61d-069a130596f0"), new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("879b8f2b-3aea-4030-9016-973107c37436"), new Guid("6d364226-b034-445c-a182-34aee0e2fdcd"), 1647781930L, new Guid("362b789c-e8e6-40b4-b590-7f9743cb9856"), new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("43eabc2f-83d0-4b4b-a247-9474782b6204"), new Guid("75819c49-6ffd-469a-b7ed-2c11d72e673c"), 1647781930L, new Guid("b53ccb92-7573-4f5b-852d-15cc3227fb8d"), new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("41dd6b6f-bb98-4c1a-996a-e52ab487f1c1"), new Guid("03c1fc56-8c4c-4895-9cd7-638dd51c1f3e"), 1647781930L, new Guid("033a4dfb-dea0-442b-8f07-efffda3dc66c"), new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("e4982fe7-a40f-48ab-b494-e23ad1898a09"), new Guid("6ce585ac-5513-4089-b668-692f58bdc331"), 1647781930L, new Guid("3e262014-0d7f-4a65-bce6-d93074a8c4dc"), new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("d87b2128-1d53-4a04-81ad-10ee1fe0e3de"), new Guid("ccfc4833-55c4-408a-803a-9db4fc5558c0"), 1647781930L, new Guid("748922e6-fc92-43ec-88b2-3da72ed82b58"), new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("60440151-520e-4b06-ad34-051a1e1c1361"), new Guid("ef59c951-cfc9-4d36-b9e8-e6b50b6fed9f"), 1647781930L, new Guid("10521b95-7b13-4cd8-b47a-19fac79fa145"), new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("0fe5f0e3-7a56-473a-878a-440b1259b413"), new Guid("90ed50e4-ac0d-428b-898f-17d83d8adea7"), 1647781930L, new Guid("f3e44686-53f3-4ce7-8c59-424b2d07e355"), new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("9eb8b8f8-ce19-4116-a31b-371d0331b795"), new Guid("cb2ecaa3-ef3b-470a-b5b0-88c2ebf2bba7"), 1647781930L, new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"), new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6") },
                    { new Guid("a83ae8df-9272-4045-bf39-11cd740600d6"), new Guid("246cb8fc-8457-4bce-a5bb-535a71e566b3"), 1647781930L, new Guid("505e050e-09de-4660-b6e5-fa4769255e4d"), new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6") },
                    { new Guid("6e4a7fd0-8930-4439-a51e-86bf441fa1d1"), new Guid("1306d78e-5b99-4165-bb5b-668cd69aa9ff"), 1647781930L, new Guid("5a424122-f16b-4bc8-891a-48fe333b6341"), new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408") },
                    { new Guid("71eb7a0a-af66-4b30-8f05-c365f5aca593"), new Guid("bcf40ec1-3934-4264-86d2-669db0fa03bf"), 1647781930L, new Guid("c2bc3863-c263-457e-a114-69cc5c94075f"), new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408") },
                    { new Guid("df92f7ea-85a0-4859-98db-147e3514efbd"), new Guid("90ed50e4-ac0d-428b-898f-17d83d8adea7"), 1647781930L, new Guid("a086d6f7-a8ca-4dd9-8cd4-28e1c67e96dd"), new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408") },
                    { new Guid("ec247867-d7c8-49e8-b3ea-4a5914efc421"), new Guid("82a89abb-487f-426a-80a7-d746fc712c46"), 1647781930L, new Guid("756beb15-3436-4d3d-8da1-afc43da58f77"), new Guid("df814f1d-5034-4c14-a03d-1829821df987") },
                    { new Guid("36bed085-d8e0-40a1-96d6-dc457b5d1001"), new Guid("c59a0945-ec6f-4860-b1da-4be977ed624f"), 1647781930L, new Guid("5209cacf-4f7c-4a88-9f1d-95ca8af3b052"), new Guid("df814f1d-5034-4c14-a03d-1829821df987") },
                    { new Guid("1309887b-c1d0-4a34-8f8a-0e1da18143d9"), new Guid("5d603485-ac47-4093-a73a-83a7593022a7"), 1647781930L, new Guid("26b2208c-2ea6-4389-b212-83583bf6dcc9"), new Guid("df814f1d-5034-4c14-a03d-1829821df987") },
                    { new Guid("e26bc60a-c128-41d8-b129-e6947c12f9de"), new Guid("d228099e-5e7a-4d83-9361-dc6624e003e1"), 1647781930L, new Guid("b02c2a20-c85f-42e3-8edd-68cb3fe4e84e"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("5c5e8638-ad78-4ea0-bd8f-224c7aa9a585"), new Guid("8a6a68cb-60b1-40bf-851c-5a9e4c1bf831"), 1647781930L, new Guid("c71686c6-741c-4929-84c0-66cbb9f5a73a"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("7acfeb68-06a0-4037-bd7e-641f997e90b9"), new Guid("8e23c49c-6374-4981-8905-fd55ee39d6df"), 1647781930L, new Guid("5e1879dd-aeb7-4de5-aa0f-4d725fe917fa"), new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6") },
                    { new Guid("81c1218f-1831-4bc9-aec8-d3024869af24"), new Guid("85f52f4b-149a-492c-ab15-b317a51c9fab"), 1647781930L, new Guid("143d4a0f-5138-4091-9e9a-8f3432f5a527"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("306123c2-78da-4181-af82-29bf6af4ac29"), new Guid("b0451579-06e1-4124-bf68-d48bb1d20237"), 1647781930L, new Guid("a3702ac3-d8e6-479e-ad3d-90371c448e32"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("4d296d04-1d3f-40d5-9e86-c437f8bd3626"), new Guid("effedd84-931a-466a-9ad1-3afcc7161bd8"), 1647781930L, new Guid("b08456ce-23d2-474d-bf65-0688076d83dd"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("3cd3d43d-8afa-4d3d-95d3-05f3fccfe791"), new Guid("4ba394de-5f78-4bfc-b42d-dd4cd3037db4"), 1647781930L, new Guid("03bb9ca9-ae28-48a0-af2d-2177898b3706"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("dbfaca60-184c-40a2-8dc3-7b8c9da7c4a6"), new Guid("8a6a68cb-60b1-40bf-851c-5a9e4c1bf831"), 1647781930L, new Guid("ae16bb0e-76b1-45ed-bf72-61ae86ad4b77"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("aa9109b5-fdd9-4646-bbfa-4db8e81eff66"), new Guid("f19c9c3a-00c0-4503-a906-4258efc04b17"), 1647781930L, new Guid("7a286bfb-2317-41be-a927-3543eb6b675c"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("dc062aaf-6c2e-43ea-a8ab-1d89141d2d7c"), new Guid("3df85a78-4052-4926-b7bf-5dc6e4bff475"), 1647781930L, new Guid("dc33adb6-52b6-4a9e-9401-66a305c9ab69"), new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f") },
                    { new Guid("058f7b77-9016-4fbc-9923-e2472df222e6"), new Guid("4e47949b-ebed-4de0-9aab-e1e15b4a2fc8"), 1647781930L, new Guid("ad5c6c97-3c62-4752-b2c9-b4b8141e3dab"), new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f") },
                    { new Guid("fcdc9766-0850-49e8-a071-57dae539189b"), new Guid("8e23c49c-6374-4981-8905-fd55ee39d6df"), 1647781930L, new Guid("2265a5ee-c06d-4ce7-a6e3-61971bb97b7e"), new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f") },
                    { new Guid("2fc0a867-8e8d-4c03-874e-376781a71a70"), new Guid("b6731905-4a7d-4523-9ab8-ef1400249ebe"), 1647781930L, new Guid("1d142e90-6fc0-42ce-a83e-7dfaf00c971d"), new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("937287e7-3f4c-4b14-85f5-b194ba1b874c"), new Guid("f7532d6b-bf41-4d53-b450-4b4fdb10efb0"), 1647781930L, new Guid("005fcf54-4ac3-4794-80e9-d9e7831c05ec"), new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("64508853-851a-4e82-b716-f0619776e8eb"), new Guid("246cb8fc-8457-4bce-a5bb-535a71e566b3"), 1647781930L, new Guid("276dd141-eee9-44a2-8f97-41decc40381e"), new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("f2571fe8-976a-42b3-9cfe-bddbecc64f50"), new Guid("d6b4fa4a-2c33-48b7-95d6-b8662804dad1"), 1647781930L, new Guid("9ac3aac0-5341-4389-8153-c98bbb803cc8"), new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("82955a35-120f-4cb5-953c-cd7f5a1781b5"), new Guid("00e61e59-a3ec-4194-9084-612a0160fab3"), 1647781930L, new Guid("a637ae33-eaf6-4d29-9268-c9d8342470df"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("76681c28-da58-4882-b36a-b44bb3cdddb8"), new Guid("c11b837c-ddae-41f4-bf49-ace5e4ad517b"), 1647781930L, new Guid("d06ceafc-9239-42d5-82bc-e7296c2ba167"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("69987b31-f1eb-40d5-84af-2f84dca00902"), new Guid("60c35c56-5ce9-40f7-a6a4-c97be7686345"), 1647781930L, new Guid("f639491f-f34e-4036-b0f2-34a5c8e9f26d"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("311ad7ba-207c-45a9-9ca1-80020d669643"), new Guid("66c061f7-ec5b-431a-b4b2-fcdd26640233"), 1647781930L, new Guid("c148479c-48ff-4120-94f2-baa33b6e8a09"), new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("b22c935b-41cc-4340-af72-6d46d0d34097"), new Guid("31f1b132-c3d6-4a47-9400-27d1782fc14e"), 1647781930L, new Guid("510b4925-7fc0-4de0-8921-a1756faab7c1"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("72c168ec-4c85-4e8f-b0bc-606896311f8c"), new Guid("517928c6-6bf3-4b58-8da8-39f84945790b"), 1647781930L, new Guid("41de7aa6-3e5f-47bf-88ba-37030de4231b"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("94e52d54-7818-4b48-b022-dc7bf26510c1"), new Guid("f19c9c3a-00c0-4503-a906-4258efc04b17"), 1647781930L, new Guid("2ab2d979-c7b4-4a20-8e09-3ce15afa7a6f"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("47d94e98-8b3b-43f7-9a3e-b4f627586965"), new Guid("da1944e4-839d-41a3-b64d-d78f24bd89c1"), 1647781930L, new Guid("bcaf902c-5d29-4b87-b01b-2b3f5b6c0473"), new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("d32d85df-ec83-4516-99c3-1633e0ee5d9f"), new Guid("da1944e4-839d-41a3-b64d-d78f24bd89c1"), 1647781930L, new Guid("e08c079e-2af4-4aba-824a-e8645fe0f06f"), new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198") },
                    { new Guid("bf5f9c60-6dbc-4b94-8b85-c35b22e56d4d"), new Guid("b79a7445-1d91-4472-a333-793fd3289b3d"), 1647781930L, new Guid("0247aec9-5de6-4a79-a805-1b4a598945ba"), new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("3a78c15c-098c-42f7-b503-3825c55ec9fa"), new Guid("d228099e-5e7a-4d83-9361-dc6624e003e1"), 1647781930L, new Guid("07dfc2c5-ff08-4ca2-9d75-ac2400f718e7"), new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c") },
                    { new Guid("fcff2ae5-a6bc-4ab7-adae-5d8aeaa75a17"), new Guid("3bdd5d34-6aae-44ae-a212-323359221dbf"), 1647781930L, new Guid("479e5195-5d9f-45f9-953c-5417315cdd48"), new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c") },
                    { new Guid("b069a1b6-9140-43c3-88a1-58c35dd5656d"), new Guid("07a97332-9348-4d3d-9d9b-09f9701393c9"), 1647781930L, new Guid("abebab04-e1f0-444a-a09d-b1c1c70b9ce2"), new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("2a6ce067-cff5-4e0b-ac5e-96429a656939"), new Guid("4dd55ace-37f5-4e3d-8f13-e44307725447"), 1647781930L, new Guid("e283577f-d734-401b-89b3-cf0e6a026e0f"), new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198") },
                    { new Guid("ab380a64-9c74-47a0-b5b3-3c22d65880cf"), new Guid("5b05cf34-933f-444f-932c-116da17e0931"), 1647781930L, new Guid("78f93bcc-d1ab-4f22-8055-d6096634b45c"), new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("aa851e05-52b0-4eb9-a2b4-d5b95e21e99b"), new Guid("a5d19899-24a3-439e-aef6-0d52f99360ab"), 1647781930L, new Guid("fdb4e33f-9d37-438c-af39-ff0516c2d8db"), new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("ad948c25-d5bb-4134-97aa-62a6b1b7df26"), new Guid("11857b4b-b0d4-42af-b758-89a803b30f5a"), 1647781930L, new Guid("d9db07d2-23b5-4d75-8e14-21733126d60e"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("762bc1e6-167e-41c4-baf1-aa3073f53ba1"), new Guid("c543ef1b-5823-4801-b131-cbe570618c52"), 1647781930L, new Guid("e7b5f652-f44f-467e-935d-78bd2de865c4"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("ad516f4a-42d4-4945-b2a9-d3ad223ca5bc"), new Guid("b7224856-e3c7-4071-a9fa-41410ed466b0"), 1647781930L, new Guid("52d2e621-2150-4328-a00c-f1f307038311"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("5734a0f7-dbd7-4d56-8a86-df532b9fc7e5"), new Guid("5b05cf34-933f-444f-932c-116da17e0931"), 1647781930L, new Guid("7942c487-3bbf-439b-ab22-dc3f0bce4cc2"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("e7825f20-a3c6-46df-b361-3c6c22d4057a"), new Guid("e004cf77-e527-4eac-89bd-d0cfc249918a"), 1647781930L, new Guid("93a27655-a27a-4fc1-83ce-4bfe7870584e"), new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37") },
                    { new Guid("bc85d273-b676-4b58-b5ef-295db7d61139"), new Guid("f6f92f2b-7c47-47be-8a22-c0c1341d17c9"), 1647781930L, new Guid("6e8ad44e-d46b-4f50-beee-0562f82288a9"), new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37") },
                    { new Guid("0fd9bf3c-814c-448f-8fc9-4c20f7a536f0"), new Guid("1306d78e-5b99-4165-bb5b-668cd69aa9ff"), 1647781930L, new Guid("cb8878dd-25c6-4edc-bf11-28f061797d43"), new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("3847944c-33e9-422b-bab1-46936bfdab2f"), new Guid("56e6e584-63c7-45c0-988a-b7869b0d30e7"), 1647781930L, new Guid("546c8df8-19bf-4426-b52b-4f7bd986f23d"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("57ff0870-a2dd-4fed-a2d4-9bf294fbaf6d"), new Guid("cb2ecaa3-ef3b-470a-b5b0-88c2ebf2bba7"), 1647781930L, new Guid("c157cb2c-9b1f-4ee2-8bb5-0919d1802622"), new Guid("e9215073-62b6-4e45-92cb-7ea3c7e52331") },
                    { new Guid("e29ff599-a1f2-4270-b46c-d8194cf2614e"), new Guid("365518ec-babb-4ef8-ae51-807dbd4e23d5"), 1647781930L, new Guid("13f231f6-e8ec-43d9-a052-844ee9041034"), new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("d9fc7dd9-fa4e-4b4c-86f7-7d34cd27a1d3"), new Guid("9b590f67-1d06-4221-83f6-8e48d5d88e74"), 1647781930L, new Guid("3818589e-f6d5-40be-a49b-cd0cb6be89f0"), new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), (short)1, new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f") },
                    { new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), (short)2, new Guid("0972c4d7-ee20-4b89-a225-b05eb876236f") },
                    { new Guid("c5697871-d83a-4001-acd9-cff38366f366"), (short)2, new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), (short)1, new Guid("df814f1d-5034-4c14-a03d-1829821df987") },
                    { new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), (short)2, new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), (short)1, new Guid("26147f69-c7ac-4b76-b0c4-95c2fa2b01ea") },
                    { new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), (short)2, new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), (short)1, new Guid("daeb8d76-9580-4155-97fd-f0a75e28cf49") },
                    { new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), (short)1, new Guid("96ddf3f8-85b9-4355-8945-6c4110723088") },
                    { new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), (short)2, new Guid("df814f1d-5034-4c14-a03d-1829821df987") },
                    { new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), (short)1, new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198") },
                    { new Guid("cf42925a-34eb-4464-897d-48396f722e88"), (short)1, new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), (short)2, new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6") },
                    { new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), (short)1, new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), (short)2, new Guid("80417947-ecb8-4ab6-a4b0-768839065692") },
                    { new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), (short)2, new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37") },
                    { new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), (short)1, new Guid("b87ef94c-34fb-4591-b139-0ae21b517e37") },
                    { new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), (short)1, new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), (short)2, new Guid("6016fe33-c9e3-4674-b62f-c352f737da9b") },
                    { new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), (short)1, new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408") },
                    { new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), (short)2, new Guid("e9215073-62b6-4e45-92cb-7ea3c7e52331") },
                    { new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), (short)1, new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), (short)2, new Guid("289342d2-5ba3-4bf0-ba4d-041e96ef7d98") },
                    { new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), (short)1, new Guid("e9215073-62b6-4e45-92cb-7ea3c7e52331") },
                    { new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), (short)2, new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c") },
                    { new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), (short)1, new Guid("fd2d4224-460d-44c4-ac98-99a4da17b22c") },
                    { new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), (short)1, new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), (short)2, new Guid("f9d676c8-305e-4de0-9ced-b5e14fd2f325") },
                    { new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), (short)2, new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), (short)1, new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c") },
                    { new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), (short)2, new Guid("59dcfa09-ac7e-4483-8fb1-12b366f1276c") },
                    { new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), (short)1, new Guid("5b752751-101e-4a82-9d4e-d31ced092458") },
                    { new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), (short)2, new Guid("298ffd6e-5931-465d-bda3-98d5a069d6cb") },
                    { new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), (short)1, new Guid("a79ec08a-fbd9-4ae6-9ada-784e39c195e6") },
                    { new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), (short)2, new Guid("d83e69b7-e0f1-4b72-a36f-fdaa584d0198") },
                    { new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), (short)2, new Guid("a3273c4d-1ddc-46d7-8e29-e17aa5742408") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("16a1e99f-921d-4a51-b214-18e12ab16dd6"), (short)4, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("c1668a6f-3947-425b-afcb-1b890bd71570"), (short)4, "Course62", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("17ab6360-ed7d-4f08-9470-a714909d9b8d"), (short)1, "Course0", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("df9e6c12-193c-4fe0-b3a0-9fcb080e6bae"), (short)2, "Course24", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("2199e07d-b072-4adb-aacd-f2ac846ae6be"), (short)5, "Course48", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("9b5f5711-ddc4-4d2e-ac93-456846e2cc3e"), (short)5, "Course72", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("678d6cd1-78d8-418e-9284-642514aa39c6"), (short)4, "Course96", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("26531397-c9d5-45cf-85a9-e87c59242590"), (short)4, "Course120", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("b9435182-dcc9-4dc3-9bdb-8361b644e4a3"), (short)2, "Course31", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("04c3ac48-025b-42db-9cee-12a0fcf8c00a"), (short)0, "Course0", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("a57eebcb-eac2-430f-8e84-3d5f8a3ed8f2"), (short)5, "Course0", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("4ce0e911-9be3-465c-8ba6-7505a5d6e9f0"), (short)0, "Course25", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("6c135def-f576-43b9-acd1-4a6d82e18477"), (short)0, "Course50", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("9d524a19-8d74-408a-9818-9b7e52b4155f"), (short)0, "Course75", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("00a89520-0eae-4a19-a5fa-3ad9503dfb0e"), (short)0, "Course100", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("d1640f6a-e7e0-4b73-aea7-1bc3a69aaf0e"), (short)1, "Course125", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("b5b734c2-6a20-4523-bccf-88d6a1ee978d"), (short)5, "Course0", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("88bc7ec9-d1cb-46e4-93e5-e597341c2797"), (short)3, "Course26", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("115b34f9-d008-4ae5-a15e-de46de593da7"), (short)3, "Course52", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("4049d820-85b0-4a52-8073-9e97ad597fd4"), (short)3, "Course78", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("b317f7a9-908f-4602-a661-1dc5de93ebe7"), (short)1, "Course104", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("6e31023f-db11-4558-a2da-7b118be441a8"), (short)3, "Course130", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("cda2ad7f-327c-41c0-9e47-340fef9808ed"), (short)0, "Course150", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("f00e07f1-2a58-4d12-8048-1d84db730374"), (short)1, "Course120", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("82e80581-424b-4090-bc7c-a00a5e436626"), (short)4, "Course93", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("579ee61f-ecb8-4613-8d98-f00f79c1747c"), (short)1, "Course115", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("3ae10080-a684-4c4d-a4db-324e7bebf2e2"), (short)0, "Course92", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("e0090a2f-734c-419f-9c26-df7f4e13f969"), (short)1, "Course69", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("e3aa8c9d-6dd4-4510-ab34-18ac3f52e10d"), (short)0, "Course20", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("1b631419-fe61-4399-ac84-83c2e24537ef"), (short)5, "Course64", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("b3cdd346-7520-4fe6-97bd-0ddedc6cfb75"), (short)4, "Course60", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("5a093f4e-b49b-43b7-bee2-c88ff07398a0"), (short)0, "Course80", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("a113e381-7bae-48a2-9335-d2ef45baad15"), (short)5, "Course100", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("b741eb8e-d97c-41a1-a55f-fd8995a04a98"), (short)3, "Course32", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("6b664f78-4d98-4a8f-80fb-6ab2530c0f3a"), (short)5, "Course0", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("231a15e4-56f8-4a58-bd40-b50d439f8031"), (short)5, "Course0", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("0bdf9168-59da-4a54-b5e3-0327189a3361"), (short)3, "Course21", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("5bec8e82-d5c7-418e-8f42-d37996fdf88f"), (short)2, "Course42", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("c6c22296-e6c1-4747-9734-ddbb51e33db9"), (short)0, "Course63", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("63696fff-8204-42c5-8fb6-dc752c3ed8b5"), (short)2, "Course0", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("fc0a99f3-651e-4428-b253-89d65e7b3424"), (short)1, "Course84", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("5b3db105-30ea-4660-9636-0ea4a2320afa"), (short)4, "Course0", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("15db5459-dcc6-4286-b48e-1c37a80f04e4"), (short)0, "Course22", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("6cb7cd42-ce68-40a9-98a7-3895aad3ccff"), (short)4, "Course44", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("409c1596-fed1-476f-9e7e-4fbb2e183345"), (short)0, "Course66", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("676b130b-4c1d-4e4c-95e0-38ad629edbea"), (short)4, "Course88", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("50172451-8c71-432f-a03b-ff8b4dbe6de0"), (short)3, "Course110", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("ae71268a-a8ec-44cd-b90b-20451abdebd9"), (short)1, "Course155", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("94490873-8102-4582-9131-32242ec3c0d4"), (short)3, "Course124", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("6f15bcbd-ce80-42ec-9b17-d68f6f1d15d0"), (short)0, "Course0", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("b172c7c7-c9e9-48a4-a74f-cb376290878f"), (short)5, "Course23", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("b2fe6b67-85db-44e2-ac30-8d55208e4599"), (short)1, "Course46", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("0734ee8a-f38b-442a-9c4b-55a2af47baa9"), (short)4, "Course105", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("c36e435c-2c90-4c12-a17a-b3b9df735361"), (short)2, "Course27", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("10e9ba43-6bfd-4aa6-a18f-58ba2c76510f"), (short)4, "Course54", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("3cade404-1f59-418b-b72f-18053b73fd84"), (short)0, "Course81", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("c3474b39-1eb8-44b9-b44f-574ab8acca8e"), (short)3, "Course26", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("06d62245-1ffd-4355-991e-2a460df8de72"), (short)0, "Course39", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("790740a3-c587-4ced-b1e0-afc519aac0a4"), (short)2, "Course52", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("3b3d3b6a-5a44-4e4f-8a0a-b00e992eff51"), (short)2, "Course65", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("4a7717dc-023c-4e63-9a1d-3a997a5f743e"), (short)5, "Course51", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("783dfc32-b826-44f3-8a88-fef7f1ddc3d5"), (short)0, "Course34", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("fd26c183-d5b4-4fa4-88a8-ddfbb8ad6bc6"), (short)4, "Course0", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("def4a2c6-7314-4eb1-8dbe-5132ebc99dc6"), (short)4, "Course14", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("23250ce8-54fc-42e6-972a-28e621b4acb5"), (short)3, "Course28", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("ed1c6a6b-0986-49b2-8d50-8e01f0698eca"), (short)5, "Course42", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("d30f75a7-b77a-4d50-b602-09d39db60d0a"), (short)1, "Course56", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("0ea15c1b-0b76-4bde-a305-c343333cfbd0"), (short)5, "Course13", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("3cd3139c-f7c2-41ab-8268-cfcfa1658968"), (short)3, "Course70", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("2afc8fbd-2a43-4c0e-8785-2c01369914a0"), (short)3, "Course0", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("a294b92d-9eb1-459e-ae2a-7fc4d2358290"), (short)5, "Course0", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("4f0b1585-6ae3-4564-8170-7428e7878c13"), (short)4, "Course15", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("5fc3dcfc-a1dd-4fa7-a725-e361c354db42"), (short)1, "Course30", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("f6a8cd89-9946-408c-a807-cae07ea974f7"), (short)5, "Course45", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("a05baa15-84c3-4549-9fa7-04ac4fdb0507"), (short)4, "Course60", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("502e248a-854d-4f70-8175-0054898b9822"), (short)2, "Course75", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("a4f4099c-964d-425a-8d82-25aef5b4d15e"), (short)1, "Course0", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("7c293d52-6633-4aab-a5d8-c92774c16e40"), (short)1, "Course16", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("7756f456-4e8a-4bf6-9eaa-25425bdfba68"), (short)2, "Course32", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("868aed83-6ccd-4b95-8b3c-8ce325d96251"), (short)3, "Course48", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("35a04558-b7ab-4153-8433-07e2c662f59f"), (short)5, "Course17", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("14a2fc7e-1e04-4f87-bf00-3ed591f8e91c"), (short)0, "Course0", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("ddbc819b-16e5-4388-aab0-be754fc87520"), (short)0, "Course0", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("1ccc402f-4fa5-4ea7-9cea-f436fd7e38b0"), (short)2, "Course85", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("fb6c8d5c-3574-47c4-ae3e-911c052f4603"), (short)1, "Course108", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("6254e9f3-65e0-4456-bf94-02fdd1e856a3"), (short)2, "Course135", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("5a6fe4e1-3ad7-4187-8eaa-dd9b697bfdcf"), (short)5, "Course90", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("a998c7ba-279a-429f-bfbb-212161e31b9f"), (short)3, "Course60", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("7c9e1b62-6060-44bc-9697-18770fb3980a"), (short)4, "Course0", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("aa77d0fd-0fe8-4ded-8f7e-26c1a7853dca"), (short)1, "Course28", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("be160f1d-3e14-4881-aef0-cb96861068fa"), (short)1, "Course56", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("597f12c6-13d0-46cf-a99c-5c82780bc829"), (short)4, "Course84", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("932d303e-b8ef-4aeb-a0f0-92925288b231"), (short)5, "Course112", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("81d7a2df-7236-4379-8e28-07fe120d5e06"), (short)4, "Course140", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("4fd8d72c-5ad9-4e45-a2df-c20b8af57914"), (short)5, "Course30", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("d00e7538-9a39-473f-bdba-8b1922f79d1b"), (short)5, "Course68", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("9af25062-cec8-4200-93ca-e32544af9443"), (short)0, "Course0", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("917fb519-e58c-44f3-aad7-02de33796f33"), (short)4, "Course29", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("297fb969-58bd-481d-909b-cbcaae73d48f"), (short)5, "Course58", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("97f3cfd2-b244-4f1b-a670-7a40cbc5d5fc"), (short)5, "Course87", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("d7c35116-05e0-409c-8144-5f0a73d1a6ec"), (short)4, "Course116", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("cf54d312-ef91-4c5e-810f-9fe0514b9709"), (short)5, "Course145", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("b389609d-f996-4f3d-91da-a0b371bbd1e8"), (short)5, "Course0", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("5ecaf884-4f4a-4e8b-b099-1082dfcdb7ad"), (short)2, "Course12", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("00da3686-7dbb-44c3-8891-89266dd87280"), (short)0, "Course24", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("00f427f3-b319-4f99-9b59-94886f890a1c"), (short)0, "Course36", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("31657031-dee9-46e1-b7a0-3ec3112e2cb6"), (short)3, "Course48", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("322a6185-1737-4aaf-ad21-e3f47f128255"), (short)3, "Course60", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("56d5a9bf-61f1-4df8-bb81-b38bd46372a2"), (short)0, "Course0", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("0d157fb0-a465-4cd2-9282-4b57ef03d74a"), (short)2, "Course64", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("372deb35-8da6-4414-9525-da8a77a2c152"), (short)3, "Course40", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("99323478-a136-417a-84c7-94f59c27d5f1"), (short)0, "Course95", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("9d6aefec-348f-4c0f-b874-0a7788bc7981"), (short)3, "Course0", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("42973089-a0e9-4238-870c-2ab323893641"), (short)5, "Course4", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("11be2c71-487c-408c-805f-cc993368d481"), (short)5, "Course8", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("85fd1f80-8fad-4aad-8271-3a713635acda"), (short)4, "Course12", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("bc08f3b4-0610-4709-b7ab-c79c34b121c1"), (short)5, "Course16", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("238ffbed-191d-43f1-a260-3ed2200c6bf7"), (short)0, "Course20", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("419c4517-e63f-4eaf-8765-746758f3c3d0"), (short)3, "Course170", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("62f78b68-bd77-4ca2-8d7e-6269ff84f0ab"), (short)3, "Course136", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("be366a91-fd04-4a27-b5df-62ac1b4001cd"), (short)4, "Course0", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("65975ecb-6a2b-4158-99a9-6b184228f6c2"), (short)4, "Course5", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("e5e5501f-1d04-4519-8e34-c0aa9478d828"), (short)0, "Course10", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("6ad11b7a-4789-4f3d-a4fb-a3862722b572"), (short)4, "Course15", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("e1f88efb-351d-4a89-8f24-92c72499212a"), (short)1, "Course15", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("f07ed86d-2d91-4422-bb89-ce2a6c36681d"), (short)4, "Course25", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("8902eaad-7692-482f-9d69-0d9f42522867"), (short)3, "Course102", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("98203cba-e8ac-4bb8-9e81-477762e52983"), (short)4, "Course68", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("c6ff74bc-1c0a-424e-9222-89fece5582f8"), (short)0, "Course0", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("e4a49f74-5e84-40d2-bdf2-4ac32b90e82c"), (short)1, "Course6", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("669e6f79-10dd-444d-996e-1c72dc0c2b4a"), (short)4, "Course12", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("dfba21a5-0fab-42dd-b62f-5432831c10b5"), (short)3, "Course18", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("05061ffc-17c7-4454-abe2-5affa6620e63"), (short)3, "Course24", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("309dd1d1-e5da-4434-980a-a3eb866343b4"), (short)2, "Course30", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("1d2a61d3-ed6d-4a6f-97bd-36d297d2fb7c"), (short)0, "Course96", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("ef08a75c-b669-4baf-81a8-e807ccd27b8d"), (short)0, "Course0", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("a3e991ef-78e2-44eb-a98d-33df64232cb3"), (short)1, "Course20", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("c10c9999-ae6d-4e8a-99d3-cf9d6d6b0c14"), (short)2, "Course12", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("1b2acee4-6cfb-42b3-b8bf-ad41fcacbc07"), (short)4, "Course9", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("6c582b7e-ce6d-42b5-915c-afa1612c1a35"), (short)0, "Course6", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("ed6f97cc-5e8a-4ba8-8763-8d499aa7310f"), (short)1, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("4eaffed0-4a9a-4ee8-bda4-dc88d4cf1c2a"), (short)0, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("bde3c9c6-040e-4e3b-a193-6930e4b33687"), (short)4, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("711f3fc5-5032-4cb1-a7e3-d86e37360f17"), (short)2, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("7cbcf72c-fefa-488f-a84c-64d77dade7e6"), (short)2, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("b2573ca7-2ae4-40b9-88bf-2ece9edbb71b"), (short)3, "Course175", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("18628480-9303-4645-b29e-d0afe273392a"), (short)2, "Course140", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("32a14724-f7d2-4444-a23a-615371e4ccab"), (short)2, "Course0", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("4e690a30-72d7-4387-87d8-0ed7cf443bed"), (short)5, "Course1", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("f243096a-2100-431c-8542-d7f36f515582"), (short)2, "Course2", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("bb839bdf-c83b-47e6-aabf-ee14f8b68a1a"), (short)0, "Course3", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("b0ec916a-851a-446a-874e-3f464398ce8b"), (short)2, "Course4", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("9d10e05c-59da-4b44-bef5-6ab022259628"), (short)0, "Course5", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("ab166d6b-1c70-4b1e-9165-f4d145069c24"), (short)4, "Course105", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("56d2815e-1d8a-49c4-b21e-b6974cc3d9ab"), (short)3, "Course70", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("60571ccf-f23d-4cea-bbe7-d021b361c433"), (short)0, "Course0", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("4084f658-c34f-4e6f-b78e-37190f0736d3"), (short)1, "Course2", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("7480d127-c2a6-4360-afd1-fc3fa9373dae"), (short)4, "Course4", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("a45fa7c4-8cdc-4031-afe6-48865d29d774"), (short)1, "Course6", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("195da3d5-3b15-480c-9ab4-2ab80fc8982a"), (short)5, "Course8", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("fccb59d5-bf08-4406-b0d6-44174f48d4f5"), (short)2, "Course10", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("b09c1eee-3c9c-43af-a5a3-e0abe00a7380"), (short)4, "Course35", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("1c2b4397-2dc9-40f9-9fa5-d5ee4bd07ac1"), (short)2, "Course0", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("cae24c24-945c-40b6-a865-b03b7187a47a"), (short)1, "Course0", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("de38d731-2fe3-448a-83b2-a50438bda3ba"), (short)3, "Course3", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("30efe5e9-6c13-4a69-ada3-5307a5c16975"), (short)2, "Course0", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("b736b57b-050e-412b-948d-23a01505de9c"), (short)1, "Course7", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("4218a945-83d8-402f-bc82-f41cc19193d6"), (short)2, "Course34", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("afd32e3a-3be3-47cf-b0f6-8d50e1ba8532"), (short)1, "Course21", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("40fdf53f-1e6f-4bf0-be73-83ed4094b8cb"), (short)1, "Course40", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("50b86949-9281-4dce-812a-2c956c11571b"), (short)5, "Course50", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("1c860cc5-feb9-4420-b759-04467018e371"), (short)5, "Course33", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("cbfb19cd-0be1-4cf0-a1d6-69be4072b468"), (short)1, "Course0", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("d1e633e3-c14b-4e04-b6ab-e691746b9cf0"), (short)5, "Course0", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("2845c36c-cf7d-474a-9658-2582222cf334"), (short)0, "Course11", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("36acc87e-4081-4a50-bb67-a130aa042719"), (short)0, "Course22", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("32daeb1e-a3cf-415b-828f-edbc17605f1a"), (short)3, "Course33", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("adf66d35-31a4-4c9b-b591-9eb839ad248d"), (short)1, "Course44", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("003cbd81-eb57-43a8-a272-95bd8cda634b"), (short)5, "Course55", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("4ae104bb-e5d0-4160-92a7-87124ed4c41b"), (short)5, "Course0", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("5314969a-8c1f-4f74-81f4-d0925a3d3d7f"), (short)1, "Course18", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("8b8a0b12-9a92-410b-8de1-6e74c1430c8c"), (short)1, "Course36", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("eb17901c-de0c-44d5-9564-67120ffdd24a"), (short)1, "Course54", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("39ab7a2d-c013-4028-af95-db57c85bcdbc"), (short)0, "Course72", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("a9df57dd-4df3-4271-91f8-73532094dc4a"), (short)1, "Course90", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("922df74f-5bdc-434e-8756-deb48fe66fff"), (short)0, "Course160", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("2645a9dd-4807-4ae2-bac0-e5b5bae0fdb0"), (short)1, "Course128", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("0c6aa87e-5986-4d32-adcf-6a5106c5ae54"), (short)2, "Course0", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("d2703c36-2aa4-4fe8-89aa-becea6d4ad72"), (short)2, "Course19", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("d943cb59-2ebd-4aed-83ad-49bc0bb7db85"), (short)4, "Course38", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("5744e6b5-b901-4e15-870a-b796b3b5237b"), (short)4, "Course57", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("41ec28a7-c84f-438e-95bf-8dac21e3fc56"), (short)5, "Course76", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("f4065884-5011-451a-8b20-1038f495dd4d"), (short)0, "Course14", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("7bfddbbe-a857-4905-9ffe-b8ea4f528cde"), (short)2, "Course20", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("a2d5c7aa-6caf-46f3-906c-761517358022"), (short)0, "Course30", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("06cd2053-6b61-4574-9b3f-02e84d2be001"), (short)4, "Course80", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("38b254b6-f105-4f20-b1eb-4ef81794d70a"), (short)1, "Course16", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("3ff268d2-4fdd-4b51-bd87-987e5a7359f2"), (short)1, "Course24", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("91e34759-e455-4499-885f-250d4fd637ed"), (short)5, "Course32", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("13c2e56f-955a-43ea-a12a-098e475ce467"), (short)1, "Course40", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("50db75df-074d-4c6f-9cf6-4e7fade628e9"), (short)2, "Course165", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("d53620a2-77e8-43b6-8ff2-294f4a69c2da"), (short)3, "Course10", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("a6fbca19-c748-4bf9-a135-b7b69b4a2dc4"), (short)4, "Course132", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("a38ce738-4778-4040-bfe3-ac895bc62f39"), (short)1, "Course8", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("9098c9e1-b013-4fef-a6db-59ae446f9bc0"), (short)2, "Course9", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("108715c1-1ac1-4af8-8cb9-ad0406b3d183"), (short)0, "Course0", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("71ee15a8-160d-434a-9d1f-0d391ba80e10"), (short)5, "Course27", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("7a6a7c08-82aa-4e49-a052-8abac366e870"), (short)3, "Course36", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("dfd57181-9352-4735-83a9-6dede198f65e"), (short)4, "Course45", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("a20fea42-4b30-4a41-a8e6-0ad0c716d0eb"), (short)0, "Course99", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("63e342c4-18d2-43da-b16d-31e65369eb17"), (short)2, "Course35", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("2c806e60-6864-41dd-8d8b-c1362ed962ba"), (short)4, "Course66", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("64dd9b8d-1118-4099-8d44-b4e0c5c22f6a"), (short)1, "Course0", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("4cb2fcf7-e095-46e9-8cc3-107bdb45558d"), (short)2, "Course28", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("816e6d30-6aaa-464b-b563-ea0b62ee2ce8"), (short)2, "Course18", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("58e115b1-e08d-45a7-a86d-e49a95b66178"), (short)4, "Course0", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("d0a4980a-5ec2-4689-9c08-62c11678b455"), (short)2, 20, "Course0", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("92ed978b-b5d6-487d-a7ec-c6e63af5eddb"), (short)3, 20, "Course0", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("af676845-0fb7-4cab-837a-04737f8d6ade"), (short)2, 20, "Course16", new Guid("0587a66a-1655-4766-bda6-ce5c600676b4"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("606627ff-bffb-45cc-a5f5-8c1480f8d9ef"), (short)1, 20, "Course33", new Guid("2b72003c-969c-4040-aa3e-9d8dc7bad15e"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("64c7a590-8643-481d-b5aa-88818420dc81"), (short)5, 20, "Course0", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("3e97b9ca-8874-416b-b15c-7d88ee620ecf"), (short)5, 20, "Course30", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("eaad80ae-3360-4b20-b687-49888015d558"), (short)0, 20, "Course31", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("76c9acc1-752d-4bc9-9aa0-49d1dfab5b15"), (short)2, 20, "Course0", new Guid("393556aa-f97e-4af2-9b8c-9dd0aa5319df"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("140d3738-4ab9-4b28-b8c0-6db4ae79c082"), (short)3, 20, "Course32", new Guid("c960e5a3-759f-4253-bd26-5e5ddf30ea4c"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("bb44fbf7-38a3-4250-bcd2-523c76cd00a5"), (short)0, 20, "Course17", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("00a8a18e-6784-4bf0-ad3a-4780dbe1c2c5"), (short)0, 20, "Course0", new Guid("325ff50f-cae1-40a2-8831-80291be583f9"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("0672f7b1-b9da-4c61-baed-030f40559e0d"), (short)4, 20, "Course34", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("4d4fcd7f-9be8-4d26-ad81-c185cb80fc3e"), (short)3, 20, "Course0", new Guid("5ad02a4d-11e1-43cf-91e4-e2863132721c"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("74a1fde6-923b-488d-b924-5e2358695d04"), (short)1, 20, "Course0", new Guid("d27e2fc0-da29-40b3-b087-8c4a5ab61988"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("f8ac9470-7dd3-4329-b9b4-c32a616a59f0"), (short)0, 20, "Course23", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("423fcbf7-9f9c-4d6f-8fa3-8c1b88414313"), (short)2, 20, "Course0", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("325b7789-79f5-48f5-8914-df7ee291c18c"), (short)3, 20, "Course0", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("f04a31a2-88f6-4ff3-8925-926403e18987") },
                    { new Guid("c6418a1e-3bd8-4bed-8491-b9b93012d45e"), (short)4, 20, "Course11", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("715043b3-7b14-4007-b1db-95e187f7a2b4"), (short)4, 20, "Course0", new Guid("135e9c16-5e5b-46d6-ad84-e338eb3c78c2"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("3cd76aa2-bf29-4531-99bb-4b60ebb03551"), (short)0, 20, "Course10", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("b4f574a0-0eea-4413-876f-64e554c0e929"), (short)4, 20, "Course0", new Guid("083e428a-d4f5-485d-b2de-54c2dd64a8af"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("2d2b80d3-f245-4878-a64f-39cec211539a"), (short)1, 20, "Course9", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("127fb692-12ff-4548-89eb-b21c1673f7e5"), (short)0, 20, "Course0", new Guid("160f0cae-1618-488d-ab49-965e96a5f955"), new Guid("7cee5f31-56c8-4b60-abaa-ae135cbda7ac") },
                    { new Guid("4fa69539-334b-4132-856a-dd14a1c228ab"), (short)2, 20, "Course8", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("db038ed8-bb29-4f07-864a-dcebd72b1399"), (short)1, 20, "Course0", new Guid("09b30035-efa3-4667-be46-3bd3c6c33859"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("ee72f575-66ec-4414-937a-3873059bb42e"), (short)0, 20, "Course7", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("24230622-b78a-4901-aec2-e96de24c6da8"), (short)4, 20, "Course0", new Guid("877138af-5424-4b1b-9c2a-bb9273116280"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("51975f8f-d60b-45f8-aa69-f7a7f01112db"), (short)5, 20, "Course6", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("42585dde-4570-4acb-8d18-b7589eee76de"), (short)4, 20, "Course0", new Guid("e6a752b1-afb5-496e-8777-bb985e1183ea"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("ce3ed5e3-032a-438e-b7be-4d5771639070"), (short)1, 20, "Course5", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("b43d90d4-2488-4138-995d-555cb28d048c"), (short)2, 20, "Course0", new Guid("0a8b69e8-da63-4fdd-8359-a6d65a716719"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("a34a7c96-0f1a-4c64-9772-76d6caf51553"), (short)2, 20, "Course4", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("ced29c79-48b5-4153-8c52-ae945ca62731"), (short)0, 20, "Course0", new Guid("9ac17c62-7f8e-4768-90d8-701e7bfa9d6d"), new Guid("440f5863-b80a-444b-9e38-7628b16206a1") },
                    { new Guid("55d90fec-9ddb-455a-9aef-f84b60f495f7"), (short)0, 20, "Course3", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("3a099a8c-7d4b-4194-b509-61180d316bc8"), (short)3, 20, "Course0", new Guid("6f7e45aa-866a-4114-8b00-e76492611e94"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("f51fb8af-3cf7-41eb-a02e-1c32571ce140"), (short)4, 20, "Course2", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("1623cdb7-0d67-463b-a372-ffd80f80c33c"), (short)0, 20, "Course0", new Guid("482c0dd7-ca14-4440-ae43-7fdee4bc27f2"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("a62dcc26-c492-4728-af34-edc57b70a66c"), (short)0, 20, "Course1", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("80bcf75a-5dbe-4e7e-9a47-7d68d0704d19"), (short)0, 20, "Course0", new Guid("c5697871-d83a-4001-acd9-cff38366f366"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("d7675fc9-5e22-4bc5-888b-9fff21cf45f3"), (short)3, 20, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("51ef5da1-f5ca-40a1-b641-112b2cbc22ea") },
                    { new Guid("c2a35a28-52f9-48db-a351-c34358f19aea"), (short)4, 20, "Course0", new Guid("7358faaa-8469-4d1b-980a-fb1a81113187"), new Guid("38f00b21-23bd-4d5b-9bff-70839859e665") },
                    { new Guid("51f1221b-72e5-47d3-9176-38572f8e5f71"), (short)0, 20, "Course18", new Guid("3bc49047-fe75-46c0-8935-cebc00ec59e5"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("6c7aab23-ebc4-4d49-8c10-d1026999335c"), (short)1, 20, "Course15", new Guid("5ef2a6bf-b329-4d8c-9ac7-03070d31d418"), new Guid("57489b88-50a6-412f-8d32-d544805f5eaa") },
                    { new Guid("783b7e04-c50b-4056-b6a4-6aa8535cbb10"), (short)2, 20, "Course0", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("9d94b677-3e2d-4388-89d5-3aaa7259ab19"), (short)0, 20, "Course0", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("5cd60307-4c3f-4018-94bf-031ae15aa971"), (short)3, 20, "Course14", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("64f2c511-583d-4dc4-a811-dada76aba579") },
                    { new Guid("a08c6128-d7fc-462d-8659-3ede91974c04"), (short)2, 20, "Course0", new Guid("f33c8045-4510-4ddb-a6c8-51e2e2ae6794"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("b8713e6a-2e5a-4f40-9ea2-f6ea9ec0364b"), (short)2, 20, "Course13", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("c8c05a9a-2a65-4909-9cb7-2acdd2ea532e"), (short)5, 20, "Course0", new Guid("55defff8-ea1e-4f76-bdee-e2f373322270"), new Guid("ee2b6e94-4732-49ca-b735-14bca07a132d") },
                    { new Guid("efdbc667-3318-4da4-8088-970ac69ef635"), (short)2, 20, "Course12", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("113968fc-1b3d-4256-ab69-435884f466d1"), (short)0, 20, "Course0", new Guid("cf42925a-34eb-4464-897d-48396f722e88"), new Guid("23c112bb-87e0-4c09-bbcb-71516e7c2216") },
                    { new Guid("e1909bde-1661-4ff2-a0a1-1c939d8a6b56"), (short)0, 20, "Course29", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("34568b31-8579-4eb1-8286-3fcef5537d0d"), (short)3, 20, "Course0", new Guid("90f49075-f49a-4f31-83a2-0e353ccb7f1d"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("2984a264-40d4-40e4-94fa-f3443b13a2e9"), (short)1, 20, "Course28", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("6eaf6240-ff67-4807-838f-df36916e11a9") },
                    { new Guid("e935827a-d958-4c82-80a9-837141ef505b"), (short)4, 20, "Course0", new Guid("499fc893-ec16-418d-aaf8-145c90826e82"), new Guid("ba859ce1-9c65-4ced-9989-f2435ccfa10f") },
                    { new Guid("4e50c87c-17c5-460a-9885-b176937e05aa"), (short)4, 20, "Course27", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("c2829d3d-1119-4b66-8704-6496cbaf96ff"), (short)0, 20, "Course0", new Guid("0d5b99cd-79da-45b1-b1de-32f0f3334c8e"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("ac6c698a-8362-4623-ace9-6427b23d39a6"), (short)2, 20, "Course26", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("b617c130-731d-4b3b-8779-7e7f418cc155"), (short)0, 20, "Course0", new Guid("114f71e4-3731-46ee-a680-ac05b93e16d1"), new Guid("4899c5fe-2ada-4dcb-9ba9-0f593bf1efda") },
                    { new Guid("4b9216fd-1f1a-42f4-b264-65e5d6728cfc"), (short)3, 20, "Course25", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("356f2f85-4ba7-4d2f-8ae1-9647218f198e") },
                    { new Guid("5e7848e5-ed63-4c60-9c9d-50f859487eba"), (short)5, 20, "Course0", new Guid("efd5dfac-6887-472b-ad1b-a3649b776b51"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("4dcae60e-e16e-43cc-a460-0ebc670812cc"), (short)0, 20, "Course24", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("7ecc162b-4ba1-4320-a1d2-2771031c672a"), (short)0, 20, "Course0", new Guid("1ac4dc15-387a-4b2f-bac3-bc2cbe981d71"), new Guid("0571d659-31bd-4ae9-ba31-96b27fc408da") },
                    { new Guid("ccb1c3d8-3ef0-4d04-ad40-d8eab450fe70"), (short)4, 20, "Course0", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("b55c1b00-ccb4-4f28-817c-52b795a61c72"), (short)3, 20, "Course0", new Guid("5b0b440a-ce3c-4a50-9c94-fff0a652afe0"), new Guid("dbc0fbcb-62b1-4a7c-8782-007ecf3b8321") },
                    { new Guid("8ba521a2-63b4-446e-9734-6e0794359a82"), (short)5, 20, "Course22", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("dacf4734-4f21-4a3f-baf9-2bdf3732f23f"), (short)5, 20, "Course0", new Guid("f307fc62-a8d2-4f3d-96b1-92fc1c158636"), new Guid("3e3f0aaf-e4b3-447d-9249-660d67c43f0e") },
                    { new Guid("36ef1441-03a6-43af-a6b7-fdc27576bf3a"), (short)5, 20, "Course21", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("c9c38940-d3b6-4ec7-87ea-7534133c08e9") },
                    { new Guid("565c3b5a-cb45-46f7-a560-74bff9106bfa"), (short)1, 20, "Course0", new Guid("2742478c-a97e-41c5-973e-920b9ea7bd15"), new Guid("a2de442f-3286-48a7-b2d7-51ae46a97a9b") },
                    { new Guid("4d60428a-3d63-43ba-b793-d268b0edab20"), (short)3, 20, "Course20", new Guid("574edf1a-d2e1-4793-9784-9e466d74d8d1"), new Guid("5189c11f-749c-4cff-b130-1a7093c9a639") },
                    { new Guid("854033aa-92dc-440e-8355-e358a5c0afec"), (short)5, 20, "Course19", new Guid("9c2e7580-5a91-499a-96cd-05a3a88d46f3"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") },
                    { new Guid("b7d93dd9-ace6-4acb-8a34-f85dbd349c2c"), (short)2, 20, "Course35", new Guid("e30574ff-b6a3-4b7e-b56a-75977b8b9a62"), new Guid("0f160406-80c3-4e48-82ef-9c5a7e2f94a5") }
                });
        }
    }
}
