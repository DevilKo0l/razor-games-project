#pragma checksum "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Rabbits_and_carrots.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf8614ef4382c01807951d2481a4f216895c844"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Rabbits_and_carrots.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rabbits_and_carrots")]
    public partial class Rabbits_and_carrots : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Rabbits_and_carrots.razor"
       
    private int currentCount = 0;
    private Data.Environment e = new Data.Environment(30, 30);
    private Data.BioUnit u;
    private void IncrementCount()
    {
        currentCount++;
        e.nextRabbitCarrotStep();             
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
