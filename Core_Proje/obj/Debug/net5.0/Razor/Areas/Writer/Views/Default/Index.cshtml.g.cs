#pragma checksum "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c688b8919dfdc82a2f6005c849356d0e6a6b7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c688b8919dfdc82a2f6005c849356d0e6a6b7ff", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    string color = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">Duyurular</h4>
                  <p class=""card-description"">
                     
                  </p>
                  <div class=""table-responsive"">
                    <table class=""table"">
                      <thead>
                        <tr>
                          <th>#</th>
                          <th>Ba??l??k</th>
                          <th>Tarih</th>
                          <th>T??r</th>
                          <th>Detaylar</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 29 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                           foreach(var item in Model){
                            if(item.Status=="Yeni Yaz??")
                            {
                                color = "badge badge-danger";
                            }
                             if(item.Status=="Yeni Video")
                            {
                                color = "badge badge-warning";
                            }
                             if(item.Status=="Yeni Proje")
                            {
                                color = "badge badge-info";
                            }
                             if(item.Status=="Yeni Bootcamp")
                            {
                                color = "badge badge-primary";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                          <th>");
#nullable restore
#line 47 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                         Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                          <td>");
#nullable restore
#line 48 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td>");
#nullable restore
#line 49 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                          Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          <td><label");
            BeginWriteAttribute("class", " class=\"", 1959, "\"", 1973, 1);
#nullable restore
#line 50 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 1967, color, 1967, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                          <td><a");
            BeginWriteAttribute("href", " href=\"", 2034, "\"", 2085, 2);
            WriteAttributeValue("", 2041, "/Writer/Default/AnnouncementDetails/", 2041, 36, true);
#nullable restore
#line 51 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2077, item.ID, 2077, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n                        </tr>");
#nullable restore
#line 52 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     \r\n                      </tbody>\r\n                    </table>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
