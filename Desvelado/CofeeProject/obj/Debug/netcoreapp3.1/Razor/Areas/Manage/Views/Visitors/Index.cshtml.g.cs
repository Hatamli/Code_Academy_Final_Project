#pragma checksum "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567fa68bb969ccaddb0a503b371254a9e0156154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Visitors_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Visitors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567fa68bb969ccaddb0a503b371254a9e0156154", @"/Areas/Manage/Views/Visitors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8eb64ae29f7c5c749e9def077b9e7f4b4bb51e0", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Visitors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Visitor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger sweet-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
  
    int count = 0;
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid py-4\">\n    <div class=\"row\">\n        <div class=\"col-md-10\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567fa68bb969ccaddb0a503b371254a9e01561546305", async() => {
                WriteLiteral("CREATE");
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
            WriteLiteral(@"
        </div>

        <div class=""col-12"">
            <div class=""card mb-4"">
                <div class=""card-header pb-0"">
                    <h6>Visitors table</h6>
                </div>
                <div class=""card-body px-0 pt-0 pb-2"">
                    <div class=""table-responsive p-0"">
                        <table class=""table align-items-center mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-secondary opacity-7""></th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Name</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Job</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Image Url</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs");
            WriteLiteral(" font-weight-bolder opacity-7\">Comment</th>\n                                    <th class=\"text-secondary opacity-7\"></th>\n                                </tr>\n                            </thead>\n                            <tbody>\n");
#nullable restore
#line 33 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                 foreach (Visitor visitor in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            <p>");
#nullable restore
#line 38 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                          Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </td>
                                        <td>
                                            <div class=""d-flex px-2 py-1"">
                                                <div class=""d-flex flex-column justify-content-center"">
                                                    <h6 class=""mb-0 text-sm text-center"">");
#nullable restore
#line 43 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                                                                    Write(visitor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 48 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                                                                Write(visitor.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        </td>\n                                        <td class=\"align-middle text-center text-sm\">\n                                            <p class=\"text-xs font-weight-bold mb-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "567fa68bb969ccaddb0a503b371254a9e015615411147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2704, "~/uploads/visitors/", 2704, 19, true);
#nullable restore
#line 51 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
AddHtmlAttributeValue("", 2723, visitor.ImageUrl, 2723, 17, false);

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
            WriteLiteral("</p>\n                                        </td>\n                                        <td class=\"align-middle text-center text-sm\">\n                                            <p class=\"text-xs font-weight-bold mb-0 text-ellipsisself\">");
#nullable restore
#line 54 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                                                                                  Write(visitor.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        </td>\n                                        <td class=\"align-middle\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567fa68bb969ccaddb0a503b371254a9e015615413494", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pencil\"></i>");
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
#line 57 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                                                   WriteLiteral(visitor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567fa68bb969ccaddb0a503b371254a9e015615415851", async() => {
                WriteLiteral("<i class=\"fa-solid fa-trash-can\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                                                     WriteLiteral(visitor.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 61 "C:\Users\LENOVO\Downloads\cofee_project-master\CofeeProject\Areas\Manage\Views\Visitors\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Visitor>> Html { get; private set; }
    }
}
#pragma warning restore 1591