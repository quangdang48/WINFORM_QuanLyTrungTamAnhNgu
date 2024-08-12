namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSoDiemDanh { get; set; }

        [StringLength(20)]
        public string MaLopHoc { get; set; }

        public int? MaHocVien { get; set; }

        public bool? Trangthai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDiemDanh { get; set; }

        public virtual Student Student { get; set; }

        public virtual Class Class { get; set; }
    }
}
