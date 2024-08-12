namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Register")]
    public partial class Register
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Register()
        {
            Receipts = new HashSet<Receipt>();
        }

        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDangKy { get; set; }

        public int? MaHocVien { get; set; }

        [StringLength(20)]
        public string MaLopHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiDiemDangKy { get; set; }

        public virtual Class Class { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }

        public virtual Student Student { get; set; }
    }
}
