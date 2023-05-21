using Pool.Class;
using Pool.Model;
using Pool.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow 
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            try
            {
                InitializeComponent();
                AppData.updateContext();
                AppData.Context.RunAsync().GetAwaiter().GetResult();

               
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером!" +
                    "\nПожалуйста, запустите сервер заново запустите приложение!",
                    "Ошибка", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }

        private void ShowPasvordCheak_Checked(object sender, RoutedEventArgs e)
        {
            PasswordBoxAuth.Visibility = Visibility.Collapsed; 
            TextBoxAuth.Visibility = Visibility.Visible; 
  
            TextBoxAuth.Text = new NetworkCredential(string.Empty, PasswordBoxAuth.SecurePassword).Password;
            
            TextBoxAuth.Focus();
        }

        private void ShowPasvordCheak_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBoxAuth.Visibility = Visibility.Visible; 
            TextBoxAuth.Visibility = Visibility.Collapsed;
           
            PasswordBoxAuth.Password=TextBoxAuth.Text;
          
            PasswordBoxAuth.Focus();
        }
        public async void Eployes()
        {
            List<Model.Employess> employesse = new List<Model.Employess>();
            try
            {
                employesse = await AppData.Context.GetAllEmplooyes();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером!" +
                    "\nПожалуйста, запустите сервер заново запустите приложение!",
                    "Ошибка", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
            foreach (Model.Employess employee in employesse)
            {
                if (employee.login == LoginBox.Text && (employee.password == PasswordBoxAuth.Password || TextBoxAuth.Text== employee.password))
                {
                    // Авторизация прошла успешно 
                    AuthUser.User = employee;
                    NavigationService.Navigate(new Page.MainPage());
                    break;
                }
                
            }
            if (AuthUser.User == null)
            {
                MessageBox.Show("Не верный пароль или логин");
            }
            
        }

        private void ButtonNavigateMain_Click(object sender, RoutedEventArgs e)
        {
           Eployes();
           
        }
    }
}
