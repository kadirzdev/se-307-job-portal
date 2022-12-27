using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace JobPortalSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new instance of the Job Class
      Job job2 = new Job(22, "Job Title", "Job Description", "Job Location", "Title", "Title", "Title");
      Job job3 = new Job(23, "Yazılımcı Aranıyor", "HTML CSS JS C#", "İzmir", "3 yıl", "10000$", "Aselsan");
      Job job4 = new Job(24, "Job Title", "Job Description", "Job Location", "Title", "Title", "Title");
      Job job5 = new Job(25, "Job Title", "Job Description", "Job Location", "Title", "Title", "Title");
      
      Employer.jobList.Add(job2);
      Employer.jobList.Add(job3);
      Employer.jobList.Add(job4);
      Employer.jobList.Add(job5);

      Console.WriteLine(job2.JobDescription);



      JobSeeker ahmet = new JobSeeker { Name = "AHMET", Email = "birseyler@", Phone = "birseylerdaha@", Password = "1234", Type = 1 };
      JobSeeker memet = new JobSeeker { Name = "MEMET", Email = "birseyler@MEMET", Phone = "birseylerdaha@MEMET", Password = "12345", Type = 1 };
      Employer sirket1 = new Employer { Name = "aselsan", Email = "aselsan@", Phone = "ucyuzbesyuz", Password = "12345", Type = 2 };
      Employer sirket2 = new Employer { Name = "aselsan2", Email = "aselsan@2", Phone = "ucyuzbesyuz2", Password = "12345", Type = 2 };
      Administrator admin = new Administrator { Name = "admin", Email = "birseyler@admin", Phone = "birseylerdaha@admin", Password = "12345", Type = 3 };

     



      admin.AddUser(ahmet);
      admin.AddUser(memet);
      admin.AddUser(sirket1);
      admin.AddUser(sirket2);
      admin.AddUser(admin);

      Console.WriteLine("Enter Username");
      var x = Console.ReadLine();
      foreach (User user in admin.UsersList)
      {
        if (x == user.Name)
        {
          Console.WriteLine("Password");
          var y = Console.ReadLine();
          foreach (User user2 in admin.UsersList)
          {
            if (y == user2.Password && user2.Name == x)
            {
              Console.WriteLine("LOGIN SUCCESSFUL");
              if (user2.Type == 1)
              {
                for (; ; )
                {
                  Console.WriteLine("Choose Action:");
                  Console.WriteLine(" 1 - Search Jobs");
                  Console.WriteLine(" 2 - Apply Job");
                  Console.WriteLine(" 3 - Upload CV");
                  Console.WriteLine(" 4 - Update CV");
                  Console.WriteLine(" 5 - Exit");
                  int input = Convert.ToInt32(Console.ReadLine());
                  switch (input)
                  {
                    case 1:

                      JobSeeker.searchJob();
                      Console.WriteLine("Job Listing Successful");
                      break;
                    case 2:
                      JobSeeker.ApplyJob();
                      Job.jobSeekersList.Add(user2.Name);
                      break;
                    case 3:
                      Console.WriteLine("Applications");

                      break;
                    case 4:
                      
                      Console.WriteLine("Active Jobs List");
                      break;
                    case 5:
                      Environment.Exit(0);
                      break;

                    default:
                      Console.WriteLine("WTF ARE YOU DOING?");
                      break;

                  }
                }


              }
              else if (user2.Type == 2)
              {
                for (; ; )
                {
                  Console.WriteLine("Choose Action:");
                  Console.WriteLine(" 1 - Add Job");
                  Console.WriteLine(" 2 - Delete Job");
                  Console.WriteLine(" 3 - Show Applications");
                  Console.WriteLine(" 4 - Show Job List");
                  Console.WriteLine(" 5 - Exit");
                  int input = Convert.ToInt32(Console.ReadLine());
                  switch (input)
                  {
                    case 1:

                      Employer.PostJobOpenings();
                      Console.WriteLine("Job Listing Successful");
                      break;
                    case 2:
                      Employer.DeleteJobOpenings();
                      Console.WriteLine("Job Listing Deleted");
                      break;
                    case 3:

                      Console.WriteLine("Applications");

                      break;
                    case 4:
                      Employer.ShowJobOpenings();
                      Console.WriteLine("Active Jobs List");
                      break;
                    case 5:
                      Environment.Exit(0);
                      break;

                    default:
                      Console.WriteLine("WTF ARE YOU DOING?");
                      break;

                  }
                }


                // TODO: AFTER IS ILANI OLUSTUR
                //Console.WriteLine("BITTI GITTI");


              }
              else { Console.WriteLine("Admin HERE!"); }
            }
          }
        }
      }

      Console.WriteLine("Users are succesfully added");
      Console.WriteLine("----------------------------");
      Console.WriteLine("See the jobseeker details");
      ahmet.showUserDetails();
      Console.WriteLine("see the company details ");
      sirket1.showUserDetails();
      Console.WriteLine("Subordinate users Record");
      /*foreach(JobSeeker jobseeker in admin.UsersList)
      {
          jobseeker.showUserDetails();
      }*/
      Console.ReadLine();




    }

  }

}