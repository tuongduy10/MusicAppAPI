using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class MusicAppContext : DbContext
    {
        public MusicAppContext()
        {
        }

        public MusicAppContext(DbContextOptions<MusicAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baihat> Baihats { get; set; }
        public virtual DbSet<Casi> Casis { get; set; }
        public virtual DbSet<ChitietBaihat> ChitietBaihats { get; set; }
        public virtual DbSet<ChitietPlayList> ChitietPlayLists { get; set; }
        public virtual DbSet<ChitietTheloai> ChitietTheloais { get; set; }
        public virtual DbSet<PlayList> PlayLists { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Theloai> Theloais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MusicApp;User Id=sa; Password=123;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Baihat>(entity =>
            {
                entity.HasKey(e => e.IdBaihat)
                    .HasName("PK__Baihat__4A742C1A7848B092");

                entity.ToTable("Baihat");

                entity.Property(e => e.Anhbaihat)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lyrics).IsRequired();

                entity.Property(e => e.Tenbaihat)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Casi>(entity =>
            {
                entity.HasKey(e => e.IdCasi)
                    .HasName("PK__Casi__3B7B2B26B8C3B1A5");

                entity.ToTable("Casi");

                entity.Property(e => e.AnhCasi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nghedanh)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tencasi)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ChitietBaihat>(entity =>
            {
                entity.HasKey(e => new { e.IdCasi, e.IdBaihat });

                entity.ToTable("ChitietBaihat");

                entity.HasOne(d => d.IdBaihatNavigation)
                    .WithMany(p => p.ChitietBaihats)
                    .HasForeignKey(d => d.IdBaihat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietBa__IdBai__239E4DCF");

                entity.HasOne(d => d.IdCasiNavigation)
                    .WithMany(p => p.ChitietBaihats)
                    .HasForeignKey(d => d.IdCasi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietBa__IdCas__24927208");
            });

            modelBuilder.Entity<ChitietPlayList>(entity =>
            {
                entity.HasKey(e => new { e.IdPlayList, e.IdBaihat });

                entity.ToTable("ChitietPlayList");

                entity.HasOne(d => d.IdBaihatNavigation)
                    .WithMany(p => p.ChitietPlayLists)
                    .HasForeignKey(d => d.IdBaihat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietLi__IdBai__1ED998B2");

                entity.HasOne(d => d.IdPlayListNavigation)
                    .WithMany(p => p.ChitietPlayLists)
                    .HasForeignKey(d => d.IdPlayList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietLi__Idlis__1DE57479");
            });

            modelBuilder.Entity<ChitietTheloai>(entity =>
            {
                entity.HasKey(e => new { e.IdTheloai, e.IdBaihat });

                entity.ToTable("ChitietTheloai");

                entity.HasOne(d => d.IdBaihatNavigation)
                    .WithMany(p => p.ChitietTheloais)
                    .HasForeignKey(d => d.IdBaihat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietTh__IdBai__1B0907CE");

                entity.HasOne(d => d.IdTheloaiNavigation)
                    .WithMany(p => p.ChitietTheloais)
                    .HasForeignKey(d => d.IdTheloai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChitietTh__IdThe__1A14E395");
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.HasKey(e => e.IdPlayList)
                    .HasName("PK__PlayList__663CEF5EBB04A856");

                entity.ToTable("PlayList");

                entity.Property(e => e.Idtaikhoan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenPlayList)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdtaikhoanNavigation)
                    .WithMany(p => p.PlayLists)
                    .HasForeignKey(d => d.Idtaikhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayList_Taikhoan");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.IdTaikhoan)
                    .HasName("PK__Taikhoan__99B296A3B492EFDB");

                entity.ToTable("Taikhoan");

                entity.Property(e => e.IdTaikhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tennguoidung)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.HasKey(e => e.IdTheloai)
                    .HasName("PK__Theloai__9A190A17423B2CA9");

                entity.ToTable("Theloai");

                entity.Property(e => e.TenTheloai)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
