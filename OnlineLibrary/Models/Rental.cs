using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime RentalDate { get; set; } 
        public DateTime ?DeliveryDate {get; set;}
        public Status Status { get; set; } 

        public Rental()
        {

        }

        public void BookDelivery()
        {
            Status = Status.Delivered;
            if(DeliveryDate == null)
            {
                DeliveryDate = DateTime.Now;
            }
        }

        //public int ReturnBook()
        //{
        //    Status = Status.Reurned;
        //    if (DeliveryDate.HasValue)
        //    {
        //        var count= DateTime.Now.Date - DeliveryDate.Value.Date;
        //        if(count.Days > 30)
        //        {
        //            return count.Days - 30 * 5;
        //        } 
        //    }
            
 
        //}

    }
}
