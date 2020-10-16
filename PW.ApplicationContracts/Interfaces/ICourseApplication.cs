using PW.ApplicationContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PW.ApplicationContracts.Interfaces
{
    public interface ICourseApplication
    {
        void Create(CourseViewModel command);
        void Edit(CourseViewModel command);
        void Remove(int id);
        CourseViewModel GetBy(int id);
        List<CourseViewModel> GetAll();

    }
}
