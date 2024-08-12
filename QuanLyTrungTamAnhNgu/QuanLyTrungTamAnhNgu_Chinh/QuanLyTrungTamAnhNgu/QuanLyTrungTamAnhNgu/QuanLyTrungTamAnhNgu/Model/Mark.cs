namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mark")]
    public partial class Mark
    {      
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLichThi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocVien { get; set; }

        public decimal? DiemThi { get; set; }

        [StringLength(20)]
        public string HocLuc { get; set; }

        public virtual ExamSchedule ExamSchedule { get; set; }

        public virtual Student Student { get; set; }
        
       
    }
}
