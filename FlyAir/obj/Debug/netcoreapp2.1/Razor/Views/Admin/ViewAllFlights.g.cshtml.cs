#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c6c1d80cfee7542f4e17debc9398e9513765ea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAllFlights), @"mvc.1.0.view", @"/Views/Admin/ViewAllFlights.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ViewAllFlights.cshtml", typeof(AspNetCore.Views_Admin_ViewAllFlights))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6c1d80cfee7542f4e17debc9398e9513765ea5", @"/Views/Admin/ViewAllFlights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllFlights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlyAir.Models.FlightModels.Flight>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlightStaffs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlightPlane", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
  
    ViewData["Title"] = "ViewAllFlights";

#line default
#line hidden
            BeginContext(107, 87, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid\">\r\n    <h4>View All Flights</h4>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(194, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e11cb60b7f4b74bc11f280d4b49bc5", async() => {
                BeginContext(267, 10, true);
                WriteLiteral("Add Flight");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 145, true);
            WriteLiteral("\r\n    </div>\r\n    <br /> \r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(427, 38, false);
#line 19 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(465, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(533, 50, false);
#line 22 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.DepartDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(583, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(651, 47, false);
#line 25 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.ArrDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(698, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(766, 41, false);
#line 28 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(807, 59, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n            ");
            EndContext();
            BeginContext(867, 47, false);
#line 31 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
       Write(Html.DisplayNameFor(model => model.SeatsRemain));

#line default
#line hidden
            EndContext();
            BeginContext(914, 59, true);
            WriteLiteral("\r\n        </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(974, 43, false);
#line 34 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.PlaneID));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1085, 45, false);
#line 37 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.OriginLoc));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1198, 43, false);
#line 40 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.DestLoc));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1309, 50, false);
#line 43 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.FlightSeatType));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 49 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1522, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1583, 37, false);
#line 53 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1688, 49, false);
#line 56 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1805, 46, false);
#line 59 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.ArrDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1919, 40, false);
#line 62 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 59, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n            ");
            EndContext();
            BeginContext(2019, 46, false);
#line 65 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
       Write(Html.DisplayFor(modelItem => item.SeatsRemain));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 59, true);
            WriteLiteral("\r\n        </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2125, 42, false);
#line 68 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlaneID));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2235, 50, false);
#line 71 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.OriginLoc1.City));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2288, 57, false);
#line 71 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.OriginLoc1.CountryName));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2413, 48, false);
#line 74 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.DestLoc1.City));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2464, 55, false);
#line 74 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.DestLoc1.CountryName));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2587, 52, false);
#line 77 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.FlightSeatType.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2706, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f2d6ca75ec497ca720a43c6a54b6b2", async() => {
                BeginContext(2787, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2795, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2819, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef593cae066491db5c25a66b5cc52b4", async() => {
                BeginContext(2901, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2911, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2935, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa1576caff34f93abdd88deafa5bd78", async() => {
                BeginContext(3021, 11, true);
                WriteLiteral("Edit Staffs");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3036, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3058, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009ae324335c450e8d665f937e1c8c4b", async() => {
                BeginContext(3143, 10, true);
                WriteLiteral("Edit Plane");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3157, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 86 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Admin\ViewAllFlights.cshtml"
            }

#line default
#line hidden
            BeginContext(3216, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlyAir.Models.FlightModels.Flight>> Html { get; private set; }
    }
}
#pragma warning restore 1591
