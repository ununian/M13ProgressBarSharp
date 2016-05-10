using System;
using ObjCRuntime;

[assembly: LinkWith("libM13ProgressBar.a",
    LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7, 
    SmartLink = false, 
    ForceLoad = true,
    Frameworks = "CoreImage")]
