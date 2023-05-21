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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage 
    {
       
        public ClientPage()
        {
           
            InitializeComponent();
            Filter();
        
        }

        public async void Filter()
        {
            List<Model.Client> clients = new List<Model.Client>();
            clients = await AppData.Context.GetAllClient();

            lvClient.ItemsSource = clients;
        }
    }
}
