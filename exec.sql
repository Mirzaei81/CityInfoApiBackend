INSERT INTO [__EFMigrationsHistory] ([MIGRATIONID], [PRODUCTVERSION])
VALUES (N'20240507124530_init', N'7.0.5');
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.0 initialized 'AlmasACC14031Context' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.0' with options: None
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Bar1] (
    [B_No] int NOT NULL,
    [B_Date] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [B_Anbar] tinyint NOT NULL,
    [B_Prsn] int NULL,
    [B_Barnameh] nvarchar(50) COLLATE Arabic_CI_AI NOT NULL,
    [B_DateB] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [B_Mashin] nvarchar(100) COLLATE Arabic_CI_AI NOT NULL,
    [B_NameN] nvarchar(100) COLLATE Arabic_CI_AI NOT NULL,
    [B_Kala] int NULL,
    [B_NumKoli] int NULL,
    [B_Num] float NULL,
    [B_Num2] float NULL,
    [B_Mab] float NULL,
    [B_Mab2] float NULL,
    [B_Sharh] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [B_Bar] float NULL,
    [B_BarGry] float NULL,
    [B_Hazine] float NULL,
    [B_KsrBar] float NULL,
    [B_EzfBar] float NULL,
    [B_ZNumKoli] int NULL,
    [B_ZNum] float NULL,
    [B_ZNum2] float NULL,
    [B_DrsdPorsant] float NULL,
    [B_MabPorsant] int NULL,
    [B_Sanad] int NULL,
    [B_Flag] bit NULL,
    [B_User] tinyint NULL,
    [B_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [B_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [B_VznZrf] float NULL,
    [B_InputBar] float NULL,
    [B_InputBarGry] float NULL,
    CONSTRAINT [PK_Bar1] PRIMARY KEY ([B_No])
);
GO

CREATE TABLE [Bar2] (
    [B2_No] int NOT NULL,
    [B2_Radif] int NOT NULL,
    [B2_Moshtari] int NULL,
    [B2_NumKoli] int NULL,
    [B2_Num] float NULL,
    [B2_Num2] float NULL,
    [B2_Mab] bigint NULL,
    [B2_DateF] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [B2_Sharh] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [B2_KindPay] tinyint NULL,
    [B2_NoPay] bigint NULL,
    [B2_Discount] float NULL
);
GO

CREATE TABLE [Ghest] (
    [GH_Moshtari] int NOT NULL,
    [GH_No] int NOT NULL,
    [GH_Date] char(10) NOT NULL,
    [GH_Mab] float NULL,
    [GH_DateV] char(10) NOT NULL,
    [GH_Shrh] nvarchar(90) NULL,
    [GH_Payment] bigint NULL,
    [GH_CODEMELI] varchar(15) NULL,
    [GH_DATEVAM] varchar(10) NULL,
    [GH_MABKOLVAM] int NULL,
    [GH_VAMACC] char(8) NULL,
    CONSTRAINT [PK_Ghest] PRIMARY KEY ([GH_Moshtari], [GH_No])
);
GO

CREATE TABLE [Goroh] (
    [GH_Code] tinyint NOT NULL,
    [GH_Name] nvarchar(20) COLLATE Arabic_CI_AI NOT NULL,
    [GH_Kind] int NOT NULL,
    [GH_Mahiat] int NOT NULL,
    CONSTRAINT [PK_Goroh] PRIMARY KEY ([GH_Code])
);
GO

CREATE TABLE [GorohK] (
    [GK_Code] int NOT NULL,
    [GK_Name] nvarchar(30) COLLATE Arabic_CI_AI NULL,
    [GK_inKharid] bit NOT NULL DEFAULT ((1)),
    [GK_inForosh] bit NOT NULL DEFAULT ((1)),
    [GK_inKhadmat] bit NOT NULL DEFAULT ((1)),
    CONSTRAINT [PK_GroupK] PRIMARY KEY ([GK_Code])
);
GO

CREATE TABLE [GorohM] (
    [GM_Code] int NOT NULL,
    [GM_Name] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [GM_inKharid] bit NOT NULL DEFAULT ((1)),
    [GM_inForosh] bit NOT NULL DEFAULT ((1)),
    [GM_inPosnt] bit NOT NULL DEFAULT ((1)),
    CONSTRAINT [PK_GroupM] PRIMARY KEY ([GM_Code])
);
GO

CREATE TABLE [GorohT] (
    [T_Code] int NOT NULL,
    [T_Name] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Table1] PRIMARY KEY ([T_Code])
);
GO

CREATE TABLE [HsbPrsnsKolis] (
    [Brws] smallint NULL,
    [KindFactor] nvarchar(1) NOT NULL,
    [Date] nvarchar(max) NULL,
    [No] int NOT NULL,
    [kind] nvarchar(max) NULL,
    [Sharh] nvarchar(max) NULL,
    [Bes] float NOT NULL,
    [Bed] float NOT NULL,
    [F_Factor] bigint NOT NULL,
    [F] int NULL,
    [Mande] int NOT NULL
);
GO

CREATE TABLE [Ins2factor] (
    [RowsAffected] int NOT NULL
);
GO

CREATE TABLE [Mantagh] (
    [Code_Mantagh] int NOT NULL,
    [Name_Mantagh] nvarchar(40) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK__Mantagh__2F650636] PRIMARY KEY ([Code_Mantagh])
);
GO

CREATE TABLE [NoteBook] (
    [Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [Note] text COLLATE Arabic_CI_AI NULL
);
GO

CREATE TABLE [RFactor1] (
    [R_No] bigint NOT NULL,
    [F_Factor] int NOT NULL,
    [F_No] int NOT NULL,
    [F_Kind] tinyint NOT NULL,
    [F_Mrkaz] tinyint NOT NULL,
    [F_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [F_Anbar] tinyint NOT NULL,
    [F_Moshtari] int NULL,
    [F_Serial] int NULL,
    [F_DateTahvil] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_Mab] float NULL,
    [F_MabKol] float NULL,
    [F_Porsant] int NULL,
    [F_MabPorsant] float NULL,
    [F_KindPay] tinyint NULL,
    [F_NoPay] bigint NULL,
    [F_Sanad] int NULL,
    [F_Flag] bit NULL,
    [F_DateA] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_User] tinyint NULL,
    [F_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [F_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_Kosor] float NULL,
    [F_Ezafat] float NULL,
    [F_Anbar2] tinyint NULL,
    [F_AccKosorat] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_AccEzafat] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_FixKosorat] bit NULL,
    [F_FixEzafat] bit NULL,
    [F_FixPorsant] bit NULL,
    [F_Print] int NULL,
    [F_Kdarsad] bit NULL DEFAULT ((0)),
    [F_AccAnbar] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_Maliat] float NULL,
    [F_Avarez] float NULL,
    [F_DriverName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_RFactor1] PRIMARY KEY ([R_No])
);
GO

CREATE TABLE [RKhadamat] (
    [R_No] bigint NOT NULL,
    [Kh_Markaz] tinyint NULL,
    [Kh_No] bigint NULL,
    [Kh_Date] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_Moshtari] int NULL,
    [Kh_MName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Sanad] int NULL,
    [Kh_User] int NULL,
    [Kh_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [Kh_Serial] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Shrh] text COLLATE Arabic_CI_AI NULL,
    [Kh_Acc] varchar(8) COLLATE Arabic_CI_AI NULL,
    [Kh_Shrh2] text COLLATE Arabic_CI_AI NULL,
    [Kh_Kind] text COLLATE Arabic_CI_AI NULL,
    [Kh_Motealegh] text COLLATE Arabic_CI_AI NULL,
    [Kh_Serial2] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Factor] int NULL,
    [Kh_DateF] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_DateG] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_Ojrat] float NULL,
    [Kh_Ghatat] float NULL,
    [Kh_Sum] float NULL,
    [Kh_NoPay] bigint NULL,
    [Kh_KindPay] tinyint NULL,
    [Kh_DateT] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_KalaName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_RKhadamat] PRIMARY KEY ([R_No])
);
GO

