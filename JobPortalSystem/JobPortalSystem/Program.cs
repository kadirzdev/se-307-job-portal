using System;
using System.Collections.Generic;

namespace JobPortalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Job Class
            Job job2 = new Job(22, "Job Title", "Job Description", "Job Location", "Title", "Title", "Title");
            
            Console.WriteLine(job2.JobDescription);
            
            

        }

    }
    
}