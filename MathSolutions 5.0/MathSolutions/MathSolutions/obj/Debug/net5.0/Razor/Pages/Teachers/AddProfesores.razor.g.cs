#pragma checksum "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9628d1a80359f63c6d38c90f38750508c358cb"
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
#line 3 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profesores/add")]
    public partial class AddProfesores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Agregar profesor</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                  profesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "class", "container-border");
                __builder2.AddAttribute(6, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 13 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                                              Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mb-2");
                __builder2.AddMarkupContent(9, "<label class=\"col-form-label\" for=\"name\">Nombre</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "id", "name");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                                                          profesor.NombreCompleto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profesor.NombreCompleto = __value, profesor.NombreCompleto))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => profesor.NombreCompleto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "mb-2");
                __builder2.AddMarkupContent(19, "<label class=\"col-form-label\" for=\"name\">Correo Electr??nico</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "id", "email");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                                                          profesor.Correo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profesor.Correo = __value, profesor.Correo))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => profesor.Correo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "mb-2");
                __builder2.AddMarkupContent(29, "<label class=\"col-form-label\" for=\"name\">Redes Sociales</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "redessociales");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                                                          profesor.RedesSociales

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profesor.RedesSociales = __value, profesor.RedesSociales))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => profesor.RedesSociales));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "mb-2");
                __builder2.AddMarkupContent(39, "<label class=\"col-form-label\" for=\"name\">Descripci??n</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "desc");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
                                                          profesor.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => profesor.Descripcion = __value, profesor.Descripcion))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => profesor.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-outline-primary\">Guardar</button>\r\n        ");
                __builder2.AddMarkupContent(48, "<a class=\"btn btn-outline-danger\" href=\"/profesores\">Cancelar</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\cmezq\Downloads\MathSolutions 5.0\MathSolutions\MathSolutions\Pages\Teachers\AddProfesores.razor"
      
    [Parameter]

    public bool isUpdate { get; set; } = false;

    public int id { get; set; }

    //bool loading = true;

    //IList<Profesor> profesors;

    Profesor profesor = new Profesor();

    //protected override async Task OnInitializedAsync()
    //{
    //    profesors = await http.GetFromJsonAsync<IList<Profesor>>("api/profesor");
    //    isUpdate = id != 0;
    //    if (isUpdate)
    //    {
    //        var response = await http.GetFromJsonAsync<Profesor>($"api/profesor/{id}");
    //        if (response != null)
    //        {
    //            profesor = response;

    //        }
    //    }
    //    loading = false;
    //}

    protected async Task Save()
    {
        HttpResponseMessage response;
        if (isUpdate)
        {
            response = await http.PutAsJsonAsync<Profesor>($"api/profesor/{id}", profesor!);
        }
        else
        {
            response = await http.PostAsJsonAsync<Profesor>("api/profesor", profesor!);
        }
        Profesor Saved = response.Content.ReadFromJsonAsync<Profesor>().Result;
        NavigationManager.NavigateTo("/profesores");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
