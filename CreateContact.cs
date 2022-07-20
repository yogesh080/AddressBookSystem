﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContact
    {
        public List<Person> People = new List<Person>();

        //This method will check if the Address Book is empty or not.
        public void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }



        // UC-2 This method will Add the Person Contact.
        
        public void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Write Your Address, Enter Area/Colony Name: ");
            string[] addresses = new string[4];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter CityName: ");
            addresses[1] = Console.ReadLine();
            Console.Write("Enter State: ");
            addresses[2] = Console.ReadLine();
            Console.Write("Enter ZipCode: ");
            addresses[3] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }


        //This Method will print the Peron details.
        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: Area " + person.Addresses[0]);
            Console.WriteLine(" City: " + person.Addresses[1]);
            Console.WriteLine(" State: " + person.Addresses[2]);
            Console.WriteLine(" ZipCOde: " + person.Addresses[3]);
            Console.WriteLine("-------------------------------------------");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Addresses { get; set; }
    }
}
