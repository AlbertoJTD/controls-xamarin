using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InputsViewDemo : ContentPage
	{
		public InputsViewDemo()
		{
			InitializeComponent();
		}

		private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			lbSlider.Text = sliderControl.Value.ToString();
        }

		private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			lbSlider.Text = stepper.Value.ToString();
			sliderControl.Value = stepper.Value;
		}

		private void Switch_Toggled(object sender, ToggledEventArgs e)
		{
			DisplayAlert("Toggle", $"Toggle: {e.Value}", "Ok");
		}
	}
}