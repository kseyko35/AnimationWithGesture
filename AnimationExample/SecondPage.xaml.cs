using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AnimationExample
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        void onClickImage(System.Object sender, System.EventArgs e)
        {
            var tap = e as TappedEventArgs;
            DisplayAlert("Gesture Example!", tap.Parameter.ToString(), "Cancel");
            
        }

        void onClickLabel(System.Object sender, System.EventArgs e)
        {
            var tap = (TappedEventArgs)e;
         
            var label =(Label)sender;
            
            DisplayAlert("Gesture Example!", tap.Parameter.ToString(), "Cancel");
            label.Text = "You clicked Me!";
            label.BackgroundColor = Color.FromHex("#3497db");
            label.TextColor = Color.White;

        }
    }
}
