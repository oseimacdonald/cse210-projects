using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // create a resume instance
        Resume myResume = new Resume("Allison Rose");

        // add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // display the resume
        myResume.Display();

    }
}