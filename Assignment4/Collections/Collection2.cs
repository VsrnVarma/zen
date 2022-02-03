using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    class Products
    {
        int Pid;
        string PName;
        public double Price;

        public Products(int id, string name, double price)
        {
            Pid = id;
            PName = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product Id: {Pid} Name: {PName} costs: {Price}";
        }
    }

    class Collection2
    {
        static void Main()
        {
            List<Products> plist = new List<Products>();
            plist.Add(new Products(24, "Dell Laptop", 49999.00));
            plist.Add(new Products(05, "Mi TV", 34999.00));
            plist.Add(new Products(36, "Washing Machine", 45999.00));
            plist.Add(new Products(01, "Cell Phone", 16999.00));
            plist.Add(new Products(25, "Hp Laptop", 42999.00));
            plist.Add(new Products(06, "TCL TV", 29999.00));
            plist.Add(new Products(15, "Mixer", 14999.00));
            plist.Add(new Products(16, "Grinder", 19499.00));
            plist.Add(new Products(14, "Home Theatre", 64999.00));
            plist.Add(new Products(19, "Sound System", 24450.00));

            var res = from n in plist
                      orderby n.Price
                      select n.ToString();

            Console.WriteLine("List after Sorting------");

            Console.WriteLine(String.Join(Environment.NewLine, res));
        }
    }
}
