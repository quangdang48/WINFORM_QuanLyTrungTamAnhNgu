using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class ExamScheduleMap : EntityTypeConfiguration<ExamSchedule>
    {
        public ExamScheduleMap()
        {
            HasMany(e => e.ExamScheduleDetails)
                .WithOptional(e => e.ExamSchedule)
                .WillCascadeOnDelete();
        }
    }
}
