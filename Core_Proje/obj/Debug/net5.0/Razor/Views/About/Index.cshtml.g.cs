#pragma checksum "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33db7d4d37daf1d00b212c3ebf9432876b5a4f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33db7d4d37daf1d00b212c3ebf9432876b5a4f2f", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e8602676f9aaf81e911b17fe8826daa793fbba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Hakkımda Düzenleme Sayfası</h3>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
 using(Html.BeginForm("Index","About",FormMethod.Post))
{   

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.HiddenFor(x=>x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br />\r\n");
#nullable restore
#line 14 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Yaş</label>\r\n");
#nullable restore
#line 18 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Age, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Mail</label>\r\n");
#nullable restore
#line 21 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Mail, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Telefon</label>\r\n");
#nullable restore
#line 24 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Phone, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Adres</label>\r\n");
#nullable restore
#line 27 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Adress, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel Yolu</label>\r\n");
#nullable restore
#line 30 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Açıklama</label>\r\n");
#nullable restore
#line 33 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextAreaFor(x=>x.Description,10,2, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 36 "C:\DMP\Core-Projem\Core_Proje\Views\About\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
