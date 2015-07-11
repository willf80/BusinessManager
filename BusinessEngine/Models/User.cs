using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class User
    {
        virtual public int Id { get; set; }
        virtual public String Pseudo { get; set; }
        virtual public String Password { get; set; }
    }
}
