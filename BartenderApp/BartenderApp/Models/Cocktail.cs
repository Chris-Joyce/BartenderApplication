using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Cocktail
    {
        private Queue<Cocktail> orderQueue;

        public string Name { get; set; }
        public string Cost { get; set; }

        public void PlaceOrder(Cocktail order)
        {
            orderQueue.Enqueue(order);
        }

        public void CompleteOrder()
        {
            orderQueue.Dequeue();
        }
    }

    
}
