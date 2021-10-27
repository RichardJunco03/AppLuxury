﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLuxury.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anillo : ContentPage
    {
        public Anillo()
        {
            InitializeComponent();
            BindingContext = new ViewModel.HomeViewModel();
        }
    }
}