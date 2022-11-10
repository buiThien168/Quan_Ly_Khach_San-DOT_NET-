namespace QuanLy_KhachSan
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database_9 : DbContext
    {
        public Database_9()
            : base("name=Database_9")
        {
        }

        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Khohang> Khohangs { get; set; }
        public virtual DbSet<LPhong> LPhongs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<NhapKho> NhapKhoes { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<Phuthu> Phuthus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangNhap>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
