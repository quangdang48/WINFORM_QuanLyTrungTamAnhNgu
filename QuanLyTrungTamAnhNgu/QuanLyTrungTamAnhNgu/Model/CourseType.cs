namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseType")]
    public partial class CourseType
    {
        //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseType()
        {
            Courses = new HashSet<Course>();
        }
        public CourseType(string maLoaiKhoaHoc, string tenLoaiKhoaHoc)
        {
            MaLoaiKhoaHoc = maLoaiKhoaHoc;
            TenLoaiKhoaHoc = tenLoaiKhoaHoc;
        }   

        [Key]
        [StringLength(10)]
        public string MaLoaiKhoaHoc { get; set; }

        [StringLength(50)]
        public string TenLoaiKhoaHoc { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
