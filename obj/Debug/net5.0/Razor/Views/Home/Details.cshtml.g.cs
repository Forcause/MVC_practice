#pragma checksum "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd983f14d76d0e859d30d3a4306aad987c48fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd983f14d76d0e859d30d3a4306aad987c48fa8", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58edd3a6b5e9ca63b10fbb3cbb99bbeb61e4bcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(54, 149, true);
            WriteLiteral("\r\n<h2>Информация об автомобиле и производителе</h2>\r\n\r\n<div class=\"display-label\"><b>Марка/Производитель</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(204, 36, false);
#line 11 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(240, 93, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Модель</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(334, 37, false);
#line 16 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(371, 98, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Год выпуска</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(470, 36, false);
#line 21 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(506, 97, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Тип кузова</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(604, 40, false);
#line 26 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.BodyType));

#line default
#line hidden
            EndContext();
            BeginContext(644, 107, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Страна производителя</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(752, 55, false);
#line 31 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.MarkNavigation.Location));

#line default
#line hidden
            EndContext();
            BeginContext(807, 105, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Президент компании</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(913, 56, false);
#line 36 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.MarkNavigation.President));

#line default
#line hidden
            EndContext();
            BeginContext(969, 105, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"display-label\"><b>Продукция компании</b></div>\r\n<div class=\"display-field\">\r\n    ");
            EndContext();
            BeginContext(1075, 57, false);
#line 41 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\Details.cshtml"
Write(Html.DisplayFor(model => model.MarkNavigation.Production));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auto> Html { get; private set; }
    }
}
#pragma warning restore 1591