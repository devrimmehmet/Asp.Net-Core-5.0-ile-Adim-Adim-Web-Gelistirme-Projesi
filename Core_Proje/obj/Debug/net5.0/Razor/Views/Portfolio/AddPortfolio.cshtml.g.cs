#pragma checksum "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a3a5febf26d99bfc270a3a874d5bbfe3c6d9c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a3a5febf26d99bfc270a3a874d5bbfe3c6d9c0", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e8602676f9aaf81e911b17fe8826daa793fbba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Proje Ekleme Sayfası</h3>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
 using(Html.BeginForm("AddPortfolio","Portfolio",FormMethod.Post))
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br />\r\n");
#nullable restore
#line 16 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Name, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel 1</label>\r\n");
#nullable restore
#line 21 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.ImageUrl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                             ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n     <label>Görsel 2</label>\r\n");
#nullable restore
#line 25 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl2, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.ImageUrl2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                              ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n       <label>Proje Url</label>\r\n");
#nullable restore
#line 29 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ProjectUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.ProjectUrl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                               ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Fiyat</label>\r\n");
#nullable restore
#line 33 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Price, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.Price));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                          ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Tamamlanma Oranı</label>\r\n");
#nullable restore
#line 37 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Value, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.Value));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                          ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n      <label>Proje Dili</label>\r\n");
#nullable restore
#line 41 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Platform, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=> x.Platform));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                                             ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 46 "C:\DMP\Core-Projem\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
