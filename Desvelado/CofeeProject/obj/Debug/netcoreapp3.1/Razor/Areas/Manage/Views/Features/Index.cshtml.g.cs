#pragma checksum "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a205f48e22d62b2733709dcdf33eaab004fab1ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Features_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Features/Index.cshtml")]
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
#line 4 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\_ViewImports.cshtml"
using CofeeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\_ViewImports.cshtml"
using CofeeProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\_ViewImports.cshtml"
using CofeeProject.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a205f48e22d62b2733709dcdf33eaab004fab1ac", @"/Areas/Manage/Views/Features/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8eb64ae29f7c5c749e9def077b9e7f4b4bb51e0", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Features_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AboutFeature>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid py-4"">
    <div class=""row"">
         <div class=""col-md-10"">
        </div>
        <div class=""col-12"">
            <div class=""card mb-4"">
                <div class=""card-header pb-0"">
                    <h6>About Features table</h6>
                </div>
                <div class=""card-body px-0 pt-0 pb-2"">
                    <div class=""table-responsive p-0"">
                        <table class=""table align-items-center mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Title 1</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Title 2</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Title 3</th>
                                </tr>
                            </thead>
                  ");
            WriteLiteral("          <tbody>\n");
#nullable restore
#line 27 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                 foreach (AboutFeature feature in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td>
                                            <div class=""d-flex px-2 py-1"">
                                                <div class=""d-flex flex-column justify-content-center"">
                                                    <h6 class=""mb-0 text-sm text-center"">");
#nullable restore
#line 33 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                    Write(feature.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                </div>
                                            </div>
                                        </td>
                                         <td>
                                            <div class=""d-flex px-2 py-1"">
                                                <div class=""d-flex flex-column justify-content-center"">
                                                    <h6 class=""mb-0 text-sm text-center"">");
#nullable restore
#line 40 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                    Write(feature.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""d-flex px-2 py-1"">
                                                <div class=""d-flex flex-column justify-content-center"">
                                                    <h6 class=""mb-0 text-sm text-center"">");
#nullable restore
#line 47 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                    Write(feature.Title3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                                </div>\n                                            </div>\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 52 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                        <br />
                         <table class=""table align-items-center mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Description 1</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Description 2</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Description 3</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 65 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                 foreach (AboutFeature feature in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                           <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 69 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 72 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 75 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 78 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                        <br />
                         <table class=""table align-items-center mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Added Text 1</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Added Text 2</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Added Text 3</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Image</th>
                                    <th class=""text-secondary opacity-7""></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 93 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                 foreach (AboutFeature feature in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 97 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.AddedText1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 100 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.AddedText2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 103 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                                                      Write(feature.AddedText3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle text-center text-sm\">\n                                                <p class=\"text-xs font-weight-bold mb-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a205f48e22d62b2733709dcdf33eaab004fab1ac15625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6774, "~/uploads/about/", 6774, 16, true);
#nullable restore
#line 106 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
AddHtmlAttributeValue("", 6790, feature.ImageUrl, 6790, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n                                            </td>\n                                            <td class=\"align-middle\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a205f48e22d62b2733709dcdf33eaab004fab1ac17395", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pencil\"></i>");
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
#line 109 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                                                   WriteLiteral(feature.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 112 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Features\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AboutFeature>> Html { get; private set; }
    }
}
#pragma warning restore 1591