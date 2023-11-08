using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new();
        job1._company = "EnsignTech";
        job1._jobTitle = "Technical support Engineer";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new();
        job2._company = "Bloom";
        job2._jobTitle = "Mentor";
        job2._startYear = 2021;
        job2._endYear = 2023;
        Resume myResume = new();

        myResume._name = "Igwe Emmanuel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        



        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        // job1.DisplayJobDetails();
    }







}