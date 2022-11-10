namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khachhang()
        {
            Hoadons = new HashSet<Hoadon>();
            Phuthus = new HashSet<Phuthu>();
        }

        [Key]
        [StringLength(15)]
        public string MaKh { get; set; }

        [StringLength(50)]
        public string Tenkh { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phuthu> Phuthus { get; set; }
    }
}
