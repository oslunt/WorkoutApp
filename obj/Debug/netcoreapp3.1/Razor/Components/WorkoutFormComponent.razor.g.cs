#pragma checksum "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e239a9857b426f326168bb397b1026384c62239"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkoutApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using WorkoutApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using WorkoutApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using WorkoutApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using WorkoutApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using WorkoutApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class WorkoutFormComponent : OwningComponentBase<IWorkoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 4 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 4 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                                           ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                         w

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                           AddWorkout

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "modal-content");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "modal-header");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<h5 class=\"modal-title\">Add a Workout</h5>\r\n                    ");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "type", "button");
                __builder2.AddAttribute(24, "class", "close");
                __builder2.AddAttribute(25, "data-dismiss", "modal");
                __builder2.AddAttribute(26, "aria-label", "Close");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                                                                          () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.AddMarkupContent(29, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "modal-body");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.AddMarkupContent(40, "<label>Workout</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                 w.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => w.Name = __value, w.Name))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => w.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    \r\n                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.AddMarkupContent(51, "<label>Day</label>\r\n                        ");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                                UpdateDay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "\r\n");
#nullable restore
#line 24 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                             foreach(var day in Days)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(56, "                            ");
                __builder2.OpenElement(57, "option");
                __builder2.AddAttribute(58, "value", 
#nullable restore
#line 26 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                            day.DayID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(59, 
#nullable restore
#line 26 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                        day.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 27 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "modal-footer");
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "type", "submit");
                __builder2.AddAttribute(70, "class", "btn btn-primary");
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                                            () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(72, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "type", "button");
                __builder2.AddAttribute(76, "class", "btn btn-secondary");
                __builder2.AddAttribute(77, "data-dismiss", "modal");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
                                                                                                   () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(79, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 44 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Components\WorkoutFormComponent.razor"
       

    public Workout w { get; set; } = new Workout();
    public string ModalDisplay = "none;";
    public string AddWorkoutDisplay = "none";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    public bool addWorkout = false;

    public IWorkoutRepository repo => Service;

    public IEnumerable<Day> Days { get; set; }

    protected override void OnInitialized()
    {
        Days = repo.Days.ToList();
    }

    public void Open()
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        StateHasChanged();
    }

    public void UpdateDay(ChangeEventArgs args)
    {
        int dayid = Convert.ToInt32(args.Value);
        w.Day = repo.Days.First(d => d.DayID == dayid);
        w.DayID = w.Day.DayID;
        AddWorkoutDisplay = "none";

    }

    public void AddWorkout()
    {
        repo.AddWorkout(w);
        int id = repo.Workouts.Max(w => w.WorkoutID);
        NavigationManager.NavigateTo($"/workouts/edit/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
