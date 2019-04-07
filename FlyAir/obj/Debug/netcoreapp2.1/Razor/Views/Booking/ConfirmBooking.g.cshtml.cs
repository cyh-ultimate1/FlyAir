#pragma checksum "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3ead96f511d800756df628ca7311f0c669d338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ConfirmBooking), @"mvc.1.0.view", @"/Views/Booking/ConfirmBooking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/ConfirmBooking.cshtml", typeof(AspNetCore.Views_Booking_ConfirmBooking))]
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
#line 1 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
using FlyAir.Models.BookingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3ead96f511d800756df628ca7311f0c669d338", @"/Views/Booking/ConfirmBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_ConfirmBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GoToFillInBookingDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
  
    ViewData["Title"] = "ConfirmBooking";
    var bookingDetails = SessionHelper.GetObjectFromJson<BookingVM>(Context.Session, "tempBookingVMDetails");
    int guestCount = 0;

#line default
#line hidden
            BeginContext(223, 63, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h2>Confirm Booking</h2>\r\n    ");
            EndContext();
            BeginContext(286, 1455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527d8dd8c5954f79909c357523d24b2b", async() => {
                BeginContext(359, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
         foreach (var b in bookingDetails.BookingNonMembers)
        {

#line default
#line hidden
                BeginContext(434, 123, true);
                WriteLiteral("            <div class=\"card container\">\r\n                <div class=\"form-group\">\r\n                    <div><strong>Guest ");
                EndContext();
                BeginContext(559, 12, false);
#line 16 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
                                   Write(++guestCount);

#line default
#line hidden
                EndContext();
                BeginContext(572, 172, true);
                WriteLiteral("</strong></div>\r\n                    <div class=\"col-md-12 row\">\r\n                        <div class=\"col-md-3\">Name: </div>\r\n                        <div class=\"col-md-9\">");
                EndContext();
                BeginContext(745, 6, false);
#line 19 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
                                         Write(b.Name);

#line default
#line hidden
                EndContext();
                BeginContext(751, 190, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-md-12 row\">\r\n                        <div class=\"col-md-3\">Age: </div>\r\n                        <div class=\"col-md-9\">");
                EndContext();
                BeginContext(942, 5, false);
#line 23 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
                                         Write(b.Age);

#line default
#line hidden
                EndContext();
                BeginContext(947, 200, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-md-12 row\">\r\n                        <div class=\"col-md-3\">Date Of Birth: </div>\r\n                        <div class=\"col-md-9\">");
                EndContext();
                BeginContext(1148, 39, false);
#line 27 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
                                         Write(b.DateOfBirth.Value.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1187, 198, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-md-12 row\">\r\n                        <div class=\"col-md-3\">Passport ID: </div>\r\n                        <div class=\"col-md-9\">");
                EndContext();
                BeginContext(1386, 13, false);
#line 31 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
                                         Write(b.PassportNum);

#line default
#line hidden
                EndContext();
                BeginContext(1399, 100, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
                EndContext();
#line 36 "S:\soft_projects\VS2017_projs\FlyAirGit\FlyAir\Views\Booking\ConfirmBooking.cshtml"
        }

#line default
#line hidden
                BeginContext(1510, 106, true);
                WriteLiteral("\r\n        <div><input type=\"submit\" class=\"btn btn-danger btn-red\" value=\"CONFIRM\" /></div>\r\n        <div>");
                EndContext();
                BeginContext(1616, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc720219f1f647de893cea8a558a7625", async() => {
                    BeginContext(1714, 4, true);
                    WriteLiteral("EDIT");
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
                BeginContext(1722, 12, true);
                WriteLiteral("</div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(1741, 28, true);
            WriteLiteral("\r\n    \r\n    <br />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
