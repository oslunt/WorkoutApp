// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Workouts___Copy : OwningComponentBase<IWorkoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\owens\Desktop\Personal\WorkoutB\WorkoutApp\Pages\Workouts - Copy.razor"
       

    public IWorkoutRepository repo => Service;
    public IEnumerable<Workout> WorkoutData { get; set; }

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
#pragma warning restore 1591
