using PW.ApplicationContracts.Interfaces;
using PW.ApplicationContracts.ViewModels;
using PW.Domain.IRepository;
using PW.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PW.Application
{
    public class TestimonialApplication : ITestimonialApplication
    {
        private readonly ITestimonialRepository _irepository;

        public TestimonialApplication(ITestimonialRepository irepository)
        {
            _irepository = irepository;
        }

        public void Create(TestimonialViewModel command)
        {
            var newtestimonial = new Testimonial(command.StudentName, command.StudentImg, command.StudentEmail, command.CourseName, command.UniversityName, command.EduYear, command.Title, command.Description);
            _irepository.Create(newtestimonial);
            _irepository.SaveChanges();
        }


        public List<TestimonialViewModel> GetAll()
        {
            var Testimonials = _irepository.GetAll();
            return Testimonials.Select(Testimonialslist => new TestimonialViewModel
            {
                Id = Testimonialslist.Id,
                StudentName= Testimonialslist.StudentName,
                StudentEmail= Testimonialslist.StudentEmail,
                StudentImg= Testimonialslist.StudentImg,
                CourseName= Testimonialslist.CourseName,
                UniversityName= Testimonialslist.UniversityName,
                EduYear= Testimonialslist.EduYear,
                IsVisible= Testimonialslist.IsVisible,
                CreatedDate= Testimonialslist.CreatedDate,
                Title = Testimonialslist.Title,
                Description = Testimonialslist.Description
            }).ToList();
        }

        public TestimonialViewModel GetBy(int id)
        {
            var SelectedTestimonial = _irepository.GetByID(id);
            return new TestimonialViewModel
            {
                Id = SelectedTestimonial.Id,
                StudentName = SelectedTestimonial.StudentName,
                StudentEmail = SelectedTestimonial.StudentEmail,
                StudentImg = SelectedTestimonial.StudentImg,
                CourseName = SelectedTestimonial.CourseName,
                UniversityName = SelectedTestimonial.UniversityName,
                EduYear = SelectedTestimonial.EduYear,
                IsVisible = SelectedTestimonial.IsVisible,
                CreatedDate = SelectedTestimonial.CreatedDate,
                Title = SelectedTestimonial.Title,
                Description = SelectedTestimonial.Description
            };
        }

        public void Remove(int id)
        {
            var selectedtestimonial = _irepository.GetByID(id);
            selectedtestimonial.Remove();
            _irepository.SaveChanges();
        }

        public void ToInvisible(int id)
        {
            var selectedtestimonial = _irepository.GetByID(id);
            selectedtestimonial.ToVisible();
            _irepository.SaveChanges();
        }

        public void ToVisible(int id)
        {
            var selectedtestimonial = _irepository.GetByID(id);
            selectedtestimonial.ToInvisible();
            _irepository.SaveChanges();
        }
    }
}
