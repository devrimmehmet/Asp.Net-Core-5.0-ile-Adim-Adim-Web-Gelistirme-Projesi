#pragma checksum "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Admin\NewSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518f2db0a2b8eb51e72f940f5593c287419fefcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NewSideBar), @"mvc.1.0.view", @"/Views/Admin/NewSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518f2db0a2b8eb51e72f940f5593c287419fefcf", @"/Views/Admin/NewSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_NewSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<ul class=""nav"">
   
    <li class=""nav-item nav-category"">
        <span class=""nav-link"">Navigasyon</span>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
            </span>
            <span class=""menu-title"">Dashboard</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" ");
            WriteLiteral(" href=\"/Skill/index/\" aria-expanded=\"true\" aria-controls=\"ui-basic\">\r\n            <span class=\"menu-icon\">\r\n                <i class=\"mdi mdi-laptop\"></i>\r\n            </span>\r\n            <span class=\"menu-title\">Yetenekler</span>\r\n");
            WriteLiteral("        </a>\r\n");
            WriteLiteral(@"    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-playlist-play""></i>
            </span>
            <span class=""menu-title"">Deneyimler</span>
        </a>
    </li>
   
");
            WriteLiteral(@"    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Service/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Hizmetler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Portfolio/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-github-circle""></i>
            </span>
            <span class=""menu-title"">Projeler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/ReceiverMessageList/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Gelen Mesajlar</span>
        </a>
    </li>

    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/SenderMessageList/Index/"">
            <span class=""menu-ico");
            WriteLiteral(@"n"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Giden Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Contact/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-phone""></i>
            </span>
            <span class=""menu-title"">İletişim</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/About/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-account""></i>
            </span>
            <span class=""menu-title"">Hakkımda</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/ContactSubplace/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-calendar""></i>
            </span>
            <span class=""menu-title"">Alt İletişim</span>
        </a>
    </li>
    <li class=""nav-it");
            WriteLiteral(@"em menu-items"">
        <a class=""nav-link"" href=""/Testimonial/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Referanslar</span>
        </a>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/SocialMedia/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-youtube""></i>
            </span>
            <span class=""menu-title"">Sosyal Medya</span>
        </a>
    </li>
     <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience2/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-car""></i>
            </span>
            <span class=""menu-title"">Deneyim Ajax</span>
        </a>
    </li>

    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Feature/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            WriteLiteral(@"
            <span class=""menu-title"">Öne Çıkan Gönderiler</span>
        </a>
    </li>
        <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-table-large""></i>
            </span>
            <span class=""menu-title"">Yazar Paneline Git</span>
        </a>
    </li>
     <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Default/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-table-large""></i>
            </span>
            <span class=""menu-title"">Siteye Git</span>
        </a>
    </li>
 
   </ul>
    
    
");
            WriteLiteral("   \r\n");
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