using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int IsbnNum { get; set; }
        public int PageNum { get; set; }
        public int RentalNum { get; set; }
        public int Quantity { get; set; }
        public Author Author { get; set; }

        public void SetRentalNum()
        {

        }
    }
}
