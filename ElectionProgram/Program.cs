using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ElectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter file full path: ");
            string Path = Console.ReadLine();
            try {
                using (StreamReader sr = File.OpenText(Path))
                {
                    Dictionary<string, int> count = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(";");
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);

                        
                        if (count.ContainsKey(candidate))
                        {

                            count[candidate] += votes;

                        }
                        else
                        {
                            count[candidate] = votes;
                        }

                    }
                    foreach (var c in count)
                    {
                        Console.WriteLine(c.Key + ": " + c.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
