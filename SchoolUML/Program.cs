using System;
using System.Collections.Generic;

namespace SchoolUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Staff("Ryan", "112 Test Street", "Schooly School", 20.13));
            peopleList.Add(new Staff("Daniel", "123 Typical Boulevard", "Schooly School", 20.18));
            peopleList.Add(new Student("Rachel", "461 Sample Avenue", "Biology", 3, 2100.10));
            peopleList.Add(new Student("Jay", "614 Example Drive", "Chemistry", 2, 2800.20));
            peopleList.Add(new Student("Tony", "442 Demonstration Park", "Philosophy", 1, 1400.10));
            string input;
            int selection;
            while (true)
            {
                input = PromptUser("1: View registry\n2: Add a person to the registry\n");

                try
                {
                    selection = int.Parse(input);
                    if (selection != 1 && selection != 2)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Input error detected. Please try again.");
                    continue;
                }
                if (selection == 1)
                {
                    ViewRegistry(peopleList);
                }
                else
                {
                    RegisterPerson(peopleList);
                }
            }
        }

        public static void ViewRegistry(List<Person> peopleList)
        {
            foreach (Person person in peopleList)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public static void AddPersonToList(List<Person> peopleList)
        {
            EnterName();

        }
        public static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine().Trim();
        }

        public static void RegisterPerson(List<Person> peopleList)
        {
            int number;
            while (true)
            {
                try
                {
                    number = int.Parse(PromptUser("Register type:\nEnter 1 for staff or 2 for student\n"));
                    if (number != 1 && number != 2)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again.");
                    continue;
                }
                if (number == 1)
                {
                    RegisterStaff(peopleList);
                    break;
                }
                else
                {
                    RegisterStudent(peopleList);
                    break;
                }
            }
        }

        public static void RegisterStaff(List<Person> peopleList)
        {
            string name = EnterName();
            string address = EnterAddress();
            string school = EnterSchool();
            double pay = EnterPay();

            peopleList.Add(new Staff(name, address, school, pay));
            Console.WriteLine($"Staff member {name} added successfully.");
        }
        public static void RegisterStudent(List<Person> peopleList)
        {
            string name = EnterName();
            string address = EnterAddress();
            string program = EnterProgram();
            int year = EnterYear();
            double fee = EnterFee();
            peopleList.Add(new Student(name, address, program, year, fee));
            Console.WriteLine($"Student {name} added successfully.");
        }

        public static string EnterName()
        {
            string name;
            while (true)
            {
                name = PromptUser("Please enter a name: ");
                if (IsEmpty(name))
                {
                    Console.WriteLine("Error: name cannot be empty.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return name;
        }

        public static string EnterAddress()
        {
            string address;
            while (true)
            {
                address = PromptUser("Please enter an address: ");
                if (IsEmpty(address))
                {
                    Console.WriteLine("Error: address cannot be empty.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return address;
        }

        public static string EnterSchool()
        {
            string school;
            while (true)
            {
                school = PromptUser("Please enter a school: ");
                if (IsEmpty(school))
                {
                    Console.WriteLine("Error: school cannot be empty.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return school;
        }

        public static double EnterPay()
        {
            double pay;
            while (true)
            {
                try
                {
                    pay = double.Parse(PromptUser("Please enter a pay rate: "));
                    return pay;
                }
                catch
                {
                    Console.WriteLine("Error: please try again.");
                    continue;
                }
            }
        }

        public static string EnterProgram()
        {
            string program;
            while (true)
            {
                program = PromptUser("Please enter a program: ");
                if (IsEmpty(program))
                {
                    Console.WriteLine("Error: program cannot be empty.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return program;
        }

        public static double EnterFee()
        {
            double fee;
            while (true)
            {
                try
                {
                    fee = double.Parse(PromptUser("Please enter a fee: "));
                    return fee;
                }
                catch
                {
                    Console.WriteLine("Error: please try again.");
                    continue;
                }
            }
        }

        public static int EnterYear()
        {
            int year;
            string holder;
            while (true)
            {
                try
                {
                    holder = PromptUser("Please enter a year: ");
                    if (IsEmpty(holder))
                    {
                        throw new Exception("Input cannot be empty.");
                    }
                    year = int.Parse(holder);
                    if (year < 0)
                    {
                        throw new Exception("Input must be greater than 0.");
                    }
                    return year;
                }
                catch
                {
                    Console.WriteLine("Error: please try again.");
                    continue;
                }
            }
        }

        public static bool IsEmpty(string input)
        {
            if (input != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
