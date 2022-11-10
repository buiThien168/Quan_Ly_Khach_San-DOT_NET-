namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [StringLength(15)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        [StringLength(50)]
        public string loaiphong { get; set; }

        [StringLength(1000)]
        public string Mota { get; set; }

        public int? songtoida { get; set; }

        [Required]
        [StringLength(50)]
        public string trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoadon> Hoadons { get; set; }

        public virtual LPhong LPhong { get; set; }
    }
}
