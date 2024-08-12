namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lecturer")]
    public partial class Lecturer
    {
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lecturer()
        {
            Classes = new HashSet<Class>();
        }

        [Key]
       //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGiangVien { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(50)]
        public string TenLot { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Required]
        [StringLength(12)]
        public string SoCCCD { get; set; }

        [Required]
        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string TrinhDo { get; set; }

        public decimal? Luong { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
