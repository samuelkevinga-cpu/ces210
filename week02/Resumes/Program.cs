using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2027;
        job1._endYear = 2030;
        job1.Display();
       

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Program Manager";
        job2._startYear = 2024;
        job2._endYear = 2027;
        job2.Display();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs[0].Display();
    }
}
