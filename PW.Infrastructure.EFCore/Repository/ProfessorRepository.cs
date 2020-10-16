using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class ProfessorRepository : Repository<int, Professor>, IProfessorRepository
    {
        private readonly EMContext _emcontext;

        public ProfessorRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
