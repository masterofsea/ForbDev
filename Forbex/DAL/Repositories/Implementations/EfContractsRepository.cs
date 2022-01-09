using System.Linq;
using System.Threading.Tasks;
using Forbex.DAL.Data;
using Forbex.DAL.DbContexts;
using Forbex.DAL.Repositories.Contracts;

namespace Forbex.DAL.Repositories.Implementations
{
    public class EfContractsRepository : IContractsRepository
    {
        private ForbexDbContext Context { get; }
        public IQueryable<Contract> Contracts => Context.Contracts;
        
        public EfContractsRepository(ForbexDbContext context)
        {
            Context = context;
        }

        public Task GetContractById(int id)
        {
            throw new System.NotImplementedException();
        }
        
        
    }
}