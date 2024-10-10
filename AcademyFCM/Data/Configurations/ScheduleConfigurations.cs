using AcademyFCM.Data.Entities;
using AcademyFCM.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyFCM.Data.Configurations
{
    public class ScheduleConfigurations : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            //builder.Property(x => x.CourseName).HasMaxLength(128);
            //builder.Property(x => x.Title)
            //    .HasColumnType("VARCHAR").HasMaxLength(255)
            //    .IsRequired();


            builder.Property(x => x.Title)
                .HasConversion(
                x => x.ToString(),
                x => (ScheduleEnums)Enum.Parse(typeof(ScheduleEnums), x));

            builder.ToTable("Schedules");


            //builder.HasData(LoadDataSchedule());


        }

        /*public static List<Schedule> LoadDataSchedule()
        {
            return new List<Schedule>{
                new Schedule {Id = 1, Title = ScheduleEnums.Daily,      SUN = true, MON =  true, TUE = true, WED =true ,   THU = true ,FRI = false, SAT = false},
                new Schedule {Id = 2, Title = ScheduleEnums.DayAfterDay,SUN = true, MON =  false, TUE = true, WED = false, THU = true ,FRI = false, SAT = false},
                new Schedule {Id = 3, Title = ScheduleEnums.TwiceAWeek, SUN = false,MON =  true, TUE = false, WED = true,  THU = false ,FRI = false, SAT = false},
                new Schedule {Id = 4, Title = ScheduleEnums.Weekend,    SUN = false,MON =  false, TUE =false , WED = false,THU = false ,FRI = true, SAT = true},
                new Schedule {Id = 5, Title = ScheduleEnums.Compact,    SUN = true, MON =  true, TUE = true, WED = true,   THU = false ,FRI = true, SAT = true}
            };
        }*/




    }

}
