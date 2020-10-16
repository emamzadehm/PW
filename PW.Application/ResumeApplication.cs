using PW.ApplicationContracts.Interfaces;
using PW.ApplicationContracts.ViewModels;
using PW.Domain.IRepository;
using PW.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PW.Application
{
    public class ResumeApplication : IResumeApplication
    {
        private readonly IResumeRepository _irepository;

        public ResumeApplication(IResumeRepository irepository)
        {
            _irepository = irepository;
        }
        public void Create(ResumeViewModel command)
        {
            var newresume = new Resume(command.Priority, command.FromYear, command.ToYear, command.Title, command.Description);
            _irepository.Create(newresume);
            _irepository.SaveChanges();
        }

        public void Edit(ResumeViewModel command)
        {
            var selecteditem = _irepository.GetByID(command.Id);
            selecteditem.Edit(command.Priority, command.FromYear, command.ToYear, command.Title, command.Description);
            _irepository.SaveChanges();
        }

        public List<ResumeViewModel> GetAll()
        {
            var resumes = _irepository.GetAll();
            return resumes.Select(resumeslist => new ResumeViewModel
            {
                Id=resumeslist.Id,
                Priority=resumeslist.Priority,
                FromYear=resumeslist.FromYear,
                ToYear=resumeslist.ToYear,
                Title=resumeslist.Title,
                Description=resumeslist.Description,
                Status=resumeslist.Status
            }).ToList();
        }

        public void Remove(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            selecteditem.Remove();
            _irepository.SaveChanges();
        }
    }
}
