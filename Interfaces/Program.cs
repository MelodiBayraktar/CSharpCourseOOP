namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //IPerson person = new Customer();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlCustomerDal(),

            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            // manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" };
            manager.Add(customer);

            Student student = new Student
            {
                Id = 2,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "Computer Science"
            };
            
        }
    }
    interface IPerson
    {
       int Id { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }
       
    }
    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person) { 
            Console.WriteLine(person.FirstName);
        }
    }
}