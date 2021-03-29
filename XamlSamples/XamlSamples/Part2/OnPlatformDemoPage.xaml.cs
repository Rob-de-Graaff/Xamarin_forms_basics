using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlSamples.Part2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnPlatformDemoPage : ContentPage
    {
        public OnPlatformDemoPage()
        {
            InitializeComponent();
        }
    }
}