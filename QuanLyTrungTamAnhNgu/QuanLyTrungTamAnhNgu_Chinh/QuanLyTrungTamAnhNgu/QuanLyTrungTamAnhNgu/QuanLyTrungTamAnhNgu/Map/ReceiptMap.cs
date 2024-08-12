using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyTrungTamAnhNgu.Map
{
    public class ReceiptMap : EntityTypeConfiguration<Receipt>
    {
        public ReceiptMap()
        {
            Property(e => e.GiaTien)
                .HasPrecision(20, 3);

            HasOptional(e => e.Register)
                .WithMany(e => e.Receipts)
                .HasForeignKey(e => e.MaDangKy)
                .WillCascadeOnDelete(false);

            HasOptional(e => e.Staff)
                .WithMany(e => e.Receipts)
                .HasForeignKey(e => e.MaNhanVien)
                .WillCascadeOnDelete(false);

        }
    }
}
