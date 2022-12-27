using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSystem
{
  public class JobSeeker : User
  {

    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public byte Type { get; set; }

    public void JobSeekerInfo(string name, string email, string phone, string password)
    {
      Name = name;
      Email = email;
      Phone = phone;
      Password = password;
    }

    // Resume Object
    // public Resume Resume { get; set; }
    /* public JobSeeker(string name, string email, string phone );//Resume resume)
     {
         Name = name;
         Email = email;
         Phone = phone;
         //Resume = resume;
     }

     */
    public static void searchJob()
    {
      foreach (Job joblist in Employer.jobList)
      {
        joblist.DisplayJob();
      }
    }

    public static void ApplyJob()
    {
      Console.Write("Enter which job if you want to apply");
      var _jobid = Convert.ToInt32(Console.ReadLine());

      foreach (Job joblist in Employer.jobList)
      {
        if(joblist.JobId == _jobid)
        {
          Console.WriteLine("Apply Succesful");
          break;
        }
        else if(joblist.JobId != _jobid)
        {
          
        }
        else 
        {
          Console.WriteLine("Ýnvalid job id");

        }
      }
    }

    public void showUserDetails()
    {
      Console.WriteLine(Name + "" + Email + "" + Phone + "");//+ Resume);
    }

  }
}