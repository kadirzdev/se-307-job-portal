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

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Password { get; set; }
    public string? Sector { get; set; }
    public string Location { get; set; }
    public int Experience { get; set; }


    public void JobSeekerInfo(string name, string email, string phone, string password, string sector, string location, int experience)
    {
      Name = name;
      Email = email;
      Phone = phone;
      Password = password;
      Sector = sector;
      Location = location;
      Experience = experience;
    }
    public static void searchJob()
    {
      foreach (Job joblist in Employer.jobList)
      {
        joblist.DisplayJob();
      }
    }
    public static void ApplyJob()
    {
      Console.WriteLine("Select Job ID to apply");
      var _jobid = Convert.ToInt32(Console.ReadLine());
      
      foreach (Job joblist in Employer.jobList)
      {
        if (joblist.JobId == _jobid)
        {
          Console.WriteLine("Apply Succesful");
          break;
        }
        else if (joblist.JobId != _jobid)
        {

        }
        else
        {
          Console.WriteLine("Invalid job id");

        }
      }
    }
    // Show JobSeeker Details in one row
    public void DisplayUser()
    {
      Console.WriteLine($"Name: {Name} | Email: {Email} | Phone: {Phone} | Sector: {Sector} | Location: {Location} | Experience: {Experience}");
    }

  }
}