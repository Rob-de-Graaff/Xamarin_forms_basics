using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples.Part1
{
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");
            //OR
            //valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        }

        private async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked",
                "OK");
        }
    }
}