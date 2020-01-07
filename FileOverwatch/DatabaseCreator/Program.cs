using System.IO;
using Database;

namespace DatabaseCreator
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            args[0] = Directory.GetCurrentDirectory() + "/FileOverwatch.db";
#endif
            var db = new DataBase(args[0]);
            db.EnsureCreated();
        }
    }
}