CREATE TABLE [RPayment1] (
    [R_No] bigint NOT NULL,
    [P1_Markaz] tinyint NULL,
    [P1_Kind] tinyint NOT NULL,
    [P1_No] bigint NOT NULL,
    [P1_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [P1_Moshtari] int NULL,
    [P1_Sanad] int NULL,
    [P1_IsArz] bit NOT NULL,
    [P1_User] int NULL,
    [P1_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [P1_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [P1_Sum] float NULL,
    [P1_Acc1] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P1_Acc2] varchar(8) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_RPayment1] PRIMARY KEY ([R_No])
);
GO

CREATE TABLE [RSanad] (
    [R_No] bigint NOT NULL,
    [S_No] int NOT NULL,
    [S_Sanad] int NOT NULL,
    [S_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [S_Markaz] tinyint NULL,
    [S_Flag] bit NOT NULL,
    [S_User] int NULL,
    [S_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [S_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [S_Temp] bit NULL,
    [S_Print] int NULL,
    [S_InEdit] bit NOT NULL,
    [S_IsArz] bit NOT NULL,
    [S_Type] char(1) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_RSanad] PRIMARY KEY ([R_No])
);
GO

CREATE TABLE [Sanad] (
    [S_Sanad] int NOT NULL,
    [S_No] int NOT NULL,
    [S_Date] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [S_Markaz] tinyint NULL,
    [S_Flag] bit NOT NULL,
    [S_User] int NULL,
    [S_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [S_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [S_Temp] bit NULL,
    [S_Print] int NULL DEFAULT ((0)),
    [S_InEdit] bit NOT NULL,
    [S_IsArz] bit NOT NULL,
    [S_Type] char(1) COLLATE Arabic_CI_AI NULL DEFAULT (('H')),
    CONSTRAINT [PK_Sanad] PRIMARY KEY ([S_Sanad])
);
GO

CREATE TABLE [Sanad1400s] (
    [s_user] int NOT NULL,
    [s_date] int NOT NULL
);
GO

CREATE TABLE [Sefaresh1] (
    [S1_No] int NOT NULL,
    [S1_Mrkaz] tinyint NOT NULL,
    [S1_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [S1_Vahed] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [S1_Kind] bit NOT NULL,
    [S1_User] int NOT NULL,
    [S1_Foroshande] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Sefaresh1_1] PRIMARY KEY ([S1_No])
);
GO

CREATE TABLE [SMS] (
    [ID] int NOT NULL IDENTITY,
    [CreateDate] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [CreateTime] char(5) COLLATE Arabic_CI_AI NOT NULL,
    [Tel] varchar(11) COLLATE Arabic_CI_AI NOT NULL,
    [txt] nvarchar(250) COLLATE Arabic_CI_AI NULL,
    [Type] char(1) COLLATE Arabic_CI_AI NULL,
    [SendDate] char(10) COLLATE Arabic_CI_AI NULL,
    [SendTime] char(5) COLLATE Arabic_CI_AI NULL,
    [Status] char(1) COLLATE Arabic_CI_AI NULL,
    [DeliverDate] char(10) COLLATE Arabic_CI_AI NULL,
    [DeliverTime] char(5) COLLATE Arabic_CI_AI NULL,
    [DeliverStatus] char(1) COLLATE Arabic_CI_AI NULL,
    [DeliverMessage] nvarchar(250) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_SMS] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Vahed] (
    [V_Code] int NOT NULL,
    [V_Name] nvarchar(8) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    CONSTRAINT [PK_VAHED] PRIMARY KEY ([V_Code])
);
GO

CREATE TABLE [Onvan] (
    [O_Acc] varchar(8) COLLATE Arabic_CI_AI NOT NULL,
    [O_Goroh] tinyint NULL,
    [O_Kol] varchar(2) COLLATE Arabic_CI_AI NULL,
    [O_Moein] varchar(2) COLLATE Arabic_CI_AI NULL,
    [O_Tfzili] varchar(4) COLLATE Arabic_CI_AI NULL,
    [O_Name] nvarchar(40) COLLATE Arabic_CI_AI NULL,
    [O_Sub] bit NOT NULL,
    [O_Bed] bigint NULL,
    [O_Bes] bigint NULL,
    [O_ArzBed] float NULL,
    [O_ArzBes] float NULL,
    [O_Sanad] int NULL,
    [O_Kind] int NOT NULL,
    [O_Temp] bit NULL,
    [O_InUsed] bit NULL DEFAULT ((0)),
    [O_Flag] bit NULL DEFAULT ((1)),
    [O_NoDarayi] smallint NULL,
    [O_BedBes] tinyint NULL DEFAULT ((0)),
    CONSTRAINT [PK_Onvan] PRIMARY KEY ([O_Acc]),
    CONSTRAINT [FK_Onvan_Goroh] FOREIGN KEY ([O_Goroh]) REFERENCES [Goroh] ([GH_Code])
);
GO

CREATE TABLE [Kala] (
    [K_Code] int NOT NULL,
    [K_Goroh] int NOT NULL,
    [K_Name] nvarchar(60) COLLATE Arabic_CI_AI NULL,
    [K_Vahed] nvarchar(8) COLLATE Arabic_CI_AI NULL,
    [K_VahedKoli] nvarchar(8) COLLATE Arabic_CI_AI NULL,
    [K_Zarib] float NULL,
    [K_ForoshM] float NULL,
    [K_Arz] tinyint NULL,
    [K_ArzMab] float NULL,
    [K_MinF] float NULL,
    [K_MaxF] float NULL,
    [K_ForoshH] float NULL,
    [K_Fani] nvarchar(15) COLLATE Arabic_CI_AI NULL,
    [K_Sharh] ntext COLLATE Arabic_CI_AI NULL,
    [K_Pic] image NULL,
    [K_Log] bit NULL DEFAULT ((1)),
    [K_Lan] tinyint NULL DEFAULT ((0)),
    [K_NameL] nvarchar(30) COLLATE Arabic_CI_AI NULL,
    [K_Tolid] float NULL,
    [K_HTolid] float NULL,
    [K_Sarbar] float NULL,
    [K_HTmam] float NULL,
    [K_Barcode] nvarchar(40) NULL,
    [K_Omde] float NULL,
    [K_Vazn] float NULL,
    [K_Darsad] float NULL,
    [K_Keshvar] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [K_FMonth] float NULL,
    [K_FYear] float NULL,
    [K_FMonth2] float NULL,
    [K_FMonth3] float NULL,
    [K_FMonth4] float NULL,
    [K_FMonth1] float NULL,
    [K_FMonth5] float NULL,
    [K_FMonth6] float NULL,
    [K_FMonth7] float NULL,
    [K_FMonth8] float NULL,
    [K_FMonth9] float NULL,
    [K_FMonth10] float NULL,
    [K_FMonth11] float NULL,
    [K_FMonth12] float NULL,
    [K_MaliatIs] bit NULL,
    [K_Maliat] float NULL,
    [K_AvarezIs] bit NULL,
    [K_Avarez] float NULL,
    [K_fani2] nvarchar(15) COLLATE Arabic_CI_AI NULL,
    [K_Porsant] float NULL,
    [K_IsBarcode] bit NULL,
    [K_ForoshN] bigint NULL,
    [K_ForoshMd] bigint NULL,
    [K_ForoshMsrf] bigint NULL,
    CONSTRAINT [PK_KALA] PRIMARY KEY ([K_Code]),
    CONSTRAINT [FK_Kala_GorohK] FOREIGN KEY ([K_Goroh]) REFERENCES [GorohK] ([GK_Code])
);
GO

CREATE TABLE [RFactor2] (
    [R_No] bigint NULL,
    [FK_Factor] int NOT NULL,
    [FK_Radif] int NOT NULL,
    [FK_Kala] int NULL,
    [FK_Num] float NULL,
    [FK_NumKoli] int NULL,
    [FK_Tol] float NULL,
    [FK_Arze] float NULL,
    [FK_V] tinyint NULL,
    [FK_Tdad] smallint NULL,
    [FK_Mab] float NULL,
    [FK_KindArz] tinyint NULL,
    [FK_Arz] float NULL,
    [FK_Modat] bit NULL,
    [FK_DateModat] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [FK_Sharh] nvarchar(80) COLLATE Arabic_CI_AI NULL,
    [FK_Kdarsad] float NULL,
    [FK_Maliat] float NULL,
    [FK_Avarez] float NULL,
    CONSTRAINT [FK_RFactor2_RFactor1] FOREIGN KEY ([R_No]) REFERENCES [RFactor1] ([R_No])
);
GO

CREATE TABLE [RPayment2] (
    [R_No] bigint NULL,
    [P2_Kind] tinyint NOT NULL,
    [P2_No] bigint NOT NULL,
    [P2_Radif] int NOT NULL,
    [P2_KindP] tinyint NULL,
    [P2_Check] int NULL,
    [P2_Acc] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P2_Shrh] nvarchar(80) COLLATE Arabic_CI_AI NULL,
    [P2_Mab] float NULL,
    [P2_Acc2] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P2_ArzMab] float NULL,
    [P2_ArzType] tinyint NULL,
    [P2_KindC] smallint NULL,
    [P2_ArzKol] float NULL,
    CONSTRAINT [FK_RPayment2_RPayment1] FOREIGN KEY ([R_No]) REFERENCES [RPayment1] ([R_No])
);
GO

CREATE TABLE [RSanadITM] (
    [R_No] bigint NOT NULL,
    [S_Sanad] int NOT NULL,
    [Radif] int NOT NULL,
    [Acc] varchar(8) COLLATE Arabic_CI_AI NOT NULL,
    [Sharh] nvarchar(250) COLLATE Arabic_CI_AI NULL,
    [Bed] float NOT NULL,
    [ArzBed] float NULL,
    [Bes] float NOT NULL,
    [ArzBes] float NULL,
    [A_Code] tinyint NULL,
    [F_Factor] int NULL,
    [P_Payment] bigint NULL,
    [P_Kind] tinyint NULL,
    [H_Hesab] int NULL,
    [Kh_Khadamat] bigint NULL,
    [ArzKol] float NULL,
    [B_bar] int NULL,
    CONSTRAINT [FK_RSanadITM_RSanad] FOREIGN KEY ([R_No]) REFERENCES [RSanad] ([R_No])
);
GO

CREATE TABLE [InEditSanads] (
    [S_Sanad] int NOT NULL,
    [User] int NULL,
    [DateTime] datetime NULL,
    CONSTRAINT [PK_InEditSanads] PRIMARY KEY ([S_Sanad]),
    CONSTRAINT [FK_InEditSanads_Sanad] FOREIGN KEY ([S_Sanad]) REFERENCES [Sanad] ([S_Sanad])
);
GO

CREATE TABLE [InEditSefaresh] (
    [S1_No] int NOT NULL,
    [User] int NULL,
    [DateTime] datetime NULL,
    CONSTRAINT [FK_InEditSefaresh_Sefaresh1] FOREIGN KEY ([S1_No]) REFERENCES [Sefaresh1] ([S1_No])
);
GO

CREATE TABLE [Anbar] (
    [A_Code] tinyint NOT NULL,
    [A_Name] nvarchar(30) COLLATE Arabic_CI_AI NULL,
    [A_NameA] nvarchar(30) COLLATE Arabic_CI_AI NULL,
    [A_Flag] bit NULL DEFAULT ((1)),
    [A_Acc1] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc2] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc3] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc4] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc5] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc6] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc9] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc10] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc11] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc12] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc13] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc14] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc19] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc22] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc23] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc24] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc7] varchar(8) COLLATE Arabic_CI_AI NULL,
    [A_Acc16] varchar(8) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_ANBAR] PRIMARY KEY ([A_Code]),
    CONSTRAINT [FK__Anbar__A_Acc16__407061FE] FOREIGN KEY ([A_Acc16]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK__Anbar__A_Acc7__41648637] FOREIGN KEY ([A_Acc7]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan] FOREIGN KEY ([A_Acc1]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan1] FOREIGN KEY ([A_Acc3]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan10] FOREIGN KEY ([A_Acc13]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan11] FOREIGN KEY ([A_Acc14]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan12] FOREIGN KEY ([A_Acc2]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan13] FOREIGN KEY ([A_Acc22]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan14] FOREIGN KEY ([A_Acc23]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan15] FOREIGN KEY ([A_Acc24]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan2] FOREIGN KEY ([A_Acc4]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan3] FOREIGN KEY ([A_Acc5]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan4] FOREIGN KEY ([A_Acc19]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan5] FOREIGN KEY ([A_Acc6]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan6] FOREIGN KEY ([A_Acc9]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan7] FOREIGN KEY ([A_Acc10]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan8] FOREIGN KEY ([A_Acc11]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Anbar_Onvan9] FOREIGN KEY ([A_Acc12]) REFERENCES [Onvan] ([O_Acc])
);
GO

