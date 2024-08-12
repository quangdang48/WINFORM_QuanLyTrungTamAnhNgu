using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            Property(e => e.MaLopHoc)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.MaKhoaHoc)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            HasMany(e => e.Attendances)
                .WithOptional(e => e.Class)
                .WillCascadeOnDelete();

            HasMany(e => e.ExamScheduleDetails)
                .WithOptional(e => e.Class)
                .WillCascadeOnDelete();

            HasMany(e => e.Registers)
                .WithOptional(e => e.Class)
                .WillCascadeOnDelete();

            HasMany(e => e.TimeTables)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete();
        }
    }
}
