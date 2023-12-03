namespace ReferrenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, boolean Value Types
            int number1 = 10;
            int number2 = 20;

            number1 = number2;

            number2 = 100;

            Console.WriteLine("Sayi1:" + number1);


            //arrays, class, interface ... Reference Types
            int[] numbers1 = { 1, 2, 3 };

            int[] numbers2 = { 4, 5, 6 };

            numbers1 = numbers2;

            Console.WriteLine("Sayilar1[0]:" + numbers1[0]);

            numbers2[0] = 1000;

            Console.WriteLine("Sayilar1[0]:" + numbers1[0]);

            //Class Example

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Enes";
            person2 = person1;
            person1.FirstName = "Erdem";

            Console.WriteLine(person2.FirstName);






            Customer customer = new Customer();
            customer.FirstName = "Fatih";
            Employee employee = new Employee();
            employee.FirstName = "Aysel";


            Person person3 = customer;

            customer.FirstName = "Hasan";
            customer.CreditNumber = "123456789";

            Console.WriteLine(person3.FirstName);

            //Customer Boxing
            Console.WriteLine(((Customer)person3).CreditNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);
            

        }

    }

    //Base Class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}