namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangNhap")]
    public partial class DangNhap
    {
        [Key]
        [StringLength(50)]
        public string Taikhoan { get; set; }

        [StringLength(50)]
        public string Matkhau { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? phanquyen { get; set; }

        public int trangthai { get; set; }
    }
}
