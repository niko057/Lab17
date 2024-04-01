using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Working
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public Working(int id,string name,int salary)
        {
            Id= id;
            Name= name;
            Salary= salary;
           

        }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Tutduqu yer:{Id}\nIscinin adi:{Name}\nIscinin aldiqi emek haqqi:{Salary}");
        }
    }
}
