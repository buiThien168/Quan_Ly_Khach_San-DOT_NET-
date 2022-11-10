namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoadon")]
    public partial class Hoadon
    {
        [Key]
        [StringLength(15)]
        public string id_hoadon { get; set; }

        [StringLength(15)]
        public string MaPhong { get; set; }

        [StringLength(15)]
        public string Makh { get; set; }

        [StringLength(15)]
        public string Manv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaydatphong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaynhanphong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytraphong { get; set; }

        public int? soluongnguoi { get; set; }

        public float? phiphong { get; set; }

        public float? phiphuthu { get; set; }

        public float? thanhtien { get; set; }

        [StringLength(50)]
        public string trangthai { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
