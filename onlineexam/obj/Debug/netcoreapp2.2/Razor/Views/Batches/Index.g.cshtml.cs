#pragma checksum "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae35942ec6323144fbda301476e8517a8b0b298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Batches_Index), @"mvc.1.0.view", @"/Views/Batches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Batches/Index.cshtml", typeof(AspNetCore.Views_Batches_Index))]
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
#line 1 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\_ViewImports.cshtml"
using onlineexam;

#line default
#line hidden
#line 3 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\_ViewImports.cshtml"
using onlineexam.ViewModels;

#line default
#line hidden
#line 4 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
using onlineexam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae35942ec6323144fbda301476e8517a8b0b298", @"/Views/Batches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df1bdf5a08ac53e4920a0dafc40b97dcc05cfec", @"/Views/_ViewImports.cshtml")]
    public class Views_Batches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Batch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 155, true);
            WriteLiteral("<br /><br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-success\">Batches</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            EndContext();
            BeginContext(244, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae35942ec6323144fbda301476e8517a8b0b2984841", async() => {
                BeginContext(291, 44, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New???");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(339, 241, true);
            WriteLiteral("\n    </div>\n</div>\n<br />\n<div>\n    <table class=\"table table-striped border\" id=\"myTable\">\n        <tr class=\"table-success\">\n            <th>\n                Name\n            </th>\n            <td></td>\n            <td></td>\n        </tr>\n");
            EndContext();
#line 25 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(627, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(665, 9, false);
#line 28 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(674, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(721, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ae35942ec6323144fbda301476e8517a8b0b2987247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 30 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(771, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 33 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(822, 20, true);
            WriteLiteral("    </table>\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(859, 415, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready( function (){
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        });
        $(function(){
            var save = '");
                EndContext();
                BeginContext(1275, 16, false);
#line 48 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(1291, 107, true);
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
                EndContext();
                BeginContext(1399, 16, false);
#line 52 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(1415, 106, true);
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
                EndContext();
                BeginContext(1522, 18, false);
#line 56 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Batches\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(1540, 105, true);
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Batch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
