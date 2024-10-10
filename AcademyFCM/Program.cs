

using AcademyFCM.Data;
using Microsoft.EntityFrameworkCore;


using (AppDbContext? context = new AppDbContext())
{

    var sections = context.Sections
        .Include(x => x.Course)
        .Include(x => x.Instructor)
        .Include(x => x.Schedule);


    Console.WriteLine("\n\n\n\t-------------------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("\t|      |                      |         |                      |                |               |     |     |     |     |     |     |     |");
    Console.WriteLine("\t| Id   |  Course              | Section | Instructor           | Schedule       | Time Slot     | SUN | MON | TUE | WED | THU | FRI | SAT |");
    Console.WriteLine("\t|      |                      |         |                      |                |               |     |     |     |     |     |     |     |");
    Console.WriteLine("\t|------|----------------------|---------|----------------------|----------------|---------------|-----|-----|-----|-----|-----|-----|-----|");



    foreach (var section in sections)
    {
        string sunday = section.Schedule.SUN ? "√" : "x";
        string monday = section.Schedule.MON ? "√" : "x";
        string tuesday = section.Schedule.TUE ? "√" : "x";
        string wednesday = section.Schedule.WED ? "√" : "x";
        string thursday = section.Schedule.THU ? "√" : "x";
        string friday = section.Schedule.FRI ? "√" : "x";
        string saturday = section.Schedule.SAT ? "√" : "x";

        Console.WriteLine($"\t| [{section.Id.ToString().PadLeft(2, '0')}] | {section.Course.CourseName,-20} | {section.SectionName,-7} " +
            $"| {(section.Instructor?.FName + " " + section.Instructor?.LName),-20} |" +
            $" {section.Schedule.Title,-14} | {section.TimeSlot.ToString(),-5} " +
            $"| {sunday,3} | {monday,3} | {tuesday,3} | {wednesday,3} | {thursday,3} | {friday,3} | {saturday,3} |");
        Console.WriteLine("\t-------------------------------------------------------------------------------------------------------------------------------------------");
    }
}

Console.ReadKey();