using Days_19;
using Days_19.Models;

namespace Days_19;
    class Program
{
    static void Main(string[] args)
    {
        ContactService contactService = new ContactService();

       /*Contact contact = new Contact(0, "Aliye", "Bil", "aliye@mail.com", "1234567894", "Istanbul");
        int result = contactService.AddContact(contact);
        if (result > 0)
        {
            Console.WriteLine("Contact added successfully.");
        }
        else*/

        Console.WriteLine("--------------------");

         int resultDelete = contactService.DeleteContact(4);
        if (resultDelete > 0)
        {
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Failed to delete contact.");
        }
        Console.WriteLine("------------------");


        Contact contact = new Contact(14, "Mehmet", "Bilsin", "mehmet@mail.com", "5432223344","Adana");
        int result = contactService.UpdateContact(contact);
        if (result > 0)
        {
            Console.WriteLine("Contact updated successfully.");
        }
        else
        {
            Console.WriteLine("Failed to update contact.");
        }
        Console.WriteLine("------------------");



        List<Contact> contacts = contactService.GetAllContacts();
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
            }
        }
        Console.WriteLine("------------------");



        Contact singleContact = contactService.GetContactById(4);
        if (singleContact.Cid != null)
        {
            Console.WriteLine(singleContact.Cid + " " + singleContact.Name + " " + singleContact.Surname + " " + singleContact.Email + " " + singleContact.Phone + " " + singleContact.Address);
        }
        else
        {
            Console.WriteLine("No contact found with the given ID.");
        }
        Console.WriteLine("------------------");


        List<Contact> searchResults = contactService.SearchContact("a", 2);
        foreach (var item in searchResults)
        {
            Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
        }
        Console.WriteLine("------------------");



    }
}

