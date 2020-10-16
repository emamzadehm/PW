using System;

namespace PW.Domain.Models
{
    public class File
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string FileName { get; private set; }
        //public string FileExtention { get; private set; }
        //public long FileLenght { get; private set; }
        public string Description { get; private set; }
        public DateTime UploadDate { get; private set; }
        public int FileTypeId { get; private set; }
        public bool Status { get; private set; }

        protected File()
        {

        }

        public File(string title, string fileName, string description, int fileTypeId)
        {
            Title = title;
            FileName = fileName;
            //FileName = new FileInfo(fileName).Name;
            //FileExtention = new FileInfo(fileName).Extension;
            //FileLenght = new FileInfo(fileName).Length;
            Description = description;
            FileTypeId = fileTypeId;
            UploadDate = DateTime.Now;
            Status = true;
        }
        public void Edit(string title, string fileName, string description, int fileTypeId)
        {
            Title = title;
            FileName = fileName;
            Description = description;
            FileTypeId = fileTypeId;
        }
        public void Remove()
        {
            Status = false;
        }
    }
}
