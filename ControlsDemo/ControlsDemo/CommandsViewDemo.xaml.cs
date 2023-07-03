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
	public partial class CommandsViewDemo : ContentPage
	{
		public CommandsViewDemo()
		{
			InitializeComponent();
		}

		private void btnTest_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("My alert", "Hello world", "Ok");
		}

		private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			DisplayAlert("Radiobutton", $"Changed: {e.Value}", "Ok");
		}

		private void SearchControl_SearchButtonPressed(object sender, EventArgs e)
		{
			// SearchControl -> Name assigned to the control
			DisplayAlert("Serching", $"Serching: {SearchControl.Text}", "Ok");
		}

		private void SwipeItem_Invoked(object sender, EventArgs e)
		{
			DisplayAlert("SwipeView", "Element tapped", "Ok");
		}
	}
}