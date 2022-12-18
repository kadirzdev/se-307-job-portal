using System;
using System.Collections.Generic;

namespace JobPortalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Job Class
            JobSeeker jobSeeker = new JobSeeker("Kadir", "kadir@kadir.com", "05233574657", Resume);
            
            
            Job job1 = new Job(22, "Job Title", "Job Description", "Job Location", 2, 5, "Microsoft");
            
            Console.WriteLine(jobSeeker.Resume);
            
            

        }

    }
    
}