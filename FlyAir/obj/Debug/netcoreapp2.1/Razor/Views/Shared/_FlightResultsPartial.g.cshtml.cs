#pragma checksum "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66285bdffb14c52af1094f3e2485f3e8d8c1229e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FlightResultsPartial), @"mvc.1.0.view", @"/Views/Shared/_FlightResultsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FlightResultsPartial.cshtml", typeof(AspNetCore.Views_Shared__FlightResultsPartial))]
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
#line 2 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
using FlyAir.Models.SearchModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66285bdffb14c52af1094f3e2485f3e8d8c1229e", @"/Views/Shared/_FlightResultsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FlightResultsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlyAir.ViewModels.FlightsInputsVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
  
    var isAdjustGoFlight = Model.adjustGoFlight;


#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
 if (isAdjustGoFlight && Model.GoFlights != null)
{
    if (Model.GoFlights.Count() > 0)
    {

#line default
#line hidden
            BeginContext(237, 326, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr style=""font-weight: bold;"">
                    <td></td>
                    <td>Departure Time</td>
                    <td>Arrival Time</td>
                    <td>Selection</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                 foreach (var item in Model.GoFlights)
                {

#line default
#line hidden
            BeginContext(638, 199, true);
            WriteLiteral("                    <tr class=\"tblRow tblRowGo\">\r\n                        <td></td>\r\n                        <td>\r\n                            <div class=\"col\">\r\n                                <div>");
            EndContext();
            BeginContext(838, 39, false);
#line 28 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.DepartDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(877, 45, true);
            WriteLiteral("</div>\r\n                                <div>");
            EndContext();
            BeginContext(923, 39, false);
#line 29 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.DepartDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(962, 189, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"col\">\r\n                                <div>");
            EndContext();
            BeginContext(1152, 36, false);
#line 34 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.ArrDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1188, 45, true);
            WriteLiteral("</div>\r\n                                <div>");
            EndContext();
            BeginContext(1234, 36, false);
#line 35 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.ArrDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1270, 295, true);
            WriteLiteral(@"</div>
                            </div>
                        </td>
                        <td>
                            <div class=""chkBoxWrapper"">
                                <label>
                                    <input type=""radio"" name=""oneIdSelGo"" class=""oneIdSelGo""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1565, "\"", 1581, 1);
#line 41 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
WriteAttributeValue("", 1573, item.ID, 1573, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1582, 232, true);
            WriteLiteral(" />\r\n                                    <span class=\"customChkBox customChkBoxBorder\"></span>\r\n                                </label>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 47 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1833, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 50 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1897, 42, true);
            WriteLiteral("        <div>No Flights Available.</div>\r\n");
            EndContext();
#line 54 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
    }


#line default
#line hidden
            BeginContext(1948, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 57 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
}

#line default
#line hidden
            BeginContext(1963, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 61 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
 if (!isAdjustGoFlight && Model.ReturnFlights != null)
{

    if (Model.ReturnFlights.Count() > 0)
    {

#line default
#line hidden
            BeginContext(2079, 326, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr style=""font-weight: bold;"">
                    <td></td>
                    <td>Departure Time</td>
                    <td>Arrival Time</td>
                    <td>Selection</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 76 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                 foreach (var item in Model.ReturnFlights)
                {

#line default
#line hidden
            BeginContext(2484, 200, true);
            WriteLiteral("                    <tr class=\"tblRow tblRowRet\">\r\n                        <td></td>\r\n                        <td>\r\n                            <div class=\"col\">\r\n                                <div>");
            EndContext();
            BeginContext(2685, 39, false);
#line 82 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.DepartDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2724, 45, true);
            WriteLiteral("</div>\r\n                                <div>");
            EndContext();
            BeginContext(2770, 39, false);
#line 83 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.DepartDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(2809, 189, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"col\">\r\n                                <div>");
            EndContext();
            BeginContext(2999, 36, false);
#line 88 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.ArrDateTime.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3035, 45, true);
            WriteLiteral("</div>\r\n                                <div>");
            EndContext();
            BeginContext(3081, 36, false);
#line 89 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                                Write(item.ArrDateTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(3117, 297, true);
            WriteLiteral(@"</div>
                            </div>
                        </td>
                        <td>
                            <div class=""chkBoxWrapper"">
                                <label>
                                    <input type=""radio"" name=""oneIdSelRet"" class=""oneIdSelRet""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3414, "\"", 3430, 1);
#line 95 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
WriteAttributeValue("", 3422, item.ID, 3422, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3431, 232, true);
            WriteLiteral(" />\r\n                                    <span class=\"customChkBox customChkBoxBorder\"></span>\r\n                                </label>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 101 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(3682, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 104 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3746, 42, true);
            WriteLiteral("        <div>No Flights Available.</div>\r\n");
            EndContext();
#line 108 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\Shared\_FlightResultsPartial.cshtml"
    }

}

#line default
#line hidden
            BeginContext(3800, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlyAir.ViewModels.FlightsInputsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
