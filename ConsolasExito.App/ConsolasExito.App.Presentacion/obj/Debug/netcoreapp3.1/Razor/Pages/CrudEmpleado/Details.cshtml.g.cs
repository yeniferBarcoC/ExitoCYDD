#pragma checksum "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df29b526aa9a4da20d7f446b4e3e6b43cf1b9c94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConsolasExito.App.Presentacion.Pages.CrudEmpleado.Pages_CrudEmpleado_Details), @"mvc.1.0.razor-page", @"/Pages/CrudEmpleado/Details.cshtml")]
namespace ConsolasExito.App.Presentacion.Pages.CrudEmpleado
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
#line 1 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\_ViewImports.cshtml"
using ConsolasExito.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df29b526aa9a4da20d7f446b4e3e6b43cf1b9c94", @"/Pages/CrudEmpleado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17803325490307688ad0bab33636c6af0d96384c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudEmpleado_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
  
    ViewData["Title"] = "Detalles del empleado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Sucursal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Sucursal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.Contrasenna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.Contrasenna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empleado.TipoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empleado.TipoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df29b526aa9a4da20d7f446b4e3e6b43cf1b9c949965", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\DANIELA\Desktop\ExitoCYDD\ConsolasExito.App\ConsolasExito.App.Presentacion\Pages\CrudEmpleado\Details.cshtml"
                           WriteLiteral(Model.Empleado.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df29b526aa9a4da20d7f446b4e3e6b43cf1b9c9412154", async() => {
                WriteLiteral("Volver a la lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsolasExito.App.Presentacion.Pages.CrudEmpleado.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExito.App.Presentacion.Pages.CrudEmpleado.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConsolasExito.App.Presentacion.Pages.CrudEmpleado.DetailsModel>)PageContext?.ViewData;
        public ConsolasExito.App.Presentacion.Pages.CrudEmpleado.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
