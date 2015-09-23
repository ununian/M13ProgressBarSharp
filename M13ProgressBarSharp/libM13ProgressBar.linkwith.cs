using System;
using ObjCRuntime;

[assembly: LinkWith("libM13ProgressBar.a", LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7, SmartLink = true, ForceLoad = true)]
