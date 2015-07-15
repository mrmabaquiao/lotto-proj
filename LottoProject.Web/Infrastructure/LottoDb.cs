using System.Data.Entity;
using System.Linq;
using LottoProject.Domain;

namespace LottoProject.Web.Infrastructure
{
    public class LottoDb : DbContext, ILottoDataSource
    {
         public LottoDb()
            : base("DefaultConnection")
        {
        }
        public DbSet<Draw> Draws { get; set; }

        IQueryable<Draw> ILottoDataSource.Draws
        {
            get { return Draws; }
        }
     
    }
}
