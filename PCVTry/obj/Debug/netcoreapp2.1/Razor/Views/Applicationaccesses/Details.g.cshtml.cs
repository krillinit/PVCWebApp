#pragma checksum "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3321540a83e70709ccd82c6f8562a919099fb17e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicationaccesses_Details), @"mvc.1.0.view", @"/Views/Applicationaccesses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Applicationaccesses/Details.cshtml", typeof(AspNetCore.Views_Applicationaccesses_Details))]
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
#line 1 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\_ViewImports.cshtml"
using PCVTry;

#line default
#line hidden
#line 2 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\_ViewImports.cshtml"
using PCVTry.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3321540a83e70709ccd82c6f8562a919099fb17e", @"/Views/Applicationaccesses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicationaccesses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.Applicationaccess>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 123, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Applicationaccess</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(204, 48, false);
#line 14 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mas500Access));

#line default
#line hidden
            EndContext();
            BeginContext(252, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(293, 44, false);
#line 17 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mas500Access));

#line default
#line hidden
            EndContext();
            BeginContext(337, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(378, 55, false);
#line 20 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddAccessNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(433, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(474, 64, false);
#line 23 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddAccessNavigation.AddiAccessId));

#line default
#line hidden
            EndContext();
            BeginContext(538, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(579, 58, false);
#line 26 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BporoleGroupNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(637, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(678, 60, false);
#line 29 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.BporoleGroupNavigation.Bpoid));

#line default
#line hidden
            EndContext();
            BeginContext(738, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(779, 58, false);
#line 32 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LrvroleGroupNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(837, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(878, 60, false);
#line 35 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.LrvroleGroupNavigation.LrvId));

#line default
#line hidden
            EndContext();
            BeginContext(938, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(979, 55, false);
#line 38 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OtsaccessNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1075, 63, false);
#line 41 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.OtsaccessNavigation.OtsAccessId));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1179, 58, false);
#line 44 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmsroleGroupNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1278, 69, false);
#line 47 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmsroleGroupNavigation.VmsroleGroupId));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1389, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf5caba62e1548ba9c190d6b56ff8a72", async() => {
                BeginContext(1438, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\Applicationaccesses\Details.cshtml"
                           WriteLiteral(Model.AppId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1446, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1453, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7683d38f930348f7bc8ffac423f39ee4", async() => {
                BeginContext(1475, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.Applicationaccess> Html { get; private set; }
    }
}
#pragma warning restore 1591
