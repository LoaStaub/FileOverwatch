using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DatabaseWindows;

namespace ExecutableWindows.Classes
{
    class CleanUp
    {
        public static async Task Perform()
        {
            var db = new DataBase();
            var emailToGroup = await db.EmailToGroupNode.Where(d => !d.Deleted && (d.Email.Deleted || d.Group.Deleted)).ToListAsync();
            var emailToMember = await db.EmailToMemberNode.Where(d => !d.Deleted && (d.Email.Deleted || d.Member.Deleted)).ToListAsync();
            var emailToOrganization = await db.EmailToOrganizationNode.Where(d => !d.Deleted && (d.Email.Deleted || d.Organization.Deleted)).ToListAsync();
            //var excelToOverhead = await db.ExcelToOverheadNode.Where();
        }
    }
}
