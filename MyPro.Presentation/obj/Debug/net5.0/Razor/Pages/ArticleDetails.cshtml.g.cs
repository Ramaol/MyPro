#pragma checksum "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f0c63abab40180a98dd930cdba4eb528a3fa15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyPro.Presentation.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace MyPro.Presentation.Pages
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
#line 1 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/_ViewImports.cshtml"
using MyPro.Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f0c63abab40180a98dd930cdba4eb528a3fa15", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f65ba9b789fc7a9c6c3031ea84d7bb81b4091ed", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
  
    ViewData["Title"] = "Article Data";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<main class=\"post blog-post col-lg-12\">\n  \n    <div class=\"container\">\n        <div class=\"post-single\">\n            <div class=\"post-thumbnail\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 277, "\"", 303, 1);
#nullable restore
#line 12 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
WriteAttributeValue("", 283, Model.Article.Image, 283, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 304, "\"", 330, 1);
#nullable restore
#line 12 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
WriteAttributeValue("", 310, Model.Article.Title, 310, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 331, "\"", 359, 1);
#nullable restore
#line 12 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
WriteAttributeValue("", 339, Model.Article.Title, 339, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\n            </div>\n            <div class=\"post-details\">\n                <div class=\"post-meta d-flex justify-content-between\">\n                    <div class=\"category\">\n                        <a href=\"#\">");
#nullable restore
#line 17 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
                               Write(Model.Article.ArticleCategury);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </div>\n                </div>\n                <h1>\n                    ");
#nullable restore
#line 21 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
               Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a href=""#"">
                        <i class=""fa fa-bookmark-o""></i>
                    </a>
                </h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date"">
                            <i class=""icon-clock""></i> ");
#nullable restore
#line 29 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
                                                  Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div class=\"comments meta-last\"><i class=\"icon-comment\"></i>12</div>\n                    </div>\n                </div>\n                <div class=\"post-body\">\n                    <p>\n                        ");
#nullable restore
#line 35 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
                   Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    ");
#nullable restore
#line 37 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                        <i class=""fa fa-bookmark-o""></i>
                    </a>
                </h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date"">
                            <i class=""icon-clock""></i> ");
#nullable restore
#line 46 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
                                                  Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div class=\"comments meta-last\"><i class=\"icon-comment\"></i>12</div>\n                    </div>\n                </div>\n                <div class=\"post-body\">\n                    <p>\n                        ");
#nullable restore
#line 52 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
                   Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    ");
#nullable restore
#line 54 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Pages/ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n</main>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPro.Presentation.Pages.ArticleDetails> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPro.Presentation.Pages.ArticleDetails> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPro.Presentation.Pages.ArticleDetails>)PageContext?.ViewData;
        public MyPro.Presentation.Pages.ArticleDetails Model => ViewData.Model;
    }
}
#pragma warning restore 1591
