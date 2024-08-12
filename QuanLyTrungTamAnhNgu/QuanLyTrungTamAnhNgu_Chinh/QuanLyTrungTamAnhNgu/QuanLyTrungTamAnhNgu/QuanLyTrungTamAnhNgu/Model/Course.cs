namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Classes = new HashSet<Class>();
        }
        public Course(string maKhoaHoc, string tenKhoaHoc, int soBuoiHoc, decimal giaTien, DateTime ngayBatDau)
        {
            this.MaKhoaHoc = maKhoaHoc;
            this.TenKhoaHoc = tenKhoaHoc;
            this.SoBuoiHoc = soBuoiHoc;
            this.GiaTien = giaTien;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = null;
        }

        [Key]
        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [StringLength(10)]
        public string MaLoaiKhoaHoc { get; set; }

        public int soThuTuKhoa { get; set; }

        [StringLength(50)]
        public string TenKhoaHoc { get; set; }

        public int? SoBuoiHoc { get; set; }

        public decimal? GiaTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }  

      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        [ForeignKey("MaLoaiKhoaHoc")]
        public virtual CourseType CourseType { get; set; }
    }
}
