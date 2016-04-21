using CommonMvvm;
using MasterDetail.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.UI.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        private Order order = new Order();

        public OrderViewModel()
        {

        }

        public int ID
        {
            get { return this.order.ID; }
            set
            {
                if (this.order.ID != value)
                {
                    this.order.ID = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int OrderNumber
        {
            get { return this.order.OrderNumber; }
            set
            {
                if (this.order.OrderNumber != value)
                {
                    this.order.OrderNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string CustomerName
        {
            get { return this.order.CustomerName; }
            set
            {
                if (this.order.CustomerName != value)
                {
                    this.order.CustomerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ObservableCollection<LineItem> LineItems { get; set; } = new ObservableCollection<LineItem>();
    }
}