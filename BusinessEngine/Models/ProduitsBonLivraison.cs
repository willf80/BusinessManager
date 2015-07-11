using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine.Models
{
    public class ProduitsBonLivraison
    {
        virtual public ProduitsBonLivraisonPK PKs { get; set; }
    }

    [Serializable]
    public class ProduitsBonLivraisonPK
    {
        public int produitId { get; set; }
        public int bonLivraisonId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ProduitsBonLivraisonPK pk;
            pk = (ProduitsBonLivraisonPK)obj;
            if (pk == null)
                return false;
            if (produitId == pk.produitId && bonLivraisonId == pk.bonLivraisonId)
                return true;

            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return (produitId + "|" + bonLivraisonId).GetHashCode();
        }
    }
}
