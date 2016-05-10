using System;

using UIKit;
using System.Threading.Tasks;
using M13ProgressBar;

namespace M13ProgressBarDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Btn1.TouchUpInside += Btn_1_TouchUpInside;
            this.Btn2.TouchUpInside += Btn_2_TouchUpInside;
        }

        void Btn_2_TouchUpInside(object sender, EventArgs e)
        {
            //            this.NavigationController.FinishProgress();
            //ring.PerformAction(M13ProgressViewAction.Success, true);


        }

        M13ProgressViewRing ring;
        M13ProgressHUD hud;

        async void  Btn_1_TouchUpInside(object sender, EventArgs e)
        {
            try
            {
                this.NavigationController.ShowProgress(); 
            }
            catch (Exception ex)
            {
             
            }
           
            this.NavigationController.SetPrimaryColor(UIColor.Orange);
            this.NavigationController.SetSecondaryColor(UIColor.Green);
            this.NavigationController.SetProgress(.9f, true);
            await Task.Delay(2000);
            this.NavigationController.FinishProgress();
            ring = new M13ProgressViewRing();
            ring.Frame = new CoreGraphics.CGRect(100, 100, 200, 200);
            View.AddSubview(ring);
            ring.BackgroundColor = UIColor.GroupTableViewBackgroundColor;
            ring.PrimaryColor = UIColor.Orange;
            ring.ProgressRingWidth = 4;
            ring.BackgroundRingWidth = 2;
            //            ring.SetProgress(.5f, true);
            ring.Indeterminate = true;
            //
            //            hud = new M13ProgressHUD(new M13ProgressViewRing());
            //            hud.ProgressViewSize = new CoreGraphics.CGSize(80, 80);
            //            hud.AnimationPoint = new CoreGraphics.CGPoint(View.Frame.Width / 2, View.Frame.Height / 2);
            //            hud.Indeterminate = true;
            //            UIApplication.SharedApplication.Delegate.GetWindow().AddSubview(hud);
            //            hud.Show(true);
            //
            //            await Task.Delay(2000);
            //            hud.Hide(true);
        }
    }
}

