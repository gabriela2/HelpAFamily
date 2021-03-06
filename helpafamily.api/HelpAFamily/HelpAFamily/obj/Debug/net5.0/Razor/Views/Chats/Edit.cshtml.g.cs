#pragma checksum "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Chats\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72302f63dcefba47797bc8258f9b5bb4815135d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chats_Edit), @"mvc.1.0.view", @"/Views/Chats/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72302f63dcefba47797bc8258f9b5bb4815135d", @"/Views/Chats/Edit.cshtml")]
    public class Views_Chats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelpAFamily.Models.Chat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Chats\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Chat</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""SenderId"" class=""control-label""></label>
                <input asp-for=""SenderId"" class=""form-control"" />
                <span asp-validation-for=""SenderId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SenderUsername"" class=""control-label""></label>
                <input asp-for=""SenderUsername"" class=""form-control"" />
                <span asp-validation-for=""SenderUsername"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReceiverId"" class=""control-label""></label>
                <input asp-for=""ReceiverId"" class=""form-control"" />
          ");
            WriteLiteral(@"      <span asp-validation-for=""ReceiverId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReceiverUsername"" class=""control-label""></label>
                <input asp-for=""ReceiverUsername"" class=""form-control"" />
                <span asp-validation-for=""ReceiverUsername"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Content"" class=""control-label""></label>
                <input asp-for=""Content"" class=""form-control"" />
                <span asp-validation-for=""Content"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataRead"" class=""control-label""></label>
                <input asp-for=""DataRead"" class=""form-control"" />
                <span asp-validation-for=""DataRead"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""");
            WriteLiteral(@"MessageSent"" class=""control-label""></label>
                <input asp-for=""MessageSent"" class=""form-control"" />
                <span asp-validation-for=""MessageSent"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""SenderDeleted"" /> ");
#nullable restore
#line 53 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Chats\Edit.cshtml"
                                                                          Write(Html.DisplayNameFor(model => model.SenderDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"ReceiverDeleted\" /> ");
#nullable restore
#line 58 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Chats\Edit.cshtml"
                                                                            Write(Html.DisplayNameFor(model => model.ReceiverDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""DonationId"" class=""control-label""></label>
                <select asp-for=""DonationId"" class=""form-control"" asp-items=""ViewBag.DonationId""></select>
                <span asp-validation-for=""DonationId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AdId"" class=""control-label""></label>
                <select asp-for=""AdId"" class=""form-control"" asp-items=""ViewBag.AdId""></select>
                <span asp-validation-for=""AdId"" class=""text-danger""></span>
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
#line 83 "C:\Users\User\Documents\HelpAFamily\helpafamily.api\HelpAFamily\HelpAFamily\Views\Chats\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpAFamily.Models.Chat> Html { get; private set; }
    }
}
#pragma warning restore 1591
