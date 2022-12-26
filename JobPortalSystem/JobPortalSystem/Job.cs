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
    public static List<JobSeeker>? jobSeekersList = new List<JobSeeker>();


    public Job(int jobId, string jobTitle, string jobDescription, string jobLocation, string jobExperience, string jobSalary, string jobCompany)
    {
        JobId = jobId;
        JobTitle = jobTitle;
        JobDescription = jobDescription;
        JobLocation = jobLocation;
        JobExperience = jobExperience;
        JobSalary = jobSalary;
        JobCompany = jobCompany;
        jobSeekersList = null;
    }
   

}