#pragma checksum "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13211be07ecdac4b31df1d2f0118caaccdda2f13"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.Students
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
#line 3 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/estudiantes")]
    public partial class Estudiantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""tittle""><div class=""tittle_content""><h1>Estudiantes</h1></div>

    <div class=""tittle_btn""><a href=""/estudiantes/add"" class=""btn btn-outline-success""><i class=""oi oi-plus""></i>
            &nbsp;
            Agregar
        </a></div></div>

");
            __builder.AddMarkupContent(1, "<p>Tabla de Estudiantes</p>");
#nullable restore
#line 25 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
 if (estudiantes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 28 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\r\n                <th>Nombre Completo</th>\r\n                <th>Correo</th>\r\n                <th>Inscripción</th>\r\n                <th>Opciones</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 42 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
             foreach (var estudiante in estudiantes)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 45 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                         estudiante.IdEstudiante

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 46 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                         estudiante.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 47 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                         estudiante.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 48 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                         estudiante.Inscripcions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "icon");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/estudiantes/update/" + (
#nullable restore
#line 51 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                                                          estudiante.IdEstudiante

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "oi oi-pencil");
            __builder.AddAttribute(26, "title", "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "icon");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/estudiantes/delete/" + (
#nullable restore
#line 54 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
                                                          estudiante.IdEstudiante

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "oi oi-trash");
            __builder.AddAttribute(33, "title", "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Students\Estudiantes.razor"
       
    private readonly string api = "api/CuentaEstudiante/TodosLosEstudiantes";
    private IList<Estudiante> estudiantes;



    protected override async Task OnInitializedAsync()
    {
        estudiantes = await http.GetFromJsonAsync<IList<Estudiante>>(api);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
