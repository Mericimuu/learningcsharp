using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //  InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
        private static void Demo()
        {
            //interface'in tek başına instance'ı oluşturulamaz.
            // IPerson person = new IPerson(); hatalı. new IPerson yerine, customer, student vs olur.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //uzun yol aşağıda belirtilmiştir, kısaca manager.add diyerek de içeriğini verbiliriz.
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Meric",
            //    LastName = "Ozkan",
            //    Address = "Istanbul"
            //};
            // manager.Add(customer);
            manager.Add(new Customer { Id = 1, FirstName = "Meric", LastName = "Ozkan", Address = "Istanbul" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Müge",
                LastName = "Özkan",
                Department = "Archeology"

            };
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class PersonManager
    {
        /*burada add komutu ile interface değil normal class tanımlasaydım,
        yukarıda çağırma işleminde class ismi uyuşmadığı takdirde hata alacaktım.*/
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
