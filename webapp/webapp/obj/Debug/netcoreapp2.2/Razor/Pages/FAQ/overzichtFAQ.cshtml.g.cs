#pragma checksum "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea76f6d75faf2d091415347d133a2377c90edda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webapp.Pages.FAQ.Pages_FAQ_overzichtFAQ), @"mvc.1.0.razor-page", @"/Pages/FAQ/overzichtFAQ.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FAQ/overzichtFAQ.cshtml", typeof(webapp.Pages.FAQ.Pages_FAQ_overzichtFAQ), null)]
namespace webapp.Pages.FAQ
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#line 3 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
using webapp.Models;

#line default
#line hidden
#line 4 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
using DatabaseController;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea76f6d75faf2d091415347d133a2377c90edda", @"/Pages/FAQ/overzichtFAQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5569a73cf905216bed2b6e1222f91d848aa1d31c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FAQ_overzichtFAQ : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inputvraag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Zoek een vraag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
  
    ViewData["Title"] = "FAQ";
    List<List<String>> Vakken = new List<List<String>>();
    DBConnection dbc = new DBConnection();
    Vakken = dbc.Send("SELECT distinct vak FROM projectcdb.faqvragen;");
    foreach (var item in Vakken)
    {
        item.Add(item[0].Replace(" ", ""));
    }
    List<List<List<String>>> Blokken = new List<List<List<String>>>();
    foreach (var vak in Vakken)
    {
        List<List<String>> blok = new DBConnection().Send("SELECT * FROM projectcdb.faqvragen WHERE vak = '" + vak[0] + "';");
        blok[0].Add(vak[1]);
        Blokken.Add(blok);
    }


