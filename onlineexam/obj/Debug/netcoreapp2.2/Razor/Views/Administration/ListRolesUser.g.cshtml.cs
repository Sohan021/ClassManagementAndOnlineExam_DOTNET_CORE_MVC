#pragma checksum "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0bf6d1787a15e69a1bfdc2435c01c5183db0371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListRolesUser), @"mvc.1.0.view", @"/Views/Administration/ListRolesUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListRolesUser.cshtml", typeof(AspNetCore.Views_Administration_ListRolesUser))]
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
#line 2 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\_ViewImports.cshtml"
using onlineexam.Models;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0bf6d1787a15e69a1bfdc2435c01c5183db0371", @"/Views/Administration/ListRolesUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df1bdf5a08ac53e4920a0dafc40b97dcc05cfec", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListRolesUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListUsersInRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
  
    ViewBag.Title = "All Roles";

#line default
#line hidden
            BeginContext(101, 83, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-sm-3\">\n    </div>\n    <div class=\"col-sm-6\">\n");
            EndContext();
#line 9 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
            BeginContext(220, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(232, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bf6d1787a15e69a1bfdc2435c01c5183db03717798", async() => {
                BeginContext(354, 12, true);
                WriteLiteral("Add new role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 13 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"

            foreach (var role in Model)
            {

#line default
#line hidden
            BeginContext(426, 40, true);
            WriteLiteral("                <div class=\"card mb-3\">\n");
            EndContext();
            BeginContext(594, 91, true);
            WriteLiteral("                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(686, 9, false);
#line 21 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
                                          Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(695, 103, true);
            WriteLiteral("</h5>\n                    </div>\n                    <div class=\"card-footer\">\n                        ");
            EndContext();
            BeginContext(798, 985, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bf6d1787a15e69a1bfdc2435c01c5183db037110526", async() => {
                BeginContext(866, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(895, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bf6d1787a15e69a1bfdc2435c01c5183db037110936", async() => {
                    BeginContext(1038, 13, true);
                    WriteLiteral("View All User");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 26 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
                                 WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1055, 34, true);
                WriteLiteral("\n                            <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1089, "\"", 1120, 2);
                WriteAttributeValue("", 1094, "confirmDeleteSpan_", 1094, 18, true);
#line 27 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
WriteAttributeValue("", 1112, role.Id, 1112, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1121, 258, true);
                WriteLiteral(@" style=""display:none"">
                                <span>Are you sure you want to delete?</span>
                                <button type=""submit"" class=""btn btn-danger"">Yes</button>
                                <a href=""#"" class=""btn btn-primary""");
                EndContext();
                BeginWriteAttribute("onclick", "\n                                   onclick=\"", 1379, "\"", 1456, 4);
                WriteAttributeValue("", 1424, "confirmDelete(\'", 1424, 15, true);
#line 31 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
WriteAttributeValue("", 1439, role.Id, 1439, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1447, "\',", 1447, 2, true);
                WriteAttributeValue(" ", 1449, "false)", 1450, 7, true);
                EndWriteAttribute();
                BeginContext(1457, 77, true);
                WriteLiteral(">No</a>\n                            </span>\n                            <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1534, "\"", 1558, 2);
                WriteAttributeValue("", 1539, "deleteSpan_", 1539, 11, true);
#line 33 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
WriteAttributeValue("", 1550, role.Id, 1550, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1559, 68, true);
                WriteLiteral(">\n                                <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\n                                   onclick=\"", 1627, "\"", 1703, 4);
                WriteAttributeValue("", 1672, "confirmDelete(\'", 1672, 15, true);
#line 35 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
WriteAttributeValue("", 1687, role.Id, 1687, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1695, "\',", 1695, 2, true);
                WriteAttributeValue(" ", 1697, "true)", 1698, 6, true);
                EndWriteAttribute();
                BeginContext(1704, 72, true);
                WriteLiteral(">Delete</a>\n                            </span>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
                                                                      WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1783, 51, true);
            WriteLiteral("\n                    </div>\n                </div>\n");
            EndContext();
#line 40 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(1881, 329, true);
            WriteLiteral(@"            <div class=""card"">
                <div class=""card-header"">
                    No roles created yet
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title"">
                        Use the button below to create a role
                    </h5>
                    ");
            EndContext();
            BeginContext(2210, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bf6d1787a15e69a1bfdc2435c01c5183db037119665", async() => {
                BeginContext(2335, 57, true);
                WriteLiteral("\n                        Create Role\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2396, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 58 "F:\Study\SixCrdt\onlineexam\onlineexam\Views\Administration\ListRolesUser.cshtml"
        }

#line default
#line hidden
            BeginContext(2449, 8, true);
            WriteLiteral("        ");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2475, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(2488, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bf6d1787a15e69a1bfdc2435c01c5183db037121935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2526, 9, true);
                WriteLiteral("\n        ");
                EndContext();
            }
            );
            BeginContext(2537, 56, true);
            WriteLiteral("    </div>\n    <div class=\"col-sm-3\">\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
