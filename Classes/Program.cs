using System.Threading.Channels;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer 
            {
                FirstName ="Derin",
                LastName= "Demiroğ",
                City="İstanbul", 
                Id = 2
            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
       
       
    }
}