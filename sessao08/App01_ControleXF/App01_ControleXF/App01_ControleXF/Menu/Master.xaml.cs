using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityIndicator(object sender, EventArgs args)
        {
            if ((sender as Button).Text == "START")
            {
                Detail = new Controles.ActivityIndicatorPage();
                (sender as Button).BackgroundColor = new Color(255, 0, 0);
                (sender as Button).Text = "STOP";
                (sender as Button).TextColor = new Color(0, 0, 0);
            }
            else
            {
                Detail = new Controles.ActivityIndicatorPage();
                Detail.IsVisible = false;
                (sender as Button).BackgroundColor = new Color(0, 255, 0);
                (sender as Button).Text = "START";
                (sender as Button).TextColor = new Color(0, 0, 0);
            }
        }

        private void GoProgressBar(object sender, EventArgs args)
        {
            if ((sender as Button).Text == "START")
            {
                Detail = new Controles.ProgressBarPage();
                (sender as Button).BackgroundColor = new Color(255, 0, 0);
                (sender as Button).Text = "STOP";
                (sender as Button).TextColor = new Color(0, 0, 0);
            }
            else
            {
                Detail = new Controles.ProgressBarPage();
            //    Detail.IsVisible = false;
                (sender as Button).BackgroundColor = new Color(0, 255, 0);
                (sender as Button).Text = "START";
                (sender as Button).TextColor = new Color(0, 0, 0);
            }
        }

        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new Controles.BoxViewPAge();
        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new Controles.LabelPage();
        }

        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new Controles.ButtonPage();
        }

        private void GoEntryPage(object sender, EventArgs args)
        {
            Detail = new Controles.EntryEditorPage();
        }
    }
}