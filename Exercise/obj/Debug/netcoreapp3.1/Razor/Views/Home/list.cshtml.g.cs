#pragma checksum "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f558179b7c8c302695dbb9952ab01b8a171aa06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_list), @"mvc.1.0.view", @"/Views/Home/list.cshtml")]
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
#line 1 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\_ViewImports.cshtml"
using Exercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\_ViewImports.cshtml"
using Exercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f558179b7c8c302695dbb9952ab01b8a171aa06c", @"/Views/Home/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d26ce003a18f369e274688a220ccb2aca6a380", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral(@"    <!-- BEGIN: Content-->
    <div class=""app-content content"">
      <div class=""content-overlay""></div>
      <div class=""header-navbar-shadow""></div>
      <div class=""content-wrapper"">
        <div class=""content-header row"">
          <div class=""content-header-left col-md-9 col-12 mb-2"">
            <div class=""row breadcrumbs-top"">
              <div class=""col-12"">
                <h2 class=""content-header-title float-left mb-0"">نمایش کوتاه</h2>
                <div class=""breadcrumb-wrapper col-12"">
                  <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html"">خانه</a>
                    </li>
                    <li class=""breadcrumb-item""><a href=""#"">لیست داده ها</a>
                    </li>
                    <li class=""breadcrumb-item active""> نمایش کوتاه</li>
                  </ol>
                </div>
              </div>
            </div>
          </div>
          <div class=""content-header-right text-md-right col-");
            WriteLiteral(@"md-3 col-12 d-md-block d-none"">
            <div class=""form-group breadcrum-right"">
              <div class=""dropdown"">
                <button class=""btn-icon btn btn-primary btn-round btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""feather icon-settings""></i></button>
                <div class=""dropdown-menu dropdown-menu-right""><a class=""dropdown-item"" href=""#"">گفتگو</a><a class=""dropdown-item"" href=""#"">ایمیل</a><a class=""dropdown-item"" href=""#"">تقویم</a></div>
              </div>
            </div>
          </div>
        </div>
        <div class=""content-body""><!-- Data list view starts -->
<section id=""data-thumb-view"" class=""data-thumb-view-header"">
  <div class=""action-btns d-none"">
    <div class=""btn-dropdown mr-1 mb-1"">
      <div class=""btn-group dropdown actions-dropodown"">
        <button type=""button"" class=""btn btn-white px-1 py-1 dropdown-toggle waves-effect waves-light"" data-toggle=""dropdown"" aria-haspopup=");
            WriteLiteral(@"""true"" aria-expanded=""false""> اقدامات</button>
        <div class=""dropdown-menu dropdown-menu-right"">
          <a class=""dropdown-item"" href=""#""><i class=""feather icon-trash""></i>حذف</a>
          <a class=""dropdown-item"" href=""#""><i class=""feather icon-archive""></i>آرشیو</a>
          <a class=""dropdown-item"" href=""#""><i class=""feather icon-file""></i>چاپ</a>
          <a class=""dropdown-item"" href=""#""><i class=""feather icon-save""></i>یک اقدام دیگر</a>
        </div>
      </div>
    </div>
  </div>


");
#nullable restore
#line 49 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
     if (ViewBag.m != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <p class=\"alert alert-success\">");
#nullable restore
#line 51 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                                     Write(ViewBag.m);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 52 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

  <!-- dataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-thumb-view Aroco-table"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th>نام</th>
          <th>نام خانوادگی </th>
          <th>آدرس</th>
          <th>کدملی </th>
           <th>عکس</th>
            <th>دانلود</th>
          
          <th>اقدام</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 73 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
         if (ViewBag .list!=null)
        {int i=1;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
             foreach (var item in ViewBag .list)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n          <td></td>\r\n          <td >");
#nullable restore
#line 79 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td class=\"product-name\"> ");
#nullable restore
#line 81 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </td>\r\n           <td class=\"product-name\"> ");
#nullable restore
#line 82 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                                Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n            <td class=\"product-name\"> ");
#nullable restore
#line 83 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                                 Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n             <td class=\"product-price\"> ");
#nullable restore
#line 84 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
                                   Write(item.Codemeli);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </td>\r\n             <td class=\"product-name\"> \r\n\r\n               \r\n               \r\n               <img");
            BeginWriteAttribute("src", " src=\"", 3691, "\"", 3716, 2);
            WriteAttributeValue("", 3697, "/upload/", 3697, 8, true);
#nullable restore
#line 89 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
WriteAttributeValue("", 3705, item.image, 3705, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "alt=\"", 3717, "\"", 3722, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height:100px; border-radius:50%; \"  >\r\n               \r\n                 </td>\r\n\r\n                  <td class=\"product-name\"> \r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f558179b7c8c302695dbb9952ab01b8a171aa06c9806", async() => {
                WriteLiteral("<i class=\"feather icon-download\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3900, "~/upload/", 3900, 9, true);
#nullable restore
#line 94 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
AddHtmlAttributeValue("", 3909, item.FileName, 3909, 14, false);

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
            WriteLiteral("\r\n                  \r\n                   </td>\r\n         \r\n         \r\n          \r\n          \r\n       \r\n          <td class=\"product-action\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4122, "\"", 4150, 2);
            WriteAttributeValue("", 4129, "/home/update/", 4129, 13, true);
#nullable restore
#line 103 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
WriteAttributeValue("", 4142, item.Id, 4142, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"feather icon-edit\"></i></a>\r\n           \r\n            <a onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئ ن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 4286, "\"", 4311, 2);
            WriteAttributeValue("", 4293, "/home/del/", 4293, 10, true);
#nullable restore
#line 105 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
WriteAttributeValue("", 4303, item.Id, 4303, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"feather icon-trash\"></i></a>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 108 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
        i++;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "c:\Users\MEDIA MARK\Desktop\project\Exercise\Exercise\Views\Home\list.cshtml"
         
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        
        

      </tbody>
    </table>
  </div>
  <!-- dataTable ends -->

  <!-- add new sidebar starts -->
  
  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->

        </div>
      </div>
    </div>
    <!-- END: Content-->
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
