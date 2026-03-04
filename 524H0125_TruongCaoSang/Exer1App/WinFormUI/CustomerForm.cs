using BLL;
using DAL;
using System.Xml.Linq;
namespace WinFormUI
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public CustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void bAddCus_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = NameCustomer.Text,
                Email = Email.Text
            };
            _customerService.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
        }

        private void bGetCus_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(CustomerID.Text);
            var customer =
            _customerService.GetCustomer(customerId);
            if (customer != null)
            {
                NameCustomer.Text = customer.Name;
                Email.Text = customer.Email;
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }
    }
}
