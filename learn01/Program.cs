using System;
using Microsoft.EntityFrameworkCore;
namespace Learn01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new SqliteContext()) {
                context.Users.Add(new User(){ Name="yotsuki",Password="123456"});
                var result = context.SaveChanges();
                if (result > 0) {
                    Console.WriteLine("1 row installed.");
                }else {
                    Console.WriteLine("install failed.");
                }
            }
        }
    }
}
