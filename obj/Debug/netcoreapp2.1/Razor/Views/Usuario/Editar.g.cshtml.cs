#pragma checksum "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4670d1904ee7701eb80c49209c5d46f59854ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Editar), @"mvc.1.0.view", @"/Views/Usuario/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Editar.cshtml", typeof(AspNetCore.Views_Usuario_Editar))]
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
#line 1 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
using Senai.Financas.Mvc.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4670d1904ee7701eb80c49209c5d46f59854ce", @"/Views/Usuario/Editar.cshtml")]
    public class Views_Usuario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 39, true);
            WriteLiteral("\r\n<html>\r\n    <h1>Editar</h1>\r\n\r\n    \r\n");
            EndContext();
#line 7 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
      
        UsuarioModel usuario = ViewBag.Usuario;
    

#line default
#line hidden
            BeginContext(142, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(149, 16, false);
#line 11 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(165, 83, true);
            WriteLiteral("\r\n\r\n    <form action=\"/Usuario/Editar\" method=\"POST\">\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 248, "\"", 267, 1);
#line 14 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 256, usuario.ID, 256, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(268, 78, true);
            WriteLiteral(" name=\"id\">\r\n        <label>\r\n            Nome\r\n            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 346, "\"", 367, 1);
#line 17 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 354, usuario.Nome, 354, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(368, 101, true);
            WriteLiteral(" name=\"nome\">\r\n        </label>\r\n        <label>\r\n            E-mail\r\n            <input type=\"email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 469, "\"", 491, 1);
#line 21 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 477, usuario.Email, 477, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(492, 104, true);
            WriteLiteral(" name=\"email\">\r\n        </label>\r\n        <label>\r\n            Senha\r\n            <input type=\"password\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 596, "\"", 618, 1);
#line 25 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 604, usuario.Senha, 604, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(619, 113, true);
            WriteLiteral(" name=\"senha\">\r\n        </label>\r\n        <label>\r\n            Data de nascimento\r\n            <input type=\"date\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 732, "\"", 786, 1);
#line 29 "C:\Users\44846245837\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 740, usuario.DataNascimento.ToString("yyyy-MM-dd"), 740, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(787, 110, true);
            WriteLiteral(" name=\"dataNascimento\">\r\n        </label>\r\n        <button type=\"submit\">Salvar</button>\r\n    </form>\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591