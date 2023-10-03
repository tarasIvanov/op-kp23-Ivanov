using System;

class Program
{
   public static void Main(string[] args)
   {
       string path = Path.Combine(Directory.GetCurrentDirectory(), "task1.txt");

       using (var sw = new StreamWriter(path))
       {
           sw.WriteLine("Hello!!!");
           sw.WriteLine("It's my solution of lab 1");
       }

       using (var sr = new StreamReader(path))
       {
           while (!sr.EndOfStream)
           {
               Console.WriteLine(sr.ReadLine());
           }
       }
   }

}
