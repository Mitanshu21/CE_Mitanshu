#pragma checksum "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91da2d1887e528f530c47d1de5b81fe33f3a4608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.Web.Pages.Basket.Pages_Basket_Checkout), @"mvc.1.0.razor-page", @"/Pages/Basket/Checkout.cshtml")]
namespace Microsoft.eShopWeb.Web.Pages.Basket
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
#line 1 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91da2d1887e528f530c47d1de5b81fe33f3a4608", @"/Pages/Basket/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3eac3cadc9c5c1e04416db60e767f2c2d60b242", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Basket_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-catalog-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/main_banner_text.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn esh-basket-checkout text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"esh-catalog-hero\">\n    <div class=\"container\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91da2d1887e528f530c47d1de5b81fe33f3a46087814", async() => {
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
            WriteLiteral("\n    </div>\n</section>\n\n<div class=\"container\">\n    <h1>Review</h1>\n");
#nullable restore
#line 14 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
     if (Model.BasketModel.Items.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91da2d1887e528f530c47d1de5b81fe33f3a46089261", async() => {
                WriteLiteral(@"
            <article class=""esh-basket-titles row"">
                <br />
                <section class=""esh-basket-title col-xs-3"">Product</section>
                <section class=""esh-basket-title col-xs-3 hidden-lg-down""></section>
                <section class=""esh-basket-title col-xs-2"">Price</section>
                <section class=""esh-basket-title col-xs-2"">Quantity</section>
                <section class=""esh-basket-title col-xs-2"">Cost</section>
            </article>
            <div class=""esh-catalog-items row"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91da2d1887e528f530c47d1de5b81fe33f3a460810082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 26 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                 for (int i = 0; i < Model.BasketModel.Items.Count; i++)
                {
                    var item = Model.BasketModel.Items[i];

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <article class=""esh-basket-items row"">
                        <div>
                            <section class=""esh-basket-item esh-basket-item--middle col-lg-3 hidden-lg-down"">
                                <img class=""esh-basket-image""");
                BeginWriteAttribute("src", " src=\"", 1393, "\"", 1415, 1);
#nullable restore
#line 33 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
WriteAttributeValue("", 1399, item.PictureUrl, 1399, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            </section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-3\">");
#nullable restore
#line 35 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                                                                                         Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">$ ");
#nullable restore
#line 36 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                                                                                           Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">\n                                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1865, "\"", 1896, 1);
#nullable restore
#line 38 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
WriteAttributeValue("", 1872, "Items[" + i + "].Id", 1872, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1897, "\"", 1913, 1);
#nullable restore
#line 38 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
WriteAttributeValue("", 1905, item.Id, 1905, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1970, "\"", 2007, 1);
#nullable restore
#line 39 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
WriteAttributeValue("", 1977, "Items[" + i + "].Quantity", 1977, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2008, "\"", 2030, 1);
#nullable restore
#line 39 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
WriteAttributeValue("", 2016, item.Quantity, 2016, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                ");
#nullable restore
#line 40 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </section>\n                            <section class=\"esh-basket-item esh-basket-item--middle esh-basket-item--mark col-xs-2\">$ ");
#nullable restore
#line 42 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                                                                                                                 Write(Math.Round(item.Quantity * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</section>\n                        </div>\n                        <div class=\"row\">\n\n                        </div>\n                    </article>\n");
#nullable restore
#line 48 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""container"">
                    <article class=""esh-basket-titles esh-basket-titles--clean row"">
                        <section class=""esh-basket-title col-xs-10""></section>
                        <section class=""esh-basket-title col-xs-2"">Total</section>
                    </article>

                    <article class=""esh-basket-items row"">
                        <section class=""esh-basket-item col-xs-10""></section>
                        <section class=""esh-basket-item esh-basket-item--mark col-xs-2"">$ ");
#nullable restore
#line 58 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
                                                                                     Write(Model.BasketModel.Total().ToString("N2"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</section>
                    </article>

                    <article class=""esh-basket-items row"">
                        <section class=""esh-basket-item col-xs-7""></section>
                    </article>
                </div>
                <div class=""row"">
                    <section class=""esh-basket-item col-xs-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91da2d1887e528f530c47d1de5b81fe33f3a460817957", async() => {
                    WriteLiteral("[ Back ]");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </section>
                    <section class=""esh-basket-item col-xs-push-7 col-xs-4 text-right"">
                        <input type=""submit"" class=""btn esh-basket-checkout"" value=""[ Pay Now ]"" />
                    </section>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 75 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"esh-catalog-items row\">\n            Basket is empty.\n        </h3>\n");
            WriteLiteral("        <section class=\"esh-basket-item\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91da2d1887e528f530c47d1de5b81fe33f3a460821347", async() => {
                WriteLiteral("[ Continue Shopping..]");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </section>\n");
#nullable restore
#line 85 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Pages\Basket\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckoutModel>)PageContext?.ViewData;
        public CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591