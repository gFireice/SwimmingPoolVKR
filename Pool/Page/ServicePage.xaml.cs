using Pool.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pool.Page
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage 
    {
        public ServicePage()
        {
            InitializeComponent();
            FilterService();
            FilterSubscribe();
        }

        public async void FilterService()
        {
            List<Model.Service> services = new List<Model.Service>();
            services = await AppData.Context.GetAllService();

            lvService.ItemsSource = services;
        }
        public async void FilterSubscribe()
        {
            List<Model.Subscription> subscriptions = new List<Model.Subscription>();
            subscriptions = await AppData.Context.GetAllSybscribe();

            lvSubscibe.ItemsSource = subscriptions;
        }
    }
}
