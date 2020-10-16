using PW.ApplicationContracts.ViewModels;
using PW.ApplicationContracts.Interfaces;
using PW.Domain.IRepository;
using PW.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PW.Application
{
    public class MessageApplication : IMessageApplication
    {
        private readonly IMessageRepository _irepository;

        public MessageApplication(IMessageRepository irepository)
        {
            _irepository = irepository;
        }
        public void Create(MessageViewModel command)
        {
            var newmessage = new Message(command.Name, command.Email, command.Title, command.Description);
            _irepository.Create(newmessage);
            _irepository.SaveChanges();
        }


        public List<MessageViewModel> GetAll()
        {
            var messages = _irepository.GetAll();
            return messages.Select(messagelist => new MessageViewModel
            {
                Id= messagelist.Id,
                Name=messagelist.Name,
                Email = messagelist.Email,
                CreatedDate = messagelist.CreatedDate,
                Title=messagelist.Title,
                Description=messagelist.Description,
                IsEmailed=messagelist.IsEmailed,
                Status=messagelist.Status
            }).ToList();
        }

        public MessageViewModel GetBy(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            return new MessageViewModel
            {
                Id = selecteditem.Id,
                Name = selecteditem.Name,
                Email = selecteditem.Email,
                CreatedDate = selecteditem.CreatedDate,
                Title = selecteditem.Title,
                Description = selecteditem.Description,
                IsEmailed = selecteditem.IsEmailed,
                Status = selecteditem.Status
            };
        }

        public void Remove(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            selecteditem.Remove();
            _irepository.SaveChanges();
        }

        public void SendToEmail(MessageViewModel command)
        {
            var selecteditem = _irepository.GetByID(command.Id);
            selecteditem.Emailed();
            _irepository.SaveChanges();
        }
    }
}
