namespace JobPortalSystem;

public class JobSeeker
{
    
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    
    public int Experience { get; set; }
    
    // Resume Object

    // Constructor
    public JobSeeker(string name, string email, string phone, int experience)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Experience = experience;
    }
    
    
    // Resume
    public void DisplayResume()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone: " + Phone);
        Console.WriteLine("Experience: " + Experience);
    }


}