using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private List<Car> carsList = new List<Car>();
        private Random RND = new Random();
        
        public Main()
        {
            InitializeComponent();
            
            Car car = new Car();
            carsList = car.ReadCars(carsList);
            RandomViewCars();
        }
        private void RandomViewCars()
        {
            try
            {
                int[] mas = new int[carsList.Count];
                mas = Enumerable.Range(1, carsList.Count - 1)
                .OrderBy(_ => RND.NextDouble())
                .Take(10).ToArray();

                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        NameLabel_1.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_1.Text = carsList[mas[i]].Description;
                        AutoImg_1.Source = carsList[mas[i]].UrlImg;

                    }
                    if (i == 1)
                    {
                        NameLabel_2.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_2.Text = carsList[mas[i]].Description;
                        AutoImg_2.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 2)
                    {
                        NameLabel_3.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_3.Text = carsList[mas[i]].Description;
                        AutoImg_3.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 3)
                    {
                        NameLabel_4.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_4.Text = carsList[mas[i]].Description;
                        AutoImg_4.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 4)
                    {
                        NameLabel_5.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_5.Text = carsList[mas[i]].Description;
                        AutoImg_5.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 5)
                    {
                        NameLabel_6.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_6.Text = carsList[mas[i]].Description;
                        AutoImg_6.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 6)
                    {
                        NameLabel_7.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_7.Text = carsList[mas[i]].Description;
                        AutoImg_7.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 7)
                    {
                        NameLabel_8.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_8.Text = carsList[mas[i]].Description;
                        AutoImg_8.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 8)
                    {
                        NameLabel_9.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_9.Text = carsList[mas[i]].Description;
                        AutoImg_9.Source = carsList[mas[i]].UrlImg;
                    }
                    if (i == 9)
                    {
                        NameLabel_10.Text = carsList[mas[i]].Mark + " " + carsList[mas[i]].Generation;
                        DiscriptionLabel_10.Text = carsList[mas[i]].Description;
                        AutoImg_10.Source = carsList[mas[i]].UrlImg;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR!!!");
            }
        }

        private void PriceUpViewCars()
        {
            
            List<Car> sortedCars =  carsList.OrderBy(x => x.Price).ToList();
            InputCars(sortedCars);
        }
        private void PriceDownViewCars()
        {

            List<Car> sortedCars = carsList.OrderByDescending(x => x.Price ).ToList();
            InputCars(sortedCars);
        }
        private void YearDownViewCars()
        {

            List<Car> sortedCars = carsList.OrderByDescending(x => x.YearEnd).ToList();
            InputCars(sortedCars);
        }
        private void YearUpViewCars()
        {

            List<Car> sortedCars = carsList.OrderBy(x => x.YearEnd).ToList();
            InputCars(sortedCars);
        }


        private void InputCars(List<Car> sortedCars)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    NameLabel_1.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_1.Text = sortedCars[i].Description;
                    AutoImg_1.Source = sortedCars[i].UrlImg;
                }
                if (i == 1)
                {
                    NameLabel_2.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_2.Text = sortedCars[i].Description;
                    AutoImg_2.Source = sortedCars[i].UrlImg;
                }
                if (i == 2)
                {
                    NameLabel_3.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_3.Text = sortedCars[i].Description;
                    AutoImg_3.Source = sortedCars[i].UrlImg;
                }
                if (i == 3)
                {
                    NameLabel_4.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_4.Text = sortedCars[i].Description;
                    AutoImg_4.Source = sortedCars[i].UrlImg;
                }
                if (i == 4)
                {
                    NameLabel_5.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_5.Text = sortedCars[i].Description;
                    AutoImg_5.Source = sortedCars[i].UrlImg;
                }
                if (i == 5)
                {
                    NameLabel_6.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_6.Text = sortedCars[i].Description;
                    AutoImg_6.Source = sortedCars[i].UrlImg;
                }
                if (i == 6)
                {
                    NameLabel_7.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_7.Text = sortedCars[i].Description;
                    AutoImg_7.Source = sortedCars[i].UrlImg;
                }
                if (i == 7)
                {
                    NameLabel_8.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_8.Text = sortedCars[i].Description;
                    AutoImg_8.Source = sortedCars[i].UrlImg;
                }
                if (i == 8)
                {
                    NameLabel_9.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_9.Text = sortedCars[i].Description;
                    AutoImg_9.Source = sortedCars[i].UrlImg;
                }
                if (i == 9)
                {
                    NameLabel_10.Text = sortedCars[i].Mark + " " + sortedCars[i].Generation;
                    DiscriptionLabel_10.Text = sortedCars[i].Description;
                    AutoImg_10.Source = sortedCars[i].UrlImg;
                }
            }
        }

        private async void configButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Configure());
        }

        private async void moreButton_1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark +" " + x.Generation)  == NameLabel_1.Text).ToList()[0]));
        }

        private async void moreButton_2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_2.Text).ToList()[0]));

        }

        private async void moreButton_3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_3.Text).ToList()[0]));

        }

        private async void moreButton_4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_4.Text).ToList()[0]));

        }

        private async void moreButton_5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_5.Text).ToList()[0]));

        }

        private async void moreButton_6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_6.Text).ToList()[0]));
        }

        private async void moreButton_7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_7.Text).ToList()[0]));

        }

        private async void moreButton_8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_8.Text).ToList()[0]));

        }

        private async void moreButton_9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_9.Text).ToList()[0]));

        }

        private async void moreButton_10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MoreInfo(carsList.FindAll(x => (x.Mark +" " + x.Generation)  == NameLabel_10.Text).ToList()[0]));
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == 0)
                RandomViewCars();
            if (picker.SelectedIndex == 1)
                PriceUpViewCars();
            if (picker.SelectedIndex == 2)
                PriceDownViewCars();
            if (picker.SelectedIndex == 3)
                YearDownViewCars();
            if (picker.SelectedIndex == 4)
                YearUpViewCars();

        }

        private void nextFrames_Clicked(object sender, EventArgs e)
        {
            RandomViewCars();
            List.ScrollToAsync(0, 140, true);
        }

        private void addFavarite1_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_1.Text).ToList()[0].Id);
            addFavarite1.IsVisible = false;
        }

        private void addFavarite2_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_2.Text).ToList()[0].Id);
            addFavarite2.IsVisible = false;
        }

        private void addFavarite3_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_3.Text).ToList()[0].Id);
            addFavarite3.IsVisible = false;
        }

        private void addFavarite4_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_4.Text).ToList()[0].Id);
            addFavarite4.IsVisible = false;
        }

        private void addFavarite5_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_5.Text).ToList()[0].Id);
            addFavarite5.IsVisible = false;
        }

        private void addFavarite6_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_6.Text).ToList()[0].Id);
            addFavarite6.IsVisible = false;
        }

        private void addFavarite7_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_7.Text).ToList()[0].Id);
            addFavarite7.IsVisible = false;
        }

        private void addFavarite8_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_8.Text).ToList()[0].Id);
            addFavarite8.IsVisible = false;
        }

        private void addFavarite9_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_9.Text).ToList()[0].Id);
            addFavarite9.IsVisible = false;
        }

        private void addFavarite10_Clicked(object sender, EventArgs e)
        {
            Account.AddFavorite(MainPage.login, carsList.FindAll(x => (x.Mark + " " + x.Generation) == NameLabel_10.Text).ToList()[0].Id);
            addFavarite10.IsVisible = false;
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            List<string> cars = new List<string>();
            foreach (var item in carsList.FindAll(x => x.Mark == search.Text).ToList())
            {
                cars.Add(item.Mark + item.Model);
            }
           // string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null,cars.ForEach(p=>p.ToString()));
        }
    }
}