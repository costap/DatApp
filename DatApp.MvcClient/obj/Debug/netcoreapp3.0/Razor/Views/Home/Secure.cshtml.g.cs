#pragma checksum "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "521e241612d5a010efa2ea9eed897ba5f49785c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secure), @"mvc.1.0.view", @"/Views/Home/Secure.cshtml")]
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
#line 1 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/_ViewImports.cshtml"
using DatApp.MvcClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/_ViewImports.cshtml"
using DatApp.MvcClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521e241612d5a010efa2ea9eed897ba5f49785c1", @"/Views/Home/Secure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4465679ad6e14c521e583598908871414927cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml"
  
    ViewData["Title"] = "Secure";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Secure</h2>\n\n<h3>User Claims</h3>\n\n<dl>\n");
#nullable restore
#line 10 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 12 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dt>");
#nullable restore
#line 13 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n");
#nullable restore
#line 14 "/Users/pedro.costa/src/sandbox/dotnet/DatApp/DatApp.MvcClient/Views/Home/Secure.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\n");
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