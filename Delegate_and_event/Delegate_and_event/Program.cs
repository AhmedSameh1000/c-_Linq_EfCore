using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        #region MyRegion
        //Zoo zoo = new Zoo();
        //Animals animal1 = new Animals(9);
        //Animals animal2 = new Animals(4);
        //Animals animal3 = new Animals(3);
        //Animals[] arr = { animal1, animal2, animal3 };
        //animal1.on_die += zoo.die;
        //animal2.on_die += zoo.die;
        //animal3.on_die += zoo.die;
        //zoo.animalss.AddRange(arr);

        //animal1.die();
        //foreach (var item in zoo.animalss)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region MyRegion
        Employee employee1 = new Employee { Name = "ahmed", salary = 100 };
        Employee employee2 = new Employee { Name = "ali", salary = 200 };
        Employee employee3 = new Employee { Name = "sara", salary = 300 };
        Employee employee4 = new Employee { Name = "sameh", salary = 400 };
        Employee employee5 = new Employee { Name = "said", salary = 500 };

        Employee[] arr = new Employee[] { employee1, employee2, employee3, employee4, employee5 };

        Company company = new Company();

        company.pudget = 1000;
        company.employees.AddRange(arr);

        employee1.on_salary_chang += company.decress_budget;

        employee1.incress_salary();
        var emps = company.FilterEmployees(x => x.salary > 200);

        foreach (var item in emps)
        {
            Console.WriteLine(item);
        }
        #endregion
    }
}
public delegate void is_die_handler(Animals animals);
public class Zoo
{
    public List<Animals> animalss = new List<Animals>();
    public void Add(Animals animals)
    {
        animalss.Add(animals);
    }

    public void die(Animals animals)
    {
       animalss.Remove(animals);
    }  
 

}
public class Animals
{
    public event is_die_handler on_die;
    public void die()
    {    
        if (on_die != null)
        {
            on_die(this);
        }
    }
    public Animals()
    {

    }
    public Animals(int age)
    {
        this.age = age;
         
    }

    public int age { get; set; }

}
