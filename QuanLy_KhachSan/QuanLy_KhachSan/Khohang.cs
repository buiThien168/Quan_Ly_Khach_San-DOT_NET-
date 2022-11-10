namespace QuanLy_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khohang")]
    public partial class Khohang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khohang()
        {
            Phuthus = new HashSet<Phuthu>();
        }

        [Key]
        [StringLength(15)]
        public string Maitem { get; set; }

        [StringLength(500)]
        public string TenItem { get; set; }

        public float? gianhap { get; set; }

        public int? soluong { get; set; }

        public float? giaban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phuthu> Phuthus { get; set; }
    }
}
