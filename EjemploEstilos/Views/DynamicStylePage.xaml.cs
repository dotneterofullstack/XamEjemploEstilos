using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EjemploEstilos.Views
{
    public partial class DynamicStylePage : ContentPage
    {
        bool originalStyle = true;

        public DynamicStylePage()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchStyle"];
        }

        void OnButtonClicked(object sender, EventArgs e) {
            if(originalStyle) {
                Resources["searchBarStyle"] = Resources["greenSearchStyle"];
                originalStyle = false;
            } else {
				Resources["searchBarStyle"] = Resources["blueSearchStyle"];
				originalStyle = true;
            }
        }
    }
}
