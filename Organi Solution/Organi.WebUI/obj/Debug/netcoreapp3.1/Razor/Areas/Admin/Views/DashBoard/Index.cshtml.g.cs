#pragma checksum "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d0aefebbf5ca7f53135ac789ad01de176adb4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d0aefebbf5ca7f53135ac789ad01de176adb4c", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4afee3f150ebdcdb693d2db4a24be94fd25bc6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hp\source\repos\Organi\Organi Solution\Organi.WebUI\Areas\Admin\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""content sm-gutter"">
        <div class=""page-title""></div>
        <!-- BEGIN DASHBOARD TILES -->
        <div class=""row"">
            <div class=""col-md-4 col-vlg-3 col-sm-6"">
                <div class=""tiles green m-b-10"">
                    <div class=""tiles-body"">
                        <div class=""controller"">
                            <a href=""javascript:;"" class=""reload""></a>
                            <a href=""javascript:;"" class=""remove""></a>
                        </div>
                        <div class=""tiles-title text-black"">OVERALL SALES </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Overall Visits</span> <span class=""item-count animate-number semi-bold"" data-value=""2415"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stat");
            WriteLiteral(@"s"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Today's</span> <span class=""item-count animate-number semi-bold"" data-value=""751"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stats "">
                            <div class=""wrapper last"">
                                <span class=""item-title"">Monthly</span> <span class=""item-count animate-number semi-bold"" data-value=""1547"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""progress transparent progress-small no-radius m-t-20"" style=""width:90%"">
                            <div class=""progress-bar progress-bar-white animate-progress-bar"" data-percentage=""64.8%""></div>
                        </div>
                        <div class=""description"">
                            <span");
            WriteLiteral(@" class=""text-white mini-description "">4% higher <span class=""blend"">than last month</span></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-vlg-3 col-sm-6"">
                <div class=""tiles blue m-b-10"">
                    <div class=""tiles-body"">
                        <div class=""controller"">
                            <a href=""javascript:;"" class=""reload""></a>
                            <a href=""javascript:;"" class=""remove""></a>
                        </div>
                        <div class=""tiles-title text-black"">OVERALL VISITS </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Overall Visits</span> <span class=""item-count animate-number semi-bold"" data-value=""15489"" data- animation-duration=""700"">0</span>
                            </div>
                      ");
            WriteLiteral(@"  </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Today's</span> <span class=""item-count animate-number semi-bold"" data-value=""551"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stats "">
                            <div class=""wrapper last"">
                                <span class=""item-title"">Monthly</span> <span class=""item-count animate-number semi-bold"" data-value=""1450"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""progress transparent progress-small no-radius m-t-20"" style=""width:90%"">
                            <div class=""progress-bar progress-bar-white animate-progress-bar"" data-percentage=""54%""></div>
                        </div>
                        <div ");
            WriteLiteral(@"class=""description"">
                            <span class=""text-white mini-description "">4% higher <span class=""blend"">than last month</span></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-vlg-3 col-sm-6"">
                <div class=""tiles purple m-b-10"">
                    <div class=""tiles-body"">
                        <div class=""controller"">
                            <a href=""javascript:;"" class=""reload""></a>
                            <a href=""javascript:;"" class=""remove""></a>
                        </div>
                        <div class=""tiles-title text-black"">SERVER LOAD </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Overall Load</span> <span class=""item-count animate-number semi-bold"" data-value=""5695"" data-animation-duration=""700"">0</span>
        ");
            WriteLiteral(@"                    </div>
                        </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Today's</span> <span class=""item-count animate-number semi-bold"" data-value=""568"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stats "">
                            <div class=""wrapper last"">
                                <span class=""item-title"">Monthly</span> <span class=""item-count animate-number semi-bold"" data-value=""12459"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""progress transparent progress-small no-radius m-t-20"" style=""width:90%"">
                            <div class=""progress-bar progress-bar-white animate-progress-bar"" data-percentage=""90%""></div>
          ");
            WriteLiteral(@"              </div>
                        <div class=""description"">
                            <span class=""text-white mini-description "">4% higher <span class=""blend"">than last month</span></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-vlg-3 visible-xlg visible-sm col-sm-6"">
                <div class=""tiles red m-b-10"">
                    <div class=""tiles-body"">
                        <div class=""controller"">
                            <a href=""javascript:;"" class=""reload""></a>
                            <a href=""javascript:;"" class=""remove""></a>
                        </div>
                        <div class=""tiles-title text-black"">OVERALL SALES </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Overall Sales</span> <span class=""item-count animate-number sem");
            WriteLiteral(@"i-bold"" data-value=""5669"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stats"">
                            <div class=""wrapper transparent"">
                                <span class=""item-title"">Today's</span> <span class=""item-count animate-number semi-bold"" data-value=""751"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""widget-stats "">
                            <div class=""wrapper last"">
                                <span class=""item-title"">Monthly</span> <span class=""item-count animate-number semi-bold"" data-value=""1547"" data-animation-duration=""700"">0</span>
                            </div>
                        </div>
                        <div class=""progress transparent progress-small no-radius m-t-20"" style=""width:90%"">
                            <div class=""progress-bar progress");
            WriteLiteral(@"-bar-white animate-progress-bar"" data-percentage=""64.8%""></div>
                        </div>
                        <div class=""description"">
                            <span class=""text-white mini-description "">4% higher <span class=""blend"">than last month</span></span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- END DASHBOARD TILES -->
        <div class=""row"">
            <!-- BEGIN WORLD MAP WIDGET - MAP -->
            <div class=""col-md-8 col-vlg-8 m-b-10"">
                <div class=""row"">
                    <div class=""col-md-12"" data-sync-height=""true"">
                        <div class=""col-md-7 col-vlg-8 col-sm-8 no-padding -height"">
                            <div class=""tiles green"" id=""mapplic_demo"">
                            </div>
                            <div class=""clearfix""></div>
                        </div>
                        <div class=""col-md-5 col-vlg-4 col-sm-4 no");
            WriteLiteral(@"-padding"">
                            <div class=""tiles black"">
                                <div class=""tiles-body"">
                                    <h5 class=""text-white""><span class=""semi-bold"">QUICK</span> VIEW</h5>
                                    <input type=""text"" placeholder=""Search..."" class=""form-control input-sm m-t-20"">
                                    <div class=""m-t-40"">
                                        <div class=""widget-stats"">
                                            <div class=""wrapper""> <span class=""item-title"">Overall Visits</span> <span class=""item-count animate-number semi-bold"" data-value=""2415"" data-animation-duration=""700"">0</span> </div>
                                        </div>
                                        <div class=""widget-stats"">
                                            <div class=""wrapper""> <span class=""item-title"">Today's</span> <span class=""item-count animate-number semi-bold"" data-value=""751"" data-animation-duration=""700"">0");
            WriteLiteral(@"</span> </div>
                                        </div>
                                        <div class=""widget-stats hidden-sm"">
                                            <div class=""wrapper last""> <span class=""item-title"">Monthly</span> <span class=""item-count animate-number semi-bold"" data-value=""1547"" data-animation-duration=""700"">0</span> </div>
                                        </div>
                                        <div class=""progress transparent progress-small no-radius m-t-20"" style=""width:90%"">
                                            <div class=""progress-bar progress-bar-success animate-progress-bar"" data-percentage=""64.8%""></div>
                                        </div>
                                        <div class=""description"">
                                            <span class=""text-white mini-description "">4% higher <span class=""blend"">than last month</span></span>
                                        </div>
                           ");
            WriteLiteral(@"         </div>
                                </div>
                                <div id=""chart"" style=""height:123px""> </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- END WORLD MAP WIDGET - CRAFT MAP -->
            <!-- BEGIN REALTIME SALES GRAPH -->
            <div class=""col-md-4 col-vlg-4 m-b-10 "">
                <div class=""tiles white"">
                    <div class=""row"">
                        <div class=""sales-graph-heading"">
                            <div class=""col-md-5 col-sm-5"">
                                <h5 class=""no-margin"">You have earned</h5>
                                <h4><span class=""item-count animate-number semi-bold"" data-value=""21451"" data-animation-duration=""700"">0</span> USD</h4>
                            </div>
                            <div class=""col-md-3 col-sm-3"">
                                <p class=""semi-bold"">TODAY</p>");
            WriteLiteral(@"
                                <h4><span class=""item-count animate-number semi-bold"" data-value=""451"" data-animation-duration=""700"">0</span> USD</h4>
                            </div>
                            <div class=""col-md-4 col-sm-3"">
                                <p class=""semi-bold"">THIS MONTH</p>
                                <h4><span class=""item-count animate-number semi-bold"" data-value=""8514"" data-animation-duration=""700"">0</span> USD</h4>
                            </div>
                            <div class=""clearfix""></div>
                        </div>
                    </div>
                    <h5 class=""semi-bold m-t-30 m-l-30"">LAST SALE</h5>
                    <table class=""table no-more-tables m-t-20 m-l-20 m-b-30"">
                        <thead style=""display:none"">
                            <tr>
                                <th style=""width:9%"">Project Name</th>
                                <th style=""width:22%"">Description</th>
              ");
            WriteLiteral(@"                  <th style=""width:6%"">Price</th>
                                <th style=""width:1%""> </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class=""v-align-middle bold text-success"">25601</td>
                                <td class=""v-align-middle""><span class=""muted"">Redesign project template</span> </td>
                                <td><span class=""muted bold text-success"">$4,500</span> </td>
                                <td class=""v-align-middle""></td>
                            </tr>
                            <tr>
                                <td class=""v-align-middle bold text-success"">25601</td>
                                <td class=""v-align-middle""><span class=""muted"">Redesign project template</span> </td>
                                <td><span class=""muted bold text-success"">$4,500</span> </td>
                                <td");
            WriteLiteral(@" class=""v-align-middle""></td>
                            </tr>
                        </tbody>
                    </table>
                    <div id=""sales-graph""> </div>
                </div>
            </div>
            <!-- END REALTIME SALES GRAPH -->
        </div>
    </div>");
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
