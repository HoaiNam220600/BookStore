#pragma checksum "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b55277dcca7f0d0fda49171e2c7ccdd31a891de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddBook), @"mvc.1.0.view", @"/Views/Admin/AddBook.cshtml")]
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
#line 1 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b55277dcca7f0d0fda49171e2c7ccdd31a891de", @"/Views/Admin/AddBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin.Models.Sach>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
  
    Layout = "~/Views/Shared/_adminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""right_col"" role=""main"" style=""min-height: 3753px;"">
    <div class=""row"">

        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""x_panel"">
                <div class=""x_title"">
                    <h2>Add New Book</h2>
                    <ul class=""nav navbar-right panel_toolbox"">
                        <li>
                            <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                        </li>
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                            <ul class=""dropdown-menu"" role=""menu"">
                                <li>
                                    <a href=""#"">Settings 1</a>
                                </li>
                                <li>
                                    <a href=""#"">Settings 2</a>
                              ");
            WriteLiteral(@"  </li>
                            </ul>
                        </li>
                        <li>
                            <a class=""close-link""><i class=""fa fa-close""></i></a>
                        </li>
                    </ul>
                    <div class=""clearfix""></div>
                </div>
                <div class=""x_content"">
                    <br>
");
#nullable restore
#line 38 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                     using (Html.BeginForm("AddBook", "Admin", FormMethod.Post, new { @class = "form-horizontal form-label-left" }))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryId"">
                                Tên sách<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"" >
                                ");
#nullable restore
#line 46 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.TenSach, new { @class = "form-control  col-md-7 col-xs-12"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Giá Bán <span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 55 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.GiaBan, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Mô tả <span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 63 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.MoTa, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Ảnh bìa<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 71 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.AnhBia, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Ngày cập nhật<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 79 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.NgayCapNhat, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Số lượng tồn<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 87 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.SoLuongTon, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                 nhà xuất bản<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                ");
#nullable restore
#line 95 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.MaNxb, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group"" >
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""categoryName"">
                                Chủ đề<span class=""required"">*</span>
                            </label>
                            <div class=""col-md-6 col-sm-6 col-xs-12"" >
                                ");
#nullable restore
#line 103 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                           Write(Html.TextBoxFor(m => m.MaChuDe, new { @class = "form-control  col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""ln_solid""></div>
                        <div class=""form-group"">
                            <div class=""col-md-6 col-sm-6 col-xs-12 col-md-offset-3"">
                                <button class=""btn btn-primary"" type=""button"">Cancel</button>
                                <button class=""btn btn-primary"" type=""reset"">Reset</button>
                                <button type=""submit"" class=""btn btn-success"">Submit</button>
                            </div>
                        </div>
");
#nullable restore
#line 114 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\Admin\AddBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin.Models.Sach> Html { get; private set; }
    }
}
#pragma warning restore 1591