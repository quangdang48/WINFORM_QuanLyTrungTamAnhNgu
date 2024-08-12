using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    class MarkMap : EntityTypeConfiguration<Mark>
    {
        public MarkMap()
        {
            Property(e => e.DiemThi)
                .HasPrecision(8, 2);
        }
    }
}
