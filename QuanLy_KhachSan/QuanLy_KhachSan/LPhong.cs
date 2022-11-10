namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LPhong")]
    public partial class LPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(50)]
        public string loaiphong { get; set; }

        [StringLength(50)]
        public string mota { get; set; }

        public float? giaphong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
