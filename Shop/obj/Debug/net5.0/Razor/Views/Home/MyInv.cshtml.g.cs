#pragma checksum "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c754c83efdab3b9291aa57529e00948d4ee3c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyInv), @"mvc.1.0.view", @"/Views/Home/MyInv.cshtml")]
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
#line 1 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c754c83efdab3b9291aa57529e00948d4ee3c3", @"/Views/Home/MyInv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MyInv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<Rock>, IEnumerable<Niddle>, IEnumerable<Myinventory>>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
  
    ViewData["Title"] = "Милый дом";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 id=\"blink5\" class=\"display-4\">");
#nullable restore
#line 9 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
                                 Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
</div>
<div class=""text-center"">
    <span style=""padding: 0px 20px;"">&nbsp;</span>
    <h3>Ваши зачарованные камни и иголки!</h3>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
    <span style=""padding: 0px 20px;"">&nbsp;</span>
</div>

<div class=""row"">
");
#nullable restore
#line 20 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
     foreach (var myproduct in Model.Item3)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
         foreach (var product in Model.Item1)
        {
            if (product.Name == myproduct.ProductName && myproduct.UserName == User.Identity.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <div class=\"card border-primary mb-3\" style=\"width: 18rem; height: 29rem\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 940, "\"", 958, 1);
#nullable restore
#line 28 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
WriteAttributeValue("", 946, product.Img, 946, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 18rem\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
         foreach (var product in Model.Item2)
        {
            if (product.Name == myproduct.ProductName && myproduct.UserName == User.Identity.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <div class=\"card border-primary mb-3\" style=\"width: 18rem; height: 29rem\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1654, "\"", 1672, 1);
#nullable restore
#line 43 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
WriteAttributeValue("", 1660, product.Img, 1660, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 18rem\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 45 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 46 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\vladx\source\repos\SuperShop\MythicalShop\Shop\Views\Home\MyInv.cshtml"
         


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<Rock>, IEnumerable<Niddle>, IEnumerable<Myinventory>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
