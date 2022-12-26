using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace JobPortalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Job Class
            Job job2 = new Job(22, "Job Title", "Job Description", "Job Location", "Title", "Title", "Title");
            
            Console.WriteLine(job2.JobDescription);
            


            JobSeeker ahmet = new JobSeeker { Name = "AHMET", Email = "birseyler@", Phone = "birseylerdaha@",Password="1234",Type=1};
            JobSeeker memet = new JobSeeker { Name = "MEMET", Email = "birseyler@MEMET", Phone = "birseylerdaha@MEMET",Password = "12345",Type=1 };
            Employer sirket1 = new Employer { Name = "aselsan", Email = "aselsan@", Phone = "ucyuzbesyuz" ,Password = "12345",Type=2 };
            Employer sirket2 = new Employer { Name = "aselsan2", Email = "aselsan@2", Phone = "ucyuzbesyuz2", Password = "12345",Type=2 };
            Administrator admin = new Administrator { Name = "admin", Email = "birseyler@admin", Phone = "birseylerdaha@admin",Password = "12345",Type=3 };
            
        ;



            admin.AddUser(ahmet);
            admin.AddUser(memet);
            admin.AddUser(sirket1);
            admin.AddUser(sirket2);
            admin.AddUser(admin);
            Console.WriteLine("Kullanıcı adı giriniz");
            var x = Console.ReadLine();
            foreach (User user in admin.UsersList)
            {
                if (x == user.Name)
                {
                    Console.WriteLine("Sifre girin");
                    var y = Console.ReadLine();
                    foreach(User user2 in admin.UsersList)
                    {
                        if(y == user2.Password && user2.Name==x) {
                            Console.WriteLine("GİRİS BASARILI");
                            if (user2.Type == 1)
                            {
                                Console.WriteLine("Jobseeker girdi");
                                
                            }
                            else if( user2.Type == 2)
                            {
                                Console.WriteLine("Employer girdi");


                            }
                            else { Console.WriteLine("Admin girdi"); }
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