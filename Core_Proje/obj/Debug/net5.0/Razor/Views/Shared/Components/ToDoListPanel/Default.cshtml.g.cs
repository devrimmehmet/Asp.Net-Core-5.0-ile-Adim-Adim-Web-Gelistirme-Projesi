#pragma checksum "C:\DMP\Core-Projem\Core_Proje\Views\Shared\Components\ToDoListPanel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de336a8a74ca405552e90c7df3bc941900b247a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ToDoListPanel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ToDoListPanel/Default.cshtml")]
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
#line 1 "C:\DMP\Core-Projem\Core_Proje\Views\Shared\Components\ToDoListPanel\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de336a8a74ca405552e90c7df3bc941900b247a4", @"/Views/Shared/Components/ToDoListPanel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e8602676f9aaf81e911b17fe8826daa793fbba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ToDoListPanel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12 col-xl-4 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Yapılacaklar Listesi</h4>
                    <div class=""add-items d-flex"">
                      <input type=""text"" class=""form-control todo-list-input"" placeholder=""Birşeyler Ekle.."">
                      <button class=""add btn btn-primary todo-list-add-btn"">Ekle</button>
                    </div>
                    <div class=""list-wrapper"">
                      <ul class=""d-flex flex-column-reverse text-white todo-list todo-list-custom"">
");
#nullable restore
#line 14 "C:\DMP\Core-Projem\Core_Proje\Views\Shared\Components\ToDoListPanel\Default.cshtml"
                           foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                          <div class=\"form-check form-check-primary\">\r\n                            <label class=\"form-check-label\">\r\n                              <input class=\"checkbox\" type=\"checkbox\"> ");
#nullable restore
#line 18 "C:\DMP\Core-Projem\Core_Proje\Views\Shared\Components\ToDoListPanel\Default.cshtml"
                                                                  Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                          </div>\r\n                          <i class=\"remove mdi mdi-close-box\"></i>\r\n                          \r\n                        </li>\r\n");
#nullable restore
#line 23 "C:\DMP\Core-Projem\Core_Proje\Views\Shared\Components\ToDoListPanel\Default.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </ul>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591