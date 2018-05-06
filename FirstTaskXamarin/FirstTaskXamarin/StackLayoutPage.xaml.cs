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
	public partial class StackLayoutPage : ContentPage
	{
		public StackLayoutPage ()
		{
			InitializeComponent ();
		}
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("You can't login now", "", "OK");
        }
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            DisplayAlert("You can't register now", "", "OK");
        }
    }
}