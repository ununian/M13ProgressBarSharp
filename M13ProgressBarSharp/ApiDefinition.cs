using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace M13ProgressBarSharp
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //

    [Category]
    [BaseType(typeof(UINavigationController))]
    interface UINavigationController_M13ProgressViewBar
    {
        /**Show the progress bar.*/
        //- (void)showProgress;
        [Export("showProgress")]
        void ShowProgress();

        /**Set the progress to display on the progress bar.
        @param progress The progress to display as a percentage from 0-1.
        @param animated Wether or not to animate the change.
        - (void)setProgress:(CGFloat)progress animated:(BOOL)animated;
        */
      
        [Export("setProgress:animated:")]
        void SetProgress(nfloat progress, bool animated);


        /*@param title The string to replace the UINavigationBar's title while showing progress. 
        - (void)setProgressTitle:(NSString *)title;*/
        [Export("setProgressTitle:")]
        void SetProgressTitle(string title);

        //- (void)setIndeterminate:
        [Export("setIndeterminate:")]
        void Setindeterminate(bool indeterminate);

        //- (BOOL)getIndeterminate;
        [Export("getIndeterminate")]
        bool GetIndeterminate();

        //- (void)finishProgress;
        [Export("finishProgress")]
        void FinishProgress();

        [Export("cancelProgress")]
        void CancelProgress();

        [Export("isShowingProgressBar")]
        bool IsShowingProgressBar();

        [Export("setPrimaryColor:")]
        void SetPrimaryColor(UIColor primaryColor);

        [Export("setSecondaryColor:")]
        void SetSecondaryColor(UIColor secondaryColor);
    }

    [BaseType(typeof(UIView))]
    interface M13ProgressView
    {
        [Export("primaryColor", ArgumentSemantic.Retain)]
        UIColor PrimaryColor{ get; set; }

        [Export("secondaryColor", ArgumentSemantic.Retain)]
        UIColor SecondaryColor{ get; set; }

        [Export("indeterminate", ArgumentSemantic.Assign)]
        bool Indeterminate{ get; set; }

        [Export("animationDuration", ArgumentSemantic.Assign)]
        nfloat AnimationDuration{ get; set; }

        [Export("progress")]
        nfloat Progress{ get; }

        [Export("setProgress:animated:")]
        void SetProgress(nfloat progress, bool animated);

        [Export("performAction:animated:")]
        void PerformAction
        (M13ProgressViewAction action, bool animated);
    }

    [BaseType(typeof(M13ProgressView))]
    interface M13ProgressViewRing
    {
        [Export("backgroundRingWidth", ArgumentSemantic.Assign)]
        nfloat BackgroundRingWidth{ get; set; }

        [Export("progressRingWidth", ArgumentSemantic.Assign)]
        nfloat ProgressRingWidth{ get; set; }

        [Export("showPercentage", ArgumentSemantic.Assign)]
        bool ShowPercentage{ get; set; }
    }

    [BaseType(typeof(UIView))]
    interface M13ProgressHUD
    {
        [Export("initWithProgressView:")]
        IntPtr Constructor(M13ProgressView progressView);

        [Export("initAndShowWithProgressView:progress:indeterminate:status:mask:inView:")]
        IntPtr Constructor(M13ProgressView progressView, nfloat progress, bool indeterminate, string status, M13ProgressHUDMaskType maskType, UIView view);

    
        [Export("progressView", ArgumentSemantic.Retain)]
        M13ProgressView ProgressView{ get; set; }

        [Export("primaryColor", ArgumentSemantic.Retain)]
        UIColor PrimaryColor{ get; set; }

        [Export("secondaryColor", ArgumentSemantic.Retain)]
        UIColor SecondaryColor{ get; set; }

        [Export("progress")]
        nfloat Progress{ get; }

        [Export("indeterminate", ArgumentSemantic.Assign)]
        bool Indeterminate{ get; set; }

        [Export("applyBlurToBackground", ArgumentSemantic.Assign)]
        bool ApplyBlurToBackground{ get; set; }


        [Export("hudBackgroundColor", ArgumentSemantic.Retain)]
        UIColor HudBackgroundColor{ get; set; }

        [Export("statusPosition", ArgumentSemantic.Assign)]
        M13ProgressHUDStatusPosition StatusPosition{ get; set; }


        [Export("offsetFromCenter", ArgumentSemantic.Assign)]
        UIOffset OffsetFromCenter{ get; set; }

        [Export("contentMargin", ArgumentSemantic.Assign)]
        nfloat ContentMargin{ get; set; }

        [Export("cornerRadius", ArgumentSemantic.Assign)]
        nfloat CornerRadius{ get; set; }

        [Export("maskType", ArgumentSemantic.Assign)]
        M13ProgressHUDMaskType MaskType{ get; set; }

        [Export("maskColor", ArgumentSemantic.Retain)]
        UIColor MaskColor{ get; set; }

        [Export("statusColor", ArgumentSemantic.Retain)]
        UIColor StatusColor{ get; set; }

        [Export("statusFont", ArgumentSemantic.Retain)]
        UIFont StatusFont{ get; set; }

        [Export("progressViewSize", ArgumentSemantic.Assign)]
        CGSize ProgressViewSize{ get; set; }

        [Export("animationPoint", ArgumentSemantic.Assign)]
        CGPoint AnimationPoint{ get; set; }

        [Export("animationDuration", ArgumentSemantic.Assign)]
        nfloat AnimationDuration{ get; set; }

        [Export("status", ArgumentSemantic.Retain)]
        string Status{ get; set; }

        [Export("minimumSize", ArgumentSemantic.Assign)]
        CGSize MinimumSize{ get; set; }

        [Export("dismissAfterAction", ArgumentSemantic.Assign)]
        bool DismissAfterAction{ get; set; }


        [Export("isVisible")]
        bool IsVisible();

        [Export("shouldAutorotate", ArgumentSemantic.Assign)]
        bool ShouldAutorotate{ get; set; }


        [Export("orientation", ArgumentSemantic.Assign)]
        UIInterfaceOrientation Orientation{ get; set; }

        [Export("setProgress:animated:")]
        void SetProgress(nfloat progress, bool animated);

        [Export("performAction:animated:")]
        void PerformAction(M13ProgressViewAction action, bool animated);


        [Export("show:")]
        void Show(bool animated);

        [Export("hide:")]
        void Hide(bool animated);

        [Export("dismiss:")]
        void Dismiss(bool animated);
    }

    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_M13ProgressHUD
    {
        [Export("progressHUD")]
        M13ProgressHUD ProgressHUD();
    }
}

