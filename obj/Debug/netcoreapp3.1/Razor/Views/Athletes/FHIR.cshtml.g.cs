#pragma checksum "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7fb0b8889930f4febd9c750dd8b640ebea7df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Athletes_FHIR), @"mvc.1.0.view", @"/Views/Athletes/FHIR.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7fb0b8889930f4febd9c750dd8b640ebea7df0", @"/Views/Athletes/FHIR.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73f1b1114c17a34b22ef7e02579e5c62d85dd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Athletes_FHIR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySportTeam.Models.Patient_FHIR>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
  
    ViewData["Title"] = "FHIR!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>FHIR!</h1>\n<div>\n    <h4>Patient</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 13 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 16 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 19 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 22 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Given));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 25 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 28 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.birthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 31 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 34 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 37 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Identifier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 40 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Identifier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 43 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 46 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        \n    </dl>\n       <hr />\n<h4>Information from the FHIR Server: </h4> \n  <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            Server At\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 65 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => model.FHIRServerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n   <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            Patient Id At Server\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 73 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => 
            model.FHIR_Demographics.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Address\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 80 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => 
            model.FullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Race\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 87 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
       Write(Html.DisplayFor(model => 
            model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n   </dl>\n    <hr/>\n    <h5>Patient\'s Contact</h5>\n    <table class=\"table\">\n        <tbody>\n               \n                     <tr>\n                         <td>Phones: </td>\n                         <td> ");
#nullable restore
#line 98 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
                         Write(Html.DisplayFor(model => 
            model.FullTelecom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                     </tr>\n                     <tr>\n                         <td>Emails: </td>\n                         <td> ");
#nullable restore
#line 103 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
                         Write(Html.DisplayFor(model => 
            model.FullEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                     </tr>
        </tbody>
    </table>
    <h5>Patient's Conditions</h5>
    <table class=""table"">
    <thead>
        <tr>
            <th>
                Status
            </th>
            <th>
                Category
            </th>
            <th>
                Severity
            </th>
            <th>
                Code
            </th>
        </tr>
    </thead>    
     <tbody>
");
#nullable restore
#line 127 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
          for (int i = 0; i < Model.Conditions.Count(); i++)
         {
            string status = Model.Conditions[i].ClinicalStatus.Coding[0].Code;
            string VerificationStatus=Model.Conditions[i].VerificationStatus.Coding[0].Code;
            Hl7.Fhir.Model.FhirDateTime onsetDate= (Hl7.Fhir.Model.FhirDateTime)Model.Conditions[i].Onset;
            TimeSpan z=new TimeSpan();
            
            DateTimeOffset onSetDate=(DateTimeOffset) onsetDate.ToDateTimeOffset(z);
            string onSetDisplay=onSetDate.ToString("dd MMM yyyy");
            string code = Model.Conditions[i].Code.Coding[0].Code
                                         +"-"+Model.Conditions[i].Code.Coding[0].Display;

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 140 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                 ");
#nullable restore
#line 143 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
            Write(Html.DisplayFor(model => VerificationStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 146 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => onSetDisplay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 149 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
#nullable restore
#line 153 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
   
   </table> 
 <hr/>
  
<h5>Patient's Allergies</h5>
    <table class=""table"">
    <thead>
        <tr>
            <th>
                Status
            </th>
            <th>
                Type
            </th>
            <th>
                Category
            </th>
            <th>
                Code
            </th>
            <th>
                Criticality
            </th>
        </tr>
    </thead>    
     <tbody>
");
#nullable restore
#line 181 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
          for (int i = 0; i < Model.Allergies.Count(); i++)
         {
            string status=Model.Allergies[i].VerificationStatus.Coding[0].Code+"-"+Model.Allergies[i].ClinicalStatus.Coding[0].Code;
            string code = Model.Allergies[i].Code.Coding[0].Code
                                         +"-"+Model.Allergies[i].Code.Coding[0].Display;
            string type = Model.Allergies[i].Type.Value.ToString();
            string category=Model.Allergies[i].Category.ToArray()[0].ToString();
            string criticality = Model.Allergies[i].Code.Coding[0].Code
                                         +"-"+Model.Allergies[i].Code.Coding[0].Display;
            
                                         

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 194 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                 ");
#nullable restore
#line 197 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
            Write(Html.DisplayFor(model => type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 200 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 203 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 206 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => criticality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
#nullable restore
#line 210 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
   
   </table> 

 <hr/>
  
<h5>Patient's Medications</h5>
    <table class=""table"">
    <thead>
        <tr>
            <th>
                Status
            </th>
            <th>
                Intent
            </th>
            <th>
                Medication
            </th>
            <th>
                Authored On
            </th>
           </tr>
    </thead>    
     <tbody>
");
#nullable restore
#line 236 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
          for (int i = 0; i < Model.Medications.Count(); i++)
         {
            string status=Model.Medications[i].Status.Value.ToString();
            string intent=Model.Medications[i].Intent.Value.ToString();
            Hl7.Fhir.Model.CodeableConcept cc = (Hl7.Fhir.Model.CodeableConcept) Model.Medications[i].Medication;
            string code=cc.Coding[0].Code +"-"+cc.Coding[0].Display;
            DateTime authoredDate=DateTime.Parse(Model.Medications[i].AuthoredOn);
            string authoredDisplay=authoredDate.ToString("dd MMM yyyy");
          
                                         

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 248 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                 ");
#nullable restore
#line 251 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
            Write(Html.DisplayFor(model => intent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 254 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 257 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => authoredDisplay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
#nullable restore
#line 261 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
   
   </table> 
  
 <hr/>
  
<h5>Patient's Immunizations</h5>
    <table class=""table"">
    <thead>
        <tr>
            <th>
                Status
            </th>
            <th>
                Vaccine Code
            </th>
            <th>
                Route
            </th>
            <th>
                Date
            </th>
           </tr>
    </thead>    
     <tbody>
");
#nullable restore
#line 287 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
          for (int i = 0; i < Model.Immunizations.Count(); i++)
         {
            string status=Model.Immunizations[i].Status.Value.ToString();
            Hl7.Fhir.Model.CodeableConcept cc = (Hl7.Fhir.Model.CodeableConcept) Model.Immunizations[i].VaccineCode;
            string code=cc.Coding[0].Code +"-"+cc.Coding[0].Display;
            string ocurrenceDateTime=Model.Immunizations[i].Occurrence.ToString();
            DateTime ocurrenceDatep=DateTime.Parse(ocurrenceDateTime);
            string ocurrenceDate=ocurrenceDatep.ToString("dd MMM yyyy");
            string route="";
            Hl7.Fhir.Model.CodeableConcept ccr = (Hl7.Fhir.Model.CodeableConcept) Model.Immunizations[i].Route;
            if (ccr!=null)                                                    
            {
                route=ccr.Coding[0].Code +"-"+ccr.Coding[0].Display;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 303 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                 ");
#nullable restore
#line 306 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
            Write(Html.DisplayFor(model => code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 309 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => route));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 312 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => ocurrenceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
#nullable restore
#line 316 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
   
   </table> 
  
<h5>Practitioners Near The Patient</h5>
    <table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Address
            </th>
            <th>
                Telecom
            </th>
           </tr>
    </thead>    
     <tbody>
");
#nullable restore
#line 337 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
          for (int i = 0; i < Model.PractitionersNear.Count(); i++)
         {
            string name=Model.PractitionersNear[i].Name[0].Family+","+Model.PractitionersNear[i].Name[0].Given.First();
            string address=
            Model.PractitionersNear[i].Address[0].Line.First()+" "+
            Model.PractitionersNear[i].Address[0].City+" "+
            Model.PractitionersNear[i].Address[0].PostalCode+" "+
            Model.PractitionersNear[i].Address[0].State;
            string telecom=
            Model.PractitionersNear[i].Telecom[0].System+":"+Model.PractitionersNear[i].Telecom[0].Value;
              
            


#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n            <td>\n                ");
#nullable restore
#line 352 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                 ");
#nullable restore
#line 355 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
            Write(Html.DisplayFor(model => address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 358 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
           Write(Html.DisplayFor(model => telecom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
#nullable restore
#line 362 "D:\imp_docs\SLR_docs_Presentation\Abhi_Docs\KB\FHIR\FHIR-Intermidate\3.FHIR_Client\Assignment\FI_W02_FHIR_CLIENT_CS_PROJECT\CS\MySportTeam\Views\Athletes\FHIR.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n   \n   </table> \n\n   </div>\n\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7fb0b8889930f4febd9c750dd8b640ebea7df029376", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
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
