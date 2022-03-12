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
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();

        }

        private async void configButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Configure());
        }

        private void moreButton_1_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_2_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_3_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_4_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_5_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_6_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_7_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_8_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_9_Clicked(object sender, EventArgs e)
        {

        }

        private void moreButton_10_Clicked(object sender, EventArgs e)
        {

        }
    }
}