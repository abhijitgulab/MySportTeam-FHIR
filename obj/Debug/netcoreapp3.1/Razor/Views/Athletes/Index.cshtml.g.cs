#pragma checksum "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcceeed5b84132d30f00a442c46836d11b94f563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Athletes_Index), @"mvc.1.0.view", @"/Views/Athletes/Index.cshtml")]
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
#line 1 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\_ViewImports.cshtml"
using MySportTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\_ViewImports.cshtml"
using MySportTeam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcceeed5b84132d30f00a442c46836d11b94f563", @"/Views/Athletes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73f1b1114c17a34b22ef7e02579e5c62d85dd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Athletes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MySportTeam.Models.Athlete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FHIR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcceeed5b84132d30f00a442c46836d11b94f5635225", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                 ");
#nullable restore
#line 28 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.Identifier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </th>\r\n             <th>\r\n                 ");
#nullable restore
#line 31 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </th>\r\n             <th>\r\n                 ");
#nullable restore
#line 34 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </th>\r\n             \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identifier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcceeed5b84132d30f00a442c46836d11b94f56312562", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 65 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcceeed5b84132d30f00a442c46836d11b94f56314815", async() => {
                WriteLiteral("Details");
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
#nullable restore
#line 66 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcceeed5b84132d30f00a442c46836d11b94f56317074", async() => {
                WriteLiteral("Delete");
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
#nullable restore
#line 67 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("  |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcceeed5b84132d30f00a442c46836d11b94f56319332", async() => {
                WriteLiteral("FHIR!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MySportTeam.Models.Athlete>> Html { get; private set; }
    }
}
#pragma warning restore 1591