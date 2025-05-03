using System;
using System.Collections.Generic;
using CityInfoApi.Models_new;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CityInfoApi.Models.bak
{
    public partial class AlmasACC : DbContext
    {
        private HttpContext _httpContext;
        public AlmasACC(DbContextOptions<AlmasACC> options,IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContext = httpContextAccessor?.HttpContext!;
        }
        public virtual DbSet<Sanad1400> Sanad1400s { get; set; } = null!;
        public virtual DbSet<HsbPrsnsKoli> HsbPrsnsKolis { get; set; } = null!;
        public virtual DbSet<Anbar> Anbars { get; set; } = null!;
        public virtual DbSet<Bar1> Bar1s { get; set; } = null!;
        public virtual DbSet<Bar2> Bar2s { get; set; } = null!;
        public virtual DbSet<Check> Checks { get; set; } = null!;
        public virtual DbSet<Factor1> Factor1s { get; set; } = null!;
        public virtual DbSet<Factor2> Factor2s { get; set; } = null!;
        public virtual DbSet<GorohK> GorohKs { get; set; } = null!;
        public virtual DbSet<GorohM> GorohMs { get; set; } = null!;
        public virtual DbSet<GorohT> GorohTs { get; set; } = null!;
        public virtual DbSet<InEditFactor> InEditFactors { get; set; } = null!;
        public virtual DbSet<InEditKhadamat> InEditKhadamats { get; set; } = null!;
        public virtual DbSet<InEditPayment> InEditPayments { get; set; } = null!;
        public virtual DbSet<InEditSanad> InEditSanads { get; set; } = null!;
        public virtual DbSet<InEditSefaresh> InEditSefareshes { get; set; } = null!;
        public virtual DbSet<Kafactor> Kafactors { get; set; } = null!;
        public virtual DbSet<KafactorL> KafactorLs { get; set; } = null!;
        public virtual DbSet<Kala> Kalas { get; set; } = null!;
        public virtual DbSet<KalaM> KalaMs { get; set; } = null!;
        public virtual DbSet<KalaT> KalaTs { get; set; } = null!;
        public virtual DbSet<Khadamat> Khadamats { get; set; } = null!;
        public virtual DbSet<Mantagh> Mantaghs { get; set; } = null!;
        public virtual DbSet<Moshtari> Moshtaris { get; set; } = null!;
        public virtual DbSet<MoshtariTkmili> MoshtariTkmilis { get; set; } = null!;
        public virtual DbSet<NoteBook> NoteBooks { get; set; } = null!;
        public virtual DbSet<Onvan> Onvans { get; set; } = null!;
        public virtual DbSet<Payment1> Payment1s { get; set; } = null!;
        public virtual DbSet<Payment2> Payment2s { get; set; } = null!;
        public virtual DbSet<Rfactor1> Rfactor1s { get; set; } = null!;
        public virtual DbSet<Rfactor2> Rfactor2s { get; set; } = null!;
        public virtual DbSet<Rkhadamat> Rkhadamats { get; set; } = null!;
        public virtual DbSet<Rpayment1> Rpayment1s { get; set; } = null!;
        public virtual DbSet<Rpayment2> Rpayment2s { get; set; } = null!;
        public virtual DbSet<Rsanad> Rsanads { get; set; } = null!;
        public virtual DbSet<RsanadItm> RsanadItms { get; set; } = null!;
        public virtual DbSet<Sanad> Sanads { get; set; } = null!;
        public virtual DbSet<SanadItm> SanadItms { get; set; } = null!;
        public virtual DbSet<Sefaresh1> Sefaresh1s { get; set; } = null!;
        public virtual DbSet<Sefaresh2> Sefaresh2s { get; set; } = null!;
        public virtual DbSet<Sm> Sms { get; set; } = null!;
        public virtual DbSet<Vahed> Vaheds { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? DbName = _httpContext.Request.Cookies["Configuration"];
                if (DbName != null)
                {
                    string Connection = String.Format("data source=DESKTOP-LAM4N1K\\SQLEXPRESS;Database={0};Trusted_Connection=true", DbName);
                    optionsBuilder.UseSqlServer(Connection);
                }
                else
                {
                    string Connection = "data source=DESKTOP-LAM4N1K\\SQLEXPRESS;initial catalog=AlmasACC14031;trusted_connection=true";
                    optionsBuilder.UseSqlServer(Connection);
                }
            }
        }

        [DbFunction("dbo.GetMojodi")]
        public static float GetMojodi(int Kala,int Anbar ,string ToDate)
        { throw new NotImplementedException();}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1256_CI_AS");

            modelBuilder.Entity<Anbar>(entity =>
            {
                entity.HasKey(e => e.ACode)
                    .HasName("PK_ANBAR");

                entity.ToTable("Anbar");

                entity.HasIndex(e => e.AName, "IX_ANBAR")
                    .IsUnique();

                entity.Property(e => e.ACode).HasColumnName("A_Code");
                entity.Property(e => e.AFlag)
                    .HasColumnName("A_Flag")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.AName)
                    .HasMaxLength(30)
                    .HasColumnName("A_Name")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ANameA)
                    .HasMaxLength(30)
                    .HasColumnName("A_NameA")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Bar1>(entity =>
            {
                entity.HasKey(e => e.BNo);

                entity.ToTable("Bar1");

                entity.Property(e => e.BNo)
                    .ValueGeneratedNever()
                    .HasColumnName("B_No");

                entity.Property(e => e.BAnbar).HasColumnName("B_Anbar");

                entity.Property(e => e.BBar).HasColumnName("B_Bar");

                entity.Property(e => e.BBarGry).HasColumnName("B_BarGry");

                entity.Property(e => e.BBarnameh)
                    .HasMaxLength(50)
                    .HasColumnName("B_Barnameh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BDateB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_DateB")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BDrsdPorsant).HasColumnName("B_DrsdPorsant");

                entity.Property(e => e.BEzfBar).HasColumnName("B_EzfBar");

                entity.Property(e => e.BFlag).HasColumnName("B_Flag");

                entity.Property(e => e.BHazine).HasColumnName("B_Hazine");

                entity.Property(e => e.BInputBar).HasColumnName("B_InputBar");

                entity.Property(e => e.BInputBarGry).HasColumnName("B_InputBarGry");

                entity.Property(e => e.BKala).HasColumnName("B_Kala");

                entity.Property(e => e.BKsrBar).HasColumnName("B_KsrBar");

                entity.Property(e => e.BMab).HasColumnName("B_Mab");

                entity.Property(e => e.BMab2).HasColumnName("B_Mab2");

                entity.Property(e => e.BMabPorsant).HasColumnName("B_MabPorsant");

                entity.Property(e => e.BMashin)
                    .HasMaxLength(100)
                    .HasColumnName("B_Mashin")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BNameN)
                    .HasMaxLength(100)
                    .HasColumnName("B_NameN")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BNum).HasColumnName("B_Num");

                entity.Property(e => e.BNum2).HasColumnName("B_Num2");

                entity.Property(e => e.BNumKoli).HasColumnName("B_NumKoli");

                entity.Property(e => e.BPrsn).HasColumnName("B_Prsn");

                entity.Property(e => e.BSanad).HasColumnName("B_Sanad");

                entity.Property(e => e.BSharh)
                    .HasMaxLength(100)
                    .HasColumnName("B_Sharh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BTimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("B_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BUser).HasColumnName("B_User");

                entity.Property(e => e.BVznZrf).HasColumnName("B_VznZrf");

                entity.Property(e => e.BZnum).HasColumnName("B_ZNum");

                entity.Property(e => e.BZnum2).HasColumnName("B_ZNum2");

                entity.Property(e => e.BZnumKoli).HasColumnName("B_ZNumKoli");
            });

            modelBuilder.Entity<Bar2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bar2");

                entity.Property(e => e.B2DateF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("B2_DateF")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.B2Discount).HasColumnName("B2_Discount");

                entity.Property(e => e.B2KindPay).HasColumnName("B2_KindPay");

                entity.Property(e => e.B2Mab).HasColumnName("B2_Mab");

                entity.Property(e => e.B2Moshtari).HasColumnName("B2_Moshtari");

                entity.Property(e => e.B2No).HasColumnName("B2_No");

                entity.Property(e => e.B2NoPay).HasColumnName("B2_NoPay");

                entity.Property(e => e.B2Num).HasColumnName("B2_Num");

                entity.Property(e => e.B2Num2).HasColumnName("B2_Num2");

                entity.Property(e => e.B2NumKoli).HasColumnName("B2_NumKoli");

                entity.Property(e => e.B2Radif).HasColumnName("B2_Radif");

                entity.Property(e => e.B2Sharh)
                    .HasMaxLength(100)
                    .HasColumnName("B2_Sharh")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Check>(entity =>
            {
                entity.HasKey(e => e.CCheck)
                    .HasName("PK_CHECK");

                entity.ToTable("Check");

                entity.HasIndex(e => e.CDateC, "IX_Check");

                entity.Property(e => e.CCheck)
                    .ValueGeneratedNever()
                    .HasColumnName("C_Check");

                entity.Property(e => e.CArzMab).HasColumnName("C_ArzMab");

                entity.Property(e => e.CArzType).HasColumnName("C_ArzType");

                entity.Property(e => e.CBank)
                    .HasMaxLength(50)
                    .HasColumnName("C_Bank")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CDateC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("C_DateC")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CDateV)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("C_DateV")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CFlag).HasColumnName("C_Flag");

                entity.Property(e => e.CHesab)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("C_Hesab")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CHesab2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("C_Hesab2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CKind).HasColumnName("C_Kind");

                entity.Property(e => e.CMab).HasColumnName("C_Mab");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .HasColumnName("C_Name")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CNoJary)
                    .HasMaxLength(24)
                    .HasColumnName("C_NoJary")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CPrsnCheck).HasColumnName("C_PrsnCheck");

                entity.Property(e => e.CRadif).HasColumnName("C_Radif");

                entity.Property(e => e.CSanad)
                    .HasColumnName("C_Sanad")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CShahrestan).HasColumnName("C_Shahrestan");

                entity.Property(e => e.CSharh)
                    .HasMaxLength(50)
                    .HasColumnName("C_Sharh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CShobeh)
                    .HasMaxLength(40)
                    .HasColumnName("C_Shobeh")
                    .UseCollation("Arabic_CI_AI");


                entity.HasOne(d => d.C)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => new { d.CSanad, d.CRadif })
                    .HasConstraintName("FK_CHECK_SanadITM");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERROR");

                entity.Property(e => e.EError)
                    .HasColumnType("text")
                    .HasColumnName("E_Error");

                entity.Property(e => e.EErrorCode).HasColumnName("E_Error_Code");

                entity.Property(e => e.EFactor).HasColumnName("E_Factor");

                entity.Property(e => e.EType).HasColumnName("E_Type");
            });

            modelBuilder.Entity<Factor1>(entity =>
            {
                entity.HasKey(e => e.FFactor);

                entity.ToTable("Factor1");

                entity.HasIndex(e => e.FDate, "IX_Factor1");

                entity.HasIndex(e => new { e.FNo, e.FKind }, "IX_Factor1_1")
                    .IsUnique();

                entity.HasIndex(e => e.FAnbar, "IX_Factor1_2");

                entity.HasIndex(e => e.FNo, "IX_Factor1_3");

                entity.Property(e => e.FFactor)
                    .ValueGeneratedNever()
                    .HasColumnName("F_Factor");

                entity.Property(e => e.FAccAnbar)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccAnbar")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAccEzafat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccEzafat")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAccKosorat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccKosorat")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAnbar).HasColumnName("F_Anbar");

                entity.Property(e => e.FAnbar2).HasColumnName("F_Anbar2");

                entity.Property(e => e.FAvarez).HasColumnName("F_Avarez");

                entity.Property(e => e.FDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateA")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateTahvil)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateTahvil")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDriverName)
                    .HasMaxLength(100)
                    .HasColumnName("F_DriverName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FEzafat)
                    .HasColumnName("F_Ezafat")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FFixEzafat).HasColumnName("F_FixEzafat");

                entity.Property(e => e.FFixKosorat).HasColumnName("F_FixKosorat");

                entity.Property(e => e.FFixPorsant).HasColumnName("F_FixPorsant");

                entity.Property(e => e.FFlag).HasColumnName("F_Flag");

                entity.Property(e => e.FKdarsad)
                    .HasColumnName("F_Kdarsad")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FKind).HasColumnName("F_Kind");

                entity.Property(e => e.FKindPay).HasColumnName("F_KindPay");

                entity.Property(e => e.FKosor)
                    .HasColumnName("F_Kosor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FLog)
                    .HasMaxLength(50)
                    .HasColumnName("F_Log");

                entity.Property(e => e.FMab)
                    .HasColumnName("F_Mab")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FMabKol)
                    .HasColumnName("F_MabKol")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FMabPorsant).HasColumnName("F_MabPorsant");

                entity.Property(e => e.FMaliat).HasColumnName("F_Maliat");

                entity.Property(e => e.FMoshtari).HasColumnName("F_Moshtari");

                entity.Property(e => e.FMrkaz).HasColumnName("F_Mrkaz");

                entity.Property(e => e.FNo).HasColumnName("F_No");

                entity.Property(e => e.FNoPay).HasColumnName("F_NoPay");

                entity.Property(e => e.FPorsant).HasColumnName("F_Porsant");

                entity.Property(e => e.FPrint)
                    .HasColumnName("F_Print")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FRef)
                    .HasMaxLength(50)
                    .HasColumnName("F_Ref");

                entity.Property(e => e.FSanad).HasColumnName("F_Sanad");

                entity.Property(e => e.FSerial).HasColumnName("F_Serial");

                entity.Property(e => e.FTaxId)
                    .HasMaxLength(50)
                    .HasColumnName("F_TaxId");

                entity.Property(e => e.FTimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("F_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FUid)
                    .HasMaxLength(50)
                    .HasColumnName("F_UID");

                entity.Property(e => e.FUser).HasColumnName("F_User");

            });

            modelBuilder.Entity<Factor2>(entity =>
            {
                entity.HasKey(e => new { e.FkFactor, e.FkRadif });

                entity.ToTable("Factor2");

                entity.HasIndex(e => e.FkKala, "IX_Factor2");

                entity.Property(e => e.FkFactor).HasColumnName("FK_Factor");

                entity.Property(e => e.FkRadif).HasColumnName("FK_Radif");

                entity.Property(e => e.FkArz).HasColumnName("FK_Arz");

                entity.Property(e => e.FkArze).HasColumnName("FK_Arze");

                entity.Property(e => e.FkAvarez).HasColumnName("FK_Avarez");

                entity.Property(e => e.FkDateModat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FK_DateModat")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FkKala).HasColumnName("FK_Kala");

                entity.Property(e => e.FkKdarsad).HasColumnName("FK_Kdarsad");

                entity.Property(e => e.FkKindArz).HasColumnName("FK_KindArz");

                entity.Property(e => e.FkMab).HasColumnName("FK_Mab");

                entity.Property(e => e.FkMaliat).HasColumnName("FK_Maliat");

                entity.Property(e => e.FkModat).HasColumnName("FK_Modat");

                entity.Property(e => e.FkNum).HasColumnName("FK_Num");

                entity.Property(e => e.FkNumKoli).HasColumnName("FK_NumKoli");

                entity.Property(e => e.FkSharh)
                    .HasMaxLength(80)
                    .HasColumnName("FK_Sharh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FkTdad).HasColumnName("FK_Tdad");

                entity.Property(e => e.FkTol).HasColumnName("FK_Tol");

                entity.Property(e => e.FkV).HasColumnName("FK_V");

                entity.HasOne(d => d.FkFactorNavigation)
                    .WithMany(p => p.Factor2s)
                    .HasForeignKey(d => d.FkFactor)
                    .HasConstraintName("FK_Factor2_Factor1");

            });

            modelBuilder.Entity<Ghest>(entity =>
            {
                entity.HasKey(e => new { e.GhMoshtari, e.GhNo });

                entity.ToTable("Ghest");

                entity.Property(e => e.GhMoshtari).HasColumnName("GH_Moshtari");

                entity.Property(e => e.GhNo).HasColumnName("GH_No");

                entity.Property(e => e.GhCodemeli)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GH_CODEMELI");

                entity.Property(e => e.GhDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GH_Date")
                    .IsFixedLength();

                entity.Property(e => e.GhDateV)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GH_DateV")
                    .IsFixedLength();

                entity.Property(e => e.GhDatevam)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GH_DATEVAM");

                entity.Property(e => e.GhMab).HasColumnName("GH_Mab");

                entity.Property(e => e.GhMabkolvam).HasColumnName("GH_MABKOLVAM");

                entity.Property(e => e.GhPayment).HasColumnName("GH_Payment");

                entity.Property(e => e.GhShrh)
                    .HasMaxLength(90)
                    .HasColumnName("GH_Shrh");

                entity.Property(e => e.GhVamacc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("GH_VAMACC")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Goroh>(entity =>
            {
                entity.HasKey(e => e.GhCode);

                entity.ToTable("Goroh");

                entity.HasIndex(e => e.GhName, "IX_Goroh")
                    .IsUnique();

                entity.Property(e => e.GhCode).HasColumnName("GH_Code");

                entity.Property(e => e.GhKind).HasColumnName("GH_Kind");

                entity.Property(e => e.GhMahiat).HasColumnName("GH_Mahiat");

                entity.Property(e => e.GhName)
                    .HasMaxLength(20)
                    .HasColumnName("GH_Name")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GorohK>(entity =>
            {
                entity.HasKey(e => e.GkCode)
                    .HasName("PK_GroupK");

                entity.ToTable("GorohK");

                entity.HasIndex(e => e.GkName, "IX_GorohK")
                    .IsUnique();

                entity.Property(e => e.GkCode)
                    .ValueGeneratedNever()
                    .HasColumnName("GK_Code");

                entity.Property(e => e.GkInForosh)
                    .IsRequired()
                    .HasColumnName("GK_inForosh")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GkInKhadmat)
                    .IsRequired()
                    .HasColumnName("GK_inKhadmat")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GkInKharid)
                    .IsRequired()
                    .HasColumnName("GK_inKharid")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GkName)
                    .HasMaxLength(30)
                    .HasColumnName("GK_Name")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GorohM>(entity =>
            {
                entity.HasKey(e => e.GmCode)
                    .HasName("PK_GroupM");

                entity.ToTable("GorohM");

                entity.HasIndex(e => e.GmName, "IX_GorohM")
                    .IsUnique();

                entity.Property(e => e.GmCode)
                    .ValueGeneratedNever()
                    .HasColumnName("GM_Code");

                entity.Property(e => e.GmInForosh)
                    .IsRequired()
                    .HasColumnName("GM_inForosh")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GmInKharid)
                    .IsRequired()
                    .HasColumnName("GM_inKharid")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GmInPosnt)
                    .IsRequired()
                    .HasColumnName("GM_inPosnt")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.GmName)
                    .HasMaxLength(50)
                    .HasColumnName("GM_Name")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GorohT>(entity =>
            {
                entity.HasKey(e => e.TCode)
                    .HasName("PK_Table1");

                entity.ToTable("GorohT");

                entity.Property(e => e.TCode)
                    .ValueGeneratedNever()
                    .HasColumnName("T_Code");

                entity.Property(e => e.TName)
                    .HasMaxLength(50)
                    .HasColumnName("T_Name")
                    .UseCollation("Arabic_CI_AI");

            });

            modelBuilder.Entity<InEditFactor>(entity =>
            {
                entity.HasKey(e => e.FFactor);

                entity.Property(e => e.FFactor)
                    .ValueGeneratedNever()
                    .HasColumnName("F_Factor");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

            });

            modelBuilder.Entity<InEditKhadamat>(entity =>
            {
                entity.HasKey(e => e.KhNo);

                entity.ToTable("InEditKhadamat");

                entity.Property(e => e.KhNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Kh_No");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

            });

            modelBuilder.Entity<InEditPayment>(entity =>
            {
                entity.HasKey(e => new { e.P1No, e.P1Kind })
                    .HasName("PK_InEditPayment");

                entity.Property(e => e.P1No).HasColumnName("P1_No");

                entity.Property(e => e.P1Kind).HasColumnName("P1_Kind");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.P1)
                    .WithMany(p => p.InEditPayments)
                    .HasForeignKey(d => new { d.P1Kind, d.P1No })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InEditPayment_Payment1");
            });

            modelBuilder.Entity<InEditSanad>(entity =>
            {
                entity.HasKey(e => e.SSanad);

                entity.Property(e => e.SSanad)
                    .ValueGeneratedNever()
                    .HasColumnName("S_Sanad");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

            });

            modelBuilder.Entity<InEditSefaresh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InEditSefaresh");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.S1No).HasColumnName("S1_No");

                entity.HasOne(d => d.S1NoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.S1No)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InEditSefaresh_Sefaresh1");
            });

            modelBuilder.Entity<Kafactor>(entity =>
            {
                entity.HasKey(e => e.KaFactor1);

                entity.ToTable("KAFactor");

                entity.HasIndex(e => e.KaName, "IX_KAFactor")
                    .IsUnique();

                entity.Property(e => e.KaFactor1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("KA_Factor")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KaAcc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("KA_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KaDarsad).HasColumnName("KA_Darsad");

                entity.Property(e => e.KaKind).HasColumnName("KA_Kind");

                entity.Property(e => e.KaName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KA_Name")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KaSabet).HasColumnName("KA_Sabet");

            });

            modelBuilder.Entity<KafactorL>(entity =>
            {
                entity.HasKey(e => new { e.LFactor, e.LKa });

                entity.ToTable("KAFactorL");

                entity.Property(e => e.LFactor).HasColumnName("L_Factor");

                entity.Property(e => e.LKa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("L_KA")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.LDarsad).HasColumnName("L_Darsad");

                entity.Property(e => e.LSabet).HasColumnName("L_Sabet");


                entity.HasOne(d => d.LKaNavigation)
                    .WithMany(p => p.KafactorLs)
                    .HasForeignKey(d => d.LKa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KAFactorL_KAFactor");
            });

            modelBuilder.Entity<Kala>(entity =>
            {
                entity.HasKey(e => e.KCode)
                    .HasName("PK_KALA");

                entity.ToTable("Kala");

                entity.HasIndex(e => e.KName, "IX_Kala")
                    .IsUnique();

                entity.Property(e => e.KCode)
                    .ValueGeneratedNever()
                    .HasColumnName("K_Code");

                entity.Property(e => e.KArz).HasColumnName("K_Arz");

                entity.Property(e => e.KArzMab).HasColumnName("K_ArzMab");

                entity.Property(e => e.KAvarez).HasColumnName("K_Avarez");

                entity.Property(e => e.KAvarezIs).HasColumnName("K_AvarezIs");

                entity.Property(e => e.KBarcode)
                    .HasMaxLength(40)
                    .HasColumnName("K_Barcode");

                entity.Property(e => e.KDarsad).HasColumnName("K_Darsad");

                entity.Property(e => e.KFani)
                    .HasMaxLength(15)
                    .HasColumnName("K_Fani")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KFani2)
                    .HasMaxLength(15)
                    .HasColumnName("K_fani2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KFmonth).HasColumnName("K_FMonth");

                entity.Property(e => e.KFmonth1).HasColumnName("K_FMonth1");

                entity.Property(e => e.KFmonth10).HasColumnName("K_FMonth10");

                entity.Property(e => e.KFmonth11).HasColumnName("K_FMonth11");

                entity.Property(e => e.KFmonth12).HasColumnName("K_FMonth12");

                entity.Property(e => e.KFmonth2).HasColumnName("K_FMonth2");

                entity.Property(e => e.KFmonth3).HasColumnName("K_FMonth3");

                entity.Property(e => e.KFmonth4).HasColumnName("K_FMonth4");

                entity.Property(e => e.KFmonth5).HasColumnName("K_FMonth5");

                entity.Property(e => e.KFmonth6).HasColumnName("K_FMonth6");

                entity.Property(e => e.KFmonth7).HasColumnName("K_FMonth7");

                entity.Property(e => e.KFmonth8).HasColumnName("K_FMonth8");

                entity.Property(e => e.KFmonth9).HasColumnName("K_FMonth9");

                entity.Property(e => e.KForoshH).HasColumnName("K_ForoshH");

                entity.Property(e => e.KForoshM).HasColumnName("K_ForoshM");

                entity.Property(e => e.KForoshMd).HasColumnName("K_ForoshMd");

                entity.Property(e => e.KForoshMsrf).HasColumnName("K_ForoshMsrf");

                entity.Property(e => e.KForoshN).HasColumnName("K_ForoshN");

                entity.Property(e => e.KFyear).HasColumnName("K_FYear");

                entity.Property(e => e.KGoroh).HasColumnName("K_Goroh");

                entity.Property(e => e.KHtmam).HasColumnName("K_HTmam");

                entity.Property(e => e.KHtolid).HasColumnName("K_HTolid");

                entity.Property(e => e.KIsBarcode).HasColumnName("K_IsBarcode");

                entity.Property(e => e.KKeshvar)
                    .HasMaxLength(50)
                    .HasColumnName("K_Keshvar")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KLan)
                    .HasColumnName("K_Lan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KLog)
                    .HasColumnName("K_Log")
                    .HasDefaultValueSql("((1))");


                entity.Property(e => e.KMaliat).HasColumnName("K_Maliat");

                entity.Property(e => e.KMaliatIs).HasColumnName("K_MaliatIs");

                entity.Property(e => e.KMaxF).HasColumnName("K_MaxF");

                entity.Property(e => e.KMinF).HasColumnName("K_MinF");

                entity.Property(e => e.KName)
                    .HasMaxLength(60)
                    .HasColumnName("K_Name")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KNameL)
                    .HasMaxLength(30)
                    .HasColumnName("K_NameL")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KOmde).HasColumnName("K_Omde");

                entity.Property(e => e.KPic)
                    .HasColumnType("image")
                    .HasColumnName("K_Pic");

                entity.Property(e => e.KPorsant).HasColumnName("K_Porsant");

                entity.Property(e => e.KSarbar).HasColumnName("K_Sarbar");

                entity.Property(e => e.KSharh)
                    .HasColumnType("ntext")
                    .HasColumnName("K_Sharh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KTolid).HasColumnName("K_Tolid");

                entity.Property(e => e.KVahed)
                    .HasMaxLength(8)
                    .HasColumnName("K_Vahed")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KVahedKoli)
                    .HasMaxLength(8)
                    .HasColumnName("K_VahedKoli")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KVazn).HasColumnName("K_Vazn");

                entity.Property(e => e.KZarib).HasColumnName("K_Zarib");

                entity.HasOne(d => d.KGorohNavigation)
                    .WithMany(p => p.Kalas)
                    .HasForeignKey(d => d.KGoroh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kala_GorohK");
            });

            modelBuilder.Entity<KalaM>(entity =>
            {
                entity.HasKey(e => new { e.KmCode, e.KmAnbar });

                entity.ToTable("KalaM");

                entity.Property(e => e.KmCode).HasColumnName("KM_Code");

                entity.Property(e => e.KmAnbar).HasColumnName("KM_Anbar");

                entity.Property(e => e.KKeshvar)
                    .HasMaxLength(50)
                    .HasColumnName("K_Keshvar")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KmArzArzesh).HasColumnName("KM_ArzArzesh");

                entity.Property(e => e.KmArzesh).HasColumnName("KM_Arzesh");

                entity.Property(e => e.KmEndArzArzesh).HasColumnName("KM_EndArzArzesh");

                entity.Property(e => e.KmEndArzesh).HasColumnName("KM_EndArzesh");

                entity.Property(e => e.KmEndMoj).HasColumnName("KM_EndMoj");

                entity.Property(e => e.KmEndMojKol).HasColumnName("KM_EndMojKol");

                entity.Property(e => e.KmKindArz).HasColumnName("KM_KindArz");

                entity.Property(e => e.KmLastArzArzesh).HasColumnName("KM_LastArzArzesh");

                entity.Property(e => e.KmLastArzesh)
                    .HasColumnName("KM_LastArzesh")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.KmMaxMoj).HasColumnName("KM_MaxMoj");

                entity.Property(e => e.KmMinMoj).HasColumnName("KM_MinMoj");

                entity.Property(e => e.KmMoj).HasColumnName("KM_Moj");

                entity.Property(e => e.KmMojKol).HasColumnName("KM_MojKol");

                entity.Property(e => e.KmRadif)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KM_Radif")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KmSefaresh).HasColumnName("KM_Sefaresh");

                entity.Property(e => e.KmShomaresh)
                    .HasColumnName("KM_Shomaresh")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.KmAnbarNavigation)
                    .WithMany(p => p.KalaMs)
                    .HasForeignKey(d => d.KmAnbar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KalaM_Anbar");

                entity.HasOne(d => d.KmCodeNavigation)
                    .WithMany(p => p.KalaMs)
                    .HasForeignKey(d => d.KmCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KalaM_Kala");
            });

            modelBuilder.Entity<KalaT>(entity =>
            {
                entity.HasKey(e => new { e.TKala, e.TRadif });

                entity.ToTable("KalaT");

                entity.Property(e => e.TKala).HasColumnName("T_Kala");

                entity.Property(e => e.TRadif).HasColumnName("T_Radif");

                entity.Property(e => e.TKalaItm).HasColumnName("T_KalaITM");

                entity.Property(e => e.TMab)
                    .HasColumnName("T_Mab")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TNum)
                    .HasColumnName("T_Num")
                    .HasDefaultValueSql("(0)");


            });

            modelBuilder.Entity<Khadamat>(entity =>
            {
                entity.HasKey(e => e.KhNo);

                entity.ToTable("Khadamat");

                entity.Property(e => e.KhNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Kh_No");

                entity.Property(e => e.KhAcc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Kh_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateF")
                    .HasDefaultValueSql("('____/__/__')")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateG)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateG")
                    .HasDefaultValueSql("('____/__/__')")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateT)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateT")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhFactor).HasColumnName("Kh_Factor");

                entity.Property(e => e.KhGhatat).HasColumnName("Kh_Ghatat");

                entity.Property(e => e.KhKalaName)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_KalaName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhKind)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Kind")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhKindPay).HasColumnName("Kh_KindPay");

                entity.Property(e => e.KhMarkaz).HasColumnName("Kh_Markaz");

                entity.Property(e => e.KhMname)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_MName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhMoshtari).HasColumnName("Kh_Moshtari");

                entity.Property(e => e.KhMotealegh)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Motealegh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhNoPay).HasColumnName("Kh_NoPay");

                entity.Property(e => e.KhOjrat).HasColumnName("Kh_Ojrat");

                entity.Property(e => e.KhSanad).HasColumnName("Kh_Sanad");

                entity.Property(e => e.KhSerial)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_Serial")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhSerial2)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_Serial2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhShrh)
                    .HasMaxLength(500)
                    .HasColumnName("Kh_Shrh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhShrh2)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Shrh2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhSum)
                    .HasColumnName("Kh_Sum")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.KhTimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Kh_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhUser).HasColumnName("Kh_User");


                entity.HasOne(d => d.KhMoshtariNavigation)
                    .WithMany(p => p.Khadamats)
                    .HasForeignKey(d => d.KhMoshtari)
                    .HasConstraintName("FK_Khadamat_Moshtari");

                entity.HasOne(d => d.KhSanadNavigation)
                    .WithMany(p => p.Khadamats)
                    .HasForeignKey(d => d.KhSanad)
                    .HasConstraintName("FK_Khadamat_Sanad");

                entity.HasOne(d => d.Kh)
                    .WithMany(p => p.Khadamats)
                    .HasForeignKey(d => new { d.KhKindPay, d.KhNoPay })
                    .HasConstraintName("FK_Khadamat_Payment1");
            });

            modelBuilder.Entity<Mantagh>(entity =>
            {
                entity.HasKey(e => e.CodeMantagh)
                    .HasName("PK__Mantagh__2F650636");

                entity.ToTable("Mantagh");

                entity.Property(e => e.CodeMantagh)
                    .ValueGeneratedNever()
                    .HasColumnName("Code_Mantagh");

                entity.Property(e => e.NameMantagh)
                    .HasMaxLength(40)
                    .HasColumnName("Name_Mantagh")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Moshtari>(entity =>
            {
                entity.HasKey(e => e.MCode)
                    .HasName("PK_MOSHTARI");

                entity.ToTable("Moshtari");

                entity.HasIndex(e => e.MName, "IX_Moshtari")
                    .IsUnique();

                entity.Property(e => e.MCode)
                    .ValueGeneratedNever()
                    .HasColumnName("M_Code");

                entity.Property(e => e.MAcc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("M_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MAddress)
                    .HasMaxLength(100)
                    .HasColumnName("M_Address")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MAtbar).HasColumnName("M_Atbar");

                entity.Property(e => e.MCity)
                    .HasMaxLength(50)
                    .HasColumnName("M_City")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MCodeMantagh).HasColumnName("M_CodeMantagh");

                entity.Property(e => e.MDateList)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("M_DateList")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MEconomy)
                    .HasMaxLength(50)
                    .HasColumnName("M_Economy")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MEmail)
                    .HasMaxLength(100)
                    .HasColumnName("M_Email")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MGoroh).HasColumnName("M_Goroh");

                entity.Property(e => e.MHmkar).HasColumnName("M_Hmkar");

                entity.Property(e => e.MKol)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("M_Kol")
                    .IsFixedLength();

                entity.Property(e => e.MLan).HasColumnName("M_Lan");

                entity.Property(e => e.MLog).HasColumnName("M_Log");

                entity.Property(e => e.MLogHsab).HasColumnName("M_LogHsab");

                entity.Property(e => e.MMeli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("M_Meli");

                entity.Property(e => e.MMobil)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("M_Mobil")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MMobile2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M_Mobile2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MModir).HasColumnName("M_MODIR");

                entity.Property(e => e.MMoein)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("M_Moein")
                    .IsFixedLength();

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .HasColumnName("M_Name")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MNameL)
                    .HasMaxLength(50)
                    .HasColumnName("M_NameL")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MOnvan).HasColumnName("M_Onvan");

                entity.Property(e => e.MOstan)
                    .HasMaxLength(50)
                    .HasColumnName("M_Ostan")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MPic)
                    .HasColumnType("image")
                    .HasColumnName("M_Pic");

                entity.Property(e => e.MPorsant).HasColumnName("M_Porsant");

                entity.Property(e => e.MPost)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("M_Post")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MSabt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M_SABT")
                    .UseCollation("Arabic_CI_AI");
                entity.Property(e => e.MTel1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("M_Tel1");

                entity.Property(e => e.MTel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("M_Tel2");

                entity.Property(e => e.MTel3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M_Tel3")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MTel4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M_Tel4")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MTelSms).HasColumnName("M_TelSMS");

                entity.Property(e => e.MTfzili)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("M_Tfzili")
                    .IsFixedLength();

                entity.Property(e => e.MTxt)
                    .HasColumnType("text")
                    .HasColumnName("M_Txt");


                entity.HasOne(d => d.MGorohNavigation)
                    .WithMany(p => p.Moshtaris)
                    .HasForeignKey(d => d.MGoroh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Moshtari_GorohM");
            });

            modelBuilder.Entity<MoshtariTkmili>(entity =>
            {
                entity.HasKey(e => e.MCodeM);

                entity.ToTable("MoshtariTkmili");

                entity.Property(e => e.MCodeM)
                    .ValueGeneratedNever()
                    .HasColumnName("M_CodeM");

                entity.Property(e => e.MAddressKar)
                    .HasMaxLength(200)
                    .HasColumnName("M_AddressKar")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MAddressMnzl)
                    .HasMaxLength(200)
                    .HasColumnName("M_AddressMnzl")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MDateEnd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("M_DateEnd")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MDateFirst)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("M_DateFirst")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MFather)
                    .HasMaxLength(50)
                    .HasColumnName("M_Father")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MSadere)
                    .HasMaxLength(50)
                    .HasColumnName("M_Sadere")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MShnasnameh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_Shnasnameh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MTavalod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("M_Tavalod")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MVsighe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("M_Vsighe")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn1)
                    .HasMaxLength(50)
                    .HasColumnName("M_Zmn1")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn1Address)
                    .HasMaxLength(200)
                    .HasColumnName("M_Zmn1Address")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn1CodeMli)
                    .HasMaxLength(10)
                    .HasColumnName("M_Zmn1CodeMli")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn1Tel)
                    .HasMaxLength(20)
                    .HasColumnName("M_Zmn1Tel")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn1Vsighe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("M_Zmn1Vsighe")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn2)
                    .HasMaxLength(50)
                    .HasColumnName("M_Zmn2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn2Address)
                    .HasMaxLength(200)
                    .HasColumnName("M_Zmn2Address")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn2CodeMli)
                    .HasMaxLength(10)
                    .HasColumnName("M_Zmn2CodeMli")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn2Tel)
                    .HasMaxLength(20)
                    .HasColumnName("M_Zmn2Tel")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn2Vsighe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("M_Zmn2Vsighe")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn3)
                    .HasMaxLength(50)
                    .HasColumnName("M_Zmn3")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn3Address)
                    .HasMaxLength(200)
                    .HasColumnName("M_Zmn3Address")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn3CodeMli)
                    .HasMaxLength(10)
                    .HasColumnName("M_Zmn3CodeMli")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn3Tel)
                    .HasMaxLength(20)
                    .HasColumnName("M_Zmn3Tel")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MZmn3Vsighe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("M_Zmn3Vsighe")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

            });

            modelBuilder.Entity<NoteBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NoteBook");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Onvan>(entity =>
            {

                entity.ToTable("Onvan");

            });

            modelBuilder.Entity<Payment1>(entity =>
            {
                entity.HasKey(e => new { e.P1Kind, e.P1No });

                entity.ToTable("Payment1");

                entity.Property(e => e.P1Kind).HasColumnName("P1_Kind");

                entity.Property(e => e.P1No).HasColumnName("P1_No");

                entity.Property(e => e.P1Acc1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P1_Acc1")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1Acc2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P1_Acc2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P1_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1DateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P1_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1IsArz)
                    .HasColumnName("P1_IsArz")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.P1Markaz).HasColumnName("P1_Markaz");

                entity.Property(e => e.P1Moshtari).HasColumnName("P1_Moshtari");

                entity.Property(e => e.P1Sanad).HasColumnName("P1_Sanad");

                entity.Property(e => e.P1Sum)
                    .HasColumnName("P1_Sum")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.P1TimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("P1_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1User).HasColumnName("P1_User");


                entity.HasOne(d => d.P1MoshtariNavigation)
                    .WithMany(p => p.Payment1s)
                    .HasForeignKey(d => d.P1Moshtari)
                    .HasConstraintName("FK_Payment1_Moshtari");

                entity.HasOne(d => d.P1SanadNavigation)
                    .WithMany(p => p.Payment1s)
                    .HasForeignKey(d => d.P1Sanad)
                    .HasConstraintName("FK_Payment1_Sanad");
            });

            modelBuilder.Entity<Payment2>(entity =>
            {
                entity.HasKey(e => new { e.P2Kind, e.P2No, e.P2Radif });

                entity.ToTable("Payment2");

                entity.Property(e => e.P2Kind).HasColumnName("P2_Kind");

                entity.Property(e => e.P2No).HasColumnName("P2_No");

                entity.Property(e => e.P2Radif).HasColumnName("P2_Radif");

                entity.Property(e => e.P2Acc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P2_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P2Acc2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P2_Acc2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P2ArzKol).HasColumnName("P2_ArzKol");

                entity.Property(e => e.P2ArzMab).HasColumnName("P2_ArzMab");

                entity.Property(e => e.P2ArzType).HasColumnName("P2_ArzType");

                entity.Property(e => e.P2Check).HasColumnName("P2_Check");

                entity.Property(e => e.P2KindC).HasColumnName("P2_KindC");

                entity.Property(e => e.P2KindP).HasColumnName("P2_KindP");

                entity.Property(e => e.P2Mab)
                    .HasColumnName("P2_Mab")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.P2Shrh)
                    .HasMaxLength(80)
                    .HasColumnName("P2_Shrh")
                    .UseCollation("Arabic_CI_AI");


                entity.HasOne(d => d.P2CheckNavigation)
                    .WithMany(p => p.Payment2s)
                    .HasForeignKey(d => d.P2Check)
                    .HasConstraintName("FK_Payment2_Check");

                entity.HasOne(d => d.P2)
                    .WithMany(p => p.Payment2s)
                    .HasForeignKey(d => new { d.P2Kind, d.P2No })
                    .HasConstraintName("FK_Payment2_Payment1");
            });

            modelBuilder.Entity<Rfactor1>(entity =>
            {
                entity.HasKey(e => e.RNo);

                entity.ToTable("RFactor1");

                entity.Property(e => e.RNo)
                    .ValueGeneratedNever()
                    .HasColumnName("R_No");

                entity.Property(e => e.FAccAnbar)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccAnbar")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAccEzafat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccEzafat")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAccKosorat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("F_AccKosorat")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FAnbar).HasColumnName("F_Anbar");

                entity.Property(e => e.FAnbar2).HasColumnName("F_Anbar2");

                entity.Property(e => e.FAvarez).HasColumnName("F_Avarez");

                entity.Property(e => e.FDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateA")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateTahvil)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateTahvil")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("F_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FDriverName)
                    .HasMaxLength(100)
                    .HasColumnName("F_DriverName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FEzafat).HasColumnName("F_Ezafat");

                entity.Property(e => e.FFactor).HasColumnName("F_Factor");

                entity.Property(e => e.FFixEzafat).HasColumnName("F_FixEzafat");

                entity.Property(e => e.FFixKosorat).HasColumnName("F_FixKosorat");

                entity.Property(e => e.FFixPorsant).HasColumnName("F_FixPorsant");

                entity.Property(e => e.FFlag).HasColumnName("F_Flag");

                entity.Property(e => e.FKdarsad)
                    .HasColumnName("F_Kdarsad")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FKind).HasColumnName("F_Kind");

                entity.Property(e => e.FKindPay).HasColumnName("F_KindPay");

                entity.Property(e => e.FKosor).HasColumnName("F_Kosor");

                entity.Property(e => e.FMab).HasColumnName("F_Mab");

                entity.Property(e => e.FMabKol).HasColumnName("F_MabKol");

                entity.Property(e => e.FMabPorsant).HasColumnName("F_MabPorsant");

                entity.Property(e => e.FMaliat).HasColumnName("F_Maliat");

                entity.Property(e => e.FMoshtari).HasColumnName("F_Moshtari");

                entity.Property(e => e.FMrkaz).HasColumnName("F_Mrkaz");

                entity.Property(e => e.FNo).HasColumnName("F_No");

                entity.Property(e => e.FNoPay).HasColumnName("F_NoPay");

                entity.Property(e => e.FPorsant).HasColumnName("F_Porsant");

                entity.Property(e => e.FSanad).HasColumnName("F_Sanad");

                entity.Property(e => e.FSerial).HasColumnName("F_Serial");


                entity.Property(e => e.FTimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("F_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");


                entity.Property(e => e.FUser).HasColumnName("F_User");
            });

            modelBuilder.Entity<Rfactor2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RFactor2");

                entity.Property(e => e.FkArz).HasColumnName("FK_Arz");

                entity.Property(e => e.FkArze).HasColumnName("FK_Arze");

                entity.Property(e => e.FkAvarez).HasColumnName("FK_Avarez");

                entity.Property(e => e.FkDateModat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FK_DateModat")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FkFactor).HasColumnName("FK_Factor");

                entity.Property(e => e.FkKala).HasColumnName("FK_Kala");

                entity.Property(e => e.FkKdarsad).HasColumnName("FK_Kdarsad");

                entity.Property(e => e.FkKindArz).HasColumnName("FK_KindArz");

                entity.Property(e => e.FkMab).HasColumnName("FK_Mab");

                entity.Property(e => e.FkMaliat).HasColumnName("FK_Maliat");

                entity.Property(e => e.FkModat).HasColumnName("FK_Modat");

                entity.Property(e => e.FkNum).HasColumnName("FK_Num");

                entity.Property(e => e.FkNumKoli).HasColumnName("FK_NumKoli");

                entity.Property(e => e.FkRadif).HasColumnName("FK_Radif");

                entity.Property(e => e.FkSharh)
                    .HasMaxLength(80)
                    .HasColumnName("FK_Sharh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FkTdad).HasColumnName("FK_Tdad");

                entity.Property(e => e.FkTol).HasColumnName("FK_Tol");

                entity.Property(e => e.FkV).HasColumnName("FK_V");

                entity.Property(e => e.RNo).HasColumnName("R_No");

                entity.HasOne(d => d.RNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RNo)
                    .HasConstraintName("FK_RFactor2_RFactor1");
            });

            modelBuilder.Entity<Rkhadamat>(entity =>
            {
                entity.HasKey(e => e.RNo);

                entity.ToTable("RKhadamat");

                entity.Property(e => e.RNo)
                    .ValueGeneratedNever()
                    .HasColumnName("R_No");

                entity.Property(e => e.KhAcc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Kh_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateF")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateG)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateG")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateT)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateT")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Kh_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhFactor).HasColumnName("Kh_Factor");

                entity.Property(e => e.KhGhatat).HasColumnName("Kh_Ghatat");

                entity.Property(e => e.KhKalaName)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_KalaName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhKind)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Kind")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhKindPay).HasColumnName("Kh_KindPay");

                entity.Property(e => e.KhMarkaz).HasColumnName("Kh_Markaz");

                entity.Property(e => e.KhMname)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_MName")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhMoshtari).HasColumnName("Kh_Moshtari");

                entity.Property(e => e.KhMotealegh)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Motealegh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhNo).HasColumnName("Kh_No");

                entity.Property(e => e.KhNoPay).HasColumnName("Kh_NoPay");

                entity.Property(e => e.KhOjrat).HasColumnName("Kh_Ojrat");

                entity.Property(e => e.KhSanad).HasColumnName("Kh_Sanad");

                entity.Property(e => e.KhSerial)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_Serial")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhSerial2)
                    .HasMaxLength(100)
                    .HasColumnName("Kh_Serial2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhShrh)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Shrh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhShrh2)
                    .HasColumnType("text")
                    .HasColumnName("Kh_Shrh2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhSum).HasColumnName("Kh_Sum");

                entity.Property(e => e.KhTimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Kh_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.KhUser).HasColumnName("Kh_User");
            });

            modelBuilder.Entity<Rpayment1>(entity =>
            {
                entity.HasKey(e => e.RNo);

                entity.ToTable("RPayment1");

                entity.Property(e => e.RNo)
                    .ValueGeneratedNever()
                    .HasColumnName("R_No");

                entity.Property(e => e.P1Acc1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P1_Acc1")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1Acc2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P1_Acc2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P1_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1DateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P1_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1IsArz).HasColumnName("P1_IsArz");

                entity.Property(e => e.P1Kind).HasColumnName("P1_Kind");

                entity.Property(e => e.P1Markaz).HasColumnName("P1_Markaz");

                entity.Property(e => e.P1Moshtari).HasColumnName("P1_Moshtari");

                entity.Property(e => e.P1No).HasColumnName("P1_No");

                entity.Property(e => e.P1Sanad).HasColumnName("P1_Sanad");

                entity.Property(e => e.P1Sum).HasColumnName("P1_Sum");

                entity.Property(e => e.P1TimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("P1_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P1User).HasColumnName("P1_User");
            });

            modelBuilder.Entity<Rpayment2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPayment2");

                entity.Property(e => e.P2Acc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P2_Acc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P2Acc2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P2_Acc2")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.P2ArzKol).HasColumnName("P2_ArzKol");

                entity.Property(e => e.P2ArzMab).HasColumnName("P2_ArzMab");

                entity.Property(e => e.P2ArzType).HasColumnName("P2_ArzType");

                entity.Property(e => e.P2Check).HasColumnName("P2_Check");

                entity.Property(e => e.P2Kind).HasColumnName("P2_Kind");

                entity.Property(e => e.P2KindC).HasColumnName("P2_KindC");

                entity.Property(e => e.P2KindP).HasColumnName("P2_KindP");

                entity.Property(e => e.P2Mab).HasColumnName("P2_Mab");

                entity.Property(e => e.P2No).HasColumnName("P2_No");

                entity.Property(e => e.P2Radif).HasColumnName("P2_Radif");

                entity.Property(e => e.P2Shrh)
                    .HasMaxLength(80)
                    .HasColumnName("P2_Shrh")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RNo).HasColumnName("R_No");

                entity.HasOne(d => d.RNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RNo)
                    .HasConstraintName("FK_RPayment2_RPayment1");
            });

            modelBuilder.Entity<Rsanad>(entity =>
            {
                entity.HasKey(e => e.RNo);

                entity.ToTable("RSanad");

                entity.Property(e => e.RNo)
                    .ValueGeneratedNever()
                    .HasColumnName("R_No");

                entity.Property(e => e.SDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SFlag).HasColumnName("S_Flag");

                entity.Property(e => e.SInEdit).HasColumnName("S_InEdit");

                entity.Property(e => e.SIsArz).HasColumnName("S_IsArz");

                entity.Property(e => e.SMarkaz).HasColumnName("S_Markaz");

                entity.Property(e => e.SNo).HasColumnName("S_No");


                entity.Property(e => e.SSanad).HasColumnName("S_Sanad");

                entity.Property(e => e.STemp).HasColumnName("S_Temp");

                entity.Property(e => e.STimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("S_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("S_Type")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SUser).HasColumnName("S_User");
            });

            modelBuilder.Entity<RsanadItm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RSanadITM");

                entity.Property(e => e.ACode).HasColumnName("A_Code");

                entity.Property(e => e.Acc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BBar).HasColumnName("B_bar");

                entity.Property(e => e.FFactor).HasColumnName("F_Factor");

                entity.Property(e => e.HHesab).HasColumnName("H_Hesab");

                entity.Property(e => e.KhKhadamat).HasColumnName("Kh_Khadamat");

                entity.Property(e => e.PKind).HasColumnName("P_Kind");

                entity.Property(e => e.PPayment).HasColumnName("P_Payment");

                entity.Property(e => e.RNo).HasColumnName("R_No");

                entity.Property(e => e.SSanad).HasColumnName("S_Sanad");

                entity.Property(e => e.Sharh)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.RNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSanadITM_RSanad");
            });

            modelBuilder.Entity<Sanad>(entity =>
            {
                entity.HasKey(e => e.SSanad);

                entity.ToTable("Sanad");

                entity.HasIndex(e => e.SNo, "IX_Sanad");

                entity.HasIndex(e => e.SDate, "IX_Sanad_1");

                entity.Property(e => e.SSanad)
                    .ValueGeneratedNever()
                    .HasColumnName("S_Sanad");

                entity.Property(e => e.SDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SDateU)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_DateU")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SFlag).HasColumnName("S_Flag");

                entity.Property(e => e.SInEdit).HasColumnName("S_InEdit");

                entity.Property(e => e.SIsArz).HasColumnName("S_IsArz");

                entity.Property(e => e.SMarkaz).HasColumnName("S_Markaz");

                entity.Property(e => e.SNo).HasColumnName("S_No");


                entity.Property(e => e.STemp).HasColumnName("S_Temp");

                entity.Property(e => e.STimeU)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("S_TimeU")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("S_Type")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SUser).HasColumnName("S_User");
            });

            modelBuilder.Entity<SanadItm>(entity =>
            {
                entity.HasKey(e => new { e.SSanad, e.Radif });

                entity.ToTable("SanadITM");

                entity.HasIndex(e => e.Acc, "IX_Check");

                entity.Property(e => e.SSanad).HasColumnName("S_Sanad");

                entity.Property(e => e.ACode).HasColumnName("A_Code");

                entity.Property(e => e.Acc)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ArzBed).HasDefaultValueSql("(0)");

                entity.Property(e => e.ArzBes).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBar).HasColumnName("B_bar");

                entity.Property(e => e.FFactor).HasColumnName("F_Factor");

                entity.Property(e => e.HHesab).HasColumnName("H_Hesab");

                entity.Property(e => e.KhKhadamat).HasColumnName("Kh_Khadamat");

                entity.Property(e => e.PKind).HasColumnName("P_Kind");

                entity.Property(e => e.PPayment).HasColumnName("P_Payment");

                entity.Property(e => e.Sharh)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AI");


                entity.HasOne(d => d.KhKhadamatNavigation)
                    .WithMany(p => p.SanadItms)
                    .HasForeignKey(d => d.KhKhadamat)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SanadITM_Khadamat");

                entity.HasOne(d => d.SSanadNavigation)
                    .WithMany(p => p.SanadItms)
                    .HasForeignKey(d => d.SSanad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanadITM_Sanad");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SanadItms)
                    .HasForeignKey(d => new { d.PKind, d.PPayment })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SanadITM_Payment1");
            });

            modelBuilder.Entity<Sefaresh1>(entity =>
            {
                entity.HasKey(e => e.S1No)
                    .HasName("PK_Sefaresh1_1");

                entity.ToTable("Sefaresh1");

                entity.Property(e => e.S1No)
                    .ValueGeneratedNever()
                    .HasColumnName("S1_No");

                entity.Property(e => e.S1Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S1_Date")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.S1Foroshande)
                    .HasMaxLength(100)
                    .HasColumnName("S1_Foroshande")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.S1Kind).HasColumnName("S1_Kind");

                entity.Property(e => e.S1Mrkaz).HasColumnName("S1_Mrkaz");

                entity.Property(e => e.S1User).HasColumnName("S1_User");

                entity.Property(e => e.S1Vahed)
                    .HasMaxLength(200)
                    .HasColumnName("S1_Vahed")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Sefaresh2>(entity =>
            {
                entity.HasKey(e => new { e.S2No, e.S2Radif });

                entity.ToTable("Sefaresh2");

                entity.Property(e => e.S2No).HasColumnName("S2_No");

                entity.Property(e => e.S2Radif).HasColumnName("S2_Radif");

                entity.Property(e => e.S2DateE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S2_DateE")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.S2DateR)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S2_DateR")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.S2Kala).HasColumnName("S2_Kala");

                entity.Property(e => e.S2Kind).HasColumnName("S2_Kind");

                entity.Property(e => e.S2Num).HasColumnName("S2_Num");

                entity.Property(e => e.S2Num2).HasColumnName("S2_Num2");

                entity.Property(e => e.S2Shrh)
                    .HasMaxLength(200)
                    .HasColumnName("S2_Shrh")
                    .UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.S2KalaNavigation)
                    .WithMany(p => p.Sefaresh2s)
                    .HasForeignKey(d => d.S2Kala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sefaresh2_Kala");

                entity.HasOne(d => d.S2NoNavigation)
                    .WithMany(p => p.Sefaresh2s)
                    .HasForeignKey(d => d.S2No)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sefaresh2_Sefaresh1");
            });

            modelBuilder.Entity<Sm>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeliverDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeliverMessage)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeliverStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeliverTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SendDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SendTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Txt)
                    .HasMaxLength(250)
                    .HasColumnName("txt")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<Vahed>(entity =>
            {
                entity.HasKey(e => e.VCode)
                    .HasName("PK_VAHED");

                entity.ToTable("Vahed");

                entity.HasIndex(e => e.VName, "IX_Vahed")
                    .IsUnique();

                entity.Property(e => e.VCode)
                    .ValueGeneratedNever()
                    .HasColumnName("V_Code");


                entity.Property(e => e.VName)
                    .HasMaxLength(8)
                    .HasColumnName("V_Name")
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.ACode).HasColumnName("A_Code");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
