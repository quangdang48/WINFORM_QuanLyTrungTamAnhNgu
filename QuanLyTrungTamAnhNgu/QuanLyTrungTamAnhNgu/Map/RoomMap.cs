using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class RoomMap : EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
