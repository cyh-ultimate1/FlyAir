#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "261e8e177115b5c14400a286226303e80726bb43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ManageLogins), @"mvc.1.0.view", @"/Views/Manage/ManageLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ManageLogins.cshtml", typeof(AspNetCore.Views_Manage_ManageLogins))]
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
#line 1 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using FlyAir;

#line default
#line hidden
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using FlyAir.Models;

#line default
#line hidden
#line 3 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using Identity.Dapper.Samples.Web.Models.AccountViewModels;

#line default
#line hidden
#line 4 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using Identity.Dapper.Samples.Web.Models.ManageViewModels;

#line default
#line hidden
#line 5 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using mySession.Data.Extensions;

#line default
#line hidden
#line 9 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
using Microsoft.AspNetCore.Http.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261e8e177115b5c14400a286226303e80726bb43", @"/Views/Manage/ManageLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ManageLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";

#line default
#line hidden
            BeginContext(142, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(149, 17, false);
#line 7 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 34, true);
            WriteLiteral(".</h2>\r\n\r\n<p class=\"text-success\">");
            EndContext();
            BeginContext(201, 25, false);
#line 9 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                   Write(ViewData["StatusMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(226, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
 if (Model.CurrentLogins.Count > 0)
{

#line default
#line hidden
            BeginContext(272, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 15 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
             for (var index = 0; index < Model.CurrentLogins.Count; index++)
            {

#line default
#line hidden
            BeginContext(441, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(488, 40, false);
#line 18 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                   Write(Model.CurrentLogins[index].LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(528, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 20 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                         if ((bool)ViewData["ShowRemoveButton"])
                        {

#line default
#line hidden
            BeginContext(654, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(682, 659, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b888d784dddf42fe821e526dc4cd19d9", async() => {
                BeginContext(775, 77, true);
                WriteLiteral("\r\n                                <div>\r\n                                    ");
                EndContext();
                BeginContext(852, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d53a5750ab04027b1e038fb40defd49", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentLogins[index].LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(948, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(986, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e502d7fe8c8c4c848328d63f26ecb6d2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentLogins[index].ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1078, 97, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-default\" value=\"Remove\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1175, "\"", 1260, 7);
                WriteAttributeValue("", 1183, "Remove", 1183, 6, true);
                WriteAttributeValue(" ", 1189, "this", 1190, 5, true);
#line 26 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 1194, Model.CurrentLogins[index].LoginProvider, 1195, 41, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1236, "login", 1237, 6, true);
                WriteAttributeValue(" ", 1242, "from", 1243, 5, true);
                WriteAttributeValue(" ", 1247, "your", 1248, 5, true);
                WriteAttributeValue(" ", 1252, "account", 1253, 8, true);
                EndWriteAttribute();
                BeginContext(1261, 73, true);
                WriteLiteral(" />\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1341, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1427, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1457, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1493, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1558, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 39 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden
#line 40 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
 if (Model.OtherLogins.Count > 0)
{

#line default
#line hidden
            BeginContext(1631, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1692, 477, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aba3df9b4f44438bcfd0ad6be249351", async() => {
                BeginContext(1783, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 47 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1919, 81, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2000, "\"", 2022, 1);
#line 49 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue("", 2008, provider.Name, 2008, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2023, "\"", 2078, 6);
                WriteAttributeValue("", 2031, "Log", 2031, 3, true);
                WriteAttributeValue(" ", 2034, "in", 2035, 3, true);
                WriteAttributeValue(" ", 2037, "using", 2038, 6, true);
                WriteAttributeValue(" ", 2043, "your", 2044, 5, true);
#line 49 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 2048, provider.DisplayName, 2049, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2070, "account", 2071, 8, true);
                EndWriteAttribute();
                BeginContext(2079, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2081, 13, false);
#line 49 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                                                                                                                                                            Write(provider.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2094, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(2124, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
