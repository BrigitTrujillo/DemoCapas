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
namespace DemoCapas;

public partial class ListarCustomer : Window
{
    private BCustomer customerManager;

    public ListarCustomer()
    {
        InitializeComponent();
        customerManager = new BCustomer();
        MostrarClientesEnLista();
    }

    internal void ShowDialog()
    {
        throw new NotImplementedException();
    }

    private void MostrarClientesEnLista()
    {
        List<Customer> listarCustomer = customerManager.ListarCustomer();
        foreach (Customer customer in listarCustomer)
        {
            customerListView.Items.Add(customer);
        }
    }
}
