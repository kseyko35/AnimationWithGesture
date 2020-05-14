using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimationExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimationPage();
        
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
