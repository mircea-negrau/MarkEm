using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Org.Webelopers.Api.Migrations
{
    public partial class AddEmailInsteadOfEmailHashForAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("07cfd812-047f-498d-916d-7e847b84140f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AccountId",
                keyValue: new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("09c6a7a8-67fc-4fbb-994f-8afbfd8ef743"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0c0fad3c-7f67-483c-ba2c-2e27137cb54d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0ce7c9a3-e212-4996-872b-79d97f150010"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0d1773ec-0244-4c09-8b24-b6f34a275ab1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0ef4d181-436b-453c-b2a0-8754880dc64a"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1025ff84-b64f-46ae-8fa4-41fec6d6f171"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("106445cc-e7da-4036-98b3-08b35fb302d6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("15c970c3-b25c-4c5c-9836-69ace70bc0ea"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("164a13d6-1ab0-42fb-ba23-a83e8e00a74c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1d95401d-d844-4cd5-b347-f4502af65bd4"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1e16dc4a-08bf-48d1-ae9d-9e6e9436bbf4"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1ec752c6-ebd2-4055-97b5-c0a187970e85"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("23c227b7-08b2-40f7-904a-ed5d7b994cbf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("243497cd-f91e-4a24-ba6d-cca28bb863ac"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("26b3ba54-1e49-4807-ac04-3db4651c0b84"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2fa6b3b1-ec49-46ed-8b4e-7f670ce94c57"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("35e4e51c-503f-4f79-96c6-beb201966917"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("37faf795-9e3d-4e7e-a86f-813008dcd4e7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3a0cb163-5dff-4a4c-a84c-37ec5a5e551f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3d66ef22-dfde-41a0-8f8f-8cf1364ad04e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3dd4b36d-d662-4b56-8414-1839ae50d322"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3dd8e9f0-1f01-4db9-97d3-a0d5d9de1d9c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4d77ba5e-ac5e-4ea9-93dc-4e8a2652cccb"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4ea51a45-d354-485d-aca7-696993b47ea7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("564571ab-193f-4378-90c9-672903298184"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5b56c634-9fb1-466d-8d88-21aa37c9014c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5c37b51d-a1c9-4441-8245-78d16a149b89"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("63094e16-0d70-43ef-b1cb-3237d3c021c8"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("664fe71c-7d81-45c4-98da-c7213e6f919b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("671fc258-ae33-4336-b98d-6a8fc037c6a6"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("67b0c287-8404-44a1-a135-e6d91ac1e41d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("70d8e9fa-fea1-4e94-8a8c-b69f2b1fa1d2"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("727238df-9940-4cd5-8602-9dcb7ad6d198"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("73578850-5c75-475b-a4b0-80d8b9d5f7c3"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7429d0f1-1c3f-4ff6-999e-48f46225ad56"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7b053d1c-38e8-4ab5-9b43-f7792306c45b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("7e5eaf80-dc98-4b7f-9051-e2d8a2e06675"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("806b0bb5-1532-4505-a6c1-e594b37cf25f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("826f93e5-3cdb-407b-a4d9-79f220dce519"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("90cb5bfb-3beb-4665-8353-a34d7a489a28"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("97aeadf0-e163-4377-9546-17ccd74f8b1d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9c77760e-39a5-432b-a750-20863e29afd1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9d6e111f-c05a-4cf3-97b5-17419684539b"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9d8852b5-0a17-4e6d-af84-7763b6fa6ae5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9f612ffe-e2b6-46d6-9bb9-366eaf457c31"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a7a4a539-47b6-469d-9fb1-09ab2b6c0b2f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("a7d32706-059e-4441-b28b-48ee8fc51665"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("aaf7dac2-2f86-48ff-b01d-e4a686407468"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("af6d5c23-cc01-4712-b88f-aea3ce884347"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("afebc5f8-a94a-413c-b8ca-2ccb9acae24c"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b0595e3b-ca8d-400f-a574-d0ea91d0c5e5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b06bc045-696e-439b-a3a6-f1bd84486438"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b12884d0-e266-4ce0-bc61-c65276e49c43"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b2009ddc-83ea-493f-b9a0-597c3cce4f06"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b4759aa8-7602-4f65-a2c0-37720da32d30"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b8996bc3-6078-4952-bf32-a500d62359dd"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("b8a0c246-76b3-408d-a80f-aabd51b9ab7f"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c049ff9b-800d-4553-a8b6-ecc25fd8ad31"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c2dd13ae-a82d-4f08-a3be-ce053e7bae72"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c3b8b274-e846-46f7-83da-b0459eca06a3"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c4aad5b1-11e4-421f-98cd-bf02c457aebf"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("c5e62b9c-3cad-4135-bb8e-334d3759385e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d266b1fe-17ba-4ba3-97d2-9eae480ed6ea"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d5d67367-53cd-42a8-8aa0-8b8af28ddfe7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("d7cbdd5c-ad78-4cb6-9983-4253a09fdd53"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("dd352b57-7766-49c9-b001-368415df6dd1"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("df5c6383-763a-4547-babc-c79ff2bb4339"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e1199575-353f-4bf2-9876-dfb2f21897f9"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e6cecb5d-934b-4d05-8489-2c00318bce1d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("ea8ae582-d1c8-4cf8-ae4f-1dffd7908af5"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("f3375d29-fc29-4af4-aebf-37739f53b91e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("fbc3c21b-9566-4921-b79e-e8355d8489a4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("024bf998-be1a-4bf9-9b91-0253ed48ad9a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("04f01d38-50e5-4f6c-982c-1a4fba9d6c3d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("05a72e88-13d0-44f5-a02a-6ceae6d360b0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("065edf2f-6413-4176-bcaf-f9ce7440928b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("089f8bb8-6cd8-4317-b21b-421676fade89"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("09a89b6a-8911-4972-bf2f-3c108694b318"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0aa934d3-b028-41a8-aa70-e2c67e4c03ae"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0ab456d9-32e5-46a0-b082-aca1f6423406"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0b65dcb2-d615-4011-a9ad-e8ba62f677f5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0b8f860c-09f2-456b-8d10-3b9c535968f2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0bb57faf-198d-40f4-959c-ce5f5ea7d4a6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0cbfedca-dd07-40a3-9c0e-56f5ab9c9a51"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0cc1e0f3-6542-494c-80e8-baefb5c7373b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0cc4a65a-684b-42f9-a050-3379c05f63d5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0def7447-32ab-481d-9cf1-905d6c413961"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0f3d5b5c-db25-4265-987c-d95ad43df64e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0fc679c6-bb5a-4522-976d-6b2552a47e45"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0fd73b51-ea34-4293-ae09-5bd769d75db1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("115a9056-7522-4b55-a51a-bae84e954991"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("116cf99f-1472-45b3-9cb6-f7a9bb3575f3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11aa98ed-89f4-45ca-b22f-b48ca68f2cd7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1551cb8c-235c-4b26-8e80-67d823c149ed"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("15a29671-68dd-4fc5-9b83-75341f269ea1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("15fb3f6c-c025-4531-bdea-40b803e6560a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("16677d5b-00b9-4de7-ba4e-fe830c37addd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("17ef7042-9506-4eba-9e26-4d4365ad4d99"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1881121c-5ec1-4e72-9d15-26006165f151"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("191fca39-580a-466f-b5b6-ac103aa0ef64"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("197b4d87-1a6e-4381-a848-e5323ae47869"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1afbf401-7aad-4f01-ae35-ed9b077c5759"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1b43296f-6e96-486a-9c7e-983a57a769b1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1b9d976f-6b48-4711-b32f-b31deb152a5d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1ce2306f-7ece-4b2c-b4c6-e3bc7c8cfed3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1e19c66e-4f3b-47fb-8c03-01d060c79a29"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1ea77f73-81de-472b-9504-0077dc4959b1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("227ef423-560c-436e-b6ef-c56e1a3bdaa0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("22bee928-00a4-4e3f-acd7-1379763a225b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("23419b05-88e4-4273-8792-51e47bf97ee5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2380a6a9-91f6-42e4-b062-06cc2753dcb6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("242bf2e8-a913-4445-85b0-26822a2f51de"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("27a3d3f2-4849-401c-98fb-dd1723666c86"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("293249b5-3966-4341-82a6-e90dd651e8c1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2937aa60-a1b7-453a-ad92-c2a66035d031"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2a49f6ca-9448-4a17-bb51-6f78f0cf8bc9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2bff610d-7698-4e6f-85c8-780d6c2bdb6e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2c2c6778-a099-498a-8c84-aa0865e05308"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2d613563-3022-4684-9471-ce43baacc5a1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3040d948-3aa7-47c0-bd73-65eeb32187cf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("315807bc-3432-4fcd-9149-9d9fe41f5d7c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("31ec2bf3-5ea2-48ca-bda6-00df1752c459"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("33d528b2-1f9f-4fd2-a475-43a9e19553ea"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3417176e-cc64-4e64-8f03-3b2a74bf93f7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("34ae4e00-42fc-4315-946f-30f63f2f140e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("35f18927-31b2-4935-ab60-61f8b07a6f44"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("35f70554-0234-4cb5-b160-64d8455781f2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("37efb670-d868-4047-b738-763decf11cb2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3ba59efa-f9b3-4234-b916-1c4bf446d695"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3c6eadc8-27d5-40cf-9091-fc0e6bb58831"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3cb31a5c-fc0d-43b6-beab-40b5e73d7dd2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3ebae0fd-3df7-4f7f-80eb-5a77d16666f0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("40317028-fb37-40fd-90eb-03b1a71eae7a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4214734c-053b-4952-ab0d-1cc19cb5725c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("422d7d77-cc1e-4748-8a11-22953b8ee104"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("424326da-4c8c-4da0-b6aa-413f24b1a99e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("44e1c1c2-fefe-4180-a475-0e952bbd4935"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("453c38c1-b666-4042-8b7f-4fcbbf2897d2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("454ece4f-796b-4961-a808-d2e353c4afe4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4754999d-928e-4674-942e-fe5eae131715"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("48bdbf65-a9a8-4328-b925-959c6f1ee077"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4a5209f5-afc2-48a1-a39a-dd22003a68f6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4b1dcb4d-28d6-4a18-903c-3352361c8c84"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4c777b80-aadf-45c1-abb9-aeedd4962dd5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4dc0f244-f847-4d76-ba87-88d77bbb8ad5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4e164eae-9520-425c-a6cf-d36102ad8b27"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4f23415f-f74b-46bb-bee9-2bd5bec67514"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4f37e225-4a3b-424b-805f-361967b267bc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("51b49d9e-a556-4ff8-9b3f-1dad07146617"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("528a1696-2147-4739-9749-52625e4a20e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5389ff5e-c63c-4c1e-ad17-856e9e409b44"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("548bef49-da4a-4a4e-9f06-4d9f2bde5292"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("54a2b5f0-b301-46fc-9d94-2d595631046b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("57ff5424-0587-4813-a110-6c4c3ea3fc81"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5c53dc4a-b4a3-4469-a19a-4238a1cab25b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5e855979-45dc-4ee2-b65e-470d2c754573"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("60bd24ad-daea-4719-ae80-3e25bdd7ca45"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("60ce6b92-62d6-40dc-aa79-21c6fbe29c20"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("60ee9bd0-d4d5-46ad-a7ac-2c5a20551a8d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("620c593b-683d-46bd-9505-8168df2abc4e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("62d1a5b0-f3b1-4e52-aefc-d97feaed5533"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6440e233-88b7-47bc-be24-2029b56cfae9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6443dc44-96d0-4e81-9521-839c0dd04dc3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("65765cd5-1582-492a-b53f-49349b9218e8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("66bb1f46-f3e4-4734-83ed-05e3438c4af9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6701641c-b3ee-47df-b14e-0428d98a9555"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("68ae9ea0-06bb-44d9-a164-5684d2fb0cc2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6d4a36ac-6c7b-4fcb-9fc9-491f83ec4ff8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6da5dc3c-3fbb-4806-9fd2-063e16bc7ddc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("70a795a1-230c-486d-955a-8fed07758397"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("717f38ac-8611-43ef-b38b-4c930c334913"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7262b2c9-396e-43b4-b2ec-6debf147d93c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("74c6230c-7dcb-40aa-b3f5-bea32df93899"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("74d45fd0-4832-4b94-8ac1-6f9e4cf92682"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("75994679-d556-4daf-b772-f2d34cda4d9d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("75b8c4da-3045-42e6-a868-6ea7a4028a9f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7b0e6109-0877-4963-8140-9de2f1fed68e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7b948248-f556-4051-86f0-d4bccb42afdf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7c87761f-40fa-4e4f-9fa2-4bfa499f558e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7d421257-7152-4378-affa-ef1121075c3b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7d6446fa-457d-40b0-beaf-149028b03227"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7eaf0e66-aa29-4054-a6f3-c86470920fec"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("803b0b73-b411-4a08-970d-41d9bc228698"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("81b4e5b8-0edb-4fa9-aff0-8cb5999d03e5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("85f3e497-270c-4885-b21a-0bf602cd1679"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8863fff2-6388-4711-b919-a6c4d0cb0975"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("88bb07fa-cea9-41a8-a95c-9fc8ca790e36"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8977cf09-b01d-4a90-b816-91add9e90d55"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8c70c666-e382-418c-a8fb-50e221f72f69"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8d6be354-36e9-4786-aaf5-b4b7ba0b98b5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8f9efc74-828c-4d0a-a187-850498c5475a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8fc85435-545e-4bef-adee-3cbe60ab3f8c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8fee1121-1080-4e02-b4b3-bc67b031ffeb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("90ed04d8-c821-44a1-9aab-f4383bad0405"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("90fff920-f735-4a48-8c3d-3a956e2c093a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("938a64c5-7572-4e61-8cd8-77053377d6b6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("97cad48f-99b2-4608-93d4-8cc6baae0a9b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9802b0cf-477e-41b1-b8f5-9e25987b2ed0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("99fa7775-b6fe-41f6-bd2b-650e8d1f3f42"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9a3772b1-0ef2-4e05-93e6-8877ec655810"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9a97c2fe-d7b0-4d21-af10-eeacd6078f95"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a35d4345-3d4e-441c-b461-bb70dbb81c2a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a39fa61b-0280-408e-b7ed-aa8022125908"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a4071214-3d7e-48d7-a49a-9dcea44f55ad"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a4fbd99d-bda4-419a-85a9-8a0068fe6881"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a5c2031b-f6e7-4820-9c29-00985df9fc9b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a5ed0983-ac56-4159-ab33-c32c1de47135"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a7239024-00e6-4316-bed6-b61dd82f3abe"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a83d7f35-54ff-4683-8931-d3a30596a72d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a8e0b5c4-090f-4aab-9951-cff898f7575e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ad8643e2-4e85-4536-8230-141aa46213a9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ae91d3c0-be86-4fb9-912d-1b2d4be55fa1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aebc75a8-3d65-4a69-b6a6-ff3eb0756184"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b0a97486-71d9-41b2-80b4-d2c53ecf6569"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b1345efc-68ca-49a9-89ea-593ccc55aa07"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b28041dc-750d-45ab-8f8d-e831c155d282"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b4327c3e-e556-4e4a-85b0-399717ecd13c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b433fc46-a0b1-4734-9316-5b0f18103c56"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b476a873-175b-4b8f-9601-b4cbd56a3ef5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b62b1cc8-f11a-4e8d-950c-e4ac193abd04"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b63c575e-484f-427b-b7e3-6ba84485d18a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b6f78356-8f44-4d0e-b9c5-6c27a5e40294"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b89e2936-7b9b-44a9-8282-94854c298945"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bcb64f7b-2cc3-4262-b5e6-76cf92fcd077"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bd7239f2-1ce1-4f91-8116-7ff96c04efbc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c0163e6b-e686-4644-8480-61ddc362cf27"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c092ad42-57f9-4ac0-86b4-acba4feb6fae"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c16dcd0d-05ab-4547-bc41-1d804d41127c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c2c8651a-67c5-4c5c-a004-ee7af5b5bb99"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c359f80a-df41-4a34-ba83-3f35fe5a2a84"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c3a79417-95eb-4129-88ba-80cc77f80fc3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c40c9fa0-fa36-49e3-81b5-56c1f6c79f8e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c4bf5503-1a25-44ef-9953-e71dae893ff5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c4c64407-c5b8-4e96-9520-813699fe5d69"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c6c8141b-cddf-4ba5-a3e6-13c2ed1e0607"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c74503f2-dd2c-47b3-b403-0810836ca7c5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c7e7f8e0-3e0a-4983-95b2-2fd554224cda"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c8505dff-4f7e-4fb2-b424-9dfc59738289"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c9b4b379-8414-4cfe-ae75-37b8ad43792a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c9c4ed44-1ad1-4216-9f00-9e85522e1d70"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cac47508-4e1f-40da-a5c4-3d64a1ca3e22"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cc15bf79-018b-401e-95ed-35caa753014a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cc235b05-a11f-4b95-9865-f9f2a9dc60c3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cdcbab77-269e-471f-b914-8a6280bdcdcf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ce538069-a9d7-48c3-ad21-09c1a308a520"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("cea45bc0-ed63-4cec-b0bc-833f1cdeb955"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d12e37e1-ba4c-48f9-85ad-7b46acee01b4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d158eef7-afd3-40d2-8390-7974d05d22e4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d165987a-db36-422c-af60-a3091e70df43"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d16e7e47-ee86-42cb-8ef6-6297c1d545d8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d1ef545e-9359-4a51-985d-beb69155394d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d540bf69-f1ea-450b-a8cb-35413bfbea7e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d597dd18-4f63-4305-920f-c2bda5c91987"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d6d5abe9-9b2e-43fa-bbf0-7e1d6810bdc5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d6e7ddc5-d2aa-4563-a52e-0d8f1bd0cbce"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d80c0883-05e1-4620-8025-ddc0ad9e458d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d81b35b2-171e-4c54-89e9-3ca22557cc97"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d8fdc01a-1dcf-4436-9789-2bfa7a7147be"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d92e4ba2-8f81-487d-ad6f-42596f338c63"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("da20a8b6-f692-4d50-a9bb-df79a53462a2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("da5c125f-43e2-4431-a7ce-708eed2aad5e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("db684a1b-2eef-463e-85b1-17db42347f7f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("de6d058d-3320-456c-b766-4dd30ebeb4af"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("de9796d7-bfc3-478a-b205-e32b1514ab7a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("df309229-7cf8-4d4b-bb58-cc02d9b1594e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e1304a75-83d6-4430-8d04-f67fa28d5599"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e178705c-b7cc-477b-aedb-2cfc2080f968"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e1a562d5-a9aa-4cdd-962c-b2c9132c500d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e2bdf5c3-d0e1-448e-af9d-f444631d0f13"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e30d25f4-c1dd-484d-8710-01adc54f8b46"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e5dd9947-42a7-446a-965c-34dd966f6361"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e5fbbed4-b099-480b-aaa6-142475eba9ec"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e6f97912-82eb-4561-8e10-8ac2d7961f83"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e6fd24fa-7956-4a16-ae0c-f067e9a2c3f0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e7575089-9108-4aa0-9645-4a100df0d180"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("eaf26294-24f7-47fb-ba3a-17cfd471fb41"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ec38080e-8ed7-4282-ba63-968c122763fb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ee5ed2c5-829d-408e-8202-cf5d00f707b3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f223cf52-8bc7-4b9f-adea-f66b9fd20f06"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f292d0a9-bac5-4389-9880-0fcb6fca63f3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f5daee95-034a-46a4-9b3f-f69df388168f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f6ad26c5-55f4-4ed6-a20f-4ab41134bd92"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f72ab8d4-6fd7-48de-bfae-70d2de058289"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f81b81e2-0be6-4650-b3e6-d27d10f39a5a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f9e6f9a6-68d7-46af-95b1-0c22fe1e0476"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fc314fed-2892-4230-9d1b-ebedae42284e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fd09a277-82b2-44bc-aff3-accb4a275f4e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fe45f3b9-e566-4b37-9fce-7943e4345d16"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("0299b5a4-08d1-4d38-8877-ff0aac1d1521"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("04f0e0bc-0b49-44c9-80ca-c7f8ad740069"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("059bf253-2319-4dd1-b165-a4f657f9e701"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("06540d95-2cd7-4321-963a-49241028ee2d"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("0cb83019-99a3-4b9e-b0db-ee5aa33b885b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("1171290a-7d87-4cdc-8fdf-023922986557"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("179faa55-0ef8-47fe-8124-11c476568074"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("1b01561d-2848-4f55-b7a4-13fe8f24ed27"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("1f6c8d33-06dd-42e0-a446-0b21eb8f084c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("246bb696-32a4-46af-bfda-e15b320c0dd6"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2515d430-d1e0-4e5f-a43c-eeaa48a0c45a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("264d085b-53bb-4bb8-bd70-f207c8829b30"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("2eb6f8a9-3c01-4a96-94e4-71f7703c011e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("329c4560-62ee-47af-abb6-7607dd7ae35a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("36318065-6873-4e75-a0f8-a8b802536f9e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("3714923f-cf5b-4b87-a682-9bfa3045e16a"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("47489b22-bd13-4672-9d1f-b2419ffb410b"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("47821439-2ef5-4725-be2c-b9dd7575e163"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("488bed48-4362-4cd5-98c3-a69f19faf517"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4fca6fc0-21e0-4bd8-9b80-5c9714ba0492"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("4fd9fcbb-267e-4fbb-99f7-dd18d2aa9786"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("54308ae4-64eb-4e66-8436-22e93815c895"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5447ae2f-9185-4308-bfde-36273a7dd637"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("55f8ddc3-242c-4877-a565-acdc6df6f1ec"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5a008051-73f4-4c96-96a0-cce72d98b0dc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5c0ec2a8-5b1a-4dbe-a60f-9a9c3b8bf1c7"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("5e85550e-e19a-4510-b84d-953e8fad4850"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("664ed1b7-56e4-414d-871c-3146df861285"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("6853d5d7-63cc-4d44-947d-b457b30ba469"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("70706b38-d838-4e94-be1f-d3e9f93af540"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("78c9cc13-1672-44cc-b8a5-7d9d44bf810c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("7a9150b9-1b06-469d-9fc5-70066bec3bbe"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("80fb9c08-f388-4d50-a6cf-c0ff76453384"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("8481d187-91d9-4867-8e4a-05ea555b8888"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("84dd3636-2cc7-40d9-877a-024f322b7ec2"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("8be9964f-a67b-4780-9337-60ec615cad11"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("946abd82-4c56-485a-a2a0-ce79c60691bb"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a0f1a828-f6f9-4153-baf5-7398ddb2b6e4"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a7b5c435-b5fa-4329-b60a-80f423aa0c2f"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a8333c09-7c9d-4a39-81c5-2754d5d3048e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a861da02-f184-44b8-9f46-7953a0ac65cc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("a8853243-fbb4-4330-907b-502b1f1dd5f7"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("aad38d29-7bf5-4d61-b7be-bf048da0d42f"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b848ccd2-abbf-42f3-aba7-2578bc7299ac"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b89b5130-0c22-4ca8-aa63-4e2ec3b59413"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b91d2ebe-053e-4a37-b288-2208ae367415"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("b981f528-f3e8-48d6-9bad-db3deb6d777e"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ba16951d-c886-4adf-9179-e7a027011c4f"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("bb407ab4-cb82-416d-9154-2e9b109eeac8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("bb896fcd-a9c3-4b52-9064-c390e47b51d0"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("bc47feb8-897c-48c5-9511-5e9c17634523"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c4522fec-2a4f-4efc-901f-773ffc45286c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c69e2f5e-55ef-457d-ba06-668b33f63164"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c703a972-f923-472a-a567-1f4c7b861ee2"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c952e1ae-0f88-4625-b7df-58fb5a603b44"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c96bdb7e-82fa-4ae6-8935-734b5d215a01"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("c9f53e2a-46b9-46eb-9733-632aa99fdce1"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ce6ca2e8-9f5a-4031-9ae8-1abb969b3a7f"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("cf744660-3809-428a-865a-21c1a29e481c"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d4d4684d-8836-4b11-b0cc-86c979f4b8fc"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d5fb859b-a927-4286-85d9-27c018471b98"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("d92e2779-e05d-4ef1-b897-bfb06a84a5e0"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("dbe17214-3bda-4587-8fbc-1926f069d559"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e14de5bf-9f22-476b-a5f3-252a7f92a5db"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e3dce969-3138-491f-8c35-d8edb4fe0830"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("e5db6af0-b51e-4ad8-8246-08b2091b3f23"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ebd9e833-97de-4518-937c-0ce20e8de5fb"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("ef25218d-6606-4f4a-89c0-5728995f65ce"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f283b969-31b6-4538-b23d-4696059bc167"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f2d7ffc1-b4f1-44ec-9ae3-a3bf50bdc7db"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f808cd74-8b25-4424-a0f8-bd039cfe87f8"));

            migrationBuilder.DeleteData(
                table: "OptionalCourses",
                keyColumn: "Id",
                keyValue: new Guid("f9467108-a973-4ed5-a0a2-02647dcbd607"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("d819a0ca-3be4-449c-a23e-310e6f871598"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("07cfd812-047f-498d-916d-7e847b84140f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("047d5f61-314b-4ce8-b631-64a3a12fb239"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0e3945a9-3a01-4fd8-86cf-c4c223ebca79"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("17e755b1-67d3-456b-ab08-9bace8bf1499"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("20f78dff-abc9-4f25-8f98-7df665ca8cd5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("25fecc55-5fdb-462e-80df-52ee2c11e707"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2c79988f-6246-4256-bd67-8e11d932a663"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2e135cc3-a5f4-4c8c-bcfe-2a31a04238a2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3a888b6f-d997-41c3-b78c-22bc81609a14"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3bcebc11-cf9c-45a8-9284-7dea6502f3e3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("408d2ca0-ef00-40ab-8ca5-4713ca59bacc"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("48cfc7d0-01c2-4610-9f10-ac05c5b27a55"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("548554f6-a9d6-4955-aa27-33966a978f9f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("593b8697-93cf-4382-9071-e912d8162813"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("59d210b1-da72-479c-8e75-13019e66a19f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("61638f23-9d32-427d-a0ee-5ecefcb0671e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("67c0d79d-0929-4bdc-b990-853a5b0b4fb9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("70b92c51-d74e-421c-84ad-0490736bcac6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7183038d-3c40-43de-b0c7-aaffd0371527"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("778eb6cf-a35a-40de-9bf0-09a9a8643176"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("80319172-f1ea-4749-9d24-34867e1f9a37"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("80e64474-0e4f-4b0f-bbfd-53e74b7e70cd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9702f4a0-fe9b-4aae-a9c8-76b84e89559d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9864d11a-27f4-4ec1-b99e-6b7fcb660ea0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a01bb2b0-884a-4a83-af22-ca3a98dcdb3b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b390b62c-e3f5-4201-9675-29dc9e4aea7c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ba0f286c-3a4e-4068-b18f-72d7a6a628fc"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("be1fb0b0-b64b-4962-be0f-b2688db42d35"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c4ab0b70-3408-4fb5-836f-d063f9f2cc6c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c9edf964-f23e-4af9-9182-d91895212bb0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("cb5efdeb-6ffc-4c19-8cca-6ed94ba7c867"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d7d5ee41-0749-47e6-888b-b7745d13fc33"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e076e4c0-be4e-4529-8804-a095b3153949"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e18e5e04-3fa9-4d5f-a0ff-b46d721a5603"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e319e079-aa3a-499a-b7e8-cf6eae5e86cf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("eed65e09-d154-4c59-b3a2-2e79a83eb4e5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f4661024-d372-4b26-a528-92971d4026e9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f717afa8-85fb-45ca-92ba-3b830a2d90cf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f9b9b9d2-45cf-4aeb-9e41-9777c150c0a3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fbef0fc7-eec0-4359-bb33-a1481d1598dc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("4094df26-53da-4e51-aa69-28406bf0e198"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("41f342f3-6a25-40c0-b53b-135de297566b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("63195d9e-0811-490b-86f6-17855b2c7417"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("a7eec97f-7557-43cb-a304-a4be66956324"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("e768134a-118a-4555-bb9d-060a2b041a85"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("15673aa4-8126-43c1-b047-855314b81bc0"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("1603d021-f364-4d73-babe-5e856ac675d5"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("28166599-9455-408b-a091-0cf8f68b9793"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("5388f2c5-1fab-4389-a985-3677f94daead"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("87b77344-a316-4c77-99f9-41250addcd61"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("d337379f-541f-4903-9b61-a8b322a1019c"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"));

            migrationBuilder.DeleteData(
                table: "StudySemesters",
                keyColumn: "Id",
                keyValue: new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4094df26-53da-4e51-aa69-28406bf0e198"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("41f342f3-6a25-40c0-b53b-135de297566b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("63195d9e-0811-490b-86f6-17855b2c7417"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a7eec97f-7557-43cb-a304-a4be66956324"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e768134a-118a-4555-bb9d-060a2b041a85"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("648691b9-8bde-47b7-87b2-09ced338434f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("d03ec302-9032-4220-ad51-2da905881098"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("0b231890-5bfe-4325-834a-38484b483f08"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("3088a272-82f1-4091-aa76-9f46999917e9"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("39659841-222b-4029-8bb0-f5922c4b94a4"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("957ec602-b51c-4950-bda8-8f96a489a69c"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("d3c592b4-135c-4e51-b842-30ff352475a3"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("ebc64c61-b323-4bed-b776-14813ad9b255"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3"));

            migrationBuilder.DeleteData(
                table: "StudyYears",
                keyColumn: "Id",
                keyValue: new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("40772272-1210-4378-98bd-e829841f6b0c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("f052ae94-ba5a-4197-b978-520328996d6a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("40772272-1210-4378-98bd-e829841f6b0c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("648691b9-8bde-47b7-87b2-09ced338434f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d03ec302-9032-4220-ad51-2da905881098"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f052ae94-ba5a-4197-b978-520328996d6a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"));

            migrationBuilder.DeleteData(
                table: "Specialisations",
                keyColumn: "Id",
                keyValue: new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("7b772708-355b-4a84-8bac-b59464644496"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("86108a96-dd24-445b-b8cf-40855961fa35"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AccountId",
                keyValue: new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("edaece06-4188-4df1-aac2-978f30777f6b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7b772708-355b-4a84-8bac-b59464644496"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86108a96-dd24-445b-b8cf-40855961fa35"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8447b48e-a096-41cf-97fc-96ea2de422f2"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("411098c2-2c1c-4912-987a-1cb49f828156"));

            migrationBuilder.DeleteData(
                table: "StudyDegrees",
                keyColumn: "Id",
                keyValue: new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("4decf4a7-a414-4896-ad31-c4091dc4e3c2"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("84409672-4042-4ea4-b3d4-4087195b0285"));

            migrationBuilder.DeleteData(
                table: "StudyLines",
                keyColumn: "Id",
                keyValue: new Guid("d0d34ecc-8702-4cca-9e83-22a5b9516cf8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "AccountId",
                keyValue: new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("49aa5ee9-482a-415e-be2b-b037e114f394"));

            migrationBuilder.DeleteData(
                table: "TeacherDegrees",
                keyColumn: "Id",
                keyValue: new Guid("6e1d2723-921a-46ba-b865-a1216005ee14"));

            migrationBuilder.RenameColumn(
                name: "EmailHash",
                table: "Accounts",
                newName: "Email");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Accounts",
                newName: "EmailHash");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), "", "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", null, "Teacher", "TestAccount0" },
                    { new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"), "", "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", null, "Student", "TestAccount73" },
                    { new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"), "", "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", null, "Student", "TestAccount71" },
                    { new Guid("41f342f3-6a25-40c0-b53b-135de297566b"), "", "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", null, "Student", "TestAccount70" },
                    { new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), "", "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", null, "Student", "TestAccount69" },
                    { new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), "", "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", null, "Student", "TestAccount68" },
                    { new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"), "", "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", null, "Student", "TestAccount67" },
                    { new Guid("a7eec97f-7557-43cb-a304-a4be66956324"), "", "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", null, "Student", "TestAccount66" },
                    { new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"), "", "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", null, "Student", "TestAccount65" },
                    { new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"), "", "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", null, "Student", "TestAccount64" },
                    { new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), "", "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", null, "Student", "TestAccount63" },
                    { new Guid("7b772708-355b-4a84-8bac-b59464644496"), "", "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", null, "Student", "TestAccount62" },
                    { new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"), "", "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", null, "Student", "TestAccount61" },
                    { new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"), "", "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", null, "Student", "TestAccount60" },
                    { new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), "", "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", null, "Student", "TestAccount59" },
                    { new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"), "", "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", null, "Student", "TestAccount58" },
                    { new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"), "", "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", null, "Student", "TestAccount57" },
                    { new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"), "", "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", null, "Student", "TestAccount56" },
                    { new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"), "", "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", null, "Student", "TestAccount55" },
                    { new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), "", "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", null, "Student", "TestAccount54" },
                    { new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), "", "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", null, "Student", "TestAccount53" },
                    { new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"), "", "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", null, "Student", "TestAccount52" },
                    { new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"), "", "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", null, "Student", "TestAccount74" },
                    { new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"), "", "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", null, "Student", "TestAccount75" },
                    { new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"), "", "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", null, "Student", "TestAccount76" },
                    { new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"), "", "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", null, "Student", "TestAccount77" },
                    { new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), "", "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", null, "Student", "TestAccount99" },
                    { new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"), "", "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", null, "Student", "TestAccount98" },
                    { new Guid("63195d9e-0811-490b-86f6-17855b2c7417"), "", "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", null, "Student", "TestAccount97" },
                    { new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), "", "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", null, "Student", "TestAccount96" },
                    { new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"), "", "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", null, "Student", "TestAccount95" },
                    { new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"), "", "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", null, "Student", "TestAccount94" },
                    { new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"), "", "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", null, "Student", "TestAccount93" },
                    { new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"), "", "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", null, "Student", "TestAccount92" },
                    { new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"), "", "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", null, "Student", "TestAccount91" },
                    { new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), "", "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", null, "Student", "TestAccount90" },
                    { new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"), "", "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", null, "Student", "TestAccount51" },
                    { new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), "", "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", null, "Student", "TestAccount89" },
                    { new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"), "", "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", null, "Student", "TestAccount87" },
                    { new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"), "", "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", null, "Student", "TestAccount86" },
                    { new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"), "", "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", null, "Student", "TestAccount85" },
                    { new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"), "", "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", null, "Student", "TestAccount84" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"), "", "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", null, "Student", "TestAccount83" },
                    { new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), "", "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", null, "Student", "TestAccount82" },
                    { new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"), "", "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", null, "Student", "TestAccount81" },
                    { new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), "", "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", null, "Student", "TestAccount80" },
                    { new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"), "", "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", null, "Student", "TestAccount79" },
                    { new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"), "", "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", null, "Student", "TestAccount78" },
                    { new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"), "", "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", null, "Student", "TestAccount88" },
                    { new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"), "", "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", null, "Student", "TestAccount50" },
                    { new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), "", "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", null, "Student", "TestAccount72" },
                    { new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), "", "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", null, "Student", "TestAccount48" },
                    { new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"), "", "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", null, "Admin", "TestAccount22" },
                    { new Guid("07cfd812-047f-498d-916d-7e847b84140f"), "", "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", null, "Admin", "TestAccount21" },
                    { new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"), "", "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", null, "Admin", "TestAccount20" },
                    { new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"), "", "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", null, "Teacher", "TestAccount19" },
                    { new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"), "", "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", null, "Teacher", "TestAccount18" },
                    { new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"), "", "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", null, "Teacher", "TestAccount17" },
                    { new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"), "", "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", null, "Teacher", "TestAccount16" },
                    { new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"), "", "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", null, "Teacher", "TestAccount15" },
                    { new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"), "", "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", null, "Teacher", "TestAccount14" },
                    { new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"), "", "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", null, "Teacher", "TestAccount13" },
                    { new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"), "", "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", null, "Admin", "TestAccount23" },
                    { new Guid("40772272-1210-4378-98bd-e829841f6b0c"), "", "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", null, "Teacher", "TestAccount12" },
                    { new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"), "", "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", null, "Teacher", "TestAccount10" },
                    { new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"), "", "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", null, "Teacher", "TestAccount9" },
                    { new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"), "", "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", null, "Teacher", "TestAccount8" },
                    { new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"), "", "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", null, "Teacher", "TestAccount7" },
                    { new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"), "", "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", null, "Teacher", "TestAccount6" },
                    { new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"), "", "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", null, "Teacher", "TestAccount5" },
                    { new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"), "", "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", null, "Teacher", "TestAccount4" },
                    { new Guid("f052ae94-ba5a-4197-b978-520328996d6a"), "", "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", null, "Teacher", "TestAccount3" },
                    { new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"), "", "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", null, "Student", "TestAccount49" },
                    { new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), "", "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", null, "Teacher", "TestAccount1" },
                    { new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"), "", "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", null, "Teacher", "TestAccount11" },
                    { new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5"), "", "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", null, "Admin", "TestAccount24" },
                    { new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), "", "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", null, "Teacher", "TestAccount2" },
                    { new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"), "", "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", null, "Admin", "TestAccount26" },
                    { new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"), "", "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", null, "Admin", "TestAccount25" },
                    { new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"), "", "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", null, "Student", "TestAccount47" },
                    { new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"), "", "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", null, "Student", "TestAccount46" },
                    { new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), "", "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", null, "Student", "TestAccount44" },
                    { new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"), "", "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", null, "Student", "TestAccount43" },
                    { new Guid("e768134a-118a-4555-bb9d-060a2b041a85"), "", "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", null, "Student", "TestAccount42" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"), "", "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", null, "Student", "TestAccount41" },
                    { new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), "", "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", null, "Student", "TestAccount40" },
                    { new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"), "", "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", null, "Student", "TestAccount39" },
                    { new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"), "", "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", null, "Student", "TestAccount38" },
                    { new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"), "", "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", null, "Student", "TestAccount37" },
                    { new Guid("d03ec302-9032-4220-ad51-2da905881098"), "", "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", null, "Student", "TestAccount45" },
                    { new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"), "", "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", null, "Student", "TestAccount35" },
                    { new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"), "", "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", null, "Student", "TestAccount36" },
                    { new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"), "", "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", null, "Admin", "TestAccount27" },
                    { new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"), "", "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", null, "Admin", "TestAccount29" },
                    { new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), "", "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", null, "Student", "TestAccount30" },
                    { new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"), "", "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", null, "Admin", "TestAccount28" },
                    { new Guid("4094df26-53da-4e51-aa69-28406bf0e198"), "", "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", null, "Student", "TestAccount32" },
                    { new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"), "", "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", null, "Student", "TestAccount33" },
                    { new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"), "", "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", null, "Student", "TestAccount34" },
                    { new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), "", "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", null, "Student", "TestAccount31" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("f9b9b9d2-45cf-4aeb-9e41-9777c150c0a3"), null, 0L, null },
                    { new Guid("047d5f61-314b-4ce8-b631-64a3a12fb239"), null, 0L, null },
                    { new Guid("c9edf964-f23e-4af9-9182-d91895212bb0"), null, 0L, null },
                    { new Guid("e319e079-aa3a-499a-b7e8-cf6eae5e86cf"), null, 0L, null },
                    { new Guid("3bcebc11-cf9c-45a8-9284-7dea6502f3e3"), null, 0L, null },
                    { new Guid("ba0f286c-3a4e-4068-b18f-72d7a6a628fc"), null, 0L, null },
                    { new Guid("80319172-f1ea-4749-9d24-34867e1f9a37"), null, 0L, null },
                    { new Guid("48cfc7d0-01c2-4610-9f10-ac05c5b27a55"), null, 0L, null },
                    { new Guid("20f78dff-abc9-4f25-8f98-7df665ca8cd5"), null, 0L, null },
                    { new Guid("408d2ca0-ef00-40ab-8ca5-4713ca59bacc"), null, 0L, null },
                    { new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), null, 0L, null },
                    { new Guid("17e755b1-67d3-456b-ab08-9bace8bf1499"), null, 0L, null },
                    { new Guid("f717afa8-85fb-45ca-92ba-3b830a2d90cf"), null, 0L, null },
                    { new Guid("9702f4a0-fe9b-4aae-a9c8-76b84e89559d"), null, 0L, null },
                    { new Guid("a01bb2b0-884a-4a83-af22-ca3a98dcdb3b"), null, 0L, null },
                    { new Guid("70b92c51-d74e-421c-84ad-0490736bcac6"), null, 0L, null },
                    { new Guid("9864d11a-27f4-4ec1-b99e-6b7fcb660ea0"), null, 0L, null },
                    { new Guid("778eb6cf-a35a-40de-9bf0-09a9a8643176"), null, 0L, null },
                    { new Guid("2e135cc3-a5f4-4c8c-bcfe-2a31a04238a2"), null, 0L, null },
                    { new Guid("0e3945a9-3a01-4fd8-86cf-c4c223ebca79"), null, 0L, null },
                    { new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), null, 0L, null },
                    { new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), null, 0L, null },
                    { new Guid("be1fb0b0-b64b-4962-be0f-b2688db42d35"), null, 0L, null },
                    { new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), null, 0L, null },
                    { new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), null, 0L, null },
                    { new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), null, 0L, null },
                    { new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), null, 0L, null },
                    { new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), null, 0L, null },
                    { new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), null, 0L, null },
                    { new Guid("25fecc55-5fdb-462e-80df-52ee2c11e707"), null, 0L, null },
                    { new Guid("fbef0fc7-eec0-4359-bb33-a1481d1598dc"), null, 0L, null },
                    { new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), null, 0L, null },
                    { new Guid("d7d5ee41-0749-47e6-888b-b7745d13fc33"), null, 0L, null },
                    { new Guid("e18e5e04-3fa9-4d5f-a0ff-b46d721a5603"), null, 0L, null },
                    { new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), "Bachelor" },
                    { new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), "Master" }
                });

            migrationBuilder.InsertData(
                table: "StudyLines",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("d0d34ecc-8702-4cca-9e83-22a5b9516cf8"), "English", "EN" },
                    { new Guid("84409672-4042-4ea4-b3d4-4087195b0285"), "Romanian", "RO" },
                    { new Guid("4decf4a7-a414-4896-ad31-c4091dc4e3c2"), "German", "DE" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name", "Rank" },
                values: new object[,]
                {
                    { new Guid("49aa5ee9-482a-415e-be2b-b037e114f394"), "TeacherDegree0", 0 },
                    { new Guid("6e1d2723-921a-46ba-b865-a1216005ee14"), "TeacherDegree1", 0 },
                    { new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf"), "TeacherDegree2", 0 },
                    { new Guid("d819a0ca-3be4-449c-a23e-310e6f871598"), "TeacherDegree3", 0 },
                    { new Guid("edaece06-4188-4df1-aac2-978f30777f6b"), "TeacherDegree4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"),
                    new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"),
                    new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"),
                    new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"),
                    new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"),
                    new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"),
                    new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"),
                    new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"),
                    new Guid("07cfd812-047f-498d-916d-7e847b84140f"),
                    new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"),
                    new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"),
                    new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"),
                    new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"),
                    new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"),
                    new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"),
                    new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"),
                    new Guid("41f342f3-6a25-40c0-b53b-135de297566b"),
                    new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"),
                    new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"),
                    new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"),
                    new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"),
                    new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"),
                    new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"),
                    new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"),
                    new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"),
                    new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"),
                    new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"),
                    new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"),
                    new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"),
                    new Guid("63195d9e-0811-490b-86f6-17855b2c7417"),
                    new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"),
                    new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"),
                    new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"),
                    new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"),
                    new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"),
                    new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"),
                    new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"),
                    new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"),
                    new Guid("a7eec97f-7557-43cb-a304-a4be66956324"),
                    new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"),
                    new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"),
                    new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"),
                    new Guid("648691b9-8bde-47b7-87b2-09ced338434f"),
                    new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"),
                    new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"),
                    new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"),
                    new Guid("e768134a-118a-4555-bb9d-060a2b041a85"),
                    new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"),
                    new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"),
                    new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"),
                    new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"),
                    new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"),
                    new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"),
                    new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"),
                    new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"),
                    new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"),
                    new Guid("4094df26-53da-4e51-aa69-28406bf0e198"),
                    new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"),
                    new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"),
                    new Guid("d03ec302-9032-4220-ad51-2da905881098"),
                    new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"),
                    new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"),
                    new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"),
                    new Guid("7b772708-355b-4a84-8bac-b59464644496"),
                    new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"),
                    new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"),
                    new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"),
                    new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"),
                    new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"),
                    new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"),
                    new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"),
                    new Guid("86108a96-dd24-445b-b8cf-40855961fa35"),
                    new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"),
                    new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"),
                    new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"),
                    new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"),
                    new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"),
                    new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716")
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("f052ae94-ba5a-4197-b978-520328996d6a"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("40772272-1210-4378-98bd-e829841f6b0c"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), "Faculty-1" },
                    { new Guid("8447b48e-a096-41cf-97fc-96ea2de422f2"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), "Faculty-0" },
                    { new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), "Faculty-2" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("c4ab0b70-3408-4fb5-836f-d063f9f2cc6c"), new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), 0L, new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), 0L, new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("b390b62c-e3f5-4201-9675-29dc9e4aea7c"), new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), 0L, new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("67c0d79d-0929-4bdc-b990-853a5b0b4fb9"), new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), 0L, new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("3a888b6f-d997-41c3-b78c-22bc81609a14"), new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), 0L, new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("cb5efdeb-6ffc-4c19-8cca-6ed94ba7c867"), new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), 0L, new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), 0L, new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("548554f6-a9d6-4955-aa27-33966a978f9f"), new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), 0L, new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("2c79988f-6246-4256-bd67-8e11d932a663"), new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), 0L, new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("593b8697-93cf-4382-9071-e912d8162813"), new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), 0L, new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), 0L, new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("80e64474-0e4f-4b0f-bbfd-53e74b7e70cd"), new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), 0L, new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("f4661024-d372-4b26-a528-92971d4026e9"), new Guid("d03ec302-9032-4220-ad51-2da905881098"), 0L, new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("eed65e09-d154-4c59-b3a2-2e79a83eb4e5"), new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), 0L, new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7183038d-3c40-43de-b0c7-aaffd0371527"), new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), 0L, new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), 0L, new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("61638f23-9d32-427d-a0ee-5ecefcb0671e"), new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), 0L, new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), 0L, new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "FacultyId", "Name", "Semesters", "StudyDegreeId", "StudyLineId" },
                values: new object[,]
                {
                    { new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-2", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-3", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-5", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), new Guid("8447b48e-a096-41cf-97fc-96ea2de422f2"), "Specialisation-4", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), "Specialisation-0", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("d0d34ecc-8702-4cca-9e83-22a5b9516cf8") },
                    { new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), "Specialisation-1", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("4decf4a7-a414-4896-ad31-c4091dc4e3c2") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "EndDate", "SpecializationId", "StartDate", "StudentLeaderId" },
                values: new object[,]
                {
                    { new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77"), 1651227795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1619691795L, new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f") },
                    { new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1"), 1651227795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1619691795L, new Guid("7b772708-355b-4a84-8bac-b59464644496") },
                    { new Guid("0b231890-5bfe-4325-834a-38484b483f08"), 1588155795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1556533395L, null },
                    { new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a"), 1619691795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1588155795L, null },
                    { new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3"), 1651227795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1619691795L, new Guid("86108a96-dd24-445b-b8cf-40855961fa35") },
                    { new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764"), 1588155795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1556533395L, null },
                    { new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59"), 1619691795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1588155795L, null },
                    { new Guid("39659841-222b-4029-8bb0-f5922c4b94a4"), 1651227795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1619691795L, new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5") },
                    { new Guid("3088a272-82f1-4091-aa76-9f46999917e9"), 1588155795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1556533395L, null },
                    { new Guid("d3c592b4-135c-4e51-b842-30ff352475a3"), 1619691795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1588155795L, null },
                    { new Guid("ebc64c61-b323-4bed-b776-14813ad9b255"), 1651227795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1619691795L, new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398") },
                    { new Guid("957ec602-b51c-4950-bda8-8f96a489a69c"), 1588155795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1556533395L, null },
                    { new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973"), 1619691795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1588155795L, null },
                    { new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8"), 1651227795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1619691795L, new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d") },
                    { new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999"), 1588155795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1556533395L, null },
                    { new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d"), 1619691795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1588155795L, null },
                    { new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09"), 1619691795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1588155795L, null },
                    { new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb"), 1588155795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1556533395L, null }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("aaf7dac2-2f86-48ff-b01d-e4a686407468"), new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), 1647781930L, new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("e6cecb5d-934b-4d05-8489-2c00318bce1d"), new Guid("48cfc7d0-01c2-4610-9f10-ac05c5b27a55"), 1647781930L, new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("3d66ef22-dfde-41a0-8f8f-8cf1364ad04e"), new Guid("3a888b6f-d997-41c3-b78c-22bc81609a14"), 1647781930L, new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("37faf795-9e3d-4e7e-a86f-813008dcd4e7"), new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), 1647781930L, new Guid("d03ec302-9032-4220-ad51-2da905881098"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("dd352b57-7766-49c9-b001-368415df6dd1"), new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), 1647781930L, new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("b12884d0-e266-4ce0-bc61-c65276e49c43"), new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), 1647781930L, new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("b0595e3b-ca8d-400f-a574-d0ea91d0c5e5"), new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), 1647781930L, new Guid("4094df26-53da-4e51-aa69-28406bf0e198"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("9c77760e-39a5-432b-a750-20863e29afd1"), new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), 1647781930L, new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("af6d5c23-cc01-4712-b88f-aea3ce884347"), new Guid("b390b62c-e3f5-4201-9675-29dc9e4aea7c"), 1647781930L, new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("c2dd13ae-a82d-4f08-a3be-ce053e7bae72"), new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), 1647781930L, new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("c049ff9b-800d-4553-a8b6-ecc25fd8ad31"), new Guid("70b92c51-d74e-421c-84ad-0490736bcac6"), 1647781930L, new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("67b0c287-8404-44a1-a135-e6d91ac1e41d"), new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), 1647781930L, new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("ea8ae582-d1c8-4cf8-ae4f-1dffd7908af5"), new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), 1647781930L, new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("9d8852b5-0a17-4e6d-af84-7763b6fa6ae5"), new Guid("3bcebc11-cf9c-45a8-9284-7dea6502f3e3"), 1647781930L, new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("c4aad5b1-11e4-421f-98cd-bf02c457aebf"), new Guid("778eb6cf-a35a-40de-9bf0-09a9a8643176"), 1647781930L, new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("671fc258-ae33-4336-b98d-6a8fc037c6a6"), new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), 1647781930L, new Guid("63195d9e-0811-490b-86f6-17855b2c7417"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("09c6a7a8-67fc-4fbb-994f-8afbfd8ef743"), new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), 1647781930L, new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("d5d67367-53cd-42a8-8aa0-8b8af28ddfe7"), new Guid("9702f4a0-fe9b-4aae-a9c8-76b84e89559d"), 1647781930L, new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("b4759aa8-7602-4f65-a2c0-37720da32d30"), new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), 1647781930L, new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("d266b1fe-17ba-4ba3-97d2-9eae480ed6ea"), new Guid("2e135cc3-a5f4-4c8c-bcfe-2a31a04238a2"), 1647781930L, new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("a7d32706-059e-4441-b28b-48ee8fc51665"), new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), 1647781930L, new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("0d1773ec-0244-4c09-8b24-b6f34a275ab1"), new Guid("548554f6-a9d6-4955-aa27-33966a978f9f"), 1647781930L, new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("564571ab-193f-4378-90c9-672903298184"), new Guid("e319e079-aa3a-499a-b7e8-cf6eae5e86cf"), 1647781930L, new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("806b0bb5-1532-4505-a6c1-e594b37cf25f"), new Guid("80319172-f1ea-4749-9d24-34867e1f9a37"), 1647781930L, new Guid("41f342f3-6a25-40c0-b53b-135de297566b"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("7b053d1c-38e8-4ab5-9b43-f7792306c45b"), new Guid("2c79988f-6246-4256-bd67-8e11d932a663"), 1647781930L, new Guid("a7eec97f-7557-43cb-a304-a4be66956324"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("9f612ffe-e2b6-46d6-9bb9-366eaf457c31"), new Guid("be1fb0b0-b64b-4962-be0f-b2688db42d35"), 1647781930L, new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("c3b8b274-e846-46f7-83da-b0459eca06a3"), new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), 1647781930L, new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("e1199575-353f-4bf2-9876-dfb2f21897f9"), new Guid("61638f23-9d32-427d-a0ee-5ecefcb0671e"), 1647781930L, new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("26b3ba54-1e49-4807-ac04-3db4651c0b84"), new Guid("d7d5ee41-0749-47e6-888b-b7745d13fc33"), 1647781930L, new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("15c970c3-b25c-4c5c-9836-69ace70bc0ea"), new Guid("c4ab0b70-3408-4fb5-836f-d063f9f2cc6c"), 1647781930L, new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("63094e16-0d70-43ef-b1cb-3237d3c021c8"), new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), 1647781930L, new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("1ec752c6-ebd2-4055-97b5-c0a187970e85"), new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), 1647781930L, new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("90cb5bfb-3beb-4665-8353-a34d7a489a28"), new Guid("a01bb2b0-884a-4a83-af22-ca3a98dcdb3b"), 1647781930L, new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("35e4e51c-503f-4f79-96c6-beb201966917"), new Guid("593b8697-93cf-4382-9071-e912d8162813"), 1647781930L, new Guid("e768134a-118a-4555-bb9d-060a2b041a85"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("2fa6b3b1-ec49-46ed-8b4e-7f670ce94c57"), new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), 1647781930L, new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("0ef4d181-436b-453c-b2a0-8754880dc64a"), new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), 1647781930L, new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("df5c6383-763a-4547-babc-c79ff2bb4339"), new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), 1647781930L, new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("f3375d29-fc29-4af4-aebf-37739f53b91e"), new Guid("408d2ca0-ef00-40ab-8ca5-4713ca59bacc"), 1647781930L, new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("5b56c634-9fb1-466d-8d88-21aa37c9014c"), new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), 1647781930L, new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("3dd4b36d-d662-4b56-8414-1839ae50d322"), new Guid("25fecc55-5fdb-462e-80df-52ee2c11e707"), 1647781930L, new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("b06bc045-696e-439b-a3a6-f1bd84486438"), new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), 1647781930L, new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("243497cd-f91e-4a24-ba6d-cca28bb863ac"), new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), 1647781930L, new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("1d95401d-d844-4cd5-b347-f4502af65bd4"), new Guid("20f78dff-abc9-4f25-8f98-7df665ca8cd5"), 1647781930L, new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("164a13d6-1ab0-42fb-ba23-a83e8e00a74c"), new Guid("e18e5e04-3fa9-4d5f-a0ff-b46d721a5603"), 1647781930L, new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("97aeadf0-e163-4377-9546-17ccd74f8b1d"), new Guid("c9edf964-f23e-4af9-9182-d91895212bb0"), 1647781930L, new Guid("7b772708-355b-4a84-8bac-b59464644496"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("b8996bc3-6078-4952-bf32-a500d62359dd"), new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), 1647781930L, new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("106445cc-e7da-4036-98b3-08b35fb302d6"), new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), 1647781930L, new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("c5e62b9c-3cad-4135-bb8e-334d3759385e"), new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), 1647781930L, new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("7e5eaf80-dc98-4b7f-9051-e2d8a2e06675"), new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), 1647781930L, new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("4d77ba5e-ac5e-4ea9-93dc-4e8a2652cccb"), new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), 1647781930L, new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("b8a0c246-76b3-408d-a80f-aabd51b9ab7f"), new Guid("67c0d79d-0929-4bdc-b990-853a5b0b4fb9"), 1647781930L, new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("3dd8e9f0-1f01-4db9-97d3-a0d5d9de1d9c"), new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), 1647781930L, new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("1025ff84-b64f-46ae-8fa4-41fec6d6f171"), new Guid("80e64474-0e4f-4b0f-bbfd-53e74b7e70cd"), 1647781930L, new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("727238df-9940-4cd5-8602-9dcb7ad6d198"), new Guid("0e3945a9-3a01-4fd8-86cf-c4c223ebca79"), 1647781930L, new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("826f93e5-3cdb-407b-a4d9-79f220dce519"), new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), 1647781930L, new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"), new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("9d6e111f-c05a-4cf3-97b5-17419684539b"), new Guid("593b8697-93cf-4382-9071-e912d8162813"), 1647781930L, new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("3a0cb163-5dff-4a4c-a84c-37ec5a5e551f"), new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), 1647781930L, new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("b2009ddc-83ea-493f-b9a0-597c3cce4f06"), new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), 1647781930L, new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("afebc5f8-a94a-413c-b8ca-2ccb9acae24c"), new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), 1647781930L, new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("73578850-5c75-475b-a4b0-80d8b9d5f7c3"), new Guid("cb5efdeb-6ffc-4c19-8cca-6ed94ba7c867"), 1647781930L, new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("a7a4a539-47b6-469d-9fb1-09ab2b6c0b2f"), new Guid("9864d11a-27f4-4ec1-b99e-6b7fcb660ea0"), 1647781930L, new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("0c0fad3c-7f67-483c-ba2c-2e27137cb54d"), new Guid("047d5f61-314b-4ce8-b631-64a3a12fb239"), 1647781930L, new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("0ce7c9a3-e212-4996-872b-79d97f150010"), new Guid("eed65e09-d154-4c59-b3a2-2e79a83eb4e5"), 1647781930L, new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("70d8e9fa-fea1-4e94-8a8c-b69f2b1fa1d2"), new Guid("7183038d-3c40-43de-b0c7-aaffd0371527"), 1647781930L, new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("d7cbdd5c-ad78-4cb6-9983-4253a09fdd53"), new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), 1647781930L, new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"), new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("fbc3c21b-9566-4921-b79e-e8355d8489a4"), new Guid("f717afa8-85fb-45ca-92ba-3b830a2d90cf"), 1647781930L, new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("4ea51a45-d354-485d-aca7-696993b47ea7"), new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), 1647781930L, new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"), new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("5c37b51d-a1c9-4441-8245-78d16a149b89"), new Guid("f9b9b9d2-45cf-4aeb-9e41-9777c150c0a3"), 1647781930L, new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("1e16dc4a-08bf-48d1-ae9d-9e6e9436bbf4"), new Guid("17e755b1-67d3-456b-ab08-9bace8bf1499"), 1647781930L, new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"), new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("23c227b7-08b2-40f7-904a-ed5d7b994cbf"), new Guid("ba0f286c-3a4e-4068-b18f-72d7a6a628fc"), 1647781930L, new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("664fe71c-7d81-45c4-98da-c7213e6f919b"), new Guid("fbef0fc7-eec0-4359-bb33-a1481d1598dc"), 1647781930L, new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("7429d0f1-1c3f-4ff6-999e-48f46225ad56"), new Guid("f4661024-d372-4b26-a528-92971d4026e9"), 1647781930L, new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), (short)2, new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), (short)1, new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), (short)2, new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("28166599-9455-408b-a091-0cf8f68b9793"), (short)1, new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), (short)1, new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), (short)2, new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), (short)2, new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), (short)1, new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), (short)1, new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), (short)2, new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), (short)1, new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), (short)2, new Guid("3088a272-82f1-4091-aa76-9f46999917e9") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), (short)1, new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), (short)1, new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), (short)2, new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), (short)1, new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), (short)1, new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), (short)2, new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("87b77344-a316-4c77-99f9-41250addcd61"), (short)1, new Guid("957ec602-b51c-4950-bda8-8f96a489a69c") },
                    { new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), (short)2, new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), (short)2, new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), (short)1, new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), (short)1, new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), (short)1, new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), (short)2, new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), (short)2, new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), (short)2, new Guid("957ec602-b51c-4950-bda8-8f96a489a69c") },
                    { new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), (short)2, new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), (short)1, new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), (short)2, new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), (short)1, new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), (short)2, new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), (short)2, new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), (short)1, new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), (short)1, new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), (short)2, new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("0def7447-32ab-481d-9cf1-905d6c413961"), (short)4, "Course0", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("65765cd5-1582-492a-b53f-49349b9218e8"), (short)0, "Course14", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("a8e0b5c4-090f-4aab-9951-cff898f7575e"), (short)4, "Course0", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("b63c575e-484f-427b-b7e3-6ba84485d18a"), (short)5, "Course24", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("4214734c-053b-4952-ab0d-1cc19cb5725c"), (short)5, "Course48", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("b1345efc-68ca-49a9-89ea-593ccc55aa07"), (short)2, "Course72", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d597dd18-4f63-4305-920f-c2bda5c91987"), (short)0, "Course96", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("31ec2bf3-5ea2-48ca-bda6-00df1752c459"), (short)2, "Course120", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("b4327c3e-e556-4e4a-85b0-399717ecd13c"), (short)5, "Course7", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d1ef545e-9359-4a51-985d-beb69155394d"), (short)3, "Course0", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("0fd73b51-ea34-4293-ae09-5bd769d75db1"), (short)3, "Course0", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("ae91d3c0-be86-4fb9-912d-1b2d4be55fa1"), (short)1, "Course25", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("eaf26294-24f7-47fb-ba3a-17cfd471fb41"), (short)0, "Course50", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("0b8f860c-09f2-456b-8d10-3b9c535968f2"), (short)5, "Course75", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("54a2b5f0-b301-46fc-9d94-2d595631046b"), (short)2, "Course100", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("33d528b2-1f9f-4fd2-a475-43a9e19553ea"), (short)3, "Course125", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("05a72e88-13d0-44f5-a02a-6ceae6d360b0"), (short)1, "Course0", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("453c38c1-b666-4042-8b7f-4fcbbf2897d2"), (short)3, "Course26", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("a7239024-00e6-4316-bed6-b61dd82f3abe"), (short)2, "Course52", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("4dc0f244-f847-4d76-ba87-88d77bbb8ad5"), (short)0, "Course78", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("b476a873-175b-4b8f-9601-b4cbd56a3ef5"), (short)5, "Course104", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("ee5ed2c5-829d-408e-8202-cf5d00f707b3"), (short)1, "Course130", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("4754999d-928e-4674-942e-fe5eae131715"), (short)1, "Course30", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("6443dc44-96d0-4e81-9521-839c0dd04dc3"), (short)4, "Course24", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("7c87761f-40fa-4e4f-9fa2-4bfa499f558e"), (short)1, "Course21", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d92e4ba2-8f81-487d-ad6f-42596f338c63"), (short)5, "Course175", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("bcb64f7b-2cc3-4262-b5e6-76cf92fcd077"), (short)2, "Course140", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("0b65dcb2-d615-4011-a9ad-e8ba62f677f5"), (short)2, "Course105", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("548bef49-da4a-4a4e-9f06-4d9f2bde5292"), (short)4, "Course32", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("aebc75a8-3d65-4a69-b6a6-ff3eb0756184"), (short)1, "Course16", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("51b49d9e-a556-4ff8-9b3f-1dad07146617"), (short)5, "Course96", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("5c53dc4a-b4a3-4469-a19a-4238a1cab25b"), (short)3, "Course128", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("8f9efc74-828c-4d0a-a187-850498c5475a"), (short)3, "Course160", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("0ab456d9-32e5-46a0-b082-aca1f6423406"), (short)1, "Course8", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("0fc679c6-bb5a-4522-976d-6b2552a47e45"), (short)2, "Course0", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("1e19c66e-4f3b-47fb-8c03-01d060c79a29"), (short)2, "Course0", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("09a89b6a-8911-4972-bf2f-3c108694b318"), (short)4, "Course33", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("089f8bb8-6cd8-4317-b21b-421676fade89"), (short)5, "Course66", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("8fc85435-545e-4bef-adee-3cbe60ab3f8c"), (short)1, "Course99", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("c74503f2-dd2c-47b3-b403-0810836ca7c5"), (short)1, "Course0", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("3ba59efa-f9b3-4234-b916-1c4bf446d695"), (short)3, "Course132", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d158eef7-afd3-40d2-8390-7974d05d22e4"), (short)5, "Course0", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("e178705c-b7cc-477b-aedb-2cfc2080f968"), (short)5, "Course34", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("c16dcd0d-05ab-4547-bc41-1d804d41127c"), (short)5, "Course68", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d81b35b2-171e-4c54-89e9-3ca22557cc97"), (short)1, "Course102", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("c3a79417-95eb-4129-88ba-80cc77f80fc3"), (short)5, "Course136", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("065edf2f-6413-4176-bcaf-f9ce7440928b"), (short)0, "Course170", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("424326da-4c8c-4da0-b6aa-413f24b1a99e"), (short)3, "Course35", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("34ae4e00-42fc-4315-946f-30f63f2f140e"), (short)0, "Course28", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("c9b4b379-8414-4cfe-ae75-37b8ad43792a"), (short)4, "Course0", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("df309229-7cf8-4d4b-bb58-cc02d9b1594e"), (short)3, "Course35", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("3c6eadc8-27d5-40cf-9091-fc0e6bb58831"), (short)1, "Course70", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("7b0e6109-0877-4963-8140-9de2f1fed68e"), (short)1, "Course165", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("f72ab8d4-6fd7-48de-bfae-70d2de058289"), (short)5, "Course27", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("90fff920-f735-4a48-8c3d-3a956e2c093a"), (short)3, "Course54", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("d8fdc01a-1dcf-4436-9789-2bfa7a7147be"), (short)2, "Course81", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("2bff610d-7698-4e6f-85c8-780d6c2bdb6e"), (short)5, "Course2", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d80c0883-05e1-4620-8025-ddc0ad9e458d"), (short)1, "Course3", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("e1a562d5-a9aa-4cdd-962c-b2c9132c500d"), (short)0, "Course4", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("528a1696-2147-4739-9749-52625e4a20e9"), (short)0, "Course5", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("a5c2031b-f6e7-4820-9c29-00985df9fc9b"), (short)0, "Course15", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("0bb57faf-198d-40f4-959c-ce5f5ea7d4a6"), (short)1, "Course10", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("5e855979-45dc-4ee2-b65e-470d2c754573"), (short)4, "Course0", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("e7575089-9108-4aa0-9645-4a100df0d180"), (short)5, "Course2", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("7eaf0e66-aa29-4054-a6f3-c86470920fec"), (short)4, "Course4", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("a39fa61b-0280-408e-b7ed-aa8022125908"), (short)1, "Course6", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("b433fc46-a0b1-4734-9316-5b0f18103c56"), (short)4, "Course8", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("717f38ac-8611-43ef-b38b-4c930c334913"), (short)4, "Course1", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("422d7d77-cc1e-4748-8a11-22953b8ee104"), (short)5, "Course10", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("4b1dcb4d-28d6-4a18-903c-3352361c8c84"), (short)4, "Course0", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("1afbf401-7aad-4f01-ae35-ed9b077c5759"), (short)2, "Course0", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("81b4e5b8-0edb-4fa9-aff0-8cb5999d03e5"), (short)5, "Course3", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("3ebae0fd-3df7-4f7f-80eb-5a77d16666f0"), (short)0, "Course6", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("e30d25f4-c1dd-484d-8710-01adc54f8b46"), (short)4, "Course9", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("1ea77f73-81de-472b-9504-0077dc4959b1"), (short)4, "Course12", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("a5ed0983-ac56-4159-ab33-c32c1de47135"), (short)2, "Course15", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("35f18927-31b2-4935-ab60-61f8b07a6f44"), (short)4, "Course0", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("e5fbbed4-b099-480b-aaa6-142475eba9ec"), (short)4, "Course4", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("c7e7f8e0-3e0a-4983-95b2-2fd554224cda"), (short)0, "Course8", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("5389ff5e-c63c-4c1e-ad17-856e9e409b44"), (short)5, "Course12", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("66bb1f46-f3e4-4734-83ed-05e3438c4af9"), (short)5, "Course5", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("3040d948-3aa7-47c0-bd73-65eeb32187cf"), (short)4, "Course0", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("2937aa60-a1b7-453a-ad92-c2a66035d031"), (short)2, "Course0", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("7d421257-7152-4378-affa-ef1121075c3b"), (short)4, "Course25", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("c4c64407-c5b8-4e96-9520-813699fe5d69"), (short)3, "Course108", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("b6f78356-8f44-4d0e-b9c5-6c27a5e40294"), (short)2, "Course135", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("35f70554-0234-4cb5-b160-64d8455781f2"), (short)4, "Course18", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("0cc4a65a-684b-42f9-a050-3379c05f63d5"), (short)2, "Course12", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b28041dc-750d-45ab-8f8d-e831c155d282"), (short)5, "Course0", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("ec38080e-8ed7-4282-ba63-968c122763fb"), (short)3, "Course28", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("88bb07fa-cea9-41a8-a95c-9fc8ca790e36"), (short)3, "Course56", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("8fee1121-1080-4e02-b4b3-bc67b031ffeb"), (short)4, "Course84", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("db684a1b-2eef-463e-85b1-17db42347f7f"), (short)3, "Course112", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("b89e2936-7b9b-44a9-8282-94854c298945"), (short)4, "Course140", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("803b0b73-b411-4a08-970d-41d9bc228698"), (short)4, "Course6", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("4a5209f5-afc2-48a1-a39a-dd22003a68f6"), (short)2, "Course20", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("60ee9bd0-d4d5-46ad-a7ac-2c5a20551a8d"), (short)5, "Course0", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("b0a97486-71d9-41b2-80b4-d2c53ecf6569"), (short)3, "Course29", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("115a9056-7522-4b55-a51a-bae84e954991"), (short)2, "Course58", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("3417176e-cc64-4e64-8f03-3b2a74bf93f7"), (short)2, "Course87", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("242bf2e8-a913-4445-85b0-26822a2f51de"), (short)0, "Course116", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("68ae9ea0-06bb-44d9-a164-5684d2fb0cc2"), (short)5, "Course145", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("1b43296f-6e96-486a-9c7e-983a57a769b1"), (short)0, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("f292d0a9-bac5-4389-9880-0fcb6fca63f3"), (short)0, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("8c70c666-e382-418c-a8fb-50e221f72f69"), (short)3, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("4f37e225-4a3b-424b-805f-361967b267bc"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("cea45bc0-ed63-4cec-b0bc-833f1cdeb955"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("c6c8141b-cddf-4ba5-a3e6-13c2ed1e0607"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("8977cf09-b01d-4a90-b816-91add9e90d55"), (short)1, "Course0", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("2d613563-3022-4684-9471-ce43baacc5a1"), (short)5, "Course16", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("c2c8651a-67c5-4c5c-a004-ee7af5b5bb99"), (short)4, "Course64", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("293249b5-3966-4341-82a6-e90dd651e8c1"), (short)5, "Course155", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("9a97c2fe-d7b0-4d21-af10-eeacd6078f95"), (short)1, "Course0", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("c8505dff-4f7e-4fb2-b424-9dfc59738289"), (short)2, "Course16", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("74d45fd0-4832-4b94-8ac1-6f9e4cf92682"), (short)4, "Course32", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("191fca39-580a-466f-b5b6-ac103aa0ef64"), (short)2, "Course48", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("44e1c1c2-fefe-4180-a475-0e952bbd4935"), (short)3, "Course64", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("60ce6b92-62d6-40dc-aa79-21c6fbe29c20"), (short)1, "Course80", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d540bf69-f1ea-450b-a8cb-35413bfbea7e"), (short)3, "Course50", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("8d6be354-36e9-4786-aaf5-b4b7ba0b98b5"), (short)3, "Course40", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("23419b05-88e4-4273-8792-51e47bf97ee5"), (short)5, "Course0", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("da5c125f-43e2-4431-a7ce-708eed2aad5e"), (short)0, "Course17", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("75994679-d556-4daf-b772-f2d34cda4d9d"), (short)0, "Course34", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("f223cf52-8bc7-4b9f-adea-f66b9fd20f06"), (short)3, "Course75", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("9a3772b1-0ef2-4e05-93e6-8877ec655810"), (short)5, "Course51", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("f81b81e2-0be6-4650-b3e6-d27d10f39a5a"), (short)0, "Course85", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("e2bdf5c3-d0e1-448e-af9d-f444631d0f13"), (short)3, "Course30", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("27a3d3f2-4849-401c-98fb-dd1723666c86"), (short)5, "Course20", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d16e7e47-ee86-42cb-8ef6-6297c1d545d8"), (short)3, "Course0", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("315807bc-3432-4fcd-9149-9d9fe41f5d7c"), (short)3, "Course18", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("a4071214-3d7e-48d7-a49a-9dcea44f55ad"), (short)3, "Course36", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("024bf998-be1a-4bf9-9b91-0253ed48ad9a"), (short)2, "Course54", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("0cc1e0f3-6542-494c-80e8-baefb5c7373b"), (short)5, "Course72", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f6ad26c5-55f4-4ed6-a20f-4ab41134bd92"), (short)3, "Course90", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("60bd24ad-daea-4719-ae80-3e25bdd7ca45"), (short)4, "Course24", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("d165987a-db36-422c-af60-a3091e70df43"), (short)1, "Course0", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("17ef7042-9506-4eba-9e26-4d4365ad4d99"), (short)5, "Course68", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("22bee928-00a4-4e3f-acd7-1379763a225b"), (short)3, "Course60", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("6701641c-b3ee-47df-b14e-0428d98a9555"), (short)0, "Course45", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("f5daee95-034a-46a4-9b3f-f69df388168f"), (short)1, "Course30", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("bd7239f2-1ce1-4f91-8116-7ff96c04efbc"), (short)1, "Course12", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("15a29671-68dd-4fc5-9b83-75341f269ea1"), (short)3, "Course24", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("2c2c6778-a099-498a-8c84-aa0865e05308"), (short)3, "Course36", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d6d5abe9-9b2e-43fa-bbf0-7e1d6810bdc5"), (short)3, "Course48", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("11aa98ed-89f4-45ca-b22f-b48ca68f2cd7"), (short)1, "Course60", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b62b1cc8-f11a-4e8d-950c-e4ac193abd04"), (short)2, "Course55", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("0aa934d3-b028-41a8-aa70-e2c67e4c03ae"), (short)3, "Course44", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c40c9fa0-fa36-49e3-81b5-56c1f6c79f8e"), (short)1, "Course0", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("ce538069-a9d7-48c3-ad21-09c1a308a520"), (short)3, "Course13", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("4c777b80-aadf-45c1-abb9-aeedd4962dd5"), (short)3, "Course26", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("d12e37e1-ba4c-48f9-85ad-7b46acee01b4"), (short)2, "Course39", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("90ed04d8-c821-44a1-9aab-f4383bad0405"), (short)3, "Course52", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("6da5dc3c-3fbb-4806-9fd2-063e16bc7ddc"), (short)2, "Course65", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("cc15bf79-018b-401e-95ed-35caa753014a"), (short)2, "Course33", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("1ce2306f-7ece-4b2c-b4c6-e3bc7c8cfed3"), (short)4, "Course22", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("e6fd24fa-7956-4a16-ae0c-f067e9a2c3f0"), (short)1, "Course0", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("d6e7ddc5-d2aa-4563-a52e-0d8f1bd0cbce"), (short)5, "Course14", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("40317028-fb37-40fd-90eb-03b1a71eae7a"), (short)2, "Course28", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("1551cb8c-235c-4b26-8e80-67d823c149ed"), (short)0, "Course42", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("74c6230c-7dcb-40aa-b3f5-bea32df93899"), (short)4, "Course56", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("cac47508-4e1f-40da-a5c4-3d64a1ca3e22"), (short)3, "Course70", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("37efb670-d868-4047-b738-763decf11cb2"), (short)0, "Course11", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("e6f97912-82eb-4561-8e10-8ac2d7961f83"), (short)4, "Course0", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("97cad48f-99b2-4608-93d4-8cc6baae0a9b"), (short)2, "Course0", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("0cbfedca-dd07-40a3-9c0e-56f5ab9c9a51"), (short)4, "Course15", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("7b948248-f556-4051-86f0-d4bccb42afdf"), (short)3, "Course0", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("da20a8b6-f692-4d50-a9bb-df79a53462a2"), (short)5, "Course19", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("75b8c4da-3045-42e6-a868-6ea7a4028a9f"), (short)3, "Course10", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("1881121c-5ec1-4e72-9d15-26006165f151"), (short)1, "Course57", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("4e164eae-9520-425c-a6cf-d36102ad8b27"), (short)1, "Course88", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("de9796d7-bfc3-478a-b205-e32b1514ab7a"), (short)0, "Course110", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("fd09a277-82b2-44bc-aff3-accb4a275f4e"), (short)1, "Course9", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("04f01d38-50e5-4f6c-982c-1a4fba9d6c3d"), (short)0, "Course0", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("620c593b-683d-46bd-9505-8168df2abc4e"), (short)5, "Course0", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("c4bf5503-1a25-44ef-9953-e71dae893ff5"), (short)5, "Course23", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("0f3d5b5c-db25-4265-987c-d95ad43df64e"), (short)0, "Course46", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("85f3e497-270c-4885-b21a-0bf602cd1679"), (short)3, "Course69", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("16677d5b-00b9-4de7-ba4e-fe830c37addd"), (short)1, "Course92", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("48bdbf65-a9a8-4328-b925-959c6f1ee077"), (short)2, "Course115", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("6440e233-88b7-47bc-be24-2029b56cfae9"), (short)5, "Course0", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("ad8643e2-4e85-4536-8230-141aa46213a9"), (short)4, "Course30", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7262b2c9-396e-43b4-b2ec-6debf147d93c"), (short)1, "Course60", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("454ece4f-796b-4961-a808-d2e353c4afe4"), (short)0, "Course90", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("4f23415f-f74b-46bb-bee9-2bd5bec67514"), (short)1, "Course120", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("57ff5424-0587-4813-a110-6c4c3ea3fc81"), (short)3, "Course150", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("c0163e6b-e686-4644-8480-61ddc362cf27"), (short)5, "Course40", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("8863fff2-6388-4711-b919-a6c4d0cb0975"), (short)3, "Course32", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("c092ad42-57f9-4ac0-86b4-acba4feb6fae"), (short)1, "Course0", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("a4fbd99d-bda4-419a-85a9-8a0068fe6881"), (short)4, "Course31", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("f9e6f9a6-68d7-46af-95b1-0c22fe1e0476"), (short)4, "Course62", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("c359f80a-df41-4a34-ba83-3f35fe5a2a84"), (short)1, "Course93", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("938a64c5-7572-4e61-8cd8-77053377d6b6"), (short)3, "Course124", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("cdcbab77-269e-471f-b914-8a6280bdcdcf"), (short)0, "Course38", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("e1304a75-83d6-4430-8d04-f67fa28d5599"), (short)0, "Course44", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("a35d4345-3d4e-441c-b461-bb70dbb81c2a"), (short)4, "Course66", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("1b9d976f-6b48-4711-b32f-b31deb152a5d"), (short)0, "Course20", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("15fb3f6c-c025-4531-bdea-40b803e6560a"), (short)1, "Course40", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("2a49f6ca-9448-4a17-bb51-6f78f0cf8bc9"), (short)1, "Course60", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("de6d058d-3320-456c-b766-4dd30ebeb4af"), (short)4, "Course80", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("6d4a36ac-6c7b-4fcb-9fc9-491f83ec4ff8"), (short)2, "Course100", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("197b4d87-1a6e-4381-a848-e5323ae47869"), (short)2, "Course45", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("e5dd9947-42a7-446a-965c-34dd966f6361"), (short)4, "Course22", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("fe45f3b9-e566-4b37-9fce-7943e4345d16"), (short)1, "Course36", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("cc235b05-a11f-4b95-9865-f9f2a9dc60c3"), (short)5, "Course20", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("fc314fed-2892-4230-9d1b-ebedae42284e"), (short)2, "Course21", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("7d6446fa-457d-40b0-beaf-149028b03227"), (short)5, "Course0", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("2380a6a9-91f6-42e4-b062-06cc2753dcb6"), (short)0, "Course63", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("c9c4ed44-1ad1-4216-9f00-9e85522e1d70"), (short)3, "Course84", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("3cb31a5c-fc0d-43b6-beab-40b5e73d7dd2"), (short)3, "Course105", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("a83d7f35-54ff-4683-8931-d3a30596a72d"), (short)4, "Course27", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("99fa7775-b6fe-41f6-bd2b-650e8d1f3f42"), (short)3, "Course95", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("227ef423-560c-436e-b6ef-c56e1a3bdaa0"), (short)1, "Course18", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("116cf99f-1472-45b3-9cb6-f7a9bb3575f3"), (short)0, "Course0", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("9802b0cf-477e-41b1-b8f5-9e25987b2ed0"), (short)2, "Course76", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("70a795a1-230c-486d-955a-8fed07758397"), (short)0, "Course42", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("62d1a5b0-f3b1-4e52-aefc-d97feaed5533"), (short)5, "Course0", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("bb407ab4-cb82-416d-9154-2e9b109eeac8"), (short)5, 20, "Course0", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("f9467108-a973-4ed5-a0a2-02647dcbd607"), (short)0, 20, "Course0", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("b89b5130-0c22-4ca8-aa63-4e2ec3b59413"), (short)5, 20, "Course4", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("36318065-6873-4e75-a0f8-a8b802536f9e"), (short)4, 20, "Course9", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f2d7ffc1-b4f1-44ec-9ae3-a3bf50bdc7db"), (short)3, 20, "Course0", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b91d2ebe-053e-4a37-b288-2208ae367415"), (short)5, 20, "Course6", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("f808cd74-8b25-4424-a0f8-bd039cfe87f8"), (short)2, 20, "Course7", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("70706b38-d838-4e94-be1f-d3e9f93af540"), (short)4, 20, "Course0", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("329c4560-62ee-47af-abb6-7607dd7ae35a"), (short)2, 20, "Course8", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("a8853243-fbb4-4330-907b-502b1f1dd5f7"), (short)3, 20, "Course5", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d92e2779-e05d-4ef1-b897-bfb06a84a5e0"), (short)4, 20, "Course0", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("c96bdb7e-82fa-4ae6-8935-734b5d215a01"), (short)2, 20, "Course10", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("8be9964f-a67b-4780-9337-60ec615cad11"), (short)3, 20, "Course0", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("a861da02-f184-44b8-9f46-7953a0ac65cc"), (short)4, 20, "Course0", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("e14de5bf-9f22-476b-a5f3-252a7f92a5db"), (short)2, 20, "Course35", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c9f53e2a-46b9-46eb-9733-632aa99fdce1"), (short)1, 20, "Course0", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("a0f1a828-f6f9-4153-baf5-7398ddb2b6e4"), (short)3, 20, "Course0", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("2515d430-d1e0-4e5f-a43c-eeaa48a0c45a"), (short)0, 20, "Course23", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("179faa55-0ef8-47fe-8124-11c476568074"), (short)0, 20, "Course0", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("664ed1b7-56e4-414d-871c-3146df861285"), (short)5, 20, "Course22", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("bc47feb8-897c-48c5-9511-5e9c17634523"), (short)5, 20, "Course0", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("5c0ec2a8-5b1a-4dbe-a60f-9a9c3b8bf1c7"), (short)4, 20, "Course21", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("80fb9c08-f388-4d50-a6cf-c0ff76453384"), (short)5, 20, "Course0", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f283b969-31b6-4538-b23d-4696059bc167"), (short)1, 20, "Course20", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("1f6c8d33-06dd-42e0-a446-0b21eb8f084c"), (short)0, 20, "Course0", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("ebd9e833-97de-4518-937c-0ce20e8de5fb"), (short)5, 20, "Course19", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c4522fec-2a4f-4efc-901f-773ffc45286c"), (short)0, 20, "Course0", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("a7b5c435-b5fa-4329-b60a-80f423aa0c2f"), (short)5, 20, "Course18", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("ba16951d-c886-4adf-9179-e7a027011c4f"), (short)4, 20, "Course0", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("84dd3636-2cc7-40d9-877a-024f322b7ec2"), (short)0, 20, "Course17", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("2eb6f8a9-3c01-4a96-94e4-71f7703c011e"), (short)4, 20, "Course0", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("06540d95-2cd7-4321-963a-49241028ee2d"), (short)3, 20, "Course16", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("cf744660-3809-428a-865a-21c1a29e481c"), (short)5, 20, "Course0", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("264d085b-53bb-4bb8-bd70-f207c8829b30"), (short)1, 20, "Course15", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("d4d4684d-8836-4b11-b0cc-86c979f4b8fc"), (short)3, 20, "Course0", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("4fd9fcbb-267e-4fbb-99f7-dd18d2aa9786"), (short)4, 20, "Course14", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("54308ae4-64eb-4e66-8436-22e93815c895"), (short)5, 20, "Course0", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("488bed48-4362-4cd5-98c3-a69f19faf517"), (short)3, 20, "Course13", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7a9150b9-1b06-469d-9fc5-70066bec3bbe"), (short)0, 20, "Course0", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("ef25218d-6606-4f4a-89c0-5728995f65ce"), (short)1, 20, "Course12", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("5a008051-73f4-4c96-96a0-cce72d98b0dc"), (short)3, 20, "Course0", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("1171290a-7d87-4cdc-8fdf-023922986557"), (short)4, 20, "Course30", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("946abd82-4c56-485a-a2a0-ce79c60691bb"), (short)0, 20, "Course3", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("6853d5d7-63cc-4d44-947d-b457b30ba469"), (short)2, 20, "Course0", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("aad38d29-7bf5-4d61-b7be-bf048da0d42f"), (short)4, 20, "Course0", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("bb896fcd-a9c3-4b52-9064-c390e47b51d0"), (short)3, 20, "Course2", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("0299b5a4-08d1-4d38-8877-ff0aac1d1521"), (short)3, 20, "Course0", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("1b01561d-2848-4f55-b7a4-13fe8f24ed27"), (short)5, 20, "Course1", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("5e85550e-e19a-4510-b84d-953e8fad4850"), (short)0, 20, "Course0", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("c69e2f5e-55ef-457d-ba06-668b33f63164"), (short)0, 20, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("3714923f-cf5b-4b87-a682-9bfa3045e16a"), (short)1, 20, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("47821439-2ef5-4725-be2c-b9dd7575e163"), (short)3, 20, "Course29", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("a8333c09-7c9d-4a39-81c5-2754d5d3048e"), (short)4, 20, "Course0", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("5447ae2f-9185-4308-bfde-36273a7dd637"), (short)3, 20, "Course28", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("dbe17214-3bda-4587-8fbc-1926f069d559"), (short)1, 20, "Course0", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("b981f528-f3e8-48d6-9bad-db3deb6d777e"), (short)0, 20, "Course27", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d5fb859b-a927-4286-85d9-27c018471b98"), (short)4, 20, "Course0", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("c952e1ae-0f88-4625-b7df-58fb5a603b44"), (short)4, 20, "Course26", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("c703a972-f923-472a-a567-1f4c7b861ee2"), (short)0, 20, "Course0", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("e5db6af0-b51e-4ad8-8246-08b2091b3f23"), (short)4, 20, "Course25", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("47489b22-bd13-4672-9d1f-b2419ffb410b"), (short)1, 20, "Course0", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("b848ccd2-abbf-42f3-aba7-2578bc7299ac"), (short)1, 20, "Course24", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("0cb83019-99a3-4b9e-b0db-ee5aa33b885b"), (short)5, 20, "Course0", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("55f8ddc3-242c-4877-a565-acdc6df6f1ec"), (short)4, 20, "Course0", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("246bb696-32a4-46af-bfda-e15b320c0dd6"), (short)2, 20, "Course0", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("78c9cc13-1672-44cc-b8a5-7d9d44bf810c"), (short)1, 20, "Course34", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("04f0e0bc-0b49-44c9-80ca-c7f8ad740069"), (short)3, 20, "Course0", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("e3dce969-3138-491f-8c35-d8edb4fe0830"), (short)2, 20, "Course33", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("4fca6fc0-21e0-4bd8-9b80-5c9714ba0492"), (short)0, 20, "Course0", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("059bf253-2319-4dd1-b165-a4f657f9e701"), (short)4, 20, "Course32", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("8481d187-91d9-4867-8e4a-05ea555b8888"), (short)1, 20, "Course31", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("ce6ca2e8-9f5a-4031-9ae8-1abb969b3a7f"), (short)3, 20, "Course11", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") }
                });
        }
    }
}
