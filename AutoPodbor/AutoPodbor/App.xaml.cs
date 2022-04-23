using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCLStorage;

namespace AutoPodbor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //Debug.WriteLine("\n\n------------------------------------------\n\n" + folderPath+ "\n");
            //File.WriteAllText(Path.Combine(folderPath, "testCache"), "test123");
            String filename ="username.txt";
            IFolder folder = FileSystem.Current.LocalStorage;
            IFile file = await folder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
