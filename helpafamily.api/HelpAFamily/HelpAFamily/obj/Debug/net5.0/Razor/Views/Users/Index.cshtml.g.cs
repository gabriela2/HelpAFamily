#pragma checksum "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "488ad09ada54563eaf2792c23bdbbe4cd3ce786a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488ad09ada54563eaf2792c23bdbbe4cd3ce786a", @"/Views/Users/Index.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HelpAFamily.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordSalt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleTypes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserTypes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordSalt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleTypes.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserTypes.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1991, "\"", 2014, 1);
#nullable restore
#line 70 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
WriteAttributeValue("", 2006, item.Id, 2006, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2067, "\"", 2090, 1);
#nullable restore
#line 71 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
WriteAttributeValue("", 2082, item.Id, 2082, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2145, "\"", 2168, 1);
#nullable restore
#line 72 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
WriteAttributeValue("", 2160, item.Id, 2160, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Users\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HelpAFamily.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
