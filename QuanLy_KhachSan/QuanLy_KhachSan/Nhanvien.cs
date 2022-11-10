namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhanvien")]
    public partial class Nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [StringLength(15)]
        public string Manv { get; set; }

        [StringLength(50)]
        public string Tennv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(15)]
        public string sdt { get; set; }

        [StringLength(30)]
        public string Cmnd { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
