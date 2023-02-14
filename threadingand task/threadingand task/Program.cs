using System.Net;

public class Program
{
    static void Main(string[] args)
    {

        //print_Sum_async(x => x % 2 == 0, "even");
        //print_Sum_async(x => x == x, "all");
        //print_Sum_async(x => x % 2 != 0, "odd");
        ////////////////////////////////////////////////////
        //int[] array =
        //    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
        //    20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        //print_arr_async(0, 15, array);
        //print_arr_async(15, 25, array);
        //print_arr_async(25, 36, array);
        // DownloadFile(@"https://www.youtube.com/watch?v=l-RXsncIYfc");
        DownloadFile1(@"https://www.youtube.com/watch?v=l-RXsncIYfc");


    }
    public static async void print_Sum_async(Predicate<int> predicate, string type)
    {
        int sum = 0;
        for (int i = 0; i < 10000; i++)
        {
            if (predicate(i))
            {
                sum += i;
            }
        }
        int res = await Task.Run(() => sum);
        Console.WriteLine($"{res}>> {type}");
    } 
    public static async void print_arr_async(int start,int end, int[]arr)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += i;
        }
        int result = await Task.Run(() => sum);
        Console.WriteLine(result);
    }


    public static void  DownloadFile(string url)
    {    
        Console.WriteLine("Worker thread started: {0}", url);
        WebClient client = new WebClient();
        string path = @"C:\Users\Ahmed\Desktop\path\video.MP4";
        client.DownloadFileAsync(new Uri(url), path);
        Console.WriteLine("Worker thread finished: {0}", url);
    }
    static void DownloadFile1(string url)
    {
        Console.WriteLine("Worker thread started: {0}", url);

        WebClient client = new WebClient();      
        client.DownloadFileAsync(new Uri(url), @"C:\Users\Ahmed\Desktop\path\video.MP3");

        Console.WriteLine("Worker thread finished: {0}", url);
    }
}
   
