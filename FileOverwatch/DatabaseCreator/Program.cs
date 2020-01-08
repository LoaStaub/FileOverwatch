using System;
using System.IO;
using Database;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCreator
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var path = Directory.GetCurrentDirectory() + @"\FileOverwatch.db";
#else
            var path = args[0];
#endif
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=" + path);
            var db = new DataBase(optionsBuilder.Options);
            db.Database.EnsureCreated();
        }
    }
}