CREATE TABLE [KAFactor] (
    [KA_Factor] varchar(2) COLLATE Arabic_CI_AI NOT NULL,
    [KA_Name] varchar(25) COLLATE Arabic_CI_AI NULL,
    [KA_Kind] bit NULL,
    [KA_Darsad] float NULL,
    [KA_Sabet] float NULL,
    [KA_Acc] varchar(8) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_KAFactor] PRIMARY KEY ([KA_Factor]),
    CONSTRAINT [FK_KAFactor_Onvan] FOREIGN KEY ([KA_Acc]) REFERENCES [Onvan] ([O_Acc])
);
GO

CREATE TABLE [Moshtari] (
    [M_Code] int NOT NULL,
    [M_Goroh] int NOT NULL,
    [M_Name] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Atbar] bigint NULL,
    [M_Tel1] varchar(15) NULL,
    [M_Tel2] varchar(15) NULL,
    [M_Mobil] varchar(11) COLLATE Arabic_CI_AI NULL,
    [M_Address] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [M_Meli] varchar(30) NULL,
    [M_Log] bit NULL,
    [M_LogHsab] bit NULL,
    [M_Kol] char(2) NOT NULL,
    [M_Moein] char(2) NOT NULL,
    [M_Tfzili] char(4) NOT NULL,
    [M_Acc] varchar(8) COLLATE Arabic_CI_AI NOT NULL,
    [M_Pic] image NULL,
    [M_Txt] text COLLATE Arabic_CI_AI NULL,
    [M_Hmkar] tinyint NULL,
    [M_Lan] tinyint NULL,
    [M_NameL] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Onvan] tinyint NULL,
    [M_DateList] char(8) COLLATE Arabic_CI_AI NULL,
    [M_Economy] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Post] varchar(11) COLLATE Arabic_CI_AI NULL,
    [M_City] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Ostan] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Porsant] float NULL,
    [M_Email] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [M_CodeMantagh] int NULL,
    [M_Tel3] varchar(20) COLLATE Arabic_CI_AI NULL,
    [M_Tel4] varchar(20) COLLATE Arabic_CI_AI NULL,
    [M_Mobile2] varchar(20) COLLATE Arabic_CI_AI NULL,
    [M_TelSMS] bit NULL,
    [M_SABT] varchar(20) COLLATE Arabic_CI_AI NULL,
    [M_MODIR] bit NOT NULL,
    CONSTRAINT [PK_MOSHTARI] PRIMARY KEY ([M_Code]),
    CONSTRAINT [FK_Moshtari_GorohM] FOREIGN KEY ([M_Goroh]) REFERENCES [GorohM] ([GM_Code]),
    CONSTRAINT [FK_Moshtari_Onvan] FOREIGN KEY ([M_Acc]) REFERENCES [Onvan] ([O_Acc]) ON DELETE CASCADE
);
GO

CREATE TABLE [KalaT] (
    [T_Kala] int NOT NULL,
    [T_Radif] int NOT NULL,
    [T_KalaITM] int NULL,
    [T_Num] float NULL DEFAULT ((0)),
    [T_Mab] float NULL DEFAULT ((0)),
    CONSTRAINT [PK_KalaT] PRIMARY KEY ([T_Kala], [T_Radif]),
    CONSTRAINT [FK_KalaT_Kala] FOREIGN KEY ([T_Kala]) REFERENCES [Kala] ([K_Code]),
    CONSTRAINT [FK_KalaT_Kala1] FOREIGN KEY ([T_KalaITM]) REFERENCES [Kala] ([K_Code])
);
GO

CREATE TABLE [Sefaresh2] (
    [S2_No] int NOT NULL,
    [S2_Radif] smallint NOT NULL,
    [S2_Kala] int NOT NULL,
    [S2_Num] float NOT NULL,
    [S2_Shrh] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [S2_DateR] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [S2_Kind] tinyint NOT NULL,
    [S2_Num2] float NULL,
    [S2_DateE] char(10) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Sefaresh2] PRIMARY KEY ([S2_No], [S2_Radif]),
    CONSTRAINT [FK_Sefaresh2_Kala] FOREIGN KEY ([S2_Kala]) REFERENCES [Kala] ([K_Code]),
    CONSTRAINT [FK_Sefaresh2_Sefaresh1] FOREIGN KEY ([S2_No]) REFERENCES [Sefaresh1] ([S1_No])
);
GO

CREATE TABLE [Tashaboh] (
    [T_Code] int NOT NULL,
    [K_Code] int NOT NULL,
    CONSTRAINT [PK_Tashaboh] PRIMARY KEY ([T_Code], [K_Code]),
    CONSTRAINT [FK_Tashaboh_GorohT] FOREIGN KEY ([T_Code]) REFERENCES [GorohT] ([T_Code]),
    CONSTRAINT [FK_Tashaboh_Kala] FOREIGN KEY ([K_Code]) REFERENCES [Kala] ([K_Code])
);
GO

CREATE TABLE [KalaM] (
    [KM_Code] int NOT NULL,
    [KM_Anbar] tinyint NOT NULL,
    [KM_MojKol] float NULL,
    [KM_Moj] float NULL,
    [KM_Arzesh] float NULL,
    [KM_MinMoj] float NULL,
    [KM_Sefaresh] float NULL,
    [KM_Radif] varchar(30) COLLATE Arabic_CI_AI NULL,
    [KM_Shomaresh] float NULL DEFAULT ((0)),
    [KM_EndMoj] float NULL,
    [KM_EndMojKol] float NULL,
    [KM_EndArzesh] float NULL,
    [KM_LastArzesh] bigint NULL DEFAULT ((0)),
    [KM_ArzArzesh] float NULL,
    [KM_EndArzArzesh] float NULL,
    [KM_LastArzArzesh] bigint NULL,
    [KM_MaxMoj] float NULL,
    [KM_KindArz] tinyint NULL,
    [K_Keshvar] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_KalaM] PRIMARY KEY ([KM_Code], [KM_Anbar]),
    CONSTRAINT [FK_KalaM_Anbar] FOREIGN KEY ([KM_Anbar]) REFERENCES [Anbar] ([A_Code]),
    CONSTRAINT [FK_KalaM_Kala] FOREIGN KEY ([KM_Code]) REFERENCES [Kala] ([K_Code])
);
GO

CREATE TABLE [MoshtariTkmili] (
    [M_CodeM] int NOT NULL,
    [M_Father] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Tavalod] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [M_Sadere] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Shnasnameh] varchar(50) COLLATE Arabic_CI_AI NULL,
    [M_AddressMnzl] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [M_AddressKar] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [M_Vsighe] char(1) COLLATE Arabic_CI_AI NULL,
    [M_DateFirst] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [M_DateEnd] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [M_Zmn1] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Zmn1CodeMli] nvarchar(10) COLLATE Arabic_CI_AI NULL,
    [M_Zmn1Tel] nvarchar(20) COLLATE Arabic_CI_AI NULL,
    [M_Zmn1Address] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [M_Zmn1Vsighe] char(1) COLLATE Arabic_CI_AI NULL,
    [M_Zmn2] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Zmn2CodeMli] nvarchar(10) COLLATE Arabic_CI_AI NULL,
    [M_Zmn2Tel] nvarchar(20) COLLATE Arabic_CI_AI NULL,
    [M_Zmn2Address] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [M_Zmn2Vsighe] char(1) COLLATE Arabic_CI_AI NULL,
    [M_Zmn3] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [M_Zmn3CodeMli] nvarchar(10) COLLATE Arabic_CI_AI NULL,
    [M_Zmn3Tel] nvarchar(20) COLLATE Arabic_CI_AI NULL,
    [M_Zmn3Address] nvarchar(200) COLLATE Arabic_CI_AI NULL,
    [M_Zmn3Vsighe] char(1) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_MoshtariTkmili] PRIMARY KEY ([M_CodeM]),
    CONSTRAINT [FK_MoshtariTkmili_Moshtari] FOREIGN KEY ([M_CodeM]) REFERENCES [Moshtari] ([M_Code]) ON DELETE CASCADE
);
GO

