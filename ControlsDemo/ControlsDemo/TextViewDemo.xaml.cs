using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextViewDemo : ContentPage
	{
		public TextViewDemo()
		{
			InitializeComponent();
		}

		private void inputName_TextChanged(object sender, TextChangedEventArgs e)
		{
			//Debug.WriteLine(inputName.Text);
		}

		private void inputName_Completed(object sender, EventArgs e)
		{
			Debug.WriteLine(inputName.Text);
		}
	}
}