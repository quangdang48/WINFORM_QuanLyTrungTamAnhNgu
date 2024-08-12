using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            Property(e => e.MaKhoaHoc)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.GiaTien)
                .HasPrecision(20, 2);

            HasMany(e => e.Classes)
                .WithOptional(e => e.Course)
                .WillCascadeOnDelete();
        }
    }
}
