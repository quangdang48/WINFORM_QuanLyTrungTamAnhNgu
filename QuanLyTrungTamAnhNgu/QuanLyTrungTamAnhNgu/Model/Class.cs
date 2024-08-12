namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
  //      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Attendances = new HashSet<Attendance>();
            ExamScheduleDetails = new HashSet<ExamScheduleDetail>();
            Registers = new HashSet<Register>();
            TimeTables = new HashSet<TimeTable>();
        }
        public Class(string MaKhoaHoc, string TenLop, int MaGiangVien, string MaPhong, DateTime NgayBatDau)
        {
            this.MaKhoaHoc = MaKhoaHoc;
            this.TenLop = TenLop;
            this.MaGiangVien = MaGiangVien;
            this.MaPhong = MaPhong;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = null;
        }

        [Key]
        [StringLength(20)]
        public string MaLopHoc { get; set; }

        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }

        public int? MaGiangVien { get; set; }

        [StringLength(5)]
        public string MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        //      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual Course Course { get; set; }

        public virtual Room Room { get; set; }

   //     [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamScheduleDetail> ExamScheduleDetails { get; set; }

   //     [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers { get; set; }

    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
