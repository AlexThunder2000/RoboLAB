﻿#pragma checksum "..\..\Workday.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BAAEBEC3F50BF1B0C086E873AF3ACB49E7B2A6C2851A15B4B7461911A15CBBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using first_try;


namespace first_try {
    
    
    /// <summary>
    /// Workday
    /// </summary>
    public partial class Workday : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Monday;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tuesday;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Wednesday;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Thursday;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Friday;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Saturday;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Workday.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sunday;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/first try;component/workday.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Workday.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\Workday.xaml"
            ((first_try.Workday)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Monday = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Workday.xaml"
            this.Monday.Click += new System.Windows.RoutedEventHandler(this.Monday_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tuesday = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Workday.xaml"
            this.Tuesday.Click += new System.Windows.RoutedEventHandler(this.Tuesday_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Wednesday = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Workday.xaml"
            this.Wednesday.Click += new System.Windows.RoutedEventHandler(this.Wednesday_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Thursday = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Workday.xaml"
            this.Thursday.Click += new System.Windows.RoutedEventHandler(this.Thursday_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Friday = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Workday.xaml"
            this.Friday.Click += new System.Windows.RoutedEventHandler(this.Friday_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Saturday = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Workday.xaml"
            this.Saturday.Click += new System.Windows.RoutedEventHandler(this.Saturday_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Sunday = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Workday.xaml"
            this.Sunday.Click += new System.Windows.RoutedEventHandler(this.Sunday_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

