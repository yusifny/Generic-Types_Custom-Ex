using System;
using Custom_Exceptions.Exceptions;

namespace Custom_Exceptions.Models
{
    class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string authorName,int pageCount,string name, double price,int count, double totalInCome) :base(name,price,count,totalInCome)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}/n Price{Price}/n Count{Count}/n TotalInCome{TotalInCome}/n AuthorName{AuthorName}/n PageCount{PageCount}");
        }
        public override void Sell()
        {
            if (Count!=0)
            {
                Count--;
                TotalInCome = TotalInCome + Price;

            }
            else
            {
                throw new ProductCountIsZeroException("There is no enough product");
            }
            
        }
    }
}
