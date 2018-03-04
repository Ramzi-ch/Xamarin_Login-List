using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_List.ViewModels;
using Xamarin.Forms;

namespace Login_List
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            //liaison entre view et view model (on peut faire dans le xaml mais ici psk on a utilisé le display)
            var vm = new AdminViewModel();
            this.BindingContext = vm;
            
            //Pour que le Display sera connu dans MainViewModel.cs
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login", "OK");
            vm.DisplayValidLoginPrompt += () => DisplayAlert("Welcome", "valid Login", "OK");
        }
	}
}
