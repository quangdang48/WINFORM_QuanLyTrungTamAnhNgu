using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class StatisticsTableMap : EntityTypeConfiguration<StatisticsTable>
    {
        public StatisticsTableMap()
        {
            Property(e => e.TongDoanhThu)
                .HasPrecision(20, 3);
        }
    }
}
