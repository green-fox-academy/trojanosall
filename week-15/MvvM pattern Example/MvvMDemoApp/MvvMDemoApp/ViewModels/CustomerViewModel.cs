using MvvMDemoApp.Models;
using System.Diagnostics;

namespace MvvMDemoApp.ViewModels
{
    public class CustomerViewModel
    {
        private Customer _Customer;

        public Customer Customer
        {
            get { return _Customer; }
        }

        public CustomerViewModel()
        {
            _Customer = new Customer("David");
        }

        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated", Customer.Name));
        }
    }
}
