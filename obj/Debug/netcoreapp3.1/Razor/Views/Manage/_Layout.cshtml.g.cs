#pragma checksum "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9395fa4481140fb77ea1da6fcbcf2a872ba353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
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
#line 1 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_ViewImports.cshtml"
using WebApplication2.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_ViewImports.cshtml"
using WebApplication2.Views.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
using WebApplication2.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9395fa4481140fb77ea1da6fcbcf2a872ba353", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56daf892039b04062ae4c16ebc65ed9278a1592a", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d332356ce5fcdbfeef54eabb58247887632477", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("MANAGE_YOUR_ACCOUNT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>");
#nullable restore
#line 10 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("MANAGE_CHANGE_ACCOUNT_SETTINGS"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
#nullable restore
#line 14 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
       Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 17 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
