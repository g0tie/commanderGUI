﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private string _directoryPath = @"c:\Example";
        public string DirectoryPath
        {
            get => _directoryPath;
            set {
                _directoryPath = value;
            }
        }


    }

    
}
