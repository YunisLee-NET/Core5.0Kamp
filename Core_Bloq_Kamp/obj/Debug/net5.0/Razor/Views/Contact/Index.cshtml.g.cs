#pragma checksum "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be34af8c64613fbd11b7a94e9aa0eba40807becd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be34af8c64613fbd11b7a94e9aa0eba40807becd", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Contact\Index.cshtml"
 using (Html.BeginForm("Index", "Contact", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3 class=\"tittle\">Biziml?? ??laq??</h3>\r\n        <p class=\"sub text-center\">Elektron m??raci??t</p>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be34af8c64613fbd11b7a94e9aa0eba40807becd4515", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"validationCustom01 my-2\">Ad v?? soyad??n??z</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"ContactUserName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 512, "\"", 526, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 527, "\"", 538, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlInput1\">Emailiniz</label>\r\n                <input class=\"form-control\" type=\"email\" name=\"ContactMail\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 748, "\"", 762, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 763, "\"", 774, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"validationCustom03 my-2\">M??vzu</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"ContactSubject\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 981, "\"", 995, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 996, "\"", 1007, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"textarea\">Mesaj??n??z</label>\r\n                <textarea id=\"textarea\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1167, "\"", 1181, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" name=\"ContactMessage\"></textarea>\r\n            </div>\r\n            <button class=\"form-control btn btn-primary\" type=\"submit\">G??nd??r</button>\r\n\r\n\r\n        ");
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
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 37 "E:\Dersler\MVC\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Contact\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
