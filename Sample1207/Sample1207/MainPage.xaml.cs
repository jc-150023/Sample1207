using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample1207
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            this.listView.ItemSource = Enumerable.Range(0, 100).Select(n => $"item-{n}");
		}
	}
}
