#pragma checksum "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc09b728870e7ed4d18f32faa229bbdb972f679"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.Teachers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using MathSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\_Imports.razor"
using MathSolutions.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profesores")]
    public partial class Profesores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""tittle""><div class=""tittle_content""><h1>Profesores</h1></div>

    <div class=""tittle_btn""><a href=""/profesores/add"" class=""btn btn-outline-success""><i class=""oi oi-plus""></i>
            &nbsp;
            Agregar
        </a></div></div>

");
            __builder.AddMarkupContent(1, "<p>Tabla de Profesores</p>");
#nullable restore
#line 26 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
 if (profesores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\r\n                <th>Nombre</th>\r\n                <th>Correo</th>\r\n                <th>Redes Sociales</th>\r\n                <th>Descripci??n</th>\r\n                <th>Opciones</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 44 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
             foreach (var profesor in profesores)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 47 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                         profesor.IdProfesor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 48 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                         profesor.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 49 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                         profesor.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 50 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                         profesor.RedesSociales

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 51 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                         profesor.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "icon");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/profesores/update/" + (
#nullable restore
#line 54 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                                                         profesor.IdProfesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "oi oi-pencil");
            __builder.AddAttribute(29, "title", "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "icon");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "/profesores/delete/" + (
#nullable restore
#line 57 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
                                                         profesor.IdProfesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "oi oi-trash");
            __builder.AddAttribute(36, "title", "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\Profesores.razor"
       
    private readonly string api = "api/CuentaProfesor/TodosLosProfesores";
    private IList<Profesor> profesores;



    protected override async Task OnInitializedAsync()
    {
        profesores = await http.GetFromJsonAsync<IList<Profesor>>(api);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
