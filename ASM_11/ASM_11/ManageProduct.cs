using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    class ManageProduct
    {
        public delegate void WarningDelegate(string mess);
        ArrayList list = new ArrayList();
        public ArrayList List { get => list }
        public event WarningDelegate EventAddProduct;
        public void AddNew(Product p)
        {
            list.Add(p);
        }

        public Product FindById(int ProductID)
        {
            foreach (Product p in list)
            {
                if (p.Identity == ProductID) return p;
            }
            return null;
        }

        public void Remove(int ProductID)
        {
            Product p = FindById(ProductID);
            if (p!=null)
            {
                list.Remove(p);
                EventAddProduct($"Product ID = {p.Identity} removed successfully");
            }
        }
    }
}
