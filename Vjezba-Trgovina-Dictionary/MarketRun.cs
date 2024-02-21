using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Vjezba_Trgovina_Dictionary
{
    public static class MarketRun
    {
        public static void MarketTask() {

            Product ForestFruits = new Product("Forest Fruits", 4.3m, 12);
            Product Apple = new Product("Apple", 0.5m, 50);
            Product Banana = new Product("Banana", 0.1m, 100);
            Product Kiwi = new Product("Kiwi", 0.6m, 120);

            Market ourMarket = new Market();
            ourMarket.AddProduct(1, ForestFruits);
            ourMarket.AddProduct(2, Apple);
            ourMarket.AddProduct(3, Banana);
            ourMarket.AddProduct(4, Kiwi);
            try
            {
                ourMarket.BuyItem(1, 5);
                Console.WriteLine(ourMarket.ExistItem(1));
            }catch (NotEnaughtProductExepction ex) {
                Console.WriteLine(ex.Message);
            
            }
            

        }

    }
}
