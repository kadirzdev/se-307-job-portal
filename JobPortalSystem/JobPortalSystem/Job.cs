namespace JobPortalSystem;

// Job Portal System Jobs
public class Job
{
    public int JobId { get; set; }
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public string JobLocation { get; set; }
    public int JobExperience { get; set; }
    public int JobSalary { get; set; }
    public string JobCompany { get; set; }

    
    public Job(int jobId, string jobTitle, string jobDescription, string jobLocation, int jobExperience, int jobSalary, string jobCompany)
    {
        JobId = jobId;
        JobTitle = jobTitle;
        JobDescription = jobDescription;
        JobLocation = jobLocation;
        JobExperience = jobExperience;
        JobSalary = jobSalary;
        JobCompany = jobCompany;
    }
    
    // Display Job Details in a List
    public override string ToString()
    {
        return $"Job ID: {JobId} | Job Title: {JobTitle} | Job Description: {JobDescription} | Job Location: {JobLocation} | Job Experience: {JobExperience} | Job Salary: {JobSalary} | Job Company: {JobCompany}";
    }


}