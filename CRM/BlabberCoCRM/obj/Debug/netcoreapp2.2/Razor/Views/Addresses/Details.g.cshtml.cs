#pragma checksum "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0341decd4113811f0fd06703ca35b539d5beab43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Addresses_Details), @"mvc.1.0.view", @"/Views/Addresses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Addresses/Details.cshtml", typeof(AspNetCore.Views_Addresses_Details))]
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
#line 1 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\_ViewImports.cshtml"
using BlabberCoCRM;

#line default
#line hidden
#line 2 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\_ViewImports.cshtml"
using BlabberCoCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0341decd4113811f0fd06703ca35b539d5beab43", @"/Views/Addresses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88723a73c02d5bef5f860dfcdd27896137a1d57", @"/Views/_ViewImports.cshtml")]
    public class Views_Addresses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlabberCoCRM.Models.Address>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(212, 48, false);
#line 14 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildingName));

#line default
#line hidden
            EndContext();
            BeginContext(260, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(324, 44, false);
#line 17 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildingName));

#line default
#line hidden
            EndContext();
            BeginContext(368, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(431, 50, false);
#line 20 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(481, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(545, 46, false);
#line 23 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(591, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(654, 48, false);
#line 26 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(702, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(766, 44, false);
#line 29 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(810, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(873, 48, false);
#line 32 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(921, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(985, 44, false);
#line 35 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1092, 48, false);
#line 38 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine3));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1204, 44, false);
#line 41 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine3));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1311, 44, false);
#line 44 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostCode));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1419, 40, false);
#line 47 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostCode));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1506, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0341decd4113811f0fd06703ca35b539d5beab439411", async() => {
                BeginContext(1552, 4, true);
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
#line 52 "G:\Dev\repos\BlabberCoCRM\BlabberCo\CRM\BlabberCoCRM\Views\Addresses\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1560, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1568, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0341decd4113811f0fd06703ca35b539d5beab4311736", async() => {
                BeginContext(1590, 12, true);
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
            BeginContext(1606, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlabberCoCRM.Models.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
