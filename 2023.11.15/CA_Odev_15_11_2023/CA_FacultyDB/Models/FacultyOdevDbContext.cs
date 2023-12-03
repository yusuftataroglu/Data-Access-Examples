using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CA_FacultyDB.Models;

public partial class FacultyOdevDbContext : DbContext
{
    public FacultyOdevDbContext()
    {
    }

    public FacultyOdevDbContext(DbContextOptions<FacultyOdevDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AkademikPersoneller> AkademikPersonellers { get; set; }

    public virtual DbSet<Bolumler> Bolumlers { get; set; }

    public virtual DbSet<BolumlerAkademikPersoneller> BolumlerAkademikPersonellers { get; set; }

    public virtual DbSet<Dersler> Derslers { get; set; }

    public virtual DbSet<DerslerAkademikPersoneller> DerslerAkademikPersonellers { get; set; }

    public virtual DbSet<IdariPersoneller> IdariPersonellers { get; set; }

    public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }

    public virtual DbSet<OgrencilerBolumler> OgrencilerBolumlers { get; set; }

    public virtual DbSet<OgrencilerDersler> OgrencilerDerslers { get; set; }

    public virtual DbSet<OgrencilerSosyalKulupler> OgrencilerSosyalKuluplers { get; set; }

    public virtual DbSet<SosyalKulupler> SosyalKuluplers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=YUSUF-PC\\SQLEXPRESS;database=FacultyOdevDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AkademikPersoneller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Akademik__3214EC27F0E394AC");

            entity.ToTable("AkademikPersoneller");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alan).HasMaxLength(100);
            entity.Property(e => e.DoğumTarihi).HasColumnType("date");
            entity.Property(e => e.DoğumYeri).HasMaxLength(50);
            entity.Property(e => e.PersonelNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Soyisim).HasMaxLength(50);
            entity.Property(e => e.TcNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TelNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ünvan).HasMaxLength(50);
            entity.Property(e => e.İkametgahAdresi).HasMaxLength(255);
            entity.Property(e => e.İsim).HasMaxLength(50);
        });

        modelBuilder.Entity<Bolumler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bolumler__3214EC277BE48C0F");

            entity.ToTable("Bolumler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bölümİsmi).HasMaxLength(255);
        });

        modelBuilder.Entity<BolumlerAkademikPersoneller>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BolumlerAkademikPersoneller");

            entity.Property(e => e.AkademikPersonelId).HasColumnName("AkademikPersonelID");
            entity.Property(e => e.BölümId).HasColumnName("BölümID");

            entity.HasOne(d => d.AkademikPersonel).WithMany()
                .HasForeignKey(d => d.AkademikPersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BolumlerA__Akade__49C3F6B7");

            entity.HasOne(d => d.Bölüm).WithMany()
                .HasForeignKey(d => d.BölümId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BolumlerA__Bölüm__48CFD27E");
        });

        modelBuilder.Entity<Dersler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dersler__3214EC2768AC157A");

            entity.ToTable("Dersler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Akts).HasColumnName("AKTS");
            entity.Property(e => e.Dersİsmi).HasMaxLength(100);
        });

        modelBuilder.Entity<DerslerAkademikPersoneller>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DerslerAkademikPersoneller");

            entity.Property(e => e.AkademikPersonelId).HasColumnName("AkademikPersonelID");
            entity.Property(e => e.DersId).HasColumnName("DersID");

            entity.HasOne(d => d.AkademikPersonel).WithMany()
                .HasForeignKey(d => d.AkademikPersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DerslerAk__Akade__4CA06362");

            entity.HasOne(d => d.Ders).WithMany()
                .HasForeignKey(d => d.DersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DerslerAk__DersI__4BAC3F29");
        });

        modelBuilder.Entity<IdariPersoneller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IdariPer__3214EC275A2C8EB4");

            entity.ToTable("IdariPersoneller");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BölümId).HasColumnName("BölümID");
            entity.Property(e => e.DoğumTarihi).HasColumnType("date");
            entity.Property(e => e.DoğumYeri).HasMaxLength(50);
            entity.Property(e => e.Pozisyon).HasMaxLength(50);
            entity.Property(e => e.Soyisim).HasMaxLength(50);
            entity.Property(e => e.TcNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TelNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.İkametgahAdresi).HasMaxLength(255);
            entity.Property(e => e.İsim).HasMaxLength(50);

            entity.HasOne(d => d.Bölüm).WithMany(p => p.IdariPersonellers)
                .HasForeignKey(d => d.BölümId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IdariPers__Bölüm__4F7CD00D");
        });

        modelBuilder.Entity<Ogrenciler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ogrencil__3214EC2759F2BCC3");

            entity.ToTable("Ogrenciler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoğumTarihi).HasColumnType("date");
            entity.Property(e => e.DoğumYeri).HasMaxLength(50);
            entity.Property(e => e.Soyisim).HasMaxLength(50);
            entity.Property(e => e.TcNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TelNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ÖğrenciNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.İkametgahAdresi).HasMaxLength(255);
            entity.Property(e => e.İsim).HasMaxLength(50);
        });

        modelBuilder.Entity<OgrencilerBolumler>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OgrencilerBolumler");

            entity.Property(e => e.BölümId).HasColumnName("BölümID");
            entity.Property(e => e.ÖğrenciId).HasColumnName("ÖğrenciID");

            entity.HasOne(d => d.Bölüm).WithMany()
                .HasForeignKey(d => d.BölümId)
                .HasConstraintName("FK__Ogrencile__Bölüm__3B75D760");

            entity.HasOne(d => d.Öğrenci).WithMany()
                .HasForeignKey(d => d.ÖğrenciId)
                .HasConstraintName("FK__Ogrencile__Öğren__3A81B327");
        });

        modelBuilder.Entity<OgrencilerDersler>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OgrencilerDersler");

            entity.Property(e => e.DersId).HasColumnName("DersID");
            entity.Property(e => e.ÖğrenciId).HasColumnName("ÖğrenciID");

            entity.HasOne(d => d.Ders).WithMany()
                .HasForeignKey(d => d.DersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ogrencile__DersI__403A8C7D");

            entity.HasOne(d => d.Öğrenci).WithMany()
                .HasForeignKey(d => d.ÖğrenciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ogrencile__Öğren__3F466844");
        });

        modelBuilder.Entity<OgrencilerSosyalKulupler>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OgrencilerSosyalKulupler");

            entity.Property(e => e.SosyalKulüpId).HasColumnName("SosyalKulüpID");
            entity.Property(e => e.ÖğrenciId).HasColumnName("ÖğrenciID");

            entity.HasOne(d => d.SosyalKulüp).WithMany()
                .HasForeignKey(d => d.SosyalKulüpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ogrencile__Sosya__44FF419A");

            entity.HasOne(d => d.Öğrenci).WithMany()
                .HasForeignKey(d => d.ÖğrenciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ogrencile__Öğren__440B1D61");
        });

        modelBuilder.Entity<SosyalKulupler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SosyalKu__3214EC27E744B4E5");

            entity.ToTable("SosyalKulupler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Açıklama).HasMaxLength(500);
            entity.Property(e => e.KuruluşTarihi).HasColumnType("date");
            entity.Property(e => e.İsmi).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
