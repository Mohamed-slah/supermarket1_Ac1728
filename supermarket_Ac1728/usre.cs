using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_Ac1728
{
   public class usre
    {
        public int UsreId { get; set; }
        public string UsreFullame { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public usre()
        {

        }

        public usre(int usreid, string usrefullname, string password)
        {
            usreid = usreid;
            usrefullname = usrefullname;
            password = password;
        }
    }
}
