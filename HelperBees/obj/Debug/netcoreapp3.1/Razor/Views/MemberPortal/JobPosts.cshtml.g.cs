#pragma checksum "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\MemberPortal\JobPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7bec69ecb71ca087bada877deb4b84d41732509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPortal_JobPosts), @"mvc.1.0.view", @"/Views/MemberPortal/JobPosts.cshtml")]
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
#line 1 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\_ViewImports.cshtml"
using IntegrationTool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7bec69ecb71ca087bada877deb4b84d41732509", @"/Views/MemberPortal/JobPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPortal_JobPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\MemberPortal\JobPosts.cshtml"
  
    ViewData["Title"] = "Job Posts";
    Layout = "~/Views/Shared/_MemberPortal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Job Postings</h1>

<br />
<div style=""margin:auto;"">
    <div><input type=""button"" value=""Post a New Job"" onclick=""window.location = '/memberPortal/jobsubmission'""/></div><br />
    <table style=""width:90%; border:2px solid black;"">
        <thead>
            <tr>
                <th>Job Title</th>
                <th>Job Type</th>
                <th>Suburb</th>
                <th>Date Submitted</th>
                <th>Expiry Date</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                
                <td><a href=""/memberportal/jobsubmission"">Personal carer two days a week</a></td>
                <td>Regular</td>
                <td>West Pymble NSW 2073</td>
                <td>3rd February 2021</td>
                <td>3rd March 2021</td>
                <td>Active</td>
            </tr>
        </tbody>
    </table><br />
    <div><input type=""button"" value=""Post a New Job"" onclick=""window.location = '/m");
            WriteLiteral("emberPortal/jobsubmission\'\"/></div>\r\n</div>");
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
