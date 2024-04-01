using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class FullTimeEmployee:Working 
    {
       

        public int VacationDays { get; set; }

        public FullTimeEmployee(int id, string name, int salary,int vacationdays) : base(id, name, salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
            VacationDays = vacationdays;
            
        }

        public override void displayInfo()
        {
            Console.WriteLine($"Tutduqu yer:{Id}\nIscinin adi:{Name}\nIscinin aldiqi emek haqqi:{Salary}\nMezuniyyet gunleri:{VacationDays}");
        }

    }
}
