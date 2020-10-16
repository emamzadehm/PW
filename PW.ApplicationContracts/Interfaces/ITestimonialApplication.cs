using PW.ApplicationContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PW.ApplicationContracts.Interfaces
{
    public interface ITestimonialApplication
    {
        void Create(TestimonialViewModel command);
        TestimonialViewModel GetBy(int id);
        List<TestimonialViewModel> GetAll();
        void ToVisible(int id);
        void ToInvisible(int id);
        void Remove(int id);

    }
}
