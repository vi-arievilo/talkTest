#pragma checksum "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0396f09bcc7728bd1365d13717d3a5e7f289da19"
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
#line 1 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\_ViewImports.cshtml"
using Feriados.Web;

#line default
#line hidden
#line 2 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\_ViewImports.cshtml"
using Feriados.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
using Feriados.Model.DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0396f09bcc7728bd1365d13717d3a5e7f289da19", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc8b17fb9c0ec6608cb270aacea199a404f41a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeriadoRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(171, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(178, 17, false);
#line 11 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
Write(Html.Hidden("id"));

#line default
#line hidden
            EndContext();
            BeginContext(195, 24, true);
            WriteLiteral(";\r\n    <h2>Edit</h2>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
     using (Html.BeginForm())
    {


#line default
#line hidden
            BeginContext(259, 86, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Feriados</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(346, 64, false);
#line 20 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(410, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(421, 35, false);
#line 21 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
   Write(Html.HiddenFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(456, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(507, 93, false);
#line 24 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.date, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(656, 93, false);
#line 26 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.date, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(749, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(768, 82, false);
#line 27 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.date, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(850, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(937, 94, false);
#line 32 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1087, 94, false);
#line 34 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1200, 83, false);
#line 35 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.title, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1370, 100, false);
#line 40 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1526, 100, false);
#line 42 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1645, 89, false);
#line 43 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1821, 100, false);
#line 48 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.legislation, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1977, 100, false);
#line 50 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.legislation, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2096, 89, false);
#line 51 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.legislation, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2272, 93, false);
#line 56 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.type, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2421, 93, false);
#line 58 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.type, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2533, 82, false);
#line 59 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2702, 98, false);
#line 64 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.startTime, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2856, 98, false);
#line 66 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.startTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2954, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2973, 87, false);
#line 67 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.startTime, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3060, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3147, 96, false);
#line 72 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.endTime, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3243, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3299, 96, false);
#line 74 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.endTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3395, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3414, 85, false);
#line 75 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.endTime, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3499, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3586, 98, false);
#line 80 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.variables, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3684, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3740, 98, false);
#line 82 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.variables, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3838, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3857, 87, false);
#line 83 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.variables, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3944, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 93 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
    }

#line default
#line hidden
            BeginContext(4206, 21, true);
            WriteLiteral("\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(4228, 40, false);
#line 96 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Edit.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(4268, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeriadoRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
