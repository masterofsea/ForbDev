using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forbex.Migrations
{
    public partial class DomainModelCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ifts",
                table: "Contracts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContractNumber",
                table: "Contracts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Contracts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractState",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DocumentsStorage",
                table: "Contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturnableCopy",
                table: "Contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeaseEndDate",
                table: "Contracts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeaseTerm",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LesseeId",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MailContractId",
                table: "Contracts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MonthlyActs",
                table: "Contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PartnerId",
                table: "Contracts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentForm",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Penalty",
                table: "Contracts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price1",
                table: "Contracts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price2",
                table: "Contracts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Receipt",
                table: "Contracts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RegistrationType",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Correspondences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderName = table.Column<string>(type: "text", nullable: false),
                    ReceiverName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ReceivingAddress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    ShortName = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    AdditionalContacts = table.Column<string>(type: "text", nullable: false),
                    ContactName = table.Column<string>(type: "text", nullable: false),
                    ContactNamePosition = table.Column<string>(type: "text", nullable: false),
                    Inn = table.Column<string>(type: "text", nullable: false),
                    Bank = table.Column<string>(type: "text", nullable: false),
                    Bic = table.Column<string>(type: "text", nullable: false),
                    Ogrn = table.Column<string>(type: "text", nullable: false),
                    Kpp = table.Column<string>(type: "text", nullable: false),
                    CheckingAccount = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MailContractNumber = table.Column<string>(type: "text", nullable: false),
                    ConclusionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LeaseBeginDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LeaseEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LeaseTerm = table.Column<int>(type: "integer", nullable: false),
                    HasProxy = table.Column<bool>(type: "boolean", nullable: false),
                    Price1 = table.Column<decimal>(type: "numeric", nullable: false),
                    Price2 = table.Column<decimal>(type: "numeric", nullable: false),
                    ControlDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Responsible = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailContracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    ContactName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LesseeId",
                table: "Contracts",
                column: "LesseeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_MailContractId",
                table: "Contracts",
                column: "MailContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PartnerId",
                table: "Contracts",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Lessees_LesseeId",
                table: "Contracts",
                column: "LesseeId",
                principalTable: "Lessees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_MailContracts_MailContractId",
                table: "Contracts",
                column: "MailContractId",
                principalTable: "MailContracts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Partners_PartnerId",
                table: "Contracts",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Lessees_LesseeId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_MailContracts_MailContractId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Partners_PartnerId",
                table: "Contracts");

            migrationBuilder.DropTable(
                name: "Correspondences");

            migrationBuilder.DropTable(
                name: "Lessees");

            migrationBuilder.DropTable(
                name: "MailContracts");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_LesseeId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_MailContractId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_PartnerId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ContractState",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "DocumentsStorage",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "IsReturnableCopy",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LeaseEndDate",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LeaseTerm",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LesseeId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "MailContractId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "MonthlyActs",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "PaymentForm",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Penalty",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Price1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Price2",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Receipt",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "RegistrationType",
                table: "Contracts");

            migrationBuilder.AlterColumn<string>(
                name: "Ifts",
                table: "Contracts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ContractNumber",
                table: "Contracts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Contracts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
