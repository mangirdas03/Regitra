#pragma checksum "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f635cbe740663a354128770e7dff5595e4b4c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Registracija), @"mvc.1.0.view", @"/Views/Egzaminavimas/Registracija.cshtml")]
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
#line 3 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f635cbe740663a354128770e7dff5595e4b4c0c", @"/Views/Egzaminavimas/Registracija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Registracija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.KlientasEgzaminas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Egzaminavimas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registracija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
  
    ViewData["Title"] = "Registracija";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Registracija į egzaminus</h2>
            <br />
            <br />
            <p class=""page_infotext"">Šiame puslapyje yra pateikiama informacija apie teorijos bei praktikos egzaminus. Jei norite laikyti egzaminą, išsirinkite sau tinkamą laiką ir užsiregistruokite.</p>
            <br />
            <br />

            <p style=""text-align: center; font-size: larger"">Teorijos egzaminai</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f635cbe740663a354128770e7dff5595e4b4c0c5681", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 992, "\"", 1062, 1);
#nullable restore
#line 22 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 1000, HttpContextAccessor.HttpContext.Session.GetString("username"), 1000, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <table class=""table table-hover table-dark"" style=""background-color: #4ca1af; box-shadow: 2px 4px 20px rgba(0, 0, 0, 0.8); "">
                    <colgroup>
                        <col span=""1"" style=""width: 15%;"">
                        <col span=""1"" style=""width: 15%;"">
                        <col span=""1"" style=""width: 20%;"">
                        <col span=""1"" style=""width: 10%;"">
                        <col span=""1"" style=""width: 40%;"">
                    </colgroup>
                    <tr>
                        <th>Data</th>
                        <th>Miestas</th>
                        <th>Gatvė</th>
                        <th>Nr.</th>
                        <th>Registracija</th>
                    </tr>
");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                     foreach (var egzaminas in Model.Egzaminai)
                    {
                        if (egzaminas.EgzaminoTipas == 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                               Write(Html.FixDateFormat(egzaminas.Data));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 44 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                 foreach (var filialas in Model.Filialai)
                                {
                                    if (filialas.IdFilialas == egzaminas.FkFilialasidFilialas)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <th>");
#nullable restore
#line 48 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.FkMiestaspavadinimas));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 49 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 51 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                         if (Model.Klientas.TeorijosEgzIslaikytas == false)
                                        {
                                            if (!@Html.FixDateFormat(Model.Klientas.TeorijosEgzData).Equals(@Html.FixDateFormat(egzaminas.Data)))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th><button id=\"btn_reg\" style=\"margin-left:0px;\" class=\"btn btn-dark\" type=\"submit\" name=\"egz\"");
                BeginWriteAttribute("value", " value=\"", 3145, "\"", 3205, 1);
#nullable restore
#line 55 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 3153, Html.DisplayFor(modelItem => egzaminas.IdEgzaminas), 3153, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Registruotis</button></th>\r\n");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th><button id=\"btn_reg\" style=\"margin-left:0px;\" class=\"btn btn-danger\" type=\"submit\" name=\"egz\" value=\"0\">Atšaukti registraciją</button></th>\r\n");
#nullable restore
#line 60 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                            }
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <th><p>Teorijos egzaminą esate išlaikę</p></th>\r\n");
#nullable restore
#line 65 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                         
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </table>

                <br />
                <br />
                <p style=""text-align: center; font-size: larger"">Praktikos egzaminai</p>
                <table class=""table table-hover table-dark"" style=""background-color: #4ca1af; box-shadow: 2px 4px 20px rgba(0, 0, 0, 0.8); "">
                    <colgroup>
                        <col span=""1"" style=""width: 15%;"">
                        <col span=""1"" style=""width: 15%;"">
                        <col span=""1"" style=""width: 20%;"">
                        <col span=""1"" style=""width: 10%;"">
                        <col span=""1"" style=""width: 40%;"">
                    </colgroup>
                    <tr>
                        <th>Data</th>
                        <th>Miestas</th>
                        <th>Gatvė</th>
                        <th>Nr.</th>
                        <th>Registracija</th>
                    </tr>
");
#nullable restore
#line 93 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                     foreach (var egzaminas in Model.Egzaminai)
                    {
                        if (egzaminas.EgzaminoTipas == 2)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 98 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                               Write(Html.FixDateFormat(egzaminas.Data));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 99 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                 foreach (var filialas in Model.Filialai)
                                {
                                    if (filialas.IdFilialas == egzaminas.FkFilialasidFilialas)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <th>");
#nullable restore
#line 103 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.FkMiestaspavadinimas));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 104 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.Gatve));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 105 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                       Write(Html.DisplayFor(modelItem => filialas.GatvesNr));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 107 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                         if (Model.Klientas.PraktikosEgzIslaikytas == false)
                                        {
                                            if (!@Html.FixDateFormat(Model.Klientas.PraktikosEgzData).Equals(@Html.FixDateFormat(egzaminas.Data)))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th><button id=\"btn_reg\" style=\"margin-left:0px;\" class=\"btn btn-dark\" type=\"submit\" name=\"egz\"");
                BeginWriteAttribute("value", " value=\"", 6557, "\"", 6617, 1);
#nullable restore
#line 111 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
WriteAttributeValue("", 6565, Html.DisplayFor(modelItem => egzaminas.IdEgzaminas), 6565, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Registruotis</button></th>\r\n");
#nullable restore
#line 112 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th><button id=\"btn_reg\" style=\"margin-left:0px;\" class=\"btn btn-danger\" type=\"submit\" name=\"egz\" value=\"-1\">Atšaukti registraciją</button></th>\r\n");
#nullable restore
#line 116 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                            }
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <th><p>Praktikos egzaminą esate išlaikę</p></th>\r\n");
#nullable restore
#line 121 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                                         
                                        break;
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 126 "C:\Users\HP\Desktop\Regitra\RegitraISP\Views\Egzaminavimas\Registracija.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </table>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </section>
    </div>
</section>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script src=""sweetalert2.all.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#mf"").submit(function () {
            Swal.fire({
                icon: 'success',
                title: 'Operacija sėkminga!',
                showConfirmButton: false,
                timer: 1600
            })
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegitraISP.ViewModels.KlientasEgzaminas> Html { get; private set; }
    }
}
#pragma warning restore 1591
