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
       public string Seat { get; set; }
       public double Total { get; set; }
       public List<Item> ListItem = new List<Item>();
       
       int keyItem = 1;
       public class Item
       {
           public string ItemName { get; set; }
           public int Qunatity { get; set; }
           public double Price { get; set; }
           public double SubTotal { get; set; }
           public int KeyItem { get; set; }
           public List<Modifier> ListModifier = new List<Modifier>();
       }
       public class Modifier
       {
           public string ModifierName { get; set; }
           public int Quantity { get; set; }
           public double Price { get; set; }
           public double Suntaol { get; set; }
       }
       public void addItemToList(Item item)
       {

           item.KeyItem = ListItem.Count + 1;
           ListItem.Add(item);

       }
       public void addModifierToList(Modifier modifier,int keyItem)
       {
           
           if (ListItem.Count > 0)
           {

               ListItem[keyItem-1].ListModifier.Add(modifier);
               
           }
           
       }
       public void addSeat(string numberSeat)
       {
           Seat = numberSeat;
       }
    }
}
