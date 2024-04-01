using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class PartTimeEmployee : Working
    {
       

        public int HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, int salary,int hoursworked) : base(id, name, salary)
        {
            Id= id;
            Name= name;
            Salary= salary;
            HoursWorked= hoursworked;

        }
        public override void displayInfo()
        {
            Console.WriteLine($"Tutduqu yer:{Id}\nIscinin adi:{Name}\nIscinin aldiqi emek haqqi:{Salary}\nIslediyi saatlar:{HoursWorked}");
        }

    }
}
