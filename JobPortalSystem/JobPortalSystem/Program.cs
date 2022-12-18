using System;
using System.Collections.Generic;

namespace JobPortalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Job Class
            JobSeeker jobSeeker = new JobSeeker("Kadir", "kadir@kadir.com", "05233574657", 3);
            
            
            Job job1 = new Job(22, "Job Title", "Job Description", "Job Location", 2, 5, "Microsoft");
            Job job2 = new Job(23, "Job Title", "Job Description", "Job Location", 5, 1, "Google");
            Job job3 = new Job(24, "Job Title", "Job Description", "Job Location", 1, 5, "IEU");
            Job job4 = new Job(25, "Job Title", "Job Description", "Job Location", 8, 9, "SAYBYE");
            Job job5 = new Job(26, "Job Title", "Job Description", "Job Location", 2, 22, "LOL");
            Job job6 = new Job(27, "Job Title", "Job Description", "Job Location", 8, 1, "DOTA2");
            
            // Create List of Jobs
            List<Job> jobs = new List<Job>();
            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);
            jobs.Add(job5);
            jobs.Add(job6);
            
            // Show the list of jobs
            Console.WriteLine("List of Jobs");
            Console.WriteLine("============");
            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            
            // 2 tane user tipi : OOP - Inheritance
            // Keep datas in file
            // Export CV
            
            


            

        }

    }
    
}