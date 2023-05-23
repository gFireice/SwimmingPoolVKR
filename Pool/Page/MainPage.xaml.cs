using Pool.Api;
using Pool.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pool.Page
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage 
    {


        public MainPage()
        {
            InitializeComponent();
            
            NavigationFrame.Content = new Page.ClientPage();
            BtnBorderClient.Visibility = Visibility.Visible;
            NavigatinControl.MainFrame = this.NavigationFrame;
            FormFilter();


            
        }

        public async void FormFilter()
        {
            FioTxtBox.Text = AuthUser.User.FirstName + " " + AuthUser.User.LastName + " " + AuthUser.User.SurName;

            byte[] imageData = AppData.Context.GetImage(AuthUser.User.image);// массив байт содержащий изображение
            if (imageData != null )
            {
                BitmapImage bitmap = new BitmapImage();  // создание нового экземпляра BitmapImage
                bitmap.BeginInit();  // начало инициализации BitmapImage
                bitmap.CreateOptions = BitmapCreateOptions.None;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.Rotation = Rotation.Rotate0;
                bitmap.StreamSource = new MemoryStream(imageData); // загрузка изображения из массива байт
                bitmap.EndInit(); // завершение инициализации BitmapImage
                ImageSource imageSource = bitmap; // приведение BitmapImage к типу ImageSource
                BrImUser.ImageSource = imageSource;
            }


            switch (AuthUser.User.TypeOfEmployessID)
            {
                case 1:
                    
                    break;

                case 2:
                    ButtonTrain.Visibility = Visibility.Collapsed;
                    ButtonOrder.Visibility = Visibility.Collapsed;
                    ButtonStatistic.Visibility = Visibility.Collapsed;

                    break;

                case 3:
                    ServiceButton.Visibility = Visibility.Collapsed;
                    ButtonTrain.Visibility = Visibility.Collapsed;
              BottonEmployes.Visibility = Visibility.Collapsed;
                    break;

                case 4:
                    ButtonStatistic.Visibility = Visibility.Collapsed;
                    ServiceButton.Visibility = Visibility.Collapsed;
                    ButtonOrder.Visibility = Visibility.Collapsed;
                    BottonEmployes.Visibility = Visibility.Collapsed;
                    break;
            }
        }
            private void BottonClient_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Visible;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Hidden;
           NavigationFrame.Content = new Page.ClientPage();
        }

        private void ButtonTrain_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Visible;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Hidden;
        }

        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Visible;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Hidden;
            NavigationFrame.Content = new Page.ServicePage();
        }

        private void ButtonSetting_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Visible;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Hidden;
        }

        private void ButtonStatistic_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Visible;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Hidden;
            NavigationFrame.Content = new Page.StatisticPage();

        }


        private void BottonEmployes_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Visible;
            BtnBorderOrder.Visibility = Visibility.Hidden;
            NavigationFrame.Content = new Page.EmployessPage();
        }

        private void ButtonOrder_Click(object sender, RoutedEventArgs e)
        {
            BtnBorderClient.Visibility = Visibility.Hidden;
            BtnBorderSeting.Visibility = Visibility.Hidden;
            BtnBorderSr.Visibility = Visibility.Hidden;
            BtnBorderSt.Visibility = Visibility.Hidden;
            BtnBorderTr.Visibility = Visibility.Hidden;
            BtnBorderEmployes.Visibility = Visibility.Hidden;
            BtnBorderOrder.Visibility = Visibility.Visible;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AuthUser.User = null;
            NavigationService.Navigate(new Page.AuthorizationWindow());
        }

     


    }
}


