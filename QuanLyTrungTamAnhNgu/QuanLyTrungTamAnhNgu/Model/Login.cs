﻿
namespace QuanLyTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Login")]
    public partial class Login
    {
        [Key]
        public int MaLogin { get; set; }

        public int MaUser { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Type { get; set; }
    }
}
