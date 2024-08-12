namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatisticsTable")]
    public partial class StatisticsTable
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThongKe { get; set; }

        public int? MaNhanVien { get; set; }

        public int? Nam { get; set; }

        public int? Quy { get; set; }

        public decimal? TongDoanhThu { get; set; }

        public int? SoKhoaMo { get; set; }

        public int? SoLopMo { get; set; }

        public int? SoHocVienDangKy { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
