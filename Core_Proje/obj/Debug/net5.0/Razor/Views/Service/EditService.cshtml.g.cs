#pragma checksum "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76aec6be82b7af16ea4632c188130dade14a7a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_EditService), @"mvc.1.0.view", @"/Views/Service/EditService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76aec6be82b7af16ea4632c188130dade14a7a38", @"/Views/Service/EditService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e8602676f9aaf81e911b17fe8826daa793fbba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_EditService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
  
    ViewData["Title"] = "EditService";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Hizmet Düzenleme Sayfası</h3>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
 using(Html.BeginForm("EditService","Service",FormMethod.Post))
{   

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
Write(Html.HiddenFor(x=>x.ServiceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br />\r\n");
#nullable restore
#line 15 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
Write(Html.Label("Hizmet Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
Write(Html.TextBoxFor(x=>x.Title, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n     <label>Resim Yolu</label>\r\n");
#nullable restore
#line 19 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n");
#nullable restore
#line 23 "C:\DMP\Core-Projem\Core_Proje\Views\Service\EditService.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
