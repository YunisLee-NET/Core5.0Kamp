#pragma checksum "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c5d435bc09bfddc219669c8bef0aa243b90d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_BlogDetails), @"mvc.1.0.view", @"/Views/Default/BlogDetails.cshtml")]
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
#nullable restore
#line 1 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c5d435bc09bfddc219669c8bef0aa243b90d9d", @"/Views/Default/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/_MainView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c5d435bc09bfddc219669c8bef0aa243b90d9d4551", async() => {
                WriteLiteral("\r\n    <section class=\"banner-bottom\">\r\n        <!--/blog-->\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 16 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""row"">
                    <!--left-->
                    <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">

                        <div class=""blog-grid-top"">
                            <div class=""b-grid-top"">
                                <div class=""blog_info_left_grid"">
                                    <a href=""single.html"">
                                        <img");
                BeginWriteAttribute("src", " src=\"", 776, "\"", 794, 1);
#nullable restore
#line 26 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
WriteAttributeValue("", 782, x.BlogImage, 782, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 813, "\"", 819, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 33 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                                                                                Write(((DateTime)x.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </a>
                                        </li>
                                        <li class=""mx-2"">
                                            <a href=""#"">
                                                <i class=""far fa-thumbs-up""></i> 201 Likes
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-comment""></i> 0 Comments
                                            </a>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                <a href=""single.html"">");
#nullable restore
#line 52 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                                                 Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n                            </h3>\r\n                            <p>");
#nullable restore
#line 54 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                          Write(x.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n\r\n\r\n\r\n                        ");
#nullable restore
#line 59 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                   Write(await Component.InvokeAsync("CommentList", new {id=@x.BlogID}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 62 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                   Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </div>

                    <!--//left-->
                    <!--right-->
                    <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                        <div class=""right-blog-info text-left"">
                            <div class=""tech-btm"">
                                <img src=""images/banner1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 2964, "\"", 2970, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""tech-btm"">
                                <h4>Sign up to our newsletter</h4>
                                <p>Pellentesque dui, non felis. Maecenas male </p>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c5d435bc09bfddc219669c8bef0aa243b90d9d9907", async() => {
                    WriteLiteral("\r\n                                    <input type=\"email\" placeholder=\"Email\"");
                    BeginWriteAttribute("required", " required=\"", 3354, "\"", 3365, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <input type=\"submit\" value=\"Subscribe\">\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            </div>
                            <div class=""tech-btm"">
                                <h4>Categories</h4>
                                <ul class=""list-group single"">
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Cras justo odio
                                        <span class=""badge badge-primary badge-pill"">14</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Dapibus ac facilisis in
                                        <span class=""badge badge-primary badge-pill"">2</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                        Morbi leo risus
           ");
                WriteLiteral("                             <span class=\"badge badge-primary badge-pill\">1</span>\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                            ");
#nullable restore
#line 99 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
                       Write(await Component.InvokeAsync("Last5List",new {id=@x.WriterID}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            <div class=""single-gd my-5 tech-btm"">
                                <h4>Our Progress</h4>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                        ");
                WriteLiteral(@"             aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                                </div>
                            </div>
                            <div class=""single-gd tech-btm"">
                                <h4>Recent Post</h4>
                                <div class=""blog-grids"">
                                    <div class=""blog-grid-left"">
    ");
                WriteLiteral("                                    <a href=\"single.html\">\r\n                                            <img src=\"images/b1.jpg\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 6995, "\"", 7001, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </a>
                                    </div>
                                    <div class=""blog-grid-right"">

                                        <h5>
                                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                        </h5>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                            </div>
                        </div>

                    </aside>
                    <!--//right-->
                </div>
");
#nullable restore
#line 146 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Default\BlogDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </section>\r\n    <!--//main-->\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
