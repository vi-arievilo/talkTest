#pragma checksum "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece1a5ea8dc7e53eac0c38b4160344f17512bb51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
using Feriados.Model.DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece1a5ea8dc7e53eac0c38b4160344f17512bb51", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc8b17fb9c0ec6608cb270aacea199a404f41a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FeriadoRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(108, 626, true);
            WriteLiteral(@"<div>
    <br><br><br><br>
    <table class=""table table-bordered th table-striped table-hover"">
        <thead class=""text-center text-uppercase"">
            <tr>
                <td  width=""5%"">data</td>
                <td width=""5%"">Title</td>
                <td width=""20%"">Description</td>
                <td width=""10%"">Legislation</td>
                <td width=""10%"">Type</td>
                <td width=""10%"">Start Time</td>
                <td width=""10%"">End Time</td>
                <td width=""10%"">variables</td>
                <td colspan=""2"">Options</td>
            </tr>
        </thead>
");
            EndContext();
#line 25 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(802, 43, true);
            WriteLiteral("        <tr>\r\n            <td  width=\"5%\" >");
            EndContext();
            BeginContext(846, 9, false);
#line 29 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.date);

#line default
#line hidden
            EndContext();
            BeginContext(855, 35, true);
            WriteLiteral("</td>\r\n            <td width=\"5%\" >");
            EndContext();
            BeginContext(891, 10, false);
#line 30 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                       Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(901, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"20%\" >");
            EndContext();
            BeginContext(938, 16, false);
#line 31 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(954, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"10%\" >");
            EndContext();
            BeginContext(991, 16, false);
#line 32 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.legislation);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"10%\" >");
            EndContext();
            BeginContext(1044, 9, false);
#line 33 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.type);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"10%\" >");
            EndContext();
            BeginContext(1090, 14, false);
#line 34 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.startTime);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"10%\" >");
            EndContext();
            BeginContext(1141, 12, false);
#line 35 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.endTime);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 36, true);
            WriteLiteral("</td>\r\n            <td width=\"10%\" >");
            EndContext();
            BeginContext(1190, 14, false);
#line 36 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
                        Write(item.variables);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 26, true);
            WriteLiteral("</td>\r\n            <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1230, "\"", 1285, 1);
#line 37 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1237, Url.Action("Edit", "Home", new { id = item.id}), 1237, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1286, 75, true);
            WriteLiteral(" class=\"btn btn btn-primary btn-block\">Editar</a></td>\r\n            <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1418, 1);
#line 38 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1368, Url.Action("Delete", "Home", new { id = item.id}), 1368, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1419, 79, true);
            WriteLiteral(" class=\"btn btn-danger btn-primary btn-block\">Excluir</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Vivi\source\repos\Feriados\Feriados.Web\Views\Home\Index.cshtml"

            }

        

#line default
#line hidden
            BeginContext(1528, 26, true);
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FeriadoRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591