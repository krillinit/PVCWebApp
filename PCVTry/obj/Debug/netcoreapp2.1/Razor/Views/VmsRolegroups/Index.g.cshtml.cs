#pragma checksum "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7edd0f8cf8d4292c546d58d9cafb8e4f2cc39980"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VmsRolegroups_Index), @"mvc.1.0.view", @"/Views/VmsRolegroups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VmsRolegroups/Index.cshtml", typeof(AspNetCore.Views_VmsRolegroups_Index))]
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
#line 1 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\_ViewImports.cshtml"
using PCVTry;

#line default
#line hidden
#line 2 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\_ViewImports.cshtml"
using PCVTry.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edd0f8cf8d4292c546d58d9cafb8e4f2cc39980", @"/Views/VmsRolegroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_VmsRolegroups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PCVTry.Models.VmsRolegroup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(111, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473c141d212242188c2092d13985b692", async() => {
                BeginContext(134, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(148, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(235, 48, false);
#line 16 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(283, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(336, 48, false);
#line 19 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(384, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(437, 44, false);
#line 22 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(481, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(534, 43, false);
#line 25 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(577, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(630, 51, false);
#line 28 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(681, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(734, 49, false);
#line 31 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(783, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(836, 51, false);
#line 34 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(887, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(940, 48, false);
#line 37 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(988, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1041, 43, false);
#line 40 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1137, 59, false);
#line 43 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1249, 52, false);
#line 46 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1354, 38, false);
#line 49 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1445, 46, false);
#line 52 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1544, 47, false);
#line 55 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1644, 56, false);
#line 58 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 64 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1811, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1858, 47, false);
#line 67 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1958, 47, false);
#line 70 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2058, 43, false);
#line 73 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2154, 42, false);
#line 76 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2249, 50, false);
#line 79 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2352, 48, false);
#line 82 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2453, 50, false);
#line 85 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2556, 47, false);
#line 88 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2656, 42, false);
#line 91 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(2698, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2751, 58, false);
#line 94 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2862, 51, false);
#line 97 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2913, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2966, 37, false);
#line 100 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3056, 45, false);
#line 103 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3101, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3154, 46, false);
#line 106 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3253, 55, false);
#line 109 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(3308, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3360, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbdc1bad1814d9582c9061d1dc171c3", async() => {
                BeginContext(3417, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                       WriteLiteral(item.VmsroleGroupId);

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
            BeginContext(3425, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(3444, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db71d9bde214c65a8333b47a95bd7c1", async() => {
                BeginContext(3504, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                          WriteLiteral(item.VmsroleGroupId);

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
            BeginContext(3515, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(3534, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634f352980ab47b28589267182f4514d", async() => {
                BeginContext(3593, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
                                         WriteLiteral(item.VmsroleGroupId);

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
            BeginContext(3603, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 117 "C:\Users\lil-v\Documents\GitHub\PVCWebApp\PCVTry\Views\VmsRolegroups\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3638, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PCVTry.Models.VmsRolegroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
