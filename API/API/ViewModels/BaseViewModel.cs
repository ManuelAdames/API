using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using API.Services;

namespace API.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected IAlertService AlertService { get; }
        protected BaseViewModel(IAlertService alertService)
        {
            AlertService = alertService;
        }
    }
}
