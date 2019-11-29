using System;
using Database.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public partial class DataBase : DbContext
    {
        public DataBase()
            //: base("name=ApiDb")
        {
        }
        
        public virtual DbSet<Employee> Customers { get; set; }
        //public virtual DbSet<>
    }
}
