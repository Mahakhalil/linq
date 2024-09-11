namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
        List<Customer> Customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Maha khalil",
                    Email = "Mahakhalil@gmail.com",
                    phone = 0592999345,
                    city = "Nablus",
                },

                new Customer()
                {
                    Id = 2,
                    Name = "Tariq shreem",
                    Email = "Tariqshreem@gmail.com",
                    phone = 0592567345,
                    city = "Qalqilya",
                },

            
                new Customer()
                {
                    Id = 3,
                    Name = "Mostafa naser",
                    Email = "Mostafanaser@gmail.com",
                    phone = 0592478645,
                    city = "Ramallah",
                },

               

                new Customer()
                {
                    Id = 4,
                    Name = "shatha mohammad",
                    Email = "shathamohammad@gmail.com",
                    phone = 0593459872,
                    city = "Tulkarm",
                },

               

            };

            var customersInNablus = Customers.Where(c => c.city == "Nablus").ToList();

            foreach (var customer in customersInNablus)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("#########################");

            var customerName= Customers.Select(c  => c.Name).ToList();

            foreach ( var customer in customerName)
            { 
                Console.WriteLine(customer);
            }

            Console.WriteLine("#########################");

            var sortedCustomers = Customers.OrderBy(c => c.Name).ToList();

            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("#########################");

            var firstCustomer = Customers.FirstOrDefault();

            if (firstCustomer != null)
            {
                Console.WriteLine(firstCustomer);
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }

            Console.WriteLine("#########################");

            var customerWithId1 = Customers.FirstOrDefault(c => c.Id == 1);

            if (customerWithId1 != null)
            {
                Console.WriteLine(customerWithId1);
            }
            else
            {
                Console.WriteLine("Customer with Id = 1 not found.");
            }

            Console.WriteLine("#########################");

            bool anyCustomerInQalqilya = Customers.Any(c => c.city == "Qalqilya");

            if (anyCustomerInQalqilya)
            {
                Console.WriteLine("There is at least one customer living in Qalqilya.");
            }
            else
            {
                Console.WriteLine("No customers are living in Qalqilya.");
            }

            Console.WriteLine("#########################");

            var groupedByCity = Customers.GroupBy(c => c.city);

            foreach (var group in groupedByCity)
            {
                Console.WriteLine($"City: {group.Key}");
                foreach (var customer in group)
                {
                    Console.WriteLine(customer);
                }
            }

            Console.WriteLine("#########################");
           
            var firstThreeCustomers = Customers.Take(3).ToList();

            foreach (var customer in firstThreeCustomers)
            {
                Console.WriteLine(customer);
            }

        }
    }
}
