using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            HasIndex(s => s.TenDangNhap)
                .IsUnique();
                
        }
    }
}
