using System;
using Bogus;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using ServiceStack.Text;
namespace task4_itransition
{
    public class Person
    {
        public string FullName { get; set; }
        public string City { get; set; }
        public string Addres { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
    }

class Program
    {
        static int Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Please enter an integer and string arguments.");
                return 1;
            }
            int n = Convert.ToInt32(args[0]);
            if (n<=0)
            {
                Console.WriteLine("Please enter an integer argument >0.");
                return 1;
            }
            string languige = args[1];
            Faker <Person> generatorPerson = getGeneratorPerson(languige);
            List<Person> persons = generatorPerson.Generate(n);
            printPersons(persons);
            return 0;
        }
        private static Faker<Person> getGeneratorPerson(string languige)
        {
            return new Faker<Person>(languige)
            .RuleFor(x => x.FullName, x => x.Name.FullName())
            .RuleFor(x => x.City, x => x.Address.City())
            .RuleFor(x => x.Addres, x => x.Address.StreetAddress())
            .RuleFor(x => x.ZipCode, x => x.Address.ZipCode())
            .RuleFor(x => x.Phone, x => x.Phone.PhoneNumberFormat());
        }
        private static void printPersons(List<Person> persons)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var str = CsvSerializer.SerializeToCsv<Person>(persons);
            Console.WriteLine(str.Substring(36));
        }
    }
}
