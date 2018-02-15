using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace myApp
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly MyContext _context;

        public HelloController(MyContext context)
        {
            _context = context;
            /*
            if (_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }*/
        }   

        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new List<string>{"hello", "world"};
        }
    
    }
}