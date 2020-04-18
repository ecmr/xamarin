﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ConsultarCep.TipoPasta.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
    {
		public Abas ()
		{
			InitializeComponent ();

            Children.Add(new NavigationPage(new TipoPasta.Navigation.Pagina1()) { Title="Item 3" });
		}
	}
}