using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using System.Net;

namespace myApp
{

    class Program 
    {
        public static void Main(string[] args)
        {
            var webhost = WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseKestrel(options =>
            {
                options.Listen(IPAddress.Any, 5000);
            })
            .Build();
            webhost.Run();
        }
    }

    
/*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new MyContext())
            {
                context.Database.EnsureCreated();
            }

            using (var context = new MyContext())
            {
                // add
                context.Posts.Add(new Post { Title = "coucou" });
                context.Posts.Add(new Post { Title = "hop" });
                context.SaveChanges();
            }
        }
    }
*/
}
