using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnd_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            Manager manager
                = new Manager(); 
            SeniorManager seniorManager = new SeniorManager();
            seniorManager.calSalary();
            
        }
    }
   public abstract class Employee
    {
        public  void maleDressCode()
        {
            Console.WriteLine("Male Wear Formal");
        }
        public void fmaleDressCode() { Console.WriteLine("Female Wear only Sari"); }
        public abstract void salaryCalculation();
    }
    public class Manager : Employee
    {
        public override void salaryCalculation()
        {
            Console.WriteLine("This is the managerSalary");
        }
    }
    public interface IEmployee {
        void calSalary();
    }
    public class SeniorManager : IEmployee
    {
        public void calSalary()
        {
            Console.WriteLine("This is Senior Manager Salary");
        }
    }



}
