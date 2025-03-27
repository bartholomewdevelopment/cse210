using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Owner";
        job1._companyName = "Bartholomew Development";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Implementation Manager";
        job2._companyName = "Tekion";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Joseph Bartholomew";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        job1.ShowCompanyNames();
        job2.ShowCompanyNames();
        job1.Display();
        job2.Display();
        myResume.Display();


    }
}