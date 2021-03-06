#pragma checksum "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "649d3413ea41deaa567d8e9a2a5f67f18362f9d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Athletes_Reconcile), @"mvc.1.0.view", @"/Views/Athletes/Reconcile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649d3413ea41deaa567d8e9a2a5f67f18362f9d8", @"/Views/Athletes/Reconcile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73f1b1114c17a34b22ef7e02579e5c62d85dd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Athletes_Reconcile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySportTeam.Models.Patient_FHIR>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
  
    ViewData["Title"] = "Reconcile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Reconcile Patient Details</h1>

<div>
    <h4>Patient</h4>
    <hr />
    <table class=""table"">
        <thead>
            <tr>
                <th>Field</th>
                <th>MySportTeam</th>
                <th>FHIR Server</th>
            </tr>
        </thead>
        <tbody>
            

");
#nullable restore
#line 23 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
             
                var rowClass="";
                if(Model.Family.Equals(Model.FHIR_Family)){
                    rowClass = "table-success";
                }
                else
                {
                    rowClass = "table-danger";
                } 
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 725, "\"", 742, 1);
#nullable restore
#line 33 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
WriteAttributeValue("", 733, rowClass, 733, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 34 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayNameFor(model => model.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.FHIR_Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 39 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
             
                rowClass="";
                if(Model.Given.Equals(Model.FHIR_Given)){
                    rowClass = "table-success";
                }
                else
                {
                    rowClass = "table-danger";
                } 
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 1285, "\"", 1302, 1);
#nullable restore
#line 49 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
WriteAttributeValue("", 1293, rowClass, 1293, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 50 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayNameFor(model => model.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.FHIR_Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr> \r\n");
#nullable restore
#line 54 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               
                rowClass="";
                if(Model.birthDate.Equals(Model.FHIR_birthDate)){
                    rowClass = "table-success";
                }
                else
                {
                    rowClass = "table-danger";
                } 
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 1851, "\"", 1868, 1);
#nullable restore
#line 64 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
WriteAttributeValue("", 1859, rowClass, 1859, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 65 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayNameFor(model => model.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 66 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 67 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.FHIR_birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr> \r\n");
#nullable restore
#line 69 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               
                rowClass="";
                if(Model.Gender.ToUpper().Equals(Model.FHIR_Gender.ToUpper())){
                    rowClass = "table-success";
                }
                else
                {
                    rowClass = "table-danger";
                } 
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 2443, "\"", 2460, 1);
#nullable restore
#line 79 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
WriteAttributeValue("", 2451, rowClass, 2451, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 80 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
               Write(Html.DisplayFor(model => model.FHIR_Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>                      \r\n        </tbody>\r\n    </table>   \r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "649d3413ea41deaa567d8e9a2a5f67f18362f9d813581", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 88 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\Reconcile.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "649d3413ea41deaa567d8e9a2a5f67f18362f9d815815", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySportTeam.Models.Patient_FHIR> Html { get; private set; }
    }
}
#pragma warning restore 1591
