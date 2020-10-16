using PW.ApplicationContracts.ViewModels;
using System.Collections.Generic;

namespace PW.ApplicationContracts.Interfaces
{
    public interface IMessageApplication
    {
        void Create(MessageViewModel command);
        MessageViewModel GetBy(int id);
        List<MessageViewModel> GetAll();
        void SendToEmail(MessageViewModel command);
        void Remove(int id);

    }
}
