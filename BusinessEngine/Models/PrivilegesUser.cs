using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class PrivilegesUser
    {
        virtual public PrivilegesUserPK PKs { get; set; }
    }

    [Serializable]
    public class PrivilegesUserPK
    {
        public int PrivilegeId { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrivilegesUserPK pk;
            pk = (PrivilegesUserPK)obj;
            if (pk == null)
                return false;
            if (PrivilegeId == pk.PrivilegeId && UserId == pk.UserId)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (PrivilegeId + "|" + UserId).GetHashCode();
        }
    }
}
