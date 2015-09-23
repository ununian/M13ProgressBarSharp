using System;


namespace M13ProgressBarSharp
{

    //    typedef enum {
    //        M13ProgressViewBarPercentagePositionLeft,
    //        M13ProgressViewBarPercentagePositionRight,
    //        M13ProgressViewBarPercentagePositionTop,
    //        M13ProgressViewBarPercentagePositionBottom,
    //    } M13ProgressViewBarPercentagePosition;
    //
    //    typedef enum {
    //        M13ProgressViewBarProgressDirectionLeftToRight,
    //        M13ProgressViewBarProgressDirectionBottomToTop,
    //        M13ProgressViewBarProgressDirectionRightToLeft,
    //        M13ProgressViewBarProgressDirectionTopToBottom
    //    } M13ProgressViewBarProgressDirection;

    public enum M13ProgressViewBarPercentagePosition
    {
        Left,
        Right,
        Top,
        Bottom
    }

    public enum M13ProgressViewBarProgressDirection
    {
        LeftToRight,
        BottomToTop,
        RightToLeft,
        TopToBottom
    }

    //    typedef enum {
    //        /**Resets the action and returns the progress view to its normal state.*/
    //        M13ProgressViewActionNone,
    //        /**The progress view shows success.*/
    //        M13ProgressViewActionSuccess,
    //        /**The progress view shows failure.*/
    //        M13ProgressViewActionFailure
    //    } M13ProgressViewAction;

    public enum M13ProgressViewAction
    {
        None,
        Success,
        Failure
    }

    public enum M13ProgressHUDStatusPosition
    {
        BelowProgress,
        AboveProgress,
        LeftOfProgress,
        RightOfProgress
    }

    public enum M13ProgressHUDMaskType
    {
        None,
        SolidColor,
        Gradient,
        IOS7Blur
    }
}

