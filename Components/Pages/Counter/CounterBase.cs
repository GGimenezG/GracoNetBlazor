using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace AppBlazor.Components
{
    public class CounterBase : ComponentBase
    {
            public int currentCount = 5;

            public void IncrementCount()
            {
                currentCount++;
            }
    }
}