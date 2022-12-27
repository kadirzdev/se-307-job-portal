using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSystem
{
    // leaf
    internal class Employer : User

    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte Type { get; set; }
        public static List<Job> jobList = new List<Job>();



        /* public Employer(string name, string email, string phone)
         {
             Name = name;
             Email = email;
             Phone = phone;
         }*/

        public void showUserDetails()
        {
            Console.WriteLine(Name + "" + Email + "" + Phone + "" );
        }
        public static void PostJobOpenings()
        {
            Console.WriteLine("İs basligi girin");
            var jobTitle = Console.ReadLine();
            Console.WriteLine("İs aciklamasını girin");
            var jobDesciription = Console.ReadLine();
            Console.WriteLine("İs kounumunu girin");
            var jobLocation = Console.ReadLine();
            Console.WriteLine("İs tecrübesini girin");
            var  jobExperience = Console.ReadLine();
            Console.WriteLine("İs maaş aralığını girin");
            var jobSalary = Console.ReadLine();
            Console.WriteLine("İs ismini girin");
            var jobCompany = Console.ReadLine();
            Job job = new Job(1,jobTitle??"-" ,jobDesciription??"-",jobLocation ?? "-",jobExperience ?? "-",jobSalary ?? "-",jobCompany ?? "-");
            jobList.Add(job);
           // Console.WriteLine(job);

        }
        
        public static void ShowJobOpenings()
        {
            foreach (Job job in jobList)
            {
                job.DisplayJob();
            }
        }

        public static void DeleteJobOpenings()
        {
            Console.WriteLine("Please enter the job ID you want to delete");
            int jobId =  Convert.ToInt32(Console.ReadLine());
            foreach (Job job in jobList)
            {
                if (job.JobId == jobId)
                {
                    jobList.Remove(job);
                    Console.WriteLine("Job Deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Job not found");
                }
            }
        }
        
        public void searchCandidates()
        {
           foreach(Job job in jobList)
            {
                Console.WriteLine(job.JobTitle +""+job.JobId);

            }
            Console.WriteLine("Görünütlemek istediğiniz işlemin ID'sini seçin");
            var getJobId = Convert.ToInt32(Console.ReadLine());
            foreach (Job job in jobList)
            {
                if(job.JobId == getJobId)
                {
                    Console.WriteLine(Job.jobSeekersList);
                }
            }
            

        }


    }
}
