#pragma checksum "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81ac5f998aff7dcaf7a4e9ef38039e1e0c360c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCorps), @"mvc.1.0.view", @"/Views/Home/ShowCorps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCorps.cshtml", typeof(AspNetCore.Views_Home_ShowCorps))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81ac5f998aff7dcaf7a4e9ef38039e1e0c360c9", @"/Views/Home/ShowCorps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58edd3a6b5e9ca63b10fbb3cbb99bbeb61e4bcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCorps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.Corps>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
  
    ViewData["Title"] = "Производители";

#line default
#line hidden
            BeginContext(100, 409, true);
            WriteLiteral(@"
<h1>Производители</h1>

<table class=""table"">
    <thead>
    <tr>
        <th>
            Марка
        </th>
        <th>
            Страна производителя
        </th>
        <th>
            Президент компании
        </th>
        <th>
            Продукция
        </th>
        <th>
            Кол-во авто
        </th>
        <th></th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(550, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(599, 39, false);
#line 35 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(638, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(694, 43, false);
#line 38 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(737, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(793, 44, false);
#line 41 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.DisplayFor(modelItem => item.President));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(893, 45, false);
#line 44 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.DisplayFor(modelItem => item.Production));

#line default
#line hidden
            EndContext();
            BeginContext(938, 73, true);
            WriteLiteral("\r\n            </td>\r\n                \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 16, false);
#line 48 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(item.Autos.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1084, 50, false);
#line 51 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.ActionLink("Редактировать", "EditCorp", item));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1153, 46, false);
#line 52 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
           Write(Html.ActionLink("Удалить", "DeleteCorp", item));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
    }

#line default
#line hidden
            BeginContext(1242, 37, true);
            WriteLiteral("    <div class=\"auto-list\">\r\n        ");
            EndContext();
            BeginContext(1280, 39, false);
#line 57 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
   Write(Html.ActionLink("Список авто", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1330, 55, false);
#line 58 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
   Write(Html.ActionLink("Добавить производителя", "CreateCorp"));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 80, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"counter\">\r\n        <td>Количество производителей: ");
            EndContext();
            BeginContext(1466, 22, false);
#line 61 "C:\Users\Forcause\RiderProjects\WebApplication\Views\Home\ShowCorps.cshtml"
                                  Write(Model.ToList().Count());

#line default
#line hidden
            EndContext();
            BeginContext(1488, 45, true);
            WriteLiteral("</td>\r\n        </div>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.Corps>> Html { get; private set; }
    }
}
#pragma warning restore 1591