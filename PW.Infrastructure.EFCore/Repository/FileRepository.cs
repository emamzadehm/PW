using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class FileRepository : Repository<int, File>, IFileRepository
    {
        private readonly EMContext _emcontext;

        public FileRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
