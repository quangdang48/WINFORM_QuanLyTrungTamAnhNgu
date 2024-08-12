using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class TimeTableMap : EntityTypeConfiguration<TimeTable>
    {
        public TimeTableMap()
        {
            Property(e => e.MaLopHoc)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
