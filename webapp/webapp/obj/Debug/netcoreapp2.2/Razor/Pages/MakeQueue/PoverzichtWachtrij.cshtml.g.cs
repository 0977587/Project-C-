#pragma checksum "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9d7e37a60ad21de8f9ff86d2d3b82cc564d9ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webapp.Pages.MakeQueue.Pages_MakeQueue_PoverzichtWachtrij), @"mvc.1.0.razor-page", @"/Pages/MakeQueue/PoverzichtWachtrij.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MakeQueue/PoverzichtWachtrij.cshtml", typeof(webapp.Pages.MakeQueue.Pages_MakeQueue_PoverzichtWachtrij), null)]
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
#line 1 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#line 4 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
using DatabaseController;

#line default
#line hidden
#line 5 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
using webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9d7e37a60ad21de8f9ff86d2d3b82cc564d9ae", @"/Pages/MakeQueue/PoverzichtWachtrij.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5569a73cf905216bed2b6e1222f91d848aa1d31c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MakeQueue_PoverzichtWachtrij : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
  
    ViewData["Title"] = "Vraag stellen";

    Wachtrij temp = new Wachtrij();
    temp.SelectOne(0);
    var vragen = temp.getVragen(0);
    var vragen2 = temp.getVragen(1);
    int temp2 = temp.getVragenAmount();

  

#line default
#line hidden
            BeginContext(329, 913, true);
            WriteLiteral(@"
<!DOCTYPE html>
<html lang=""en"">
<style>

.myButton {
	background-color:#44c767;
	border-radius:28px;
	border:1px solid #18ab29;
	display:inline-block;
	cursor:pointer;
	color:#ffffff;
	font-family:Arial;
	font-size:17px;
	padding:16px 31px;
	text-decoration:none;
	text-shadow:0px 1px 0px #2f6627;
}
.myButton:hover {
	background-color:#5cbf2a;
}
.myButton:active {
	position:relative;
	top:1px;
}

</style>
<div class=""col-xs-6"">
    <h2 class=""sub-header"">Te behandelen vragen</h2>
    <div class=""table-responsive"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th class=""col-md-1"">Vraag</th>
                    <th class=""col-md-2"">Naam</th>
                    <th class=""col-md-3"">Lokaal</th>
                    <th class=""col=md-4""> </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 57 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                  
                    var count = 0;
                

#line default
#line hidden
            BeginContext(1317, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 60 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                 foreach (var item in vragen)
                {
                    count++;
                    if (count > 5)
                    {
                        break;
                    }
                    User user = new User();


                    user.SelectOne(item.UserID);


#line default
#line hidden
            BeginContext(1628, 63, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"col-md-1\">");
            EndContext();
            BeginContext(1692, 14, false);
#line 73 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                    Write(item.VraagText);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-2\">");
            EndContext();
            BeginContext(1755, 13, false);
#line 74 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                    Write(user.Voornaam);

#line default
#line hidden
            EndContext();
            BeginContext(1768, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-3\">");
            EndContext();
            BeginContext(1817, 12, false);
#line 75 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                    Write(item.Locatie);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 112, true);
            WriteLiteral("</td>\r\n\r\n                    <td ref=\"#\" class=\"myButton\" asp-controller=\"PWachtrij\" asp-action =\"BehandelVraag\"");
            EndContext();
            BeginWriteAttribute("asp-route", " asp-route =\"", 1941, "\"", 1967, 1);
#line 77 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
WriteAttributeValue("", 1954, item.VraagID, 1954, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1968, 39, true);
            WriteLiteral(">Behandel</td>\r\n                </tr>\r\n");
            EndContext();
#line 79 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                }

#line default
#line hidden
            BeginContext(2026, 456, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <h2 class=""sub-header"">Vragen in behandeling</h2>
    <div class=""table-responsive"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th class=""col-md-1"">Vraag</th>
                    <th class=""col-md-2"">Naam</th>
                    <th class=""col-md-3"">Lokaal</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 94 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                  
                    var count2 = 0;
                

#line default
#line hidden
            BeginContext(2558, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 97 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                 foreach (var item in vragen2)
                {
                    count2++;
                    if (count2 > 5)
                    {
                        break;
                    }
                    User user = new User();
                    user.SelectOne(item.UserID);


#line default
#line hidden
            BeginContext(2868, 71, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"col-md-1\">");
            EndContext();
            BeginContext(2940, 14, false);
#line 108 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                        Write(item.VraagText);

#line default
#line hidden
            EndContext();
            BeginContext(2954, 52, true);
            WriteLiteral("</td>\r\n                        <td class=\"col-md-2\">");
            EndContext();
            BeginContext(3007, 13, false);
#line 109 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                        Write(user.Voornaam);

#line default
#line hidden
            EndContext();
            BeginContext(3020, 52, true);
            WriteLiteral("</td>\r\n                        <td class=\"col-md-3\">");
            EndContext();
            BeginContext(3073, 12, false);
#line 110 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                                        Write(item.Locatie);

#line default
#line hidden
            EndContext();
            BeginContext(3085, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 112 "C:\Users\jurri\AndroidStudioProjects\OpenDagApp\app\Project-C-\webapp\webapp\Pages\MakeQueue\PoverzichtWachtrij.cshtml"
                }

#line default
#line hidden
            BeginContext(3138, 69, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp.Pages.MakeQueue.Queue> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.MakeQueue.Queue> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webapp.Pages.MakeQueue.Queue>)PageContext?.ViewData;
        public webapp.Pages.MakeQueue.Queue Model => ViewData.Model;
    }
}
#pragma warning restore 1591
