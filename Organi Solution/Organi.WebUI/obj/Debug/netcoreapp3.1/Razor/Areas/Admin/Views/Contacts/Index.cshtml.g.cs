#pragma checksum "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b095d730addb8748e449db221cff2eaebb2234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contacts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
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
#line 3 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b095d730addb8748e449db221cff2eaebb2234", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4afee3f150ebdcdb693d2db4a24be94fd25bc6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Organi.WebUI.Models.Entity.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-typeId", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-typeId", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var message = TempData["Message"] as string;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <ul class=""breadcrumb"">
        <li>
            <p>YOU ARE HERE</p>
        </li>
        <li><a href=""#"" class=""active"">Muracietler</a> </li>
    </ul>
    <div class=""page-title"">
        <i class=""icon-custom-left""></i>
        <h3>Form - <span class=""semi-bold"">Əsas səhifə</span></h3>
    </div>
    <div class=""row"" id=""inbox-wrapper"">
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""grid simple"">
                        <div class=""grid-body no-border email-body"">
                            <br>
                            <div class=""row-fluid"">

");
#nullable restore
#line 29 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                 if (!string.IsNullOrWhiteSpace(message))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"row\">\r\n                                        <div class=\"col-12\">\r\n                                            <div class=\"alert alert-success\">\r\n                                                ");
#nullable restore
#line 34 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                           Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <div class=""btn-group btn-group-sm"" role=""group"" aria-label=""Basic example"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b095d730addb8748e449db221cff2eaebb22347974", async() => {
                WriteLiteral("Hamisi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-typeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["typeId"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b095d730addb8748e449db221cff2eaebb22349774", async() => {
                WriteLiteral("Gozlemede");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-typeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["typeId"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""col-12"">
                                        <table class=""table"">
                                            <thead>
                                                <tr>
                                                    <th>
                                                        ");
#nullable restore
#line 52 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th>\r\n                                                        p\r\n                                                        ");
#nullable restore
#line 56 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th>\r\n                                                        ");
#nullable restore
#line 59 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th>\r\n                                                        ");
#nullable restore
#line 62 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th>\r\n                                                        ");
#nullable restore
#line 65 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.AnswerDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th>\r\n                                                        ");
#nullable restore
#line 68 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </th>
                                                    <th>
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 75 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 79 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 82 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 85 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 88 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.Raw(item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 91 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.AnswerDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 94 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n");
#nullable restore
#line 97 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                             if (item.Answer == null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b095d730addb8748e449db221cff2eaebb223419132", async() => {
                WriteLiteral("\r\n                                                                    <i class=\"fa fa-pencil\"> </i>\r\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Organi.WebUI.Models.Entity.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
