#pragma checksum "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Demands\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e2049b438977f8a250aa7bc2738178da7c9c07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demands_Create), @"mvc.1.0.view", @"/Views/Demands/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e2049b438977f8a250aa7bc2738178da7c9c07", @"/Views/Demands/Create.cshtml")]
    public class Views_Demands_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelpAFamily.Models.Demand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Demands\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Demand</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class =""form-control"" asp-items=""ViewBag.UserId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""AdId"" class=""control-label""></label>
                <select asp-for=""AdId"" class =""form-control"" asp-items=""ViewBag.AdId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedAt"" class=""control-label""></label>
                <input asp-for=""CreatedAt"" class=""form-control"" />
                <span asp-validation-for=""CreatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quanti");
            WriteLiteral(@"ty"" class=""control-label""></label>
                <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeliveryTypeId"" class=""control-label""></label>
                <select asp-for=""DeliveryTypeId"" class =""form-control"" asp-items=""ViewBag.DeliveryTypeId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
#line 49 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Demands\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpAFamily.Models.Demand> Html { get; private set; }
    }
}
#pragma warning restore 1591
