using System;
using System.Collections.Concurrent;

class Program1
{
    static void Main()
    {
        
        var con = new ConcurrentDictionary<string, int>();
        con.TryAdd("cat", 1);
        con.TryAdd("dog", 2);
              
        con.TryUpdate("cat", 200, 4);
              
        con.TryUpdate("cat", 100, 1);
              
        Console.WriteLine(con["cat"]);
    }
}