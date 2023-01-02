namespace JobPortalSystem;

// Job Portal System Jobs
public class Job
{

  public int JobId { get; set; }
  public string JobTitle { get; set; }
  public string JobDescription { get; set; }
  public string JobLocation { get; set; }
  public string JobExperience { get; set; }
  public string JobSalary { get; set; }
  public string JobCompany { get; set; }

  public static List<JobSeeker> jobSeekersList = new List<JobSeeker>();

  public Job(int jobId, string jobTitle, string jobDescription, string jobLocation, string jobExperience, string jobSalary, string jobCompany)
  {
    JobId = jobId;
    JobTitle = jobTitle;
    JobDescription = jobDescription;
    JobLocation = jobLocation;
    JobExperience = jobExperience;
    JobSalary = jobSalary;
    JobCompany = jobCompany;
  }
  // Display Job Details in one line
  public void DisplayJob()
  {
    Console.WriteLine($"Job ID: {JobId} | Job Title: {JobTitle} | Job Description: {JobDescription} | Job Location: {JobLocation} | Job Experience: {JobExperience} | Job Salary: {JobSalary} | Job Company: {JobCompany}");
  }
  // Display jobSeekersList in one line
  public static void DisplayJobAppUser()
  {
    foreach (JobSeeker jobSeeker in jobSeekersList)
    {
      Console.WriteLine(jobSeeker);
    }
  }
}