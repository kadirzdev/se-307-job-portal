namespace JobPortalSystem;

public class JobSeeker
{
    
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    
    // Resume Object
    public Resume Resume { get; set; }
    
    // Constructor
    public JobSeeker(string name, string email, string phone, Resume resume)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Resume = new Resume(name, email , phone);;


    }

    
}