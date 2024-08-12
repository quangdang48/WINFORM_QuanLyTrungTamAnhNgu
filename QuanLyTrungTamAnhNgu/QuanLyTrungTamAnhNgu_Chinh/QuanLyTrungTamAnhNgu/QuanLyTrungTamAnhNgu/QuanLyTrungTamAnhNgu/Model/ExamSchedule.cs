namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamSchedule")]
    public partial class ExamSchedule
    {
      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamSchedule()
        {
            ExamScheduleDetails = new HashSet<ExamScheduleDetail>();
            Marks = new HashSet<Mark>();
        }

        [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLichThi { get; set; }

        [StringLength(50)]
        public string TenDotThi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiDiemThi { get; set; }

      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamScheduleDetail> ExamScheduleDetails { get; set; }

        //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
