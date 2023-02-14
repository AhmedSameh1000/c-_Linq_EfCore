public delegate void salary_change();
public class Employee
{
    public event salary_change? on_salary_chang;
    public void incress_salary()
    {
        salary += 100;
        on_salary_chang.Invoke();
    }
    public string? Name { get; set; }
    public decimal salary { get; set; }

    public override string ToString()
    {
        return $"{Name} => {salary}";
    }
}
public class Company
{
    public List<Employee> employees { get; set; } = new List<Employee>();
    public string? name { get; set; }
    public decimal pudget { get; set; }
    public void decress_budget()
    {
        this.pudget -= 100;
        Console.WriteLine($"company budjet is {pudget}");
    }
    public List<Employee> FilterEmployees(Func<Employee, bool> filter)
    {
        List<Employee> res = new List<Employee>();
        foreach (var item in employees)
        {
            if (filter(item))
            {
                res.Add(item);
            }
        }
        return res;
    }



}