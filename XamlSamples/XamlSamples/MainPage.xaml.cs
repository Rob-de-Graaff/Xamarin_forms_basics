using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamlSamples.Part1;
using XamlSamples.Part2;
using XamlSamples.Part3;
using XamlSamples.Part4;

namespace XamlSamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                //await Navigation.PushAsync(new HelloXamlPage());
                //await Navigation.PushAsync(new XamlPlusCodePage());
                //await Navigation.PushAsync(new GridDemoPage());
                //await Navigation.PushAsync(new AbsoluteDemoPage());
                //await Navigation.PushAsync(new OnPlatformDemoPage());
                //await Navigation.PushAsync(new SharedResourcesPage());
                //await Navigation.PushAsync(new StaticConstantsPage());
                //await Navigation.PushAsync(new RelativeLayoutPage());
                //await Navigation.PushAsync(new SliderBindingsPage());
                //await Navigation.PushAsync(new SliderTransformsPage());
                await Navigation.PushAsync(new ListViewDemoPage());
            };

            Content = button;
        }
    }
}