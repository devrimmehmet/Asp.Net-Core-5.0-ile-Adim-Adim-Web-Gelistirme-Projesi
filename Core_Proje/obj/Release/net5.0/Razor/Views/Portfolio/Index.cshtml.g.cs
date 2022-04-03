#pragma checksum "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea064537e276b17e0297315682a2de379e78b356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\DMP\Core-Projem\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DMP\Core-Projem\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea064537e276b17e0297315682a2de379e78b356", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e8602676f9aaf81e911b17fe8826daa793fbba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
        <div class=""col"">
          <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
              <h3 class=""text-white mb-0"">Projelerim</h3>
            </div>
            <div class=""table-responsive"">
              <table class=""table align-items-center table-dark table-flush"">
                <thead class=""thead-dark"">
                  <tr>
                    <th scope=""col"" class=""sort"" data-sort=""name"">Proje</th>
                    <th scope=""col"" class=""sort"" data-sort=""budget"">Ücret</th>
                    <th scope=""col"" class=""sort"" data-sort=""status"">Durum</th>
                    <th scope=""col"" class=""sort"" data-sort=""completion"">Tamamlanma Oranı</th>
                    <th scope=""col"">Sil</th>
                    <th scope=""col"">Düzenle</th>
                  </tr>
                </thead>
                <tbody class=""list"">
");
#nullable restore
#line 27 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <th scope=\"row\">\r\n                      <div class=\"media align-items-center\">\r\n                        <a href=\"#\" class=\"avatar rounded-circle mr-3\">\r\n                          <img alt=\"Image placeholder\"");
            BeginWriteAttribute("src", " src=\"", 1394, "\"", 1414, 1);
#nullable restore
#line 32 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1400, item.Platform, 1400, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                        <div class=\"media-body\">\r\n                          <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 35 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                      </div>\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                      ");
#nullable restore
#line 40 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                      <span class=""badge badge-dot mr-4"">
                        <i class=""bg-success""></i>
                        <span class=""status"">Tamamlandı</span>
                      </span>
                    </td>
                    
                    <td>
                      <div class=""d-flex align-items-center"">
                        <span class=""completion mr-2"">");
#nullable restore
#line 51 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                        <div>\r\n                          <div class=\"progress\">\r\n                            <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2376, "\"", 2403, 1);
#nullable restore
#line 54 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2392, item.Value, 2392, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 2442, "\"", 2470, 3);
            WriteAttributeValue("", 2450, "width:", 2450, 6, true);
#nullable restore
#line 54 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue(" ", 2456, item.Value, 2457, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2468, "%;", 2468, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </td>\r\n                   <td> <a");
            BeginWriteAttribute("href", " href=\"", 2629, "\"", 2680, 2);
            WriteAttributeValue("", 2636, "/portfolio/DeletePortfolio/", 2636, 27, true);
#nullable restore
#line 59 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2663, item.PortfolioID, 2663, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                      <td> <a");
            BeginWriteAttribute("href", " href=\"", 2756, "\"", 2805, 2);
            WriteAttributeValue("", 2763, "/portfolio/EditPortfolio/", 2763, 25, true);
#nullable restore
#line 60 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2788, item.PortfolioID, 2788, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Düzenle</a>   </td>\r\n                  </tr>\r\n");
#nullable restore
#line 62 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n              </table>\r\n            \r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n        <a href=\"/Portfolio/AddPortfolio/\" class=\"btn btn-primary\">Yeni Proje Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
