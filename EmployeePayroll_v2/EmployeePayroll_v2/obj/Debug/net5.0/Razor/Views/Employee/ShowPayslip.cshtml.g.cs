#pragma checksum "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c75b0be1bf9f5035306bfbc645d1ae885799def7e115fdb327de6c46b03a3002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowPayslip), @"mvc.1.0.view", @"/Views/Employee/ShowPayslip.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\_ViewImports.cshtml"
using EmployeePayroll_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\_ViewImports.cshtml"
using EmployeePayroll_v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c75b0be1bf9f5035306bfbc645d1ae885799def7e115fdb327de6c46b03a3002", @"/Views/Employee/ShowPayslip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e4c004906f4a253c121514b5b6baa6879b27b61c459812871ba120dc8e1e3717", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_ShowPayslip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeePayroll_v2.Models.PaySlip>
    #nullable disable
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
            WriteLiteral("\r\n<h1>Employee PaySlip</h1>\r\n<hr />\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 9 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 12 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 26 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
         if (Model.EmployeeType == EnumEmployeeTypes.Regular)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 29 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 32 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 35 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayNameFor(model => model.AbsentDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 38 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayFor(model => model.AbsentDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 40 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 47 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 50 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayNameFor(model => model.PresentDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 53 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
           Write(Html.DisplayFor(model => model.PresentDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 55 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.Deductions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.Deductions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.TaxableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\risd\source\repos\EmployeePayroll_v2\Views\Employee\ShowPayslip.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c75b0be1bf9f5035306bfbc645d1ae885799def7e115fdb327de6c46b03a300211602", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeePayroll_v2.Models.PaySlip> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
