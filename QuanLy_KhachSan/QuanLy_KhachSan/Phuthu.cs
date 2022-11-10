namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phuthu")]
    public partial class Phuthu
    {
        [Key]
        [StringLength(15)]
        public string MaPhu { get; set; }

        [StringLength(15)]
        public string MaKh { get; set; }

        [StringLength(15)]
        public string Maitem { get; set; }

        [StringLength(500)]
        public string tensp { get; set; }

        public int? soluong { get; set; }

        public float? gia { get; set; }

        public int? trangthai { get; set; }

        public float? thanhtien { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Khohang Khohang { get; set; }
    }
}
