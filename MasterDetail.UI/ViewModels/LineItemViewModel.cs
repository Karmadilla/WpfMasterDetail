using CommonMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MasterDetail.Business;

namespace MasterDetail.UI.ViewModels
{
    public class LineItemViewModel : ViewModelBase
    {
        private LineItem lineItem;

        public int ID
        {
            get { return this.lineItem.ID; }
            set
            {
                if (this.lineItem.ID != value)
                {
                    this.lineItem.ID = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int Quantity
        {
            get { return this.lineItem.Quantity; }
            set
            {
                if (this.lineItem.Quantity != value)
                {
                    this.lineItem.Quantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string PartNumber
        {
            get { return this.lineItem.PartNumber; }
            set
            {
                if (this.lineItem.PartNumber != value)
                {
                    this.lineItem.PartNumber = value;
                    RaisePropertyChanged();
                }
            }
        }
        
        public int Cost
        {
            get { return this.lineItem.Cost; }
            set
            {
                if (this.lineItem.Cost != value)
                {
                    this.lineItem.Cost = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}