
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ICT13580015FinalA
{
    public partial class App : Application
    {


        public App(string dbPath)
        {
          
            InitializeComponent();
           
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
            //Handle when your app start
        }
        protected override void OnSleep()
        {

			//Handle when your app sleeps
		}
        protected override void OnResume()
        {
			//Handle when your app resumes
		}
    }
}