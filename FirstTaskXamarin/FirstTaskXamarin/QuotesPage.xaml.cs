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
    public partial class QuotesPage : ContentPage
    {
        int i = 0;
        private string[] _quotes = new string[]
        {
            "Hryshchyshyn Krasava.",
            "Dima Krasva.",
            "Max Krasava."
        };

        public QuotesPage()
        {
            InitializeComponent();
            currentQuoteLabel.Text = _quotes[i];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            i++;
            if (i >= _quotes.Length)
            {
                i = 0;
            }

            currentQuoteLabel.Text = _quotes[i];
        }
    }
}