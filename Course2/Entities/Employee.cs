using System;
using System.Collections.Generic;
using System.Text;

namespace Course2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours  { get; set; }
        public  double ValuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour) // Construtor com 3 argumentos
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() // Função com virtual
        {
            return Hours * ValuePerHour;
        }
            
    }

}
