using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseStandard.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseStandard.Functions
{
    public class Get
    {
        public static async Task<List<Organization>> Organizations()
        {
            var db = new DataBase();
            return await db.Organizations.Where(d => !d.Deleted).ToListAsync();
        }
    }
}
