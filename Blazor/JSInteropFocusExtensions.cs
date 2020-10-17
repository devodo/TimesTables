using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor
{
    public static class JSInteropFocusExtensions
    {
        public static ValueTask FocusAsync(this IJSRuntime jsRuntime, string elementId)
        {
            return jsRuntime.InvokeVoidAsync("BlazorFocusElement", elementId);
        }
    }
}