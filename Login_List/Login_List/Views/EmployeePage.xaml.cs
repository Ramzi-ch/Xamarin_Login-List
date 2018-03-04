using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_List.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login_List.ViewModels;

namespace Login_List.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeView : ContentPage
	{
		public EmployeeView()
		{
			InitializeComponent ();
            //liaison entre le view et le model view
            var vm = new EmployeeViewModel();
            this.BindingContext = vm;
        }
    }
}