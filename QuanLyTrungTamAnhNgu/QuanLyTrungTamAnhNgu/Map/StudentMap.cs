using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            Property(e => e.SoDienThoai)
                .IsUnicode(false);

            Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            HasMany(e => e.Registers)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Attendances)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete();


        }
    }
}
