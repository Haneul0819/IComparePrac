using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparePrac
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price - ((Product)obj).Price;
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product(){ Name = "고구마", Price=1000},
                new Product(){ Name = "감자", Price=3000},
                new Product(){ Name = "옥수수", Price=900},
                new Product(){ Name = "토마토", Price=1200},
                new Product(){ Name = "당근", Price=10000},
            };
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
