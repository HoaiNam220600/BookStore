#pragma checksum "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f966e293590bcb289cbb68031e4e0f3e523e2a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Detail), @"mvc.1.0.view", @"/Views/User/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f966e293590bcb289cbb68031e4e0f3e523e2a21", @"/Views/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin.Models.Sach>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/images/01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/images/01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-fancybox", new global::Microsoft.AspNetCore.Html.HtmlString("thumb-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
  
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""product-page mb-4"">
    <div class=""container"">
        <!-- chi tiết 1 sản phẩm -->
        <div class=""product-detail bg-white p-4"">
            <div class=""row"">
                <!-- ảnh  -->
                <div class=""col-md-5 khoianh"">
                    <div class=""anhto mb-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f966e293590bcb289cbb68031e4e0f3e523e2a215767", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f966e293590bcb289cbb68031e4e0f3e523e2a216050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 554, Model.TenSach, 554, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f966e293590bcb289cbb68031e4e0f3e523e2a218724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 656, "~/User/images/", 656, 14, true);
#nullable restore
#line 16 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 670, Model.AnhBia, 670, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral(@"                </div>
                <!-- thông tin sản phẩm: tên, giá bìa giá bán tiết kiệm, các khuyến mãi, nút chọn mua.... -->
                <div class=""col-md-7 khoithongtin"">
                    <div class=""row"">
                        <div class=""col-md-12 header"">
                            <h4 class=""ten"">");
