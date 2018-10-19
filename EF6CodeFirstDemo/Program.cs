using TipsterData;
using System;

namespace TipsterFootballApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new TipsterDbContext())
            {
                //var student = new Student() { StudentName = "Bill" };

                //ctx.Students.Add(student);
                //ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}