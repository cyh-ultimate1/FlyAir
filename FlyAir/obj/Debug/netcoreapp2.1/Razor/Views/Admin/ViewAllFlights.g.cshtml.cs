#pragma checksum "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f56084ae32dfb6d4c7834d07758254cf0beddb"
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
#line 1 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using FlyAir;

#line default
#line hidden
#line 2 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using FlyAir.Models;

#line default
#line hidden
#line 3 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using Identity.Dapper.Samples.Web.Models.AccountViewModels;

#line default
#line hidden
#line 4 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using Identity.Dapper.Samples.Web.Models.ManageViewModels;

#line default
#line hidden
#line 5 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using mySession.Data.Extensions;

#line default
#line hidden
#line 9 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f56084ae32dfb6d4c7834d07758254cf0beddb", @"/Views/Admin/ViewAllFlights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllFlights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlyAir.Models.FlightModels.Flight>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlightStaffs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFlightPlane", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
  
    ViewData["Title"] = "ViewAllFlights";

#line default
#line hidden
            BeginContext(107, 85, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid\">\r\n    <h2>ViewAllFlights</h2>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(192, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea45cdb553a401e86bdf3ae61690101", async() => {
                BeginContext(265, 10, true);
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
            BeginContext(279, 132, true);
            WriteLiteral("\r\n    </div>\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(412, 38, false);
#line 18 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(450, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(518, 50, false);
#line 21 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.DepartDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(568, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(636, 47, false);
#line 24 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.ArrDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(683, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(751, 41, false);
#line 27 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(792, 59, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n            ");
            EndContext();
            BeginContext(852, 47, false);
#line 30 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
       Write(Html.DisplayNameFor(model => model.SeatsRemain));

#line default
#line hidden
            EndContext();
            BeginContext(899, 59, true);
            WriteLiteral("\r\n        </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(959, 43, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.PlaneID));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1070, 45, false);
#line 36 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.OriginLoc));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1183, 43, false);
#line 39 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.DestLoc));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1294, 50, false);
#line 42 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayNameFor(model => model.FlightSeatType));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 48 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1507, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1568, 37, false);
#line 52 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1673, 49, false);
#line 55 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1790, 46, false);
#line 58 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.ArrDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1904, 40, false);
#line 61 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 59, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n            ");
            EndContext();
            BeginContext(2004, 46, false);
#line 64 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
       Write(Html.DisplayFor(modelItem => item.SeatsRemain));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 59, true);
            WriteLiteral("\r\n        </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2110, 42, false);
#line 67 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlaneID));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2220, 50, false);
#line 70 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.OriginLoc1.City));

#line default
#line hidden
            EndContext();
            BeginContext(2270, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2273, 57, false);
#line 70 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.OriginLoc1.CountryName));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2398, 48, false);
#line 73 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.DestLoc1.City));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2449, 55, false);
#line 73 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.DestLoc1.CountryName));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2572, 52, false);
#line 76 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.FlightSeatType.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2624, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2691, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb9d89c2072d48ecb5ba65b0997ced22", async() => {
                BeginContext(2748, 4, true);
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
#line 79 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2756, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2780, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78f07816d88d468382ea289b9f8af812", async() => {
                BeginContext(2839, 6, true);
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
#line 80 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2849, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2873, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0108b22eae9542c6a37c7c5f3d7fecc3", async() => {
                BeginContext(2959, 15, true);
                WriteLiteral("AddFlightStaffs");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2978, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3000, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9357f9becd462fb06de477253caff6", async() => {
                BeginContext(3085, 14, true);
                WriteLiteral("AddFlightPlane");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3103, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 85 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Admin\ViewAllFlights.cshtml"
            }

#line default
#line hidden
            BeginContext(3162, 44, true);
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
