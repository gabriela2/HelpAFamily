#pragma checksum "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1907f5536767ccfa77bbb7c87c146accc0b458a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pictures_Index), @"mvc.1.0.view", @"/Views/Pictures/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1907f5536767ccfa77bbb7c87c146accc0b458a7", @"/Views/Pictures/Index.cshtml")]
    public class Views_Pictures_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HelpAFamily.Models.Picture>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ad.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 761, "\"", 784, 1);
#nullable restore
#line 34 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
WriteAttributeValue("", 776, item.Id, 776, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 837, "\"", 860, 1);
#nullable restore
#line 35 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
WriteAttributeValue("", 852, item.Id, 852, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 915, "\"", 938, 1);
#nullable restore
#line 36 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
WriteAttributeValue("", 930, item.Id, 930, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Pictures\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HelpAFamily.Models.Picture>> Html { get; private set; }
    }
}
#pragma warning restore 1591
