namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBienLai { get; set; }

        public int? MaDangKy { get; set; }

        public int? MaNhanVien { get; set; }

        public decimal? GiaTien { get; set; }

        public bool? TrangThaiThanhToan { get; set; }

        public virtual Register Register { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
