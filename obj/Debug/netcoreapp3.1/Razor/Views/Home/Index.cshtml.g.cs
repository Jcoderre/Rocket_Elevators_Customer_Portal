#pragma checksum "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3ba3d7e9900bd5e57f1ba3d9a629b523e26e59"
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
#line 1 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3ba3d7e9900bd5e57f1ba3d9a629b523e26e59", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Content Wrapper. Contains page content -->
  <div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1 class=""m-0"">Dashboard</h1>
          </div><!-- /.col -->
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item active"">Dashboard</li>
              <li class=""breadcrumb-item"">");
#nullable restore
#line 17 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml"
                                     Write(Html.ActionLink("Intervention","intervention_form"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"breadcrumb-item\">");
#nullable restore
#line 18 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml"
                                     Write(Html.ActionLink("View Data","view_data"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"breadcrumb-item\">");
#nullable restore
#line 19 "C:\Users\Joey\Desktop\Codeboxx\Week11\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml"
                                     Write(Html.ActionLink("Manage Data","manage_data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <!-- Main content -->
    <section class=""content"">
      <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
              <div class=""inner"">
                <h3>194</h3>

                <p>Job related expences</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-bag""></i>
              </div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
              <div class=""inner"">
                <h3>87<sup style=""font-size: 20px"">%</sup></h3>

                <p>Elevator Usage</p>
           ");
            WriteLiteral(@"   </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
              <div class=""inner"">
                <h3>21 </h3>

                <p>New Employee (this year)</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-person-add""></i>
              </div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
              <div class=""inner"">
                <h3>284</h3>

                <p>Building Visitor by day</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-pie-graph""></i>
              </div>
            </div>
          </div>
          ");
            WriteLiteral(@"<!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
          <!-- Left col -->
          <section class=""col-lg-7 connectedSortable"">
            <!-- TO DO List -->
            <div class=""card"">
              <div class=""card-header"">
                <h3 class=""card-title"">
                  <i class=""ion ion-clipboard mr-1""></i>
                  To Do List
                </h3>

                <div class=""card-tools"">
                  <ul class=""pagination pagination-sm"">
                    <li class=""page-item""><a href=""#"" class=""page-link"">&laquo;</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">3</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">&raquo;</a></li>
                  </ul>
             ");
            WriteLiteral(@"   </div>
              </div>
              <!-- /.card-header -->
              <div class=""card-body"">
                <ul class=""todo-list"" data-widget=""todo-list"">
                  <li>
                    <!-- drag handle -->
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <!-- checkbox -->
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4464, "\"", 4472, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo1"" id=""todoCheck1"">
                      <label for=""todoCheck1""></label>
                    </div>
                    <!-- todo text -->
                    <span class=""text"">Checkout Elevators Intervention</span>
                    <!-- Emphasis label -->
                    <small class=""badge badge-danger""><i class=""far fa-clock""></i> 2 mins</small>
                    <!-- General tools such as edit or delete-->
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5436, "\"", 5444, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo2"" id=""todoCheck2"" checked>
                      <label for=""todoCheck2""></label>
                    </div>
                    <span class=""text"">Come to admin panel</span>
                    <small class=""badge badge-info""><i class=""far fa-clock""></i> 4 hours</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 6252, "\"", 6260, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo3"" id=""todoCheck3"">
                      <label for=""todoCheck3""></label>
                    </div>
                    <span class=""text"">Call Rocket Elevator Support</span>
                    <small class=""badge badge-warning""><i class=""far fa-clock""></i> 1 day</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7070, "\"", 7078, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo4"" id=""todoCheck4"">
                      <label for=""todoCheck4""></label>
                    </div>
                    <span class=""text"">Do Dishes</span>
                    <small class=""badge badge-success""><i class=""far fa-clock""></i> 3 days</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7870, "\"", 7878, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo5"" id=""todoCheck5"">
                      <label for=""todoCheck5""></label>
                    </div>
                    <span class=""text"">Check your messages and notifications</span>
                    <small class=""badge badge-primary""><i class=""far fa-clock""></i> 1 week</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 8698, "\"", 8706, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo6"" id=""todoCheck6"">
                      <label for=""todoCheck6""></label>
                    </div>
                    <span class=""text"">Give a pay raise to Web Dev</span>
                    <small class=""badge badge-secondary""><i class=""far fa-clock""></i> 1 month</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                </ul>
              </div>
              <!-- /.card-body -->
              <div class=""card-footer clearfix"">
                <button type=""button"" class=""btn btn-info float-right""><i class=""fas fa-plus""></i> Add item</button>
              </div>
            </div>
            <!-- /.card -->
          </section>
          <!-- /.Left col -->
          <!-- right col (We are only adding the ID to make the widgets sortable)-->
          <section class=""col-lg-5 connectedSortable"">
            <!--");
            WriteLiteral(@" solid sales graph -->
            <div class=""card bg-gradient-info"">
              <div class=""card-header border-0"">
                <h3 class=""card-title"">
                  <i class=""fas fa-th mr-1""></i>
                  Elevator Travel
                </h3>

                <div class=""card-tools"">
                  <button type=""button"" class=""btn bg-info btn-sm"" data-card-widget=""collapse"">
                    <i class=""fas fa-minus""></i>
                  </button>
                  <button type=""button"" class=""btn bg-info btn-sm"" data-card-widget=""remove"">
                    <i class=""fas fa-times""></i>
                  </button>
                </div>
              </div>
              <div class=""card-body"">
                <canvas class=""chart"" id=""line-chart"" style=""min-height: 170px; height: 170px; max-height: 170px; max-width: 100%;""></canvas>
              </div>
              <!-- /.card-body -->
              <div class=""card-footer bg-transparent"">
                ");
            WriteLiteral(@"<div class=""row"">
                  <div class=""col-4 text-center"">
                    <input type=""text"" class=""knob"" data-readonly=""true"" value=""75"" data-width=""100"" data-height=""100""
                           data-fgColor=""#39CCCC"">

                    <div class=""text-white"">In Motion</div>
                  </div>
                  <!-- ./col -->
                  <div class=""col-4 text-center"">
                    <input type=""text"" class=""knob"" data-readonly=""true"" value=""15"" data-width=""100"" data-height=""100""
                           data-fgColor=""#39CCCC"">

                    <div class=""text-white"">Stand-by</div>
                  </div>
                  <!-- ./col -->
                  <div class=""col-4 text-center"">
                    <input type=""text"" class=""knob"" data-readonly=""true"" value=""85"" data-width=""100"" data-height=""100""
                           data-fgColor=""#39CCCC"">

                    <div class=""text-white"">Intervention</div>
                  </div>");
            WriteLiteral(@"
                  <!-- ./col -->
                </div>
                <!-- /.row -->
              </div>
              <!-- /.card-footer -->
            </div>
            <!-- /.card -->
          </section>
          <!-- right col -->
        </div>
        <!-- /.row (main row) -->
      </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
