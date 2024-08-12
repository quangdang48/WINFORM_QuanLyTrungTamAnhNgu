using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class CourseTypeMap : EntityTypeConfiguration<CourseType>
    {
        public CourseTypeMap()
        {

            HasMany(e => e.Courses)
                .WithOptional(e => e.CourseType)
                .WillCascadeOnDelete();
        }
    }
}
