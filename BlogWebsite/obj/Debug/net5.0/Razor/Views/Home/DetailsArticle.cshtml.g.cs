#pragma checksum "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d26907ff194bf6b3148c0d51d2dcbfb3e8d527d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsArticle), @"mvc.1.0.view", @"/Views/Home/DetailsArticle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d26907ff194bf6b3148c0d51d2dcbfb3e8d527d", @"/Views/Home/DetailsArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c62f4659e58e4f161da2f4232506b072bf24a9a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_DetailsArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebsite.Models.Article>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "DetailsArticle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-title\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 170, "\"", 195, 1);
#nullable restore
#line 9 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
WriteAttributeValue("", 176, Model.ArticleThumb, 176, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
</div>
<div id=""fh5co-single-content"" class=""container-fluid pb-4 pt-4 paddding"">
    <div class=""container paddding"">
        <div class=""row mx-0 justify-content-around"">
            <div class=""col-md-8 animate-box"" data-animate-effect=""fadeInLeft"">
                <div class=""page-title"">
                    <a class=""h5""");
            BeginWriteAttribute("href", " href=\"", 532, "\"", 669, 1);
#nullable restore
#line 16 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
WriteAttributeValue("", 539, Url.ActionLink("GetArticlesByCategory", "Home", new {slug = Model.Category.CategoryName.Replace(" ","-"), id = Model.CategoryId}), 539, 130, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"badge badge-danger d-inline-block\">");
#nullable restore
#line 16 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                                                                                                                                                                                                                       Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                    <span class=\"h6 date\">");
#nullable restore
#line 17 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                                     Write(Model.ArticleDate.ToString("dd/MM/yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h2>");
#nullable restore
#line 18 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                   Write(Model.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-md-12 animate-box fadeInLeft animated-fast\" data-animate-effect=\"fadeInLeft\" style=\"word-wrap: break-word; white-space: pre-wrap; overflow:hidden\">\r\n                    ");
#nullable restore
#line 21 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
               Write(Html.Raw(Model.ArticleContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex justify-content-between\">\r\n                    <div>\r\n");
#nullable restore
#line 25 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                         if (ViewBag.IsLiked)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"like\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1415, "\"", 1440, 3);
            WriteAttributeValue("", 1425, "Like(", 1425, 5, true);
#nullable restore
#line 27 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
WriteAttributeValue("", 1430, Model.Id, 1430, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1439, ")", 1439, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa-regular fa-thumbs-up fa-lg\"></i>\r\n                                <span class=\"ml-1\">");
#nullable restore
#line 29 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                                              Write(Model.LikeCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </button>\r\n");
#nullable restore
#line 31 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"like\" class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1794, "\"", 1819, 3);
            WriteAttributeValue("", 1804, "Like(", 1804, 5, true);
#nullable restore
#line 34 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
WriteAttributeValue("", 1809, Model.Id, 1809, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1818, ")", 1818, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa-regular fa-thumbs-up fa-lg\"></i>\r\n                                <span class=\"ml-1\">");
#nullable restore
#line 36 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                                              Write(Model.LikeCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </button>\r\n");
#nullable restore
#line 38 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <h6 class=\"author mt-auto\">");
#nullable restore
#line 41 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
                                          Write(Model.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3 pt-5 animate-box\" data-animate-effect=\"fadeInRight\">\r\n                ");
#nullable restore
#line 45 "E:\2. Tai lieu mon hoc\Nam 4\Ky II\Nhịp 2\Chuyên đề mạng máy tính và hệ thống thông tin\Nhóm 8 19CN3\BlogWebsite\BlogWebsite\Views\Home\DetailsArticle.cshtml"
           Write(await Component.InvokeAsync("MostPopular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<script>
    function Like(id) {
        $.ajax({
            url: '/Like/' + id,
            type: 'POST',
            processData: false,
            contentType: false,
            success: function (data) {
                var likecount = parseInt($('#like').children('span').text());
                if ($('#like').hasClass('btn-secondary')) {
                    likecount++;
                } else {
                    likecount--;
                }
                $('#like').toggleClass(""btn-primary btn-secondary"");
                $('#like').children('span').text(likecount);
            },
            error: function (xhr, status, error) {

            }
        });
    }
</script>");
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
