using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class ExamScheduleDetailMap : EntityTypeConfiguration<ExamScheduleDetail>
    {
        public ExamScheduleDetailMap()
        {
            Property(e => e.MaLopHoc)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
