#pragma checksum "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57190d227087663c57720548b9c0fcb825310728"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "c:\Users\DevilWalker\Desktop\My Projects\WSB projects\Advanced Programming\blazorserver01\Pages\Counter.razor"
           
    private bool isCollapsed = true; 
    private int cyclesPerTime = 0;
    private string patternName = "";
    public int row =0;
    public int col =0;
    public string getTextArea{get;set;} = string.Empty;
    private int[] positionInput()
    {
        
        string[] values = getTextArea.Split(new[] {',','\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[6];
        int i = 0;       
        foreach(var value in values)
        {
            int number;
            bool success = int.TryParse(value,out number);
            if(success)
            {
                nums[i]=number;
                i++;                
            }
        }
        
        return nums; 
    }

    private int currentCount = 0;
    private string theRadio="";
    private Data.Environment e = new Data.Environment(30,30);  
     
    private void AddCell()
    {
        int[] position = positionInput();
        for(int i = 0; i<6 ; i++)
        {
            if(i%2==0)
            {
                e.insert(position[i],position[i+1], new Data.BioUnit(position[i],position[i+1], e));
            }
        }
    } 
    
    private void AddPatern()
    {
        e.put_pattern(row,col,patternName);
    }
   
    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep(); 
    }
    
    private void ClickRadio(ChangeEventArgs args)
    {
        theRadio = args.Value.ToString();
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
