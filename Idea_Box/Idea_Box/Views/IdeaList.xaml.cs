using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idea_Box.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IdeaList : ContentPage
	{
		public IdeaList ()
		{
			InitializeComponent ();
            //var vm = new ViewModels.IdeaViewModel();
            //BindingContext = vm;
            //Idea_List.ItemsSource = vm.Ideas;
        }

        private void AddIdeaButton_Tapped(object sender, EventArgs e)
        {

        }
    }
}