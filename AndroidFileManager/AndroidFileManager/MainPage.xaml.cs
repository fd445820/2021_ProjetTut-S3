﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidFileManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Documents_Clicked(object sender, EventArgs e)
        {
            PageDetailDossier detail_doc = new PageDetailDossier();
        }
    }
}
