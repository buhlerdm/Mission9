using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreProject.Models
{
    public class Cart
    {
        public List<PurchaseLineItem> Items { get; set; } = new List<PurchaseLineItem>();

        public virtual void AddItem(Book boo, int qty)
        {
            PurchaseLineItem line = Items
                .Where(b => b.Book.BookId == boo.BookId)
                .FirstOrDefault();

            if(line == null)
            {
                Items.Add(new PurchaseLineItem
                {
                    Book = boo,
                    Quantity = qty

                });
            }
            else
            {
                line.Quantity = line.Quantity + qty;
            }
        }

        public virtual void RemoveItem(Book boo)
        {
            Items.RemoveAll(x => x.Book.BookId == boo.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }

        public int CalculateQuantity()
        {
            int total = Items.Sum(x => x.Quantity);

            return total;
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

   

    public class PurchaseLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
