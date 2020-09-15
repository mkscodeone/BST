using System;
using NewCode1.BST;
using NewCode1.Data;
using System.Linq;
using System.Collections;
namespace NewCode1
{
    class Program
    {
        static void Main()
        {
            var tree = CreateBinarySearchTreeAndPopulateWithTestContactsUsingTheirNameAsTheKey();

            var contact = tree.FindByKey("Sigourney H. Holman");
            if (!IsContactFound(contact))
            {
                PrintContactNotFound();
                return;
            }

            PrintContact(contact);
            WaitForReturnToBePressedBeforeExiting();
        }

        static Tree<string, Contact> CreateBinarySearchTreeAndPopulateWithTestContactsUsingTheirNameAsTheKey()
        {
            var tree = new Tree<string, Contact>();
            foreach (var contact in TestData.Contacts)
            {
                tree.AddNode(contact.Name, contact);
            }
            
            return tree;
        }

        static bool IsContactFound(Contact contact)
        {
            return contact != null;
        }

        static void PrintContactNotFound()
        {
            Console.WriteLine("Could not find the contact");
        }

        static void PrintContact(Contact contact)
        {
            Console.WriteLine("Id: {0} Name: {1} Company: {2}", contact.Id, contact.Name, contact.Company);
        }

        static void WaitForReturnToBePressedBeforeExiting()
        {
            Console.WriteLine("Press the Enter key to exit");
            Console.ReadLine();
        }
    }
}
