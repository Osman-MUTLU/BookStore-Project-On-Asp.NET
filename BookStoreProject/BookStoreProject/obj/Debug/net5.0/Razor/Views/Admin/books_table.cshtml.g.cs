#pragma checksum "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01134683cd738ecd8f562fab6097ab2220aac169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_books_table), @"mvc.1.0.view", @"/Views/Admin/books_table.cshtml")]
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
#line 1 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01134683cd738ecd8f562fab6097ab2220aac169", @"/Views/Admin/books_table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e50f3def89caa8a8572a10d7dc3501897537c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_books_table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
  
    
    ViewData["Title"] = "Display Data";
    string[] table_headers = new string[]
    {
        "Photo","ID","Name","Author","Category","PageCount","Price","Rating","Year","Action"
            };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table\">\r\n    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 15 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
                 foreach (var head in table_headers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>");
#nullable restore
#line 17 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
                   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 18 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
             if (Model != null)
            {
                foreach (var data in Model)
                {
                    


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n");
#nullable restore
#line 31 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
                      
                        string img_source = data.Name.Replace(" ", "-").ToLower();
                        img_source = data.Category + "/" + img_source + "-" + data.Year + ".jpg";

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01134683cd738ecd8f562fab6097ab2220aac1696858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 998, "~/images/book-images/", 998, 21, true);
#nullable restore
#line 37 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
AddHtmlAttributeValue("", 1019, img_source, 1019, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
               Write(data.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01134683cd738ecd8f562fab6097ab2220aac16911170", async() => {
                WriteLiteral("\r\n                        Delete\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1444, "~/deletebook/", 1444, 13, true);
#nullable restore
#line 49 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
AddHtmlAttributeValue("", 1457, data.ID, 1457, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\osman\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\books_table.cshtml"
                    
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>");
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