CREATE TABLE [Payment1] (
    [P1_Kind] tinyint NOT NULL,
    [P1_No] bigint NOT NULL,
    [P1_Markaz] tinyint NULL,
    [P1_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [P1_Moshtari] int NULL,
    [P1_Sanad] int NULL,
    [P1_IsArz] bit NULL DEFAULT ((0)),
    [P1_User] int NULL,
    [P1_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [P1_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [P1_Sum] float NULL DEFAULT ((0)),
    [P1_Acc1] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P1_Acc2] varchar(8) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Payment1] PRIMARY KEY ([P1_Kind], [P1_No]),
    CONSTRAINT [FK_Payment1_Moshtari] FOREIGN KEY ([P1_Moshtari]) REFERENCES [Moshtari] ([M_Code]),
    CONSTRAINT [FK_Payment1_Onvan] FOREIGN KEY ([P1_Acc1]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Payment1_Onvan1] FOREIGN KEY ([P1_Acc2]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Payment1_Sanad] FOREIGN KEY ([P1_Sanad]) REFERENCES [Sanad] ([S_Sanad])
);
GO

CREATE TABLE [Factor1] (
    [F_Factor] int NOT NULL,
    [F_No] int NOT NULL,
    [F_Kind] tinyint NOT NULL,
    [F_Mrkaz] tinyint NOT NULL,
    [F_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [F_Anbar] tinyint NOT NULL,
    [F_Moshtari] int NULL,
    [F_Serial] int NULL,
    [F_DateTahvil] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_Mab] float NULL DEFAULT ((0)),
    [F_MabKol] float NULL DEFAULT ((0)),
    [F_Porsant] int NULL,
    [F_MabPorsant] float NULL,
    [F_KindPay] tinyint NULL,
    [F_NoPay] bigint NULL,
    [F_Sanad] int NULL,
    [F_Flag] bit NULL,
    [F_DateA] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_User] tinyint NULL,
    [F_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [F_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [F_Kosor] float NULL DEFAULT ((0)),
    [F_Ezafat] float NULL DEFAULT ((0)),
    [F_Anbar2] tinyint NULL,
    [F_AccKosorat] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_AccEzafat] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_FixKosorat] bit NULL,
    [F_FixEzafat] bit NULL,
    [F_FixPorsant] bit NULL,
    [F_Print] int NULL DEFAULT ((0)),
    [F_Kdarsad] bit NULL DEFAULT ((0)),
    [F_AccAnbar] varchar(8) COLLATE Arabic_CI_AI NULL,
    [F_Maliat] float NULL,
    [F_Avarez] float NULL,
    [F_DriverName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Factor1] PRIMARY KEY ([F_Factor]),
    CONSTRAINT [FK_FACTOR_ANBAR] FOREIGN KEY ([F_Anbar]) REFERENCES [Anbar] ([A_Code]),
    CONSTRAINT [FK_Factor1_Anbar] FOREIGN KEY ([F_Anbar2]) REFERENCES [Anbar] ([A_Code]),
    CONSTRAINT [FK_Factor1_Moshtari] FOREIGN KEY ([F_Moshtari]) REFERENCES [Moshtari] ([M_Code]),
    CONSTRAINT [FK_Factor1_Moshtari1] FOREIGN KEY ([F_Porsant]) REFERENCES [Moshtari] ([M_Code]),
    CONSTRAINT [FK_Factor1_Onvan] FOREIGN KEY ([F_AccKosorat]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Factor1_Onvan1] FOREIGN KEY ([F_AccEzafat]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Factor1_Payment1] FOREIGN KEY ([F_KindPay], [F_NoPay]) REFERENCES [Payment1] ([P1_Kind], [P1_No]),
    CONSTRAINT [FK_Factor1_Sanad] FOREIGN KEY ([F_Sanad]) REFERENCES [Sanad] ([S_Sanad])
);
GO

CREATE TABLE [InEditPayments] (
    [P1_Kind] tinyint NOT NULL,
    [P1_No] bigint NOT NULL,
    [User] int NULL,
    [DateTime] datetime NULL,
    CONSTRAINT [PK_InEditPayment] PRIMARY KEY ([P1_No], [P1_Kind]),
    CONSTRAINT [FK_InEditPayment_Payment1] FOREIGN KEY ([P1_Kind], [P1_No]) REFERENCES [Payment1] ([P1_Kind], [P1_No])
);
GO

CREATE TABLE [Khadamat] (
    [Kh_No] bigint NOT NULL,
    [Kh_Markaz] tinyint NOT NULL,
    [Kh_Date] char(10) COLLATE Arabic_CI_AI NOT NULL DEFAULT (('____/__/__')),
    [Kh_Moshtari] int NULL,
    [Kh_MName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Sanad] int NULL,
    [Kh_User] int NULL,
    [Kh_DateU] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_TimeU] char(5) COLLATE Arabic_CI_AI NULL,
    [Kh_Serial] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Shrh] nvarchar(500) COLLATE Arabic_CI_AI NULL,
    [Kh_Acc] varchar(8) COLLATE Arabic_CI_AI NULL,
    [Kh_Shrh2] text COLLATE Arabic_CI_AI NULL,
    [Kh_Kind] text COLLATE Arabic_CI_AI NULL,
    [Kh_Motealegh] text COLLATE Arabic_CI_AI NULL,
    [Kh_Serial2] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    [Kh_Factor] int NULL,
    [Kh_DateF] varchar(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_DateG] varchar(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_Ojrat] float NULL,
    [Kh_Ghatat] float NULL,
    [Kh_Sum] float NULL DEFAULT ((0)),
    [Kh_NoPay] bigint NULL,
    [Kh_KindPay] tinyint NULL,
    [Kh_DateT] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [Kh_KalaName] nvarchar(100) COLLATE Arabic_CI_AI NULL,
    CONSTRAINT [PK_Khadamat] PRIMARY KEY ([Kh_No]),
    CONSTRAINT [FK_Khadamat_Moshtari] FOREIGN KEY ([Kh_Moshtari]) REFERENCES [Moshtari] ([M_Code]),
    CONSTRAINT [FK_Khadamat_Onvan] FOREIGN KEY ([Kh_Acc]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Khadamat_Payment1] FOREIGN KEY ([Kh_KindPay], [Kh_NoPay]) REFERENCES [Payment1] ([P1_Kind], [P1_No]),
    CONSTRAINT [FK_Khadamat_Sanad] FOREIGN KEY ([Kh_Sanad]) REFERENCES [Sanad] ([S_Sanad])
);
GO

CREATE TABLE [Factor2] (
    [FK_Factor] int NOT NULL,
    [FK_Radif] int NOT NULL,
    [FK_Kala] int NULL,
    [FK_Num] float NULL,
    [FK_NumKoli] int NULL,
    [FK_Tol] float NULL,
    [FK_Arze] float NULL,
    [FK_V] tinyint NULL,
    [FK_Tdad] smallint NULL,
    [FK_Mab] float NULL,
    [FK_KindArz] tinyint NULL,
    [FK_Arz] float NULL,
    [FK_Modat] bit NULL,
    [FK_DateModat] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [FK_Sharh] nvarchar(80) COLLATE Arabic_CI_AI NULL,
    [FK_Kdarsad] float NULL,
    [FK_Maliat] float NULL,
    [FK_Avarez] float NULL,
    CONSTRAINT [PK_Factor2] PRIMARY KEY ([FK_Factor], [FK_Radif]),
    CONSTRAINT [FK_Factor2_Factor1] FOREIGN KEY ([FK_Factor]) REFERENCES [Factor1] ([F_Factor]) ON DELETE CASCADE,
    CONSTRAINT [FK_Factor2_Kala] FOREIGN KEY ([FK_Kala]) REFERENCES [Kala] ([K_Code])
);
GO

CREATE TABLE [InEditFactors] (
    [F_Factor] int NOT NULL,
    [User] int NULL,
    [DateTime] datetime NULL,
    CONSTRAINT [PK_InEditFactors] PRIMARY KEY ([F_Factor]),
    CONSTRAINT [FK_InEditFactors_Factor1] FOREIGN KEY ([F_Factor]) REFERENCES [Factor1] ([F_Factor])
);
GO

CREATE TABLE [KAFactorL] (
    [L_Factor] int NOT NULL,
    [L_KA] varchar(2) COLLATE Arabic_CI_AI NOT NULL,
    [L_Darsad] float NULL,
    [L_Sabet] float NULL,
    CONSTRAINT [PK_KAFactorL] PRIMARY KEY ([L_Factor], [L_KA]),
    CONSTRAINT [FK_KAFactorL_Factor1] FOREIGN KEY ([L_Factor]) REFERENCES [Factor1] ([F_Factor]),
    CONSTRAINT [FK_KAFactorL_KAFactor] FOREIGN KEY ([L_KA]) REFERENCES [KAFactor] ([KA_Factor])
);
GO

CREATE TABLE [InEditKhadamat] (
    [Kh_No] bigint NOT NULL,
    [User] int NULL,
    [DateTime] datetime NULL,
    CONSTRAINT [PK_InEditKhadamat] PRIMARY KEY ([Kh_No]),
    CONSTRAINT [FK_InEditKhadamat_Khadamat] FOREIGN KEY ([Kh_No]) REFERENCES [Khadamat] ([Kh_No])
);
GO

