using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Vjezba_Trgovina_Dictionary
{
    public class Market
    {
        Dictionary<int, Product> Inventory;

        public Market() { 
        
            Inventory = new Dictionary<int, Product>();
        }

        public void AddProduct(int id, Product product)
        {
            Inventory.Add(id, product);
        }

        public void RemoveProduct(int id)
        {
            Inventory.Remove(id);
        }

        public void BuyItem(int ID, int numberOfItems)
        {
            foreach (var id in Inventory)
            {
                if(id.Key == ID)
                {

                    if (id.Value.Quantity < numberOfItems)
                    {
                        throw new NotEnaughtProductExepction("We don't have enaught item");
                    }
                    else
                    {
                        id.Value.Quantity -= numberOfItems;
                    }
                }
            }
        }

        public string ExistItem(int ID)
        {
            int numberOfItem = 0;
            string productName = string.Empty;
            foreach (var id in Inventory) { 
                if (id.Key == ID)
                {
                    numberOfItem = id.Value.Quantity;
                    productName = id.Value.Name;
                }
            }
            string text = $"Product: {productName}, Quantity {numberOfItem} ";
            return text;
        }
        

    }
}
