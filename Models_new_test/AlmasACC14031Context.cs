using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CityInfoApi.Models_new_test
{
    public partial class AlmasACC14031Context : DbContext
    {
        public AlmasACC14031Context()
        {
        }

        public AlmasACC14031Context(DbContextOptions<AlmasACC14031Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Factor1> Factor1s { get; set; } = null!;
        public virtual DbSet<Factor2> Factor2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AlmasACC14031;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1256_CI_AS");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
