﻿#pragma checksum "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F895D6039B2AEB5465E7C6722EA83C95362B4F8FC8F0B37CECDEF6E39A2A0E66"
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
    /// wpf_tab_control
    /// </summary>
    public partial class wpf_tab_control : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tab_ctl;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sel_tab_item_lbl;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tab_ctl_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Adv_WPF;component/toolbar_ribbon/wpf_tab_control.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
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
            this.tab_ctl = ((System.Windows.Controls.TabControl)(target));
            
            #line 11 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
            this.tab_ctl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tab_ctl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sel_tab_item_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tab_ctl_Copy = ((System.Windows.Controls.TabControl)(target));
            
            #line 49 "..\..\..\Toolbar_Ribbon\wpf_tab_control.xaml"
            this.tab_ctl_Copy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tab_ctl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