#line default
#line hidden
            BeginContext(715, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(721, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea76f6d75faf2d091415347d133a2377c90edda6028", async() => {
                BeginContext(765, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(773, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cea76f6d75faf2d091415347d133a2377c90edda6417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 28 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Vraag);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(843, 59, true);
                WriteLiteral("\r\n\r\n\r\n    <button onclick=\'show(\"Zoek\");\'>Submit</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(909, 57, true);
            WriteLiteral("\r\n<center>overzicht van de FAQ</center>\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(966, 1708, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea76f6d75faf2d091415347d133a2377c90edda9697", async() => {
                BeginContext(972, 18, true);
                WriteLiteral("\r\n\r\n    <center>\r\n");
                EndContext();
#line 39 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
         foreach (var item in Vakken)
        {

#line default
#line hidden
                BeginContext(1040, 38, true);
                WriteLiteral("            <a href=\"#\" class=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\'", 1078, "\'", 1105, 3);
                WriteAttributeValue("", 1088, "show(\"", 1088, 6, true);
#line 41 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
WriteAttributeValue("", 1094, item[1], 1094, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1102, "\");", 1102, 3, true);
                EndWriteAttribute();
                BeginContext(1106, 25, true);
                WriteLiteral(">\r\n                <span>");
                EndContext();
                BeginContext(1132, 7, false);
#line 42 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                 Write(item[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 60, true);
                WriteLiteral("</span>\r\n            </a>\r\n            <p>&nbsp;&nbsp;</p>\r\n");
                EndContext();
#line 45 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
        }

#line default
#line hidden
                BeginContext(1210, 19, true);
                WriteLiteral("    </center>\r\n\r\n\r\n");
                EndContext();
#line 49 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
     foreach (var item2 in Blokken)
    {

#line default
#line hidden
                BeginContext(1273, 34, true);
                WriteLiteral("        <td>\r\n\r\n            <Table");
                EndContext();
                BeginWriteAttribute("id", " id=", 1307, "", 1323, 1);
#line 53 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
WriteAttributeValue("", 1311, item2[0][4], 1311, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1323, 49, true);
                WriteLiteral(" class=\"table table-striped\" style=\"display:none\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1372, "\"", 1392, 1);
#line 53 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
WriteAttributeValue("", 1380, item2[0][1], 1380, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1393, 251, true);
                WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th class=\"col-md-1\">Vraag</th>\r\n                        <th class=\"col-md-1\">Antwoord</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 62 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                     foreach (var item3 in item2)
                    {


#line default
#line hidden
                BeginContext(1720, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1783, 8, false);
#line 66 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                           Write(item3[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1791, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1831, 8, false);
#line 67 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                           Write(item3[2]);

#line default
#line hidden
                EndContext();
                BeginContext(1839, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 69 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                    }

#line default
#line hidden
                BeginContext(1900, 63, true);
                WriteLiteral("                </tbody>\r\n            </Table>\r\n        </td>\r\n");
                EndContext();
#line 73 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
    }

#line default
#line hidden
                BeginContext(1970, 375, true);
                WriteLiteral(@"
    <td>

        <Table id=Zoek class=""table table-striped"" style=""display:block"" title=""Zoek"">
            <thead>
                <tr>
                    <th class=""col-md-1"">Vraag</th>
                    <th class=""col-md-1"">Antwoord</th>
                    <th class=""col-md-1"">Vak</th>

                </tr>
            </thead>
            <tbody>

");
                EndContext();
#line 88 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                 foreach (var z in @Model.Zoeklijst)
                {


#line default
#line hidden
                BeginContext(2420, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(2475, 4, false);
#line 92 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                       Write(z[0]);

#line default
#line hidden
                EndContext();
                BeginContext(2479, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2515, 4, false);
#line 93 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                       Write(z[2]);

#line default
#line hidden
                EndContext();
                BeginContext(2519, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2555, 4, false);
#line 94 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                       Write(z[1]);

#line default
#line hidden
                EndContext();
                BeginContext(2559, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 96 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\FAQ\overzichtFAQ.cshtml"
                }

#line default
#line hidden
                BeginContext(2612, 55, true);
                WriteLiteral("            </tbody>\r\n        </Table>\r\n    </td>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2674, 2963, true);
            WriteLiteral(@"
<script>
    var nrs = new Array();
    nrs.push(""Zoek"");
    function show(nr) {


        nrs.forEach(myFunction);
        nrs.push(nr)

        document.getElementById(nr).style.display = ""block""
        console.log(nr + "" pushed"")


    }
    function myFunction(item, index) {
        document.getElementById(item).style.display = ""none""
        console.log(item)
    }
    function zoeky() {


        var container = document.getElementById(""zoek"");
        var content = container.innerHTML;
        container.innerHTML = content;

        //this line is to watch the result in console , you can remove it later
        console.log(""Refreshed"");


    }
</script>
<style>
    #table1, #table2, #table3, #table4 {
        display: none;
    }

    body {
        font-family: ""Nunito"", sans-serif;
        font-size: 24px;
    }

    a {
        text-decoration: none;
    }

    p {
        text-align: center;
    }

    sup {
        font-size: 36px;
        fo");
            WriteLiteral(@"nt-weight: 100;
        line-height: 55px;
    }

    .button {
        text-transform: uppercase;
        letter-spacing: 2px;
        text-align: center;
        color: #0C5;
        font-size: 24px;
        font-family: ""Nunito"", sans-serif;
        font-weight: 300;
        margin: 5em auto;
        position: relative;
        top: 0;
        right: 0;
        bottom: 0;
        left: 0;
        padding: 20px 0;
        width: 220px;
        height: 30px;
        background: #0D6;
        border: 1px solid #0D6;
        color: #FFF;
        overflow: hidden;
        transition: all 0.5s;
    }

        .button:hover, .button:active {
            text-decoration: none;
            color: #0C5;
            border-color: #0C5;
            background: #FFF;
        }

        .button span {
            display: inline-block;
            position: relative;
            padding-right: 0;
            transition: padding-right 0.5s;
        }

            .button span:aft");
            WriteLiteral(@"er {
                content: ' ';
                position: absolute;
                top: 0;
                right: -18px;
                opacity: 0;
                width: 10px;
                height: 10px;
                margin-top: -10px;
                background: rgba(0, 0, 0, 0);
                border: 3px solid #FFF;
                border-top: none;
                border-right: none;
                transition: opacity 0.5s, top 0.5s, right 0.5s;
                transform: rotate(-45deg);
            }

        .button:hover span, .button:active span {
            padding-right: 30px;
        }

            .button:hover span:after, .button:active span:after {
                transition: opacity 0.5s, top 0.5s, right 0.5s;
                opacity: 1;
                border-color: #0C5;
                right: 0;
                top: 50%;
            }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp.Pages.FAQ.overzichtFAQModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.FAQ.overzichtFAQModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.FAQ.overzichtFAQModel>)PageContext?.ViewData;
        public webapp.Pages.FAQ.overzichtFAQModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
