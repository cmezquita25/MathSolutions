#pragma checksum "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83733e0eab6e3651d8efd3cb8cc2e9208a8c8556"
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
#line 50 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cursos/add")]
    public partial class AddCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Agregar curso</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                  curso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "class", "container-border");
                __builder2.AddAttribute(6, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                              Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mb-2");
                __builder2.AddMarkupContent(9, "<label class=\"col-form-label\" for=\"name\">Titulo</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "id", "name");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.Titulo = __value, curso.Titulo))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "mb-2");
                __builder2.AddMarkupContent(19, "<label class=\"col-form-label\" for=\"name\">Fecha de Inicio</label>\r\n            ");
                __Blazor.MathSolutions.Pages.courses.AddCursos.TypeInference.CreateInputDate_0(__builder2, 20, 21, "form-control", 22, "fechainicio", 23, 
#nullable restore
#line 18 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.FechaInicio

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.FechaInicio = __value, curso.FechaInicio)), 25, () => curso.FechaInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "mb-2");
                __builder2.AddMarkupContent(29, "<label class=\"col-form-label\" for=\"name\">Fecha de Cierre</label>\r\n            ");
                __Blazor.MathSolutions.Pages.courses.AddCursos.TypeInference.CreateInputDate_1(__builder2, 30, 31, "form-control", 32, "fechacierre", 33, 
#nullable restore
#line 23 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.FechaCierre

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.FechaCierre = __value, curso.FechaCierre)), 35, () => curso.FechaCierre);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "mb-2");
                __builder2.AddMarkupContent(39, "<label class=\"col-form-label\" for=\"name\">Link de laReunion</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "link");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.LinkReunion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.LinkReunion = __value, curso.LinkReunion))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.LinkReunion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "mb-2");
                __builder2.AddMarkupContent(49, "<label class=\"col-form-label\" for=\"name\">Material</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "id", "material");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.Material

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.Material = __value, curso.Material))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.Material));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "mb-2");
                __builder2.AddMarkupContent(59, "<label class=\"col-form-label\" for=\"name\">Descripción</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "id", "desc");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                          curso.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.Descripcion = __value, curso.Descripcion))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "mb-2");
                __builder2.AddMarkupContent(69, "<label class=\"col-form-label\" for=\"name\">ID del Profesor</label>\r\n            ");
                __Blazor.MathSolutions.Pages.courses.AddCursos.TypeInference.CreateInputNumber_2(__builder2, 70, 71, "form-control", 72, "idprof", 73, 
#nullable restore
#line 43 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
                                                            curso.IdProfesor

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.IdProfesor = __value, curso.IdProfesor)), 75, () => curso.IdProfesor);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.AddMarkupContent(77, "<button type=\"submit\" class=\"btn btn-outline-primary\">Guardar</button>\r\n        ");
                __builder2.AddMarkupContent(78, "<a class=\"btn btn-outline-danger\" href=\"/cursos\">Cancelar</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\courses\AddCursos.razor"
      
    [Parameter]

    public bool isUpdate { get; set; } = false;

    public int id { get; set; }

    //bool loading = true;

    //IList<Curso> cursos;

    Curso curso = new Curso();

    //protected override async Task OnInitializedAsync()
    //{
    //    cursos = await http.GetFromJsonAsync<IList<Curso>>("api/curso");
    //    isUpdate = id != 0;
    //    if (isUpdate)
    //    {
    //        var response = await http.GetFromJsonAsync<Curso>($"api/curso/{id}");
    //        if (response != null)
    //        {
    //            curso = response;

    //        }
    //    }
    //    loading = false;
    //}

    protected async Task Save()
    {
        HttpResponseMessage response;
        if (isUpdate)
        {
            response = await http.PutAsJsonAsync<Curso>($"api/curso/{id}", curso!);
        }
        else
        {
            response = await http.PostAsJsonAsync<Curso>("api/curso", curso!);
        }
        Curso Saved = response.Content.ReadFromJsonAsync<Curso>().Result;
        NavigationManager.NavigateTo("/cursos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.MathSolutions.Pages.courses.AddCursos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591