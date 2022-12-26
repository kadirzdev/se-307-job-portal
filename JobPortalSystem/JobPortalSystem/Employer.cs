using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalSystem
{
    // leaf
    internal class Employer : User

    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte Type { get; set; }


        /* public Employer(string name, string email, string phone)
         {
             Name = name;
             Email = email;
             Phone = phone;
         }*/

        public void showUserDetails()
        {
            Console.WriteLine(Name + "" + Email + "" + Phone + "" );
        }

    }
}
