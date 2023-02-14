
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {3};

        var result = arr.Single(x=>x>4);
        Console.WriteLine(result); 
    }
}