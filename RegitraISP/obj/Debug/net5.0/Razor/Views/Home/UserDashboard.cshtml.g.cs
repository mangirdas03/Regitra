#pragma checksum "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42bdbe7bd26ba44cfcddcaa5e32ee91d808fba55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserDashboard), @"mvc.1.0.view", @"/Views/Home/UserDashboard.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bdbe7bd26ba44cfcddcaa5e32ee91d808fba55", @"/Views/Home/UserDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.Models.Klienta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"section\" class=\"bodysection\">\r\n    <div class=\"container_white\">\r\n        <section class=\"tm-margin-b-l\">\r\n            <h2 class=\"pagetitle\">Naudotojo paskyra</h2>\r\n            <br />\r\n            <p class=\"page_infotext\">Sveiki <strong>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                                               Write(Html.DisplayFor(modelItem => Model.Vardas));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                                                                                           Write(Html.DisplayFor(modelItem => Model.Pavarde));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</strong> Esate prisijungę prie sistemos. Galite naudotis visomis funkcijomis bei paslaugomis.</p>
            <br />
            <br />
            <p class=""page_infotext"">Naudotojo informacija:</p>
            <div style=""padding-left:50px"">
                <p>Asmens kodas: <strong>");
#nullable restore
#line 18 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.AsmensKodas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>Vardas: <strong>");
#nullable restore
#line 19 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                              Write(Html.DisplayFor(modelItem => Model.Vardas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>Pavardė: <strong>");
#nullable restore
#line 20 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Pavarde));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>Tel. nr: <strong>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.TelNr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>El. paštas: <strong>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                                  Write(Html.DisplayFor(modelItem => Model.ElPastas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 23 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                 if (Model.TeorijosEgzIslaikytas == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Teorijos egzaminas:<strong> Išlaikytas.</strong></p>\r\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Teorijos egzaminas:<strong> Neišlaikytas.</strong></p>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                 if (Model.PraktikosEgzIslaikytas == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Praktikos egzaminas:<strong> Išlaikytas.</strong></p>\r\n");
#nullable restore
#line 34 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Praktikos egzaminas:<strong> Neišlaikytas.</strong></p>\r\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Nuotrauka:</p>\r\n");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                 if (Model.Nuotrauka != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42bdbe7bd26ba44cfcddcaa5e32ee91d808fba559230", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/profilepics/");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                                WriteLiteral(Model.Nuotrauka);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 44 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }else
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Neturite ikėlę nuotraukos.</p>\r\n");
#nullable restore
#line 48 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <div style=\" margin: 0 auto; margin-left:50%\">\r\n                <a class=\"btn btn-danger btn-lg\"");
            BeginWriteAttribute("href", " href=\"", 2424, "\"", 2460, 1);
#nullable restore
#line 54 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Home\UserDashboard.cshtml"
WriteAttributeValue("", 2431, Url.Action("Logout", "Home"), 2431, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Atsijungti</a>\r\n            </div>\r\n        </section>\r\n\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.Models.Klienta> Html { get; private set; }
    }
}
#pragma warning restore 1591
