using System;
using System.Collections;


public class Program
{
    static void Main(string[] args)
    {
        #region EXample_1
        //Point point1 = new Point(3, 2);
        //Point point2 = new Point(2, 3);
        //Point point3 = new Point(2, 2);
        //Point point4 = new Point(0, 2);
        //Point point5 = new Point(9, 2);
        //Point[] All_point = new Point[] { point1, point2, point3, point4, point5 };
        //Array.Sort(All_point);
        //Point.print(All_point);
        //var obj = point1.Clone();
        //Console.WriteLine(ReferenceEquals(obj, point1));
        #endregion
        #region Example_2
        Employee employee = new Employee("ahmed", 22, 300);
      //  employee.show_payment();
        Trianee trianee = new Trianee("ahmed", 22, 700);
       // trianee.show_payment();

        Employee e1 = new Employee("mohammed", 2, 400);
        Employee e2 = new Employee("said", 4, 400);
        Employee e3 = new Employee("ahmed", 8, 400);
        Employee e4 = new Employee("ali", 60, 400);
        Employee e5 = new Employee("aballh", 7, 400);
        Employee[] arr_emp = new Employee[] { e1, e2, e3, e4, e5 };

        Array.Sort(arr_emp, new Emp_comparer());
        Employee.print(arr_emp);
        #endregion
        #region Example_3
        //int[] book_num = new int[5] { 4, 0, 2, 1, 3 };
        //string[] book_name = new string[5]
        //{
        //"math","jolojia",
        //"arabic","English","franch"
        //};

        //phone_book phone_Book = new phone_book(book_num, book_name);

        //Console.WriteLine(book_name[book_num[1]]);
        //Console.WriteLine(book_num[0]);
        #endregion
    }
}

class Point : IComparable<Point>, ICloneable
{
    int x;
    int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public static void print(Point[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public object Clone()
    {
        var point = (Point)MemberwiseClone();
        point.x = x;
        point.y = y;
        return point;
    }

    public int CompareTo(Point? other)
    {
        if (this.x > other.x) return 1;
        else if (this.x < other.x) return -1;
        else if (this.y > other.y) return 1;
        else if (this.y < other.y) return -1;
        else return 0;
    }

    public override string ToString()
    {
        return $"{x}>>{y}";
    }
}
//-----------------------------------------------
interface Ipayable
{
    public int MyProperty { get; set; }

    public  void show_payment();
}
class Employee:Ipayable
{
    
    public string name;
    public int age;
    public int salary;


    public Employee(string name,int age,int salary)
    {
        this.name = name;
        this.age = age;
        this.salary=salary;
    }

    public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    
    public void show_payment()
    {
        Console.WriteLine($"salary of {typeof(Employee)} {salary}");
    }

    public static void print(Employee[]arr )
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public override string ToString()
    {
        return $"{name} >> {age}  >> {salary}";
    }  
}
class Emp_comparer : IComparer<Employee>
{
    public int Compare(Employee? emp_1, Employee? emp_2)
    {
        if (emp_1.name.Length==emp_2.name.Length) return 0;
        else if(emp_1.name.Length > emp_2.name.Length) return -1;
        else return 1;      
    }
}
class Trianee : Employee, Ipayable
{
    public Trianee(string name, int age, int salary) : base(name, age, salary)
    {

    }
    public Trianee MyProperty { get; set; }

    public void show_payment()
    {
        Console.WriteLine($"salary of {typeof(Trianee)} {salary}");
    }
}
class trin_comparer : IComparer<Trianee>
{
    public int Compare(Trianee? triner_1, Trianee? triner_2)
    {
        if (triner_1.age == triner_2.age) return 0;
        else if (triner_1.age > triner_2.age) return -1;
        else return 1;
    }
}

class phone_book 
{
    public int[] book_nom { get; set; }
    public string[] book_name { set; get; }

    public phone_book(int[] book_no, string[]name)
    {
        this.book_nom = book_no;
        this.book_name = name;
    }
    public string this[int index]
    {
        get { return book_name[index]; }
        set { book_name[index] = value; } 
    }
    public int this[string name]
    {
        get 
        {
            int num=0;
            for (int i = 0; i < book_name.Length; i++)
            {
                if (name == book_name[i])
                {
                    num = book_nom[i];
                    break;
                }
            }
            return book_nom[num];      
        }
        set 
        {
            for (int i = 0; i < book_nom.Length; i++)
            {
                book_nom[i] = value;
            }
        }
    }


}