CREATE TABLE [SanadITM] (
    [S_Sanad] int NOT NULL,
    [Radif] int NOT NULL,
    [Acc] varchar(8) COLLATE Arabic_CI_AI NOT NULL,
    [Sharh] nvarchar(250) COLLATE Arabic_CI_AI NULL,
    [Bed] float NOT NULL,
    [ArzBed] float NULL DEFAULT ((0)),
    [Bes] float NOT NULL,
    [ArzBes] float NULL DEFAULT ((0)),
    [A_Code] tinyint NULL,
    [F_Factor] int NULL,
    [P_Payment] bigint NULL,
    [P_Kind] tinyint NULL,
    [H_Hesab] int NULL,
    [Kh_Khadamat] bigint NULL,
    [ArzKol] float NULL,
    [B_bar] int NULL,
    CONSTRAINT [PK_SanadITM] PRIMARY KEY ([S_Sanad], [Radif]),
    CONSTRAINT [FK_SanadITM_Factor1] FOREIGN KEY ([F_Factor]) REFERENCES [Factor1] ([F_Factor]) ON DELETE CASCADE,
    CONSTRAINT [FK_SanadITM_Khadamat] FOREIGN KEY ([Kh_Khadamat]) REFERENCES [Khadamat] ([Kh_No]) ON DELETE CASCADE,
    CONSTRAINT [FK_SanadITM_Onvan] FOREIGN KEY ([Acc]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_SanadITM_Payment1] FOREIGN KEY ([P_Kind], [P_Payment]) REFERENCES [Payment1] ([P1_Kind], [P1_No]) ON DELETE CASCADE,
    CONSTRAINT [FK_SanadITM_Sanad] FOREIGN KEY ([S_Sanad]) REFERENCES [Sanad] ([S_Sanad])
);
GO

CREATE TABLE [Check] (
    [C_Check] bigint NOT NULL,
    [C_DateC] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [C_Bank] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [C_Shobeh] nvarchar(40) COLLATE Arabic_CI_AI NULL,
    [C_NoJary] nvarchar(24) COLLATE Arabic_CI_AI NULL,
    [C_Mab] float NULL,
    [C_ArzMab] float NULL,
    [C_ArzType] tinyint NULL,
    [C_DateV] char(10) COLLATE Arabic_CI_AI NULL DEFAULT (('____/__/__')),
    [C_Kind] smallint NULL,
    [C_Flag] bit NULL,
    [C_Sharh] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [C_Sanad] int NULL DEFAULT ((0)),
    [C_Radif] int NULL,
    [C_Name] nvarchar(50) COLLATE Arabic_CI_AI NULL,
    [C_Hesab] varchar(8) COLLATE Arabic_CI_AI NULL,
    [C_Hesab2] varchar(8) COLLATE Arabic_CI_AI NULL,
    [C_Shahrestan] bit NULL,
    [C_PrsnCheck] tinyint NULL,
    CONSTRAINT [PK_CHECK] PRIMARY KEY ([C_Check]),
    CONSTRAINT [FK_Check_Onvan] FOREIGN KEY ([C_Hesab]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Check_Onvan1] FOREIGN KEY ([C_Hesab2]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_CHECK_SanadITM] FOREIGN KEY ([C_Sanad], [C_Radif]) REFERENCES [SanadITM] ([S_Sanad], [Radif])
);
GO

CREATE TABLE [Payment2] (
    [P2_Kind] tinyint NOT NULL,
    [P2_No] bigint NOT NULL,
    [P2_Radif] int NOT NULL,
    [P2_KindP] tinyint NULL,
    [P2_Check] bigint NULL,
    [P2_Acc] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P2_Shrh] nvarchar(80) COLLATE Arabic_CI_AI NULL,
    [P2_Mab] float NULL DEFAULT ((0)),
    [P2_Acc2] varchar(8) COLLATE Arabic_CI_AI NULL,
    [P2_ArzMab] float NULL,
    [P2_ArzType] tinyint NULL,
    [P2_KindC] smallint NULL,
    [P2_ArzKol] float NULL,
    CONSTRAINT [PK_Payment2] PRIMARY KEY ([P2_Kind], [P2_No], [P2_Radif]),
    CONSTRAINT [FK_Payment2_Check] FOREIGN KEY ([P2_Check]) REFERENCES [Check] ([C_Check]),
    CONSTRAINT [FK_Payment2_Onvan] FOREIGN KEY ([P2_Acc]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Payment2_Onvan1] FOREIGN KEY ([P2_Acc2]) REFERENCES [Onvan] ([O_Acc]),
    CONSTRAINT [FK_Payment2_Payment1] FOREIGN KEY ([P2_Kind], [P2_No]) REFERENCES [Payment1] ([P1_Kind], [P1_No]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_ANBAR] ON [Anbar] ([A_Name]) WHERE [A_Name] IS NOT NULL;
GO

CREATE INDEX [IX_Anbar_A_Acc1] ON [Anbar] ([A_Acc1]);
GO

CREATE INDEX [IX_Anbar_A_Acc10] ON [Anbar] ([A_Acc10]);
GO

CREATE INDEX [IX_Anbar_A_Acc11] ON [Anbar] ([A_Acc11]);
GO

CREATE INDEX [IX_Anbar_A_Acc12] ON [Anbar] ([A_Acc12]);
GO

CREATE INDEX [IX_Anbar_A_Acc13] ON [Anbar] ([A_Acc13]);
GO

CREATE INDEX [IX_Anbar_A_Acc14] ON [Anbar] ([A_Acc14]);
GO

CREATE INDEX [IX_Anbar_A_Acc16] ON [Anbar] ([A_Acc16]);
GO

CREATE INDEX [IX_Anbar_A_Acc19] ON [Anbar] ([A_Acc19]);
GO

CREATE INDEX [IX_Anbar_A_Acc2] ON [Anbar] ([A_Acc2]);
GO

CREATE INDEX [IX_Anbar_A_Acc22] ON [Anbar] ([A_Acc22]);
GO

CREATE INDEX [IX_Anbar_A_Acc23] ON [Anbar] ([A_Acc23]);
GO

CREATE INDEX [IX_Anbar_A_Acc24] ON [Anbar] ([A_Acc24]);
GO

CREATE INDEX [IX_Anbar_A_Acc3] ON [Anbar] ([A_Acc3]);
GO

CREATE INDEX [IX_Anbar_A_Acc4] ON [Anbar] ([A_Acc4]);
GO

CREATE INDEX [IX_Anbar_A_Acc5] ON [Anbar] ([A_Acc5]);
GO

CREATE INDEX [IX_Anbar_A_Acc6] ON [Anbar] ([A_Acc6]);
GO

CREATE INDEX [IX_Anbar_A_Acc7] ON [Anbar] ([A_Acc7]);
GO

CREATE INDEX [IX_Anbar_A_Acc9] ON [Anbar] ([A_Acc9]);
GO

CREATE INDEX [IX_Check] ON [Check] ([C_DateC]);
GO

CREATE INDEX [IX_Check_C_Hesab] ON [Check] ([C_Hesab]);
GO

CREATE INDEX [IX_Check_C_Hesab2] ON [Check] ([C_Hesab2]);
GO

CREATE INDEX [IX_Check_C_Sanad_C_Radif] ON [Check] ([C_Sanad], [C_Radif]);
GO

CREATE INDEX [IX_Factor1] ON [Factor1] ([F_Date]);
GO

CREATE UNIQUE INDEX [IX_Factor1_1] ON [Factor1] ([F_No], [F_Kind]);
GO

CREATE INDEX [IX_Factor1_2] ON [Factor1] ([F_Anbar]);
GO

CREATE INDEX [IX_Factor1_3] ON [Factor1] ([F_No]);
GO

CREATE INDEX [IX_Factor1_F_AccEzafat] ON [Factor1] ([F_AccEzafat]);
GO

CREATE INDEX [IX_Factor1_F_AccKosorat] ON [Factor1] ([F_AccKosorat]);
GO

CREATE INDEX [IX_Factor1_F_Anbar2] ON [Factor1] ([F_Anbar2]);
GO

CREATE INDEX [IX_Factor1_F_KindPay_F_NoPay] ON [Factor1] ([F_KindPay], [F_NoPay]);
GO

CREATE INDEX [IX_Factor1_F_Moshtari] ON [Factor1] ([F_Moshtari]);
GO

CREATE INDEX [IX_Factor1_F_Porsant] ON [Factor1] ([F_Porsant]);
GO

CREATE INDEX [IX_Factor1_F_Sanad] ON [Factor1] ([F_Sanad]);
GO

CREATE INDEX [IX_Factor2] ON [Factor2] ([FK_Kala]);
GO

CREATE UNIQUE INDEX [IX_Goroh] ON [Goroh] ([GH_Name]);
GO

CREATE UNIQUE INDEX [IX_GorohK] ON [GorohK] ([GK_Name]) WHERE [GK_Name] IS NOT NULL;
GO

CREATE UNIQUE INDEX [IX_GorohM] ON [GorohM] ([GM_Name]) WHERE [GM_Name] IS NOT NULL;
GO

CREATE INDEX [IX_InEditPayments_P1_Kind_P1_No] ON [InEditPayments] ([P1_Kind], [P1_No]);
GO

CREATE INDEX [IX_InEditSefaresh_S1_No] ON [InEditSefaresh] ([S1_No]);
GO

CREATE UNIQUE INDEX [IX_KAFactor] ON [KAFactor] ([KA_Name]) WHERE [KA_Name] IS NOT NULL;
GO

CREATE INDEX [IX_KAFactor_KA_Acc] ON [KAFactor] ([KA_Acc]);
GO

CREATE INDEX [IX_KAFactorL_L_KA] ON [KAFactorL] ([L_KA]);
GO

CREATE UNIQUE INDEX [IX_Kala] ON [Kala] ([K_Name]) WHERE [K_Name] IS NOT NULL;
GO

