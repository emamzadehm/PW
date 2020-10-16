using _01_Framework.Infrastructure;
using PW.Domain.IRepository;
using PW.Domain.Models;

namespace PW.Infrastructure.EFCore.Repository
{
    public class MessageRepository : Repository<int, Message>, IMessageRepository
    {
        private readonly EMContext _emcontext;

        public MessageRepository(EMContext emcontext) : base(emcontext)
        {
            _emcontext = emcontext;
        }
    }
}
