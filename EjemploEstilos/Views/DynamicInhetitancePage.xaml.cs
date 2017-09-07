using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EjemploEstilos.Views
{
    public partial class DynamicInhetitancePage : ContentPage
    {
		bool originalStyle = true;

		public DynamicInhetitancePage()
		{
			InitializeComponent();
			Resources["searchBarStyle"] = Resources["blueSearchBar"];
		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			if (originalStyle)
			{
				Resources["searchBarStyle"] = Resources["greenSearchBar"];
				originalStyle = false;
			}
			else
			{
				Resources["searchBarStyle"] = Resources["blueSearchBar"];
				originalStyle = true;
			}
		}
    }
}
