using System;
namespace Custom_Exceptions.Models
{
    abstract class Product
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected double TotalInCome { get; set; }

        public Product(string name,double price,int count,double totalInCome)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
            TotalInCome = totalInCome;

        }

        
        public abstract void Sell();
        public abstract void ShowInfo();
       
       
    }
}