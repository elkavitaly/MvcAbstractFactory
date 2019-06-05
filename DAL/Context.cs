using System.Data.Entity;
using DAL.Model;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<ArticleIdentity> ArticleIdentities { get; set; }
        public DbSet<NewspaperIdentity> NewspaperIdentities { get; set; }

        public Context() : base("NewsDatabase")
        {
        }
    }
}