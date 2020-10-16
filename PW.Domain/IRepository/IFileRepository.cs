using _01_Framework.Infrastructure;
using PW.Domain.Models;

namespace PW.Domain.IRepository
{
    public interface IFileRepository : IRepository<int, File>
    {
    }
}
