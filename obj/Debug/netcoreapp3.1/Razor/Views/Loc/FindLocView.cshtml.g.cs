#pragma checksum "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\Loc\FindLocView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a25ff756d8457c7c9a924649705ede934001a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loc_FindLocView), @"mvc.1.0.view", @"/Views/Loc/FindLocView.cshtml")]
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
#line 1 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\_ViewImports.cshtml"
using CompanyWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\_ViewImports.cshtml"
using CompanyWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a25ff756d8457c7c9a924649705ede934001a5", @"/Views/Loc/FindLocView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958cb35f2ff0a771278f879044c61f1c13a7fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Loc_FindLocView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\Loc\FindLocView.cshtml"
  
    ViewBag.Title = "Location";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Location</h2>\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr> <th>Location ID</th> <th>City</th>  <th>Street</th>   </tr>\r\n    </thead>\r\n    <tbody>\r\n      \r\n            <tr>\r\n                <td>");
#nullable restore
#line 16 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\Loc\FindLocView.cshtml"
               Write(Model.LocID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\Loc\FindLocView.cshtml"
               Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "D:\Jihad_Ali_Mohammad_Webproject\CompanyWebApp\Views\Loc\FindLocView.cshtml"
               Write(Model.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loc> Html { get; private set; }
    }
}
#pragma warning restore 1591
