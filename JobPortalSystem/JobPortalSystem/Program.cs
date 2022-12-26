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


            JobSeeker ahmet = new JobSeeker { Name = "AHMET", Email = "birseyler@", Phone = "birseylerdaha@" };
            JobSeeker memet = new JobSeeker { Name = "MEMET", Email = "birseyler@MEMET", Phone = "birseylerdaha@MEMET" };
            Employer sirket1 = new Employer { Name = "aselsan", Email = "aselsan@", Phone = "ucyuzbesyuz" };
            Employer sirket2 = new Employer { Name = "aselsan2", Email = "aselsan@2", Phone = "ucyuzbesyuz2" };
            Administrator admin = new Administrator { Name = "admin", Email = "birseyler@admin", Phone = "birseylerdaha@admin" };
            admin.AddUser(ahmet);
            admin.AddUser(memet);
            admin.AddUser(sirket1);
            admin.AddUser(sirket2);
            Console.WriteLine("Users are succesfully added");
            Console.WriteLine("----------------------------");
            Console.WriteLine("See the jobseeker details");
            ahmet.showUserDetails();
            Console.WriteLine("see the company details ");
            sirket1.showUserDetails();
            Console.WriteLine("Subordinate users Record");
            foreach(JobSeeker jobseeker in admin.UsersList)
            {
                jobseeker.showUserDetails();
            }
            Console.ReadLine();




        }

    }
    
}