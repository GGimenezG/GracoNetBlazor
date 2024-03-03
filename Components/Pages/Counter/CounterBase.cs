using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace AppBlazor.Components
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;

        [Parameter]
        public Action<int> OnPepito { get; set; }

        [Parameter]
        public EventCallback<int> OnMultipleOfThree { get; set; }

        public async Task IncrementCount()
        {
            currentCount++;
            if (currentCount % 2 == 0)
                OnPepito?.Invoke(currentCount);

            if (currentCount % 3 == 0)
                await OnMultipleOfThree.InvokeAsync(currentCount);
        }
    }
}