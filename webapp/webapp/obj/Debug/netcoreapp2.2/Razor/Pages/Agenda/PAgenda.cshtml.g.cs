#pragma checksum "C:\Users\laure\Documents\GitHub\Project-C-\webapp\webapp\Pages\Agenda\PAgenda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543d4c64cb926f16ee63883f3c53c37116434d73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webapp.Pages.Agenda.Pages_Agenda_PAgenda), @"mvc.1.0.razor-page", @"/Pages/Agenda/PAgenda.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Agenda/PAgenda.cshtml", typeof(webapp.Pages.Agenda.Pages_Agenda_PAgenda), null)]
namespace webapp.Pages.Agenda
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\laure\Documents\GitHub\Project-C-\webapp\webapp\Pages\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543d4c64cb926f16ee63883f3c53c37116434d73", @"/Pages/Agenda/PAgenda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5569a73cf905216bed2b6e1222f91d848aa1d31c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Agenda_PAgenda : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\laure\Documents\GitHub\Project-C-\webapp\webapp\Pages\Agenda\PAgenda.cshtml"
  
    ViewData["Title"] = "Agenda";

#line default
#line hidden
            BeginContext(70, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(75, 17, false);
#line 6 "C:\Users\laure\Documents\GitHub\Project-C-\webapp\webapp\Pages\Agenda\PAgenda.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 47, true);
            WriteLiteral("</h1>\r\n\r\n<p>Hier komt de agenda Peercoach</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
