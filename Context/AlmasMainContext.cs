using System;
using System.Collections.Generic;
using CityInfoApi.AlmasMain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CityInfoApi.Models
{
    public partial class AlmasMainContext : DbContext
    {
        public AlmasMainContext()
        {
        }

        public AlmasMainContext(DbContextOptions<AlmasMainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysCompany> SysCompanies { get; set; } = null!;
        public virtual DbSet<SysDaftar> SysDaftars { get; set; } = null!;
        public virtual DbSet<SysYear> SysYears { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Markaz> Markazs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AI");
            modelBuilder.Entity<Markaz>(entity =>
            {
                entity.HasKey(e => e.ZCode);

                entity.ToTable("Markaz");

                entity.Property(e => e.ZCode).HasColumnName("Z_Code");

                entity.Property(e => e.ZFlag).HasColumnName("Z_Flag");

                entity.Property(e => e.ZName)
                    .HasMaxLength(20)
                    .HasColumnName("Z_Name");
            });
            modelBuilder.Entity<SysCompany>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("SysCompany");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("C_ID");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(150)
                    .HasColumnName("C_Address");

                entity.Property(e => e.CArm)
                    .HasColumnType("image")
                    .HasColumnName("C_Arm");

                entity.Property(e => e.CBackupPath)
                    .HasColumnType("text")
                    .HasColumnName("C_BackupPath");

                entity.Property(e => e.CCity)
                    .HasMaxLength(50)
                    .HasColumnName("C_City");

                entity.Property(e => e.CEconomy)
                    .HasMaxLength(50)
                    .HasColumnName("C_Economy");

                entity.Property(e => e.CKey)
                    .HasColumnType("text")
                    .HasColumnName("C_Key");

                entity.Property(e => e.CMali)
                    .HasMaxLength(100)
                    .HasColumnName("C_Mali");

                entity.Property(e => e.CMeli)
                    .HasMaxLength(20)
                    .HasColumnName("C_Meli");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .HasColumnName("C_Name");

                entity.Property(e => e.CNovin)
                    .HasMaxLength(50)
                    .HasColumnName("C_Novin");

                entity.Property(e => e.COstan)
                    .HasMaxLength(50)
                    .HasColumnName("C_Ostan");

                entity.Property(e => e.CPost)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("C_Post");

                entity.Property(e => e.CSabt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Sabt");

                entity.Property(e => e.CTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_Tel");

                entity.Property(e => e.CVersion)
                    .HasMaxLength(200)
                    .HasColumnName("C_Version");

                entity.Property(e => e.CWeb)
                    .HasMaxLength(100)
                    .HasColumnName("C_Web");
            });

            modelBuilder.Entity<SysDaftar>(entity =>
            {
                entity.HasKey(e => e.DId);

                entity.ToTable("SysDaftar");

                entity.Property(e => e.DId)
                    .ValueGeneratedNever()
                    .HasColumnName("D_ID");

                entity.Property(e => e.DName)
                    .HasMaxLength(50)
                    .HasColumnName("D_Name");
            });

            modelBuilder.Entity<SysYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SysYear");

                entity.Property(e => e.YAvarez).HasColumnName("Y_Avarez");

                entity.Property(e => e.YCompany).HasColumnName("Y_Company");

                entity.Property(e => e.YDaftar).HasColumnName("Y_Daftar");

                entity.Property(e => e.YDateE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Y_DateE")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength();

                entity.Property(e => e.YDateF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Y_DateF")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength();

                entity.Property(e => e.YDbname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Y_DBName");

                entity.Property(e => e.YFirstSanad).HasColumnName("Y_FirstSanad");

                entity.Property(e => e.YFlag)
                    .HasColumnName("Y_Flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.YLastSanad).HasColumnName("Y_LastSanad");

                entity.Property(e => e.YMaliat).HasColumnName("Y_Maliat");

                entity.Property(e => e.YYear).HasColumnName("Y_Year");

                entity.HasOne(d => d.YCompanyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.YCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysYear_SysCompany");

                entity.HasOne(d => d.YDaftarNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.YDaftar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysYear_SysDaftar");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UNo);

                entity.ToTable("User");

                entity.Property(e => e.UNo).HasColumnName("U_No");

                entity.Property(e => e.UActive).HasColumnName("U_Active");

                entity.Property(e => e.UAdd).HasColumnName("U_Add");

                entity.Property(e => e.UAddDb).HasColumnName("U_Add_DB");

                entity.Property(e => e.UDateL)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("U_DateL")
                    .HasDefaultValueSql("('____/__/__')")
                    .IsFixedLength();

                entity.Property(e => e.UDelDb).HasColumnName("U_Del_DB");

                entity.Property(e => e.UDele).HasColumnName("U_Dele");

                entity.Property(e => e.UEsla).HasColumnName("U_Esla");

                entity.Property(e => e.UHgd)
                    .HasColumnType("text")
                    .HasColumnName("U_HGD");

                entity.Property(e => e.UKind).HasColumnName("U_Kind");

                entity.Property(e => e.UList).HasColumnName("U_List");

                entity.Property(e => e.UName)
                    .HasMaxLength(20)
                    .HasColumnName("U_Name");

                entity.Property(e => e.URamz)
                    .HasMaxLength(30)
                    .HasColumnName("U_Ramz");

                entity.Property(e => e.UTimeE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("U_TimeE")
                    .IsFixedLength();

                entity.Property(e => e.UTimeF)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("U_TimeF")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
