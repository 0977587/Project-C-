#pragma checksum "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webapp.Pages.MakeQueue.Pages_MakeQueue_create), @"mvc.1.0.razor-page", @"/Pages/MakeQueue/create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MakeQueue/create.cshtml", typeof(webapp.Pages.MakeQueue.Pages_MakeQueue_create), null)]
namespace webapp.Pages.MakeQueue
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
#line 4 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
using DatabaseController;

#line default
#line hidden
#line 5 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
using webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b1ef3f1e8e3d94ee996f654688d0653bcbf0e61", @"/Pages/MakeQueue/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5569a73cf905216bed2b6e1222f91d848aa1d31c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MakeQueue_create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
  
    ViewData["Title"] = "Maak een Wachtrij";
    var time = DateTime.Now;
    var time2 = DateTime.Now.AddHours(3);
    List<string> dates = new List<string>();
    for (int x = 0; x < 4; x++)

    {
        var newtime = time.AddMinutes(x * 15);
        var temp = RoundDown(newtime);
        dates.Add(temp.ToString("H:mm"));
    }

    List<string> enddate = new List<string>();

    for (int x = 0; x < 8; x++)

    {
        var newtime = time2.AddMinutes(x * 15);
        var temp = RoundDown(newtime);
        enddate.Add(temp.ToString("H:mm"));
    }



#line default
#line hidden
            BeginContext(957, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(982, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e615492", async() => {
                BeginContext(988, 99, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Maak een wachtrij</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1094, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1098, 983, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e616785", async() => {
                BeginContext(1104, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1110, 962, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e617173", async() => {
                    BeginContext(1154, 66, true);
                    WriteLiteral("\r\n        <br />\r\n        <select id=\"selectNumber\">\r\n            ");
                    EndContext();
                    BeginContext(1220, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e617647", async() => {
                        BeginContext(1228, 14, true);
                        WriteLiteral("Kies begintijd");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1251, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1265, 27, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e619004", async() => {
                        BeginContext(1273, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1275, 8, false);
#line 51 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(dates[0]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1292, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1306, 27, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6110608", async() => {
                        BeginContext(1314, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1316, 8, false);
#line 52 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(dates[1]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1333, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1347, 27, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6112213", async() => {
                        BeginContext(1355, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1357, 8, false);
#line 53 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(dates[2]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1374, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1388, 27, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6113818", async() => {
                        BeginContext(1396, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1398, 8, false);
#line 54 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(dates[3]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1415, 70, true);
                    WriteLiteral("\r\n        </select>\r\n        <select id=\"selectNumber2\">\r\n            ");
                    EndContext();
                    BeginContext(1485, 30, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6115485", async() => {
                        BeginContext(1493, 13, true);
                        WriteLiteral("Kies eindtijd");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1515, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1529, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6116842", async() => {
                        BeginContext(1537, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1539, 10, false);
#line 58 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[0]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1558, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1572, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6118450", async() => {
                        BeginContext(1580, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1582, 10, false);
#line 59 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[1]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1601, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1615, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6120058", async() => {
                        BeginContext(1623, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1625, 10, false);
#line 60 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[2]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1644, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1658, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6121666", async() => {
                        BeginContext(1666, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1668, 10, false);
#line 61 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[3]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1687, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1701, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6123274", async() => {
                        BeginContext(1709, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1711, 10, false);
#line 62 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[4]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1730, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1744, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6124882", async() => {
                        BeginContext(1752, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1754, 10, false);
#line 63 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[5]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1773, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1787, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6126490", async() => {
                        BeginContext(1795, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1797, 10, false);
#line 64 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[6]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1816, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1830, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1ef3f1e8e3d94ee996f654688d0653bcbf0e6128098", async() => {
                        BeginContext(1838, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1840, 10, false);
#line 65 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                Write(enddate[7]);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1859, 206, true);
                    WriteLiteral("\r\n        </select>\r\n        <br />\r\n\r\n        <input placeholder=\"Naam van de wachtrij\" />\r\n        <!--<input asp-for=\"Name\" placeholder=\"Naam van de wachtrij\" />-->\r\n        <button>Submit</button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
                BeginContext(2072, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(2081, 131, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    //todo jurriaans vakken weergeven invoegen\r\n    //todo add a fucntionality\r\n\r\n    var tijdenweergeven = ");
            EndContext();
            BeginContext(2213, 5, false);
#line 80 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                     Write(dates);

#line default
#line hidden
            EndContext();
            BeginContext(2218, 175, true);
            WriteLiteral(";\r\n    for(i = 0; i < 4; i++) {\r\n        var opt = document.createElement(\"option\");\r\n        document.getElementById(\"selectNumber\").innerHTML += \'<option id=\"\' + i + \'\">\' + ");
            EndContext();
            BeginContext(2394, 8, false);
#line 83 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                                                                                    Write(dates[1]);

#line default
#line hidden
            EndContext();
            BeginContext(2402, 50, true);
            WriteLiteral(") + \'</option>\';\r\n    }\r\n\r\n     var endwachtrij = ");
            EndContext();
            BeginContext(2453, 7, false);
#line 86 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                  Write(enddate);

#line default
#line hidden
            EndContext();
            BeginContext(2460, 176, true);
            WriteLiteral(";\r\n    for(i = 0; i < 8; i++) {\r\n        var opt = document.createElement(\"option\");\r\n        document.getElementById(\"selectNumber2\").innerHTML += \'<option id=\"\' + i + \'\">\' + ");
            EndContext();
            BeginContext(2637, 10, false);
#line 89 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
                                                                                     Write(enddate[1]);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 35, true);
            WriteLiteral(" + \'</option>\';\r\n    }\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 32 "C:\Users\Matthijs\Documents\GitHub\Project-C-\webapp\webapp\Pages\MakeQueue\create.cshtml"
            
    public DateTime RoundDown(DateTime dateTime)
    {
        return new DateTime(dateTime.Year, dateTime.Month,
             dateTime.Day, dateTime.Hour, (dateTime.Minute / 15) * 15, 0);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp.Pages.MakeQueue.Queue> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.MakeQueue.Queue> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.MakeQueue.Queue>)PageContext?.ViewData;
        public webapp.Pages.MakeQueue.Queue Model => ViewData.Model;
    }
}
#pragma warning restore 1591
