﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePOS.Model
{
   public class Order
    {
        public int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> FloorID { get; set; }
        public int Status { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string Note { get; set; }
        public int Seat { get; set; }
        public List<OrderDetail> ListOrderDetail = new List<OrderDetail>();
        
        public void addItemToList(OrderDetail item)
        {
            item.KeyItem = ListOrderDetail.Count + 1;
            ListOrderDetail.Add(item);
        }
        public void addModifierToList(OrderDetailModifire modifire, int keyItem)
        {
            if (ListOrderDetail.Count > 0)
            {
                modifire.KeyItem = ListOrderDetail[keyItem - 1].ListOrderDetailModifire.Count + 1;
                ListOrderDetail[keyItem - 1].ListOrderDetailModifire.Add(modifire);

            }
        }
        public Double SubTotal()
        {
            Double total = 0;
            for (int i = 0; i < ListOrderDetail.Count; i++)
            {

                total +=Convert.ToDouble(ListOrderDetail[i].Price);
            }
            return total;
        }
       public void addSeat(int numberSeat)
       {
           Seat=numberSeat; 
       }
    }
}
