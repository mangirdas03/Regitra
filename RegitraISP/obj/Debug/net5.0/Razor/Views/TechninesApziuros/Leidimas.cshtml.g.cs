#pragma checksum "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb6ac52f13849bff46124d7e65c0d8d7f9f0ffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechninesApziuros_Leidimas), @"mvc.1.0.view", @"/Views/TechninesApziuros/Leidimas.cshtml")]
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
#line 1 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb6ac52f13849bff46124d7e65c0d8d7f9f0ffd", @"/Views/TechninesApziuros/Leidimas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_TechninesApziuros_Leidimas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.AutomobilisTechnine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TechninesApziuros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Leidimas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
  
    ViewData["Title"] = "Leidimas";
    int c = 0;
    int d = 0;
    int b = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//use.fontawesome.com/releases/v5.0.7/css/all.css"">
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Vienos dienos leidimas</h2>
            <br />
            <p class=""page_infotext"">Šiame puslapyje galite įsigyti vienos dienos leidimą</p>
            <br />
            <br />
");
#nullable restore
#line 23 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
             if (Model.Automobiliai.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"page_infotext\">Jūsų automobiliai</p>\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceb6ac52f13849bff46124d7e65c0d8d7f9f0ffd6950", async() => {
                WriteLiteral(@"
                    <table class=""table table-hover table-dark"" style=""background-color: #4ca1af; box-shadow: 2px 4px 20px rgba(0, 0, 0, 0.8);"">
                        <tr>
                            <th>Markė</th>
                            <th>Modelis</th>
                            <th>Valstybiniai numeriai</th>
                            <th>Mygtukas</th>
                            <th>Galiojimo data</th>
                        </tr>
");
#nullable restore
#line 36 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                         foreach (Automobili auto in Model.Automobiliai)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 39 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                               Write(auto.Marke);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                               Write(auto.Modelis);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                               Write(auto.ValstybiniaiNumeriai);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                               Write(auto.Vin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                                 if (DateTime.Today > Model.Apziuros.Where(a => a.FkAutomobilisvin.Equals(auto.Vin)).LastOrDefault().GaliojimoData)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ceb6ac52f13849bff46124d7e65c0d8d7f9f0ffd10124", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Vin);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
AddHtmlAttributeValue("", 2050, d, 2050, 2, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2052, "++", 2052, 2, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                                                                        WriteLiteral(auto.Vin);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\"");
                BeginWriteAttribute("id", " id=\"", 2130, "\"", 2139, 2);
#nullable restore
#line 47 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
WriteAttributeValue("", 2135, c, 2135, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2137, "++", 2137, 2, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-dark\" value=\"Gauti leidimą\" />\r\n                            </td>\r\n");
#nullable restore
#line 49 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                                 if (DateTime.Today <= Model.Apziuros.Where(a => a.FkAutomobilisvin.Equals(auto.Vin)).LastOrDefault().GaliojimoData)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>Galiojimas nesibaigė</td>\r\n");
#nullable restore
#line 53 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 55 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
             if (Model.Automobiliai.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"page_infotext\">Jūs neturite priregistruoto automobilio</p>\r\n");
#nullable restore
#line 62 "E:\Mokslai\III kursas\OneDrive - Kaunas University of Technology\Informacinių sistemų pagrindai\redst3\Regitra\RegitraISP\Views\TechninesApziuros\Leidimas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</section>\r\n\r\n<script>\r\n    function pranesti(id) {\r\n        var value = document.getElementById(id);\r\n        alert(value);\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.ViewModels.AutomobilisTechnine> Html { get; private set; }
    }
}
#pragma warning restore 1591