#pragma checksum "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cdf47df283168e43da77cb11498ec7f9f288e81"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/workouts/exercises/{id:long}")]
    public partial class Exercises : OwningComponentBase<IWorkoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "thead");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                <td class=\"col-1\"></td>\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "p");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "font-weight-bold h3");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                                                          workout.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(15, " ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "float-right h6");
            __builder.AddContent(18, 
#nullable restore
#line 9 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                                                                                                            day.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(19, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 15 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
             foreach (var we in Workout_ExerciseData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 18 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                         we.ExerciseNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
#nullable restore
#line 20 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                     if (we.Eccentric)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\r\n                            Eccentric ");
            __builder.AddContent(34, 
#nullable restore
#line 23 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                                       we.Exercise.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 25 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 28 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                             we.Exercise.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 29 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 32 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            __builder.AddAttribute(47, "class", "btn btn-success");
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 35 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                                            GetStartUrl(Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(50, "Start");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "btn btn-warning float-right");
            __builder.AddAttribute(54, "href", 
#nullable restore
#line 36 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
                                                        GetEditUrl(Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(56, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n    <br><br>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Exercises.razor"
       

    [Inject]
    public IWorkoutRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public IEnumerable<Workout_Exercise> Workout_ExerciseData { get; set; }
    public Workout workout { get; set; }
    public Day day { get; set; }

    protected override void OnParametersSet()
    {
        Workout_ExerciseData = repo.Workout_Exercises
            .Include(e => e.Exercise)
            .Where(we => we.WorkoutID == Id)
            .OrderBy(we => we.ExerciseNum)
            .ToList();
        workout = repo.Workouts.First(w => w.WorkoutID == Id);
        day = repo.Days.First(d => d.DayID == workout.DayID);
    }

    public string GetEditUrl(long id) => $"/workouts/edit/{id}";
    public string GetStartUrl(long id) => $"/workouts/{id}/track";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
