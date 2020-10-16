using PW.ApplicationContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PW.ApplicationContracts.Interfaces
{
    public interface IResumeApplication

    { 
        void Create(ResumeViewModel command);
        void Edit(ResumeViewModel command);
        List<ResumeViewModel> GetAll();
        void Remove(int id);

    }
}
