using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        // I am creating first Job object (a “box” for job info)
        Job job1  = new Job();

        // I am filling in job1’s information using dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;



        // I am creating second Job object
        Job job2 = new Job();

        // I am filling in job2’s information
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // I am creating Resume object (this will hold name + jobs)
        Resume myResume = new Resume();

        // I set the name on resume
        myResume._name = "Allison Rose";

        // I add two job objects into resume’s job list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        // Now I display resume in one call
        myResume.Display();  // I show name + all jobs


    }
}