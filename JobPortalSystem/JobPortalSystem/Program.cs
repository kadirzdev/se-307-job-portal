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

      Job job2 = new Job(1, "Proje Menejeri", "Projelere menejerlik yapıcak adam aranıyor", "İstanbul", "15 Yıl", "5000$", "Metrix");
      Job job3 = new Job(2, "Yazılımcı Aranıyor", "HTML CSS JS C#", "İzmir", "3 yıl", "10000$", "Aselsan");
      Job job4 = new Job(3, "Med Backend Developer", "c#, redis , docker, .net bilen yazılımcı aranıyor.", "İstanbul", "2 Yıl", "2000$", "Pepsico");
      Job job5 = new Job(4, "Junior Frontend Developer", "Basic html jquery ve css", "İstanbul", "1 Yıl", "1000$", "Koç");
      Job job6 = new Job(5, "Junior Backend Developer", "Basic c# .net core", "Ankara", "1.5 Yıl", "1500$", "Şişecam");

      Employer.jobList.Add(job2);
      Employer.jobList.Add(job3);
      Employer.jobList.Add(job4);
      Employer.jobList.Add(job5);
      Employer.jobList.Add(job6);

      JobSeeker Kadir = new JobSeeker { Name = "kadir", Email = "kadirzdev@gmail.com", Phone = "5325540204", Password = "1234", Sector = "-", Location = "-", Experience = 0 };
      JobSeeker Cenk = new JobSeeker { Name = "cenk", Email = "cenk@gmail.com", Phone = "502423223", Password = "1234", Sector = "-", Location = "-", Experience = 0 };
      JobSeeker Berke = new JobSeeker { Name = "berke", Email = "berke@gmail.com", Phone = "5053212122", Password = "1234", Sector = "-", Location = "-", Experience = 0 };
      JobSeeker Eray = new JobSeeker { Name = "eray", Email = "eray@gmail.com", Phone = "5422521997", Password = "1234", Sector = "-", Location = "-", Experience = 0 };

      Employer sirket1 = new Employer { Name = "sirket1", Email = "sirsirketket@", Phone = "765786767", Password = "12345" };
      Employer sirket2 = new Employer { Name = "sirket2", Email = "sirsirketket@2", Phone = "76668687", Password = "12345" };
      Administrator admin = new Administrator { Name = "admin", Email = "birseyler@admin", Phone = "birseylerdaha@admin", Password = "12345" };

      admin.AddUser(admin);
      admin.AddUser(Kadir);
      admin.AddUser(Cenk);
      admin.AddUser(Berke);
      admin.AddUser(Eray);

      admin.AddUser(sirket1);
      admin.AddUser(sirket2);

      int protector = 3;

      while (protector > 0)
      {

      BACKLOGIN:

        Console.WriteLine("Enter Username");
        var username = Console.ReadLine();

        foreach (User user in admin.UsersList)
        {

          if (username == user.Name)
          {

            Console.WriteLine("Password");
            var password = Console.ReadLine();
            foreach (User user2 in admin.UsersList)
            {
              if (password == user2.Password && user2.Name == username)
              {

                if (user2.GetType() == typeof(JobSeeker))
                {
                  while (true)
                  {
                  CHOOSEAGAIN:

                    Console.WriteLine("Choose Action:");
                    Console.WriteLine(" 1 - Search Jobs");
                    Console.WriteLine(" 2 - Apply Job");
                    Console.WriteLine(" 3 - Create CV");
                    Console.WriteLine(" 4 - Update CV");
                    Console.WriteLine(" 5 - Logout");

                    for (; ; )
                    {
                      int input = Convert.ToInt32(Console.ReadLine());
                      switch (input)
                      {
                        case 1:

                          JobSeeker.searchJob();
                          Console.WriteLine("Job Listing Successful");
                          goto CHOOSEAGAIN;
                        case 2:
                          JobSeeker.searchJob();
                          JobSeeker.ApplyJob();
                          Job.jobSeekersList.Add(new JobSeeker { Name = user2.Name, Email = user2.Email, Phone = user2.Phone, Sector = user2.Sector, Location = user2.Location, Experience = user2.Experience });
                          goto CHOOSEAGAIN;
                        case 3:
                          Console.WriteLine("Create Your CV " + user2.Name);
                          user2.DisplayUser();
                          Console.WriteLine("FILL Your FIELD:");
                          Console.WriteLine(" 1 - Sector");
                          Console.WriteLine(" 2 - Location");
                          Console.WriteLine(" 3 - Experience");
                          Console.WriteLine(" 4 - Back");
                          while (true)
                          {
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            switch (input2)
                            {
                              case 1:
                                Console.WriteLine("Enter Sector");
                                user2.Sector = Console.ReadLine() ?? " - ";
                                user2.DisplayUser();
                                break;
                              case 2:
                                Console.WriteLine("Enter Location");
                                user2.Location = Console.ReadLine() ?? " - ";
                                user2.DisplayUser();
                                break;
                              case 3:
                                Console.WriteLine("Enter Experience");
                                user2.Experience = Convert.ToInt32(Console.ReadLine() ?? "0");
                                user2.DisplayUser();
                                break;
                              default:
                                goto CHOOSEAGAIN;
                            }
                          }
                        case 4:
                          Console.WriteLine("Update Your CV " + user2.Name);
                          user2.DisplayUser();
                          Console.WriteLine("Update Your FIELD:");
                          Console.WriteLine(" 1 - Sector");
                          Console.WriteLine(" 2 - Location");
                          Console.WriteLine(" 3 - Experience");
                          Console.WriteLine(" 4 - Back");
                          while (true)
                          {
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            switch (input2)
                            {
                              case 1:
                                Console.WriteLine("Enter Sector");
                                user2.Sector = Console.ReadLine() ?? " - ";
                                user2.DisplayUser();
                                break;
                              case 2:
                                Console.WriteLine("Enter Location");
                                user2.Location = Console.ReadLine() ?? " - ";
                                user2.DisplayUser();
                                break;
                              case 3:
                                Console.WriteLine("Enter Experience");
                                user2.Experience = Convert.ToInt32(Console.ReadLine() ?? "0");
                                user2.DisplayUser();
                                break;
                              default:
                                goto CHOOSEAGAIN;
                            }
                          }
                        case 5:
                          Console.WriteLine("Logout Successful");
                          goto BACKLOGIN;
                        default:
                          goto CHOOSEAGAIN;
                      }
                    }
                  }

                }
                else if (user2.GetType() == typeof(Employer))
                {
                  for (; ; )
                  {
                  CHOOSEAGAIN:
                    Console.WriteLine("Choose Action:");
                    Console.WriteLine(" 1 - Add Job");
                    Console.WriteLine(" 2 - Delete Job");
                    Console.WriteLine(" 3 - Show Applications");
                    Console.WriteLine(" 4 - Show Job List");
                    Console.WriteLine(" 5 - Logout");
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

                        // JobSeeker List with For Loop
                        for (int i = 0; i < Job.jobSeekersList.Count; i++)
                        {
                          Job.jobSeekersList[i].DisplayUser();
                        }

                        break;
                      case 4:
                        Employer.ShowJobOpenings();
                        Console.WriteLine("Active Jobs List");
                        break;
                      case 5:
                        Console.WriteLine("Logout Successful");
                        goto BACKLOGIN;

                      default:
                        goto CHOOSEAGAIN;

                    }
                  }

                }
                else if (user2.GetType() == typeof(Administrator))
                {
                  for (; ; )
                  {
                    Console.WriteLine("Choose Action:");
                    Console.WriteLine(" 1 - Delete User");
                    Console.WriteLine(" 2 - Show Users");
                    Console.WriteLine(" 3 - Logout");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                      case 1:
                        // Show UsersLists
                        for (int i = 0; i < admin.UsersList.Count; i++)
                        {
                          Console.Write((i + 1) + " - ");
                          admin.UsersList[i].DisplayUser();
                        }
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("User Removed " + admin.UsersList[input2 - 1].Name);
                        admin.UsersList.RemoveAt(input2 - 1);

                        Console.WriteLine("NEW USER LIST");
                        for (int i = 0; i < admin.UsersList.Count; i++)
                        {
                          Console.Write((i + 1) + " - ");
                          admin.UsersList[i].DisplayUser();
                        }
                        break;
                      case 2:
                        // Show UsersLists
                        for (int i = 0; i < admin.UsersList.Count; i++)
                        {
                          admin.UsersList[i].DisplayUser();
                        }
                        break;
                      case 3:
                        Console.WriteLine("Logout Successful");
                        goto BACKLOGIN;
                      default:
                        break;
                    }
                  }
                }
              }

            }
            protector--;
            Console.WriteLine("Wrong Username - Try Again : You can try " + protector + " more time!");

          }
        }

      }

    }

  }
}