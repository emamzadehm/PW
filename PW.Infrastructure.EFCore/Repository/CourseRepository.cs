using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class CourseRepository : Repository<int, Course> , ICourseRepository
    {
        private readonly EMContext _emcontext;

        public CourseRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
