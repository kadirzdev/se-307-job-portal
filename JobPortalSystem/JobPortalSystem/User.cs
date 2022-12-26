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

        void showUserDetails();

    }
}
