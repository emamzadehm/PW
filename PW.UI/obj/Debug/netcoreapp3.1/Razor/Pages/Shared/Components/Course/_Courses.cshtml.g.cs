#pragma checksum "F:\Projects\PW\PW\PW.UI\Pages\Shared\Components\Course\_Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b80311c5c120b61e62909f8f4be3981a701d731a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PW.UI.Pages.Shared.Components.Course.Pages_Shared_Components_Course__Courses), @"mvc.1.0.view", @"/Pages/Shared/Components/Course/_Courses.cshtml")]
namespace PW.UI.Pages.Shared.Components.Course
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Projects\PW\PW\PW.UI\Pages\_ViewImports.cshtml"
using PW.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b80311c5c120b61e62909f8f4be3981a701d731a", @"/Pages/Shared/Components/Course/_Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654f5cd2445e04a94fa0aa2bacab3f19052688b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Course__Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PW.ApplicationContracts.ViewModels.CourseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""section section-dark section-services"" id=""services"">
    <div class=""container"">
        <div class=""section-head"">
            <span>آموزش ها</span>
            <h2>دوره های آموزشی تدریس شده</h2>
        </div>

        <div class=""section-inner"">
            <div class=""row"">
");
#nullable restore
#line 12 "F:\Projects\PW\PW\PW.UI\Pages\Shared\Components\Course\_Courses.cshtml"
                 foreach (var course in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-4"">
        <div class=""blog-list d-block mb-5"">
            <div class=""services-list mt-4 text-center"">
                <div class=""list-icon list-icon-6 mt-1 "">
                    <i class=""lni-bar-chart""></i>
                </div>
                <div class=""blog-list--desc p-4"">
                    <h5 class=""mb-0 text-center"">");
#nullable restore
#line 21 "F:\Projects\PW\PW\PW.UI\Pages\Shared\Components\Course\_Courses.cshtml"
                                            Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\" mt-3\">");
#nullable restore
#line 22 "F:\Projects\PW\PW\PW.UI\Pages\Shared\Components\Course\_Courses.cshtml"
                                Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
#nullable restore
#line 26 "F:\Projects\PW\PW\PW.UI\Pages\Shared\Components\Course\_Courses.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PW.ApplicationContracts.ViewModels.CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
