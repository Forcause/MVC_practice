#pragma checksum "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22956ae8f27035b2b473b40b325b2718aa8e5ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Forcause\RiderProjects\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "C:\Users\Forcause\RiderProjects\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#line 1 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22956ae8f27035b2b473b40b325b2718aa8e5ab8", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58edd3a6b5e9ca63b10fbb3cbb99bbeb61e4bcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.Auto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(135, 30, true);
            WriteLiteral("\r\n<h1>Добавление авто</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(195, 19, true);
            WriteLiteral("    <h4>Авто</h4>\r\n");
            EndContext();
            BeginContext(219, 33, false);
#line 13 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(254, 47, true);
            WriteLiteral("    <p>\r\n        Название марки <br/>\r\n        ");
            EndContext();
            BeginContext(302, 70, false);
#line 16 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
   Write(Html.DropDownListFor(model => model.Mark, ViewBag.Corps as SelectList));

#line default
#line hidden
            EndContext();
            BeginContext(372, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(386, 48, true);
            WriteLiteral("    <p>\r\n        Название модели <br/>\r\n        ");
            EndContext();
            BeginContext(435, 36, false);
#line 21 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(471, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(485, 44, true);
            WriteLiteral("    <p>\r\n        Год выпуска <br/>\r\n        ");
            EndContext();
            BeginContext(530, 35, false);
#line 26 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(565, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(579, 43, true);
            WriteLiteral("    <p>\r\n        Тип кузова <br/>\r\n        ");
            EndContext();
            BeginContext(623, 39, false);
#line 31 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(model => model.BodyType));

#line default
#line hidden
            EndContext();
            BeginContext(662, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
            BeginContext(676, 71, true);
            WriteLiteral("    <p>\r\n    <input type=\"submit\" value=\"Добавить авто\"/>\r\n    </p>  \r\n");
            EndContext();
#line 37 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
} 

#line default
#line hidden
            BeginContext(751, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(763, 41, false);
#line 39 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Edit.cshtml"
Write(Html.ActionLink("К списку авто", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(804, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.Auto> Html { get; private set; }
    }
}
#pragma warning restore 1591
