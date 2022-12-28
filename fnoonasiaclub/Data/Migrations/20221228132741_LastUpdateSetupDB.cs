using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fnoonasiaclub.Data.Migrations
{
    public partial class LastUpdateSetupDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "AddAnotherGame",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cellphone",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cellphone2",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DateBirth",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Datetime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DurationAnotherGame",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DurationMonth",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Game",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GuardianWork",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Identification",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageTransfer",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.AddColumn<string>(
                name: "NameA",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AladaNadiWaiting");

            migrationBuilder.DropTable(
                name: "Alhwodor");

            migrationBuilder.DropTable(
                name: "Almosthdmeen");

            migrationBuilder.DropTable(
                name: "HarkatAadaWaiting");

            migrationBuilder.DropTable(
                name: "ShehdatEtehad");

            migrationBuilder.DropTable(
                name: "Tb_Advert");

            migrationBuilder.DropTable(
                name: "Tb_AdvertDetails");

            migrationBuilder.DropTable(
                name: "Tb_Belt");

            migrationBuilder.DropTable(
                name: "TB_class");

            migrationBuilder.DropTable(
                name: "TB_Details");

            migrationBuilder.DropTable(
                name: "Tb_Games");

            migrationBuilder.DropTable(
                name: "tb_subscition");

            migrationBuilder.DropTable(
                name: "tb_UserName");

            migrationBuilder.DropTable(
                name: "tbl_Acc_Report");

            migrationBuilder.DropTable(
                name: "tbl_Acc_Types");

            migrationBuilder.DropTable(
                name: "tbl_Accounts");

            migrationBuilder.DropTable(
                name: "tbl_Bank");

            migrationBuilder.DropTable(
                name: "tbl_Bond_Details");

            migrationBuilder.DropTable(
                name: "tbl_Bond_Types");

            migrationBuilder.DropTable(
                name: "tbl_Cash");

            migrationBuilder.DropTable(
                name: "tbl_Company");

            migrationBuilder.DropTable(
                name: "tbl_Curr_Types");

            migrationBuilder.DropTable(
                name: "tbl_Currencies");

            migrationBuilder.DropTable(
                name: "tbl_Journal_Details");

            migrationBuilder.DropTable(
                name: "tbl_jTypes");

            migrationBuilder.DropTable(
                name: "tbl_karate_certificate");

            migrationBuilder.DropTable(
                name: "tbl_Orders_Details");

            migrationBuilder.DropTable(
                name: "tbl_Process");

            migrationBuilder.DropTable(
                name: "tbl_taekwondo_certificate");

            migrationBuilder.DropTable(
                name: "tbl_Users");

            migrationBuilder.DropTable(
                name: "ToDay");

            migrationBuilder.DropTable(
                name: "UserName");

            migrationBuilder.DropTable(
                name: "tbl_Bond_HDR");

            migrationBuilder.DropTable(
                name: "tbl_Journal_HDR");

            migrationBuilder.DropTable(
                name: "tbl_Order");

            migrationBuilder.DropTable(
                name: "tbl_Products");

            migrationBuilder.DropTable(
                name: "TbPlayer");

            migrationBuilder.DropTable(
                name: "tbl_Categories");

            migrationBuilder.DropTable(
                name: "TB_branch");

            migrationBuilder.DropColumn(
                name: "AddAnotherGame",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cellphone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cellphone2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Datetime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DurationAnotherGame",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DurationMonth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Game",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GuardianWork",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Identification",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageTransfer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NameA",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
