using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class LectureMap : EntityTypeConfiguration<Lecturer>
    {
        public LectureMap()
        {
            Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.SoDienThoai)
                .IsUnicode(false);

            Property(e => e.Luong)
                .HasPrecision(20, 3);
        }
    }
}
