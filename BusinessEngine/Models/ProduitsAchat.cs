using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class ProduitsAchat
    {
        virtual public ProduitsAchatPK PKs { get; set; }
    }

    [Serializable]
    public class ProduitsAchatPK
    {
        public int produitId { get; set; }
        public int achatId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ProduitsAchatPK pk;
            pk = (ProduitsAchatPK)obj;
            if (pk == null)
                return false;
            if (produitId == pk.produitId && achatId == pk.achatId)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (produitId + "|" + achatId).GetHashCode();
        }
    }
}
