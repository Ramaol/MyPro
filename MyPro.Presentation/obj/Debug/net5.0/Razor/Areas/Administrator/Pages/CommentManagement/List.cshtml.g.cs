#pragma checksum "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564d97483458eade2228223c195371ff061e4c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.CommentManagement.Areas_Administrator_Pages_CommentManagement_List), @"mvc.1.0.razor-page", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages.CommentManagement
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564d97483458eade2228223c195371ff061e4c1b", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b0df2f174ccdf01c1976f0d5b11ab72892799f", @"/Areas/Administrator/Pages/_ViewImports.cshtml")]
    public class Areas_Administrator_Pages_CommentManagement_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning float-left mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ReadComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card\">\n        <div class=\"card-header\">\n            <h3 class=\"float-left\">Project List</h3>\n");
            WriteLiteral(@"        </div>
        <div class=""card-body"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>CreationDate</th>
                        <th>Status</th>
                        <th>opertation</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                     foreach (var item in Model.Comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 30 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 31 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 32 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                           Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                  <td>\n");
#nullable restore
#line 35 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                                 if (item.IsRead)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Read</p>\n");
#nullable restore
#line 38 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Not Read</p>\n");
#nullable restore
#line 42 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "564d97483458eade2228223c195371ff061e4c1b6745", async() => {
                WriteLiteral("See");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 48 "/home/ramol/Ramol/MyPro/MyPro.Presentation/Areas/Administrator/Pages/CommentManagement/List.cshtml"
                    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPro.Presentation.Areas.Administrator.Pages.CommentManagement.List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPro.Presentation.Areas.Administrator.Pages.CommentManagement.List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPro.Presentation.Areas.Administrator.Pages.CommentManagement.List>)PageContext?.ViewData;
        public MyPro.Presentation.Areas.Administrator.Pages.CommentManagement.List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
