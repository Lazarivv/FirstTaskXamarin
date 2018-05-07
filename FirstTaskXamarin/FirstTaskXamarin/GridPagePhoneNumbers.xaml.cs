using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstTaskXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPagePhoneNumbers : ContentPage
	{
		public GridPagePhoneNumbers ()
		{
			InitializeComponent ();
		}
        //void Handle_Clicked(object sender, System.EventArgs e) 
        //{
        //    DisplayAlert("You can't dial now", "", "OK");
        //    //Clicked = "Handle_Clicked"

        //}
    }
}