#pragma checksum "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd1ef43fde4008e141c41ce253588244cb26eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RockCatalog), @"mvc.1.0.view", @"/Views/Home/RockCatalog.cshtml")]
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
#line 1 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd1ef43fde4008e141c41ce253588244cb26eaf", @"/Views/Home/RockCatalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RockCatalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rock>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
  
    ViewData["Title"] = "Милый дом";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 id=\"blink5\" class=\"display-4\">");
#nullable restore
#line 10 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
                                 Write(ViewBag.CatalogName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
</div>
<div class=""text-center"">
    <span style=""padding: 0px 20px;"">&nbsp;</span>
    <h3>Добавь в свою зачаровальню новые камни!</h3>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
</div>

<div class=""row""> 
");
#nullable restore
#line 21 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
  foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"col-4\">\r\n    <div class=\"card border-primary mb-3\" style=\"width: 18rem; height: 29rem\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 683, "\"", 701, 1);
#nullable restore
#line 25 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
WriteAttributeValue("", 689, product.Img, 689, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 18rem\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 27 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 28 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd1ef43fde4008e141c41ce253588244cb26eaf6411", async() => {
                WriteLiteral("\r\n             <input type=\"hidden\" name=\"a\"");
                BeginWriteAttribute("value", " value=\"", 1021, "\"", 1048, 1);
#nullable restore
#line 30 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
WriteAttributeValue("", 1029, User.Identity.Name, 1029, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n             <input type=\"hidden\" name=\"b\"");
                BeginWriteAttribute("value", " value=\"", 1096, "\"", 1117, 1);
#nullable restore
#line 31 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"
WriteAttributeValue("", 1104, product.Name, 1104, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n             <input type=\"hidden\" name=\"c\" value=\"Rock\" />\r\n             <input id=\"blink6\" class=\"btn btn-primary\" type=\"submit\" value=\"Добавить\" />\r\n             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n </div>\r\n");
#nullable restore
#line 38 "D:\ТРПО_MysticalShop\MythicalShop\Shop\Views\Home\RockCatalog.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"padding: 0px 20px;\">&nbsp;</span>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rock>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591