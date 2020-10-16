using _01_Framework.Infrastructure;
using PW.Domain.Models;

namespace PW.Domain.IRepository
{
    public interface IResumeRepository : IRepository<int, Resume>
    {
    }
}
