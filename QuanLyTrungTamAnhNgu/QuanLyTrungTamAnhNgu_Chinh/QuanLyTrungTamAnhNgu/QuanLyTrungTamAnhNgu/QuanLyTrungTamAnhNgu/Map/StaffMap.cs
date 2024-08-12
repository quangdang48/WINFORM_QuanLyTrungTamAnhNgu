using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class StaffMap : EntityTypeConfiguration<Staff>
    {
        public StaffMap()
        {
            Property(e => e.SoDienThoai)
                .IsUnicode(false);

            Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.Luong)
                .HasPrecision(20, 3);
        }
    }
}
