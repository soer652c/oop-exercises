public class Main
{
    public Customer
    {
        public string Name {get; set;}
        public int Id {get; set;}
        public double Balance {get; set;}

        public Customer(string name, int id, double balance)
        {
            this.Name = name;
            this.Id = id;
            this.balance = balance;
        }


    }
}
