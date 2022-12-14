using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSystem
{
  // Composite 
  internal class Administrator : User
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string Sector { get; set; }
    public string Location { get; set; }
    public int Experience { get; set; }
    public List<User> UsersList = new List<User>();
    public void showUserDetails()
    {
      Console.WriteLine(Name + "" + Email + "" + Phone + "");
    }
    public void DisplayUser()
    {
      Console.WriteLine($"Name: {Name} | Email: {Email} | Phone: {Phone}");
    }
    public void AddUser(User user)
    {
      UsersList.Add(user);
    }
    public void RemoveUser(User user)
    {
      UsersList.Remove(user);
    }
  }
}
