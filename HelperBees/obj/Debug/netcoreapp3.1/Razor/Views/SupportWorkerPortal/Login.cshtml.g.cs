#pragma checksum "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\SupportWorkerPortal\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac07b86a2ae241f47cb38df81cf92b0b1de9f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupportWorkerPortal_Login), @"mvc.1.0.view", @"/Views/SupportWorkerPortal/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac07b86a2ae241f47cb38df81cf92b0b1de9f9d", @"/Views/SupportWorkerPortal/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebbd0d61602e875c87018bf3b4eb8a5c46f6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_SupportWorkerPortal_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\TFS-2019sonnet\SourceTree\HelperBees\HelperBees\Views\SupportWorkerPortal\Login.cshtml"
  
    ViewData["Title"] = "Support Worker Login";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Support Coordinator Login</h1>

<div>
    
    <div>
        <input type=""text"" placeholder=""Enter username"">
    </div>
    <div><input type=""password"" placeholder=""Enter password""></div>
    <div>
        <button type=""button"" onclick=""window.location = '/supportworkerportal/dashboard'"">Login</button>
    </div>
    <br />
    <br />
    <div>
        <button type=""button"" onclick=""window.location = '/memberportal/login'"">Go to Member Portal</button>
        <button type=""button"" onclick=""window.location = '/supportcoordinator/login'"">Go to Support Coordinator</button>
    </div>
</div>");
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
