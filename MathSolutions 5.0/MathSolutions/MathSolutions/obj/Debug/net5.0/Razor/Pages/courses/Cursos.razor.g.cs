#pragma checksum "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945223ceaf12ba0ce39b6d7d885131c1fc6d293f"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.courses
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
#line 3 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cursos")]
    public partial class Cursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"tittle\"><div class=\"tittle_content\"><h1>Cursos</h1></div>\r\n\r\n    <div class=\"tittle_btn\"><a href=\"/cursos/add\" class=\"btn btn-outline-success\"><i class=\"oi oi-plus\"></i>\r\n            &nbsp;\r\n            Agregar\r\n        </a></div></div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Tabla de los Cursos</p>");
#nullable restore
#line 25 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
 if (cursos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 28 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, @"<thead><tr><th>ID</th>
                <th>Nombre</th>
                <th>Fecha de Inicio</th>
                <th>Fecha de Cierre</th>
                <th>Link de la Reunión</th>
                <th>Material</th>
                <th>Descripción</th>
                <th>Estatus</th>
                <th>Profesor</th>
                <th>Opciones</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 47 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
             foreach (var curso in cursos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 50 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.IdCurso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 51 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 52 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.FechaInicio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 53 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.FechaCierre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 54 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.LinkReunion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 55 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.Material

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 56 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 57 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.Estatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 58 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                         curso.IdProfesor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "icon");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "/cursos/update/" + (
#nullable restore
#line 61 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                                                     curso.IdCurso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "oi oi-pencil");
            __builder.AddAttribute(41, "title", "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "icon");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "/cursos/delete/" + (
#nullable restore
#line 64 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
                                                     curso.IdCurso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "oi oi-trash");
            __builder.AddAttribute(48, "title", "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\Cursos.razor"
       
    private readonly string api = "api/Profesor/TodosLosCursos";
    private IList<Curso> cursos;



    protected override async Task OnInitializedAsync()
    {
        cursos = await http.GetFromJsonAsync<IList<Curso>>(api);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
