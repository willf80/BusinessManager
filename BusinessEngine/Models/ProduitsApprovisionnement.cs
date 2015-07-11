using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class ProduitsApprovisionnement
    {
        virtual public ProduitsApprovisionnementPK PKs { get; set; }
    }

    [Serializable]
    public class ProduitsApprovisionnementPK
    {
        public int produitId { get; set; }
        public int approvisionnementId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ProduitsApprovisionnementPK pk;
            pk = (ProduitsApprovisionnementPK)obj;
            if (pk == null)
                return false;
            if (produitId == pk.produitId && approvisionnementId == pk.approvisionnementId)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (produitId + "|" + approvisionnementId).GetHashCode();
        }
    }
}
