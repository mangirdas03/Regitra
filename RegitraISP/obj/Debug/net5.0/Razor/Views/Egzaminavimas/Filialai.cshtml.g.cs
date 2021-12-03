#pragma checksum "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad91647ab36a97c94563af1e7bd1bdf55b1f4207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Filialai), @"mvc.1.0.view", @"/Views/Egzaminavimas/Filialai.cshtml")]
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
#line 1 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad91647ab36a97c94563af1e7bd1bdf55b1f4207", @"/Views/Egzaminavimas/Filialai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd31c404b08e362cfcef0622733b84fb04c880f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Filialai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.FilialaiMiestai>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
  
    ViewData["Title"] = "Filialai";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Regitros filialai</h2>
            <br />
            <p class=""page_infotext"">Šiame puslapyje yra pateikiama informacija apie Regitros filialus. Filialai yra suskirstyti pagal miestus, kuriuose juos galima rasti.</p>
            <br />
            <br />

");
#nullable restore
#line 17 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
             foreach (var miestas in Model.Miestai)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <p class=\"cityname\">");
#nullable restore
#line 20 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                               Write(Html.DisplayFor(modelItem => miestas.Pavadinimas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br/>\r\n");
#nullable restore
#line 21 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                foreach (var filialas in Model.Filialai)
                {
                    if (filialas.FkMiestaspavadinimas == miestas.Pavadinimas)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"fproperty\" style=\"font-weight:bold\">Adresas: ");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"fproperty\">Galima laikyti:</p>\r\n                        <ul class=\"fproperty_ul\">\r\n");
#nullable restore
#line 29 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                             if (filialas.PraktikosEgz != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Praktikos egzaminą: <b>Taip.</b></li>\r\n");
#nullable restore
#line 32 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Praktikos egzaminą: <b>Ne.</b></li>\r\n");
#nullable restore
#line 36 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                             if (filialas.TeorijosEgz != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Teorijos egzaminą: <b>Taip.</b></li>\r\n");
#nullable restore
#line 40 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"fproperty_li\">Teorijos egzaminą: <b>Ne.</b></li>\r\n");
#nullable restore
#line 44 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <br />\r\n");
#nullable restore
#line 47 "C:\Users\gladi\Desktop\redst3\Regitra\RegitraISP\Views\Egzaminavimas\Filialai.cshtml"
                    }
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </section>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.ViewModels.FilialaiMiestai> Html { get; private set; }
    }
}
#pragma warning restore 1591
