using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class RegisterMap : EntityTypeConfiguration<Register>
    {
        public RegisterMap()
        {
            Property(e => e.MaLopHoc)
                .IsFixedLength()
                .IsUnicode(false);

        }
    }
}
