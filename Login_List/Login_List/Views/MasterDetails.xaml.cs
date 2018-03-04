using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_List.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetails : MasterDetailPage //ContentPage
	{
		public MasterDetails ()
		{
			InitializeComponent ();
		}
	}
}