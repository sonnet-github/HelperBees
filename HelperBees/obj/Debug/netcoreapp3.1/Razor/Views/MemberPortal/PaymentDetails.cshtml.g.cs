#pragma checksum "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\MemberPortal\PaymentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac4bfdd968768173b7707269e00250fdfbd1652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPortal_PaymentDetails), @"mvc.1.0.view", @"/Views/MemberPortal/PaymentDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac4bfdd968768173b7707269e00250fdfbd1652", @"/Views/MemberPortal/PaymentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPortal_PaymentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\MemberPortal\PaymentDetails.cshtml"
  
    ViewData["Title"] = "Payment Details";
    Layout = "~/Views/Shared/_MemberPortal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Client Profile</h1>

<div class='parent'>
    <div style=""display: inline-block; width:65%"">
        <h3>Payment Details</h3>
        <div>
            Do you have some form of Government funding? <input type=""radio"" name=""gfunding"" /> Yes <input type=""radio"" name=""gfunding"" /> No
        </div>
        <div><input type=""button"" value=""Supporting Information Details"" onclick=""window.location = '/memberPortal/supportinginfo'"" /></div>
    </div>
    <div style=""display: inline-block; width: 30%"">
        <div>
            <ul>
                <li> <a href=""/memberPortal/accountdetails""> Account Details</a> </li>
                <li> <a href=""/memberPortal/carerecipientdetails""> Care Recipient Details</a> </li>
                <li> <a href=""/memberPortal/medicaldetails""> Medical Details</a> </li>
                <li> <a href=""/memberPortal/paymentdetails""> Payment Details</a> </li>
                <li> <a href=""/memberPortal/supportinginfo""> Supporting Information</a> </li>
            <");
            WriteLiteral("/ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
