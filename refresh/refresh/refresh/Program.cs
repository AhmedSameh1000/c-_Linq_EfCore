using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee { id = 1, salary = 300, YearOfExp = 4,name="ahmed"};
        Employee employee2 = new Employee {id=2, salary = 200, YearOfExp = 2, name = "ali" };
        Employee employee3 = new Employee { id = 3, salary = 1000, YearOfExp = 1, name = "sameh" };
        Employee employee4 = new Employee { id = 4,  salary = 700, YearOfExp = 0, name = "sara" };
        Employee employee5 = new Employee {id=5, salary = 500, YearOfExp = 7, name = "said" };
        List<Employee> All_emp = new List<Employee> { employee1, employee2, employee3, employee4, employee5 };      
        
        department department1 = new department() { Dnom=10};
        department department2 = new department() { Dnom = 11 };
        department1.emps.Add(employee1.id , employee1);
        department1.emps.Add(employee2.id , employee2);
        department1.emps.Add(employee3.id , employee3);
        department1.emps.Add(employee4.id , employee4);
        department1.emps.Add(employee5.id , employee5);

        Console.WriteLine("department 1 before change employee");
        Console.WriteLine("___________________________________");
        foreach (var item in department1.emps)
        {
            Console.WriteLine(item);
        }
       
        employee1.onchange += department1.decress;
        employee1.onincress += department2.Increses_employe;

        employee1.change_department(1);    
        department2.Increses_employe(employee1);   
        
        Console.WriteLine("___________________________________");
        Console.WriteLine("department 1 after change employee");
        foreach (var item in department1.emps)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("________________________________");
        Console.WriteLine("department 2 it has changed employee");
        foreach (var item in department2.Emploies)
        {
            Console.WriteLine(item);
        }
        
    }
}
delegate void change_dep(int dep_id);
delegate void Incress(Employee employee);
class Employee : IComparable<Employee>
{
    public event change_dep onchange;
    public event Incress onincress;
    public int id { get; set; }
    public string name { get; set; }
    public int salary { get; set; }
    public int YearOfExp { get; set; }
    public int department { get; set; }
    department departments = new department();
    public int CompareTo(Employee? other)
    {
        return YearOfExp.CompareTo(other.YearOfExp);
    }

    public void Increses_employe(Employee employee)
    {
        onincress(employee);      
    }
    public void change_department(int department)
    {
        this.department = department;
        Console.WriteLine("your employee changed to another department");     
        onchange(department);
    }
    public override string ToString()
    {
        return $"{id}>>{salary}>>{YearOfExp}>>{name}>>{department}";
    }
}
class Employee_comparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.salary.CompareTo(y.salary);
    }
}
class department 
{
    public Dictionary<int,Employee> emps  = new Dictionary<int, Employee>();
    public int Dnom { get; set; }
    public List<Employee> Emploies = new List<Employee>();

    public Employee this[int index]
    {
        get
        {
            foreach (var item in emps.ToList())
            {
                if (item.Key == index)
                {
                    return item.Value;
                }
            }
            return null;
        }

        set
        {
            emps.Add(index, value);
        }
    }

    public void Increses_employe(Employee employee)
    {
        Emploies.Add(employee);
    }

    public void decress(int department)
    {
        emps.Remove(department);
    }

}