CREATE INDEX [IX_Kala_K_Goroh] ON [Kala] ([K_Goroh]);
GO

CREATE INDEX [IX_KalaM_KM_Anbar] ON [KalaM] ([KM_Anbar]);
GO

CREATE INDEX [IX_KalaT_T_KalaITM] ON [KalaT] ([T_KalaITM]);
GO

CREATE INDEX [IX_Khadamat_Kh_Acc] ON [Khadamat] ([Kh_Acc]);
GO

CREATE INDEX [IX_Khadamat_Kh_KindPay_Kh_NoPay] ON [Khadamat] ([Kh_KindPay], [Kh_NoPay]);
GO

CREATE INDEX [IX_Khadamat_Kh_Moshtari] ON [Khadamat] ([Kh_Moshtari]);
GO

CREATE INDEX [IX_Khadamat_Kh_Sanad] ON [Khadamat] ([Kh_Sanad]);
GO

CREATE UNIQUE INDEX [IX_Moshtari] ON [Moshtari] ([M_Name]) WHERE [M_Name] IS NOT NULL;
GO

CREATE INDEX [IX_Moshtari_M_Acc] ON [Moshtari] ([M_Acc]);
GO

CREATE INDEX [IX_Moshtari_M_Goroh] ON [Moshtari] ([M_Goroh]);
GO

CREATE INDEX [IX_Onvan_O_Goroh] ON [Onvan] ([O_Goroh]);
GO

CREATE INDEX [IX_Payment1_P1_Acc1] ON [Payment1] ([P1_Acc1]);
GO

CREATE INDEX [IX_Payment1_P1_Acc2] ON [Payment1] ([P1_Acc2]);
GO

CREATE INDEX [IX_Payment1_P1_Moshtari] ON [Payment1] ([P1_Moshtari]);
GO

CREATE INDEX [IX_Payment1_P1_Sanad] ON [Payment1] ([P1_Sanad]);
GO

CREATE INDEX [IX_Payment2_P2_Acc] ON [Payment2] ([P2_Acc]);
GO

CREATE INDEX [IX_Payment2_P2_Acc2] ON [Payment2] ([P2_Acc2]);
GO

CREATE INDEX [IX_Payment2_P2_Check] ON [Payment2] ([P2_Check]);
GO

CREATE INDEX [IX_RFactor2_R_No] ON [RFactor2] ([R_No]);
GO

CREATE INDEX [IX_RPayment2_R_No] ON [RPayment2] ([R_No]);
GO

CREATE INDEX [IX_RSanadITM_R_No] ON [RSanadITM] ([R_No]);
GO

CREATE INDEX [IX_Sanad] ON [Sanad] ([S_No]);
GO

CREATE INDEX [IX_Sanad_1] ON [Sanad] ([S_Date]);
GO

CREATE INDEX [IX_Check1] ON [SanadITM] ([Acc]);
GO

CREATE INDEX [IX_SanadITM_F_Factor] ON [SanadITM] ([F_Factor]);
GO

CREATE INDEX [IX_SanadITM_Kh_Khadamat] ON [SanadITM] ([Kh_Khadamat]);
GO

CREATE INDEX [IX_SanadITM_P_Kind_P_Payment] ON [SanadITM] ([P_Kind], [P_Payment]);
GO

CREATE INDEX [IX_Sefaresh2_S2_Kala] ON [Sefaresh2] ([S2_Kala]);
GO

CREATE INDEX [IX_Tashaboh_K_Code] ON [Tashaboh] ([K_Code]);
GO

CREATE UNIQUE INDEX [IX_Vahed] ON [Vahed] ([V_Name]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241201062007_InitialCreate', N'6.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Check] DROP CONSTRAINT [FK_CHECK_SanadITM];
GO

ALTER TABLE [Factor1] DROP CONSTRAINT [FK_Factor1_Moshtari];
GO

ALTER TABLE [Factor1] DROP CONSTRAINT [FK_Factor1_Moshtari1];
GO

ALTER TABLE [Factor1] DROP CONSTRAINT [FK_Factor1_Sanad];
GO

ALTER TABLE [Factor2] DROP CONSTRAINT [FK_Factor2_Kala];
GO

ALTER TABLE [KalaT] DROP CONSTRAINT [FK_KalaT_Kala1];
GO

ALTER TABLE [Khadamat] DROP CONSTRAINT [FK_Khadamat_Moshtari];
GO

ALTER TABLE [Khadamat] DROP CONSTRAINT [FK_Khadamat_Sanad];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [FK_Moshtari_GorohM];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [FK_Moshtari_Onvan];
GO

ALTER TABLE [Payment1] DROP CONSTRAINT [FK_Payment1_Moshtari];
GO

ALTER TABLE [Payment1] DROP CONSTRAINT [FK_Payment1_Sanad];
GO

ALTER TABLE [SanadITM] DROP CONSTRAINT [FK_SanadITM_Factor1];
GO

ALTER TABLE [SanadITM] DROP CONSTRAINT [AK_SanadITM_TempId_TempId1];
GO

ALTER TABLE [Sanad] DROP CONSTRAINT [AK_Sanad_TempId];
GO

ALTER TABLE [Sanad] DROP CONSTRAINT [AK_Sanad_TempId1];
GO

ALTER TABLE [Sanad] DROP CONSTRAINT [AK_Sanad_TempId2];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [AK_Moshtari_TempId];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [AK_Moshtari_TempId1];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [AK_Moshtari_TempId2];
GO

ALTER TABLE [Moshtari] DROP CONSTRAINT [AK_Moshtari_TempId3];
GO

DROP INDEX [IX_Moshtari_M_Acc] ON [Moshtari];
GO

DROP INDEX [IX_Moshtari_M_Goroh] ON [Moshtari];
GO

ALTER TABLE [Kala] DROP CONSTRAINT [AK_Kala_TempId];
GO

ALTER TABLE [Kala] DROP CONSTRAINT [AK_Kala_TempId1];
GO

ALTER TABLE [Factor1] DROP CONSTRAINT [AK_Factor1_TempId];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SanadITM]') AND [c].[name] = N'TempId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SanadITM] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SanadITM] DROP COLUMN [TempId];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SanadITM]') AND [c].[name] = N'TempId1');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [SanadITM] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [SanadITM] DROP COLUMN [TempId1];
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad]') AND [c].[name] = N'TempId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Sanad] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Sanad] DROP COLUMN [TempId];
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad]') AND [c].[name] = N'TempId1');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Sanad] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Sanad] DROP COLUMN [TempId1];
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad]') AND [c].[name] = N'TempId2');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Sanad] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Sanad] DROP COLUMN [TempId2];
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Moshtari]') AND [c].[name] = N'TempId');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Moshtari] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Moshtari] DROP COLUMN [TempId];
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Moshtari]') AND [c].[name] = N'TempId1');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Moshtari] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Moshtari] DROP COLUMN [TempId1];
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Moshtari]') AND [c].[name] = N'TempId2');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Moshtari] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Moshtari] DROP COLUMN [TempId2];
GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Moshtari]') AND [c].[name] = N'TempId3');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Moshtari] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Moshtari] DROP COLUMN [TempId3];
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Kala]') AND [c].[name] = N'TempId');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Kala] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Kala] DROP COLUMN [TempId];
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Kala]') AND [c].[name] = N'TempId1');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Kala] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Kala] DROP COLUMN [TempId1];
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'TempId');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Factor1] DROP COLUMN [TempId];
GO

DROP INDEX [IX_Vahed] ON [Vahed];
DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vahed]') AND [c].[name] = N'V_Name');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Vahed] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Vahed] ALTER COLUMN [V_Name] nvarchar(8) COLLATE Arabic_CI_AI NOT NULL;
CREATE UNIQUE INDEX [IX_Vahed] ON [Vahed] ([V_Name]);
GO

ALTER TABLE [Vahed] ADD [V_Mali] nvarchar(20) COLLATE Arabic_CI_AI NULL;
GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SanadITM]') AND [c].[name] = N'H_Hesab');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [SanadITM] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [SanadITM] ALTER COLUMN [H_Hesab] int NULL;
GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SanadITM]') AND [c].[name] = N'F_Factor');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [SanadITM] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [SanadITM] ALTER COLUMN [F_Factor] int NULL;
GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SanadITM]') AND [c].[name] = N'B_bar');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [SanadITM] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [SanadITM] ALTER COLUMN [B_bar] int NULL;
GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad1400s]') AND [c].[name] = N's_user');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Sanad1400s] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [Sanad1400s] ALTER COLUMN [s_user] bigint NOT NULL;
GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad1400s]') AND [c].[name] = N's_date');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Sanad1400s] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [Sanad1400s] ALTER COLUMN [s_date] bigint NOT NULL;
GO

