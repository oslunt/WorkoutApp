// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
