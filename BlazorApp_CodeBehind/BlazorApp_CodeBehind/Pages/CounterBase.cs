using Microsoft.AspNetCore.Components;
namespace BlazorApp_CodeBehind.Pages
{
    public class CounterBase : ComponentBase
    {

        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
