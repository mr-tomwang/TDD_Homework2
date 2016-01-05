using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<Book> potterVol1;
        private List<Book> potterVol2;
        private List<Book> potterVol3;
        private List<Book> potterVol4;
        private List<Book> potterVol5;

        static void Main(string[] args)
        {
        }

        public ShoppingCart()
        {
            potterVol1 = new List<Book>();
            potterVol2 = new List<Book>();
            potterVol3 = new List<Book>();
            potterVol4 = new List<Book>();
            potterVol5 = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book.Title=="PoterVolume1")
                this.potterVol1.Add(book);
            else if (book.Title == "PoterVolume2")
                this.potterVol2.Add(book);
            else if (book.Title == "PoterVolume3")
                this.potterVol3.Add(book);
            else if (book.Title == "PoterVolume4")
                this.potterVol4.Add(book);
            else if (book.Title == "PoterVolume5")
                this.potterVol5.Add(book);
            else
            {
                Console.WriteLine("Exception: Special offer does not include {0}", book.Title);
            }
        }

        public int GetPrice()
        {
            int priceForVol1 = 100 * this.potterVol1.Count;
            int priceForVol2 = 100 * this.potterVol2.Count;
            int priceForVol3 = 100 * this.potterVol3.Count;
            int priceForVol4 = 100 * this.potterVol4.Count;
            int priceForVol5 = 100 * this.potterVol5.Count;

            return priceForVol1 + 
                   priceForVol2 +
                   priceForVol3 +
                   priceForVol4 +
                   priceForVol5;
        }
    }
}
