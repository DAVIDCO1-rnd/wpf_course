﻿#pragma checksum "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEE6B9EE554F68D4CD740A7566AFED20C72284C1BCF7E09C2C210AECF7D2E752"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Adv_WPF.Toolbar_Ribbon;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Adv_WPF.Toolbar_Ribbon {
    
    
    /// <summary>
    /// wpf_StatusBar
    /// </summary>
    public partial class wpf_StatusBar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_tbox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button st_butt_info;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label count_lbl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox zoom_combo;
        
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
            System.Uri resourceLocater = new System.Uri("/Adv_WPF;component/toolbar_ribbon/wpf_statusbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
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
            this.text_tbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
            this.text_tbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text_tbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.st_butt_info = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
            this.st_butt_info.Click += new System.Windows.RoutedEventHandler(this.st_butt_info_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.count_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.zoom_combo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Toolbar_Ribbon\wpf_StatusBar.xaml"
            this.zoom_combo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

