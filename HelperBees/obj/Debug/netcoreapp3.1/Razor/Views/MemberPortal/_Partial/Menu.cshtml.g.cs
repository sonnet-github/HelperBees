#pragma checksum "D:\Sonnet\Git\HelperBees\HelperBees\Views\MemberPortal\_Partial\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7cc8a06b0589a27384b16b6753898f05890ebd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberPortal__Partial_Menu), @"mvc.1.0.view", @"/Views/MemberPortal/_Partial/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7cc8a06b0589a27384b16b6753898f05890ebd5", @"/Views/MemberPortal/_Partial/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberPortal__Partial_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .ulxmenu {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
    }

    .lixmenu {
        float: right;
    }

    .lixmenu a {
        display: block;
        padding: 8px;
    }
</style>

<header>
        <div style="" background-color: #dddddd;"">
            <div style=""float:right;""><label >Raymond Milca</label>&nbsp;<input  type=""button"" value=""Logout"" onclick=""window.location = '/memberPortal/login'""/></div>
            <br />
            <br />
            <div>
                <ul class=""ulxmenu"">
                    <li class=""lixmenu""> <a href=""/memberPortal/myaccount""> My Account</a> </li>
                    <li class=""lixmenu""> <a href=""#""> Billings</a> </li>
                    <li class=""lixmenu""> <a href=""/memberPortal/supportworkers""> Support Workers</a> </li>
                    <li class=""lixmenu""> <a href=""/memberportal/jobposts""> Job Postings</a> </li>
                    <li class=""lixmenu""> <a href=");
            WriteLiteral(@"""/memberportal/timesheets""> Timesheets</a> </li>
                    <li class=""lixmenu""> <a href=""/memberportal/inbox""> Inbox</a> </li>
                    <li class=""lixmenu""> <a href=""/memberportal/dashboard""> Dashboard</a> </li>
                </ul>
            </div>
        </div>

</header>
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