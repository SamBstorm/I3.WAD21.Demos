using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace I3.WAD21.Demos.LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact { Nom = "Legrain", Prenom="Samuel", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Adrien", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Corentin", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Aurore", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Philippe", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Françoise", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Leon", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987},
                new Contact { Nom = "Legrain", Prenom="Monique", Email = "samuel.legrain@bstorm.be", AnneeDeNaissance = 1987}
            };
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{contact.Nom} {contact.Prenom}");
            }
            ArrayList MyArrayList = new ArrayList(contacts.ToArray());
            MyArrayList.Add(5);
            foreach (object item in MyArrayList)
            {
                Console.WriteLine($"{item.GetType()}");
            }
            IEnumerable<Contact> contactList = MyArrayList.OfType<Contact>();
            foreach (Contact c in contactList)
            {
                Console.WriteLine($"{c.Nom} {c.Prenom}");
            }
        }
    }

    public class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int AnneeDeNaissance { get; set; }
    }
}
