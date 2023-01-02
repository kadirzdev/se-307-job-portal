using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSystem
{ //Component ( Drawing Element)
  public interface User
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string Sector { get; set; }
    public string Location { get; set; }
    public int Experience { get; set; }

    void DisplayUser();

  }
}
