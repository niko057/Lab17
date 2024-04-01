
namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Working working = new Working(1,"Nicat",500);

            working.displayInfo();
            
            Working emp = new FullTimeEmployee(2,"Pasha",800,25);

            emp.displayInfo();

            Working empl = new PartTimeEmployee(3,"Ali",250,18);

            empl.displayInfo();
            
        }
    }
}