ALTER TABLE [Sanad1400s] ADD [id] bigint NOT NULL IDENTITY;
GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad]') AND [c].[name] = N'S_User');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Sanad] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [Sanad] ALTER COLUMN [S_User] int NULL;
GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sanad]') AND [c].[name] = N'S_Print');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Sanad] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [Sanad] ALTER COLUMN [S_Print] int NULL;
ALTER TABLE [Sanad] ADD DEFAULT ((0)) FOR [S_Print];
GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RSanadITM]') AND [c].[name] = N'H_Hesab');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [RSanadITM] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [RSanadITM] ALTER COLUMN [H_Hesab] int NULL;
GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RSanadITM]') AND [c].[name] = N'F_Factor');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [RSanadITM] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [RSanadITM] ALTER COLUMN [F_Factor] int NULL;
GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RSanadITM]') AND [c].[name] = N'B_bar');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [RSanadITM] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [RSanadITM] ALTER COLUMN [B_bar] int NULL;
GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RSanad]') AND [c].[name] = N'S_User');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [RSanad] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [RSanad] ALTER COLUMN [S_User] int NULL;
GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RSanad]') AND [c].[name] = N'S_Print');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [RSanad] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [RSanad] ALTER COLUMN [S_Print] int NULL;
GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RPayment2]') AND [c].[name] = N'P2_Check');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [RPayment2] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [RPayment2] ALTER COLUMN [P2_Check] int NULL;
GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RPayment1]') AND [c].[name] = N'P1_User');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [RPayment1] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [RPayment1] ALTER COLUMN [P1_User] int NULL;
GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RPayment1]') AND [c].[name] = N'P1_Sanad');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [RPayment1] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [RPayment1] ALTER COLUMN [P1_Sanad] int NULL;
GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RPayment1]') AND [c].[name] = N'P1_Moshtari');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [RPayment1] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [RPayment1] ALTER COLUMN [P1_Moshtari] int NULL;
GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RKhadamat]') AND [c].[name] = N'Kh_User');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [RKhadamat] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [RKhadamat] ALTER COLUMN [Kh_User] int NULL;
GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RKhadamat]') AND [c].[name] = N'Kh_Sanad');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [RKhadamat] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [RKhadamat] ALTER COLUMN [Kh_Sanad] int NULL;
GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RKhadamat]') AND [c].[name] = N'Kh_Moshtari');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [RKhadamat] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [RKhadamat] ALTER COLUMN [Kh_Moshtari] int NULL;
GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RKhadamat]') AND [c].[name] = N'Kh_Factor');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [RKhadamat] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [RKhadamat] ALTER COLUMN [Kh_Factor] int NULL;
GO

DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor2]') AND [c].[name] = N'FK_NumKoli');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [RFactor2] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [RFactor2] ALTER COLUMN [FK_NumKoli] int NULL;
GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor2]') AND [c].[name] = N'FK_Kala');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [RFactor2] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [RFactor2] ALTER COLUMN [FK_Kala] int NULL;
GO

DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor1]') AND [c].[name] = N'F_Serial');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [RFactor1] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [RFactor1] ALTER COLUMN [F_Serial] int NULL;
GO

DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor1]') AND [c].[name] = N'F_Sanad');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [RFactor1] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [RFactor1] ALTER COLUMN [F_Sanad] int NULL;
GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor1]') AND [c].[name] = N'F_Print');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [RFactor1] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [RFactor1] ALTER COLUMN [F_Print] int NULL;
GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor1]') AND [c].[name] = N'F_Porsant');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [RFactor1] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [RFactor1] ALTER COLUMN [F_Porsant] int NULL;
GO

DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RFactor1]') AND [c].[name] = N'F_Moshtari');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [RFactor1] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [RFactor1] ALTER COLUMN [F_Moshtari] int NULL;
GO

ALTER TABLE [RFactor1] ADD [F_Log] nvarchar(50) NULL;
GO

ALTER TABLE [RFactor1] ADD [F_Ref] nvarchar(50) NULL;
GO

ALTER TABLE [RFactor1] ADD [F_TaxId] nvarchar(50) NULL;
GO

ALTER TABLE [RFactor1] ADD [F_UID] nvarchar(50) NULL;
GO

DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Payment1]') AND [c].[name] = N'P1_User');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [Payment1] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [Payment1] ALTER COLUMN [P1_User] int NULL;
GO

DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Payment1]') AND [c].[name] = N'P1_Sanad');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [Payment1] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [Payment1] ALTER COLUMN [P1_Sanad] int NULL;
GO

DECLARE @var42 sysname;
SELECT @var42 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Payment1]') AND [c].[name] = N'P1_Moshtari');
IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [Payment1] DROP CONSTRAINT [' + @var42 + '];');
ALTER TABLE [Payment1] ALTER COLUMN [P1_Moshtari] int NULL;
GO

DECLARE @var43 sysname;
SELECT @var43 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Onvan]') AND [c].[name] = N'O_Sanad');
IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [Onvan] DROP CONSTRAINT [' + @var43 + '];');
ALTER TABLE [Onvan] ALTER COLUMN [O_Sanad] int NULL;
GO

DECLARE @var44 sysname;
SELECT @var44 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Moshtari]') AND [c].[name] = N'M_CodeMantagh');
IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [Moshtari] DROP CONSTRAINT [' + @var44 + '];');
ALTER TABLE [Moshtari] ALTER COLUMN [M_CodeMantagh] int NULL;
GO

ALTER TABLE [Moshtari] ADD [GorohMGmCode] int NULL;
GO

ALTER TABLE [Moshtari] ADD [M_Shobe] nvarchar(50) NULL;
GO

DECLARE @var45 sysname;
SELECT @var45 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Khadamat]') AND [c].[name] = N'Kh_User');
IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [Khadamat] DROP CONSTRAINT [' + @var45 + '];');
ALTER TABLE [Khadamat] ALTER COLUMN [Kh_User] int NULL;
GO

DECLARE @var46 sysname;
SELECT @var46 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Khadamat]') AND [c].[name] = N'Kh_Sanad');
IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [Khadamat] DROP CONSTRAINT [' + @var46 + '];');
ALTER TABLE [Khadamat] ALTER COLUMN [Kh_Sanad] int NULL;
GO

DECLARE @var47 sysname;
SELECT @var47 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Khadamat]') AND [c].[name] = N'Kh_Moshtari');
IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [Khadamat] DROP CONSTRAINT [' + @var47 + '];');
ALTER TABLE [Khadamat] ALTER COLUMN [Kh_Moshtari] int NULL;
GO

DECLARE @var48 sysname;
SELECT @var48 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Khadamat]') AND [c].[name] = N'Kh_Factor');
IF @var48 IS NOT NULL EXEC(N'ALTER TABLE [Khadamat] DROP CONSTRAINT [' + @var48 + '];');
ALTER TABLE [Khadamat] ALTER COLUMN [Kh_Factor] int NULL;
GO

DECLARE @var49 sysname;
SELECT @var49 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[KalaT]') AND [c].[name] = N'T_KalaITM');
IF @var49 IS NOT NULL EXEC(N'ALTER TABLE [KalaT] DROP CONSTRAINT [' + @var49 + '];');
ALTER TABLE [KalaT] ALTER COLUMN [T_KalaITM] int NULL;
GO

DECLARE @var50 sysname;
SELECT @var50 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Kala]') AND [c].[name] = N'K_Log');
IF @var50 IS NOT NULL EXEC(N'ALTER TABLE [Kala] DROP CONSTRAINT [' + @var50 + '];');
ALTER TABLE [Kala] ADD DEFAULT (((1))) FOR [K_Log];
GO

DECLARE @var51 sysname;
SELECT @var51 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Kala]') AND [c].[name] = N'K_Lan');
IF @var51 IS NOT NULL EXEC(N'ALTER TABLE [Kala] DROP CONSTRAINT [' + @var51 + '];');
ALTER TABLE [Kala] ADD DEFAULT (((0))) FOR [K_Lan];
GO

ALTER TABLE [Kala] ADD [K_Mali] nvarchar(20) COLLATE Arabic_CI_AI NULL;
GO

DECLARE @var52 sysname;
SELECT @var52 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InEditSefaresh]') AND [c].[name] = N'User');
IF @var52 IS NOT NULL EXEC(N'ALTER TABLE [InEditSefaresh] DROP CONSTRAINT [' + @var52 + '];');
ALTER TABLE [InEditSefaresh] ALTER COLUMN [User] int NULL;
GO

DECLARE @var53 sysname;
SELECT @var53 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InEditSanads]') AND [c].[name] = N'User');
IF @var53 IS NOT NULL EXEC(N'ALTER TABLE [InEditSanads] DROP CONSTRAINT [' + @var53 + '];');
ALTER TABLE [InEditSanads] ALTER COLUMN [User] int NULL;
GO

DECLARE @var54 sysname;
SELECT @var54 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InEditPayments]') AND [c].[name] = N'User');
IF @var54 IS NOT NULL EXEC(N'ALTER TABLE [InEditPayments] DROP CONSTRAINT [' + @var54 + '];');
ALTER TABLE [InEditPayments] ALTER COLUMN [User] int NULL;
GO

DECLARE @var55 sysname;
SELECT @var55 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InEditKhadamat]') AND [c].[name] = N'User');
IF @var55 IS NOT NULL EXEC(N'ALTER TABLE [InEditKhadamat] DROP CONSTRAINT [' + @var55 + '];');
ALTER TABLE [InEditKhadamat] ALTER COLUMN [User] int NULL;
GO

DECLARE @var56 sysname;
SELECT @var56 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InEditFactors]') AND [c].[name] = N'User');
IF @var56 IS NOT NULL EXEC(N'ALTER TABLE [InEditFactors] DROP CONSTRAINT [' + @var56 + '];');
ALTER TABLE [InEditFactors] ALTER COLUMN [User] int NULL;
GO

DECLARE @var57 sysname;
SELECT @var57 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HsbPrsnsKolis]') AND [c].[name] = N'No');
IF @var57 IS NOT NULL EXEC(N'ALTER TABLE [HsbPrsnsKolis] DROP CONSTRAINT [' + @var57 + '];');
ALTER TABLE [HsbPrsnsKolis] ALTER COLUMN [No] bigint NOT NULL;
GO

