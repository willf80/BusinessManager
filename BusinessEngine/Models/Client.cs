using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class Client
    {
        virtual public int Id { get; set; }
        virtual public String Nom { get; set; }
        virtual public String Prenoms { get; set; }
    }
}
