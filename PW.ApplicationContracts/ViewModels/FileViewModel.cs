using System;

namespace PW.ApplicationContracts.ViewModels
{
    public class FileViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public long FileLenght { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
        public int FileTypeId { get; set; }
        public bool Status { get; set; }

    }
}
