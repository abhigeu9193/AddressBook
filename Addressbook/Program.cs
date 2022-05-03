// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class AddressBookSolution
{
    public class AddressBook : AddressBookBase
    {
        List<Contact> addressBook = new List<AddressBookSolution.Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),

                State = Console.ReadLine(),
                EmailAddress = Console.ReadLine(),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
                MobileNumber = Convert.ToInt64(Console.ReadLine())
            };

            addressBook.Add(address1);
        }

        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
    }

    private class Contact
    {
        public string? FirstName { get; internal set; }
        public string? LastName { get; internal set; }
        public string? Address { get; internal set; }
        public string? State { get; internal set; }
        public string? EmailAddress { get; internal set; }
        public int PostalCode { get; internal set; }
        public long MobileNumber { get; internal set; }
    }
}   
