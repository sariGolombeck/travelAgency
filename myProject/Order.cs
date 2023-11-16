namespace myProject
{
    public class Order

    {
        public Order()
        {

        }
        public Order(int id, string name,string addrass,string phone, string email)
        {
                this.Id = id;
            this.Name = name;
            this.Addrass = addrass;
              //this.Tour = tour;
            this.Email= email;
            this.PhoneNumber = phone;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addrass { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
         public Tour Tour { get; set; }
    }
}
