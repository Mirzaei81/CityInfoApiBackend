using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfoApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bar1",
                columns: table => new
                {
                    B_No = table.Column<int>(type: "int", nullable: false),
                    B_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    B_Anbar = table.Column<byte>(type: "tinyint", nullable: false),
                    B_Prsn = table.Column<int>(type: "int", nullable: true),
                    B_Barnameh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, collation: "Arabic_CI_AI"),
                    B_DateB = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    B_Mashin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "Arabic_CI_AI"),
                    B_NameN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "Arabic_CI_AI"),
                    B_Kala = table.Column<int>(type: "int", nullable: true),
                    B_NumKoli = table.Column<int>(type: "int", nullable: true),
                    B_Num = table.Column<double>(type: "float", nullable: true),
                    B_Num2 = table.Column<double>(type: "float", nullable: true),
                    B_Mab = table.Column<double>(type: "float", nullable: true),
                    B_Mab2 = table.Column<double>(type: "float", nullable: true),
                    B_Sharh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    B_Bar = table.Column<double>(type: "float", nullable: true),
                    B_BarGry = table.Column<double>(type: "float", nullable: true),
                    B_Hazine = table.Column<double>(type: "float", nullable: true),
                    B_KsrBar = table.Column<double>(type: "float", nullable: true),
                    B_EzfBar = table.Column<double>(type: "float", nullable: true),
                    B_ZNumKoli = table.Column<int>(type: "int", nullable: true),
                    B_ZNum = table.Column<double>(type: "float", nullable: true),
                    B_ZNum2 = table.Column<double>(type: "float", nullable: true),
                    B_DrsdPorsant = table.Column<double>(type: "float", nullable: true),
                    B_MabPorsant = table.Column<int>(type: "int", nullable: true),
                    B_Sanad = table.Column<int>(type: "int", nullable: true),
                    B_Flag = table.Column<bool>(type: "bit", nullable: true),
                    B_User = table.Column<byte>(type: "tinyint", nullable: true),
                    B_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    B_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    B_VznZrf = table.Column<double>(type: "float", nullable: true),
                    B_InputBar = table.Column<double>(type: "float", nullable: true),
                    B_InputBarGry = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bar1", x => x.B_No);
                });

            migrationBuilder.CreateTable(
                name: "Bar2",
                columns: table => new
                {
                    B2_No = table.Column<int>(type: "int", nullable: false),
                    B2_Radif = table.Column<int>(type: "int", nullable: false),
                    B2_Moshtari = table.Column<int>(type: "int", nullable: true),
                    B2_NumKoli = table.Column<int>(type: "int", nullable: true),
                    B2_Num = table.Column<double>(type: "float", nullable: true),
                    B2_Num2 = table.Column<double>(type: "float", nullable: true),
                    B2_Mab = table.Column<long>(type: "bigint", nullable: true),
                    B2_DateF = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    B2_Sharh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    B2_KindPay = table.Column<byte>(type: "tinyint", nullable: true),
                    B2_NoPay = table.Column<long>(type: "bigint", nullable: true),
                    B2_Discount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ghest",
                columns: table => new
                {
                    GH_Moshtari = table.Column<int>(type: "int", nullable: false),
                    GH_No = table.Column<int>(type: "int", nullable: false),
                    GH_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    GH_Mab = table.Column<double>(type: "float", nullable: true),
                    GH_DateV = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    GH_Shrh = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    GH_Payment = table.Column<long>(type: "bigint", nullable: true),
                    GH_CODEMELI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    GH_DATEVAM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GH_MABKOLVAM = table.Column<int>(type: "int", nullable: true),
                    GH_VAMACC = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghest", x => new { x.GH_Moshtari, x.GH_No });
                });

            migrationBuilder.CreateTable(
                name: "Goroh",
                columns: table => new
                {
                    GH_Code = table.Column<byte>(type: "tinyint", nullable: false),
                    GH_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, collation: "Arabic_CI_AI"),
                    GH_Kind = table.Column<int>(type: "int", nullable: false),
                    GH_Mahiat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goroh", x => x.GH_Code);
                });

            migrationBuilder.CreateTable(
                name: "GorohK",
                columns: table => new
                {
                    GK_Code = table.Column<int>(type: "int", nullable: false),
                    GK_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Arabic_CI_AI"),
                    GK_inKharid = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)"),
                    GK_inForosh = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)"),
                    GK_inKhadmat = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupK", x => x.GK_Code);
                });

            migrationBuilder.CreateTable(
                name: "GorohM",
                columns: table => new
                {
                    GM_Code = table.Column<int>(type: "int", nullable: false),
                    GM_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    GM_inKharid = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)"),
                    GM_inForosh = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)"),
                    GM_inPosnt = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupM", x => x.GM_Code);
                });

            migrationBuilder.CreateTable(
                name: "GorohT",
                columns: table => new
                {
                    T_Code = table.Column<int>(type: "int", nullable: false),
                    T_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.T_Code);
                });

            migrationBuilder.CreateTable(
                name: "HsbPrsnsKolis",
                columns: table => new
                {
                    Brws = table.Column<short>(type: "smallint", nullable: true),
                    KindFactor = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    No = table.Column<int>(type: "int", nullable: false),
                    kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sharh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bes = table.Column<double>(type: "float", nullable: false),
                    Bed = table.Column<double>(type: "float", nullable: false),
                    F_Factor = table.Column<long>(type: "bigint", nullable: false),
                    F = table.Column<int>(type: "int", nullable: true),
                    Mande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ins2factor",
                columns: table => new
                {
                    RowsAffected = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Mantagh",
                columns: table => new
                {
                    Code_Mantagh = table.Column<int>(type: "int", nullable: false),
                    Name_Mantagh = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mantagh__2F650636", x => x.Code_Mantagh);
                });

            migrationBuilder.CreateTable(
                name: "NoteBook",
                columns: table => new
                {
                    Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Note = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RFactor1",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: false),
                    F_Factor = table.Column<int>(type: "int", nullable: false),
                    F_No = table.Column<int>(type: "int", nullable: false),
                    F_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Mrkaz = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Anbar = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Moshtari = table.Column<int>(type: "int", nullable: true),
                    F_Serial = table.Column<int>(type: "int", nullable: true),
                    F_DateTahvil = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Mab = table.Column<double>(type: "float", nullable: true),
                    F_MabKol = table.Column<double>(type: "float", nullable: true),
                    F_Porsant = table.Column<int>(type: "int", nullable: true),
                    F_MabPorsant = table.Column<double>(type: "float", nullable: true),
                    F_KindPay = table.Column<byte>(type: "tinyint", nullable: true),
                    F_NoPay = table.Column<long>(type: "bigint", nullable: true),
                    F_Sanad = table.Column<int>(type: "int", nullable: true),
                    F_Flag = table.Column<bool>(type: "bit", nullable: true),
                    F_DateA = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_User = table.Column<byte>(type: "tinyint", nullable: true),
                    F_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    F_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Kosor = table.Column<double>(type: "float", nullable: true),
                    F_Ezafat = table.Column<double>(type: "float", nullable: true),
                    F_Anbar2 = table.Column<byte>(type: "tinyint", nullable: true),
                    F_AccKosorat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_AccEzafat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_FixKosorat = table.Column<bool>(type: "bit", nullable: true),
                    F_FixEzafat = table.Column<bool>(type: "bit", nullable: true),
                    F_FixPorsant = table.Column<bool>(type: "bit", nullable: true),
                    F_Print = table.Column<int>(type: "int", nullable: true),
                    F_Kdarsad = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
                    F_AccAnbar = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_Maliat = table.Column<double>(type: "float", nullable: true),
                    F_Avarez = table.Column<double>(type: "float", nullable: true),
                    F_DriverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFactor1", x => x.R_No);
                });

            migrationBuilder.CreateTable(
                name: "RKhadamat",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: false),
                    Kh_Markaz = table.Column<byte>(type: "tinyint", nullable: true),
                    Kh_No = table.Column<long>(type: "bigint", nullable: true),
                    Kh_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_Moshtari = table.Column<int>(type: "int", nullable: true),
                    Kh_MName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Sanad = table.Column<int>(type: "int", nullable: true),
                    Kh_User = table.Column<int>(type: "int", nullable: true),
                    Kh_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Serial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Shrh = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Shrh2 = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Kind = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Motealegh = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Serial2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Factor = table.Column<int>(type: "int", nullable: true),
                    Kh_DateF = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_DateG = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_Ojrat = table.Column<double>(type: "float", nullable: true),
                    Kh_Ghatat = table.Column<double>(type: "float", nullable: true),
                    Kh_Sum = table.Column<double>(type: "float", nullable: true),
                    Kh_NoPay = table.Column<long>(type: "bigint", nullable: true),
                    Kh_KindPay = table.Column<byte>(type: "tinyint", nullable: true),
                    Kh_DateT = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_KalaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RKhadamat", x => x.R_No);
                });

            migrationBuilder.CreateTable(
                name: "RPayment1",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: false),
                    P1_Markaz = table.Column<byte>(type: "tinyint", nullable: true),
                    P1_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    P1_No = table.Column<long>(type: "bigint", nullable: false),
                    P1_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    P1_Moshtari = table.Column<int>(type: "int", nullable: true),
                    P1_Sanad = table.Column<int>(type: "int", nullable: true),
                    P1_IsArz = table.Column<bool>(type: "bit", nullable: false),
                    P1_User = table.Column<int>(type: "int", nullable: true),
                    P1_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    P1_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    P1_Sum = table.Column<double>(type: "float", nullable: true),
                    P1_Acc1 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P1_Acc2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPayment1", x => x.R_No);
                });

            migrationBuilder.CreateTable(
                name: "RSanad",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: false),
                    S_No = table.Column<int>(type: "int", nullable: false),
                    S_Sanad = table.Column<int>(type: "int", nullable: false),
                    S_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S_Markaz = table.Column<byte>(type: "tinyint", nullable: true),
                    S_Flag = table.Column<bool>(type: "bit", nullable: false),
                    S_User = table.Column<int>(type: "int", nullable: true),
                    S_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    S_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S_Temp = table.Column<bool>(type: "bit", nullable: true),
                    S_Print = table.Column<int>(type: "int", nullable: true),
                    S_InEdit = table.Column<bool>(type: "bit", nullable: false),
                    S_IsArz = table.Column<bool>(type: "bit", nullable: false),
                    S_Type = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSanad", x => x.R_No);
                });

            migrationBuilder.CreateTable(
                name: "Sanad",
                columns: table => new
                {
                    S_Sanad = table.Column<int>(type: "int", nullable: false),
                    S_No = table.Column<int>(type: "int", nullable: false),
                    S_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S_Markaz = table.Column<byte>(type: "tinyint", nullable: true),
                    S_Flag = table.Column<bool>(type: "bit", nullable: false),
                    S_User = table.Column<int>(type: "int", nullable: true),
                    S_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    S_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S_Temp = table.Column<bool>(type: "bit", nullable: true),
                    S_Print = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    S_InEdit = table.Column<bool>(type: "bit", nullable: false),
                    S_IsArz = table.Column<bool>(type: "bit", nullable: false),
                    S_Type = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('H')", collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanad", x => x.S_Sanad);
                });

            migrationBuilder.CreateTable(
                name: "Sanad1400s",
                columns: table => new
                {
                    s_user = table.Column<int>(type: "int", nullable: false),
                    s_date = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sefaresh1",
                columns: table => new
                {
                    S1_No = table.Column<int>(type: "int", nullable: false),
                    S1_Mrkaz = table.Column<byte>(type: "tinyint", nullable: false),
                    S1_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S1_Vahed = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    S1_Kind = table.Column<bool>(type: "bit", nullable: false),
                    S1_User = table.Column<int>(type: "int", nullable: false),
                    S1_Foroshande = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefaresh1_1", x => x.S1_No);
                });

            migrationBuilder.CreateTable(
                name: "SMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    CreateTime = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false, collation: "Arabic_CI_AI"),
                    Tel = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false, collation: "Arabic_CI_AI"),
                    txt = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, collation: "Arabic_CI_AI"),
                    Type = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    SendDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, collation: "Arabic_CI_AI"),
                    SendTime = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    Status = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    DeliverDate = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, collation: "Arabic_CI_AI"),
                    DeliverTime = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    DeliverStatus = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    DeliverMessage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vahed",
                columns: table => new
                {
                    V_Code = table.Column<int>(type: "int", nullable: false),
                    V_Name = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VAHED", x => x.V_Code);
                });

            migrationBuilder.CreateTable(
                name: "Onvan",
                columns: table => new
                {
                    O_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false, collation: "Arabic_CI_AI"),
                    O_Goroh = table.Column<byte>(type: "tinyint", nullable: true),
                    O_Kol = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, collation: "Arabic_CI_AI"),
                    O_Moein = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, collation: "Arabic_CI_AI"),
                    O_Tfzili = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true, collation: "Arabic_CI_AI"),
                    O_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, collation: "Arabic_CI_AI"),
                    O_Sub = table.Column<bool>(type: "bit", nullable: false),
                    O_Bed = table.Column<long>(type: "bigint", nullable: true),
                    O_Bes = table.Column<long>(type: "bigint", nullable: true),
                    O_ArzBed = table.Column<double>(type: "float", nullable: true),
                    O_ArzBes = table.Column<double>(type: "float", nullable: true),
                    O_Sanad = table.Column<int>(type: "int", nullable: true),
                    O_Kind = table.Column<int>(type: "int", nullable: false),
                    O_Temp = table.Column<bool>(type: "bit", nullable: true),
                    O_InUsed = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
                    O_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(1)"),
                    O_NoDarayi = table.Column<short>(type: "smallint", nullable: true),
                    O_BedBes = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onvan", x => x.O_Acc);
                    table.ForeignKey(
                        name: "FK_Onvan_Goroh",
                        column: x => x.O_Goroh,
                        principalTable: "Goroh",
                        principalColumn: "GH_Code");
                });

            migrationBuilder.CreateTable(
                name: "Kala",
                columns: table => new
                {
                    K_Code = table.Column<int>(type: "int", nullable: false),
                    K_Goroh = table.Column<int>(type: "int", nullable: false),
                    K_Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, collation: "Arabic_CI_AI"),
                    K_Vahed = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    K_VahedKoli = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    K_Zarib = table.Column<double>(type: "float", nullable: true),
                    K_ForoshM = table.Column<double>(type: "float", nullable: true),
                    K_Arz = table.Column<byte>(type: "tinyint", nullable: true),
                    K_ArzMab = table.Column<double>(type: "float", nullable: true),
                    K_MinF = table.Column<double>(type: "float", nullable: true),
                    K_MaxF = table.Column<double>(type: "float", nullable: true),
                    K_ForoshH = table.Column<double>(type: "float", nullable: true),
                    K_Fani = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, collation: "Arabic_CI_AI"),
                    K_Sharh = table.Column<string>(type: "ntext", nullable: true, collation: "Arabic_CI_AI"),
                    K_Pic = table.Column<byte[]>(type: "image", nullable: true),
                    K_Log = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(1)"),
                    K_Lan = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    K_NameL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Arabic_CI_AI"),
                    K_Tolid = table.Column<double>(type: "float", nullable: true),
                    K_HTolid = table.Column<double>(type: "float", nullable: true),
                    K_Sarbar = table.Column<double>(type: "float", nullable: true),
                    K_HTmam = table.Column<double>(type: "float", nullable: true),
                    K_Barcode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    K_Omde = table.Column<double>(type: "float", nullable: true),
                    K_Vazn = table.Column<double>(type: "float", nullable: true),
                    K_Darsad = table.Column<double>(type: "float", nullable: true),
                    K_Keshvar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    K_FMonth = table.Column<double>(type: "float", nullable: true),
                    K_FYear = table.Column<double>(type: "float", nullable: true),
                    K_FMonth2 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth3 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth4 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth1 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth5 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth6 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth7 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth8 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth9 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth10 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth11 = table.Column<double>(type: "float", nullable: true),
                    K_FMonth12 = table.Column<double>(type: "float", nullable: true),
                    K_MaliatIs = table.Column<bool>(type: "bit", nullable: true),
                    K_Maliat = table.Column<double>(type: "float", nullable: true),
                    K_AvarezIs = table.Column<bool>(type: "bit", nullable: true),
                    K_Avarez = table.Column<double>(type: "float", nullable: true),
                    K_fani2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, collation: "Arabic_CI_AI"),
                    K_Porsant = table.Column<double>(type: "float", nullable: true),
                    K_IsBarcode = table.Column<bool>(type: "bit", nullable: true),
                    K_ForoshN = table.Column<long>(type: "bigint", nullable: true),
                    K_ForoshMd = table.Column<long>(type: "bigint", nullable: true),
                    K_ForoshMsrf = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KALA", x => x.K_Code);
                    table.ForeignKey(
                        name: "FK_Kala_GorohK",
                        column: x => x.K_Goroh,
                        principalTable: "GorohK",
                        principalColumn: "GK_Code");
                });

            migrationBuilder.CreateTable(
                name: "RFactor2",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: true),
                    FK_Factor = table.Column<int>(type: "int", nullable: false),
                    FK_Radif = table.Column<int>(type: "int", nullable: false),
                    FK_Kala = table.Column<int>(type: "int", nullable: true),
                    FK_Num = table.Column<double>(type: "float", nullable: true),
                    FK_NumKoli = table.Column<int>(type: "int", nullable: true),
                    FK_Tol = table.Column<double>(type: "float", nullable: true),
                    FK_Arze = table.Column<double>(type: "float", nullable: true),
                    FK_V = table.Column<byte>(type: "tinyint", nullable: true),
                    FK_Tdad = table.Column<short>(type: "smallint", nullable: true),
                    FK_Mab = table.Column<double>(type: "float", nullable: true),
                    FK_KindArz = table.Column<byte>(type: "tinyint", nullable: true),
                    FK_Arz = table.Column<double>(type: "float", nullable: true),
                    FK_Modat = table.Column<bool>(type: "bit", nullable: true),
                    FK_DateModat = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    FK_Sharh = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, collation: "Arabic_CI_AI"),
                    FK_Kdarsad = table.Column<double>(type: "float", nullable: true),
                    FK_Maliat = table.Column<double>(type: "float", nullable: true),
                    FK_Avarez = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RFactor2_RFactor1",
                        column: x => x.R_No,
                        principalTable: "RFactor1",
                        principalColumn: "R_No");
                });

            migrationBuilder.CreateTable(
                name: "RPayment2",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: true),
                    P2_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    P2_No = table.Column<long>(type: "bigint", nullable: false),
                    P2_Radif = table.Column<int>(type: "int", nullable: false),
                    P2_KindP = table.Column<byte>(type: "tinyint", nullable: true),
                    P2_Check = table.Column<int>(type: "int", nullable: true),
                    P2_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P2_Shrh = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, collation: "Arabic_CI_AI"),
                    P2_Mab = table.Column<double>(type: "float", nullable: true),
                    P2_Acc2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P2_ArzMab = table.Column<double>(type: "float", nullable: true),
                    P2_ArzType = table.Column<byte>(type: "tinyint", nullable: true),
                    P2_KindC = table.Column<short>(type: "smallint", nullable: true),
                    P2_ArzKol = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RPayment2_RPayment1",
                        column: x => x.R_No,
                        principalTable: "RPayment1",
                        principalColumn: "R_No");
                });

            migrationBuilder.CreateTable(
                name: "RSanadITM",
                columns: table => new
                {
                    R_No = table.Column<long>(type: "bigint", nullable: false),
                    S_Sanad = table.Column<int>(type: "int", nullable: false),
                    Radif = table.Column<int>(type: "int", nullable: false),
                    Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false, collation: "Arabic_CI_AI"),
                    Sharh = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, collation: "Arabic_CI_AI"),
                    Bed = table.Column<double>(type: "float", nullable: false),
                    ArzBed = table.Column<double>(type: "float", nullable: true),
                    Bes = table.Column<double>(type: "float", nullable: false),
                    ArzBes = table.Column<double>(type: "float", nullable: true),
                    A_Code = table.Column<byte>(type: "tinyint", nullable: true),
                    F_Factor = table.Column<int>(type: "int", nullable: true),
                    P_Payment = table.Column<long>(type: "bigint", nullable: true),
                    P_Kind = table.Column<byte>(type: "tinyint", nullable: true),
                    H_Hesab = table.Column<int>(type: "int", nullable: true),
                    Kh_Khadamat = table.Column<long>(type: "bigint", nullable: true),
                    ArzKol = table.Column<double>(type: "float", nullable: true),
                    B_bar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RSanadITM_RSanad",
                        column: x => x.R_No,
                        principalTable: "RSanad",
                        principalColumn: "R_No");
                });

            migrationBuilder.CreateTable(
                name: "InEditSanads",
                columns: table => new
                {
                    S_Sanad = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InEditSanads", x => x.S_Sanad);
                    table.ForeignKey(
                        name: "FK_InEditSanads_Sanad",
                        column: x => x.S_Sanad,
                        principalTable: "Sanad",
                        principalColumn: "S_Sanad");
                });

            migrationBuilder.CreateTable(
                name: "InEditSefaresh",
                columns: table => new
                {
                    S1_No = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_InEditSefaresh_Sefaresh1",
                        column: x => x.S1_No,
                        principalTable: "Sefaresh1",
                        principalColumn: "S1_No");
                });

            migrationBuilder.CreateTable(
                name: "Anbar",
                columns: table => new
                {
                    A_Code = table.Column<byte>(type: "tinyint", nullable: false),
                    A_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Arabic_CI_AI"),
                    A_NameA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Arabic_CI_AI"),
                    A_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(1)"),
                    A_Acc1 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc3 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc4 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc5 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc6 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc9 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc10 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc11 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc12 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc13 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc14 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc19 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc22 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc23 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc24 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc7 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    A_Acc16 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANBAR", x => x.A_Code);
                    table.ForeignKey(
                        name: "FK__Anbar__A_Acc16__407061FE",
                        column: x => x.A_Acc16,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK__Anbar__A_Acc7__41648637",
                        column: x => x.A_Acc7,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan",
                        column: x => x.A_Acc1,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan1",
                        column: x => x.A_Acc3,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan10",
                        column: x => x.A_Acc13,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan11",
                        column: x => x.A_Acc14,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan12",
                        column: x => x.A_Acc2,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan13",
                        column: x => x.A_Acc22,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan14",
                        column: x => x.A_Acc23,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan15",
                        column: x => x.A_Acc24,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan2",
                        column: x => x.A_Acc4,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan3",
                        column: x => x.A_Acc5,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan4",
                        column: x => x.A_Acc19,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan5",
                        column: x => x.A_Acc6,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan6",
                        column: x => x.A_Acc9,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan7",
                        column: x => x.A_Acc10,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan8",
                        column: x => x.A_Acc11,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Anbar_Onvan9",
                        column: x => x.A_Acc12,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                });

            migrationBuilder.CreateTable(
                name: "KAFactor",
                columns: table => new
                {
                    KA_Factor = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, collation: "Arabic_CI_AI"),
                    KA_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true, collation: "Arabic_CI_AI"),
                    KA_Kind = table.Column<bool>(type: "bit", nullable: true),
                    KA_Darsad = table.Column<double>(type: "float", nullable: true),
                    KA_Sabet = table.Column<double>(type: "float", nullable: true),
                    KA_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KAFactor", x => x.KA_Factor);
                    table.ForeignKey(
                        name: "FK_KAFactor_Onvan",
                        column: x => x.KA_Acc,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                });

            migrationBuilder.CreateTable(
                name: "Moshtari",
                columns: table => new
                {
                    M_Code = table.Column<int>(type: "int", nullable: false),
                    M_Goroh = table.Column<int>(type: "int", nullable: false),
                    M_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Atbar = table.Column<long>(type: "bigint", nullable: true),
                    M_Tel1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    M_Tel2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    M_Mobil = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true, collation: "Arabic_CI_AI"),
                    M_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    M_Meli = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    M_Log = table.Column<bool>(type: "bit", nullable: true),
                    M_LogHsab = table.Column<bool>(type: "bit", nullable: true),
                    M_Kol = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    M_Moein = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    M_Tfzili = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    M_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false, collation: "Arabic_CI_AI"),
                    M_Pic = table.Column<byte[]>(type: "image", nullable: true),
                    M_Txt = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    M_Hmkar = table.Column<byte>(type: "tinyint", nullable: true),
                    M_Lan = table.Column<byte>(type: "tinyint", nullable: true),
                    M_NameL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Onvan = table.Column<byte>(type: "tinyint", nullable: true),
                    M_DateList = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    M_Economy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Post = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true, collation: "Arabic_CI_AI"),
                    M_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Ostan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Porsant = table.Column<double>(type: "float", nullable: true),
                    M_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    M_CodeMantagh = table.Column<int>(type: "int", nullable: true),
                    M_Tel3 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_Tel4 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_Mobile2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_TelSMS = table.Column<bool>(type: "bit", nullable: true),
                    M_SABT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_MODIR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOSHTARI", x => x.M_Code);
                    table.ForeignKey(
                        name: "FK_Moshtari_GorohM",
                        column: x => x.M_Goroh,
                        principalTable: "GorohM",
                        principalColumn: "GM_Code");
                    table.ForeignKey(
                        name: "FK_Moshtari_Onvan",
                        column: x => x.M_Acc,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KalaT",
                columns: table => new
                {
                    T_Kala = table.Column<int>(type: "int", nullable: false),
                    T_Radif = table.Column<int>(type: "int", nullable: false),
                    T_KalaITM = table.Column<int>(type: "int", nullable: true),
                    T_Num = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    T_Mab = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KalaT", x => new { x.T_Kala, x.T_Radif });
                    table.ForeignKey(
                        name: "FK_KalaT_Kala",
                        column: x => x.T_Kala,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                    table.ForeignKey(
                        name: "FK_KalaT_Kala1",
                        column: x => x.T_KalaITM,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                });

            migrationBuilder.CreateTable(
                name: "Sefaresh2",
                columns: table => new
                {
                    S2_No = table.Column<int>(type: "int", nullable: false),
                    S2_Radif = table.Column<short>(type: "smallint", nullable: false),
                    S2_Kala = table.Column<int>(type: "int", nullable: false),
                    S2_Num = table.Column<double>(type: "float", nullable: false),
                    S2_Shrh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    S2_DateR = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    S2_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    S2_Num2 = table.Column<double>(type: "float", nullable: true),
                    S2_DateE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefaresh2", x => new { x.S2_No, x.S2_Radif });
                    table.ForeignKey(
                        name: "FK_Sefaresh2_Kala",
                        column: x => x.S2_Kala,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                    table.ForeignKey(
                        name: "FK_Sefaresh2_Sefaresh1",
                        column: x => x.S2_No,
                        principalTable: "Sefaresh1",
                        principalColumn: "S1_No");
                });

            migrationBuilder.CreateTable(
                name: "Tashaboh",
                columns: table => new
                {
                    T_Code = table.Column<int>(type: "int", nullable: false),
                    K_Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tashaboh", x => new { x.T_Code, x.K_Code });
                    table.ForeignKey(
                        name: "FK_Tashaboh_GorohT",
                        column: x => x.T_Code,
                        principalTable: "GorohT",
                        principalColumn: "T_Code");
                    table.ForeignKey(
                        name: "FK_Tashaboh_Kala",
                        column: x => x.K_Code,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                });

            migrationBuilder.CreateTable(
                name: "KalaM",
                columns: table => new
                {
                    KM_Code = table.Column<int>(type: "int", nullable: false),
                    KM_Anbar = table.Column<byte>(type: "tinyint", nullable: false),
                    KM_MojKol = table.Column<double>(type: "float", nullable: true),
                    KM_Moj = table.Column<double>(type: "float", nullable: true),
                    KM_Arzesh = table.Column<double>(type: "float", nullable: true),
                    KM_MinMoj = table.Column<double>(type: "float", nullable: true),
                    KM_Sefaresh = table.Column<double>(type: "float", nullable: true),
                    KM_Radif = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, collation: "Arabic_CI_AI"),
                    KM_Shomaresh = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    KM_EndMoj = table.Column<double>(type: "float", nullable: true),
                    KM_EndMojKol = table.Column<double>(type: "float", nullable: true),
                    KM_EndArzesh = table.Column<double>(type: "float", nullable: true),
                    KM_LastArzesh = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "(0)"),
                    KM_ArzArzesh = table.Column<double>(type: "float", nullable: true),
                    KM_EndArzArzesh = table.Column<double>(type: "float", nullable: true),
                    KM_LastArzArzesh = table.Column<long>(type: "bigint", nullable: true),
                    KM_MaxMoj = table.Column<double>(type: "float", nullable: true),
                    KM_KindArz = table.Column<byte>(type: "tinyint", nullable: true),
                    K_Keshvar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KalaM", x => new { x.KM_Code, x.KM_Anbar });
                    table.ForeignKey(
                        name: "FK_KalaM_Anbar",
                        column: x => x.KM_Anbar,
                        principalTable: "Anbar",
                        principalColumn: "A_Code");
                    table.ForeignKey(
                        name: "FK_KalaM_Kala",
                        column: x => x.KM_Code,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                });

            migrationBuilder.CreateTable(
                name: "MoshtariTkmili",
                columns: table => new
                {
                    M_CodeM = table.Column<int>(type: "int", nullable: false),
                    M_Father = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Tavalod = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    M_Sadere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Shnasnameh = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_AddressMnzl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    M_AddressKar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    M_Vsighe = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    M_DateFirst = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    M_DateEnd = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    M_Zmn1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn1CodeMli = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn1Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn1Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn1Vsighe = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn2CodeMli = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn2Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn2Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn2Vsighe = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn3CodeMli = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn3Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn3Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "Arabic_CI_AI"),
                    M_Zmn3Vsighe = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoshtariTkmili", x => x.M_CodeM);
                    table.ForeignKey(
                        name: "FK_MoshtariTkmili_Moshtari",
                        column: x => x.M_CodeM,
                        principalTable: "Moshtari",
                        principalColumn: "M_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment1",
                columns: table => new
                {
                    P1_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    P1_No = table.Column<long>(type: "bigint", nullable: false),
                    P1_Markaz = table.Column<byte>(type: "tinyint", nullable: true),
                    P1_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    P1_Moshtari = table.Column<int>(type: "int", nullable: true),
                    P1_Sanad = table.Column<int>(type: "int", nullable: true),
                    P1_IsArz = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
                    P1_User = table.Column<int>(type: "int", nullable: true),
                    P1_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    P1_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    P1_Sum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    P1_Acc1 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P1_Acc2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment1", x => new { x.P1_Kind, x.P1_No });
                    table.ForeignKey(
                        name: "FK_Payment1_Moshtari",
                        column: x => x.P1_Moshtari,
                        principalTable: "Moshtari",
                        principalColumn: "M_Code");
                    table.ForeignKey(
                        name: "FK_Payment1_Onvan",
                        column: x => x.P1_Acc1,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Payment1_Onvan1",
                        column: x => x.P1_Acc2,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Payment1_Sanad",
                        column: x => x.P1_Sanad,
                        principalTable: "Sanad",
                        principalColumn: "S_Sanad");
                });

            migrationBuilder.CreateTable(
                name: "Factor1",
                columns: table => new
                {
                    F_Factor = table.Column<int>(type: "int", nullable: false),
                    F_No = table.Column<int>(type: "int", nullable: false),
                    F_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Mrkaz = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Anbar = table.Column<byte>(type: "tinyint", nullable: false),
                    F_Moshtari = table.Column<int>(type: "int", nullable: true),
                    F_Serial = table.Column<int>(type: "int", nullable: true),
                    F_DateTahvil = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Mab = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    F_MabKol = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    F_Porsant = table.Column<int>(type: "int", nullable: true),
                    F_MabPorsant = table.Column<double>(type: "float", nullable: true),
                    F_KindPay = table.Column<byte>(type: "tinyint", nullable: true),
                    F_NoPay = table.Column<long>(type: "bigint", nullable: true),
                    F_Sanad = table.Column<int>(type: "int", nullable: true),
                    F_Flag = table.Column<bool>(type: "bit", nullable: true),
                    F_DateA = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_User = table.Column<byte>(type: "tinyint", nullable: true),
                    F_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    F_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    F_Kosor = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    F_Ezafat = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    F_Anbar2 = table.Column<byte>(type: "tinyint", nullable: true),
                    F_AccKosorat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_AccEzafat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_FixKosorat = table.Column<bool>(type: "bit", nullable: true),
                    F_FixEzafat = table.Column<bool>(type: "bit", nullable: true),
                    F_FixPorsant = table.Column<bool>(type: "bit", nullable: true),
                    F_Print = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    F_Kdarsad = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
                    F_AccAnbar = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    F_Maliat = table.Column<double>(type: "float", nullable: true),
                    F_Avarez = table.Column<double>(type: "float", nullable: true),
                    F_DriverName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factor1", x => x.F_Factor);
                    table.ForeignKey(
                        name: "FK_FACTOR_ANBAR",
                        column: x => x.F_Anbar,
                        principalTable: "Anbar",
                        principalColumn: "A_Code");
                    table.ForeignKey(
                        name: "FK_Factor1_Anbar",
                        column: x => x.F_Anbar2,
                        principalTable: "Anbar",
                        principalColumn: "A_Code");
                    table.ForeignKey(
                        name: "FK_Factor1_Moshtari",
                        column: x => x.F_Moshtari,
                        principalTable: "Moshtari",
                        principalColumn: "M_Code");
                    table.ForeignKey(
                        name: "FK_Factor1_Moshtari1",
                        column: x => x.F_Porsant,
                        principalTable: "Moshtari",
                        principalColumn: "M_Code");
                    table.ForeignKey(
                        name: "FK_Factor1_Onvan",
                        column: x => x.F_AccKosorat,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Factor1_Onvan1",
                        column: x => x.F_AccEzafat,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Factor1_Payment1",
                        columns: x => new { x.F_KindPay, x.F_NoPay },
                        principalTable: "Payment1",
                        principalColumns: new[] { "P1_Kind", "P1_No" });
                    table.ForeignKey(
                        name: "FK_Factor1_Sanad",
                        column: x => x.F_Sanad,
                        principalTable: "Sanad",
                        principalColumn: "S_Sanad");
                });

            migrationBuilder.CreateTable(
                name: "InEditPayments",
                columns: table => new
                {
                    P1_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    P1_No = table.Column<long>(type: "bigint", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InEditPayment", x => new { x.P1_No, x.P1_Kind });
                    table.ForeignKey(
                        name: "FK_InEditPayment_Payment1",
                        columns: x => new { x.P1_Kind, x.P1_No },
                        principalTable: "Payment1",
                        principalColumns: new[] { "P1_Kind", "P1_No" });
                });

            migrationBuilder.CreateTable(
                name: "Khadamat",
                columns: table => new
                {
                    Kh_No = table.Column<long>(type: "bigint", nullable: false),
                    Kh_Markaz = table.Column<byte>(type: "tinyint", nullable: false),
                    Kh_Date = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_Moshtari = table.Column<int>(type: "int", nullable: true),
                    Kh_MName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Sanad = table.Column<int>(type: "int", nullable: true),
                    Kh_User = table.Column<int>(type: "int", nullable: true),
                    Kh_DateU = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_TimeU = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Serial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Shrh = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Shrh2 = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Kind = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Motealegh = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Serial2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI"),
                    Kh_Factor = table.Column<int>(type: "int", nullable: true),
                    Kh_DateF = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_DateG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_Ojrat = table.Column<double>(type: "float", nullable: true),
                    Kh_Ghatat = table.Column<double>(type: "float", nullable: true),
                    Kh_Sum = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    Kh_NoPay = table.Column<long>(type: "bigint", nullable: true),
                    Kh_KindPay = table.Column<byte>(type: "tinyint", nullable: true),
                    Kh_DateT = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    Kh_KalaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AI")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khadamat", x => x.Kh_No);
                    table.ForeignKey(
                        name: "FK_Khadamat_Moshtari",
                        column: x => x.Kh_Moshtari,
                        principalTable: "Moshtari",
                        principalColumn: "M_Code");
                    table.ForeignKey(
                        name: "FK_Khadamat_Onvan",
                        column: x => x.Kh_Acc,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Khadamat_Payment1",
                        columns: x => new { x.Kh_KindPay, x.Kh_NoPay },
                        principalTable: "Payment1",
                        principalColumns: new[] { "P1_Kind", "P1_No" });
                    table.ForeignKey(
                        name: "FK_Khadamat_Sanad",
                        column: x => x.Kh_Sanad,
                        principalTable: "Sanad",
                        principalColumn: "S_Sanad");
                });

            migrationBuilder.CreateTable(
                name: "Factor2",
                columns: table => new
                {
                    FK_Factor = table.Column<int>(type: "int", nullable: false),
                    FK_Radif = table.Column<int>(type: "int", nullable: false),
                    FK_Kala = table.Column<int>(type: "int", nullable: true),
                    FK_Num = table.Column<double>(type: "float", nullable: true),
                    FK_NumKoli = table.Column<int>(type: "int", nullable: true),
                    FK_Tol = table.Column<double>(type: "float", nullable: true),
                    FK_Arze = table.Column<double>(type: "float", nullable: true),
                    FK_V = table.Column<byte>(type: "tinyint", nullable: true),
                    FK_Tdad = table.Column<short>(type: "smallint", nullable: true),
                    FK_Mab = table.Column<double>(type: "float", nullable: true),
                    FK_KindArz = table.Column<byte>(type: "tinyint", nullable: true),
                    FK_Arz = table.Column<double>(type: "float", nullable: true),
                    FK_Modat = table.Column<bool>(type: "bit", nullable: true),
                    FK_DateModat = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    FK_Sharh = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, collation: "Arabic_CI_AI"),
                    FK_Kdarsad = table.Column<double>(type: "float", nullable: true),
                    FK_Maliat = table.Column<double>(type: "float", nullable: true),
                    FK_Avarez = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factor2", x => new { x.FK_Factor, x.FK_Radif });
                    table.ForeignKey(
                        name: "FK_Factor2_Factor1",
                        column: x => x.FK_Factor,
                        principalTable: "Factor1",
                        principalColumn: "F_Factor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factor2_Kala",
                        column: x => x.FK_Kala,
                        principalTable: "Kala",
                        principalColumn: "K_Code");
                });

            migrationBuilder.CreateTable(
                name: "InEditFactors",
                columns: table => new
                {
                    F_Factor = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InEditFactors", x => x.F_Factor);
                    table.ForeignKey(
                        name: "FK_InEditFactors_Factor1",
                        column: x => x.F_Factor,
                        principalTable: "Factor1",
                        principalColumn: "F_Factor");
                });

            migrationBuilder.CreateTable(
                name: "KAFactorL",
                columns: table => new
                {
                    L_Factor = table.Column<int>(type: "int", nullable: false),
                    L_KA = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, collation: "Arabic_CI_AI"),
                    L_Darsad = table.Column<double>(type: "float", nullable: true),
                    L_Sabet = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KAFactorL", x => new { x.L_Factor, x.L_KA });
                    table.ForeignKey(
                        name: "FK_KAFactorL_Factor1",
                        column: x => x.L_Factor,
                        principalTable: "Factor1",
                        principalColumn: "F_Factor");
                    table.ForeignKey(
                        name: "FK_KAFactorL_KAFactor",
                        column: x => x.L_KA,
                        principalTable: "KAFactor",
                        principalColumn: "KA_Factor");
                });

            migrationBuilder.CreateTable(
                name: "InEditKhadamat",
                columns: table => new
                {
                    Kh_No = table.Column<long>(type: "bigint", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InEditKhadamat", x => x.Kh_No);
                    table.ForeignKey(
                        name: "FK_InEditKhadamat_Khadamat",
                        column: x => x.Kh_No,
                        principalTable: "Khadamat",
                        principalColumn: "Kh_No");
                });

            migrationBuilder.CreateTable(
                name: "SanadITM",
                columns: table => new
                {
                    S_Sanad = table.Column<int>(type: "int", nullable: false),
                    Radif = table.Column<int>(type: "int", nullable: false),
                    Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false, collation: "Arabic_CI_AI"),
                    Sharh = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, collation: "Arabic_CI_AI"),
                    Bed = table.Column<double>(type: "float", nullable: false),
                    ArzBed = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    Bes = table.Column<double>(type: "float", nullable: false),
                    ArzBes = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    A_Code = table.Column<byte>(type: "tinyint", nullable: true),
                    F_Factor = table.Column<int>(type: "int", nullable: true),
                    P_Payment = table.Column<long>(type: "bigint", nullable: true),
                    P_Kind = table.Column<byte>(type: "tinyint", nullable: true),
                    H_Hesab = table.Column<int>(type: "int", nullable: true),
                    Kh_Khadamat = table.Column<long>(type: "bigint", nullable: true),
                    ArzKol = table.Column<double>(type: "float", nullable: true),
                    B_bar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanadITM", x => new { x.S_Sanad, x.Radif });
                    table.ForeignKey(
                        name: "FK_SanadITM_Factor1",
                        column: x => x.F_Factor,
                        principalTable: "Factor1",
                        principalColumn: "F_Factor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanadITM_Khadamat",
                        column: x => x.Kh_Khadamat,
                        principalTable: "Khadamat",
                        principalColumn: "Kh_No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanadITM_Onvan",
                        column: x => x.Acc,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_SanadITM_Payment1",
                        columns: x => new { x.P_Kind, x.P_Payment },
                        principalTable: "Payment1",
                        principalColumns: new[] { "P1_Kind", "P1_No" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanadITM_Sanad",
                        column: x => x.S_Sanad,
                        principalTable: "Sanad",
                        principalColumn: "S_Sanad");
                });

            migrationBuilder.CreateTable(
                name: "Check",
                columns: table => new
                {
                    C_Check = table.Column<long>(type: "bigint", nullable: false),
                    C_DateC = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    C_Bank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    C_Shobeh = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, collation: "Arabic_CI_AI"),
                    C_NoJary = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true, collation: "Arabic_CI_AI"),
                    C_Mab = table.Column<double>(type: "float", nullable: true),
                    C_ArzMab = table.Column<double>(type: "float", nullable: true),
                    C_ArzType = table.Column<byte>(type: "tinyint", nullable: true),
                    C_DateV = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "('____/__/__')", collation: "Arabic_CI_AI"),
                    C_Kind = table.Column<short>(type: "smallint", nullable: true),
                    C_Flag = table.Column<bool>(type: "bit", nullable: true),
                    C_Sharh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    C_Sanad = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    C_Radif = table.Column<int>(type: "int", nullable: true),
                    C_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Arabic_CI_AI"),
                    C_Hesab = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    C_Hesab2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    C_Shahrestan = table.Column<bool>(type: "bit", nullable: true),
                    C_PrsnCheck = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHECK", x => x.C_Check);
                    table.ForeignKey(
                        name: "FK_Check_Onvan",
                        column: x => x.C_Hesab,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Check_Onvan1",
                        column: x => x.C_Hesab2,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_CHECK_SanadITM",
                        columns: x => new { x.C_Sanad, x.C_Radif },
                        principalTable: "SanadITM",
                        principalColumns: new[] { "S_Sanad", "Radif" });
                });

            migrationBuilder.CreateTable(
                name: "Payment2",
                columns: table => new
                {
                    P2_Kind = table.Column<byte>(type: "tinyint", nullable: false),
                    P2_No = table.Column<long>(type: "bigint", nullable: false),
                    P2_Radif = table.Column<int>(type: "int", nullable: false),
                    P2_KindP = table.Column<byte>(type: "tinyint", nullable: true),
                    P2_Check = table.Column<long>(type: "bigint", nullable: true),
                    P2_Acc = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P2_Shrh = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, collation: "Arabic_CI_AI"),
                    P2_Mab = table.Column<double>(type: "float", nullable: true, defaultValueSql: "(0)"),
                    P2_Acc2 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, collation: "Arabic_CI_AI"),
                    P2_ArzMab = table.Column<double>(type: "float", nullable: true),
                    P2_ArzType = table.Column<byte>(type: "tinyint", nullable: true),
                    P2_KindC = table.Column<short>(type: "smallint", nullable: true),
                    P2_ArzKol = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment2", x => new { x.P2_Kind, x.P2_No, x.P2_Radif });
                    table.ForeignKey(
                        name: "FK_Payment2_Check",
                        column: x => x.P2_Check,
                        principalTable: "Check",
                        principalColumn: "C_Check");
                    table.ForeignKey(
                        name: "FK_Payment2_Onvan",
                        column: x => x.P2_Acc,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Payment2_Onvan1",
                        column: x => x.P2_Acc2,
                        principalTable: "Onvan",
                        principalColumn: "O_Acc");
                    table.ForeignKey(
                        name: "FK_Payment2_Payment1",
                        columns: x => new { x.P2_Kind, x.P2_No },
                        principalTable: "Payment1",
                        principalColumns: new[] { "P1_Kind", "P1_No" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ANBAR",
                table: "Anbar",
                column: "A_Name",
                unique: true,
                filter: "[A_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc1",
                table: "Anbar",
                column: "A_Acc1");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc10",
                table: "Anbar",
                column: "A_Acc10");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc11",
                table: "Anbar",
                column: "A_Acc11");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc12",
                table: "Anbar",
                column: "A_Acc12");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc13",
                table: "Anbar",
                column: "A_Acc13");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc14",
                table: "Anbar",
                column: "A_Acc14");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc16",
                table: "Anbar",
                column: "A_Acc16");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc19",
                table: "Anbar",
                column: "A_Acc19");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc2",
                table: "Anbar",
                column: "A_Acc2");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc22",
                table: "Anbar",
                column: "A_Acc22");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc23",
                table: "Anbar",
                column: "A_Acc23");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc24",
                table: "Anbar",
                column: "A_Acc24");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc3",
                table: "Anbar",
                column: "A_Acc3");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc4",
                table: "Anbar",
                column: "A_Acc4");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc5",
                table: "Anbar",
                column: "A_Acc5");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc6",
                table: "Anbar",
                column: "A_Acc6");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc7",
                table: "Anbar",
                column: "A_Acc7");

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_A_Acc9",
                table: "Anbar",
                column: "A_Acc9");

            migrationBuilder.CreateIndex(
                name: "IX_Check",
                table: "Check",
                column: "C_DateC");

            migrationBuilder.CreateIndex(
                name: "IX_Check_C_Hesab",
                table: "Check",
                column: "C_Hesab");

            migrationBuilder.CreateIndex(
                name: "IX_Check_C_Hesab2",
                table: "Check",
                column: "C_Hesab2");

            migrationBuilder.CreateIndex(
                name: "IX_Check_C_Sanad_C_Radif",
                table: "Check",
                columns: new[] { "C_Sanad", "C_Radif" });

            migrationBuilder.CreateIndex(
                name: "IX_Factor1",
                table: "Factor1",
                column: "F_Date");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_1",
                table: "Factor1",
                columns: new[] { "F_No", "F_Kind" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_2",
                table: "Factor1",
                column: "F_Anbar");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_3",
                table: "Factor1",
                column: "F_No");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_AccEzafat",
                table: "Factor1",
                column: "F_AccEzafat");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_AccKosorat",
                table: "Factor1",
                column: "F_AccKosorat");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_Anbar2",
                table: "Factor1",
                column: "F_Anbar2");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_KindPay_F_NoPay",
                table: "Factor1",
                columns: new[] { "F_KindPay", "F_NoPay" });

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_Moshtari",
                table: "Factor1",
                column: "F_Moshtari");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_Porsant",
                table: "Factor1",
                column: "F_Porsant");

            migrationBuilder.CreateIndex(
                name: "IX_Factor1_F_Sanad",
                table: "Factor1",
                column: "F_Sanad");

            migrationBuilder.CreateIndex(
                name: "IX_Factor2",
                table: "Factor2",
                column: "FK_Kala");

            migrationBuilder.CreateIndex(
                name: "IX_Goroh",
                table: "Goroh",
                column: "GH_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GorohK",
                table: "GorohK",
                column: "GK_Name",
                unique: true,
                filter: "[GK_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GorohM",
                table: "GorohM",
                column: "GM_Name",
                unique: true,
                filter: "[GM_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InEditPayments_P1_Kind_P1_No",
                table: "InEditPayments",
                columns: new[] { "P1_Kind", "P1_No" });

            migrationBuilder.CreateIndex(
                name: "IX_InEditSefaresh_S1_No",
                table: "InEditSefaresh",
                column: "S1_No");

            migrationBuilder.CreateIndex(
                name: "IX_KAFactor",
                table: "KAFactor",
                column: "KA_Name",
                unique: true,
                filter: "[KA_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KAFactor_KA_Acc",
                table: "KAFactor",
                column: "KA_Acc");

            migrationBuilder.CreateIndex(
                name: "IX_KAFactorL_L_KA",
                table: "KAFactorL",
                column: "L_KA");

            migrationBuilder.CreateIndex(
                name: "IX_Kala",
                table: "Kala",
                column: "K_Name",
                unique: true,
                filter: "[K_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Kala_K_Goroh",
                table: "Kala",
                column: "K_Goroh");

            migrationBuilder.CreateIndex(
                name: "IX_KalaM_KM_Anbar",
                table: "KalaM",
                column: "KM_Anbar");

            migrationBuilder.CreateIndex(
                name: "IX_KalaT_T_KalaITM",
                table: "KalaT",
                column: "T_KalaITM");

            migrationBuilder.CreateIndex(
                name: "IX_Khadamat_Kh_Acc",
                table: "Khadamat",
                column: "Kh_Acc");

            migrationBuilder.CreateIndex(
                name: "IX_Khadamat_Kh_KindPay_Kh_NoPay",
                table: "Khadamat",
                columns: new[] { "Kh_KindPay", "Kh_NoPay" });

            migrationBuilder.CreateIndex(
                name: "IX_Khadamat_Kh_Moshtari",
                table: "Khadamat",
                column: "Kh_Moshtari");

            migrationBuilder.CreateIndex(
                name: "IX_Khadamat_Kh_Sanad",
                table: "Khadamat",
                column: "Kh_Sanad");

            migrationBuilder.CreateIndex(
                name: "IX_Moshtari",
                table: "Moshtari",
                column: "M_Name",
                unique: true,
                filter: "[M_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Moshtari_M_Acc",
                table: "Moshtari",
                column: "M_Acc");

            migrationBuilder.CreateIndex(
                name: "IX_Moshtari_M_Goroh",
                table: "Moshtari",
                column: "M_Goroh");

            migrationBuilder.CreateIndex(
                name: "IX_Onvan_O_Goroh",
                table: "Onvan",
                column: "O_Goroh");

            migrationBuilder.CreateIndex(
                name: "IX_Payment1_P1_Acc1",
                table: "Payment1",
                column: "P1_Acc1");

            migrationBuilder.CreateIndex(
                name: "IX_Payment1_P1_Acc2",
                table: "Payment1",
                column: "P1_Acc2");

            migrationBuilder.CreateIndex(
                name: "IX_Payment1_P1_Moshtari",
                table: "Payment1",
                column: "P1_Moshtari");

            migrationBuilder.CreateIndex(
                name: "IX_Payment1_P1_Sanad",
                table: "Payment1",
                column: "P1_Sanad");

            migrationBuilder.CreateIndex(
                name: "IX_Payment2_P2_Acc",
                table: "Payment2",
                column: "P2_Acc");

            migrationBuilder.CreateIndex(
                name: "IX_Payment2_P2_Acc2",
                table: "Payment2",
                column: "P2_Acc2");

            migrationBuilder.CreateIndex(
                name: "IX_Payment2_P2_Check",
                table: "Payment2",
                column: "P2_Check");

            migrationBuilder.CreateIndex(
                name: "IX_RFactor2_R_No",
                table: "RFactor2",
                column: "R_No");

            migrationBuilder.CreateIndex(
                name: "IX_RPayment2_R_No",
                table: "RPayment2",
                column: "R_No");

            migrationBuilder.CreateIndex(
                name: "IX_RSanadITM_R_No",
                table: "RSanadITM",
                column: "R_No");

            migrationBuilder.CreateIndex(
                name: "IX_Sanad",
                table: "Sanad",
                column: "S_No");

            migrationBuilder.CreateIndex(
                name: "IX_Sanad_1",
                table: "Sanad",
                column: "S_Date");

            migrationBuilder.CreateIndex(
                name: "IX_Check1",
                table: "SanadITM",
                column: "Acc");

            migrationBuilder.CreateIndex(
                name: "IX_SanadITM_F_Factor",
                table: "SanadITM",
                column: "F_Factor");

            migrationBuilder.CreateIndex(
                name: "IX_SanadITM_Kh_Khadamat",
                table: "SanadITM",
                column: "Kh_Khadamat");

            migrationBuilder.CreateIndex(
                name: "IX_SanadITM_P_Kind_P_Payment",
                table: "SanadITM",
                columns: new[] { "P_Kind", "P_Payment" });

            migrationBuilder.CreateIndex(
                name: "IX_Sefaresh2_S2_Kala",
                table: "Sefaresh2",
                column: "S2_Kala");

            migrationBuilder.CreateIndex(
                name: "IX_Tashaboh_K_Code",
                table: "Tashaboh",
                column: "K_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Vahed",
                table: "Vahed",
                column: "V_Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bar1");

            migrationBuilder.DropTable(
                name: "Bar2");

            migrationBuilder.DropTable(
                name: "Factor2");

            migrationBuilder.DropTable(
                name: "Ghest");

            migrationBuilder.DropTable(
                name: "HsbPrsnsKolis");

            migrationBuilder.DropTable(
                name: "InEditFactors");

            migrationBuilder.DropTable(
                name: "InEditKhadamat");

            migrationBuilder.DropTable(
                name: "InEditPayments");

            migrationBuilder.DropTable(
                name: "InEditSanads");

            migrationBuilder.DropTable(
                name: "InEditSefaresh");

            migrationBuilder.DropTable(
                name: "Ins2factor");

            migrationBuilder.DropTable(
                name: "KAFactorL");

            migrationBuilder.DropTable(
                name: "KalaM");

            migrationBuilder.DropTable(
                name: "KalaT");

            migrationBuilder.DropTable(
                name: "Mantagh");

            migrationBuilder.DropTable(
                name: "MoshtariTkmili");

            migrationBuilder.DropTable(
                name: "NoteBook");

            migrationBuilder.DropTable(
                name: "Payment2");

            migrationBuilder.DropTable(
                name: "RFactor2");

            migrationBuilder.DropTable(
                name: "RKhadamat");

            migrationBuilder.DropTable(
                name: "RPayment2");

            migrationBuilder.DropTable(
                name: "RSanadITM");

            migrationBuilder.DropTable(
                name: "Sanad1400s");

            migrationBuilder.DropTable(
                name: "Sefaresh2");

            migrationBuilder.DropTable(
                name: "SMS");

            migrationBuilder.DropTable(
                name: "Tashaboh");

            migrationBuilder.DropTable(
                name: "Vahed");

            migrationBuilder.DropTable(
                name: "KAFactor");

            migrationBuilder.DropTable(
                name: "Check");

            migrationBuilder.DropTable(
                name: "RFactor1");

            migrationBuilder.DropTable(
                name: "RPayment1");

            migrationBuilder.DropTable(
                name: "RSanad");

            migrationBuilder.DropTable(
                name: "Sefaresh1");

            migrationBuilder.DropTable(
                name: "GorohT");

            migrationBuilder.DropTable(
                name: "Kala");

            migrationBuilder.DropTable(
                name: "SanadITM");

            migrationBuilder.DropTable(
                name: "GorohK");

            migrationBuilder.DropTable(
                name: "Factor1");

            migrationBuilder.DropTable(
                name: "Khadamat");

            migrationBuilder.DropTable(
                name: "Anbar");

            migrationBuilder.DropTable(
                name: "Payment1");

            migrationBuilder.DropTable(
                name: "Moshtari");

            migrationBuilder.DropTable(
                name: "Sanad");

            migrationBuilder.DropTable(
                name: "GorohM");

            migrationBuilder.DropTable(
                name: "Onvan");

            migrationBuilder.DropTable(
                name: "Goroh");
        }
    }
}
