#pragma checksum "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57c95b29f2e3361178f552d9d0ed478aa62cd49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_AddBlog), @"mvc.1.0.view", @"/Views/Default/AddBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57c95b29f2e3361178f552d9d0ed478aa62cd49", @"/Views/Default/AddBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_AddBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
  
    ViewData["Title"] = "AddBlog";
    Layout = "~/Views/Shared/_AdminView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Yeni Bloq</h2>\r\n");
#nullable restore
#line 8 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
 using (Html.BeginForm("AddBlog", "Default", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.Label("Bloq ba??l??????"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.Label("Bloq ki??ik ????kli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnail, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.Label("Bloq fotosu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.Label("Bloq kateqoriyas??"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.cv, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.Label("Bloq m??zmunu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent, 3, 10, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-dark\">T??sdiq edin</button>\r\n");
#nullable restore
#line 29 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\AddBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
