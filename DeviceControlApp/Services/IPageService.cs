﻿using System;
using System.Threading.Tasks;

namespace DeviceControlApp.ViewModel
{
    public interface IPageService
    {
        Task GoNext(Type viewModelType);
        Task GoNext(object viewModel);
    }
}