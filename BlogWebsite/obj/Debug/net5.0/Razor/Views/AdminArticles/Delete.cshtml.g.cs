#pragma checksum "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c30ca5956a56cb7f16960344c1a51683925f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminArticles_Delete), @"mvc.1.0.view", @"/Views/AdminArticles/Delete.cshtml")]
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
#line 1 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\_ViewImports.cshtml"
using BlogWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\_ViewImports.cshtml"
using BlogWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c30ca5956a56cb7f16960344c1a51683925f46", @"/Views/AdminArticles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c62f4659e58e4f161da2f4232506b072bf24a9a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminArticles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebsite.Models.Article>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Article</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleThumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleThumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticlePriority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticlePriority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ViewCounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ViewCounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LikeCounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LikeCounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArticleStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Author.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c30ca5956a56cb7f16960344c1a51683925f4614891", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1c30ca5956a56cb7f16960344c1a51683925f4615158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 89 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\AdminArticles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c30ca5956a56cb7f16960344c1a51683925f4617024", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogWebsite.Models.Article> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
