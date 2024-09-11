namespace Task
{
    internal class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public decimal phone { get; set; }

        public string city { get; set; }

        public List<Product> PurchasedProducts { get; set; } = new List<Product>();

        public override string ToString()
        {
            return $"Id : {Id}  Name: {Name} Email: {Email} phone: {phone} city: {city}";
        }
    }
}
