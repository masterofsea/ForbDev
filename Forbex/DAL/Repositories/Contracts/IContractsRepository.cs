using System.Linq;
using System.Threading.Tasks;
using Forbex.DAL.Data;

namespace Forbex.DAL.Repositories.Contracts
{
    public interface IContractsRepository
    {
        IQueryable<Contract> Contracts { get; }
        Task GetContractById(int id);
    }
}