﻿#pragma checksum "c:\users\matt mccormick\documents\visual studio 2010\Projects\WhereFi\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2791E1244DA9950EDF0448919AE8917C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WhereFi {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivWhereFi;
        
        internal Microsoft.Phone.Controls.PivotItem pviMapView;
        
        internal Microsoft.Phone.Controls.Maps.Map mapWhereFi;
        
        internal Microsoft.Phone.Controls.PivotItem pviListView;
        
        internal System.Windows.Controls.ListBox lstWhereFi;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mnuToggleLocation;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhereFi;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivWhereFi = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivWhereFi")));
            this.pviMapView = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pviMapView")));
            this.mapWhereFi = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("mapWhereFi")));
            this.pviListView = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pviListView")));
            this.lstWhereFi = ((System.Windows.Controls.ListBox)(this.FindName("lstWhereFi")));
            this.mnuToggleLocation = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mnuToggleLocation")));
        }
    }
}

