#pragma checksum "D:\Sonnet\Git\HelperBees\HelperBees\Views\MemberPortal\AccountDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "917278a9702b4f7193cecd56dd3b6ffa45fe11ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPortal_AccountDetails), @"mvc.1.0.view", @"/Views/MemberPortal/AccountDetails.cshtml")]
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
#line 1 "D:\Sonnet\Git\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sonnet\Git\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sonnet\Git\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917278a9702b4f7193cecd56dd3b6ffa45fe11ea", @"/Views/MemberPortal/AccountDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPortal_AccountDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Sonnet\Git\HelperBees\HelperBees\Views\MemberPortal\AccountDetails.cshtml"
  
    ViewData["Title"] = "Account Details";
    Layout = "~/Views/Shared/_MemberPortal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

</style>

<div>
    <h1>Client Profile</h1>
    <div class='parent'>
        <div style=""display: inline-block; width:65%"">
            <h3>Account Details</h3>
            <input type=""text"" placeholder=""Your First Name"" /><br /><br />
            <input type=""text"" placeholder=""Your Last Name"" /><br /><br />
            <input type=""text"" placeholder=""Email Address"" /><br /><br />
            <input type=""text"" placeholder=""Gender"" /><br /><br />
            <p>
                <span>
                    Are you 18 years or older (you must be 18 years or older to have an account).
                    If no, your parent or guardian must be the account holder.
                </span>
            </p>
            <input type=""text"" placeholder=""Residential Address"" /><br />
            <input type=""text"" placeholder=""Pos Code"" /><br />
            <input type=""text"" placeholder=""Suburb"" /><br />
            <input type=""text"" placeholder=""State"" /><br />
            <input typ");
            WriteLiteral("e=\"text\" placeholder=\"Landline Phone Number\" /><br />\r\n            <input type=\"text\" placeholder=\"Mobile Number\" /><br /><br />\r\n            <div><input type=\"checkbox\" /> Is the support taking place at the same address?</div><br />\r\n            <select>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "917278a9702b4f7193cecd56dd3b6ffa45fe11ea4915", async() => {
                WriteLiteral("What is your Relationship to the Person Who is Receiving the Care?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select>
            <br />
            <div><input type=""button"" value=""Care Recipient Details"" onclick=""window.location = '/memberPortal/carerecipientdetails'"" /></div>
        </div>
        <div style=""display: inline-block; width: 30%"">
            <div>
                <ul>
                    <li> <a href=""/memberPortal/accountdetails""> Account Details</a> </li>
                    <li> <a href=""/memberPortal/carerecipientdetails""> Care Recipient Details</a> </li>
                    <li> <a href=""/memberPortal/medicaldetails""> Medical Details</a> </li>
                    <li> <a href=""/memberPortal/paymentdetails""> Payment Details</a> </li>
                    <li> <a href=""/memberPortal/supportinginfo""> Supporting Information</a> </li>
                </ul>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
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
