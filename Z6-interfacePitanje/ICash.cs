using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    //shvatio sam da je potrebna interface ali ne razumijem bas sta sve treba sadrzavati
    internal interface ICash
    {
        public decimal CalculateAllocation();
        public abstract decimal TotalAmount();
        public abstract int GetIndex();

    }
}
