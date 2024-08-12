using QuanLyTrungTamAnhNgu.Map;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTrungTamAnhNgu
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=QuanLyTTAnhNgu_02")
        {

        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<ExamSchedule> ExamSchedules { get; set; }
        public virtual DbSet<ExamScheduleDetail> ExamScheduleDetails { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StatisticsTable> StatisticsTables { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TimeTable> TimeTables { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceMap());
            modelBuilder.Configurations.Add(new ClassMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new ExamScheduleDetailMap());
            modelBuilder.Configurations.Add(new ExamScheduleMap());
            modelBuilder.Configurations.Add(new LectureMap());
            modelBuilder.Configurations.Add(new MarkMap());
            modelBuilder.Configurations.Add(new ReceiptMap());
            modelBuilder.Configurations.Add(new RegisterMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new ShiftMap());
            modelBuilder.Configurations.Add(new StaffMap());
            modelBuilder.Configurations.Add(new StatisticsTableMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new TimeTableMap());
            modelBuilder.Configurations.Add(new CourseTypeMap());
            modelBuilder.Configurations.Add(new LoginMap());
        }
    }
}
