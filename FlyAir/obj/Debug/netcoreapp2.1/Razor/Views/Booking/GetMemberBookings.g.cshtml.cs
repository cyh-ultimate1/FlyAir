#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a67491baacb7887814c5a99375994da07874d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_GetMemberBookings), @"mvc.1.0.view", @"/Views/Booking/GetMemberBookings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/GetMemberBookings.cshtml", typeof(AspNetCore.Views_Booking_GetMemberBookings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a67491baacb7887814c5a99375994da07874d0", @"/Views/Booking/GetMemberBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_GetMemberBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlyAir.Models.BookingModels.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/getMemberBookings.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WebCheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
  
    ViewData["Title"] = "GetMemberBookings";
    var idx = 0;
    var retFlightExpired = false;

#line default
#line hidden
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7968d94328874bcdb47bdbb277b4e66b", async() => {
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
            BeginContext(223, 70, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h3>Your Bookings</h3>\r\n\r\n    <div>\r\n");
            EndContext();
#line 14 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(342, 28, true);
            WriteLiteral("        <div class=\"card\">\r\n");
            EndContext();
#line 17 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
              idx++;

#line default
#line hidden
            BeginContext(393, 188, true);
            WriteLiteral("            <div class=\"row\" style=\"font-weight: bold;\">\r\n                <label class=\"control-label col-md-2\">Booking ID:</label>\r\n                <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(582, 7, false);
#line 20 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                  Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(589, 229, true);
            WriteLiteral("</label>\r\n            </div>\r\n            <div>Go Flight</div>\r\n            <div class=\"row\">\r\n                <label class=\"control-label col-md-2\">Departure Date:</label>\r\n                <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(819, 48, false);
#line 25 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                  Write(item.GoFlight.DepartDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(867, 195, true);
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"row\">\r\n                <label class=\"control-label col-md-2\">Departure Time:</label>\r\n                <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(1063, 48, false);
#line 29 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                  Write(item.GoFlight.DepartDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1111, 188, true);
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"row\">\r\n                <label class=\"control-label col-md-2\">Journey:</label>\r\n                <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(1300, 28, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                  Write(item.GoFlight.OriginLoc.City);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1331, 35, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                 Write(item.GoFlight.OriginLoc.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(1366, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1370, 26, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                                                        Write(item.GoFlight.DestLoc.City);

#line default
#line hidden
            EndContext();
            BeginContext(1396, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1399, 33, false);
#line 33 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                                                                                     Write(item.GoFlight.DestLoc.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(1432, 32, true);
            WriteLiteral("</label>\r\n            </div>\r\n\r\n");
            EndContext();
#line 36 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
             if (item.ReturnFlight != null)
            {

#line default
#line hidden
            BeginContext(1524, 243, true);
            WriteLiteral("                <hr />\r\n                <div>Return Flight</div>\r\n                <div class=\"row\">\r\n                    <label class=\"control-label col-md-2\">Departure Date:</label>\r\n                    <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(1768, 52, false);
#line 42 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                      Write(item.ReturnFlight.DepartDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1820, 211, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"control-label col-md-2\">Departure Time:</label>\r\n                    <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(2032, 52, false);
#line 46 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                      Write(item.ReturnFlight.DepartDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(2084, 204, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"control-label col-md-2\">Journey:</label>\r\n                    <label class=\"control-label col-md-10\">");
            EndContext();
            BeginContext(2289, 32, false);
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                      Write(item.ReturnFlight.OriginLoc.City);

#line default
#line hidden
            EndContext();
            BeginContext(2321, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2324, 39, false);
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                         Write(item.ReturnFlight.OriginLoc.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(2363, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2367, 30, false);
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                                                                    Write(item.ReturnFlight.DestLoc.City);

#line default
#line hidden
            EndContext();
            BeginContext(2397, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2400, 37, false);
#line 50 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                                                                                                                                                                     Write(item.ReturnFlight.DestLoc.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(2437, 34, true);
            WriteLiteral("</label>\r\n                </div>\r\n");
            EndContext();
#line 52 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                 if (item.ReturnFlight.DepartDateTime < DateTime.Now)
                {
                    retFlightExpired = true;
                }
                else
                {
                    retFlightExpired = false;
                }

#line default
#line hidden
#line 59 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2748, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2764, 855, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abf1d0ff671940959a95b657e13e3d97", async() => {
                BeginContext(2833, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 62 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                     if (item.GoFlight.DepartDateTime < DateTime.Now && retFlightExpired)
                    {

#line default
#line hidden
                BeginContext(2949, 86, true);
                WriteLiteral("                    <button class=\"btn btn-outline-danger\" disabled>EXPIRED</button>\r\n");
                EndContext();
#line 65 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                    }
                    else
                    {
                        if (!item.HasCheckedIn)
                        {

#line default
#line hidden
                BeginContext(3183, 48, true);
                WriteLiteral("                            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3231, "\"", 3247, 1);
#line 70 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
WriteAttributeValue("", 3239, item.ID, 3239, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3248, 116, true);
                WriteLiteral(" name=\"bookingId\" />\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Check-in\" />\r\n");
                EndContext();
#line 72 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(3448, 98, true);
                WriteLiteral("                            <input type=\"submit\" class=\"btn btn-warning\" value=\"More details\" />\r\n");
                EndContext();
#line 76 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(3596, 16, true);
                WriteLiteral("                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3619, 36, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 82 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\GetMemberBookings.cshtml"
        }

#line default
#line hidden
            BeginContext(3666, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlyAir.Models.BookingModels.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
