#pragma checksum "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e408952b25b2efd9c03e09561b76640f153c694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webapp.Pages.Vragen.Steleenvraag.Pages_Vragen_Steleenvraag_Details), @"mvc.1.0.razor-page", @"/Pages/Vragen/Steleenvraag/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vragen/Steleenvraag/Details.cshtml", typeof(webapp.Pages.Vragen.Steleenvraag.Pages_Vragen_Steleenvraag_Details), null)]
namespace webapp.Pages.Vragen.Steleenvraag
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e408952b25b2efd9c03e09561b76640f153c694", @"/Pages/Vragen/Steleenvraag/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5569a73cf905216bed2b6e1222f91d848aa1d31c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vragen_Steleenvraag_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Question</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(236, 49, false);
#line 15 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Question.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(285, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(347, 45, false);
#line 18 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayFor(model => model.Question.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(392, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(453, 50, false);
#line 21 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Question.Vraag));

#line default
#line hidden
            EndContext();
            BeginContext(503, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(565, 46, false);
#line 24 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayFor(model => model.Question.Vraag));

#line default
#line hidden
            EndContext();
            BeginContext(611, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(672, 48, false);
#line 27 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Question.Vak));

#line default
#line hidden
            EndContext();
            BeginContext(720, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(782, 44, false);
#line 30 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayFor(model => model.Question.Vak));

#line default
#line hidden
            EndContext();
            BeginContext(826, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(887, 51, false);
#line 33 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Question.Lokaal));

#line default
#line hidden
            EndContext();
            BeginContext(938, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1000, 47, false);
#line 36 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayFor(model => model.Question.Lokaal));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1108, 49, false);
#line 39 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Question.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1219, 45, false);
#line 42 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
       Write(Html.DisplayFor(model => model.Question.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1311, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e408952b25b2efd9c03e09561b76640f153c6948720", async() => {
                BeginContext(1366, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\Vragen\Steleenvraag\Details.cshtml"
                           WriteLiteral(Model.Question.ID);

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
            BeginContext(1374, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1382, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e408952b25b2efd9c03e09561b76640f153c69411069", async() => {
                BeginContext(1404, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1420, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp.Pages.Vragen.Steleenvraag.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.Vragen.Steleenvraag.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.Vragen.Steleenvraag.DetailsModel>)PageContext?.ViewData;
        public webapp.Pages.Vragen.Steleenvraag.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
