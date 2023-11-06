using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5.Models
{
    public class Keeper
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        public int YearOfEmployment { get; set; }


        public Keeper(string name, string surname, string patronymic, string address, DateOnly birthday, int yearOfEmployment)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Address = address;
            Birthday = birthday;
            YearOfEmployment = yearOfEmployment;
        }

        public Keeper(string text)
        {
            var parts = text.Split(", ");
            Name = parts[0];
            Surname = parts[1];
            Patronymic = parts[2];
            Address = parts[3];
            Birthday = DateOnly.Parse(parts[4]);
            YearOfEmployment = int.Parse(parts[5]);
        }

        public override string ToString() => $"{Name}, {Surname}, {Patronymic}, {Address}, {Birthday}, {YearOfEmployment}";


        public static Keeper GenerateRandomKeeper()
        {
            Random random = new Random();

            string[] names = { "John", "Michael", "Robert", "Daniel", "James", "William" };
            string[] surnames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis" };
            string[] patronymics = { "Alexandrovich", "Dmitrievich", "Ivanovich", "Nikolaevich", "Sergeyevich", "Vladimirovich" };
            string[] addresses = { "123 Main St", "456 Elm St", "789 Oak St", "101 Maple Ave", "111 Pine St" };
            int randomNameIndex = random.Next(names.Length);
            int randomSurnameIndex = random.Next(surnames.Length);
            int randomPatronymicIndex = random.Next(patronymics.Length);
            int randomAddressIndex = random.Next(addresses.Length);
            string name = names[randomNameIndex];
            string surname = surnames[randomSurnameIndex];
            string patronymic = patronymics[randomPatronymicIndex];
            string address = addresses[randomAddressIndex];
            DateOnly birthday = new DateOnly(random.Next(1950, 2005), random.Next(1, 13), random.Next(1, 29)); // Adjust the date range as needed
            int yearOfEmployment = random.Next(2000, DateTime.Now.Year + 1);

            Keeper randomKeeper = new Keeper(name, surname, patronymic, address, birthday, yearOfEmployment);
            return randomKeeper;
        }

        public static List<Keeper> GetKeepers(string filePath)
        {
            var lines = FileHandler.ReadFromTextFile(filePath);
            var keepers = new List<Keeper>();
            foreach (var line in lines)
            {
                keepers.Add(new Keeper(line));
            }
            return keepers;
        }
    }
}
