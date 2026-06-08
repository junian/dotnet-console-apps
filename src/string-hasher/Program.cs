using System;
using System.Collections.Generic;
using System.Linq;

namespace StringHasher;

class Program
{
    static void Main(string[] args)
    {
        // We put our code here
        var algorithms = new Dictionary<string, Func<string, string>>
        {
            {nameof(Hasher.MD5).ToLower(), Hasher.MD5},
            {nameof(Hasher.SHA1).ToLower(), Hasher.SHA1},
            {nameof(Hasher.SHA256).ToLower(), Hasher.SHA256},
            {nameof(Hasher.SHA384).ToLower(), Hasher.SHA384},
            {nameof(Hasher.SHA512).ToLower(), Hasher.SHA512},
        };

        if(args.Length < 2)
        {
            Console.WriteLine("You need 2 arguments.");
            return;
        }

        if(args.Length > 2)
        {
            Console.WriteLine("Too many arguments.");
            return;
        }

        var algo = args[0].ToLower();
        var text = args[1];

        if(!algorithms.ContainsKey(algo))
        {
            Console.WriteLine($"Algorithm {algo} is unknown.");
            return;
        }

        var result = algorithms[algo].Invoke(text);

        Console.WriteLine(result);
    }
}
