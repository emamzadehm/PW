using PW.ApplicationContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PW.ApplicationContracts.Interfaces
{
    public interface IProfessorApplication
    {
        void Edit(ProfessorViewModel command);   
        ProfessorViewModel GetBy(int id);

    }
}
