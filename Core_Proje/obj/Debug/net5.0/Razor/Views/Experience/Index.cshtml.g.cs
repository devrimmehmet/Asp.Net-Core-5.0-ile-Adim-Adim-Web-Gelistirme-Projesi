#pragma checksum "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff82cbf6674aa8b2f2ef649c901a5e18f949541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#nullable restore
#line 1 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff82cbf6674aa8b2f2ef649c901a5e18f949541", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n                <div class=\"card\">\r\n                  <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">Deneyimler</h4>\r\n");
            WriteLiteral(@"                    <div class=""table-responsive"">
                      <table class=""table"">
                        <thead>
                          <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                          </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
                             foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
                           Write(item.ExperienceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 30 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 31 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
                          Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td> <a");
            BeginWriteAttribute("href", " href=\"", 1212, "\"", 1266, 2);
            WriteAttributeValue("", 1219, "/Experience/DeleteExperience/", 1219, 29, true);
#nullable restore
#line 32 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1248, item.ExperienceID, 1248, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                           <td> <a");
            BeginWriteAttribute("href", " href=\"", 1347, "\"", 1399, 2);
            WriteAttributeValue("", 1354, "/Experience/EditExperience/", 1354, 27, true);
#nullable restore
#line 33 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1381, item.ExperienceID, 1381, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            \r\n                          </tr>\r\n");
#nullable restore
#line 36 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Experience\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          
                        </tbody>

                      </table>
                      <a href=""/Experience/AddExperience/"" class=""btn btn-outline-info"">Yeni Deneyim Ekle</a>
                    </div>
                  </div>
                </div>

              </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
