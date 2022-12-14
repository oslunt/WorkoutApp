#pragma checksum "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4fe98c43888674469a98c16b6fc7b9f410bb60"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkoutApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/workouts")]
    public partial class Workouts : OwningComponentBase<IWorkoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.WorkoutApp.Pages.Workouts.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 4 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<WorkoutApp.Components.WorkoutFormComponent>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 5 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                                Modal = (WorkoutApp.Components.WorkoutFormComponent)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n");
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-bordered table-striped table-hover");
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.AddMarkupContent(14, "<thead>\r\n            <tr>\r\n                <td class=\"font-weight-bold\"><h4>Workout</h4></td>\r\n            </tr>\r\n        </thead>\r\n\r\n        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 18 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
             if (WorkoutData?.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                 foreach (Workout w in WorkoutData)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 24 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                                            GetExercisesUrl(w.WorkoutID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                                ");
                __builder2.AddContent(26, 
#nullable restore
#line 25 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                                 w.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 29 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                ");
            __builder.AddMarkupContent(32, "<tr>\r\n                    <td>No workouts</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-warning");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
                                              () => Modal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Add Workout");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts.razor"
       

    public IWorkoutRepository repo => Service;
    public IEnumerable<Workout> WorkoutData { get; set; }

    private WorkoutFormComponent Modal { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        WorkoutData = await repo.Workouts.ToListAsync();
    }

    public string GetExercisesUrl(long id) => $"/workouts/exercises/{id}";


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WorkoutApp.Pages.Workouts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
