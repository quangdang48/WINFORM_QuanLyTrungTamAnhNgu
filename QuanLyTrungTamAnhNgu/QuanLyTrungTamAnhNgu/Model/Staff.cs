namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
     //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Receipts = new HashSet<Receipt>();
            StatisticsTables = new HashSet<StatisticsTable>();
        }

        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanVien { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(12)]
        public string SoCCCD { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(50)]
        public string TenLot { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public decimal? Luong { get; set; }

     //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }

      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatisticsTable> StatisticsTables { get; set; }
    }
}
