namespace login_register_postgresql.Models
{
    public class Students
    {
        
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddelName{ get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddelName} {LastName}";

        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }

        public string Gender{ get; set; }


    }
}
