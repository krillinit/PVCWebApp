#pragma checksum "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343d378ece4194119da3c43ecc220ab5503bb335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OtsAccesses_Details), @"mvc.1.0.view", @"/Views/OtsAccesses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OtsAccesses/Details.cshtml", typeof(AspNetCore.Views_OtsAccesses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343d378ece4194119da3c43ecc220ab5503bb335", @"/Views/OtsAccesses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_OtsAccesses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.OtsAccess>
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
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 115, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>OtsAccess</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(188, 42, false);
#line 14 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(230, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(271, 38, false);
#line 17 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(309, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(350, 47, false);
#line 20 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MultiAssign));

#line default
#line hidden
            EndContext();
            BeginContext(397, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(438, 43, false);
#line 23 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.MultiAssign));

#line default
#line hidden
            EndContext();
            BeginContext(481, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(522, 47, false);
#line 26 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeleteOrder));

#line default
#line hidden
            EndContext();
            BeginContext(569, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(610, 43, false);
#line 29 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeleteOrder));

#line default
#line hidden
            EndContext();
            BeginContext(653, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(694, 46, false);
#line 32 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ToReassign));

#line default
#line hidden
            EndContext();
            BeginContext(740, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(781, 42, false);
#line 35 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.ToReassign));

#line default
#line hidden
            EndContext();
            BeginContext(823, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(864, 49, false);
#line 38 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecreateOrder));

#line default
#line hidden
            EndContext();
            BeginContext(913, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(954, 45, false);
#line 41 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecreateOrder));

#line default
#line hidden
            EndContext();
            BeginContext(999, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1040, 52, false);
#line 44 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppraisalTagShip));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1133, 48, false);
#line 47 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppraisalTagShip));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1222, 54, false);
#line 50 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaintainTagReasons));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1317, 50, false);
#line 53 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaintainTagReasons));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1408, 56, false);
#line 56 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaintainClariReasons));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1505, 52, false);
#line 59 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaintainClariReasons));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1598, 46, false);
#line 62 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuditAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1685, 42, false);
#line 65 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuditAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1768, 54, false);
#line 68 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisputeQueueAccess));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1863, 50, false);
#line 71 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisputeQueueAccess));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1955, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e6ad4f1fe644d7be5856753dcad0be", async() => {
                BeginContext(2010, 4, true);
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
#line 76 "C:\Users\lil-v\Desktop\CoreWebApp-NewerBranch\PCVTry\Views\OtsAccesses\Details.cshtml"
                           WriteLiteral(Model.OtsAccessId);

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
            BeginContext(2018, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2025, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a94a5c05ce6437682a1fd2892bf8860", async() => {
                BeginContext(2047, 12, true);
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
            BeginContext(2063, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.OtsAccess> Html { get; private set; }
    }
}
#pragma warning restore 1591