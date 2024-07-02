using AutoMapper;
using BusinessLogic;
using DataAccess.DAO;
using DataAccess.Models;
using DataAccess.Repository.Interface;
using Lombok.NET;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    public partial class MainWindow : Window
    {
        private readonly OrderDAO dao;
        private readonly IMapper mapper;
        public MainWindow(OrderDAO dao, IMapper mapper)
        {
            InitializeComponent();
            this.dao = dao;
            this.mapper = mapper;

            List<Order> orders = dao.getOrders();
            foreach (Order order in orders.Take(3))
            {
                OrderObject orderObject = mapper.Map<OrderObject>(order);
                MessageBox.Show(orderObject.ToString());
            }
        }
    }
}