using PW.ApplicationContracts.ViewModels;
using PW.ApplicationContracts.Interfaces;
using PW.Domain.IRepository;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PW.Application
{
    public class FileApplication : IFileApplication
    {
        private readonly IFileRepository _irepository;

        public FileApplication(IFileRepository irepository)
        {
            _irepository = irepository;
        }
        public void Create(FileViewModel command)
        {
            var newfile = new Domain.Models.File(command.Title, command.FileExtention, command.Description, command.FileTypeId);
            _irepository.Create(newfile);
            _irepository.SaveChanges();
        }

        public void Edit(FileViewModel command)
        {
            var selecteditem = _irepository.GetByID(command.Id);
            selecteditem.Edit(command.Title, command.FileName, command.Description, command.FileTypeId);
            _irepository.SaveChanges();
        }

        public List<FileViewModel> GetAll()
        {
            var files = _irepository.GetAll();
            return files.Select(filelist=> new FileViewModel
            {
                Id=filelist.Id,
                FileName = filelist.FileName,
                Description=filelist.Description,
                FileTypeId=filelist.FileTypeId,
                Title= filelist.Title,
                UploadDate=filelist.UploadDate,
                Status=filelist.Status,
                FileExtention = new FileInfo(filelist.FileName).Extension,
                FileLenght= new FileInfo(filelist.FileName).Length
            }).ToList();
        }

        public FileViewModel GetBy(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            return new FileViewModel { 
                Id=selecteditem.Id,
                FileName = selecteditem.FileName,
                Description = selecteditem.Description,
                FileTypeId = selecteditem.FileTypeId,
                Title = selecteditem.Title,
                UploadDate = selecteditem.UploadDate,
                Status = selecteditem.Status,
                FileExtention = new FileInfo(selecteditem.FileName).Extension,
                FileLenght = new FileInfo(selecteditem.FileName).Length
            };
        }

        public void Remove(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            selecteditem.Remove();
            _irepository.SaveChanges();
        }
    }
}
