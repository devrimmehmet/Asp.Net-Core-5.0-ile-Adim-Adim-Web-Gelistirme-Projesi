#pragma checksum "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0acde96c098a9785f78aeecf7490af645161ff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0acde96c098a9785f78aeecf7490af645161ff2", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/vendors/js/vendor.bundle.base.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Card header -->
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Ba??l??k</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">D??zenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 26 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 33 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 39 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                            <div>\r\n                                <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1507, "\"", 1534, 1);
#nullable restore
#line 42 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1523, item.Value, 1523, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1573, "\"", 1600, 3);
            WriteAttributeValue("", 1581, "width:", 1581, 6, true);
#nullable restore
#line 42 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1587, item.Value, 1588, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1599, "%", 1599, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1771, "\"", 1810, 2);
            WriteAttributeValue("", 1778, "/skill/DeleteSkill/", 1778, 19, true);
#nullable restore
#line 47 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1797, item.SkillID, 1797, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Sil </a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1877, "\"", 1914, 2);
            WriteAttributeValue("", 1884, "/skill/EditSkill/", 1884, 17, true);
#nullable restore
#line 48 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1901, item.SkillID, 1901, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\"> D??zenle </a></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\DMP\Core-Proje-Portfolyo\Core_Proje\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    \r\n    <a href=\"/skill/AddSkill/\" class=\"btn btn-primary\">Yeni Yetenek Ekle</a>\r\n</div>\r\n<!-- Card footer -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0acde96c098a9785f78aeecf7490af645161ff28637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
