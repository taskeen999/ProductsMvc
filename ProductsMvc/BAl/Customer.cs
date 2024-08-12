namespace ProductsMvc.BAl
{
    public class Customer
    {
        public long id { get; set; }
        public string FistName { get; set; } = string.Empty;  
        public string LastName { get; set; } = string.Empty;  
        public string Gender { get;set; } = string.Empty;   
        public string Address { get; set; }= string.Empty;
         public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool IsActive { get; set; }  = false;
        public string image { get; set; } = string.Empty;
    }
}
