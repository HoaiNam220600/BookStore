using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Admin.Models
{
    public partial class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChuDe> ChuDes { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<QuanLy> QuanLies { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }
        public virtual DbSet<ThamGium> ThamGia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-CIOFBUC4\\SQLEXPRESS;user Id=sa;password=123;database=BookStore");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => new { e.MaDonHang, e.MaSach });

                entity.ToTable("ChiTietDonHang");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_DonHang");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDonHang_Sach");
            });

            modelBuilder.Entity<ChuDe>(entity =>
            {
                entity.HasKey(e => e.MaChuDe);

                entity.ToTable("ChuDe");

                entity.Property(e => e.TenChuDe).HasMaxLength(50);
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDonHang);

                entity.ToTable("DonHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_DonHang_KhachHang");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChiKh)
                    .HasMaxLength(200)
                    .HasColumnName("diaChiKH");

                entity.Property(e => e.DienThoaiKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dienThoaiKH");

                entity.Property(e => e.EmailKh)
                    .HasMaxLength(100)
                    .HasColumnName("emailKH");

                entity.Property(e => e.GioiTinhKh)
                    .HasMaxLength(3)
                    .HasColumnName("gioiTinhKH");

                entity.Property(e => e.HoTenKh)
                    .HasMaxLength(50)
                    .HasColumnName("hoTenKH");

                entity.Property(e => e.MatKhauKh)
                    .HasMaxLength(50)
                    .HasColumnName("matKhauKH");

                entity.Property(e => e.NgaySinhKh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaySinhKH");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taiKhoan");
            });

            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.HasKey(e => e.MaNxb);

                entity.ToTable("NhaXuatBan");

                entity.Property(e => e.MaNxb).HasColumnName("MaNXB");

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenNxb)
                    .HasMaxLength(50)
                    .HasColumnName("TenNXB");
            });

            modelBuilder.Entity<QuanLy>(entity =>
            {
                entity.HasKey(e => e.MaQl);

                entity.ToTable("QuanLy");

                entity.Property(e => e.MaQl).HasColumnName("MaQL");

                entity.Property(e => e.DiaChiQl)
                    .HasMaxLength(200)
                    .HasColumnName("diaChiQL");

                entity.Property(e => e.DienThoaiQl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dienThoaiQL");

                entity.Property(e => e.EmailQl)
                    .HasMaxLength(100)
                    .HasColumnName("emailQL");

                entity.Property(e => e.GioiTinhQl)
                    .HasMaxLength(3)
                    .HasColumnName("gioiTinhQL");

                entity.Property(e => e.HoTenQl)
                    .HasMaxLength(50)
                    .HasColumnName("hoTenQL");

                entity.Property(e => e.MatKhauQl)
                    .HasMaxLength(50)
                    .HasColumnName("matKhauQL");

                entity.Property(e => e.TaiKhoanQl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taiKhoanQL");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach);

                entity.ToTable("Sach");

                entity.Property(e => e.AnhBia).HasMaxLength(50);

                entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaNxb).HasColumnName("MaNXB");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.TenSach).HasMaxLength(50);

                entity.HasOne(d => d.MaChuDeNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaChuDe)
                    .HasConstraintName("FK_Sach_ChuDe");

                entity.HasOne(d => d.MaNxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaNxb)
                    .HasConstraintName("FK_Sach_NhaXuatBan");
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.MaTacGia);

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenTacGia).HasMaxLength(50);
            });

            modelBuilder.Entity<ThamGium>(entity =>
            {
                entity.HasKey(e => new { e.MaSach, e.MaTacGia });

                entity.Property(e => e.VaiTro).HasMaxLength(50);

                entity.Property(e => e.ViTri).HasMaxLength(50);

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.ThamGia)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThamGia_Sach");

                entity.HasOne(d => d.MaTacGiaNavigation)
                    .WithMany(p => p.ThamGia)
                    .HasForeignKey(d => d.MaTacGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThamGia_TacGia");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
