#pragma checksum "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4919fbb3d70dd00c98b122d1603ad74cedf77bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last5List_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last5List/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4919fbb3d70dd00c98b122d1603ad74cedf77bd0", @"/Views/Shared/Components/Last5List/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Last5List_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Son 5 bloq</h4>\r\n");
#nullable restore
#line 5 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
     foreach(var x in Model.TakeLast(5))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 259, "\"", 297, 3);
            WriteAttributeValue("", 266, "/Default/BlogDetails/", 266, 21, true);
#nullable restore
#line 9 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
WriteAttributeValue("", 287, x.BlogID, 287, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 296, "/", 296, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 325, "\"", 343, 1);
#nullable restore
#line 10 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
WriteAttributeValue("", 331, x.BlogImage, 331, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 362, "\"", 368, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 512, "\"", 550, 3);
            WriteAttributeValue("", 519, "/Default/BlogDetails/", 519, 21, true);
#nullable restore
#line 16 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
WriteAttributeValue("", 540, x.BlogID, 540, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 549, "/", 549, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
                                                         Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 20 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"
                                                 Write(((DateTime)x.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 26 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\Last5List\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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