#pragma checksum "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Donations\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8854f7cc4b2f41df9b4874cfd382eaab1ffef4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donations_Edit), @"mvc.1.0.view", @"/Views/Donations/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8854f7cc4b2f41df9b4874cfd382eaab1ffef4d", @"/Views/Donations/Edit.cshtml")]
    public class Views_Donations_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelpAFamily.Models.Donation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Donations\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Donation</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""UserSenderId"" class=""control-label""></label>
                <input asp-for=""UserSenderId"" class=""form-control"" />
                <span asp-validation-for=""UserSenderId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UserReceiverId"" class=""control-label""></label>
                <input asp-for=""UserReceiverId"" class=""form-control"" />
                <span asp-validation-for=""UserReceiverId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedAt"" class=""control-label""></label>
                <input asp-for=""CreatedAt"" class=""form-control"" ");
            WriteLiteral(@"/>
                <span asp-validation-for=""CreatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Amount"" class=""control-label""></label>
                <input asp-for=""Amount"" class=""form-control"" />
                <span asp-validation-for=""Amount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Donations\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpAFamily.Models.Donation> Html { get; private set; }
    }
}
#pragma warning restore 1591
