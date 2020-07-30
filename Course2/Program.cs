using System;
using System.Collections.Generic;
using Course2.Entities;
using System.Globalization;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();


            Console.Write("Enter the number of employees ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour is: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Addicional charge: ");
                    double addicinalCharge = double.Parse(Console.ReadLine());
                    lista.Add(new OutsourcedEmployee(name, hours, valuePerHour, addicinalCharge));

                }
                else
                {
                    lista.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Payment: ");
            foreach(Employee emp in lista)
            {
                Console.WriteLine(emp.Name+" - R$ "+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
