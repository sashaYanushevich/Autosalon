using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoPodbor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPanel : ContentPage
    {
        List<Request> req = Request.ReadRequests();
        public AdminPanel()
        {
            InitializeComponent();
            
            requestsList.ItemsSource = req.Select(n => n.ListViewText);
        }

        private async void requestsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("1",$"{req[e.ItemIndex].Id} \n {req[e.ItemIndex].Login}","ok");
        }
    }
}