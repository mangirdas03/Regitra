#pragma checksum "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1190542d3c43dab4ffe9a167d84403e59cae634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechninesApziuros_Index), @"mvc.1.0.view", @"/Views/TechninesApziuros/Index.cshtml")]
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
#line 1 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1190542d3c43dab4ffe9a167d84403e59cae634", @"/Views/TechninesApziuros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_TechninesApziuros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
  
    ViewData["Title"] = "Techninės apžiūros";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""tm-main-content"">
        <section class=""tm-margin-b-l"">
            <header>
                <h2 class=""pagetitle2"">Techninės apžiūros</h2>
            </header>
            <br />
            <p class=""page_infotext"">Šioje paslaugų skiltyje rasite visą reikiamą informaciją bei teikiamas paslaugas susijusias su automobilių technine apžiūra.</p>

            <div class=""tm-gallery"">
                <div class=""row"">
                    <figure class=""col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item"">
                        <a style=""text-decoration:none""");
            BeginWriteAttribute("href", " href=\"", 866, "\"", 920, 1);
#nullable restore
#line 21 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
WriteAttributeValue("", 873, Url.Action("Skaiciuokle", "TechninesApziuros"), 873, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""tm-gallery-item-overlay"">
                                <img src=""img/3.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                            </div>
                            <p class=""tm-figcaption"">Taršos mokesčio skaičiuoklė</p>
                        </a>
                    </figure>
");
#nullable restore
#line 28 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
                     if (@HttpContextAccessor.HttpContext.Session.GetString("username") != null && @HttpContextAccessor.HttpContext.Session.GetInt32("isEmployee") == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <figure class=\"col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item\">\r\n                            <a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 1617, "\"", 1672, 1);
#nullable restore
#line 31 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
WriteAttributeValue("", 1624, Url.Action("Deklaravimas", "TechninesApziuros"), 1624, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/4.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>
                                <p class=""tm-figcaption"">Duomenų deklaravimas</p>
                            </a>
                        </figure>
");
#nullable restore
#line 38 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
                     if (@HttpContextAccessor.HttpContext.Session.GetString("username") != null && @HttpContextAccessor.HttpContext.Session.GetInt32("isEmployee") == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <figure class=\"col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item\">\r\n                            <a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 2411, "\"", 2462, 1);
#nullable restore
#line 43 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
WriteAttributeValue("", 2418, Url.Action("Istorija", "TechninesApziuros"), 2418, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/2.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>

                                <p class=""tm-figcaption"">Apžiūros istorija</p>
                            </a>
                        </figure>
                        <figure class=""col-lg-3 col-md-3 col-sm-6 col-12 tm-gallery-item"">
                            <a style=""text-decoration:none""");
            BeginWriteAttribute("href", " href=\"", 2982, "\"", 3033, 1);
#nullable restore
#line 52 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
WriteAttributeValue("", 2989, Url.Action("Leidimas", "TechninesApziuros"), 2989, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/6.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>
                                <p class=""tm-figcaption"">Vienos dienos leidimas</p>
                            </a>
                        </figure>
                        <figure class=""col-lg-3 col-md-4 col-sm-6 col-12 tm-gallery-item"">
                            <a style=""text-decoration:none"" href=""#"">
                                <div class=""tm-gallery-item-overlay"">
                                    <img src=""img/5.jpg"" alt=""Image"" class=""img-fluid tm-img-center"">
                                </div>
                                <p class=""tm-figcaption"">Registracija apžiūrai</p>
                            </a>
                        </figure>
");
#nullable restore
#line 67 "C:\Users\gladi\Desktop\Regitra\RegitraISP\Views\TechninesApziuros\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
