using CommonMvvm;
using MasterDetail.Business;
using MasterDetail.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.UI
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string WindowTitle { get; set; }

        public ObservableCollection<OrderViewModel> Orders { get; set; }

        private OrderViewModel selectedOrder;
        public OrderViewModel SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                RaisePropertyChanged();
            }
        }

        private LineItemViewModel selectedLineItem;
        public LineItemViewModel SelectedLineItem
        {
            get { return selectedLineItem; }
            set
            {
                if (selectedLineItem != value)
                {
                    selectedLineItem = value;
                    RaisePropertyChanged();
                    LineItemDetailsCommand.RaiseCanExecuteChanged();
                }
                
            }
        }
        
        public CommandBase<LineItemViewModel> LineItemDetailsCommand { get; set; }

        public MainWindowViewModel()
        {
            WindowTitle = "My Main Window";

            Orders = new ObservableCollection<OrderViewModel>()
            {
                new OrderViewModel()
                {
                    ID = 101,
                    CustomerName = "Tony",
                    OrderNumber = 123,
                    LineItems = new ObservableCollection<LineItemViewModel>()
                    {
                        new LineItemViewModel() { ID = 201, Cost = 500, PartNumber = "ABC123", Quantity = 3 },
                        new LineItemViewModel() { ID = 202, Cost = 450, PartNumber = "DEF456", Quantity = 7 },
                        new LineItemViewModel() { ID = 202, Cost = 450, PartNumber = "GHI789", Quantity = 5 }
                    }
                },
                new OrderViewModel()
                {
                    ID = 102,
                    CustomerName = "Frank",
                    OrderNumber = 124,
                    LineItems = new ObservableCollection<LineItemViewModel>()
                    {
                        new LineItemViewModel() { ID = 203, Cost = 200, PartNumber = "AAA111", Quantity = 11 }
                    }
                },
                new OrderViewModel()
                {
                    ID = 102,
                    CustomerName = "Lisa",
                    OrderNumber = 126,
                    LineItems = new ObservableCollection<LineItemViewModel>()
                    {
                        new LineItemViewModel() { ID = 204, Cost = 20, PartNumber = "AAA111", Quantity = 3 },
                        new LineItemViewModel() { ID = 205, Cost = 1100, PartNumber = "BBB222", Quantity = 17 }
                    }
                }
            };

            LineItemDetailsCommand = new CommandBase<LineItemViewModel>(ExecuteLineItemDetails, CanExecuteLineItemDetails, "View LineItemDetails");
        }

        private bool CanExecuteLineItemDetails(LineItemViewModel obj)
        {
            if (selectedLineItem != null)
            {
                return true;
            }
            return false;
        }

        private void ExecuteLineItemDetails(LineItemViewModel obj)
        {
            
        }
    }
}