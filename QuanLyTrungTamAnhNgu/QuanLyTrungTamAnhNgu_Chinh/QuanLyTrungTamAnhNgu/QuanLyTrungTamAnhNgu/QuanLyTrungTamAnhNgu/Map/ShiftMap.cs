using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class ShiftMap : EntityTypeConfiguration<Shift>
    {
        public ShiftMap()
        {
            Property(e => e.GioBatDau)
                .HasPrecision(0);

            Property(e => e.GioKetThuc)
                .HasPrecision(0);

            HasMany(e => e.TimeTables)
                .WithMany(e => e.Shifts)
                .Map(m => m.ToTable("ShiftDetail")
                .MapLeftKey("MaCaHoc")
                .MapRightKey("MaLichHoc"));
        }
    }
}
