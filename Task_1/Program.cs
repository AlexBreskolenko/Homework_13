//Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.
//На примере этого текста, выясните, какие будут различия между этими коллекциями.

using System.IO;
using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        
        string path = "C:\\Users\\abres\\Desktop\\Text1.txt";

        var watch_1 = Stopwatch.StartNew();
        var list = new List<string>();
        using (StreamReader read = new StreamReader(path))
        {
            list.Add(read.ReadToEnd());
        }
        Console.WriteLine($"Время затраченное на вставку в коллекцию List : {watch_1.Elapsed.TotalMilliseconds} мс.");
        watch_1.Stop();

        var watch_2 = Stopwatch.StartNew();
        var linkedList = new LinkedList<string>();
        using (StreamReader linkedRead = new StreamReader(path))
        {
            linkedList.AddFirst(linkedRead.ReadToEnd());
        }
        Console.WriteLine($"Время затраченное на вставку в коллекцию LinkedList : {watch_2.Elapsed.TotalMilliseconds} мс.");
        watch_2.Stop();
    }
}

