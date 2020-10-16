using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class ResumeRepository : Repository<int, Resume>, IResumeRepository
    {
        private readonly EMContext _emcontext;

        public ResumeRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
