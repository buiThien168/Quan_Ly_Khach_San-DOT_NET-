namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapKho")]
    public partial class NhapKho
    {
        [Key]
        [StringLength(15)]
        public string Id_hd { get; set; }

        [StringLength(500)]
        public string sanpham { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaynhap { get; set; }

        public float? Thanhtien { get; set; }
    }
}
