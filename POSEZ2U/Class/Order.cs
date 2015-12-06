using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEZ2U.Class
{
    public class Order
    {
        public string TableId { get; set; }
        public double Total { get; set; }
        public double GST { get; set; }
        public int Discount { get; set; }
        public List<Item> ListItem = new List<Item>();
        public int Seat { get; set; }
        public class Item
        {
            public int ItemId { get; set; }
            public int Seat { get; set; }
            public string ItemName { get; set; }
            public int Qunatity { get; set; }
            public double Price { get; set; }
            public double SubTotal { get; set; }
            public int KeyItem { get; set; }
            public double GST { get; set; }
            public List<Modifier> ListModifier = new List<Modifier>();
        }
        public class Modifier
        {
            public string ModifierName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public double Suntaol { get; set; }
            public int KeyItem { get; set; }
            public int ModifireId { get; set; }
        }
        public void addItemToList(Item item)
        {

            item.KeyItem = ListItem.Count + 1;
            ListItem.Add(item);

        }
        public void addModifierToList(Modifier modifier, int keyItem)
        {

            if (ListItem.Count > 0)
            {
                modifier.KeyItem = ListItem[keyItem - 1].ListModifier.Count + 1;
                ListItem[keyItem - 1].ListModifier.Add(modifier);

            }

        }
        public void addSeat(int numberSeat)
        {
            Seat = numberSeat;
        }
        public Double SubTotal()
        {
            Double total = 0;
            for (int i = 0; i < ListItem.Count; i++)
            {

                total += ListItem[i].Price;
            }
            return total;
        }
    }
}