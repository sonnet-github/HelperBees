#pragma checksum "D:\Solutions\HelperBees\HelperBees\Views\MemberPortal\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73714b1f9d9a6730ebdfbdf24aabfa5be57d4a07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPortal_Dashboard), @"mvc.1.0.view", @"/Views/MemberPortal/Dashboard.cshtml")]
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
#line 1 "D:\Solutions\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Solutions\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Solutions\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73714b1f9d9a6730ebdfbdf24aabfa5be57d4a07", @"/Views/MemberPortal/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPortal_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Solutions\HelperBees\HelperBees\Views\MemberPortal\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_MemberPortal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .div-complete-profile {
        text-align: center;
        margin: auto;
        width: 98%;
        border: 2px solid black;
        padding: 10px;
        background-color: #EA9999;
    }

    #container {
        height: 100%;
        width: 100%;
        font-size: 0;
    }

    .left, .middle, .right {
        display: inline-block;
        *display: inline;
        zoom: 1;
        vertical-align: top;
        font-size: 12px;
    }

    .left {
        width: 33%;
    }

    .middle {
        width: 33%;
    }

    .right {
        width: 33%;
    }

    .dashboard-items {
        border: 2px solid black;
        cursor: pointer;
    }
</style>

<div>
    <br />
    <div class=""div-complete-profile"">
        <h1>Complete Your Client Profile</h1>
        <div style=""width:80%; margin:auto; padding:10px;"">
            <p><span>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna al");
            WriteLiteral(@"iqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</span></p>
        </div>
        <div style="" margin: auto; padding: 10px;"">
            <input type=""button"" value=""Complete Your Profile"" onclick=""window.location = '/memberPortal/accountdetails'""/>
        </div>
    </div>
    <br />
    <div id=""container"" style=""width:98%; margin: auto;"">
        <div class=""dashboard-items left"" onclick=""window.location = '/memberPortal/accountdetails'"">
            <h3>Profile</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        </div>
        <div class=""dashboard-items middle"" onclick=""window.location = '/memberPortal/inbox'"">
            <h3>Inbox</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        </div>
        <div class=""dashboard-items right"" onclick=""window.location = '/memberPortal/jobposts'"">
            <h3>Job Postings</h3>
            <p>Lorem ipsum dolo");
            WriteLiteral(@"r sit amet, consectetur adipiscing elit</p>
        </div>
    </div>
    <br />
    <div id=""container"" style=""width:98%; margin: auto;"" >
        <div class=""dashboard-items left"" onclick=""window.location = '/memberPortal/timesheets'"">
            <h3>Timesheets</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        </div>
        <div class=""dashboard-items middle"" onclick=""window.location = '/memberPortal/supportworkers'"">
            <h3>Support Workers</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        </div>
        <div class=""dashboard-items right"">
            <h3>Billings</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        </div>
    </div>
    <div id=""container"" style=""width:98%; margin: auto;"" onclick=""window.location = '/memberPortal/myaccount'"">
        <div class=""dashboard-items middle"">
            <h3>My Account</h3>
            <p>Lorem ipsum dolor sit amet, conse");
            WriteLiteral("ctetur adipiscing elit</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
