#pragma checksum "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 3 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\_ViewImports.cshtml"
using Organi.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3528a1daac56ffcb3a5564692cc8ceb19afe9e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4afee3f150ebdcdb693d2db4a24be94fd25bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShopDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/banner/banner-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/banner/banner-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n\r\n");
#nullable restore
#line 4 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""categories"">
    <div class=""container"">
        <div class=""row"">
            <div class=""categories__slider owl-carousel"">
                <div class=""col-lg-3"">
                    <div class=""categories__item set-bg"" data-setbg=""/assets/img/categories/cat-1.jpg"">
                        <h5><a href=""#"">Fresh Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories__item set-bg"" data-setbg=""/assets/img/categories/cat-2.jpg"">
                        <h5><a href=""#"">Dried Fruit</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories__item set-bg"" data-setbg=""/assets/img/categories/cat-3.jpg"">
                        <h5><a href=""#"">Vegetables</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories__item set-bg"" data");
            WriteLiteral(@"-setbg=""/assets/img/categories/cat-4.jpg"">
                        <h5><a href=""#"">drink fruits</a></h5>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""categories__item set-bg"" data-setbg=""/assets/img/categories/cat-5.jpg"">
                        <h5><a href=""#"">drink fruits</a></h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>Featured Product</h2>
                </div>
                <div class=""featured__controls"">
                    <ul>
                        <li class=""active"" data-filter=""*"">All</li>
");
#nullable restore
#line 54 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-filter=\".");
#nullable restore
#line 56 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                                         Write(item.Name.Replace(" ","-"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 56 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 57 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row featured__filter\">\r\n\r\n");
#nullable restore
#line 65 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
             foreach (var item in Model.FeaturedProducts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 2405, "\"", 2480, 5);
            WriteAttributeValue("", 2413, "col-lg-3", 2413, 8, true);
            WriteAttributeValue(" ", 2421, "col-md-4", 2422, 9, true);
            WriteAttributeValue(" ", 2430, "col-sm-6", 2431, 9, true);
            WriteAttributeValue(" ", 2439, "mix", 2440, 4, true);
#nullable restore
#line 67 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2443, item.Category.Name.Replace(" ","-"), 2444, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"featured__item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2531, "\"", 2615, 3);
            WriteAttributeValue("", 2541, "window.location.href=\'", 2541, 22, true);
#nullable restore
#line 68 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2563, Url.Action("ShopDetails","shop",new { id=item.Id}), 2563, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2614, "\'", 2614, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"featured__item__pic set-bg\" data-setbg=\"/Uploads/");
#nullable restore
#line 69 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                                                                                Write(item.Images.FirstOrDefault(i=>i.IsMain==true).Path);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li>
                                    <a href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 3087, "\"", 3122, 3);
            WriteAttributeValue("", 3097, "addToCard(", 3097, 10, true);
#nullable restore
#line 74 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3107, item.Id, 3107, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3115, ",event)", 3115, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                       <i class=""fa fa-shopping-cart""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e12980", async() => {
#nullable restore
#line 81 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
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
            WriteLiteral("</h6>\r\n                            <h5>");
#nullable restore
#line 82 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
                           Write(item.price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 86 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<div class=\"banner\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                <div class=\"banner__pic\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e16509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                <div class=\"banner__pic\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e17797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        </div>
    </div>
</div>


<section class=""latest-product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""latest-product__text"">
                    ");
#nullable restore
#line 115 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("ProductsByCategory",new { 
               title="Son Mehsullar",
               val=1
               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  \r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                ");
#nullable restore
#line 123 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("ProductsByCategory", new
                {
            title = "Cox Satilanlar",
            val=2
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              \r\n            </div>\r\n            <div class=\"col-lg-4 col-md-6\">\r\n                ");
#nullable restore
#line 131 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("ProductsByCategory", new
                {
            title = "Review Products",
            val=3
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>


<section class=""from-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title from-blog__title"">
                    <h2>From The Blog</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e21130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e22996", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3528a1daac56ffcb3a5564692cc8ceb19afe9e24864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("banner", async() => {
                WriteLiteral(@"
    <div class=""hero__item set-bg"" data-setbg=""/assets/img/hero/banner.jpg"">
        <div class=""hero__text"">
            <span>FRUIT FRESH</span>
            <h2>Vegetable <br />100% Organic</h2>
            <p>Free Pickup and Delivery Available</p>
            <a href=""#"" class=""primary-btn"">SHOP NOW</a>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("script", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.js"" integrity=""sha512-aUhL2xOCrpLEuGD5f6tgHbLYEXRpYZ8G5yD+WlFrXrPy2IrWBlu6bih5C9H6qGsgqnU6mgx6KtU8TreHpASprw=="" crossorigin=""anonymous""></script>
    <script>
        $('.hero__categories > ul').css({
            display: 'block'
        });

        function onlyUnique(value, index, self) {
            return self.indexOf(value) === index;
        };


        function addToCard(id,event) {

            event.stopPropagation();
            event.preventDefault();


            let cardItems = $.cookie('cards-item');
            let items;
            if (cardItems == null) {
                items = [];
            }
            else {
                items = cardItems.split(',').map(e => parseInt(e));
            }

            items.push(id);
            items = items.filter(onlyUnique);


            $.cookie('cards-item', items.toString(), { expires: 7 });

            $('.item-count");
                WriteLiteral("\').removeClass(\'d-none\').html(items.length);\r\n\r\n            console.log(items);\r\n\r\n        };\r\n\r\n\r\n\r\n\r\n        </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
