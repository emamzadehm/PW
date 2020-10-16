using Microsoft.AspNetCore.Mvc;
using PW.ApplicationContracts.Interfaces;

namespace Emamzadeh.ViewComponents
{
    public class TestimonialsViewComponent : ViewComponent
    {
        private readonly ITestimonialApplication _itestimonialapplication;

        public TestimonialsViewComponent(ITestimonialApplication itestimonialapplication)
        {
            _itestimonialapplication = itestimonialapplication;
        }

        public IViewComponentResult Invoke()
        {
            var testimonialslist = _itestimonialapplication.GetAll();
            return View("_Testimonials", testimonialslist);
        }
    }
}
