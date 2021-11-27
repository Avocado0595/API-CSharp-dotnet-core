using demo05.Models;
using Microsoft.EntityFrameworkCore;

namespace demo05.EF
{
    public class MemberContext: DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}