#pragma checksum "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fdf77cc8d902d6ec2845fa481b849114198369a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dummy_TestChat), @"mvc.1.0.view", @"/Views/dummy/TestChat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/dummy/TestChat.cshtml", typeof(AspNetCore.Views_dummy_TestChat))]
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
#line 1 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml"
using FlyAir.Models.IdentityEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdf77cc8d902d6ec2845fa481b849114198369a", @"/Views/dummy/TestChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7288a1a1ae2e73b68aba0a7b62a7dd77c8e07", @"/Views/_ViewImports.cshtml")]
    public class Views_dummy_TestChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml"
  
    ViewData["Title"] = "TestChat";
    var username = UserManager.GetUserName(User);

#line default
#line hidden
            BeginContext(228, 2337, true);
            WriteLiteral(@"
<style>
    /*body{
        position: relative;
    }*/
    .mainWrap {
        height: 63vh;
        padding: 0px;
        overflow-y: auto;
        overflow-x: hidden;
    }
    .msgInput {
        position: fixed;
        bottom: 0vh;
        z-index: +99;
        background-color: hotpink;
        width: 100%;
        height: 60px;
        padding: 10px;
    }
    .msgInputWrapper{
        
    }
    .myMessages > div {
        word-wrap: break-word;
    }
        .myMessages > div > p {
            border-radius: 5px;
            
            padding: 5px;
            display: inline-block;
        }
    .msgRight {
        text-align: right;
        padding-left: 70px;
        padding-right: 10px;
        word-wrap: break-word;
    }
        .msgRight > p {
            background-color: greenyellow;
        }
    .msgLeft {
        padding-left: 10px;
        padding-right: 70px;
    }
        .msgLeft > p {
            background-color: lightpink;
       ");
            WriteLiteral(@" }
    .contactRadioWrapper{
        padding: 5px;
    }
    .contactRadioWrapper input[name='contactRadio'] {
        display: none;
    }
    .contactRadioWrapper label {
        cursor: pointer;
    }
    .highlightGreen{
        background-color: var(--myGreen);
    }
    .contactList {
        height: 63vh;
        overflow-y: auto;
        overflow-x: hidden;
    }
</style>

<h2>Your Chat</h2>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""container-fluid contactList col-3"">

        </div>
        <div class=""container mainWrap col-9"">
            <div class="" myMessages"">

            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <hr />
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid msgInputWrapper"">
    <div class=""row msgInput"">
        <div class=""col-11"">
            <input type=""text"" id=""messageInput"" class=""form-control"" pl");
            WriteLiteral(@"aceholder=""Enter message here""/>
        </div>
        <div class=""col-1"">
            <input type=""button"" id=""sendButton"" value=""Send"" class=""btn btn-info""/>
            <input type=""button"" id=""joinButton"" value=""Join"" class=""btn btn-info""/>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2582, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2588, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d6ee90df1b49caa2a44d6ae9d10ae2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2649, 1140, true);
                WriteLiteral(@"

    <script>
        $(function () {
            $(""footer"").remove();
            //""use strict"";

            var contactRadio = $('input:radio[name=""contactRadio""]');
            var contactRadioChkdStr = 'input[name=""contactRadio""]:checked';
            var prevContactRadioId = """";
            var contactList = $("".contactList"");
            var userList = $(""#userList"");
            var mainWrap = $("".mainWrap"");
            var messageInput = $(""#messageInput"");
            var myMessages = $("".myMessages"");
            var sendButton = $(""#sendButton"");
            var connId = """";
            var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

            //Disable send button until connection is established
            sendButton.attr(""disabled"", true);

            //connection.on(""ReceivePrivateMessage"", function ( message) {
            connection.on(""ReceiveGroupMessage"", function ( message, user) {
            var msg = message.replace(/&/g");
                WriteLiteral(", \"&amp;\").replace(/</g, \"&lt;\").replace(/>/g, \"&gt;\");\r\n            var encodedMsg = \"\";\r\n            if (user == \'");
                EndContext();
                BeginContext(3790, 8, false);
#line 134 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml"
                    Write(username);

#line default
#line hidden
                EndContext();
                BeginContext(3798, 2156, true);
                WriteLiteral(@"') {
                encodedMsg = msg;
                myMessages.append('<div class=""msgRight""><p>' + encodedMsg + '</p></div>');
            } else {
                encodedMsg = user + "" : <br/>"" + msg;
                myMessages.append('<div class=""msgLeft""><p>' + encodedMsg + '</p></div>');
            }
            mainWrap.animate({ scrollTop: myMessages.height() });
            });

            connection.on(""UserConnected"", function (connectionId, username) {
                //userList.append('<option value=""' + connectionId + '"">' + username + '</option>');
                connId = connectionId;
                contactList.append('<div class=""contactRadioWrapper""><label><input name=""contactRadio"" type=""radio"" data-contact-id=""' + connectionId + '""/><span>' + username + '</span></label></div>' );
            });

            connection.on(""UserDisconnected"", function (connectionId) {
                $('[data-contact-id=""' + connectionId + '""]').parent().remove();
            });

");
                WriteLiteral(@"            connection.start().then(function () {
                //document.getElementById(""sendButton"").disabled = false;
                //$(""#userList option:first"").attr('selected', 'selected')
                //connection.invoke(""JoinGroup"", userList.val()).catch(function (err) {
                //    return console.error(err.toString());
                //});
            }).catch(function (err) {
                return console.error(err.toString());
            });

            messageInput.on('input paste', function () {
                if (messageInput.val() !== """") {
                    enableSendBtn(true);
                } else {
                    enableSendBtn(false);
                }
            });

            $(document).keypress(function (e) {
                var key = e.which;
                if (key == 13 && !sendButton.is("":disabled""))  // the enter key code
                {
                    sendButton.click();
                    return false;
             ");
                WriteLiteral("   }\r\n            });\r\n\r\n            sendButton.on(\"click\", function (event) {\r\n                var user = \'");
                EndContext();
                BeginContext(5955, 8, false);
#line 182 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml"
                       Write(username);

#line default
#line hidden
                EndContext();
                BeginContext(5963, 447, true);
                WriteLiteral(@"';
                var message = messageInput.val();
                //connId = userList.val();
                //alert(connId);
                //connection.invoke(""SendPrivateMessage"", connId, message).catch(function (err) {
                //    return console.error(err.toString());
                //});
                connection.invoke(""SendMessageToGroup"", $(""input[name='contactRadio']:checked"").attr(""data-contact-id""), message, '");
                EndContext();
                BeginContext(6411, 8, false);
#line 189 "S:\soft_projects\VS2017_projs\FlyAir\FlyAir\Views\dummy\TestChat.cshtml"
                                                                                                                              Write(username);

#line default
#line hidden
                EndContext();
                BeginContext(6419, 2292, true);
                WriteLiteral(@"').catch(function (err) {
                    return console.error(err.toString());
                });

                event.preventDefault();
                messageInput.val("""");
                enableSendBtn(false);
            });

            //change when contact Radio is changed
            contactList.on(""change"", ""input[name = 'contactRadio']"", function () {
                if (prevContactRadioId !== """") {
                    ResetPreviousSelectedRadio(prevContactRadioId, ""highlightGreen"");
                }
                prevContactRadioId = HighlightCurrContact(contactRadioChkdStr, ""highlightGreen"", false);
                //alert($(""input[name='contactRadio']:checked"").attr(""data-contact-id""));
                myMessages.children().remove();
                connection.invoke(""JoinGroup"", $(""input[name='contactRadio']:checked"").attr(""data-contact-id"")).catch(function (err) {
                    return console.error(err.toString());
                });
            });


  ");
                WriteLiteral(@"          //userList.change(function (e) {
            //    connection.invoke(""JoinGroup"", userList.val()).catch(function (err) {
            //        return console.error(err.toString());
            //    });
            //    e.preventDefault();
            //});

            function enableSendBtn(enableTrue) {
                if (enableTrue) {
                    sendButton.attr(""disabled"", false);
                } else {
                    sendButton.attr(""disabled"", true);
                }
            }

            function HighlightCurrContact(elName, bgColor, colorIsWhite) {
                if (!colorIsWhite) {
                    $(elName).parent().parent().addClass(bgColor).css(""font-weight"", ""bold"");
                } else {
                    $(elName).parent().parent().css(""font-weight"", ""bold"").addClass(bgColor).css(""color"", ""white"");
                }
                return $(elName).attr(""data-contact-id"");
            }

            function ResetPreviousSelect");
                WriteLiteral("edRadio(previousRadioId, bgColor) {\r\n                $(\"input[data-contact-id=\'\" + previousRadioId + \"\']\").parent().parent().removeClass(bgColor).css(\"color\", \"black\").css(\"font-weight\", \"normal\");\r\n            }\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CustomUser> SignInManager { get; private set; }
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
