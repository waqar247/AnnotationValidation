using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validationEntries.ViewModels;
using Xamarin.Forms;

namespace validationEntries
{
	public partial class MainPage : ContentPage
	{
        FirstPageViewModel first;
        public MainPage()
		{
			InitializeComponent();
            first = new FirstPageViewModel();
            BindingContext = first;
		}
	}
}
