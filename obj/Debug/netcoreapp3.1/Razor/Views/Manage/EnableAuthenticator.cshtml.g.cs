#pragma checksum "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4e0305eb90cb66f097e4ac3892b5e059691afd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_EnableAuthenticator), @"mvc.1.0.view", @"/Views/Manage/EnableAuthenticator.cshtml")]
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
#line 1 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
using WebApplication2.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4e0305eb90cb66f097e4ac3892b5e059691afd", @"/Views/Manage/EnableAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56daf892039b04062ae4c16ebc65ed9278a1592a", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d332356ce5fcdbfeef54eabb58247887632477", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_EnableAuthenticator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnableAuthenticatorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP");
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 9 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div>\r\n    <p>");
#nullable restore
#line 11 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
  Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_STEPS"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <ol class=\"list\">\r\n        <li>\r\n            <p>\r\n                ");
#nullable restore
#line 15 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_DOWNLOAD_TEXT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <a href=\"https://go.microsoft.com/fwlink/?Linkid=825071\">Windows Phone</a>,\r\n                <a href=\"https://go.microsoft.com/fwlink/?Linkid=825072\">Android</a> ");
#nullable restore
#line 17 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                                Write(SharedLocalizer.GetLocalizedHtmlString("AND"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <a href=\"https://go.microsoft.com/fwlink/?Linkid=825073\">iOS</a> ");
#nullable restore
#line 18 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                            Write(SharedLocalizer.GetLocalizedHtmlString("OR"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_GOOGLE_TEXT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <a href=\"https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&amp;hl=en\">Android</a> ");
#nullable restore
#line 20 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                                                                                Write(SharedLocalizer.GetLocalizedHtmlString("AND"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <a href=\"https://itunes.apple.com/us/app/google-authenticator/id388497605?mt=8\">iOS</a>.\r\n            </p>\r\n        </li>\r\n        <li>\r\n            <p>");
#nullable restore
#line 25 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_SCAN1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<kbd>");
#nullable restore
#line 25 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                                           Write(Model.SharedKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</kbd> ");
#nullable restore
#line 25 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_SCAN2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"alert alert-info\">");
#nullable restore
#line 26 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_SCAN_ALERT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"https://go.microsoft.com/fwlink/?Linkid=852423\">");
#nullable restore
#line 26 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                                                                                                                               Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_SCAN_ALERT_LINK"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</div>\r\n            <div id=\"qrCode\"></div>\r\n            <div id=\"qrCodeData\" data-url=\"");
#nullable restore
#line 28 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                      Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n        </li>\r\n        <li>\r\n            <p>\r\n                ");
#nullable restore
#line 32 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("CONFIGURE_AUTHENTICATOR_APP_SCAN_ALERT_DETAILS"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4e0305eb90cb66f097e4ac3892b5e059691afd14059", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4e0305eb90cb66f097e4ac3892b5e059691afd14400", async() => {
#nullable restore
#line 38 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                   Write(SharedLocalizer.GetLocalizedHtmlString("VERIFICATION_CODE"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 38 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d4e0305eb90cb66f097e4ac3892b5e059691afd16382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 39 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4e0305eb90cb66f097e4ac3892b5e059691afd18108", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 40 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 42 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("VERIFY"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4e0305eb90cb66f097e4ac3892b5e059691afd20299", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 43 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n    </ol>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 52 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4e0305eb90cb66f097e4ac3892b5e059691afd23719", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n        new QRCode(document.getElementById(\"qrCode\"),\r\n            {\r\n                text: \"");
#nullable restore
#line 58 "J:\Programming\practice\IdentityPractice\quickstart6\quickstart\WebApplication2\Views\Manage\EnableAuthenticator.cshtml"
                  Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                width: 150,\r\n                height: 150\r\n            });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnableAuthenticatorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
