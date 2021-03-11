using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem (Book boo, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == boo.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = boo,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }

        }

        public void RemoveLine(Book boo) =>
            Lines.RemoveAll(x => x.Book.BookId == boo.BookId);

        public void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => Lines.Sum(e => 25 * e.Quantity); //Price is hard-coded     

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
