#pragma checksum "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Shared\Components\VisitorMap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0221fdde9cec646c18a3987a2db7e2d89fb38073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitorMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0221fdde9cec646c18a3987a2db7e2d89fb38073", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_VisitorMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 

<div class=""row"">
              <div class=""col-12"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Ziyaret Edilen Ülkeler</h4>
                    <div class=""row"">
                      <div class=""col-md-5"">
                        <div class=""table-responsive"">
                          <table class=""table"">
                            <tbody>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-tr""></i>
                                </td>
                                <td>Türkiye</td>
                                <td class=""text-right""> 1500 </td>
                                <td class=""text-right font-weight-medium""> 56.35% </td>
                              </tr>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-de""></i>
       ");
            WriteLiteral(@"                         </td>
                                <td>Almanya</td>
                                <td class=""text-right""> 800 </td>
                                <td class=""text-right font-weight-medium""> 33.25% </td>
                              </tr>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-au""></i>
                                </td>
                                <td>avustralya</td>
                                <td class=""text-right""> 760 </td>
                                <td class=""text-right font-weight-medium""> 15.45% </td>
                              </tr>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-gb""></i>
                                </td>
                                <td>İngiltere</td>
                                <td class=""text-right""> 450 </td>
          ");
            WriteLiteral(@"                      <td class=""text-right font-weight-medium""> 25.00% </td>
                              </tr>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-ro""></i>
                                </td>
                                <td>Romanya</td>
                                <td class=""text-right""> 620 </td>
                                <td class=""text-right font-weight-medium""> 10.25% </td>
                              </tr>
                              <tr>
                                <td>
                                  <i class=""flag-icon flag-icon-br""></i>
                                </td>
                                <td>Birazilya</td>
                                <td class=""text-right""> 230 </td>
                                <td class=""text-right font-weight-medium""> 75.00% </td>
                              </tr>
                            </tbody>
        ");
            WriteLiteral(@"                  </table>
                        </div>
                      </div>
                      <div class=""col-md-7"">
                        <div id=""audience-map"" class=""vector-map""></div>
                      </div>
                    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
