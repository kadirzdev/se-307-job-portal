namespace JobPortalSystem;
// leaf
public class JobSeeker : User
{
    
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

  /*  public JobSeeker(string name,string email,string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }*/

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
    
    public  void showUserDetails()
    {
        Console.WriteLine(Name + "" + Email + "" + Phone + "");//+ Resume);
    }

}