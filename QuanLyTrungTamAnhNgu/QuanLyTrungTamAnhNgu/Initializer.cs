using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            ThemTrigger(context);
            ThemProc(context);
            ThemDuLieu(context); 
        }
        public void ThemTrigger(Context context)
        {
            //TRIGGER
            context.Database.ExecuteSqlCommand(@"CREATE TRIGGER checkSLBuoiHoc 
                ON [dbo].[Course] AFTER INSERT, UPDATE AS 
                BEGIN DECLARE @SoBuoi INT SELECT @SoBuoi = inserted.SoBuoiHoc 
                FROM inserted IF(@SoBuoi <= 0) 
                BEGIN RAISERROR ('So buoi phai lon hon 0', 16, 10) ROLLBACK TRAN END END");
           /* context.Database.ExecuteSqlCommand(
                @"create trigger TaoNgayKetThuc on Course 
                after insert,update
                as 
                begin
	                declare @SoTuanHoc int
	                declare @SoBuoiHoc int 
	                declare @NgayBatDauHoc date
	                declare @Makhoa char(10)
	                select @SoBuoiHoc = i.SoBuoiHoc, @NgayBatDauHoc = i.NgayBatDau, @Makhoa = i.MaKhoaHoc
	                from inserted i
	                set @SoTuanHoc = @SoBuoiHoc / 3 
	
	                Update Course
	                set NgayKetThuc = DATEADD(WEEK, @SoTuanHoc,@NgayBatDauHoc)
	                where MaKhoaHoc = @Makhoa
                end"
                );*/
        }
        public void ThemDuLieu(Context context)
        {
            //Tạo loại khóa học 
            context.CourseTypes.AddRange(new List<CourseType>
            {
                new CourseType{ MaLoaiKhoaHoc = "AVGT", TenLoaiKhoaHoc = "Anh Văn giao tiếp" },
                new CourseType{ MaLoaiKhoaHoc = "T4KN", TenLoaiKhoaHoc = "Toeic 4 kỹ năng" },
                new CourseType{ MaLoaiKhoaHoc = "TND", TenLoaiKhoaHoc = "Toeic nghe đọc" }
            });
            // tao ca hoc
            context.Shifts.AddRange(new List<Shift>
            {
                new Shift{ GioBatDau = new TimeSpan(18, 0, 0), GioKetThuc = new TimeSpan(18, 50, 0)},
                 new Shift{ GioBatDau = new TimeSpan(19, 0, 0), GioKetThuc = new TimeSpan(19, 50, 0)},
                  new Shift{ GioBatDau = new TimeSpan(20, 0, 0), GioKetThuc = new TimeSpan(20, 50, 0)},
                   new Shift{ GioBatDau = new TimeSpan(21, 0, 0), GioKetThuc = new TimeSpan(21, 50, 0)},
            });
            context.SaveChanges();

            // tao Phong hoc
            context.Rooms.AddRange(new List<Room>
            {
                new Room{ MaPhong = "P1"},
                new Room{ MaPhong = "P2"},
                new Room{ MaPhong = "P3"},
                new Room{ MaPhong = "P4"},
                new Room{ MaPhong = "P5"},
                new Room{ MaPhong = "P6"},
                new Room{ MaPhong = "P7"},
                new Room{ MaPhong = "P8"}
            });
            context.SaveChanges();

            // Them giang vien
            context.Lecturers.AddRange(new List<Lecturer>
            {
                new Lecturer{ Ho = "Nguyễn", TenLot = "Lan", Ten = "Anh", SoCCCD = "05137688704",
                 SoDienThoai = "0267456543", TrinhDo = "985 Toeic", Luong = 15000000},
                new Lecturer{ Ho = "Đào", TenLot = "Phương", Ten = "Anh", SoCCCD = "05137833937",
                 SoDienThoai = "0356728649", TrinhDo = "985 Toeic", Luong = 15000000},
                new Lecturer{ Ho = "Lê", TenLot = "Trung", Ten = "Quân", SoCCCD =  "05127386747",
                 SoDienThoai = "0647839027", TrinhDo = "886 Toeic", Luong = 12000000},
                new Lecturer{ Ho = "Trần", TenLot = "Mỹ", Ten = "Dung", SoCCCD =   "05137688704",
                 SoDienThoai = "0267456543", TrinhDo = "8.5 Ielts", Luong = 19000000},
                new Lecturer{ Ho = "Nguyễn", TenLot = "Thị Phương", Ten = "Nhung", SoCCCD = "05137688895",
                 SoDienThoai = "0284955872", TrinhDo = "8.5 Ielts", Luong = 18500000},
                new Lecturer{ Ho = "Bùi", TenLot = "Minh", Ten = "Tân", SoCCCD = "05186388346",
                 SoDienThoai = "0348572927", TrinhDo = "900 Toeic", Luong = 16000000},
                new Lecturer{ Ho = "Trần", TenLot = "Thế", Ten = "Nam", SoCCCD = "05972688453",
                 SoDienThoai = "0264783648", TrinhDo = "8 Ielts", Luong = 17000000},
            });
            context.SaveChanges();

            // them nhan vien
            context.Staffs.AddRange(new List<Staff>
            {
                new Staff{ Ho = "Trần", TenLot = "Thị", Ten = "Tiền", SoCCCD =      "05137688704",
                 SoDienThoai = "0267456543",  Luong = 7000000},
                new Staff{ Ho = "Nguyễn", TenLot = "Phương", Ten = "Thảo", SoCCCD = "05135748975",
                 SoDienThoai = "0397656556",  Luong = 7000000},
                new Staff{ Ho = "Bùi", TenLot = "Thị Xuân", Ten = "Trang", SoCCCD = "05784578345",
                 SoDienThoai = "0345632863",  Luong = 10000000},
                new Staff{ Ho = "Trần", TenLot = "Nhất", Ten = "Chung", SoCCCD = "05137345238",
                 SoDienThoai = "0637983624",  Luong = 15000000},
            });
            context.SaveChanges();

            context.Logins.AddRange(new List<Login>
            {
                new Login { MaUser = 1, TenDangNhap = "TranTien", Password = "123456",  Type = "Staff"},
                new Login {  MaUser = 2, TenDangNhap = "NguyenPhuong", Password = "123456",  Type = "Staff"},
                new Login {  MaUser = 3, TenDangNhap = "BuiTrang", Password = "123456",  Type = "Staff"},
                new Login {  MaUser = 4, TenDangNhap = "TranChung", Password = "123456",  Type = "Staff"},
            }) ;
            context.SaveChanges();

            context.Courses.AddRange(new List<Course>
            {
                new Course { MaLoaiKhoaHoc = "AVGT",soThuTuKhoa = 1,MaKhoaHoc = "AVGT_01", TenKhoaHoc = "Khóa Anh Văn giao tiếp 1",SoBuoiHoc = 30,GiaTien = 5200000,NgayBatDau = new DateTime(2024,5,7),NgayKetThuc = null,TrangThai = true},
                new Course { MaLoaiKhoaHoc = "TND",soThuTuKhoa = 1,MaKhoaHoc = "TND_01", TenKhoaHoc = "Khóa Toeic nghe đọc 1",SoBuoiHoc = 30,GiaTien = 3600000,NgayBatDau = new DateTime(2024,5,7),NgayKetThuc = null,TrangThai = true},
                new Course { MaLoaiKhoaHoc = "T4KN",soThuTuKhoa = 1,MaKhoaHoc = "T4KN_01", TenKhoaHoc = "Khóa Toeic 4 kỹ năng 1",SoBuoiHoc = 30,GiaTien = 6800000,NgayBatDau = new DateTime(2024,5,7),NgayKetThuc = null, TrangThai = true}
            });
            context.SaveChanges();



/*            context.Database.ExecuteSqlCommand(@"new
            exec ThemKhoaHoc 'T4KN_01',N'Toeic 4 kỹ năng',30,3000000,'2024-5-7'
    exec ThemKhoaHoc 'TND_01',N'Toeic nghe đọc ',30,3000000,'2024-5-7'
    exec ThemKhoaHoc 'AVGT_01',N'Anh Văn giao tiếp',30,4000000,'2024-5-7'");
*/
/*            context.Database.ExecuteSqlCommand(@"
        exec ThemLopHoc 'AVGT_01_01','AVGT_01',N'Lớp AVGT 1 khóa 1', 4,NULL
        exec ThemLopHoc 'AVGT_01_02','AVGT_01',N'Lớp AVGT 2 khóa 1', 5,NULL
        exec ThemLopHoc 'T4KN_01_01','T4KN_01',N' Lớp Toeic 4 kỹ năng 1 khóa 1',1,NULL
        exec ThemLopHoc 'T4KN_01_02','T4KN_01',N' Lớp Toeic 4 kỹ năng 2 khóa 1',2,NULL
        exec ThemLopHoc 'TND_01_01','TND_01',N'Lớp Toeic Nghe đọc 1 khóa 1', 6,NULL
        exec ThemLopHoc 'TND_01_02','TND_01',N'Lớp Toeic Nghe đọc 2 khóa 1', 7,NULL");*/

/*            context.Database.ExecuteSqlCommand(@"
            exec ThemLichThi N'Thi quá trình Anh Văn giao tiếp','2024-05-26'
            exec ThemLichThi N'Thi quá trình Toeic 4 kỹ năng','2024-05-26'
            exec ThemLichThi N'Thi quá trình Toeic nghe đọc','2024-05-26'");

            context.Database.ExecuteSqlCommand(@"
            exec ThemChiTietLichThi 1,'AVGT_01_01'
            exec ThemChiTietLichThi 1,'AVGT_01_02'
            exec ThemChiTietLichThi 2,'T4KN_01_01'
            exec ThemChiTietLichThi 2,'T4KN_01_01'
            exec ThemChiTietLichThi 3,'TND_01_01'
            exec ThemChiTietLichThi 3,'TND_01_01'");*/


            // them hoc vien 
           /* context.Database.ExecuteSqlCommand(@"EXEC spThemHocVien N'Cao', N'Thị Xuân', N'Hương', '0354488239', '051304004739', 
			'T4KN_01_01', 1, '2024-05-04', 6000000, 1");
            context.Logins.Add(new Login { MaUser = 1, TenDangNhap = "XuanHuong", Password = "123456", Type = "Student" });
*/

        }
        public void ThemProc(Context context)
        {
            // tao du lieu lieu khoa hoc

            // code sql
            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE spThemHocVien @Ho nvarchar(50), @TenLot nvarchar(50), @Ten nvarchar(50),
	                    @SoDienThoai varchar(10), @SoCCCD char(12), @MaLopHoc char(20), @MaNhanVien int,
	                    @ThoiDiemDangKy DATE, @GiaTien decimal(20,3), @TrangThaiThanhToan bit AS
                    BEGIN
	                    BEGIN TRANSACTION
	                    BEGIN TRY
		                    -- chen du lieu hoc vien
		                    INSERT [dbo].[Student] ([Ho],[TenLot],[Ten], [SoDienThoai],[SoCCCD])
			                    VALUES (@Ho, @TenLot, @Ten, @SoDienThoai, @SoCCCD)
		                    -- chen du lieu vao danh sach dang ky lop hoc
		                    DECLARE @MaHocVien int
			                    SET @MaHocVien = SCOPE_IDENTITY()
		                    INSERT [dbo].[Register] ([MaHocVien], [MaLopHoc], [ThoiDiemDangKy])
			                    VALUES (@MaHocVien, @MaLopHoc, @ThoiDiemDangKy)
		                    -- tao bien lai hoc phi
		                    DECLARE @MaDangKy int
			                    SET @MaDangKy = SCOPE_IDENTITY()
		                    INSERT [dbo].[Receipt] ([MaDangKy], [MaNhanVien], [GiaTien], [TrangThaiThanhToan])
			                    VALUES(@MaDangKy, @MaNhanVien, @GiaTien, @TrangThaiThanhToan)
		                    -- tao danh sach diem danh
		                    INSERT INTO [dbo].[Attendance] ([MaLopHoc], [MaHocVien], [Trangthai], [NgayDiemDanh])
		                    SELECT @MaLopHoc, @MaHocVien, 1, TimeTable.NgayHoc 
		                    FROM [dbo].[TimeTable]	
		                    WHERE (TimeTable.MaLopHoc = @MaLopHoc)

	                    COMMIT TRANSACTION;
	                    END TRY
	                    BEGIN CATCH
		                    -- Nếu có lỗi xảy ra, hủy bỏ giao dịch
		                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
		                     -- Ném ra lỗi
		                     RAISERROR (@ErrorMessage, 16, 10);

		                    ROLLBACK TRANSACTION
	                    END CATCH
                    END");

            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE [dbo].[spXoaHocVien] @MaHocVien int AS
BEGIN
	UPDATE Register
        SET MaHocVien = NULL
        WHERE MaHocVien = @MaHocVien;
        -- Xóa học viên từ bảng Student
        DELETE FROM [dbo].[Student]
        WHERE MaHocVien = @MaHocVien;
END");
            /*Room--OK*/
            //ThemPhongHoc 
            context.Database.ExecuteSqlCommand(
                @"create proc ThemPhongHoc @MaPhong char(5) as
                begin
                    insert into Room
                    values(@MaPhong)
                end"
                );
            //XoaPhongHoc
            context.Database.ExecuteSqlCommand(
                @"create proc XoaPhongHoc @MaPhong char(5) as
                begin
                    delete from Room 
                    where MaPhong = @MaPhong
                end"
                );
            //*Shift OK*//*
            //ThemCaHoc
            context.Database.ExecuteSqlCommand(@"create proc ThemCaHoc 
            @GioBatDau time, @GioKetThuc time
            as
            begin
                insert into Shift
                values(@GioBatDau, @GioKetThuc)
            end"
            );
            //SuaCaHoc
            context.Database.ExecuteSqlCommand(
            @"create proc SuaCaHoc @MaCaHoc int,@GioBatDau time, @GioKetThuc time
              as
              begin
                 update Shift
                 set GioBatDau = @GioBatDau, GioKetThuc = @GioKetThuc
                 where MaCaHoc = @MaCaHoc
              end"
            );

            //XoaCaHoc 
            context.Database.ExecuteSqlCommand(
                @"create proc XoaCaHoc @MaCaHoc int as
                begin
                    delete from Shift 
                    where MaCaHoc = @MaCaHoc
                end"
                );

            //*Course OK*//*
            //ThemKhoaHoc
           /* context.Database.ExecuteSqlCommand(@"create proc ThemKhoaHoc
            @Makhoahoc char(10), @TenKhoaHoc nvarchar(50), @SoBuoiHoc int, @GiaTien decimal(20, 2), @NgayBatDau date
            as
            begin
                insert into Course(MaKhoaHoc,TenKhoaHoc,SoBuoiHoc,GiaTien,NgayBatDau)
                 values(@Makhoahoc, @TenKhoaHoc, @SoBuoiHoc, @GiaTien, @NgayBatDau)
            end");*/
            //SuaKhoaHoc 
            context.Database.ExecuteSqlCommand(@"create proc SuaKhoaHoc
            @Makhoahoc char(10), @TenKhoaHoc nvarchar(50), @SoBuoiHoc int, @GiaTien decimal(20, 2), @NgayBatDau date, @NgayKetThuc date
            as
            begin
                 Update  Course
                 set 
                 MaKhoaHoc = @Makhoahoc, 
                 TenKhoaHoc = @Tenkhoahoc, 
                 SoBuoiHoc = @SoBuoiHoc, 
                 GiaTien = @GiaTien, 
                 NgayBatDau = @NgayBatDau, 
                 NgayKetThuc = @NgayKetThuc
                 where MaKhoaHoc = @Makhoahoc
            end");
            //XoaKhoaHoc
            context.Database.ExecuteSqlCommand(@"create proc XoaKhoaHoc
            @Makhoahoc char(10)
            as
            begin
                delete from Course 
                where MaKhoaHoc = @Makhoahoc
            end");


            //*TimeTable*//*
            //ThemLichHoc
            context.Database.ExecuteSqlCommand(@"create proc ThemLichHoc
            @NgayHoc date, @MaLopHoc char(20)
            as
            begin
                insert into TimeTable
                values(@NgayHoc, @MaLopHoc)
            end");
            //SuaLichHoc
            context.Database.ExecuteSqlCommand(@"create proc SuaLichHoc
            @MaLichHoc int, @NgayHoc date, @MaLopHoc char(20)
            as
            begin
                update TimeTable
                set NgayHoc = @NgayHoc, MaLopHoc = @MaLopHoc 
                where MaLichHoc = @MaLichHoc
            end");
            //XoaLichHoc
            context.Database.ExecuteSqlCommand(@"create proc XoaLichHoc
            @MaLichHoc int
            as
            begin
                delete from TimeTable
                where MaLichHoc = @MaLichHoc
            end");
            //*ExamScheduleDetail*//*
            //ThemChiTietLichThi
            context.Database.ExecuteSqlCommand(@"create proc ThemChiTietLichThi
            @MaLichThi int, @MaLopHoc char(20)
            as
            begin
                insert into ExamScheduleDetail
                values(@MaLichThi, @MaLopHoc)
            end");
            //SuaChiTietLichThi
            context.Database.ExecuteSqlCommand(@"create proc SuaChiTietLichThi
            @MaChiTietLichThi int, @MaLichThi int, @MaLopHoc char(20)
            as
            begin
                update ExamScheduleDetail
                set 
                MaLichThi = @MaLichThi,
                MaLopHoc = @MaLopHoc
                where MaChiTietLichThi = @MaChiTietLichThi
            end");
            //XoaChiTietLichThi
            context.Database.ExecuteSqlCommand(@"create proc XoaChiTietLichThi
@MaChiTietLichThi int, @MaLichThi int, @MaLopHoc char(20), @TenDotThi nvarchar(50), @ThoiDiemThi date
            as
            begin
               delete from ExamScheduleDetail
                where MaChiTietLichThi = @MaChiTietLichThi
            end");
            //*ExamSchedule*//*
            //ThemLichThi
            context.Database.ExecuteSqlCommand(@"create proc ThemLichThi
            @TenDotThi nvarchar(50), @ThoiDiemThi date
            as
            begin      
                insert into ExamSchedule
                values(@TenDotThi, @ThoiDiemThi)
            end");
            //SuaLichThi
            context.Database.ExecuteSqlCommand(@"create proc SuaLichThi
            @MaLichThi int, @TenDotThi nvarchar(50), @ThoiDiemThi date
            as
            begin      
                Update ExamSchedule
                set 
                TenDotThi = @TenDotThi, 
                ThoiDiemThi = @ThoiDiemThi
                where MaLichThi = @MaLichThi
            end");
            //XoaLichThi
            context.Database.ExecuteSqlCommand(@"create proc XoaLichThi
            @MaLichThi int
            as
            begin      
                delete from ExamSchedule
                where MaLichThi = @MaLichThi
            end");
            //*Class*//*
            //ThemLopHoc
            context.Database.ExecuteSqlCommand(@"create proc ThemLopHoc
            @MaLopHoc char(20), @MaKhoaHoc char(10), @TenLop nvarchar(50), @MaGiangVien int, @MaPhong char(5)
            as
            begin
                insert into Class(MaLopHoc,MaKhoaHoc,TenLop,MaGiangVien,MaPhong)
                values(@MaLopHoc, @MaKhoaHoc, @TenLop, @MaGiangVien, @MaPhong)
            end");
            //SuaLopHoc
            context.Database.ExecuteSqlCommand(@"create proc SuaLopHoc
            @MaLopHoc char(20), @MaKhoaHoc char(10), @TenLop nvarchar(50), @MaGiangVien int, @MaPhong char(5)
            as
            begin
                Update Class
                set 
                MaKhoaHoc = @MaKhoaHoc, 
                TenLop = @TenLop,
                MaGiangVien = @MaGiangVien, 
                MaPhong = @MaPhong
                where MaLopHoc = @MaLopHoc
            end");
            //XoaLopHoc 
            context.Database.ExecuteSqlCommand(@"create proc XoaLopHoc
            @MaLopHoc char(20), @MaKhoaHoc char(10), @TenLop nvarchar(50), @MaGiangVien int, @MaPhong char(5)
            as
            begin
                delete from  Class
                where MaLopHoc = @MaLopHoc
            end");


            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE spDangKyThiThu @MaLichThi int, @MaHocVien int AS
BEGIN
	INSERT [dbo].[Mark] ([MaLichThi], [MaHocVien], [DiemThi])
		VALUES (@MaLichThi, @MaHocVien, 0.0)
END");

            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE spCapNhatDiemThi @MaLichThi int, @MaHocVien int,
	@Diem decimal(8,2), @HocLuc nvarchar(20) AS
BEGIN
	UPDATE [dbo].[Mark]
	SET DiemThi = @Diem, HocLuc = @HocLuc
	WHERE MaHocVien = @MaHocVien and MaLichThi = @MaLichThi
END");

            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE spTaoThongKe @MaNhanVien int,
	@Nam int, @Quy int, @TongDoanhThu decimal(20,3), @SoKhoaMo int, @SoLopMo int, @SoHocVienDangKy int
AS
BEGIN
	Insert [dbo].[StatisticsTable]([MaNhanVien], [Nam], [Quy], 
	[TongDoanhThu], [SoKhoaMo], [SoLopMo], [SoHocVienDangKy])
	values(@MaNhanVien, @Nam, @Quy, @TongDoanhThu, @SoKhoaMo, @SoLopMo, @SoHocVienDangKy)
END");

            context.Database.ExecuteSqlCommand(
                @"CREATE PROCEDURE spCapNhatDiemDanh @MaLopHoc char(20), @MaHocVien int,
	@TrangThai bit, @NgayDiemDanh Date AS
BEGIN
	UPDATE [dbo].[Attendance]
	SET TrangThai = @TrangThai
	WHERE MaHocVien = @MaLopHoc and NgayDiemDanh = @NgayDiemDanh
		and MaLopHoc =  @MaLopHoc
END"
            );
        }
    }


}
