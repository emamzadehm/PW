using PW.ApplicationContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PW.ApplicationContracts.Interfaces
{
    public interface IFileApplication
    {
        void Create(FileViewModel command);
        void Edit(FileViewModel command);
        FileViewModel GetBy(int id);
        List<FileViewModel> GetAll();
        void Remove(int id);

    }
}
