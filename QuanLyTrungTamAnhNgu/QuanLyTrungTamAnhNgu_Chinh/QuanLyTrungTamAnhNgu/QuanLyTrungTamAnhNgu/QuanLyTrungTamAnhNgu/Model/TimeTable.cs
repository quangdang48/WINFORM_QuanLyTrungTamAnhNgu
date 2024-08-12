namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeTable")]
    public partial class TimeTable
    {
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeTable()
        {
            Shifts = new HashSet<Shift>();
        }

        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLichHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHoc { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLopHoc { get; set; }

        public virtual Class Class { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
