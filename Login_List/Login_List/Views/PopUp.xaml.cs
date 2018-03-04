using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_List.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_List.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUp : ContentPage
	{
		public PopUp (String Name, String Departement)
		{
			InitializeComponent ();
            var vm = new PopUpViewModel();
            this.BindingContext = vm;
            N.Text = Name;
            D.Text = Departement;
        }
	}
}