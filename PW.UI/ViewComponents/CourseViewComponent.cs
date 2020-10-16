
using Microsoft.AspNetCore.Mvc;
using PW.ApplicationContracts.Interfaces;

namespace Emamzadeh.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly ICourseApplication _icourseapplication;

        public CourseViewComponent(ICourseApplication icourseapplication)
        {
            _icourseapplication = icourseapplication;
        }

        public IViewComponentResult Invoke()
        {
            var courselist = _icourseapplication.GetAll();
            return View("_Courses", courselist);
        }
    }
}
