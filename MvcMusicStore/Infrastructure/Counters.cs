using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastructure
{
    [PerformanceCounterCategory("MvcMusicStore", System.Diagnostics.PerformanceCounterCategoryType.MultiInstance, "MvcMusicStore")]
    public enum Counters
    {
        [PerformanceCounter("Successful login count", "Successful login", PerformanceCounterType.NumberOfItems32)]
        SuccessfulLogin,
        [PerformanceCounter("Unsuccessful login count", "Unsuccessful login", PerformanceCounterType.NumberOfItems32)]
        UnsuccessfulLogin,
        [PerformanceCounter("User registration count", "User registration", PerformanceCounterType.NumberOfItems32)]
        UserRegistration
    }
}