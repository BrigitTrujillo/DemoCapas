using Buiness;
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
using System.Windows.Shapes;
using Entity;
using Data;

namespace DemoCapas
{
    /// <summary>
    /// Lógica de interacción para ListarCustomer.xaml
    /// </summary>
    public partial class ListarCustomer : Window
    {
        BCustomer customerManager;

        public ListarCustomer()
        {
            InitializeComponent();
            customerManager = new BCustomer();
            dgDemo.ItemsSource = customerManager.ListarCustomer("John Doe");
        }


        public void listarCustomer(object sender, RoutedEventArgs e)
        {
            ListarCustomer listarCustomerWindow = new ListarCustomer();
        }

    }
}
