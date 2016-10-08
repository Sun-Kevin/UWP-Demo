﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace AdeptlyAdaptiveChallenge
{    
    public sealed partial class ItemTemplate : UserControl
    {
        public Item Item { get { return this.DataContext as Item; } }
        public ItemTemplate()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}
