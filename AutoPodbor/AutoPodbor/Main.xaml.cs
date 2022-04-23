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
            int[] mas = new int[carsList.Count];
            mas = Enumerable.Range(1, carsList.Count-1)
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
            List.ScrollToAsync(0, 140, false);
        }
        

    }
}