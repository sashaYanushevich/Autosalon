using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoPodbor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginingProfile : ContentPage
    {
        public LoginingProfile()
        {
            InitializeComponent();
            nameText.Text = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "accountInfo"));
        }

        private void exitButton_Clicked(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "accountInfo"));
            (Application.Current).MainPage = new MainPage();

        }

        private void adminButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}