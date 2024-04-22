using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDos.Models;

namespace ToDos.Data
{
    //DbContext is a class provided by Entity Framework Core for managing database connections and performing CRUD operations.
    public class ToDosContext : DbContext
    {
        //Contructor's ToDosContext
        public ToDosContext (DbContextOptions<ToDosContext> options)
            //It takes an instance of DbContextOptions<ToDosContext>
            : base(options)
        {
        }
        //DbSet<T> is a property of DbContext
        //ToDo.Models.ToDo specifies the type of entity that will be stored in this DbSet
        public DbSet<ToDos.Models.ToDo> ToDo { get; set; } = default!;
    }
}