#nullable restore
#line 27 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
                                       Write(Model.TenSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            <div class=""rate"">
                                <i class=""fa fa-star active""></i>
                                <i class=""fa fa-star active""></i>
                                <i class=""fa fa-star active""></i>
                                <i class=""fa fa-star active""></i>
                                <i class=""fa fa-star ""></i>
                            </div>
                            <hr>
                        </div>
                        <div class=""col-md-7"">
                            <div class=""gia"" bolder>
                                <div class=""giabia"">Giá: ");
#nullable restore
#line 39 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
                                                    Write(Model.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ<span class=\"giacu ml-2\">Mã Sách: ");
#nullable restore
#line 39 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
                                                                                                     Write(Model.MaSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                            </div>
                        </div>
                        <div class=""uudai my-3"">
                            <h6 class=""header font-weight-bold"">Khuyến mãi &amp; Ưu đãi tại H&N STORE:</h6>
                            <ul>
                                <li>
                                    <b>Miễn phí giao hàng </b>cho đơn hàng từ 150.000đ ở TP.HCM và 300.000đ ở
                                    Tỉnh/Thành khác <a href=""#"">&gt;&gt; Chi tiết</a>
                                </li>
                                <li><b>Combo sách HOT - GIẢM 25% </b><a href=""#"">&gt;&gt;Xem ngay</a></li>
                                <li>Tặng Bookmark cho mỗi đơn hàng</li>
                                <li>Bao sách miễn phí (theo yêu cầu)</li>
                            </ul>
                        </div>
                        <div class=""soluong d-flex"">
                            <label class=""font-weight-bold"">Số lượng: </label>
                ");
            WriteLiteral(@"            <div class=""input-number input-group mb-3"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text btn-spin btn-dec"">-</span>
                                </div>
                                <input type=""text"" value=""1"" class=""soluongsp  text-center"">
                                <div class=""input-group-append"">
                                    <span class=""input-group-text btn-spin btn-inc"">+</span>
                                </div>
                            </div>
                        </div>
                        <div class=""nutmua btn w-100 text-uppercase"">Chọn mua</div>
                        <a class=""huongdanmuahang text-decoration-none"" href=""#"">
                            (Vui lòng xem hướng dẫn mua
                            hàng)
                        </a>
                        <small class=""share"">Share: </small>
                        <div class=""fb-like"" data-hr");
            WriteLiteral(@"ef=""https://www.facebook.com/DealBook-110745443947730/""
                             data-width=""300px"" data-layout=""button"" data-action=""like"" data-size=""small""
                             data-share=""true""></div>
                    </div>
                    <!-- thông tin khác của sản phẩm:  tác giả, ngày xuất bản, kích thước ....  -->

                </div> <div class=""col-md-5"">
                    <div class=""thongtinsach"">
                        <ul>
                            <li>Mô tả <a href=""#"" class=""tacgia"">");
#nullable restore
#line 81 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
                                                            Write(Model.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li>Ngày xuất bản: <b>");
#nullable restore
#line 82 "C:\Users\NAM\OneDrive\Desktop\PTWEB\BookStore\Admin\Views\User\Detail.cshtml"
                                             Write(Model.NgayCapNhat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></li>
                        </ul>
                    </div>
                </div>
            </div>

                <!-- decripstion của 1 sản phẩm: giới thiệu , đánh giá độc giả  -->
                <div class=""product-description col-md-9"">
                    <!-- 2 tab ở trên  -->
                    <nav>
                        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                            <a class=""nav-item nav-link active text-uppercase"" id=""nav-gioithieu-tab"" data-toggle=""tab"" href=""#nav-gioithieu"" role=""tab"" aria-controls=""nav-gioithieu"" aria-selected=""true"">Giới thiệu</a>
                            <a class=""nav-item nav-link text-uppercase"" id=""nav-danhgia-tab"" data-toggle=""tab"" href=""#nav-danhgia"" role=""tab"" aria-controls=""nav-danhgia"" aria-selected=""false"">
                                Đánh
                                giá của độc giả
                            </a>
                        </div>
                    </nav>
                 ");
            WriteLiteral(@"   <!-- nội dung của từng tab  -->
                    <div class=""tab-content"" id=""nav-tabContent"">
                        <div class=""tab-pane fade show active ml-3"" id=""nav-gioithieu"" role=""tabpanel"" aria-labelledby=""nav-gioithieu-tab"">
                            <h6 class=""tieude font-weight-bold"">Lập Kế Hoạch Kinh Doanh Hiệu Quả</h6>
                            <p>
                                <span>
                                    Khi bắt đầu thành lập doanh nghiệp hay mở rộng quy mô hoạt động, lập ra một
                                    bản kế hoạch kinh doanh là bước đi đầu tiên không thể thiếu. Bản kế hoạch kinh
                                    doanh càng được chuẩn bị kỹ lưỡng và lôi cuốn bao nhiêu, cơ hội ghi điểm trước
                                    các nhà đầu tư càng lớn bấy nhiêu. Phải chăng, thông qua bản kế hoạch kinh
                                    doanh, bạn muốn người đọc:
                                </span>
                            </p>
        ");
            WriteLiteral(@"                    <p>
                                <span>
                                    - Đầu tư vào một ý tưởng kinh doanh mới hay một doanh nghiệp đang hoạt
                                    động?
                                </span>
                            </p>
                            <p>
                                <span>- Mua lại doanh nghiệp của bạn?</span>
                            </p>
                            <p>
                                <span>- Tham gia liên doanh với bạn?</span>
                            </p>
                            <p>
                                <span>- Chấp nhận đề nghị của bạn để thực hiện hợp đồng?</span>
                            </p>
                            <p>
                                <span>- Cấp cho bạn một khoản hỗ trợ hoặc phê duyệt theo quy định?</span>
                            </p>
                            <p>
                                <span>
                                 ");
            WriteLiteral(@"   - Thuyết phục hội đồng quản trị thay đổi phương hướng hoạt động doanh nghiệp
                                    của bạn?
                                </span>
                            </p>
                            <p>
                                <span>
                                    Cuốn sách “Lập kế hoạch kinh doanh hiệu quả” sẽ hướng dẫn bạn cách để tạo ra
                                    bản kế hoạch kinh doanh thu hút mọi tổ chức tài chính, khiến họ phải đáp ứng
                                    mong muốn của bạn và hỗ trợ bạn tới cùng trong công việc kinh doanh. Thông qua
                                    cuốn sách, bạn sẽ biết cách:
                                </span>
                            </p>
                            <p>
                                <span>
                                    Tạo ra bản kế hoạch kinh doanh hoàn chỉnh Xây dựng chiến lược hoạt động cho
                                    doanh nghiệp.
                           ");
            WriteLiteral(@"     </span>
                            </p>
                            <p>
                                <span>Đưa ra dự báo kinh doanh sát với thực tế.</span>
                            </p>
                            <p>
                                <span>Nắm rõ các thông tin tài chính ảnh hưởng lớn tới doanh nghiệp.</span>
                            </p>
                            <p>
                                <span>
                                    Trong quá trình xây dựng kế hoạch, việc tham khảo ý kiến chuyên gia là điều
                                    cần thiết nhưng bạn phải là người đóng góp chính và hiểu tường tận mỗi chi tiết
                                    có trong đó. Hãy xem việc lập kế hoạch giống như việc truyền đạt câu chuyện của
                                    mình nhằm thuyết phục người đọc đồng hành cùng bạn trên con đường chinh phục mục
                                    tiêu kinh doanh.
                                </span>
            ");
            WriteLiteral(@"                </p>
                            <p>
                                <span>
                                    Bạn chỉ có một cơ hội duy nhất để tạo ấn tượng đầu tiên tốt đẹp. Đừng để nó
                                    vụt mất. Hãy trình bày một văn bản có tính thuyết phục cao, bố cục đẹp mắt,
                                    không mắc lỗi chính tả, ngữ pháp, bao gồm các vấn đề trọng tâm và cuối cùng là
                                    chứa các thông tin bổ trợ cần thiết.
                                </span>
                            </p>
                            <p>
                                <span>
                                    Bằng kiến thức, kinh nghiệm của mình, Brian Finch - một chuyên gia trong lĩnh
                                    vực tư vấn lập kế hoạch kinh doanh và quản lý tài chính - chắc chắn sẽ giúp bạn
                                    xây dựng thành công kế hoạch kinh doanh của riêng mình.
                                </span>
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""tab-pane fade"" id=""nav-danhgia"" role=""tabpanel"" aria-labelledby=""nav-danhgia-tab"">
                            <div class=""row"">
                                <div class=""col-md-3 text-center"">
                                    <p class=""tieude"">Đánh giá trung bình</p>
                                    <div class=""diem"">0/5</div>
                                    <div class=""sao"">
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                    </div>
                                    <p class=""sonhanxet text-muted"">(0 nhận xét)</p>
                                </div>
             ");
            WriteLiteral(@"                   <div class=""col-md-5"">
                                    <div class=""tiledanhgia text-center"">
                                        <div class=""motthanh d-flex align-items-center"">
                                            5 <i class=""fa fa-star""></i>
                                            <div class=""progress mx-2"">
                                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div> 0%
                                        </div>
                                        <div class=""motthanh d-flex align-items-center"">
                                            4 <i class=""fa fa-star""></i>
                                            <div class=""progress mx-2"">
                                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
               ");
            WriteLiteral(@"                             </div> 0%
                                        </div>
                                        <div class=""motthanh d-flex align-items-center"">
                                            3 <i class=""fa fa-star""></i>
                                            <div class=""progress mx-2"">
                                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div> 0%
                                        </div>
                                        <div class=""motthanh d-flex align-items-center"">
                                            2 <i class=""fa fa-star""></i>
                                            <div class=""progress mx-2"">
                                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            <");
            WriteLiteral(@"/div> 0%
                                        </div>
                                        <div class=""motthanh d-flex align-items-center"">
                                            1 <i class=""fa fa-star""></i>
                                            <div class=""progress mx-2"">
                                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div> 0%
                                        </div>
                                        <div class=""btn vietdanhgia mt-3"">Viết đánh giá của bạn</div>
                                    </div>
                                    <!-- nội dung của form đánh giá  -->
                                    <div class=""formdanhgia"" style=""display: none;"">
                                        <h6 class=""tieude text-uppercase"">GỬI ĐÁNH GIÁ CỦA BẠN</h6>
                                        <span class=""danhgiac");
            WriteLiteral(@"uaban"">Đánh giá của bạn về sản phẩm này:</span>
                                        <div class=""rating d-flex flex-row-reverse align-items-center justify-content-end"">
                                            <input type=""radio"" name=""star"" id=""star1""><label for=""star1""></label>
                                            <input type=""radio"" name=""star"" id=""star2""><label for=""star2""></label>
                                            <input type=""radio"" name=""star"" id=""star3""><label for=""star3""></label>
                                            <input type=""radio"" name=""star"" id=""star4""><label for=""star4""></label>
                                            <input type=""radio"" name=""star"" id=""star5""><label for=""star5""></label>
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""text"" class=""txtFullname w-100"" placeholder=""Mời bạn nhập tên(Bắt buộc)"">
                        ");
            WriteLiteral(@"                </div>
                                        <div class=""form-group"">
                                            <input type=""text"" class=""txtEmail w-100"" placeholder=""Mời bạn nhập email(Bắt buộc)"">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""text"" class=""txtComment w-100"" placeholder=""Đánh giá của bạn về sản phẩm này"">
                                        </div>
                                        <div class=""btn nutguibl"">Gửi bình luận</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <hr>
                        <!-- het tab nav-danhgia  -->
                    </div>
                    <!-- het tab-content  -->
                </div>
                <!-- het product-description -->
            </div>
           ");
            WriteLiteral(" <!-- het row  -->\r\n        </div>\r\n        <!-- het product-detail -->\r\n    </div>\r\n    <!-- het container  -->\r\n</section>");
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