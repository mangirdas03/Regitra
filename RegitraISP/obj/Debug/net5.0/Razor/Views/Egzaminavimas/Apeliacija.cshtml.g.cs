#pragma checksum "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\Egzaminavimas\Apeliacija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995642304ffb08d542fe66dcac8cb0b63362af3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egzaminavimas_Apeliacija), @"mvc.1.0.view", @"/Views/Egzaminavimas/Apeliacija.cshtml")]
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
#line 1 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\_ViewImports.cshtml"
using RegitraISP.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\Egzaminavimas\Apeliacija.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995642304ffb08d542fe66dcac8cb0b63362af3c", @"/Views/Egzaminavimas/Apeliacija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2850022c157a4673b9966b72fab848d8fa9cb17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Egzaminavimas_Apeliacija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegitraISP.ViewModels.KlientasEgzaminas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Egzaminavimas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Apeliacija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\Egzaminavimas\Apeliacija.cshtml"
  
    ViewData["Title"] = "Apeliacija";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""section"" class=""bodysection"">
    <div class=""container_white"">
        <section class=""tm-margin-b-l"">
            <h2 class=""pagetitle"">Apeliacija</h2>
            <br />
            <br />
            <p class=""page_infotext"">Šiame puslapyje yra pateikiama informacija apie teorijos bei praktikos egzaminus. Jei norite laikyti egzaminą, išsirinkite sau tinkamą laiką ir užsiregistruokite.</p>
            <br />
            <br />

            <p style=""text-align: center; font-size: larger"">Apeliacija</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "995642304ffb08d542fe66dcac8cb0b63362af3c5683", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 966, "\"", 1036, 1);
#nullable restore
#line 22 "C:\Users\redas\Desktop\RegistraISP\RegitraISP\Views\Egzaminavimas\Apeliacija.cshtml"
WriteAttributeValue("", 974, HttpContextAccessor.HttpContext.Session.GetString("username"), 974, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <p style=\"font-size: larger\">Priežastis</p>\r\n                <input type=\"text\" name=\"priezastis\"");
                BeginWriteAttribute("value", " value=\"", 1155, "\"", 1163, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <br />
                <br />
                <p style=""font-size: larger"">Tikslus situacijos apibūdinimas</p>
                <textarea id=""text"" name=""tekstas"" rows=""10"" cols=""50""></textarea>
                <br />
                <br />
                <button id=""btn_snd"" style=""margin-left:0px;"" class=""btn btn-danger"" type=""submit"" name=""send"" value=""1"">Siųsti apeliaciją</button>
            ");
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
