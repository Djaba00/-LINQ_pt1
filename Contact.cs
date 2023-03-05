namespace PhoneBook
{
    public class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
        public string Name {get;  set; }
        public string LastName {get;  set; }
        public string Email {get; set; }
        public long PhoneNumber {get; set; }
    }
}