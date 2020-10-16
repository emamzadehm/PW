using PW.ApplicationContracts.ViewModels;
using PW.ApplicationContracts.Interfaces;
using PW.Domain.IRepository;


namespace PW.Application
{
    public class ProfessorApplication : IProfessorApplication
    {
        private readonly IProfessorRepository _irepository;

        public ProfessorApplication(IProfessorRepository irepository)
        {
            _irepository = irepository;
        }

        public void Edit(ProfessorViewModel command)
        {
            var selecteditem = _irepository.GetByID(command.Id);
            selecteditem.Edit(command.Name, command.Family, command.Level, command.ImgAddress, command.Tel, command.Email, command.Address, command.LinkedInURL, command.MapAddress);
            _irepository.SaveChanges();
        }

        public ProfessorViewModel GetBy(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            return new ProfessorViewModel
            {
                Id = selecteditem.Id,
                Name = selecteditem.Name,
                Family = selecteditem.Family,
                Email=selecteditem.Email,
                Tel=selecteditem.Tel,
                Address=selecteditem.Address,
                Level= selecteditem.Level,
                ImgAddress= selecteditem.ImgAddress,
                LinkedInURL=selecteditem.LinkedInURL,
                MapAddress=selecteditem.MapAddress
            };
        }
    }
}
