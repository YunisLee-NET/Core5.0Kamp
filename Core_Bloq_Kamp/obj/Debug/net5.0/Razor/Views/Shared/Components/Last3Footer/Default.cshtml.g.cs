#pragma checksum "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de76be7dd2ceb835bfe71f48db028deeaa28db0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last3Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last3Footer/Default.cshtml")]
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
#line 1 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\_ViewImports.cshtml"
using Core_Bloq_Kamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\_ViewImports.cshtml"
using Core_Bloq_Kamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de76be7dd2ceb835bfe71f48db028deeaa28db0d", @"/Views/Shared/Components/Last3Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Last3Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"blog-grids row mb-3\">\r\n");
#nullable restore
#line 5 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
     foreach (var x in Model.TakeLast(3))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-5 blog-grid-left\">\r\n            <br />\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 217, "\"", 255, 3);
            WriteAttributeValue("", 224, "/Default/BlogDetails/", 224, 21, true);
#nullable restore
#line 9 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
WriteAttributeValue("", 245, x.BlogID, 245, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 254, "/", 254, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img style=\"height: 120px; width: 180px;\"");
            BeginWriteAttribute("src", " src=\"", 316, "\"", 334, 1);
#nullable restore
#line 10 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
WriteAttributeValue("", 322, x.BlogImage, 322, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 366, "\"", 372, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n            <br />\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n            <br />\r\n            <h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 572, 3);
            WriteAttributeValue("", 541, "/Default/BlogDetails/", 541, 21, true);
#nullable restore
#line 17 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
WriteAttributeValue("", 562, x.BlogID, 562, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 571, "/", 571, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
                                                     Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
                                             Write(((DateTime)x.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 26 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last3Footer\Default.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
