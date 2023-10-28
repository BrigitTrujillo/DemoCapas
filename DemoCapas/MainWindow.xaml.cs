using Buiness;
using Entity;
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
using static DemoCapas.ListarCustomer;


namespace DemoCapas
{
    public partial class MainWindow : Window
    {
        BCustomer customerManager; 

        public MainWindow()
        {
            InitializeComponent();
            customerManager = new BCustomer(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer
            {
                customer_id = Convert.ToInt32(txtcustomer_id.Text),
                name = txtname.Text,
                address = txtaddress.Text,
                phone = txtphone.Text,
                active = true
            };

            customerManager.InsertarCustomer(customer);
            

        }

        
          private void ListarCustomer_Click(object sender, RoutedEventArgs e)
            {
                ListarCustomer listarCustomer = new ListarCustomer();
               //customerManager.ListarCustomer();
               
            }

        

    }
}

