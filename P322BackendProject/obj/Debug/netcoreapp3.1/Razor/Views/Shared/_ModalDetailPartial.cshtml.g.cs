#pragma checksum "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f47fdfea7b813fc83ec17f630c2c1d5c67640b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_ModalDetailPartial.cshtml")]
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
#line 1 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\_ViewImports.cshtml"
using PustokP322;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\_ViewImports.cshtml"
using PustokP322.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\_ViewImports.cshtml"
using PustokP322.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f47fdfea7b813fc83ec17f630c2c1d5c67640b78", @"/Views/Shared/_ModalDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d10ba5feb0d38d0a5937cdc9c33c5be825f32f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ModalDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<button type=""button"" class=""close modal-close-btn ml-auto"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            <div class=""product-details-modal"">
                <div class=""row"">
                    <div class=""col-lg-5"">
                        <!-- Product Details Slider Big Image-->
                     
                            
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f47fdfea7b813fc83ec17f630c2c1d5c67640b784337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 478, "~/assets/image/products/", 478, 24, true);
#nullable restore
#line 12 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
AddHtmlAttributeValue("", 502, Model.ImageUrl, 502, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          
                            
                       
                       
                    </div>
                    <div class=""col-lg-7 mt--30 mt-lg--30"">
                        <div class=""product-details-info pl-lg--30 "">
                            <p class=""tag-block"">Tags: 
");
#nullable restore
#line 21 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                 foreach (var item in @Model.BookTags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\">");
#nullable restore
#line 23 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                       Write(item.Tag.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 24 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            <h3 class=\"product-title\">");
#nullable restore
#line 26 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <ul class=\"list-unstyled\">\r\n                                <li>Ex Tax: <span class=\"list-value\"> ");
#nullable restore
#line 28 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                                                 Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>Brands: <a href=\"#\" class=\"list-value font-weight-bold\"> Canon</a></li>\r\n                                <li>Product Code: <span class=\"list-value\"> ");
#nullable restore
#line 30 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                                                       Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>Reward Points: <span class=\"list-value\"> 200</span></li>\r\n                                <li>Availability: <span class=\"list-value\"> ");
#nullable restore
#line 32 "C:\Users\Nursultan Sultanov\Desktop\P322Backend\Backend-ProjectP322\P322BackendProject\Views\Shared\_ModalDetailPartial.cshtml"
                                                                       Write(Model.IsAvailability);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                            </ul>
                            <div class=""price-block"">
                                <span class=""price-new"">£73.79</span>
                                <del class=""price-old"">£91.86</del>
                            </div>
                            <div class=""rating-widget"">
                                <div class=""rating-block"">
                                    <span class=""fas fa-star star_on""></span>
                                    <span class=""fas fa-star star_on""></span>
                                    <span class=""fas fa-star star_on""></span>
                                    <span class=""fas fa-star star_on""></span>
                                    <span class=""fas fa-star ""></span>
                                </div>
                                <div class=""review-widget"">
                                    <a href=""#"">(1 Reviews)</a> <span>|</span>
                                    <a href=""#"">Write a re");
            WriteLiteral(@"view</a>
                                </div>
                            </div>
                            <article class=""product-details-article"">
                                <h4 class=""sr-only"">Product Summery</h4>
                                <p>
                                    Long printed dress with thin adjustable straps. V-neckline and wiring under
                                    the Dust with ruffles
                                    at the bottom
                                    of the
                                    dress.
                                </p>
                            </article>
                            <div class=""add-to-cart-row"">
                                <div class=""count-input-block"">
                                    <span class=""widget-label"">Qty</span>
                                    <input type=""number"" class=""form-control text-center"" value=""1"">
                                </div>
                          ");
            WriteLiteral(@"      <div class=""add-cart-btn"">
                                    <a href=""#"" class=""btn btn-outlined--primary"">
                                        <span class=""plus-icon"">+</span>Add to Cart
                                    </a>
                                </div>
                            </div>
                            <div class=""compare-wishlist-row"">
                                <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                                <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""widget-social-share"">
                    <span class=""widget-label"">Share:</span>
                    <div class=""modal-social-share"">
                        <a href=""#"" class=""single-icon""><i class=""fab f");
            WriteLiteral(@"a-facebook-f""></i></a>
                        <a href=""#"" class=""single-icon""><i class=""fab fa-twitter""></i></a>
                        <a href=""#"" class=""single-icon""><i class=""fab fa-youtube""></i></a>
                        <a href=""#"" class=""single-icon""><i class=""fab fa-google-plus-g""></i></a>
                    </div>
                </div>
            </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591