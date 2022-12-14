#pragma checksum "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0363a5db55268a92d1a1afd0a2325f85a146e9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/workouts/edit/{id:long}")]
    public partial class Edit : OwningComponentBase<IWorkoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.WorkoutApp.Pages.Edit.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 5 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<WorkoutApp.Components.ExerciseFormComponent>(4);
                __builder2.AddAttribute(5, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 6 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                             Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 6 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                 Modal = (WorkoutApp.Components.ExerciseFormComponent)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n");
            }
            );
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-bordered table-hover");
            __builder.AddAttribute(14, "ondragover", "event.preventDefault();");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "thead");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                <td class=\"col-1\"></td>\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "font-weight-bold h3");
            __builder.AddContent(26, 
#nullable restore
#line 16 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                           workout.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "float-right h6");
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                     changeDay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 19 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                 if (days?.Count() > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                     foreach (Day d in days)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                         if (d.DayID == day.DayID)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                                            ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", 
#nullable restore
#line 25 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                            d.DayID

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "selected", "selected");
            __builder.AddContent(39, 
#nullable restore
#line 25 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                                          d.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 26 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                                            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", 
#nullable restore
#line 29 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                            d.DayID

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, 
#nullable restore
#line 29 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                      d.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 30 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                                    ");
            __builder.OpenElement(47, "option");
            __builder.AddContent(48, "Loading");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 36 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, " \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                <td class=\"col-1\"></td>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.OpenElement(57, "tbody");
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 46 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
             if (Workout_ExerciseData?.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                 foreach (var we in Workout_ExerciseData)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                    ");
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "draggable", "true");
            __builder.AddAttribute(62, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                          () => Drop(we)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "ondrag", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                                                      () => StartDrag(we)

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 50 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                               we.ExerciseNum

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 51 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                             we.ExerciseNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n");
#nullable restore
#line 53 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                         if (we.Eccentric)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                            ");
            __builder.OpenElement(69, "td");
            __builder.AddMarkupContent(70, "\r\n                                Eccentric ");
            __builder.AddContent(71, 
#nullable restore
#line 56 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                           we.Exercise.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 58 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 61 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                 we.Exercise.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 62 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "td");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-danger");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                     (x => DeleteWorkoutExercise(we))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 66 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-warning");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                              () => Modal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, "Add Exercise");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(94);
            __builder.AddAttribute(95, "class", "btn btn-success");
            __builder.AddAttribute(96, "href", 
#nullable restore
#line 71 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                            GetExercisesUrl(Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                                           SaveWorkout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(99, "Save");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(101);
            __builder.AddAttribute(102, "class", "btn btn-primary float-right");
            __builder.AddAttribute(103, "href", 
#nullable restore
#line 72 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
                                                        GetExercisesUrl(Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(105, "Back");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n    <br><br>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Edit.razor"
       

    [Inject]
    public IWorkoutRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public List<Workout_Exercise> Workout_ExerciseData { get; set; }

    public int curIndex;

    private ExerciseFormComponent Modal { get; set; }

    public Workout workout { get; set; }
    public Day day { get; set; }
    public List<Day> days { get; set; }
    public Day newDay { get; set; }

    protected async override Task OnInitializedAsync()
    {
        workout = repo.Workouts.First(w => w.WorkoutID == Id);
        day = repo.Days.First(d => d.DayID == workout.DayID);
        await UpdateData();
    }

    public async Task UpdateData()
    {
        Workout_ExerciseData = await repo.Workout_Exercises
                    .Include(e => e.Exercise)
                    .Where(we => we.WorkoutID == Id)
                    .OrderBy(we => we.ExerciseNum)
                    .ToListAsync();
        days = await repo.Days.ToListAsync();
    }

    public void StartDrag(Workout_Exercise we)
    {
        curIndex = GetIndex(we);
    }

    public void ClickItem(Workout_Exercise we)
    {
        curIndex = GetIndex(we);
    }

    public int GetIndex(Workout_Exercise we)
    {
        return Workout_ExerciseData.First(w => w.WorkoutExerciseID == we.WorkoutExerciseID).ExerciseNum - 1;
    }

    public void Drop(Workout_Exercise we)
    {
        if(we != null)
        {
            var index = GetIndex(we);
            var current = Workout_ExerciseData[curIndex];

            Workout_ExerciseData.RemoveAt(curIndex);
            Workout_ExerciseData.Insert(index, current);

            for(int i = 0; i < Workout_ExerciseData.Count(); i++)
            {
                Workout_ExerciseData[i].ExerciseNum = i + 1;
            }

            curIndex = index;

            StateHasChanged();
        }
    }

    public string GetExercisesUrl(long id) => $"/workouts/exercises/{id}";

    public void SaveWorkout()
    {
        foreach(Workout_Exercise we in Workout_ExerciseData)
        {
            repo.SaveWorkoutExercises(we);
        }
        workout.DayID = day.DayID;
        workout.Day = day;
        repo.SaveWorkout(workout);
    }

    public void RefreshState()
    {
        workout.DayID = day.DayID;
        workout.Day = day;
        repo.SaveWorkout(workout);
        NavigationManager.NavigateTo($"workouts/edit/{Id}", true);
    }

    public void DeleteWorkoutExercise(Workout_Exercise we)
    {
        repo.DeleteWorkoutExercises(we);
        if(we.ExerciseNum < Workout_ExerciseData.Count())
        {
            for (int i = 0; i < Workout_ExerciseData.Count(); i++)
            {
                if (i + 1 == we.ExerciseNum)
                {
                    Workout_ExerciseData[i].ExerciseNum = i + 1;
                }
                else if(i + 1 > we.ExerciseNum)
                {
                    Workout_ExerciseData[i].ExerciseNum = i + 2;
                }
            }
        }
        RefreshState();
    }

    public void changeDay(ChangeEventArgs args)
    {
        int dayid = Convert.ToInt32(args.Value);
        day = repo.Days.First(d => d.DayID == dayid);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.WorkoutApp.Pages.Edit
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
