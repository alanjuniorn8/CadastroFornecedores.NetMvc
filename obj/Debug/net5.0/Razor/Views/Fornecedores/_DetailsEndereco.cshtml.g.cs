#pragma checksum "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa718b0e23a2ca1eb1e05048716b3b6d80b06220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__DetailsEndereco), @"mvc.1.0.view", @"/Views/Fornecedores/_DetailsEndereco.cshtml")]
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
#line 1 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/_ViewImports.cshtml"
using CadastroFornecedores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/_ViewImports.cshtml"
using CadastroFornecedores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa718b0e23a2ca1eb1e05048716b3b6d80b06220", @"/Views/Fornecedores/_DetailsEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b290bacdebdc57c474bb38bf46303eb1aea48493", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__DetailsEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroFornecedores.ViewModels.FornecedorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-modal", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div style=\"paddding-top: 20px\">\n    <div>\n        <hr />\n        <h4>Endereço</h4>\n    </div>\n\n");
#nullable restore
#line 9 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
     if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-hover\">\n            <thead class=\"thead-dark\">\n                <tr>\n                    <th>\n                        ");
#nullable restore
#line 14 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 17 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 20 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 23 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 26 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 29 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 32 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n                <tr>\n                    <td>\n                        ");
#nullable restore
#line 40 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 43 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 46 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 49 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 52 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 55 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 58 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa718b0e23a2ca1eb1e05048716b3b6d80b062209834", async() => {
                WriteLiteral("\n                            <span title=\"Editar\" class=\"fa fa-pencil-alt\"></span>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                </tr>\n            </tbody>\n        </table>\n");
#nullable restore
#line 68 "/home/alan/VScode-workspace/AppMvc/CadastroFornecedores/Views/Fornecedores/_DetailsEndereco.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroFornecedores.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
