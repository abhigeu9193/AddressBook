using static AddressBookSolution;

class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
        AddressBook addressBook = new AddressBook();
        addressBook.Display();
        Console.WriteLine("Enter the First Name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        Console.WriteLine("Display after Deleting information ");
        addressBook.DeletingContactINAddressBook(name);
    }
}