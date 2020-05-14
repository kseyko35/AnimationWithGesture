using System;
using Xamarin.Forms;
namespace AnimationExample
{
    public class AnimationPage : ContentPage
    {
        public AnimationPage()
        {
            RelativeLayout layout = new RelativeLayout();
            Image mImage = new Image
            {
                Source = "visa.png"
            };


            Button mRotateButton = new Button
            {
                Text = "Rotater",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Opacity= 0

            };
   
            mImage.GestureRecognizers.Add(new TapGestureRecognizer // Bu sekilde resmimize tap eventi eklemis olduk
            {
               
                Command = new Command(async (obj) =>
                {
                    //while (true)
                    //{
                    //    await mImage.LayoutTo(new Rectangle(1, 150, mImage.Width, mImage.Height), 1250, Easing.SpringIn);
                    //    //await mImage.LayoutTo(new Rectangle(1, 100, mImage.Width, mImage.Height), 1250, Easing.SpringIn);
                    //    await mImage.RotateXTo(360, 1250, Easing.Linear);
                    //    await mImage.RotateXTo(0, 1250, Easing.Linear);
                    //}
                    await mImage.ScaleTo(1, 250, Easing.CubicIn);
                    await mImage.ScaleTo(1, 1250, Easing.CubicInOut);
                    await mImage.LayoutTo(new Rectangle(1, 150, mImage.Width, mImage.Height), 1250, Easing.SpringIn);
                    await mImage.RotateXTo(360, 1250, Easing.Linear);
                    //await DisplayAlert("Title", "Ok", "Cancel");
                    await mRotateButton.FadeTo(1, 250, Easing.Linear);

                } ) 

            } );
            //mRotateButton.IsVisible = true; 
         
            
   
            mRotateButton.Clicked += async (sender, args) => { await mImage.RelRotateTo(360, 1000); };

            layout.Children.Add(mImage, Constraint.Constant(0) , Constraint.RelativeToParent(
                parent => { return parent.Height - 50; }), Constraint.RelativeToParent(
                parent => { return parent.Width; })); // Resmi ekranin ortasina koyabilmemiz icin

            layout.Children.Add(mRotateButton,Constraint.Constant(0),
                Constraint.RelativeToParent(parent => { return parent.Height - 100; }),
                Constraint.RelativeToParent(parent => { return parent.Width; }));
            Content = layout;
        }

    }
}
