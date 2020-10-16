using PW.ApplicationContracts.ViewModels;
using PW.ApplicationContracts.Interfaces;
using PW.Domain.IRepository;
using PW.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PW.Application
{
    public class CourseApplication : ICourseApplication
    {
        private readonly ICourseRepository _irepository;

        public CourseApplication(ICourseRepository irepository)
        {
            _irepository = irepository;
        }

        public void Create(CourseViewModel command)
        {
            var newcourse = new Course(command.Title, command.Description);
            _irepository.Create(newcourse);
            _irepository.SaveChanges();
        }

        public void Edit(CourseViewModel command)
        {
            var selectedcourse = _irepository.GetByID(command.Id);
            selectedcourse.Edit(command.Title, command.Description);
            _irepository.SaveChanges();

        }

        public List<CourseViewModel> GetAll()
        {
            var Courses = _irepository.GetAll();
            return Courses.Select(courselist => new CourseViewModel
            {
                Id = courselist.Id,
                Title=courselist.Title,
                Description=courselist.Description
            }).ToList();
        }

        public CourseViewModel GetBy(int id)
        {
            var selecteditem = _irepository.GetByID(id);
            return new CourseViewModel
            {
                Id = selecteditem.Id,
                Title = selecteditem.Title,
                Description = selecteditem.Description
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