DECLARE @var58 sysname;
SELECT @var58 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HsbPrsnsKolis]') AND [c].[name] = N'Mande');
IF @var58 IS NOT NULL EXEC(N'ALTER TABLE [HsbPrsnsKolis] DROP CONSTRAINT [' + @var58 + '];');
ALTER TABLE [HsbPrsnsKolis] ALTER COLUMN [Mande] bigint NOT NULL;
GO

DECLARE @var59 sysname;
SELECT @var59 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HsbPrsnsKolis]') AND [c].[name] = N'F_Factor');
IF @var59 IS NOT NULL EXEC(N'ALTER TABLE [HsbPrsnsKolis] DROP CONSTRAINT [' + @var59 + '];');
ALTER TABLE [HsbPrsnsKolis] ALTER COLUMN [F_Factor] bigint NULL;
GO

DECLARE @var60 sysname;
SELECT @var60 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HsbPrsnsKolis]') AND [c].[name] = N'F');
IF @var60 IS NOT NULL EXEC(N'ALTER TABLE [HsbPrsnsKolis] DROP CONSTRAINT [' + @var60 + '];');
ALTER TABLE [HsbPrsnsKolis] ALTER COLUMN [F] bigint NOT NULL;
GO

DECLARE @var61 sysname;
SELECT @var61 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ghest]') AND [c].[name] = N'GH_MABKOLVAM');
IF @var61 IS NOT NULL EXEC(N'ALTER TABLE [Ghest] DROP CONSTRAINT [' + @var61 + '];');
ALTER TABLE [Ghest] ALTER COLUMN [GH_MABKOLVAM] int NULL;
GO

DECLARE @var62 sysname;
SELECT @var62 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor2]') AND [c].[name] = N'FK_NumKoli');
IF @var62 IS NOT NULL EXEC(N'ALTER TABLE [Factor2] DROP CONSTRAINT [' + @var62 + '];');
ALTER TABLE [Factor2] ALTER COLUMN [FK_NumKoli] int NULL;
GO

DECLARE @var63 sysname;
SELECT @var63 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor2]') AND [c].[name] = N'FK_Kala');
IF @var63 IS NOT NULL EXEC(N'ALTER TABLE [Factor2] DROP CONSTRAINT [' + @var63 + '];');
ALTER TABLE [Factor2] ALTER COLUMN [FK_Kala] int NULL;
GO

DECLARE @var64 sysname;
SELECT @var64 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'F_Serial');
IF @var64 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var64 + '];');
ALTER TABLE [Factor1] ALTER COLUMN [F_Serial] int NULL;
GO

DECLARE @var65 sysname;
SELECT @var65 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'F_Sanad');
IF @var65 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var65 + '];');
ALTER TABLE [Factor1] ALTER COLUMN [F_Sanad] int NULL;
GO

DECLARE @var66 sysname;
SELECT @var66 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'F_Print');
IF @var66 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var66 + '];');
ALTER TABLE [Factor1] ALTER COLUMN [F_Print] int NULL;
ALTER TABLE [Factor1] ADD DEFAULT ((0)) FOR [F_Print];
GO

DECLARE @var67 sysname;
SELECT @var67 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'F_Porsant');
IF @var67 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var67 + '];');
ALTER TABLE [Factor1] ALTER COLUMN [F_Porsant] int NULL;
GO

DECLARE @var68 sysname;
SELECT @var68 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Factor1]') AND [c].[name] = N'F_Moshtari');
IF @var68 IS NOT NULL EXEC(N'ALTER TABLE [Factor1] DROP CONSTRAINT [' + @var68 + '];');
ALTER TABLE [Factor1] ALTER COLUMN [F_Moshtari] int NULL;
GO

ALTER TABLE [Factor1] ADD [F_Log] nvarchar(50) NULL;
GO

ALTER TABLE [Factor1] ADD [F_Ref] nvarchar(50) NULL;
GO

ALTER TABLE [Factor1] ADD [F_TaxId] nvarchar(50) NULL;
GO

ALTER TABLE [Factor1] ADD [F_UID] nvarchar(50) NULL;
GO

DECLARE @var69 sysname;
SELECT @var69 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Check]') AND [c].[name] = N'C_Sanad');
IF @var69 IS NOT NULL EXEC(N'ALTER TABLE [Check] DROP CONSTRAINT [' + @var69 + '];');
ALTER TABLE [Check] ALTER COLUMN [C_Sanad] int NULL;
ALTER TABLE [Check] ADD DEFAULT ((0)) FOR [C_Sanad];
GO

DECLARE @var70 sysname;
SELECT @var70 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Check]') AND [c].[name] = N'C_Radif');
IF @var70 IS NOT NULL EXEC(N'ALTER TABLE [Check] DROP CONSTRAINT [' + @var70 + '];');
ALTER TABLE [Check] ALTER COLUMN [C_Radif] int NULL;
GO

ALTER TABLE [Check] ADD [C_Sayadi] nvarchar(50) NULL;
GO

DECLARE @var71 sysname;
SELECT @var71 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar2]') AND [c].[name] = N'B2_NumKoli');
IF @var71 IS NOT NULL EXEC(N'ALTER TABLE [Bar2] DROP CONSTRAINT [' + @var71 + '];');
ALTER TABLE [Bar2] ALTER COLUMN [B2_NumKoli] int NULL;
GO

DECLARE @var72 sysname;
SELECT @var72 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar2]') AND [c].[name] = N'B2_Moshtari');
IF @var72 IS NOT NULL EXEC(N'ALTER TABLE [Bar2] DROP CONSTRAINT [' + @var72 + '];');
ALTER TABLE [Bar2] ALTER COLUMN [B2_Moshtari] int NULL;
GO

DECLARE @var73 sysname;
SELECT @var73 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_ZNumKoli');
IF @var73 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var73 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_ZNumKoli] int NULL;
GO

DECLARE @var74 sysname;
SELECT @var74 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_Sanad');
IF @var74 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var74 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_Sanad] int NULL;
GO

DECLARE @var75 sysname;
SELECT @var75 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_Prsn');
IF @var75 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var75 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_Prsn] int NULL;
GO

DECLARE @var76 sysname;
SELECT @var76 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_NumKoli');
IF @var76 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var76 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_NumKoli] int NULL;
GO

DECLARE @var77 sysname;
SELECT @var77 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_MabPorsant');
IF @var77 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var77 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_MabPorsant] int NULL;
GO

DECLARE @var78 sysname;
SELECT @var78 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Bar1]') AND [c].[name] = N'B_Kala');
IF @var78 IS NOT NULL EXEC(N'ALTER TABLE [Bar1] DROP CONSTRAINT [' + @var78 + '];');
ALTER TABLE [Bar1] ALTER COLUMN [B_Kala] int NULL;
GO

ALTER TABLE [Sanad1400s] ADD CONSTRAINT [PK_Sanad1400s] PRIMARY KEY ([id]);
GO

CREATE TABLE [ERROR] (
    [E_Error] text NULL,
    [E_Factor] int NULL,
    [E_Error_Code] int NULL,
    [E_Type] int NULL
);
GO

CREATE INDEX [IX_Moshtari_GorohMGmCode] ON [Moshtari] ([GorohMGmCode]);
GO

ALTER TABLE [Check] ADD CONSTRAINT [FK_CHECK_SanadITM] FOREIGN KEY ([C_Sanad], [C_Radif]) REFERENCES [SanadITM] ([S_Sanad], [Radif]);
GO

ALTER TABLE [Factor1] ADD CONSTRAINT [FK_Factor1_Moshtari] FOREIGN KEY ([F_Moshtari]) REFERENCES [Moshtari] ([M_Code]);
GO

ALTER TABLE [Factor1] ADD CONSTRAINT [FK_Factor1_Moshtari1] FOREIGN KEY ([F_Porsant]) REFERENCES [Moshtari] ([M_Code]);
GO

ALTER TABLE [Factor1] ADD CONSTRAINT [FK_Factor1_Sanad] FOREIGN KEY ([F_Sanad]) REFERENCES [Sanad] ([S_Sanad]);
GO

ALTER TABLE [Factor2] ADD CONSTRAINT [FK_Factor2_Kala] FOREIGN KEY ([FK_Kala]) REFERENCES [Kala] ([K_Code]);
GO

ALTER TABLE [KalaT] ADD CONSTRAINT [FK_KalaT_Kala1] FOREIGN KEY ([T_KalaITM]) REFERENCES [Kala] ([K_Code]);
GO

ALTER TABLE [Khadamat] ADD CONSTRAINT [FK_Khadamat_Moshtari] FOREIGN KEY ([Kh_Moshtari]) REFERENCES [Moshtari] ([M_Code]);
GO

ALTER TABLE [Khadamat] ADD CONSTRAINT [FK_Khadamat_Sanad] FOREIGN KEY ([Kh_Sanad]) REFERENCES [Sanad] ([S_Sanad]);
GO

ALTER TABLE [Moshtari] ADD CONSTRAINT [FK_Moshtari_GorohM_GorohMGmCode] FOREIGN KEY ([GorohMGmCode]) REFERENCES [GorohM] ([GM_Code]);
GO

ALTER TABLE [Payment1] ADD CONSTRAINT [FK_Payment1_Moshtari] FOREIGN KEY ([P1_Moshtari]) REFERENCES [Moshtari] ([M_Code]);
GO

ALTER TABLE [Payment1] ADD CONSTRAINT [FK_Payment1_Sanad] FOREIGN KEY ([P1_Sanad]) REFERENCES [Sanad] ([S_Sanad]);
GO

ALTER TABLE [SanadITM] ADD CONSTRAINT [FK_SanadITM_Factor1] FOREIGN KEY ([F_Factor]) REFERENCES [Factor1] ([F_Factor]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250507090315_changes', N'6.0.0');
GO

COMMIT;
GO


