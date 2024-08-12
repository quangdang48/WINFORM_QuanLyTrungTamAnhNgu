namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamScheduleDetail")]
    public partial class ExamScheduleDetail
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChiTietLichThi { get; set; }

        public int? MaLichThi { get; set; }

        [StringLength(20)]
        public string MaLopHoc { get; set; }

        public virtual Class Class { get; set; }

        public virtual ExamSchedule ExamSchedule { get; set; }
    }
}
