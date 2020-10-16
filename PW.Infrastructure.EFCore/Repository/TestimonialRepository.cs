using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class TestimonialRepository : Repository<int, Testimonial>, ITestimonialRepository
    {
        private readonly EMContext _emcontext;

        public TestimonialRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
