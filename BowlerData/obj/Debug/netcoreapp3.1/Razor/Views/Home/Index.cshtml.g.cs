#pragma checksum "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a3c326ef9dd76bdde2165836493c9d7218bf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\_ViewImports.cshtml"
using BowlerData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\_ViewImports.cshtml"
using BowlerData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\_ViewImports.cshtml"
using BowlerData.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2a3c326ef9dd76bdde2165836493c9d7218bf95", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382761849c412abdc24ff9efd16c021c69f2cf46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
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
        private global::BowlerData.Infrastructure.PaginationTagHelper __BowlerData_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
 foreach (var x in Model.Bowlers)
{
    //Display info: First Name, Middle Init, Last Name, Address, City, State, Zip, Phone Number

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"m-0\">\r\n        <p class=\"m-0\">");
#nullable restore
#line 10 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                  Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                                     Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                                                        Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0\">");
#nullable restore
#line 11 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                  Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 11 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                                    Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                                                  Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                                                                 Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0\">");
#nullable restore
#line 12 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
                  Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a3c326ef9dd76bdde2165836493c9d7218bf956063", async() => {
            }
            );
            __BowlerData_Infrastructure_PaginationTagHelper = CreateTagHelper<global::BowlerData.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__BowlerData_Infrastructure_PaginationTagHelper);
#nullable restore
#line 16 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
__BowlerData_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __BowlerData_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__BowlerData_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-team", "BowlerData.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 16 "C:\Users\natha\source\repos\BowlerData\BowlerData\Views\Home\Index.cshtml"
__BowlerData_Infrastructure_PaginationTagHelper.KeyValuePairs["team"] = Model.TeamName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-team", __BowlerData_Infrastructure_PaginationTagHelper.KeyValuePairs["team"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591