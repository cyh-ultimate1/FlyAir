#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba9bc210cd6ed7583a23d3772dce5284102f76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_FlightResults), @"mvc.1.0.view", @"/Views/Flight/FlightResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flight/FlightResults.cshtml", typeof(AspNetCore.Views_Flight_FlightResults))]
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
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
using FlyAir.Models.SearchModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba9bc210cd6ed7583a23d3772dce5284102f76d", @"/Views/Flight/FlightResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_FlightResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlyAir.ViewModels.FlightsInputsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick-1.8.1/slick.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick-1.8.1/slick-theme.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/flightResults.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Flight/flightResults.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
  
    ViewData["Title"] = "FlightResults";
    var todayDate = DateTime.Today;
    var searchFlightTemp = SessionHelper.GetObjectFromJson<SearchFlight>(Context.Session, "searchFlightTemp");
    var goDate = searchFlightTemp.DepartDate;
    var returnDate = searchFlightTemp.ReturnDate;

#line default
#line hidden
            BeginContext(373, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(375, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d47114b851cc4910bcd834ae84520512", async() => {
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
            BeginContext(433, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(435, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c561afec35904fea8db7a24cb4d23bbf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(501, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40025a4a14f947948606767d9149626e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(555, 56, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid marginBtmAdd\">\r\n\r\n    ");
            EndContext();
            BeginContext(611, 1610, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93755ec1625a425fb7acb71c8a159341", async() => {
                BeginContext(696, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(707, 23, false);
#line 19 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(730, 14, true);
                WriteLiteral("\r\n        <h4>");
                EndContext();
                BeginContext(745, 16, false);
#line 20 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
       Write(Model.OriginName);

#line default
#line hidden
                EndContext();
                BeginContext(761, 5, true);
                WriteLiteral("  -  ");
                EndContext();
                BeginContext(767, 14, false);
#line 20 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                             Write(Model.DestName);

#line default
#line hidden
                EndContext();
                BeginContext(781, 146, true);
                WriteLiteral("</h4><span class=\"asteriskSign\" id=\"goFlightErr\">&nbsp;</span>\r\n        <div class=\"goSlider sliderCommon container\" data-class-type=\"goSlider\">\r\n");
                EndContext();
#line 22 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
             for (int i = -7; i < 7; i++)
            {

#line default
#line hidden
                BeginContext(985, 46, true);
                WriteLiteral("                <div class=\"slide\" data-date=\"");
                EndContext();
                BeginContext(1032, 60, false);
#line 24 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                                         Write(Convert.ToDateTime(goDate.AddDays(i)).ToString("MM/dd/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1092, 2, true);
                WriteLiteral("\">");
                EndContext();
                BeginContext(1095, 37, false);
#line 24 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                                                                                                        Write(goDate.AddDays(i).ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1132, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 25 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
            }

#line default
#line hidden
                BeginContext(1155, 52, true);
                WriteLiteral("        </div>\r\n        <div id=\"goFlightResults\">\r\n");
                EndContext();
#line 28 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
               Model.adjustGoFlight = true; 

#line default
#line hidden
                BeginContext(1254, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1267, 55, false);
#line 29 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
       Write(await Html.PartialAsync("_FlightResultsPartial", Model));

#line default
#line hidden
                EndContext();
                BeginContext(1322, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 31 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
         if (Model.ReturnFlights != null)
        {

#line default
#line hidden
                BeginContext(1394, 16, true);
                WriteLiteral("            <h4>");
                EndContext();
                BeginContext(1411, 14, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
           Write(Model.DestName);

#line default
#line hidden
                EndContext();
                BeginContext(1425, 5, true);
                WriteLiteral("  -  ");
                EndContext();
                BeginContext(1431, 16, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                               Write(Model.OriginName);

#line default
#line hidden
                EndContext();
                BeginContext(1447, 153, true);
                WriteLiteral("</h4><span class=\"asteriskSign\" id=\"retFlightErr\">&nbsp;</span>\r\n            <div class=\"retSlider sliderCommon container\" data-class-type=\"retSlider\">\r\n");
                EndContext();
#line 35 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                 for (int i = -7; i < 7; i++)
                {

#line default
#line hidden
                BeginContext(1666, 50, true);
                WriteLiteral("                    <div class=\"slide\" data-date=\"");
                EndContext();
                BeginContext(1717, 64, false);
#line 37 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                                             Write(Convert.ToDateTime(returnDate.AddDays(i)).ToString("MM/dd/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1781, 2, true);
                WriteLiteral("\">");
                EndContext();
                BeginContext(1784, 41, false);
#line 37 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                                                                                                                Write(returnDate.AddDays(i).ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1825, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 38 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                }

#line default
#line hidden
                BeginContext(1852, 61, true);
                WriteLiteral("            </div>\r\n            <div id=\"retFlightResults\">\r\n");
                EndContext();
#line 41 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                   Model.adjustGoFlight = false; 

#line default
#line hidden
                BeginContext(1965, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1982, 55, false);
#line 42 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
           Write(await Html.PartialAsync("_FlightResultsPartial", Model));

#line default
#line hidden
                EndContext();
                BeginContext(2037, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 44 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
        }

#line default
#line hidden
                BeginContext(2070, 144, true);
                WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n        <input type=\"submit\" class=\"btn btn-danger btn-red\" value=\"NEXT\" id=\"submitBtn\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2221, 74, true);
            WriteLiteral("\r\n    <div class=\"popup\" onclick=\"myFunction()\">\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2312, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2318, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfe461ac493249549ff26bdeb24fbbe4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2370, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2376, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa03255dc4e14856a9f6ea9179eb0ca0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2437, 941, true);
                WriteLiteral(@"
    <script>
        //===== variables
        var goSlider = $("".goSlider"");
        var slide = $("".slide"");
        var departDateIn = """";
        var goFlightResults = $(""#goFlightResults"");
        var retFlightResults = $(""#retFlightResults"");
        var departDateIn = """", returnDateIn = """", parentClass = """";
        var isAdjustGoFlight = true;

        //===============implementation
        //when the slide of the slider is clicked, it becomes active slide and related flight details are obtained from ajax
        slide.click(function () {
            var slide_active = parseInt($(this).attr('data-slick-index'));
            parentClass = $(this).parent().parent().parent().attr('data-class-type');
            $(""."" + parentClass).slick('slickGoTo', slide_active);

            if (parentClass === ""goSlider"") {
                departDateIn = $(this).attr(""data-date"");
                returnDateIn = '");
                EndContext();
                BeginContext(3379, 70, false);
#line 77 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                           Write(Convert.ToDateTime(searchFlightTemp.ReturnDate).ToString("MM/dd/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3449, 133, true);
                WriteLiteral("\';\r\n                isAdjustGoFlight = true;\r\n            } else if (parentClass === \"retSlider\") {\r\n                departDateIn = \'");
                EndContext();
                BeginContext(3583, 70, false);
#line 80 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                           Write(Convert.ToDateTime(searchFlightTemp.DepartDate).ToString("MM/dd/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3653, 442, true);
                WriteLiteral(@"';
                returnDateIn = $(this).attr(""data-date"");
                isAdjustGoFlight = false;
            }
            //alert(""current adjust GO: "" + isAdjustGoFlight);
            getFlightAjax(departDateIn, returnDateIn, isAdjustGoFlight);
        });



        //===================functions
        function getFlightAjax(departDateIn, returnDateIn, isAdjustGoFlight) {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(4096, 40, false);
#line 93 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Flight\FlightResults.cshtml"
                 Write(Url.Content("/Flight/SearchFlightShort"));

#line default
#line hidden
                EndContext();
                BeginContext(4136, 1079, true);
                WriteLiteral(@"',
                type: ""POST"",
                contentType: ""application/json; charset=utf-8;"",
                //datatype is what type Jquery ajax call expects in return.
                dataType: ""html"",
                data: JSON.stringify({
                    departDate: departDateIn,
                    returnDate: returnDateIn,
                    //departDate: ""05/03/2019"",
                    //returnDate: ""06/03/2019"",
                    toAdjustGoFlight: isAdjustGoFlight
                }),
                headers: {
                    RequestVerificationToken:
                        $('input:hidden[name=""__RequestVerificationToken""]').val()
                },
                async: true,
                success: function (respData) {
                    if (isAdjustGoFlight) {
                        goFlightResults.html(respData);
                    } else if (!isAdjustGoFlight) {
                        retFlightResults.html(respData);
                    }

       ");
                WriteLiteral("         }\r\n            });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlyAir.ViewModels.FlightsInputsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
