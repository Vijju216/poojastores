#pragma checksum "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793983520dc26dbdfd9a684221b20f7a9903776f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_ProductPageBannerData), @"mvc.1.0.view", @"/Views/Image/ProductPageBannerData.cshtml")]
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
#line 1 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793983520dc26dbdfd9a684221b20f7a9903776f", @"/Views/Image/ProductPageBannerData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd5e81157aaadf292c89301cd5c1be8ee9a165", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Image_ProductPageBannerData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.ImageDisplayModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/AllProductPageBanners"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/ProductPageBannerData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
  
    Layout = "~/Views/Shared/AdminMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-image""></i>
        </div>
        <div class=""header-title"">
            <h1>Edit Product Page Banner Images</h1>
            <small></small>
        </div>
    </section>
    <!-- Main content -->
    <div class=""content"">
        <div class=""row"">
            <!-- Form controls -->
            <div class=""col-sm-12"">
                <div class=""card all_btn_card"" id=""lobicard-custom-control1"" data-sortable=""true"">
                    <div class=""card-header all_card_btn"">
                        <div class=""row"">
                            <div class=""card-title custom_title col-sm-3"">
                                <h5>Edit Banner Image</h5>
                            </div>
                            <div class=""col-sm-6"">
                                <label>Image Size : ");
#nullable restore
#line 28 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                                               Write(Model.ImageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""btn-group float-right"" role=""group"">
                                    <div class=""buttonexport"" id=""buttonlist"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793983520dc26dbdfd9a684221b20f7a9903776f7059", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-reply mr-2\"></i>Back\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793983520dc26dbdfd9a684221b20f7a9903776f8604", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                       Write(Html.HiddenFor(m => m.ImageId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3\">\r\n                                    <label>Select Category</label>\r\n                                    ");
#nullable restore
#line 47 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.DropDownListFor(a => a.RelatedCategoryId, new SelectList(Model.CategoryDrops, "CategoryId", "CategoryName", Model.RelatedCategoryId), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <label>Image Title-1</label>\r\n                                    ");
#nullable restore
#line 51 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.ImageTitle1, null, new { @placeholder = "Enter Image Title1", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 52 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.ImageTitle1, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <label>Image Title-2</label>\r\n                                    ");
#nullable restore
#line 56 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.ImageTitle2, null, new { @placeholder = "Enter Image Title2", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 57 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.ImageTitle2, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <label>Image Description</label>\r\n                                    ");
#nullable restore
#line 61 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.ImageDescription, null, new { @placeholder = "Enter Image Description", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 62 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.ImageDescription, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n");
                WriteLiteral("                                <div class=\"col-md-3\">\r\n                                    <label>Old Cost</label>\r\n                                    ");
#nullable restore
#line 68 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.OldCost, null, new { @placeholder = "Enter Old Cost", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 69 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.OldCost, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <label>New Cost</label>\r\n                                    ");
#nullable restore
#line 73 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.NewCost, null, new { @placeholder = "Enter New Cost", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 74 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.NewCost, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n");
                WriteLiteral("                                <div class=\"col-md-3\">\r\n                                    <label>Staring At</label>\r\n                                    ");
#nullable restore
#line 79 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.StartingAt, null, new { @placeholder = "Enter Starting At", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 80 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.StartingAt, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <label>Discount Percentage</label>\r\n                                    ");
#nullable restore
#line 84 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.DiscountPercent, null, new { @placeholder = "Enter Discounrt Percentage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 85 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.DiscountPercent, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n");
                WriteLiteral("                                <div class=\"col-md-3\">\r\n                                    <label>Text On Button</label>\r\n                                    ");
#nullable restore
#line 91 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.TextBoxFor(m => m.TextOnButton, null, new { @placeholder = "Enter Text On Button", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 92 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Image\ProductPageBannerData.cshtml"
                               Write(Html.ValidationMessageFor(m => m.TextOnButton, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n");
                WriteLiteral(@"                                <div class=""col-sm-3"">
                                    <div class=""form-group"">
                                        <label>Image Upload</label>
                                        <input type=""file"" name=""CategoryImageUpload"" />
                                    </div>
                                </div>
                                <div class=""col-sm-3"">
                                    <button type=""submit"" class=""btn btn-success serchgaptop""> Save</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.content -->\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.ImageDisplayModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
