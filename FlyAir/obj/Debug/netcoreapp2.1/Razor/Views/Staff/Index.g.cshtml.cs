#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d007a3f49f2800cc83387627f5bd44afda84171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Index.cshtml", typeof(AspNetCore.Views_Staff_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d007a3f49f2800cc83387627f5bd44afda84171", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlyAir.Models.StaffModels.StaffVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/staffDashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var flights = Model.Flights;
    var flightCount = 0;
    if(Model.Flights.Count() > 0)
    {
        flightCount = Model.Flights.Count();
    }

#line default
#line hidden
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(240, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc3960767fc54cc5b587159c4efda16f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(295, 180, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <h2>Staff Dashboard</h2>\r\n\r\n    <div>\r\n        <h4>Your Work</h4>\r\n        <div class=\"card yourWorkCard\">\r\n            <div id=\"title\">You have ");
            EndContext();
            BeginContext(476, 11, false);
#line 21 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                                Write(flightCount);

#line default
#line hidden
            EndContext();
            BeginContext(487, 31, true);
            WriteLiteral(" flight duty coming up.</div>\r\n");
            EndContext();
#line 22 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
             foreach (var flight in flights)
            {

#line default
#line hidden
            BeginContext(579, 32, true);
            WriteLiteral("                <div>Flight ID: ");
            EndContext();
            BeginContext(612, 9, false);
#line 24 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                           Write(flight.ID);

#line default
#line hidden
            EndContext();
            BeginContext(621, 35, true);
            WriteLiteral("</div>\r\n                <div>From: ");
            EndContext();
            BeginContext(657, 22, false);
#line 25 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                      Write(flight.OriginLoc1.City);

#line default
#line hidden
            EndContext();
            BeginContext(679, 42, true);
            WriteLiteral("</div>\r\n                <div>Depart Time: ");
            EndContext();
            BeginContext(722, 21, false);
#line 26 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                             Write(flight.DepartDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(743, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(753, 25, true);
            WriteLiteral("                <div>To: ");
            EndContext();
            BeginContext(779, 20, false);
#line 28 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                    Write(flight.DestLoc1.City);

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("</div>\r\n                <div>Arrival Time: ");
            EndContext();
            BeginContext(843, 18, false);
#line 29 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
                              Write(flight.ArrDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(861, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(871, 24, true);
            WriteLiteral("                <hr />\r\n");
            EndContext();
#line 32 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(910, 181, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"card\">\r\n        <div class=\"form-control\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(1091, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679bbd097981421d8fde62f47ae0c4d4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 40 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1119, 87, true);
            WriteLiteral(":\r\n                </div>\r\n                <div class=\"col-md-9\">\r\n                    ");
            EndContext();
            BeginContext(1207, 8, false);
#line 43 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
               Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 189, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-control\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(1404, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a54ee19d02e46b6b39e4549ff57bfae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1434, 87, true);
            WriteLiteral(":\r\n                </div>\r\n                <div class=\"col-md-9\">\r\n                    ");
            EndContext();
            BeginContext(1522, 10, false);
#line 53 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Staff\Index.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlyAir.Models.StaffModels.StaffVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
